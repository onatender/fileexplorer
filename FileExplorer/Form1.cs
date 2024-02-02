using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Explorer fileExplorer;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            fileExplorer = new Explorer();
            wholepccb.Checked = true;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            lstFile.Items.Clear();
           
            fileExplorer.search(txtQuery.Text);
          
        }

        public class Explorer
        {
            static Form1 form = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            private string[] drives = null;
            private string startpath = "wholecomputer";
            private List<FileInfo> matchlist = null;
            public bool print;

            public string C = @"C:\";
            public string D = @"D:\";


            public Explorer()
            {
                this.drives = Directory.GetLogicalDrives();
            }

            public void renewmatchlist() { matchlist = new List<FileInfo>(); }
            public void setstartpath(string path)
            {
                this.startpath = path;
            }

            public FileInfo getmatch(int index)
            {
                 return matchlist[index];
            }

            public FileInfo[] getmatchlist()
            {
                FileInfo[] templst = this.matchlist.ToArray();
                return templst;
            }

            public FileInfo[] search(string path, string query)
            {
                setstartpath(path);
                return search(query);
            }

            public FileInfo[] search(string query)
            {
                renewmatchlist();
                pathclassifier(query);
                return getmatchlist();
            }
            private void pathclassifier(string query)
            {
                if (startpath == "wholecomputer")
                    foreach (string drive in drives)
                    {
                        recwander(drive, query);
                    }
                else
                    recwander(startpath, query);
            }

            private bool recwander(string path, string query)
            {
                string[] directories;
                string[] files;

                try
                {
                    directories = Directory.GetDirectories(path);
                    files = Directory.GetFiles(path);
                }
                catch { return false; }

                foreach (string file in files)
                {
                    bool match = file.ToLower().Contains(query.ToLower());

                    if (match)
                    {
                        FileInfo mf = new FileInfo(file);
                        if (print) Console.WriteLine(mf.Name);
                        form.lstFile.Items.Add(mf.Directory.Name+"\\"+mf.Name); 
                        form.Refresh();
                        this.matchlist.Add(mf);
                    }
 
                }

                foreach (var directory in directories)
                {
                    recwander(directory, query);
                }
                return true;
            }


        }


        private void lstFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = lstFile.SelectedIndex;
            Process.Start(fileExplorer.getmatch(index).Directory.FullName);
        }

        private void strpthexp_Click(object sender, EventArgs e)
        {
            var nfl = new FolderBrowserDialog();
            var dr = nfl.ShowDialog();
            fileExplorer.setstartpath(nfl.SelectedPath);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (wholepccb.Checked)
            {
                fileExplorer.setstartpath("wholecomputer");
                strpthexp.Enabled = false;
            }
            else
            {
                strpthexp.Enabled = true;
            }
        }
    }
   
}
