using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileInFiles
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            string[] fileTypes = Properties.Settings.Default.FileTypes.ToString().Split(',');
            clbox_FileTypes.Items.AddRange(fileTypes);
            for (int i = 0; i < clbox_FileTypes.Items.Count; i++) {
                clbox_FileTypes.SetItemCheckState(i, CheckState.Checked);
            }
            
        }

        private int dir_count = 0;
        private int file_count = 0;
        private int files_found = 0;

        private void btn_Search_Click(object sender, EventArgs e)
        {

            lstbox_Files.Items.Clear();

            List<string> Directorys = new List<string>();
            List<string> Files = new List<string>();

            DirectoryInfo Dir = new DirectoryInfo(txt_Dir.Text);
            List<string> filepaths = new List<string>();

            List<string> fileTypes = new List<string>();

            for (int i = 0; i < clbox_FileTypes.Items.Count; i++)
            {
                if (clbox_FileTypes.GetItemCheckState(i) == CheckState.Checked)
                {
                    fileTypes.Add(clbox_FileTypes.Items[i].ToString());
                }
            }


            

            var t = Task.Run(() =>
                {
                    dir_count = 0;
                    file_count = 0;
                    files_found = 0;
                    try
                    {
                        FileInfo[] firstPass = Dir.GetFiles();
                        for (int i = 0; i < firstPass.Length; i++)
                        {
                            for (int j = 0; j < fileTypes.Count; j++)
                            {
                                if (firstPass[i].Extension.Equals(fileTypes[j].Trim()))
                                {
                                    if (FileHasString(txt_Search.Text.Trim().ToLower(), firstPass[i].FullName))
                                    {
                                        lstbox_Files.Items.Add(firstPass[i].FullName);
                                        files_found++;
                                    }
                                }
                            }
                            file_count++;
                            lblStatInfo.Text = "Searching Directory:\t" + Dir.Name +
                                                "\nDirectories Searched:\t" + dir_count.ToString() +
                                                "\nFiles Searched:\t" + file_count.ToString();
                        }

                        dir_count = 1;


                        foreach (DirectoryInfo temp in Dir.GetDirectories())
                        {
                            FileInfo[] test = temp.GetFiles();
                            for (int i = 0; i < test.Length; i++)
                            {
                                for (int j = 0; j < fileTypes.Count; j++)
                                {
                                    if (test[i].Extension.Equals(fileTypes[j].Trim()))
                                    {
                                        if (FileHasString(txt_Search.Text.Trim().ToLower(), test[i].FullName))
                                        {
                                            lstbox_Files.Items.Add(test[i].FullName);
                                            files_found++;
                                        }
                                    }
                                }
                                file_count++;
                            }
                            dir_count++;
                            lblStatInfo.Text = "Searching:\t" + temp.Name +
                                                "\nDirectories Searched:\t" + dir_count.ToString() +
                                                "\nFiles Searched:\t" + file_count.ToString();
                        }
                        lblStatInfo.Text = "Directories Searched:\t" + dir_count.ToString() + "\nFiles Searched:\t" + file_count.ToString() + "\nFiles Found:\t" + files_found;
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show("Opps....Nothing here");
                    }
            });

        }


        private bool FileHasString(string searchString, string filePath)
        {
            try
            {
                string file = File.ReadAllText(filePath);
                file = file.Trim().ToLower();
                return file.Contains(searchString);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Failed to open file.");
            }
            return false;
        }

        private void btn_SelectFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    txt_Dir.Text = fbd.SelectedPath;
                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void lstbox_Files_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstbox_Files.SelectedItem.ToString().Length > 0)
                {
                    System.Diagnostics.Process.Start(lstbox_Files.SelectedItem.ToString());
                }
                    }
            catch(Exception Ex)
            {

            }
        }
    }
}
