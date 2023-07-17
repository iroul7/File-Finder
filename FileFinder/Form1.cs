using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileFinder
{
    public partial class Form1 : Form
    {
        public static Form1 form1;
        private CsFinder Finder = null;
        public Form1()
        {
            InitializeComponent();
            this.Initialize();
        }

        private void Initialize()
        {
            Finder = new CsFinder();
            form1 = this;

            string strTest = "ㄱㄴㄷ123abc";

            foreach(char ch in strTest)
            {
                this.CheckingString(ch);
            }
        }

        //
        private void CheckingString(char ch)
        {
            if((0xAC00 <= ch && ch <= 0xD7A3) || (0x3131 <= ch && ch <= 0x318E))
            {
                Console.WriteLine("KOR");
            }
            else
            {
                Console.WriteLine("Unknown");
            }
        }


        private void CvOpenDialogButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Opener = new FolderBrowserDialog();
            if(Opener.ShowDialog() == DialogResult.OK)
            {
                CvPathTextBox.Text = Opener.SelectedPath;
            }

        }

        private void CvSearchButton_Click(object sender, EventArgs e)
        {
            string tempPath = CvPathTextBox.Text;
            string tempSearchWord = CvSearchWordTextBox.Text;
            string tempFileExtension = CvFileExtensionTextBox.Text;

            if (tempPath == "" || tempSearchWord == "")
            {
                Console.WriteLine("Path or Search word is empty.\n");
                MessageBox.Show("Path or Search word is empty.", "warning");
                return;
            }
            else
            {
                if(CvExtenUseCheckBox.Checked == true)
                {
                    Finder.SetSearchInfo(tempPath, tempSearchWord, tempFileExtension);
                }
                else
                {
                    Finder.SetSearchInfo(tempPath, tempSearchWord, "");
                }
            }
            Finder.StartSearch();
        }

        private void CvExtenUseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(CvExtenUseCheckBox.Checked == true)
            {
                CvFileExtensionTextBox.Enabled = true;
            }
            else
            {
                CvFileExtensionTextBox.Enabled = false;
            }
        }
    }
}
