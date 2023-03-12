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

namespace Proiect1
{
    public partial class FormDisk : Form
    {
        public FormDisk()
        {
            InitializeComponent();
        }

        private void TestTransferSpeed()
        {
            if (!Directory.Exists($@"{Environment.CurrentDirectory}\in"))
            {
                Directory.CreateDirectory($@"{Environment.CurrentDirectory}\in");
            }

            if (!Directory.Exists($@"{Environment.CurrentDirectory}\out"))
            {
                Directory.CreateDirectory($@"{Environment.CurrentDirectory}\out");
            }

            var sizeInMb = int.Parse(fileSizeComboBox.SelectedItem.ToString()); ;
            var iterations = 5;

            double rez = 0;
            diskTextBox.AppendText($"File size: {sizeInMb} MB\r\nNumber of transfers: {iterations}\r\n");
            for (int it = 1; it <= iterations; it++)
            {
                if (!File.Exists($@"{Environment.CurrentDirectory}\in\{it}test.tmp"))
                {
                    GenerateRandomFile(sizeInMb, $@"{Environment.CurrentDirectory}\in\{it}test.tmp");
                }
                Application.DoEvents();

                var watch = new Stopwatch();
                watch.Start();

                File.Copy($@"{Environment.CurrentDirectory}\in\{it}test.tmp", $@"{Environment.CurrentDirectory}\out\{it}test.tmp", true);
 
                watch.Stop();

                File.Delete($@"{Environment.CurrentDirectory}\in\{it}test.tmp");
                File.Delete($@"{Environment.CurrentDirectory}\out\{it}test.tmp");

                diskTextBox.AppendText($"\tTransfer{it}: {Math.Round(((double)sizeInMb * 1000) / watch.ElapsedMilliseconds, 2)} MB/sec\r\n");
                diskTextBox.Invalidate();

                rez += Math.Round((double)sizeInMb * 1000 / watch.ElapsedMilliseconds, 2);
            }
            diskTextBox.AppendText($"Average: { Math.Round(rez / iterations, 2)} MB/sec\r\n");
            diskTextBox.AppendText("\r\n\r\n");
            diskTextBox.Invalidate();
        }

        public void GenerateRandomFile(int sizeInMb, string fileName)
        {
            byte[] data = new byte[sizeInMb * 1024 * 1024];
            Random random = new Random();
            random.NextBytes(data);
            File.WriteAllBytes(fileName, data);
        }
        private void fileSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestTransferSpeed();
        }
    }
}
