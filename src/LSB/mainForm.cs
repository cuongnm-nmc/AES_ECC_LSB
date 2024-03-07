using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace LSB
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        byte[] emData;
        string emName;
        Bitmap emImg;

        byte[] exData;
        string exName;
        Bitmap exImg;

        private byte getByte(byte[] bits)
        {
            String bitsString = "";
            for (int i = 0; i < 8; i++)
                bitsString += bits[i];
            byte binByte = Convert.ToByte(bitsString, 2);
            int decByte = (int)binByte;
            return (byte)decByte;
        }

        private byte[] getStringBits(string str)
        {
            byte[] strBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(str);
            BitArray bits = new BitArray(strBytes);
            bool[] boolBits = new bool[bits.Count];
            bits.CopyTo(boolBits, 0);
            byte[] byteBits = boolBits.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(byteBits);
            return byteBits;
        }

        private byte[] getBits(byte simplePixel)
        {
            int intPixel = (int)simplePixel;
            BitArray bits = new BitArray(new byte[] { (byte)intPixel });
            bool[] boolBits = new bool[bits.Count];
            bits.CopyTo(boolBits, 0);
            byte[] byteBits = boolBits.Select(bit => (byte)(bit ? 1 : 0)).ToArray();
            Array.Reverse(byteBits);
            return byteBits;
        }

        public Color embed(Color pixel, byte[] bits)
        {
            byte[] redBits = getBits((byte)pixel.R);
            byte[] greenBits = getBits((byte)pixel.G);
            byte[] blueBits = getBits((byte)pixel.B);

            redBits[5] = bits[0];
            greenBits[5] = bits[1];
            redBits[6] = bits[2];
            redBits[7] = bits[3];
            greenBits[6] = bits[4];
            greenBits[7] = bits[5];
            blueBits[6] = bits[6];
            blueBits[7] = bits[7];

            byte red = getByte(redBits);
            byte green = getByte(greenBits);
            byte blue = getByte(blueBits);

            return Color.FromArgb(red, green, blue);
        }

        public byte extract(Color pixel)
        {
            byte[] redBits = getBits((byte)pixel.R);
            byte[] greenBits = getBits((byte)pixel.G);
            byte[] blueBits = getBits((byte)pixel.B);
            byte[] bits = new byte[8];

            bits[0] = redBits[5];
            bits[1] = greenBits[5];
            bits[2] = redBits[6];
            bits[3] = redBits[7];
            bits[4] = greenBits[6];
            bits[5] = greenBits[7];
            bits[6] = blueBits[6];
            bits[7] = blueBits[7];

            return getByte(bits);
        }

        private void buttonBrowseEmImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap files (*.bmp,*.dib,*.png)|*.bmp;*.dib;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                emImg = new Bitmap(ofd.FileName);
                embedPictureBox.Image = emImg;

                buttonBrowseEmFile.Enabled = true;
            }
        }

        private void buttonBrowseEmFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName;
                try
                {
                    using (FileStream fs = File.Open(path, FileMode.Open))
                    {
                        emData = new BinaryReader(fs).ReadBytes((int)fs.Length);
                        emName = ofd.SafeFileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Warning", MessageBoxButtons.OK);
                    return;
                }
                embedURLTextBox.Text = path;

                embedButton.Enabled = true;
            }
        }

        private void embedButton_Click(object sender, EventArgs e)
        {
            if (emData.Length > emImg.Height * emImg.Width - 30)
            {
                MessageBox.Show("Data is larger than image size!", "Warning", MessageBoxButtons.OK);
                return;
            }

            string strEmDataLen = (Convert.ToString(emData.Length)).PadLeft(13, '0');
            char[] charEmDataLen = strEmDataLen.ToArray();

            for (int i = 0; i < 13; i++)
            {
                string str = Convert.ToString(charEmDataLen[i]);
                Color pixel = emImg.GetPixel(emImg.Width - i - 1, emImg.Height - 1);
                pixel = embed(pixel, getStringBits(str));
                emImg.SetPixel(emImg.Width - i - 1, emImg.Height - 1, pixel);
            }

            string strEmNameLen = Convert.ToString(emName.Length).PadLeft(4, '0');
            char[] charEmNameLen = strEmNameLen.ToArray();

            for (int i = 13; i < 17; i++)
            {
                string str = Convert.ToString(charEmNameLen[i - 13]);
                Color pixel = emImg.GetPixel(emImg.Width - i - 1, emImg.Height - 1);
                pixel = embed(pixel, getStringBits(str));
                emImg.SetPixel(emImg.Width - i - 1, emImg.Height - 1, pixel);
            }

            char[] charEmName = emName.ToArray();

            for (int i = 17; i < 17 + emName.Length; i++)
            {
                string str = Convert.ToString(charEmName[i - 17]);
                Color pixel = emImg.GetPixel(emImg.Width - i - 1, emImg.Height - 1);
                pixel = embed(pixel, getStringBits(str));
                emImg.SetPixel(emImg.Width - i - 1, emImg.Height - 1, pixel);
            }

            int k = 0;

            for (int i = 0; i < emImg.Height; i++)
            {
                for (int j = 0; j < emImg.Width; j++)
                {
                    if (k < emData.Length)
                    {
                        Color pixel = emImg.GetPixel(j, i);
                        pixel = embed(pixel, getBits(emData[k]));
                        emImg.SetPixel(j, i, pixel);
                        k++;
                    }
                }
            }

            embedPictureBox.Image = emImg;
            MessageBox.Show("Embedding completed.", "Notification", MessageBoxButtons.OK);

            buttonSaveEmImg.Enabled = true;
            embedButton.Enabled = false;
            buttonBrowseEmFile.Enabled = false;
            buttonBrowseEmImg.Enabled = false;
        }

        private void buttonSaveEmImg_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmap files (*.bmp)|*.bmp";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    emImg.Save(sfd.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Warning", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("Image has been saved successfully.", "Notification", MessageBoxButtons.OK);

                buttonBrowseEmImg.Enabled = true;
                buttonBrowseEmFile.Enabled = false;
                embedButton.Enabled = false;
                buttonSaveEmImg.Enabled = false;

                embedPictureBox.Image = null;
                emImg = null;

                embedURLTextBox.Text = null;
                emName = null;
                emData = null;

            }
        }

        private void buttonBrowseExImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmap files (*.bmp,*.dib,*.png)|*.bmp;*.dib;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                exImg = new Bitmap(ofd.FileName);
                extractPictureBox.Image = exImg;

                extractButton.Enabled = true;
            }
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            string strExDataLen = "";

            for (int i = 0; i < 13; i++)
            {
                Color pixel = exImg.GetPixel(exImg.Width - i - 1, exImg.Height - 1);
                byte byteEx = extract(pixel);
                strExDataLen += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(byteEx)));
            }

            int exDataLen = Convert.ToInt32(strExDataLen);

            string strExNameLen = "";

            for (int i = 13; i < 17; i++)
            {
                Color pixel = exImg.GetPixel(exImg.Width - i - 1, exImg.Height - 1);
                byte byteEx = extract(pixel);
                strExNameLen += Convert.ToInt32(Encoding.ASCII.GetString(BitConverter.GetBytes(byteEx)));
            }

            int exNameLen = Convert.ToInt32(strExNameLen);

            exName = "";

            for (int i = 17; i < 17 + exNameLen; i++)
            {
                Color pixel = exImg.GetPixel(exImg.Width - i - 1, exImg.Height - 1);
                byte byteEx = extract(pixel);
                exName += Encoding.ASCII.GetString(BitConverter.GetBytes(byteEx));
            }
            exName = exName.Replace("\0", "");

            int k = 0;
            exData = new byte[exDataLen];

            for (int i = 0; i < exImg.Height; i++)
            {
                for (int j = 0; j < exImg.Width; j++)
                {
                    if (k < exDataLen)
                    {
                        Color pixel = exImg.GetPixel(j, i);
                        byte byteEx = extract(pixel);
                        exData[k] = byteEx;
                        k++;
                    }
                }
            }
            extractNameTextBox.Text = exName;
            MessageBox.Show("Extracting completed.", "Notification", MessageBoxButtons.OK);

            buttonSaveExFile.Enabled = true;
            extractButton.Enabled = false;
            buttonBrowseExImg.Enabled = false;
        }

        private void buttonSaveExFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                string path = fbd.SelectedPath + "\\" + extractNameTextBox.Text;
                try
                {
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(exData);
                        bw.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Warning", MessageBoxButtons.OK);
                    return;
                }
                MessageBox.Show("File has been saved successfully.", "Notification", MessageBoxButtons.OK);

                buttonBrowseExImg.Enabled = true;
                extractButton.Enabled = false;
                buttonSaveExFile.Enabled = false;

                extractPictureBox.Image = null;
                exImg = null;

                extractNameTextBox.Text = null;
                exName = null;
                exData = null;
            }    
        }
    }
}