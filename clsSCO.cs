using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using INI;

namespace SCOToolBox
{
    class SCO
    {
        private static FileStream sco;
        public static Dictionary<string, string> offsets = new Dictionary<string, string>();        
        public static byte[] AESKey = {26, 181, 111, 237, 126, 195, 255, 1, 34, 123, 105, 21, 51, 151, 93, 206, 71, 215, 105, 101, 63, 247, 117, 66, 106, 150, 205, 109, 83, 7, 86, 93};

        public static bool isEncrypted = false;

        private static byte[] segheaderdec;
        public static byte[] segcodedec;
        private static byte[] segglobaldec;
        private static byte[] segpublicdec;

        private static int codesize = 0;
        private static int globalcount = 0;
        private static int publiccount = 0;

        public static byte[] flags;
        public static byte[] signature;

        private static byte[] segheaderenc;
        private static byte[] segcodeenc;
        private static byte[] segglobalenc;
        private static byte[] segpublicenc;              

        public static MemoryStream codereader;

        public static int codeCounter = 1;
        private static int tabCounter = 0;

        public static string nattype = "Old";

        public static long progress = 0;
        public static long progressOf = 0;
        public static string progressstr = "";

        public static bool writeNatives = false;

        public static bool createSCO(string path)
        {
            try{
                sco = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);                
            }catch{
                return false;
            }
            return true;
        }

        public static bool openSCO(string path)
        {
            try{
                sco = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);                
            }catch{
                return false;
            }
            return true;
        }

        public static bool closeSCO()
        {
            try{
                sco.Close();
            }catch{
                return false;
            }
            return true;
        }

        public static string getHeaderSectionDec()
        {
            try{
                byte[] block = new byte[24];
                sco.Position = 0;
                sco.Read(block, 0, 24);
                segheaderdec = block;
                segheaderenc = segheaderdec;
                segheaderenc[0] = 0x53;
                segheaderenc[1] = 0x43;
                segheaderenc[2] = 0x52;
                segheaderenc[3] = 0x0d;
                return "OK";
            }catch{
                return "Error: Unable to get header.";
            }
        }

        public static string getHeaderSectionEnc()
        {
            try{
                byte[] block = new byte[24];
                sco.Position = 0;
                sco.Read(block, 0, 24);
                segheaderenc = block;
                segheaderdec = segheaderenc;
                segheaderdec[0] = 0x73;
                segheaderdec[1] = 0x63;
                segheaderdec[2] = 0x72;
                segheaderdec[3] = 0x0e;
                return "OK";
            }catch{
                return "Error: Unable to get header.";
            }
        }

        public static string getSCOType()
        {
            try{                
                byte[] block = new byte[4];
                string strBlock = "";
                sco.Position = 0; sco.Read(block, 0, 4);
                strBlock = BitConverter.ToString(block).Replace("-", "");
                if (strBlock == "7363720E") { isEncrypted = true; return "Encrypted"; }
                if (strBlock == "5343520D") { isEncrypted = false; return "Not Encrypted"; }                
                return "Error: Cannot read or unknown SCO Type.";
            }catch{
                return "Error: Unable to get SCO Type.";
            }
        }

        public static string getCodeSize()
        {
            try{
                byte[] block = new byte[4]; int size = 0;
                sco.Position = 4;
                sco.Read(block, 0, 4);
                size = BitConverter.ToInt32(block, 0);
                //if (size == 0) return "Error: Code Size seems 0.";
                codesize = size;
                return size.ToString() + " bytes";
            }catch{
                return "Error: Unable to get Code Size.";
            }
        }

        public static string getGlobalCount()
        {
            try{
                byte[] block = new byte[4]; int size = 0;
                sco.Read(block, 0, 4);
                size = BitConverter.ToInt32(block, 0);
                //if (size == 0) return "Error: Global Count seems 0.";
                globalcount = size;
                return size.ToString();
            }catch{
                return "Error: Unable to get Global Count.";
            }
        }

        public static string getPublicCount()
        {
            try{
                byte[] block = new byte[4]; int size = 0;
                sco.Read(block, 0, 4);
                size = BitConverter.ToInt32(block, 0);
                //if (size == 0) return "Error: Public Count seems 0.";
                publiccount = size;
                return size.ToString();
            }catch{
                return "Error: Unable to get Public Count.";
            }
        }

        public static string getCodeFlags()
        {
            try{
                byte[] block = new byte[4];
                sco.Read(block, 0, 4);
                flags = block;
                return BitConverter.ToString(block).Replace("-", " ") + "\n(Flags meanings are currently unknown)";
            }catch{
                return "Error: Unable to get Code Flags.";
            }
        }

        public static string getSignature()
        {
            try{
                byte[] block = new byte[4];
                string temp = ""; string temp2 = "";
                sco.Read(block, 0, 4);
                signature = block;
                temp = BitConverter.ToString(block).Replace("-", "");
                if (temp == "0044207E") temp2 = "GTA IV";
                if (temp == "4AA44B39") temp2 = "TBoGT";
                if (temp == "3FA5FA2D") temp2 = "TLaD";
                return BitConverter.ToString(block).Replace("-", " ") + " (" + temp2 + ")";
            }catch{
                return "Error: Unable to get Signature.";
            }
        }

        public static string getCodeSectionDec()
        {
            try{
                byte[] block = new byte[codesize];
                sco.Read(block, 0, codesize);
                segcodeenc = block;
                segcodedec = decryptAES(block);
                return "OK";
            }catch{
                return "Error: Unable to get and/or decode Code Section.";
            }
        }
     
        public static string getGlobalSectionDec()
        {
            try{
                byte[] block = new byte[4 * globalcount];
                sco.Read(block, 0, (4 * globalcount));
                segglobalenc = block;
                segglobaldec = decryptAES(block);
                return "OK";
            }catch{
                return "Error: Unable to get and/or decode Global Section.";
            }
        }  

        public static string getPublicSectionDec()
        {
            try{
                byte[] block = new byte[4 * publiccount];
                sco.Read(block, 0, (4 * publiccount));
                segpublicenc = block;
                segpublicdec = decryptAES(block);
                return "OK";
            }catch{
                return "Error: Unable to get and/or decode Public Section.";
            }
        }

        public static string getCodeSectionEnc()
        {
            try{
                byte[] block = new byte[codesize];
                sco.Read(block, 0, codesize);
                segcodedec = block;
                segcodeenc = encryptAES(block);
                return "OK";
            }catch{
                return "Error: Unable to get and/or encode Code Section.";
            }
        }

        public static string getGlobalSectionEnc()
        {
            try{
                byte[] block = new byte[4 * globalcount];
                sco.Read(block, 0, (4 * globalcount));
                segglobaldec = block;
                segglobalenc = encryptAES(block);
                return "OK";
            }catch{
                return "Error: Unable to get and/or encode Global Section.";
            }
        }  

        public static string getPublicSectionEnc()
        {
            try{
                byte[] block = new byte[4 * publiccount];
                sco.Read(block, 0, (4 * publiccount));
                segpublicdec = block;
                segpublicenc = encryptAES(block);
                return "OK";
            }catch{
                return "Error: Unable to get and/or encode Public Section.";
            }
        } 

        public static string saveFileDec(string target)
        {
            try{
                if (isEncrypted == false) return "Error: File is not encoded. No decoding necessary.";

                createSCO(target);
                sco.Position = 0;
                sco.Write(segheaderdec, 0, segheaderdec.Length);
                sco.Write(segcodedec, 0, segcodedec.Length);
                sco.Write(segglobaldec, 0, segglobaldec.Length);
                sco.Write(segpublicdec, 0, segpublicdec.Length);
                closeSCO();

                return "OK";
            }catch{
                return "Error: Unable to decode and/or save file.";
            }
        } 

        public static string saveFileEnc(string target)
        {
            try{
                if (isEncrypted == true) return "Error: File is not decoded. No encoding necessary.";

                createSCO(target);
                sco.Position = 0;
                sco.Write(segheaderenc, 0, segheaderenc.Length);
                sco.Write(segcodeenc, 0, segcodeenc.Length);
                sco.Write(segglobalenc, 0, segglobalenc.Length);
                sco.Write(segpublicenc, 0, segpublicenc.Length);
                closeSCO();

                return "OK";
            }catch{
                return "Error: Unable to encode and/or save file.";
            }
        } 

        public static byte[] decryptAES(byte[] dataIn)
        {
            byte[] data = new byte[dataIn.Length];
            dataIn.CopyTo(data, 0);

            // Create our Rijndael class
            Rijndael rj = Rijndael.Create();
            rj.BlockSize = 128;
            rj.KeySize = 256;
            rj.Mode = CipherMode.ECB;
            rj.Key = AESKey;
            rj.IV = new byte[16];
            rj.Padding = PaddingMode.None;

            ICryptoTransform transform = rj.CreateDecryptor();

            int dataLen = data.Length & ~0x0F;

            // Decrypt!

            // R* was nice enough to do it 16 times...
            // AES is just as effective doing it 1 time because it has multiple internal rounds

            if (dataLen > 0)
            {
                for (int i = 0; i < 16; i++)
                {
                    transform.TransformBlock(data, 0, dataLen, data, 0);
                }
            }

            return data;
        }

        public static byte[] encryptAES(byte[] dataIn)
        {
            byte[] data = new byte[dataIn.Length];
            dataIn.CopyTo(data, 0);

            // Create our Rijndael class
            Rijndael rj = Rijndael.Create();
            rj.BlockSize = 128;
            rj.KeySize = 256;
            rj.Mode = CipherMode.ECB;
            rj.Key = AESKey;
            rj.IV = new byte[16];
            rj.Padding = PaddingMode.None;

            ICryptoTransform transform = rj.CreateEncryptor();

            int dataLen = data.Length & ~0x0F;

            // Decrypt!

            // R* was nice enough to do it 16 times...
            // AES is just as effective doing it 1 time because it has multiple internal rounds

            if (dataLen > 0)
            {
                for (int i = 0; i < 16; i++)
                {
                    transform.TransformBlock(data, 0, dataLen, data, 0);
                }
            }

            return data;
        }

        public static ListViewItem[] getGlobals()
        {
            byte[] block = new byte[4];
            ListViewItem lvi;
            ListViewItem[] lvil = new ListViewItem[globalcount];
            MemoryStream ms = new MemoryStream(segglobaldec);

            progressOf = globalcount; progressstr = "Reading: Step 1/7 - Reading Global Variables...";            

            for(int i = 0; i < globalcount; i++){
                progress = i;
                ms.Read(block,0,4);
                lvi = new ListViewItem((i + 1).ToString());
                lvi.SubItems.Add(BitConverter.ToInt32(block, 0).ToString());
                lvil[i] = lvi;
                if (i % 1000 == 0) Application.DoEvents();
            }
            return lvil;
        }

        public static ListViewItem[] getPublics()
        {
            byte[] block = new byte[4];
            ListViewItem lvi;
            ListViewItem[] lvil = new ListViewItem[publiccount];
            MemoryStream ms = new MemoryStream(segpublicdec);

            progressOf = publiccount; progressstr = "Reading: Step 2/7 - Reading Public Variables...";     

            for(int i = 0; i < publiccount; i++){
                progress = i;
                ms.Read(block,0,4);
                lvi = new ListViewItem((i + 1).ToString());
                lvi.SubItems.Add(BitConverter.ToInt32(block, 0).ToString());
                lvil[i] = lvi;
                if (i % 1000 == 0) Application.DoEvents();
            }
            return lvil;
        }

        /*public static string readCode()
        {            
            //FileStream fs = new FileStream(Application.StartupPath + "\\OutputHashes" + SCO.nattype + ".log", FileMode.Create);
            //fs.Close();

            offsets.Clear();
            
            codereader = new MemoryStream(segcodedec);
            codestring = "";
            byte[] block = new byte[1];
            string temp = "";
            string temp2 = "";
            codeCounter = 1;
            tabCounter = 0;

            codereader.Position = 0; progressOf = codereader.Length; progressstr = "Reading: Step 4/7- Reading Code...";
            while (codereader.Position < codereader.Length){
                progress = codereader.Position;
                codereader.Read(block, 0, 1);
                codeFirstRun(block[0]);
                if(codereader.Position % 200 == 0) Application.DoEvents();
            }

            Debug.WriteLine("**************************");

            codereader.Position = 0; progressOf = codereader.Length; progressstr = "Reading: Step 5/7 - Decompiling Code...";
            while (codereader.Position < codereader.Length){
                progress = codereader.Position;

                temp2 = getSavedOffset(codereader.Position.ToString(), "UNKNOWN");
                if (temp2 != "UNKNOWN") codestring += "\n" + getTabs(tabCounter) + ":" + temp2.Substring(1) + "\n";

                codereader.Read(block, 0, 1);
                temp = getOpCodeMeaning(block[0]);
                //codestring += getTabs(tabCounter) + temp + "\n";
                //if (temp.StartsWith("FnBegin")) tabCounter++;

                if (codereader.Position % 200 == 0) Application.DoEvents();
            }

            return codestring;
        }*/

        public static string getTabs(int count)
        {
            string retstr = "";
            //for (int i = 0; i < count; i++) { retstr += "\t"; }
            return retstr;
        }

        public static string codeFirstRun(int opCode)
        {
            byte[] block;
            int size = 0; int indices = 0;

            switch (opCode)
            {
                case 34:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);
                    saveOffset(SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)));
                    //Debug.WriteLine("Jump 0x" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)).ToString("X"));
                    return "OK";    
                case 35:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);
                    saveOffset(SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)));                    
                    //Debug.WriteLine("JumpFalse 0x" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)).ToString("X"));
                    return "OK";
                case 36:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);
                    saveOffset(SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)));                    
                    //Debug.WriteLine("JumpTrue 0x" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)).ToString("X"));
                    return "OK";
                case 40:
                case 48:
                    codereader.Position += 2;
                    return "OK";
                case 41:
                case 42:
                    codereader.Position += 4;
                    return "OK";
                case 45:
                    codereader.Position += 6;
                    return "OK";
                case 46:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);
                    saveOffset(SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)));                    
                    //return "Call 0x" + loc;
                    return "OK";
                case 47:
                    codereader.Position += 3;
                    return "OK";
                case 66:
                    block = new byte[1]; size = 0;
                    codereader.Read(block, 0, 1);
                    indices = block[0];
                    size = (indices * 8);
                    block = new byte[size];
                    codereader.Read(block, 0, size);
                    saveOffsetSwitch(indices, block);                    
                    //return "Switch " + getSwitchString(indices, block);
                    return "OK";
                case 67:
                    block = new byte[1];
                    size = 0;
                    codereader.Read(block, 0, 1);
                    size = block[0];
                    if (size < 0) size = 0;
                    codereader.Position += size;                    
                    //return "PushString \"" + System.Text.Encoding.GetEncoding(1251).GetString(block).Replace(char.ConvertFromUtf32(10), "\\n").Replace(char.ConvertFromUtf32(0), "") + "\"";
                    return "OK";
                default:
                    return "OK";
            }
        }

        public static void saveOffset(UInt32 offset)
        {
            string temp = getSavedOffset(offset.ToString(), "UNKNOWN");
            if(temp == "UNKNOWN"){
                //offsets.IniWriteValue("Offsets", offset.ToString(), "@Label" + codeCounter.ToString());
                offsets.Add(offset.ToString(), "@Label" + codeCounter.ToString());
                codeCounter++;
            }            
        }

        public static void saveOffsetSwitch(int indices, byte[] block)
        {
            for (int i = 0; i < (indices * 8); i += 8){
                saveOffset(SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block, i + 4, 4).Replace("-", ""), 16)));
                //Debug.WriteLine(SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block, i + 4, 4).Replace("-", ""), 16)).ToString("X") + ">" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block, i + 4, 4).Replace("-", ""), 16)).ToString());
            }
        }

        public static string getOpCodeMeaning(int opCode)
        {
            byte[] block;
            string native = ""; string input = ""; string retval = ""; string vars = "";
            int size = 0; int indices = 0;

            switch (opCode)
            {
                case 0:
                    return "NOp"; 
                case 1:
                    return "Add";
                case 2:
                    return "Sub";
                case 3:
                    return "Mul";
                case 4:
                    return "Div";
                case 5:
                    return "Mod";
                case 6:
                    return "IsZero";
                case 7:
                    return "Neg";
                case 8:
                    return "CmpEq";
                case 9:
                    return "CmpNe";
                case 10:
                    return "CmpGt";
                case 11:
                    return "CmpGe";
                case 12:
                    return "CmpLt";
                case 13:
                    return "CmpLe";
                case 14:
                    return "AddF";
                case 15:
                    return "SubF";
                case 16:
                    return "MulF";
                case 17:
                    return "DivF";
                case 18:
                    return "ModF";
                case 19:
                    return "NegF";
                case 20:
                    return "CmpEqF";
                case 21:
                    return "CmpNeF";
                case 22:
                    return "CmpGtF";
                case 23:
                    return "CmpGeF";
                case 24:
                    return "CmpLtF";
                case 25:
                    return "CmpLeF";
                case 26:
                    return "AddVec";
                case 27:
                    return "SubVec";
                case 28:
                    return "MulVec";
                case 29:
                    return "DivVec";
                case 30:
                    return "NegVec";
                case 31:
                    return "And";
                case 32:
                    return "Or";
                case 33:
                    return "Xor";
                case 34:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);                    
                    //Debug.WriteLine("Jump 0x" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)).ToString("X"));
                    return "Jump " + getSavedOffset(BitConverter.ToInt32(block, 0).ToString(), "*** UNKNOWN LABEL ERROR ***");
                case 35:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);                    
                    //Debug.WriteLine("JumpFalse 0x" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)).ToString("X"));
                    return "JumpFalse " + getSavedOffset(BitConverter.ToInt32(block, 0).ToString(), "*** UNKNOWN LABEL ERROR ***");
                case 36:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);
                    //Debug.WriteLine("JumpTrue 0x" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)).ToString("X"));
                    return "JumpTrue " + getSavedOffset(BitConverter.ToInt32(block, 0).ToString(), "*** UNKNOWN LABEL ERROR ***");
                case 37:
                    return "ToF";
                case 38:
                    return "FromF";
                case 39:
                    return "VecFromF";
                case 40:
                    block = new byte[2];
                    codereader.Read(block, 0, 2);
                    return "PushS " + BitConverter.ToInt16(block, 0).ToString();
                case 41:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);
                    return "Push 0x" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)).ToString("X");
                case 42:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);
                    return "PushF " + BitConverter.ToSingle(block, 0).ToString();
                case 43:
                    return "Dup";
                case 44:
                    return "Pop";
                case 45:
                    native = ""; input = ""; retval = "";
                    block = new byte[1];
                    codereader.Read(block, 0, 1);
                    input = block[0].ToString();
                    block = new byte[1];
                    codereader.Read(block, 0, 1);
                    retval = block[0].ToString();
                    block = new byte[4];
                    codereader.Read(block, 0, 4);
                    native = getNativeName(SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)));
                    return "CallNative " + native + " " + input + " " + retval;
                case 46:
                    block = new byte[4];
                    codereader.Read(block, 0, 4);                    
                    //Debug.WriteLine("Call 0x" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block).Replace("-", ""), 16)).ToString("X"));
                    return "Call " + getSavedOffset(BitConverter.ToInt32(block, 0).ToString(), "*** UNKNOWN LABEL ERROR ***");
                case 47:
                    input = ""; vars = "";
                    block = new byte[1];
                    codereader.Read(block, 0, 1);
                    input = block[0].ToString();
                    block = new byte[2];
                    codereader.Read(block, 0, 2);
                    vars = BitConverter.ToInt16(block, 0).ToString();
                    return "FnBegin " + input + " " + vars;
                case 48:
                    input = ""; vars = "";
                    block = new byte[1];
                    codereader.Read(block, 0, 1);
                    input = block[0].ToString();
                    block = new byte[1];
                    codereader.Read(block, 0, 1);
                    vars = block[0].ToString();
                    tabCounter--;
                    return "FnEnd " + input + " " + vars;
                case 49:
                    return "RefGet";
                case 50:
                    return "RefSet";
                case 51:
                    return "RefPeekSet";
                case 52:
                    return "ArrayExplode";
                case 53:
                    return "ArrayImplode";
                case 54:
                    return "Var0";
                case 55:
                    return "Var1";
                case 56:
                    return "Var2";
                case 57:
                    return "Var3";
                case 58:
                    return "Var4";
                case 59:
                    return "Var5";
                case 60:
                    return "Var6";
                case 61:
                    return "Var7";
                case 62:
                    return "Var";
                case 63:
                    return "LocalVar";
                case 64:
                    return "GlobalVar";
                case 65:
                    return "ArrayRef";
                case 66:
                    block = new byte[1]; size = 0;
                    codereader.Read(block, 0, 1);
                    indices = block[0];
                    size = (indices * 8);
                    block = new byte[size];
                    codereader.Read(block, 0, size);                    
                    return "Switch " + getSwitchString(indices, block);
                case 67:                    
                    block = new byte[1]; 
                    size = 0;
                    codereader.Read(block, 0, 1);
                    size = block[0];
                    if (size < 0) size = 0;                    
                    block = new byte[size];
                    codereader.Read(block, 0, size);
                    return "PushString \"" + System.Text.Encoding.GetEncoding(1251).GetString(block).Replace(char.ConvertFromUtf32(10),"\\n").Replace(char.ConvertFromUtf32(0),"") + "\"";
                case 68:
                    return "NullObj";
                case 69:
                    return "StrCpy";
                case 70:
                    return "IntToStr";
                case 71:
                    return "StrCat";
                case 72:
                    return "StrCatI";
                case 73:
                    return "Catch";
                case 74:
                    return "Throw";
                case 75:
                    return "StrVarCpy";
                case 76:
                    return "GetProtect";
                case 77:
                    return "SetProtect";
                case 78:
                    return "RefProtect";
                case 79:
                    return "Abort";                
            }
            if ((opCode > 79) && (opCode < 256)){
                return "PushD " + (opCode - 96).ToString();
            }
            return "UNKNOWN";
        }

        public static UInt16 SwapUInt16(UInt16 inValue)
        {
            byte[] byteArray = BitConverter.GetBytes(inValue);
            Array.Reverse(byteArray);
            return BitConverter.ToUInt16(byteArray, 0);
        }

        public static UInt32 SwapUInt32(UInt32 inValue)
        {
            byte[] byteArray = BitConverter.GetBytes(inValue);
            Array.Reverse(byteArray);
            return BitConverter.ToUInt32(byteArray, 0);
        }

        public static string getNativeName(UInt32 val)
        {
            IniFile natives = new IniFile(Application.StartupPath + "\\Data\\Natives" + nattype + ".dat");
            string nat = "ERROR"; 
            nat = natives.IniReadValue("Natives", val.ToString(), "ERROR");
            
            if (writeNatives == true){
                string get = "";
                IniFile debug = new IniFile(Application.StartupPath + "\\OutputHashes" + SCO.nattype + ".log");
                get = debug.IniReadValue("Debug", val.ToString(), "UNKNOWN");
                if(get == "UNKNOWN"){
                    if (nat == "ERROR") debug.IniWriteValue("Debug", val.ToString(), "?"); else debug.IniWriteValue("Debug", val.ToString(), nat);
                }
            }

            if (nat == "ERROR") return "0x" + val.ToString("X"); else return nat;
        }

        public static string getSwitchString(int indices, byte[] block)
        {
            string retstr = "";
            //retstr = indices.ToString();
            for (int i = 0; i < (indices * 8); i += 8){
                retstr += " " + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block, i, 4).Replace("-", ""), 16)).ToString("X") + ":" + getSavedOffset(SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block, i + 4, 4).Replace("-", ""), 16)).ToString(), "*** UNKNOWN LABEL ERROR ***");
                //retstr += " " + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block, i, 4).Replace("-", ""), 16)).ToString("X") + ":0x" + SwapUInt32(Convert.ToUInt32(BitConverter.ToString(block, i + 4, 4).Replace("-", ""), 16)).ToString("X");
            }
            //Debug.WriteLine(retstr);
            return retstr.Trim();
        }

        public static void writeToSCO(byte[] towrite)
        {            
            sco.Write(towrite, 0, towrite.Length);
        }

        public static string getSavedOffset(string get, string defval)
        {
            try{
                string temp = defval;
                offsets.TryGetValue(get, out temp);
                if (temp == null) return defval;
                return temp;
            }catch{
                return defval;
            }
        }
    }
}
