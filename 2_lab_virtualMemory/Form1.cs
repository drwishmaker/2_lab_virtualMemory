using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_lab_virtualMemory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            int faultFIFO = 0;
            int faultLRU = 0;
            string[] FIFOElems = null;
            string[] LRUElems = null;
            string text;
            textBoxFifo.Text = "";
            textBoxLru.Text = "";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string filename = ofd.FileName;

                try
                {
                    using (var stream = new StreamReader(filename, Encoding.UTF8))
                    {
                        text = stream.ReadToEnd();
                        textBoxDefault.Text = "Your file:" + Environment.NewLine + text + Environment.NewLine;
                        FIFOElems = new string[text.Length];
                        LRUElems = new string[text.Length];
                        FIFOElems = text.Split(' ');
                        LRUElems = text.Split(' ');
                    }

                    for (int i = Decimal.ToInt32(frameCount.Value); i != FIFOElems.Length; i++)
                    {
                        bool pageFall = true;

                        for (int j = 0; j != Decimal.ToInt32(frameCount.Value); j++)
                        {
                            textBoxFifo.Text += FIFOElems[j] + " ";

                            if (FIFOElems[j] == FIFOElems[i])
                            {
                                pageFall = false;
                            }
                        }

                        if (pageFall == false)
                        {
                            textBoxFifo.Text += Environment.NewLine + "No pagefaults found";
                        }

                        textBoxFifo.Text += Environment.NewLine;

                        if (pageFall == true)
                        {
                            textBoxFifo.Text += "Drop: " + FIFOElems[0] + "  Add:" + FIFOElems[i] + Environment.NewLine;
                            faultFIFO++;

                            for (int k = 0; k < Decimal.ToInt32(frameCount.Value) - 1; k++)
                            {
                                FIFOElems[k] = FIFOElems[k + 1];
                            }

                            FIFOElems[Decimal.ToInt32(frameCount.Value) - 1] = FIFOElems[i];
                        }
                    }

                    for (int j = 0; j != Decimal.ToInt32(frameCount.Value); j++)
                    {
                        textBoxFifo.Text += FIFOElems[j] + " ";
                    }

                    textBoxFifo.Text += Environment.NewLine + "All drops:  " + Convert.ToString(faultFIFO);

                    for (int i = Decimal.ToInt32(frameCount.Value); i != LRUElems.Length; i++)
                    {
                        for (int j = 0; j != Decimal.ToInt32(frameCount.Value); j++)
                        {
                            textBoxLru.Text += LRUElems[j] + " ";
                        }

                        bool pageFault = true;

                        for (int j = 0; j != Decimal.ToInt32(frameCount.Value); j++)
                        {
                            if (LRUElems[j] == LRUElems[i])
                            {
                                pageFault = false;

                                for (int k = j; k != Decimal.ToInt32(frameCount.Value) - 1; k++)
                                {
                                    LRUElems[k] = LRUElems[k + 1];
                                }

                                LRUElems[Decimal.ToInt32(frameCount.Value) - 1] = LRUElems[i];
                            }
                        }

                        if (pageFault == false)
                        {
                            textBoxLru.Text += Environment.NewLine + "Move values";
                        }

                        textBoxLru.Text += Environment.NewLine;

                        if (pageFault == true)
                        {
                            textBoxLru.Text += "Drop: " + LRUElems[0] + "  Add:" + LRUElems[i] + Environment.NewLine;
                            faultLRU++;

                            for (int k = 0; k < Decimal.ToInt32(frameCount.Value) - 1; k++)
                            {
                                LRUElems[k] = LRUElems[k + 1];
                            }

                            LRUElems[Decimal.ToInt32(frameCount.Value) - 1] = LRUElems[i];
                        }
                    }
                    for (int j = 0; j != Decimal.ToInt32(frameCount.Value); j++)
                    {
                        textBoxLru.Text += LRUElems[j] + " ";
                    }

                    textBoxLru.Text += Environment.NewLine + "All drops:  " + Convert.ToString(faultLRU);
                    textBoxDefault.Text += "Drops in FIFO: " + Convert.ToString(faultFIFO) + Environment.NewLine +
                       "Drops in LRU: " + Convert.ToString(faultLRU) + Environment.NewLine;

                    if (faultFIFO < faultLRU)
                    {
                        textBoxDefault.Text += "FIFO algorithm is better here.";
                    }

                    else
                    {
                        textBoxDefault.Text += "LRU algorithm is better here.";
                    }
                }

                catch
                {
                    MessageBox.Show("Incorrect data");
                }

            }

            else
            {
                MessageBox.Show("Unable to read file");
            }
        }
    }
}
