using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace FileFinder
{
    class CsFinder
    {
        private string mPath = null;
        private string mSearchWord = null;
        private string mSearchExtension = null;

        public void SetSearchInfo(string _path, string _searchWord, string _searchExtension)
        {
            mPath = _path;
            mSearchWord = _searchWord;
            mSearchExtension = _searchExtension;

            if (mSearchExtension != "")
            {
                if(mSearchExtension.Substring(0, 1) != ".")
                {
                    mSearchExtension = mSearchExtension.Insert(0, ".");
                }
            }
        }

        public void StartSearch()
        {
            DirectoryInfo DirInfo = new DirectoryInfo(mPath);
            int DetectCount = 0;
            int NonDetectCount = 0;

            Form1.form1.CvSearchButton.Enabled = false;
            Form1.form1.CvResultRichTextBox.Clear();
            
            foreach(FileInfo Files in DirInfo.GetFiles())
            {
                if (mSearchExtension != "")
                {
                    if (Files.Extension.ToLower().CompareTo(mSearchExtension) == 0)
                    {
                        DetectFile(Files, ref DetectCount, ref NonDetectCount);
                    }
                }
                else
                {
                    DetectFile(Files, ref DetectCount, ref NonDetectCount);
                }
            }

            Form1.form1.CvResultRichTextBox.SelectionColor = Color.Blue;
            Form1.form1.CvResultRichTextBox.AppendText("Total Detected : " + DetectCount + "\r\n");
            Form1.form1.CvResultRichTextBox.SelectionColor = Color.Red;
            Form1.form1.CvResultRichTextBox.AppendText("Total NonDetected : " + NonDetectCount + "\r\n");
            Form1.form1.CvResultRichTextBox.ScrollToCaret();
            Form1.form1.CvSearchButton.Enabled = true;
        }

        private void DetectFile(FileInfo _fi, ref int _dCount, ref int _ndCount)
        {
            string FullFilePath = _fi.FullName;
            string Msg = "File : " + FullFilePath;
            
            Console.WriteLine(Msg);
            Form1.form1.CvResultRichTextBox.SelectionColor = Color.Black;
            Form1.form1.CvResultRichTextBox.AppendText(Msg + "\r\n");
            Form1.form1.CvResultRichTextBox.ScrollToCaret();

            if (this.IsExistWord(FullFilePath, mSearchWord))
            {
                Form1.form1.CvResultRichTextBox.SelectionColor = Color.Blue;
                Msg = "Detected ! ! ! ! !";
                _dCount++;
            }
            else
            {
                Form1.form1.CvResultRichTextBox.SelectionColor = Color.Red;
                Msg = "Not Detected";
                _ndCount++;
            }

            Console.WriteLine(Msg);
            Form1.form1.CvResultRichTextBox.AppendText(Msg + "\r\n\r\n");
            Form1.form1.CvResultRichTextBox.ScrollToCaret();
        }

        public bool IsExistWord(string _path, string _searchWord)
        {
            bool IsReturn = false;
            string ColumnVal = File.ReadAllText(_path, Encoding.Default);

            int ResultNum = ColumnVal.IndexOf(_searchWord);

            if (ResultNum != -1)
            {
                IsReturn = true;
            }
            else
            {
                IsReturn = false;
            }
                                            
            return IsReturn;
        }
    }


}
