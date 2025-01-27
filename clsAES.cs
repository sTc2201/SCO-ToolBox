using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using Microsoft.Win32;
using System.Diagnostics;

namespace SCOToolBox
{
    class AES
    {
        public static byte[] GetKey()
        {
            string dir = null;
            string exe = null;

            try {

            if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "GTAIV.exe")))
            {
                dir = Directory.GetCurrentDirectory();
                exe = "GTAIV.exe";
            }
            else if (File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "EFLC.exe")))
            {
                dir = Directory.GetCurrentDirectory();
                exe = "EFLC.exe";
            }
            else
            {
                const string Key32 = @"SOFTWARE\Rockstar Games\Grand Theft Auto IV";
                const string Key64 = @"SOFTWARE\Wow6432Node\Rockstar Games\Grand Theft Auto IV";
                const string Key32E = @"SOFTWARE\Rockstar Games\EFLC";
                const string Key64E = @"SOFTWARE\Wow6432Node\Rockstar Games\EFLC";
                const string ValueName = "InstallFolder";

                RegistryKey key;
                if ((key = Registry.LocalMachine.OpenSubKey(Key32)) != null ||
                    (key = Registry.LocalMachine.OpenSubKey(Key64)) != null)
                {
                    dir = key.GetValue(ValueName).ToString();
                    exe = "GTAIV.exe";
                }
                else if ((key = Registry.LocalMachine.OpenSubKey(Key32E)) != null ||
                    (key = Registry.LocalMachine.OpenSubKey(Key64E)) != null)
                {
                    dir = key.GetValue(ValueName).ToString();
                    exe = "EFLC.exe";
                }
            }

            return FindKey(dir, exe);

            } catch { return null; }
        }

        private static byte[] FindKey(string gtaPath, string gtaExe)
        {
            gtaExe = Path.Combine(gtaPath, gtaExe);

            try {
                uint[] searchOffsets = {
                    //EFIGS EXEs
                    0xA94204, /* 1.0.0.0 */ 
                    0xB607C4, /* 1.0.1.0 */ 
                    0xB56BC4, /* 1.0.2.0 */
                    0xB75C9C, /* 1.0.3.0 */
                    0xB7AEF4, /* 1.0.4.0 */
                    0xBE1370, /* 1.0.4.0r2 */
                    0xBE6540, /* 1.0.6.0 */
                    0xBE7540, /* 1.0.7.0 */
                    0xC95FD8, /* 1.0.8.0, same fore RUS/JPN EXEs */
                    0xC5B73C, /* 1.2.0.59, Steam/CE (Complete Edition) */
                    //Russian EXEs
                    0xB5B65C, /* 1.0.0.1 */
                    0xB569F4, /* 1.0.1.1 */
                    0xB76CB4, /* 1.0.2.1 */
                    0xB7AEFC, /* 1.0.3.1 */
                    //Japan EXEs
                    0xB8813C, /* 1.0.1.2 */
                    0xB8C38C, /* 1.0.2.2 */
                    0xBE6510, /* 1.0.5.2 */
                    //EFLC
                    0xC6DEEC, /* 1.1.0.0 */
                    0xC705E0, /* 1.1.1.0 */
                    0xBEF028, /* 1.1.2.0 */
                    0xB82A28  /* 1.1.3.0 */
                    
                };
                const string validHash = "DEA375EF1E6EF2223A1221C2C575C47BF17EFA5E";
                byte[] key = null;

                var fs = new FileStream(gtaExe, FileMode.Open, FileAccess.Read);

                foreach (var u in searchOffsets)
                {
                    if (u <= fs.Length - 32)
                    {
                        var tempKey = new byte[32];
                        fs.Seek(u, SeekOrigin.Begin);
                        fs.Read(tempKey, 0, 32);

                        var hash = BitConverter.ToString(SHA1.Create().ComputeHash(tempKey)).Replace("-", "");
                        if (hash == validHash)
                        {
                            key = tempKey;
                            break;
                        }
                    }
                }

                fs.Close();

                return key;
            } catch { return null; }
        }
    }
}
