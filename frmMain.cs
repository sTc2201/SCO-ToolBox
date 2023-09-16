using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Net;
using INI;

namespace SCOToolBox
{
    public partial class frmMain : Form
    {
        public string sError = "An error occured during processing.\n\n{0}";
        public int filenr = 0;
        public string multiError = "";
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Shift) == 0) { tabControl.TabPages[2].Dispose(); } else { checkBoxWriteHashes.Checked = true; }                      
            
            backgroundWorkerAll.RunWorkerCompleted += new RunWorkerCompletedEventHandler(fileDone);

            // byte[] aes = AES.GetKey();
            // if (aes == null) {
            //     MessageBox.Show("Could not find IV or EFLC installed to get the AES key from for reading SCO files.\nPlease install IV or ELFC or place its EXE in the current directory.\n\nThe program will now quit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //     Application.Exit();
            // }else{
            //     SCO.AESKey = aes;
            // }

            if (File.Exists(Application.StartupPath + "\\Puzzle.SyntaxBox.NET3.5.dll") == false){
                MessageBox.Show("The Code Editor cannot be used because the file \"Puzzle.SyntaxBox.NET3.5.dll\" is missing in the current folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonCode.Enabled = false;
                return;
            }
            
            string[] files = { "Functions.acl", "Natives.acl", "SCO.syn", "HashesNew.dat", "HashesOld.dat", "NativesNew.dat", "NativesOld.dat" };
            foreach (string file in files){
                if (File.Exists(Application.StartupPath + "\\Data\\" + file) == false){
                    MessageBox.Show("The Code Editor cannot be used because the file \"" + file + "\" is missing in the Data folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    buttonCode.Enabled = false;
                    return;
                }
            }

            /*string upd = checkUpdates();
            if ((upd != "OK") && (upd != "ERR")){
                if (MessageBox.Show("A new version of SCO ToolBox (v" + upd + ") is available.\nThis update may fix bugs and may contain new features.\n\nDo you want to go to the topic on GTAForums.com to view and download the new version?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes){
                    Process.Start("http://www.gtaforums.com/index.php?showtopic=481229");
                }
            } else if (upd == "ERR"){
                MessageBox.Show("An error occured while checking for updates.\nPlease try again or check for updates manually.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
        }

        /*
         * Non-functional, download URL doesn't exist anymore.
         *
        public string checkUpdates()
        {
            try{
                Version vcur = new Version(Application.ProductVersion);            
                WebClient clnt = new WebClient();
                Version vlat = new Version(clnt.DownloadString(System.Text.Encoding.UTF8.GetString(Convert.FromBase64String("aHR0cDovL3d3dy5mbGl0c2tpa2tlci5jb20vc29mdHdhcmUvc2NvdG9vbGJveC92ZXJzaW9uLnR4dA=="))));
                if (vlat > vcur) return vlat.ToString(4); else return "OK"; 
            }catch{ return "ERR"; }
        }*/

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            bool bResult = false;
            string sResult = "Error: Unknown";

            if (File.Exists(textBoxSCO.Text) == false){
                MessageBox.Show(String.Format(sError, "Error: File not found."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bResult = SCO.openSCO(textBoxSCO.Text);
            if (bResult == false){
                MessageBox.Show(String.Format(sError, "Error: Opening SCO file failed."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;            
            }

            sResult = SCO.getSCOType();
            if (sResult.StartsWith("Error:")){
                MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else{
                labelSCOType.Text = sResult;
            }

            if(SCO.isEncrypted == true){
                sResult = SCO.getHeaderSectionDec();
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                labelAction.Text = "Decode";
            }else{
                sResult = SCO.getHeaderSectionEnc();
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                labelAction.Text = "Encode";
            }

            sResult = SCO.getCodeSize();
            if (sResult.StartsWith("Error:")){
                MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else{
                labelCodeSize.Text = sResult;
            }

            if (Convert.ToInt32(SCO.getCodeSize().Replace("bytes", "").Trim()) > 50000) { radioButtonBasic.Checked = true; } else { radioButtonAdvanced.Checked = true; }

            sResult = SCO.getGlobalCount();
            if (sResult.StartsWith("Error:")){
                MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else{
                labelGlobals.Text = sResult;
            }

            sResult = SCO.getPublicCount();
            if (sResult.StartsWith("Error:")){
                MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else{
                labelPublics.Text = sResult;
            }

            sResult = SCO.getCodeFlags();
            if (sResult.StartsWith("Error:")){
                MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else{
                labelFlags.Text = sResult;
            }

            sResult = SCO.getSignature();
            if (sResult.StartsWith("Error:")){
                MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else{
                labelSignature.Text = sResult;
            }

            if (sResult.Contains("GTA IV") == false) { radioButtonNew.Checked = true; } else { radioButtonOld.Checked = true; }

            if(SCO.isEncrypted == true){
                sResult = SCO.getCodeSectionDec();
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sResult = SCO.getGlobalSectionDec();
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sResult = SCO.getPublicSectionDec();
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }else{
                sResult = SCO.getCodeSectionEnc();
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sResult = SCO.getGlobalSectionEnc();
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sResult = SCO.getPublicSectionEnc();
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            bResult = SCO.closeSCO();
            if (bResult == false){
                MessageBox.Show(String.Format(sError, "Error: Closing SCO file failed."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            label2.Enabled = true;
            textBoxTargetSCO.Enabled = true;
            buttonBrowseTarget.Enabled = true;
            buttonProcess.Enabled = true;
            checkBoxSelf.Enabled = true;
            groupBox.Enabled = true;

            buttonOpen.Enabled = false;
            buttonBrowse.Enabled = false;
            buttonClose.Enabled = true;
            textBoxSCO.ReadOnly = true;

            textBoxTargetSCO.Enabled = !checkBoxSelf.Checked;
            buttonBrowseTarget.Enabled = !checkBoxSelf.Checked;

            if (SCO.isEncrypted == true) textBoxTargetSCO.Text = textBoxSCO.Text.Replace(".sco", " - Decoded.sco"); else textBoxTargetSCO.Text = textBoxSCO.Text.Replace(".sco", " - Encoded.sco");

            Cursor.Current = Cursors.Default;
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxSelf_CheckedChanged(object sender, EventArgs e)
        {
            textBoxTargetSCO.Enabled = !checkBoxSelf.Checked;
            buttonBrowseTarget.Enabled = !checkBoxSelf.Checked;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to close this file?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) Application.Restart();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            frmAbout abt = new frmAbout();
            abt.ShowDialog();
        }

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            string sResult = "Error: Unknown";
            
            if (File.Exists(textBoxSCO.Text) == false){
                MessageBox.Show(String.Format(sError, "Error: File not found."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(SCO.isEncrypted == true){
                if (checkBoxSelf.Checked == false) sResult = SCO.saveFileDec(textBoxTargetSCO.Text); else sResult = SCO.saveFileDec(textBoxSCO.Text);
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else{
                    MessageBox.Show("The file has been successfully decoded!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }else{
                if (checkBoxSelf.Checked == false) sResult = SCO.saveFileEnc(textBoxTargetSCO.Text); else sResult = SCO.saveFileEnc(textBoxSCO.Text);
                if (sResult.StartsWith("Error:")){
                    MessageBox.Show(String.Format(sError, sResult), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }else{
                    MessageBox.Show("The file has been successfully encoded!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            Cursor.Current = Cursors.Default;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) textBoxSCO.Text = openFileDialog.FileName;
        }

        private void buttonBrowseTarget_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) textBoxTargetSCO.Text = saveFileDialog.FileName;
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {   
            Cursor.Current = Cursors.WaitCursor;

            SCO.writeNatives = checkBoxWriteHashes.Checked;
            
            frmCode cd = new frmCode();
            if (radioButtonOld.Checked) { SCO.nattype = "Old"; cd.toolStripComboBoxNatType.Text = radioButtonOld.Text; }
            if (radioButtonNew.Checked) { SCO.nattype = "New"; cd.toolStripComboBoxNatType.Text = radioButtonNew.Text; }

            if (radioButtonAdvanced.Checked) { cd.syntaxBoxControl.Visible = true; cd.richTextBox.Visible = false; }
            if (radioButtonBasic.Checked) { cd.syntaxBoxControl.Visible = false; cd.richTextBox.Visible = true; }
            cd.ShowDialog();
            Cursor.Current = Cursors.Default;           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialogMulti.ShowDialog() == System.Windows.Forms.DialogResult.OK){
                for (int i = 0; i < openFileDialogMulti.FileNames.Length; i++){
                    listBox.Items.Add(openFileDialogMulti.FileNames[i]);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox.SelectedItems.Count; i++){
                listBox.Items.Remove(listBox.Items[listBox.SelectedIndices[i]]);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Are you sure you want to clear the file list?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) listBox.Items.Clear();
        }

        private void buttonBrowseDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) textBoxDir.Text = folderBrowserDialog.SelectedPath;
        }

        private void checkBoxSelfAll_CheckedChanged(object sender, EventArgs e)
        {
            textBoxDir.Enabled = !checkBoxSelfAll.Checked;
            buttonBrowseDir.Enabled = !checkBoxSelfAll.Checked;
        }

        public void fileDone(object sender, RunWorkerCompletedEventArgs e)
        {
            filenr++;
            progressBar.Value++;            
            if (filenr >= listBox.Items.Count) { 
                completeProcess(); 
            } else {
                labelStatus.Text = "Processing: " + Path.GetFileName(listBox.Items[filenr].ToString()) + "...";
                labelStatus.Refresh();
                backgroundWorkerAll.RunWorkerAsync();
            }
        }

        public void completeProcess()
        {            
            labelStatus.Text = "Done!";
            labelStatus.Refresh();
            if (multiError == "") MessageBox.Show("All files done!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information); else MessageBox.Show("All files that could be done, are done.\nAn error occured during the processing of the following files:\n" + multiError, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            progressBar.Value = 0;
            cleanUp();
        }

        public void cleanUp()
        {
            textBoxDir.Enabled = true;
            buttonBrowseDir.Enabled = true;
            buttonProcessAll.Enabled = true;
            buttonAdd.Enabled = true;
            buttonDelete.Enabled = true;
            buttonClear.Enabled = true;

            Cursor.Current = Cursors.Default;
        }

        private void buttonProcessAll_Click(object sender, EventArgs e)
        {
            if (checkBoxSelfAll.Checked == false){
                if (Directory.Exists(textBoxDir.Text) == false){
                    MessageBox.Show(String.Format(sError, "Error: Destination folder not found."), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            multiError = "";

            Cursor.Current = Cursors.WaitCursor;  

            textBoxDir.Enabled = false;
            buttonBrowseDir.Enabled = false;
            buttonProcessAll.Enabled = false;
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
            buttonClear.Enabled = false;

            progressBar.Maximum = listBox.Items.Count;

            filenr = 0;

            if (filenr >= listBox.Items.Count) { completeProcess(); return; }
                        
            backgroundWorkerAll.RunWorkerAsync();
        }

        private void backgroundWorkerAll_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = filenr; string sResult = ""; bool bResult = true;

            bResult = SCO.openSCO(listBox.Items[i].ToString());
            if (bResult == false) { multiError += "\n" + listBox.Items[i].ToString() + ": Opening SCO file failed."; return; }

            sResult = "";

            sResult = SCO.getSCOType(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            if(SCO.isEncrypted == true){
                sResult = SCO.getHeaderSectionDec(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            }else{
                sResult = SCO.getHeaderSectionEnc(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            }
            sResult = SCO.getCodeSize(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            sResult = SCO.getGlobalCount(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            sResult = SCO.getPublicCount(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            sResult = SCO.getCodeFlags(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            sResult = SCO.getSignature(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            if(SCO.isEncrypted == true){
                sResult = SCO.getCodeSectionDec(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
                sResult = SCO.getGlobalSectionDec(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
                sResult = SCO.getPublicSectionDec(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            }else{
                sResult = SCO.getCodeSectionEnc(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
                sResult = SCO.getGlobalSectionEnc(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
                sResult = SCO.getPublicSectionEnc(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            }            
            bResult = SCO.closeSCO(); if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
            if(SCO.isEncrypted == true){
                if (checkBoxSelfAll.Checked == true) sResult = SCO.saveFileDec(listBox.Items[i].ToString()); else sResult = SCO.saveFileDec(textBoxDir.Text + "\\" + Path.GetFileName(listBox.Items[i].ToString()));
            }else{
                if (checkBoxSelfAll.Checked == true) sResult = SCO.saveFileEnc(listBox.Items[i].ToString()); else sResult = SCO.saveFileEnc(textBoxDir.Text + "\\" + Path.GetFileName(listBox.Items[i].ToString()));
            }
            if (sResult.StartsWith("Error:") == true) { multiError += "\n" + listBox.Items[i].ToString() + sResult.Replace("Error", ""); return; }
        }

        private void radioButtonAdvanced_CheckedChanged(object sender, EventArgs e)
        {            
            if ((Convert.ToInt32(labelCodeSize.Text.Replace("bytes", "").Trim()) > 50000) && (radioButtonAdvanced.Checked == true)){
                if (MessageBox.Show("WARNING: You've selected the advanced editor for a big file. Loading could take a very long time. Up to 3 minutes for the main.sco!\nOn slower computers, it could take even longer.\nCompiling, however, is fast.\n\nAre you sure you want to use the advanced editor?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.No) { radioButtonAdvanced.Checked = false; radioButtonBasic.Checked = true; }
            }
        }

        private void buttonDebugCompare_Click(object sender, EventArgs e)
        {
            textBoxDebugLog.Clear();
            if (File.Exists(Application.StartupPath + "\\OutputHashesOld.log") == false) { textBoxDebugLog.AppendText("ERROR: Cannot find 1040 log.\n"); return; }
            if (File.Exists(Application.StartupPath + "\\OutputHashesNew.log") == false) { textBoxDebugLog.AppendText("ERROR: Cannot find 1070 log.\n"); return; }
            if (File.Exists(Application.StartupPath + "\\Data\\HashesNew.dat") == false) { textBoxDebugLog.AppendText("ERROR: Cannot find Hashes dat.\n"); return; }
            IniFile log1040 = new IniFile(Application.StartupPath + "\\OutputHashesOld.log");
            IniFile log1070 = new IniFile(Application.StartupPath + "\\OutputHashesNew.log");
            IniFile hashes = new IniFile(Application.StartupPath + "\\Data\\HashesNew.dat");
            string size1040 = log1040.IniReadValue("Code", "Size", "UNKNOWN");
            string size1070 = log1070.IniReadValue("Code", "Size", "UNKNOWN");
            if (size1040 == "UNKNOWN") { textBoxDebugLog.AppendText("ERROR: 1040 size unknown.\n"); return; } else { textBoxDebugLog.AppendText("Size 1040: " + size1040 + "\n"); }
            if (size1070 == "UNKNOWN") { textBoxDebugLog.AppendText("ERROR: 1070 size unknown.\n"); return; } else { textBoxDebugLog.AppendText("Size 1070: " + size1070 + "\n"); }
            if (size1040 != size1070) { textBoxDebugLog.AppendText("ERROR: Different sizes.\n"); return; } else { textBoxDebugLog.AppendText("Sizes OK.\n"); }
            List<string> list1040 = new List<string>();
            List<string> list1070 = new List<string>();
            string line;
            using (StreamReader sr = new StreamReader(Application.StartupPath + "\\OutputHashesOld.log")){
                while ((line = sr.ReadLine()) != null){
                    if((line.StartsWith("[") == false) && (line.StartsWith("Size") == false)){
                        list1040.Add(line);
                    }
                }
            }
            using (StreamReader sr = new StreamReader(Application.StartupPath + "\\OutputHashesNew.log")){
                while ((line = sr.ReadLine()) != null){
                    if((line.StartsWith("[") == false) && (line.StartsWith("Size") == false)){
                        list1070.Add(line);
                    }
                }
            }
            textBoxDebugLog.AppendText("Count 1040: " + list1040.Count.ToString() + "\n");
            textBoxDebugLog.AppendText("Count 1070: " + list1070.Count.ToString() + "\n");
            if (list1040.Count != list1070.Count) { textBoxDebugLog.AppendText("ERROR: Different counts.\n"); return; } else { textBoxDebugLog.AppendText("Counts OK.\n"); }
            string[] split1040; string[] split1070; string left; string right; string check;
            int w = 0; int n = 0; int d = 0;
            for (int i = 0; i < list1040.Count; i++){
                split1040 = list1040[i].Split(Convert.ToChar("="));
                split1070 = list1070[i].Split(Convert.ToChar("="));
                left = split1070[0];
                right = split1040[1];
                textBoxDebugLog.AppendText(left + "=" + right);
                check = hashes.IniReadValue("Hashes", right, "UNKNOWN");
                if(check == "UNKNOWN"){
                    hashes.IniWriteValue("Hashes", right, left);
                    textBoxDebugLog.AppendText(" - NOT FOUND: Written XXXXXXXXXXXXXX\n");
                    w++;
                }else{
                    if(check == left){                        
                        textBoxDebugLog.AppendText(" - FOUND: Nothing written ---------------\n");
                        n++;
                    }else{
                        textBoxDebugLog.AppendText(" - FOUND, *****BUT DIFFERENT!!!******. In file: " + check + ", From log: " + left + "\n");
                        d++;
                    }
                }
            }
            textBoxDebugLog.AppendText("\n");
            textBoxDebugLog.AppendText("Found: " + n.ToString() + " / " + list1040.Count.ToString() + "\n");
            textBoxDebugLog.AppendText("Not Found, Written: " + w.ToString() + " / " + list1040.Count.ToString() + "\n");
            textBoxDebugLog.AppendText("Found but different: " + d.ToString() + " / " + list1040.Count.ToString() + "\n");
            textBoxDebugLog.AppendText("\n");
            textBoxDebugLog.AppendText("DONE!");
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            /*string[] files = Directory.GetFiles(Application.StartupPath + "\\SCOTestFiles");
            foreach (string file in files){
                FileInfo info1 = new FileInfo(Application.StartupPath + "\\SCOTestFiles\\" + Path.GetFileName(file));
                FileInfo info2 = new FileInfo(Application.StartupPath + "\\SCOTestFiles1040\\" + Path.GetFileName(file));
                if (info1.Length == info2.Length){
                    File.Copy(Application.StartupPath + "\\SCOTestFiles1040\\" + Path.GetFileName(file), Application.StartupPath + "\\SCOTestFilesSame\\" + Path.GetFileNameWithoutExtension(file) + "_1040.sco");
                    File.Copy(Application.StartupPath + "\\SCOTestFiles\\" + Path.GetFileName(file), Application.StartupPath + "\\SCOTestFilesSame\\" + Path.GetFileNameWithoutExtension(file) + "_1070.sco");
                    System.Diagnostics.Debug.WriteLine(Path.GetFileName(file) + " SAME! XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
                }else{
                    System.Diagnostics.Debug.WriteLine(Path.GetFileName(file) + " different -----------------------------------");
                }
            }*/

            textBoxDebugLog.Clear();
            IniFile hashes = new IniFile(Application.StartupPath + "\\Data\\HashesNew.dat");
            List<string> list = new List<string>();
            string line;
            using (StreamReader sr = new StreamReader(Application.StartupPath + "\\Data\\New.txt")){
                while ((line = sr.ReadLine()) != null){
                    list.Add(line);
                }
            }
            textBoxDebugLog.AppendText("Count: " + list.Count.ToString() + "\n");
            string[] split; string left; string right; string check;
            int w = 0; int n = 0; int d = 0;
            for (int i = 0; i < list.Count; i++){
                split = list[i].Split(Convert.ToChar("="));
                left = split[0];
                right = split[1];
                right = Convert.ToInt64(right.Replace("0x", ""), 16).ToString();
                textBoxDebugLog.AppendText(right + "=" + left);
                check = hashes.IniReadValue("Hashes", left, "UNKNOWN");
                if(check == "UNKNOWN"){
                    //hashes.IniWriteValue("Hashes", left, right);
                    textBoxDebugLog.AppendText(" - NOT FOUND: Written XXXXXXXXXXXXXX\n");
                    w++;
                }else{
                    if(check == right){                        
                        textBoxDebugLog.AppendText(" - FOUND: Nothing written ---------------\n");
                        n++;
                    }else{
                        textBoxDebugLog.AppendText(" - FOUND, *****BUT DIFFERENT!!!******. In file: " + check + ", From log: " + right + "\n");
                        d++;
                    }
                }
            }
            textBoxDebugLog.AppendText("\n");
            textBoxDebugLog.AppendText("Found: " + n.ToString() + " / " + list.Count.ToString() + "\n");
            textBoxDebugLog.AppendText("Not Found, Written: " + w.ToString() + " / " + list.Count.ToString() + "\n");
            textBoxDebugLog.AppendText("Found but different: " + d.ToString() + " / " + list.Count.ToString() + "\n");
            textBoxDebugLog.AppendText("\n");
            textBoxDebugLog.AppendText("DONE!");
        }
    }
}
