using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calistir_btn_Click(object sender, EventArgs e)
        {
            
            //bulunan klasördeki dosyaları açar

            string[] dsDosyas = Directory.GetFiles(dizin.Text);
            try
            {
                foreach (var dsdosya in dsDosyas)
                {
                    FileInfo fileInfo = new FileInfo(dsdosya);
                    System.Diagnostics.Process.Start(Convert.ToString(fileInfo));
                };
            }
            catch
            {
                MessageBox.Show("Bulunan Dizindeki dosyalar çalışmadı");
            }

            


            //bir alt klasöre geçer
            string[] dsKlasors = Directory.GetDirectories(dizin.Text);
            foreach (var ks in dsKlasors)
            {
                string klasorIsmi;
                DirectoryInfo dirInfo = new DirectoryInfo(ks);
                klasorIsmi = dirInfo.Name;
                FileInfo fileInfo = new FileInfo(dizin.Text + "/" + klasorIsmi + "/"+ dsAd.Text);
                try
                {
                    System.Diagnostics.Process.Start(Convert.ToString(fileInfo));
                }
                catch { Console.WriteLine("bir alt klasör hatası."); }

                //iki alt klasöre geçer
                string dsKlasor2 = dizin.Text + "/" + klasorIsmi;
                string[] klasor2 = Directory.GetDirectories(dsKlasor2);

                foreach (var ks2 in klasor2)
                {
                    DirectoryInfo dirInfo2 = new DirectoryInfo(ks2);
                    string klasor2i = dirInfo2.Name;
                    FileInfo ikiinfo = new FileInfo(dsKlasor2 + "/" + klasor2i + "/" + dsAd.Text);
                    try
                    {
                        System.Diagnostics.Process.Start(Convert.ToString(ikiinfo));
                    }
                    catch { Console.WriteLine("İki alt klasör hatası."); }

                    //üç alt klasöre geçer
                    string dsKlasor3 = dsKlasor2 + "/" + klasor2i;
                    string[] klasor3 = Directory.GetDirectories(dsKlasor3);
                    foreach (var ks3 in klasor3)
                    {

                        DirectoryInfo dirInfo3 = new DirectoryInfo(ks3);
                        string klasor3i = dirInfo3.Name;

                        FileInfo fileInfo3 = new FileInfo(dsKlasor3 + "/" + klasor3i + "/" + dsAd.Text);
                        try
                        {
                            System.Diagnostics.Process.Start(Convert.ToString(fileInfo3));
                        }
                        catch { Console.WriteLine("üç alt klasör hatası."); }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Klasor = new FolderBrowserDialog();
            Klasor.ShowDialog();
            dizin.Text = Klasor.SelectedPath;
        }
    }
}

