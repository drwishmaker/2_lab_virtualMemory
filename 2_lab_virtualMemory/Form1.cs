using System;
using System.IO;
using System.Windows.Forms;

namespace _2_lab_virtualMemory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int faultFIFO = 0;
        int faultLRU = 0;
        string[] fifoEl = null;
        string[] lruEl = null;
        string text;
        

        private void buttonFile_Click(object sender, EventArgs e)
        {
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                input();
                fifo();
                lru();
                output();
            }

            else
            {
                MessageBox.Show("Unable to read file", "Error");
            }
        }

        private void input()
        {
            string filename = ofd.FileName;

            textBoxFifo.Text = "";
            textBoxLru.Text = "";

            text = File.ReadAllText(filename);
            textBoxDefault.Text = "Selected file:" + Environment.NewLine + text + Environment.NewLine;

            fifoEl = new string[text.Length];
            lruEl = new string[text.Length];

            fifoEl = text.Split(' ');
            lruEl = text.Split(' ');
        }

        private void fifo()
        {
            try
            {
                for (int count = Convert.ToInt32(frameCount.Value); count != fifoEl.Length; count++)
                {
                    bool pageFall = true;

                    for (int j = 0; j != Convert.ToInt32(frameCount.Value); j++)
                    {
                        textBoxFifo.Text += fifoEl[j] + " ";

                        if (fifoEl[j] == fifoEl[count])
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
                        textBoxFifo.Text += "Drop: " + fifoEl[0] + "  Add:" + fifoEl[count] + Environment.NewLine;
                        faultFIFO++;

                        for (int num = 0; num < Convert.ToInt32(frameCount.Value) - 1; num++)
                        {
                            fifoEl[num] = fifoEl[num + 1];
                        }

                        fifoEl[Convert.ToInt32(frameCount.Value) - 1] = fifoEl[count];
                    }
                }

                for (int count = 0; count != Convert.ToInt32(frameCount.Value); count++)
                {
                    textBoxFifo.Text += fifoEl[count] + " ";
                }

                textBoxFifo.Text += Environment.NewLine + "All drops: " + Convert.ToString(faultFIFO);
            }

            catch
            { 
                MessageBox.Show("Incorrect data", "Error"); 
            }
        }

        private void lru()
        {
            try
            {
                for (int count = Convert.ToInt32(frameCount.Value); count != lruEl.Length; count++)
                {
                    for (int num = 0; num != Convert.ToInt32(frameCount.Value); num++)
                    {
                        textBoxLru.Text += lruEl[num] + " ";
                    }

                    bool pageFault = true;

                    for (int num = 0; num != Convert.ToInt32(frameCount.Value); num++)
                    {
                        if (lruEl[num] == lruEl[count])
                        {
                            pageFault = false;

                            for (int k = num; k != Convert.ToInt32(frameCount.Value) - 1; k++)
                            {
                                lruEl[k] = lruEl[k + 1];
                            }

                            lruEl[Convert.ToInt32(frameCount.Value) - 1] = lruEl[count];
                        }
                    }

                    if (pageFault == false)
                    {
                        textBoxLru.Text += Environment.NewLine + "Move values";
                    }

                    textBoxLru.Text += Environment.NewLine;

                    if (pageFault == true)
                    {
                        textBoxLru.Text += "Drop: " + lruEl[0] + "  Add:" + lruEl[count] + Environment.NewLine;
                        faultLRU++;

                        for (int num = 0; num < Convert.ToInt32(frameCount.Value) - 1; num++)
                        {
                            lruEl[num] = lruEl[num + 1];
                        }

                        lruEl[Convert.ToInt32(frameCount.Value) - 1] = lruEl[count];
                    }
                }

                for (int j = 0; j != Convert.ToInt32(frameCount.Value); j++)
                {
                    textBoxLru.Text += lruEl[j] + " ";
                }

                textBoxLru.Text += Environment.NewLine + "All drops: " + Convert.ToString(faultLRU);
            }

            catch
            {
                MessageBox.Show("Incorrect data", "Error");
            }
        }

        private void output()
        {
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
    }
}
