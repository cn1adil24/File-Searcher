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
using Ookii.Dialogs.WinForms;
using System.Text.RegularExpressions;

namespace FileSearcher
{
    public partial class Form1 : Form
    {
        string path = "";
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            txt_check.Hide();
            doc_check.Hide();
            csv_check.Hide();
            xml_check.Hide();
            json_check.Hide();
            //progress_label.Hide();
            progressBar1.Hide();
        }        

        private void search_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please select a folder!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(search_box.Text) || String.IsNullOrWhiteSpace(search_box.Text))
            {
                MessageBox.Show("Please enter a keyword!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                List<Result> list = new List<Result>();
                try
                {
                    // Get folders of root directory, e.g folders in C:/Users
                    var directories = Directory.GetDirectories(path);                    
                    List<string> files = new List<string>();                    
                    progressBar1.Show();
                    label2.Show();
                    if (directories.Length != 0)
                    {
                        List<string> tree = new List<string>();
                        tree.Add(path);
                        //progressBar1.Show();
                        //label2.Show();

                        progressBar1.Maximum = Math.Max(directories.Length, 10000);
                        progressBar1.Step = 1;
                        label2.Text = "Extracting folders..";
                        label2.Refresh();
                        // Extract folders and its nested sub-directories
                        foreach (var folder in ExtractFolders(path))
                        {
                            tree.Add(folder);
                            if (progressBar1.Value + 1 == progressBar1.Maximum)
                            {
                                continue;
                            }
                            else
                            {
                                progressBar1.PerformStep();
                                progressBar1.Refresh();
                            }
                        }
                        progressBar1.PerformStep();

                        // Extract all files from nested folders
                        //List<string> files = new List<string>();
                        progressBar1.Value = 0;
                        progressBar1.Maximum = tree.Count;
                        progressBar1.Step = 1;
                        label2.Text = "Extracting files..";
                        label2.Refresh();
                        foreach (var folder in tree)
                        {
                            foreach(var file in ExtractFiles(folder))
                            {
                                files.Add(file);
                            }
                            progressBar1.PerformStep();
                            progressBar1.Refresh();
                        }                        
                    }
                    else
                    {
                        progressBar1.Maximum = Directory.GetFiles(path).Length;
                        progressBar1.Step = 1;
                        label2.Text = "Extracting files..";
                        label2.Refresh();
                        foreach (var file in ExtractFiles(path))
                        {
                            files.Add(file);
                            progressBar1.PerformStep();
                            progressBar1.Refresh();
                        }
                    }
                    List<Result> search_results = new List<Result>();
                    progressBar1.Value = 0;
                    progressBar1.Maximum = files.Count;
                    progressBar1.Step = 1;
                    label2.Text = "Searching..";
                    label2.Refresh();

                    // Search file names
                    foreach (var file in files)
                    {
                        var file_name = Path.GetFileName(file);
                        Match m = Regex.Match(file_name.ToUpper(), search_box.Text.ToUpper());
                        if (m.Success)
                        {
                            search_results.Add(new Result(
                                                          Path.GetFileNameWithoutExtension(file),
                                                          file,
                                                          Path.GetExtension(file))
                                              );
                            count++;
                        }
                        progressBar1.PerformStep();
                        progressBar1.Refresh();
                    }
                    if (count != 0)
                    {
                        dataGridView1.DataSource = search_results;
                        MessageBox.Show("Found " + count.ToString() + " file(s)", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        dataGridView1.DataSource = null;
                        MessageBox.Show("No such file exists!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                        
                    }
                    label2.Hide();
                    progressBar1.Value = 0;
                    progressBar1.Hide();
                    count = 0;

                    if (advanced_check.Checked)
                    {
                        // Advanced Search: through all files
                        foreach (var file in files)
                        {
                            if (Path.GetExtension(file).Equals(".txt") || Path.GetExtension(file).Equals(".doc"))
                            {
                                // simple read
                            }
                            else if (Path.GetExtension(file).Equals(".csv"))
                            {
                                // CSVParser
                            }
                            else if (Path.GetExtension(file).Equals(".xml"))
                            {
                                // XMLParser
                            }
                            else if (Path.GetExtension(file).Equals(".json"))
                            {
                                // JSONParser
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var dialog = new VistaFolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = dialog.SelectedPath;
                label3.Text = "Folder selected: " + path;
                label3.Show();
            }
        }
        private List<string> ExtractFolders(string folder)
        {
            List<string> tree = new List<string>();
            GetFolders(folder, tree);
            return tree;
        }
        private void GetFolders(string folder, List<string> tree)
        {
            var hierarchy = Directory.GetDirectories(folder);
            if (hierarchy != null)
            {
                /* Select each folder from the root path
                   For example C:/Users/Abc -> Target: 'Abc'
                               C:/Users/Xyz -> Target: 'Xyz' */
                foreach (var f in hierarchy)
                {
                    tree.Add(f);
                    /* Extract sub-folders of each folder
                       For example C:/Users/Abc/A -> Target 'A' and its sub-directories recursively
                                   C:/Users/Abc/B -> Target 'B' and its sub-directories recursively */
                    GetFolders(f, tree);
                }
            }
            return;
        }
        private List<string> ExtractFiles(string folder)
        {
            List<string> files = new List<string>();
            var all_files = Directory.GetFiles(folder);
            foreach (var file in all_files)
            {
                files.Add(file);
            }
            return files;
        }
        private List<string> ExtractAdvancedFiles(string folder)
        {
            List<string> files = new List<string>();
            if (txt_check.Checked)
            {
                var txt_files = Directory.GetFiles(folder, "*.txt");
                // Extract all txt files
                foreach (var txt in txt_files)
                {
                    files.Add(txt);
                }
            }
            if (doc_check.Checked)
            {
                var doc_files = Directory.GetFiles(folder, "*.doc");
                // Extract all doc files
                foreach (var doc in doc_files)
                {
                    files.Add(doc);
                }
            }
            if (csv_check.Checked)
            {
                var csv_files = Directory.GetFiles(folder, "*.csv");
                // Extract all csv files
                foreach (var csv in csv_files)
                {
                    files.Add(csv);
                }
            }
            if (xml_check.Checked)
            {
                var xml_files = Directory.GetFiles(folder, "*.xml");
                // Extract all xml files
                foreach (var xml in xml_files)
                {
                    files.Add(xml);
                }
            }
            if (json_check.Checked)
            {
                var json_files = Directory.GetFiles(folder, "*.json");
                // Extract all json files
                foreach (var json in json_files)
                {
                    files.Add(json);
                }
            }
            return files;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (advanced_check.Checked)
            {
                label4.Show();
                txt_check.Show();
                doc_check.Show();
                csv_check.Show();
                xml_check.Show();
                json_check.Show();
            }
            else
            {
                label4.Hide();
                txt_check.Hide();
                doc_check.Hide();
                csv_check.Hide();
                xml_check.Hide();
                json_check.Hide();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            search_box.Text = "";
            label3.Text = "";
            label3.Hide();
            path = "";
            label2.Hide();            
            progressBar1.Hide();
            progressBar1.Value = 0;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string path = dataGridView1[1, e.RowIndex].Value.ToString();
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true,
                    Verb = "open"
                });
            }            
        }
    }
    public class Result
    {
        public string name { get; set; }
        public string path { get; set; }
        public string type { get; set; }
        public Result()
        {
        }
        public Result(string name, string path, string type)
        {
            this.name = name;
            this.path = path;
            this.type = type;
        }
    }
}
