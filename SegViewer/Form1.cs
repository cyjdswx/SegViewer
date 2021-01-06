﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using itk.simple;

using PixelId = itk.simple.PixelIDValueEnum;

namespace SegViewer
{
    public partial class mainForm : Form
    {
        private Bitmap T1imageBMP;
        private Bitmap T2imageBMP;
        private Bitmap Annot1imageBMP;
        private Bitmap Annot2imageBMP;
        private Bitmap T1AdjustedBmp;
        private Bitmap T2AdjustedBmp;
        private Byte[] T1Buffer;
        private Byte[] T2Buffer;
        private Byte[] Annot1Buffer;
        private Byte[] Annot2Buffer;
        private bool T1Flag = false;
        private bool T2Flag = false;
        private bool Annot1Flag = false;
        private bool Annot2Flag = false;
        private bool[] patientCheckFlag;
        private bool[] patientFinishFlag;
        private int T1Width;
        private int T1Height;
        private int T1Slice;
        private int T2Width;
        private int T2Height;
        private int T2Slice;
        private int preIndex = -1;
        private string[] patientList;
        private string T1_name;
        private string T2_name;
        private string A1_name;
        private string A2_name;
        string rootPath;
        private int questionNum = 3;
        private int[,] answer;

        float[][] ContrastArray = {
                            new float[] {1.0f, 0, 0, 0, 0},
                            new float[] {0, 1.0f, 0, 0, 0},
                            new float[] {0, 0 , 1.0f, 0, 0},
                            new float[] {0, 0, 0, 1.0f, 0},
                            new float[] {0, 0, 0, 0, 1.0f}};
        float gamma = 1.0f;

        public mainForm()
        {
            InitializeComponent();
        }
        [STAThread]
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "Please select image folder";
            dialog.SelectedPath = "C:\\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                rootPath = dialog.SelectedPath;
                string T1Path = Path.Combine(rootPath, "T1WI");
                string T2Path = Path.Combine(rootPath, "T2WI");
                string annot1Path = Path.Combine(rootPath, "annotation1");
                string annot2Path = Path.Combine(rootPath, "annotation2");
                if(!Directory.Exists(T1Path) || !Directory.Exists(T2Path)
                    || !Directory.Exists(annot1Path) || !Directory.Exists(annot2Path))
                {
                    MessageBox.Show("Please select correct path!", "Error");
                    return;
                }
                var T1files = Directory.GetFiles(Path.Combine(rootPath, "T1WI"), "*.nii.gz");
                //var T2files = Directory.GetFiles(T2Path, "*.nii.gz");
                //var annot1files = Directory.GetFiles(annot1Path, "*.nii.gz");
                //var annot2files = Directory.GetFiles(annot2Path, "*.nii.gz");
                //patientList = new string[T1files.Length];
                this.dataListView.Items.Clear();
                List<string> tmpList = new List<string>();
                for (int i = 0; i < T1files.Length; ++i)
                {
                    if (T1files[i].EndsWith(".nii.gz"))
                    {
                        //lv.SubItems.Add("X");
                        var filenames = Path.GetFileName(T1files[i]).Split(new char[] { '.' })[0].Split('_');
                        if (filenames.Length < 3)
                        {
                            MessageBox.Show("Incorrect image files, please check!", "Error");
                            return;
                        }
                        string patientName = filenames[0];
                        string T2FileName = string.Concat(filenames[0], "_T2_", filenames[2], ".nii.gz");
                        string a1FileName = string.Concat(filenames[0], "_T1_annotation1", ".nii.gz");
                        string a2FileName = string.Concat(filenames[0], "_T1_annotation2", ".nii.gz");
                        if (File.Exists(Path.Combine(Path.Combine(rootPath, "T2WI"), T2FileName))
                            && File.Exists(Path.Combine(Path.Combine(rootPath, "annotation1"), a1FileName))
                            && File.Exists(Path.Combine(Path.Combine(rootPath, "annotation2"), a2FileName)))
                        {
                            ListViewItem lv = new ListViewItem(patientName, 0);
                            this.dataListView.Items.Add(lv);
                            this.dataListView.Items[i].SubItems.Add("");
                            tmpList.Add(patientName);
                        }
                        else
                        {
                            MessageBox.Show("Cannot find corresponding image data, please check!", "Error");
                            return;
                        }
                    }
                }
                patientList = tmpList.ToArray();
                // clear current button
                foreach (RadioButton rb in this.Q1Box.Controls.OfType<RadioButton>())
                {
                    rb.Checked = false;
                }
                foreach (CheckBox cb in this.Q1Box.Controls.OfType<CheckBox>())
                {
                    cb.Checked = false;
                }
                foreach (RadioButton rb in this.Q2Box.Controls.OfType<RadioButton>())
                {
                    rb.Checked = false;
                }
                foreach (CheckBox cb in this.Q2Box.Controls.OfType<CheckBox>())
                {
                    cb.Checked = false;
                }
                foreach (RadioButton rb in this.Q3Box.Controls.OfType<RadioButton>())
                {
                    rb.Checked = false;
                }
                foreach (CheckBox cb in this.Q3Box.Controls.OfType<CheckBox>())
                {
                    cb.Checked = false;
                }

                answer = new int[T1files.Length, 9];
                patientCheckFlag = new bool[T1files.Length];
                patientFinishFlag = new bool[T1files.Length];
                for (int i = 0; i < T1files.Length; ++i)
                {
                    patientCheckFlag[i] = false;
                    patientFinishFlag[i] = false;
                    for (int j = 0; j < 9; ++j)
                    {
                        answer[i, j] = 0;
                    }
                }

                this.dataListView.Items[0].Focused = true;
                this.dataListView.Items[0].Selected = true;

                if (File.Exists(Path.Combine(rootPath, "QuestionaireResult.txt")))
                {
                    // read results.
                    string[] lines = File.ReadAllLines(Path.Combine(rootPath, "QuestionaireResult.txt"));
                    if (lines.Length == patientList.Length)
                    {
                        for (int i = 0; i < lines.Length; ++i)
                        {
                            string[] line_s = lines[i].Split(' ');
                            if (line_s[0] == patientList[i] && line_s[1] != "-1")
                            {
                                patientCheckFlag[i] = true;
                                patientFinishFlag[i] = true;
                                this.dataListView.Items[i].SubItems[1].Text = "X";
                                for (int j = 0; j < line_s.Length - 1; ++j)
                                {
                                    answer[i, j] = Int32.Parse(line_s[j + 1]);
                                }
                            }
                        }
                    }
                }
                
                List<GroupBox> QBoxlist = new List<GroupBox>();
                QBoxlist.Add(Q1Box);
                QBoxlist.Add(Q2Box);
                QBoxlist.Add(Q3Box);
                for (int i = 0; i < questionNum; ++i)
                {
                    var radioButtons = QBoxlist[i].Controls.OfType<RadioButton>().ToArray();
                    if (answer[this.dataListView.FocusedItem.Index, i * 3] > 0)
                    {
                        radioButtons[answer[this.dataListView.FocusedItem.Index, i * 3] - 1].Checked = true;
                    }
                    else
                    {
                        radioButtons[0].Checked = false;
                        radioButtons[1].Checked = false;
                        radioButtons[2].Checked = false;
                    }

                    var checkBoxes = QBoxlist[i].Controls.OfType<CheckBox>().ToArray();
                    if (answer[this.dataListView.FocusedItem.Index, i * 3 + 1] == 1)
                    {
                        checkBoxes[0].Checked = true;
                    }
                    else
                    {
                        checkBoxes[0].Checked = false;
                    }
                    if (answer[this.dataListView.FocusedItem.Index, i * 3 + 2] == 1)
                    {
                        checkBoxes[1].Checked = true;
                    }
                    else
                    {
                        checkBoxes[1].Checked = false;
                    }
                }
                preIndex = 0;
                
            }
        }
        private void T1Display(string rootPath, int index)
        {
            T1_name = string.Concat(patientList[index], "_T1_0000.nii.gz");
            string T1ImagePath = Path.Combine(Path.Combine(rootPath, "T1WI"), T1_name);
            itk.simple.Image input = SimpleITK.ReadImage(T1ImagePath);
            input = SimpleITK.Cast(input, PixelId.sitkFloat32);

            // load the range of grayscale
            MinimumMaximumImageFilter filter = new MinimumMaximumImageFilter();
            filter.Execute(input);
            double ImageHighestIntensity = filter.GetMaximum();
            double ImageLowestIntensity = filter.GetMinimum();
            filter.Dispose();

            // calculate the number of pixels
            VectorUInt32 size = input.GetSize();
            int len = 1;
            T1Width = (int)size[0];
            T1Height = (int)size[1];
            if (input.GetDimension() >= 2)
            {
                T1Slice = (int)size[2];
            }
            else
            {
                T1Slice = 1;
            }
            for (int dim = 0; dim < input.GetDimension(); dim++)
            {
                len *= (int)size[dim];
            }
            IntPtr buffer = input.GetBufferAsFloat();
            float[] bufferAsArray = new float[len];
            Marshal.Copy(buffer, bufferAsArray, 0, len);
            T1Buffer = new Byte[len * 3]; //RGB

            // *rotate and scale
            T1Width = (int)size[1];
            T1Height = (int)size[0];
            for (int i = 0; i < T1Slice; ++i)
            {
                for (int j = 0; j < T1Height; ++j)
                {
                    for (int k = 0; k < T1Width; ++k)
                    {
                        T1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height)] = (Byte)(bufferAsArray[j + T1Height * (T1Width - 1 - k) + i * T1Width * T1Height] / ImageHighestIntensity * 255);
                        T1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 1] = (Byte)(bufferAsArray[j + T1Height * (T1Width - 1 - k) + i * T1Width * T1Height] / ImageHighestIntensity * 255);
                        T1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 2] = (Byte)(bufferAsArray[j + T1Height * (T1Width - 1 - k) + i * T1Width * T1Height] / ImageHighestIntensity * 255);
                    }
                }
            }
            /*
            for (int i = 0; i < len; ++i)
            {
                T1Buffer[3 * i] = (Byte)(bufferAsArray[i] / ImageHighestIntensity * 255);
                T1Buffer[3 * i + 1] = (Byte)(bufferAsArray[i] / ImageHighestIntensity * 255);
                T1Buffer[3 * i + 2] = (Byte)(bufferAsArray[i] / ImageHighestIntensity * 255);
            }
            */
            //display orignal image
            T1imageBMP = new Bitmap(T1Width, T1Height, PixelFormat.Format24bppRgb);
            var BoundsRect = new Rectangle(0, 0, T1Width, T1Height);
            BitmapData bmpData = T1imageBMP.LockBits(BoundsRect,
                                            ImageLockMode.WriteOnly,
                                            T1imageBMP.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int stride = bmpData.Stride;
            //int offset = stride - T1Width;
            int offset = stride - T1Width * 3;
            int alignedBytes = bmpData.Stride * T1Height;
            byte[] alignedBuffer = new byte[alignedBytes];
            //move data to bitmap(scaled and alignment)
            for (int i = 0; i < T1Height; ++i)
            {
                Array.Copy(T1Buffer, T1Width * 3 * i, alignedBuffer, stride * i, T1Width * 3);
            }
            Marshal.Copy(alignedBuffer, 0, ptr, alignedBytes);
            T1imageBMP.UnlockBits(bmpData);

            // contrast and brightness
            T1AdjustedBmp = new Bitmap(T1Width, T1Height, PixelFormat.Format24bppRgb);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ContrastArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(T1AdjustedBmp);
            g.DrawImage(T1imageBMP, new Rectangle(0, 0, T1AdjustedBmp.Width, T1AdjustedBmp.Height)
                        , 0, 0, T1imageBMP.Width, T1imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
            // Create font and brush.
            Font drawFont = new Font("Arial", 14, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            // Draw at upper-left corner.
            g.DrawString(T1_name, drawFont, drawBrush, 0.0f, 10.0f);
            this.OriT1.Image = T1AdjustedBmp;

            T1Flag = true;
            Annot1Flag = false;
            Annot2Flag = false;

            //Display image for annotation1
            Annot1imageBMP = new Bitmap(T1Width, T1Height, PixelFormat.Format24bppRgb);
            //Annot1AdjustedBMP = new Bitmap(T1Width, T1Height, PixelFormat.Format24bppRgb);
            DiaplayImage(T1Width, T1Height, 0, T1Buffer, ref Annot1imageBMP, ref Annotation1);

            //Display image for annotation2
            Annot2imageBMP = new Bitmap(T1Width, T1Height, PixelFormat.Format24bppRgb);
            //Annot2AdjustedBMP = new Bitmap(T1Width, T1Height, PixelFormat.Format24bppRgb);
            DiaplayImage(T1Width, T1Height, 0, T1Buffer, ref Annot2imageBMP, ref Annotation2);

            this.saveInfoDisplay.ForeColor = System.Drawing.Color.Green;
            this.saveInfoDisplay.Text = "Ready to write";
            //this.T1ScrollBar.Value = 0;

            // setScrollbar range
            this.T1ScrollBar.Value = 0;
            this.T1ScrollBar.Maximum = T1Slice + this.T1ScrollBar.LargeChange - 2;
            string indexText = string.Format("1 of {0}", T1Slice);
            this.T1Index.Text = indexText;

            this.Annot1ScrollBar.Value = 0;
            Annot1ScrollBar.Maximum = T1Slice + Annot1ScrollBar.LargeChange - 2;
            indexText = string.Format("1 of {0}", T1Slice);
            Annot1Index.Text = indexText;

            this.Annot2ScrollBar.Value = 0;
            Annot2ScrollBar.Maximum = T1Slice + Annot2ScrollBar.LargeChange - 2;
            indexText = string.Format("1 of {0}", T1Slice);
            Annot2Index.Text = indexText;
        }
        private void T2Display(string T2Path, int index)
        {
            T2_name = string.Concat(patientList[index], "_T2_0000.nii.gz");
            string T2ImagePath = Path.Combine(T2Path, T2_name);
            itk.simple.Image input = SimpleITK.ReadImage(T2ImagePath);
            input = SimpleITK.Cast(input, PixelId.sitkFloat32);

            // load the range of grayscale
            MinimumMaximumImageFilter filter = new MinimumMaximumImageFilter();
            filter.Execute(input);
            double ImageHighestIntensity = filter.GetMaximum();
            double ImageLowestIntensity = filter.GetMinimum();
            filter.Dispose();

            // calculate the number of pixels
            VectorUInt32 size = input.GetSize();
            int len = 1;
            T2Width = (int)size[0];
            T2Height = (int)size[1];
            if (input.GetDimension() >= 2)
            {
                T2Slice = (int)size[2];
            }
            else
            {
                T2Slice = 1;
            }
            for (int dim = 0; dim < input.GetDimension(); dim++)
            {
                len *= (int)size[dim];
            }
            IntPtr buffer = input.GetBufferAsFloat();
            float[] bufferAsArray = new float[len];
            Marshal.Copy(buffer, bufferAsArray, 0, len);
            T2Buffer = new Byte[len * 3];  //RGB

            // *rotate and scale
            T2Width = (int)size[1];
            T2Height = (int)size[0];
            for (int i = 0; i < T2Slice; ++i)
            {
                for (int j = 0; j < T2Height; ++j)
                {
                    for (int k = 0; k < T2Width; ++k)
                    {
                        T2Buffer[3 * (k + j * T2Width + i * T2Width * T2Height)] = (Byte)(bufferAsArray[j + T2Height * (T2Width - 1 - k) + i * T2Width * T2Height] / ImageHighestIntensity * 255);
                        T2Buffer[3 * (k + j * T2Width + i * T2Width * T2Height) + 1] = (Byte)(bufferAsArray[j + T2Height * (T2Width - 1 - k) + i * T2Width * T2Height] / ImageHighestIntensity * 255);
                        T2Buffer[3 * (k + j * T2Width + i * T2Width * T2Height) + 2] = (Byte)(bufferAsArray[j + T2Height * (T2Width - 1 - k) + i * T2Width * T2Height] / ImageHighestIntensity * 255);
                    }
                }
            }
            /*
            for (int i = 0; i < len; ++i)
            {
                T2Buffer[3 * i] = (Byte)(bufferAsArray[i] / ImageHighestIntensity * 255);
                T2Buffer[3 * i + 1] = (Byte)(bufferAsArray[i] / ImageHighestIntensity * 255);
                T2Buffer[3 * i + 2] = (Byte)(bufferAsArray[i] / ImageHighestIntensity * 255);
            }
            */
            T2imageBMP = new Bitmap(T2Width, T2Height, PixelFormat.Format24bppRgb);
            var BoundsRect = new Rectangle(0, 0, T2Width, T2Height);
            BitmapData bmpData = T2imageBMP.LockBits(BoundsRect,
                                            ImageLockMode.WriteOnly,
                                            T2imageBMP.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int stride = bmpData.Stride;
            int offset = stride - T2Width * 3;
            int alignedBytes = bmpData.Stride * T2Height;
            byte[] alignedBuffer = new byte[alignedBytes];
            //move data to bitmap(scaled and alignment)
            for (int i = 0; i < T2Height; ++i)
            {
                Array.Copy(T2Buffer, T2Width * 3 * i, alignedBuffer, stride * i, T2Width * 3);
            }
            Marshal.Copy(alignedBuffer, 0, ptr, alignedBytes);
            T2imageBMP.UnlockBits(bmpData);

            this.OriT2.Image = T2imageBMP;

            // contrast and brightness
            T2AdjustedBmp = new Bitmap(T2Width, T2Height, PixelFormat.Format24bppRgb);
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ContrastArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            Graphics g = Graphics.FromImage(T2AdjustedBmp);
            g.DrawImage(T2imageBMP, new Rectangle(0, 0, T2AdjustedBmp.Width, T2AdjustedBmp.Height)
                        , 0, 0, T2imageBMP.Width, T2imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
            // Create font and brush.
            Font drawFont = new Font("Arial", 14, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            // Draw at upper-left corner.
            g.DrawString(T2_name, drawFont, drawBrush, 0.0f, 10.0f);
            this.OriT2.Image = T2AdjustedBmp;
            // setScrollbar range
            this.T2ScrollBar.Value = 0;
            if (input.GetDimension() >= 2)
            {
                this.T2ScrollBar.Maximum = T2Slice;
                this.T2ScrollBar.Maximum += this.T2ScrollBar.LargeChange - 2;
            }
            string indexText = string.Format("1 of {0}", T1Slice);
            this.T2Index.Text = indexText;
            T2Flag = true;
        }

        private void annot1Display(string a1Path, int index)
        {
            A1_name = string.Concat(patientList[index], "_T1_annotation1.nii.gz"); 
            string a1ImagePath = Path.Combine(a1Path, A1_name);
            itk.simple.Image input = SimpleITK.ReadImage(a1ImagePath);
            input = SimpleITK.Cast(input, PixelId.sitkFloat32);
            MinimumMaximumImageFilter filter = new MinimumMaximumImageFilter();
            filter.Execute(input);
            double MaskHighestIntensity = filter.GetMaximum();
            double MaskLowestIntensity = filter.GetMinimum();
            filter.Dispose();
            VectorUInt32 size = input.GetSize();

            if (size[0] != T1Width || size[1] != T1Height || size[2] != T1Slice || MaskHighestIntensity > 1)
            {
                MessageBox.Show("Annotation mask error", "Error");
                return;
            }

            IntPtr buffer = input.GetBufferAsFloat();
            int len = T1Height * T1Width * T1Slice;
            float[] bufferAsArray = new float[len];
            Marshal.Copy(buffer, bufferAsArray, 0, len);
            Annot1Buffer = new Byte[len * 3];    //BGR

            // *rotate and scale
            for (int i = 0; i < T1Slice; ++i)
            {
                for (int j = 0; j < T1Height; ++j)
                {
                    for (int k = 0; k < T1Width; ++k)
                    {
                        Annot1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height)] = T1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height)];
                        Annot1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 1] = T1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 1];
                        Annot1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 2] = (Byte)(Math.Min(255, (int)T1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 2] + 100 * (int)bufferAsArray[j + T1Height * (T1Width - 1 - k) + i * T1Width * T1Height]));
                    }
                }
            }
            /*
            for (int i = 0; i < len; ++i)
            {
                Annot1Buffer[3 * i] = T1Buffer[3 * i];
                Annot1Buffer[3 * i + 1] = T1Buffer[3 * i + 1];
                Annot1Buffer[3 * i + 2] = (Byte)(Math.Min(255, (int)T1Buffer[3 * i + 2] + 100 * (int)bufferAsArray[i]));
            }
            */
            //Display image for annotation1
            Annot1imageBMP = new Bitmap(T1Width, T1Height, PixelFormat.Format24bppRgb);
            DiaplayImage(T1Width, T1Height, this.Annot1ScrollBar.Value, Annot1Buffer, ref Annot1imageBMP, ref Annotation1);
            Graphics g = Graphics.FromImage(Annot1imageBMP);
            // Create font and brush.
            Font drawFont = new Font("Arial", 14, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            // Draw at upper-left corner.
            g.DrawString(A1_name, drawFont, drawBrush, 0.0f, 10.0f);
            Annot1Flag = true;
        }
        private void annot2Display(string a2Path, int index)
        {
            A2_name = string.Concat(patientList[index], "_T1_annotation2.nii.gz");
            string a2ImagePath = Path.Combine(a2Path, A2_name);
            itk.simple.Image input = SimpleITK.ReadImage(a2ImagePath);
            input = SimpleITK.Cast(input, PixelId.sitkFloat32);
            MinimumMaximumImageFilter filter = new MinimumMaximumImageFilter();
            filter.Execute(input);
            double MaskHighestIntensity = filter.GetMaximum();
            double MaskLowestIntensity = filter.GetMinimum();
            filter.Dispose();
            VectorUInt32 size = input.GetSize();

            if (size[0] != T1Width || size[1] != T1Height || size[2] != T1Slice || MaskHighestIntensity > 1)
            {
                MessageBox.Show("Annotation mask error", "Error");
                return;
            }

            IntPtr buffer = input.GetBufferAsFloat();
            int len = T1Height * T1Width * T1Slice;
            float[] bufferAsArray = new float[len];
            Marshal.Copy(buffer, bufferAsArray, 0, len);
            Annot2Buffer = new Byte[len * 3];    //BGR
                                                 // *rotate and scale
            for (int i = 0; i < T1Slice; ++i)
            {
                for (int j = 0; j < T1Height; ++j)
                {
                    for (int k = 0; k < T1Width; ++k)
                    {
                        Annot2Buffer[3 * (k + j * T1Width + i * T1Width * T1Height)] = T1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height)];
                        Annot2Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 1] = T1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 1];
                        Annot2Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 2] = (Byte)(Math.Min(255, (int)T1Buffer[3 * (k + j * T1Width + i * T1Width * T1Height) + 2] + 100 * (int)bufferAsArray[j + T1Height * (T1Width - 1 - k) + i * T1Width * T1Height]));
                    }
                }
            }
            /*
            for (int i = 0; i < len; ++i)
            {
                Annot2Buffer[3 * i] = T1Buffer[3 * i];
                Annot2Buffer[3 * i + 1] = T1Buffer[3 * i + 1];
                Annot2Buffer[3 * i + 2] = (Byte)(Math.Min(255, (int)T1Buffer[3 * i + 2] + 100 * (int)bufferAsArray[i])); ;
            }
            */
            //Display image for annotation2
            Annot2imageBMP = new Bitmap(T1Width, T1Height, PixelFormat.Format24bppRgb);
            DiaplayImage(T1Width, T1Height, this.Annot2ScrollBar.Value, Annot2Buffer, ref Annot2imageBMP, ref Annotation2);
            Graphics g = Graphics.FromImage(Annot2imageBMP);
            // Create font and brush.
            Font drawFont = new Font("Arial", 14, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            // Draw at upper-left corner.
            g.DrawString(A2_name, drawFont, drawBrush, 0.0f, 10.0f);
            Annot2Flag = true;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void T1ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            if (T1Slice > 1)
            {
                DiaplayImage(T1Width, T1Height, this.T1ScrollBar.Value, T1Buffer, ref T1imageBMP, ref OriT1);
                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.ClearColorMatrix();
                imageAttributes.SetColorMatrix(new ColorMatrix(ContrastArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
                Graphics g = Graphics.FromImage(T1AdjustedBmp);
                g.DrawImage(T1imageBMP, new Rectangle(0, 0, T1AdjustedBmp.Width, T1AdjustedBmp.Height)
                            , 0, 0, T1imageBMP.Width, T1imageBMP.Height,
                            GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T1_name, drawFont, drawBrush, 0.0f, 10.0f);
                this.OriT1.Image = T1AdjustedBmp;

                string indexText = string.Format("{0} of {1}", this.T1ScrollBar.Value + 1, T1Slice);
                this.T1Index.Text = indexText;
                if(this.synCheck.Checked)
                {
                    this.Annot1ScrollBar.Value = this.T1ScrollBar.Value;
                    this.Annot2ScrollBar.Value = this.T1ScrollBar.Value;
                    if(T2Flag && T2Slice == T1Slice)
                    {
                        this.T2ScrollBar.Value = this.T1ScrollBar.Value;
                    }
                }
            }
        }

        private void T2ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            if (T2Slice > 1)
            {
                DiaplayImage(T2Width, T2Height, this.T2ScrollBar.Value, T2Buffer, ref T2imageBMP, ref OriT2);
                ImageAttributes imageAttributes = new ImageAttributes();
                imageAttributes.ClearColorMatrix();
                imageAttributes.SetColorMatrix(new ColorMatrix(ContrastArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
                Graphics g = Graphics.FromImage(T2AdjustedBmp);
                g.DrawImage(T2imageBMP, new Rectangle(0, 0, T2AdjustedBmp.Width, T2AdjustedBmp.Height)
                            , 0, 0, T2imageBMP.Width, T2imageBMP.Height,
                            GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T2_name, drawFont, drawBrush, 0.0f, 10.0f);
                this.OriT2.Image = T2AdjustedBmp;

                string indexText = string.Format("{0} of {1}", this.T2ScrollBar.Value + 1, T2Slice);
                this.T2Index.Text = indexText;

                if (this.synCheck.Checked && T1Flag && T2Slice == T1Slice)
                {
                    this.T1ScrollBar.Value = this.T2ScrollBar.Value;
                    this.Annot1ScrollBar.Value = this.T2ScrollBar.Value;
                    this.Annot2ScrollBar.Value = this.T2ScrollBar.Value;
                }
            }
        }

        private void A1ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            if (T1Slice > 1)
            {
                if (!Annot1Flag)
                {
                    DiaplayImage(T1Width, T1Height, this.Annot1ScrollBar.Value, T1Buffer, ref Annot1imageBMP, ref Annotation1);
                    string indexText = string.Format("{0} of {1}", this.Annot1ScrollBar.Value + 1, T1Slice);
                    this.Annot1Index.Text = indexText;
                }
                else
                {
                    DiaplayImage(T1Width, T1Height, this.Annot1ScrollBar.Value, Annot1Buffer, ref Annot1imageBMP, ref Annotation1);
                    Graphics g = Graphics.FromImage(Annot1imageBMP);
                    // Create font and brush.
                    Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                    SolidBrush drawBrush = new SolidBrush(Color.Red);
                    // Draw at upper-left corner.
                    g.DrawString(A1_name, drawFont, drawBrush, 0.0f, 10.0f);
                    string indexText = string.Format("{0} of {1}", this.Annot1ScrollBar.Value + 1, T1Slice);
                    this.Annot1Index.Text = indexText;
                }
                if (this.synCheck.Checked)
                {
                    this.T1ScrollBar.Value = this.Annot1ScrollBar.Value;
                    this.Annot2ScrollBar.Value = this.Annot1ScrollBar.Value;
                    if (T2Flag && T2Slice == T1Slice)
                    {
                        this.T2ScrollBar.Value = this.Annot1ScrollBar.Value;
                    }
                }
            }
        }

        private void A2ScrollBar_ValueChanged(object sender, EventArgs e)
        {
            if (T1Slice > 1)
            {
                if(!Annot2Flag)
                {
                    DiaplayImage(T1Width, T1Height, this.Annot2ScrollBar.Value, T1Buffer, ref Annot2imageBMP, ref Annotation2);
                    string indexText = string.Format("{0} of {1}", this.Annot2ScrollBar.Value + 1, T1Slice);
                    this.Annot2Index.Text = indexText;
                }
                else
                {
                    DiaplayImage(T1Width, T1Height, this.Annot2ScrollBar.Value, Annot2Buffer, ref Annot2imageBMP, ref Annotation2);
                    Graphics g = Graphics.FromImage(Annot2imageBMP);
                    // Create font and brush.
                    Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                    SolidBrush drawBrush = new SolidBrush(Color.Red);
                    // Draw at upper-left corner.
                    g.DrawString(A2_name, drawFont, drawBrush, 0.0f, 10.0f);
                    string indexText = string.Format("{0} of {1}", this.Annot2ScrollBar.Value + 1, T1Slice);
                    this.Annot2Index.Text = indexText;
                }
                if (this.synCheck.Checked)
                {
                    this.T1ScrollBar.Value = this.Annot2ScrollBar.Value;
                    this.Annot1ScrollBar.Value = this.Annot2ScrollBar.Value;
                    if (T2Flag && T2Slice == T1Slice)
                    {
                        this.T2ScrollBar.Value = this.Annot2ScrollBar.Value;
                    }
                }
            }
        }
        
        private void DiaplayImage(int width, int height, int slice, byte[] buffer, ref Bitmap image, ref PictureBox pBox)
        {
            //image = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            var BoundsRect = new Rectangle(0, 0, width, height);
            BitmapData bmpData = image.LockBits(BoundsRect,
                                            ImageLockMode.WriteOnly,
                                            image.PixelFormat);
            IntPtr ptr = bmpData.Scan0;
            int stride = bmpData.Stride;
            int offset = stride - width * 3;
            int alignedBytes = bmpData.Stride * height;
            byte[] alignedBuffer = new byte[alignedBytes];
            //move data to bitmap(scaled and alignment)
            for (int i = 0; i < height; ++i)
            {
                //Marshal.Copy(scaledBuffer, i, alignedBuffer, (int)size[0]);
                Array.Copy(buffer, width * 3 * i + slice * width * height * 3, alignedBuffer, stride * i, width * 3);
            }
            Marshal.Copy(alignedBuffer, 0, ptr, alignedBytes);
            image.UnlockBits(bmpData);

            pBox.Image = image;
        }

        private void Contrast_ValueChanged(object sender, EventArgs e)
        {
            float contrast = ((float)this.ContrastScrollbar.Value + 1) / 50;
            Graphics g;
            ContrastArray[0][0] = contrast;
            ContrastArray[1][1] = contrast;
            ContrastArray[2][2] = contrast;
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ContrastArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            //oriT1
            if (T1Flag)
            {
                g = Graphics.FromImage(T1AdjustedBmp);
                g.DrawImage(T1imageBMP, new Rectangle(0, 0, T1AdjustedBmp.Width, T1AdjustedBmp.Height)
                        , 0, 0, T1imageBMP.Width, T1imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T1_name, drawFont, drawBrush, 0.0f, 10.0f);
                OriT1.Image = T1AdjustedBmp;
            }
            if (T2Flag)
            {
                //T2
                g = Graphics.FromImage(T2AdjustedBmp);
                g.DrawImage(T2imageBMP, new Rectangle(0, 0, T2AdjustedBmp.Width, T2AdjustedBmp.Height)
                        , 0, 0, T2imageBMP.Width, T2imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T2_name, drawFont, drawBrush, 0.0f, 10.0f);
                OriT2.Image = T2AdjustedBmp;
            }
            string indexText = string.Format("Contrast: {0}", this.ContrastScrollbar.Value + 1);
            this.ContrastLabel.Text = indexText;
        }

        private void Brightness_ValueChanged(object sender, EventArgs e)
        {
            float brightness = ((float)this.BrightnessScrollbar.Value + 1) / 100 - 0.5f;
            Graphics g;
            ContrastArray[4][0] = brightness;
            ContrastArray[4][1] = brightness;
            ContrastArray[4][2] = brightness;
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ContrastArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            if (T1Flag)
            {
                g = Graphics.FromImage(T1AdjustedBmp);
                g.DrawImage(T1imageBMP, new Rectangle(0, 0, T1AdjustedBmp.Width, T1AdjustedBmp.Height)
                        , 0, 0, T1imageBMP.Width, T1imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T1_name, drawFont, drawBrush, 0.0f, 10.0f);
                OriT1.Image = T1AdjustedBmp;
            }
            if(T2Flag)
            {
                //T2
                g = Graphics.FromImage(T2AdjustedBmp);
                g.DrawImage(T2imageBMP, new Rectangle(0, 0, T2AdjustedBmp.Width, T2AdjustedBmp.Height)
                        , 0, 0, T2imageBMP.Width, T2imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T2_name, drawFont, drawBrush, 0.0f, 10.0f);
                OriT2.Image = T2AdjustedBmp;
            }
            string indexText = string.Format("Brightness: {0}", this.BrightnessScrollbar.Value + 1);
            this.brightnessLabel.Text = indexText;
        }

        private void ContrastReset_Click(object sender, EventArgs e)
        {
            Graphics g;
            ContrastArray[0][0] = 1;
            ContrastArray[1][1] = 1;
            ContrastArray[2][2] = 1;
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ContrastArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            //oriT1
            if (T1Flag)
            {
                g = Graphics.FromImage(T1AdjustedBmp);
                g.DrawImage(T1imageBMP, new Rectangle(0, 0, T1AdjustedBmp.Width, T1AdjustedBmp.Height)
                        , 0, 0, T1imageBMP.Width, T1imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T1_name, drawFont, drawBrush, 0.0f, 10.0f);
                OriT1.Image = T1AdjustedBmp;
            }
            if (T2Flag)
            {
                //T2
                g = Graphics.FromImage(T2AdjustedBmp);
                g.DrawImage(T2imageBMP, new Rectangle(0, 0, T2AdjustedBmp.Width, T2AdjustedBmp.Height)
                        , 0, 0, T2imageBMP.Width, T2imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T2_name, drawFont, drawBrush, 0.0f, 10.0f);
                OriT2.Image = T2AdjustedBmp;
            }
            this.ContrastScrollbar.Value = 49;
            string indexText = string.Format("Contrast: {0}", 50);
            this.ContrastLabel.Text = indexText;
        }

        private void BrightnessReset_Click(object sender, EventArgs e)
        {
            Graphics g;
            ContrastArray[4][0] = 0;
            ContrastArray[4][1] = 0;
            ContrastArray[4][2] = 0;
            ImageAttributes imageAttributes = new ImageAttributes();
            imageAttributes.ClearColorMatrix();
            imageAttributes.SetColorMatrix(new ColorMatrix(ContrastArray), ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
            imageAttributes.SetGamma(gamma, ColorAdjustType.Bitmap);
            //oriT1
            if (T1Flag)
            {
                g = Graphics.FromImage(T1AdjustedBmp);
                g.DrawImage(T1imageBMP, new Rectangle(0, 0, T1AdjustedBmp.Width, T1AdjustedBmp.Height)
                        , 0, 0, T1imageBMP.Width, T1imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T1_name, drawFont, drawBrush, 0.0f, 10.0f);
                OriT1.Image = T1AdjustedBmp;
            }
            if (T2Flag)
            {
                //T2
                g = Graphics.FromImage(T2AdjustedBmp);
                g.DrawImage(T2imageBMP, new Rectangle(0, 0, T2AdjustedBmp.Width, T2AdjustedBmp.Height)
                        , 0, 0, T2imageBMP.Width, T2imageBMP.Height,
                        GraphicsUnit.Pixel, imageAttributes);
                // Create font and brush.
                Font drawFont = new Font("Arial", 14, FontStyle.Bold);
                SolidBrush drawBrush = new SolidBrush(Color.Red);
                // Draw at upper-left corner.
                g.DrawString(T2_name, drawFont, drawBrush, 0.0f, 10.0f);
                OriT2.Image = T2AdjustedBmp;
            }
            this.BrightnessScrollbar.Value = 49;
            string indexText = string.Format("Brightness: {0}", 50);
            this.brightnessLabel.Text = indexText;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            // current patient
            List<GroupBox> QBoxlist = new List<GroupBox>();
            QBoxlist.Add(Q1Box);
            QBoxlist.Add(Q2Box);
            QBoxlist.Add(Q3Box);
            bool allChecked = true;
            for (int i = 0; i < questionNum; ++i)
            {
                var radioButtons = QBoxlist[i].Controls.OfType<RadioButton>().ToArray();
                bool ischecked = false;
                for (int j = 0; j < radioButtons.Length; ++j)
                {
                    if (radioButtons[j].Checked)
                    {
                        answer[this.dataListView.FocusedItem.Index, i * 3] = j + 1;
                        ischecked = true;
                        break;
                    }
                }
                if (!ischecked)
                {
                    answer[this.dataListView.FocusedItem.Index, i * 3] = 0;
                    allChecked = false;
                }
                var checkBoxes = QBoxlist[i].Controls.OfType<CheckBox>().ToArray();
                for (int j = 0; j < checkBoxes.Length; ++j)
                {
                    if (checkBoxes[j].Checked)
                    {
                        answer[this.dataListView.FocusedItem.Index, i * 3 + j + 1] = 1;
                    }
                    else
                    {
                        answer[this.dataListView.FocusedItem.Index, i * 3 + j + 1] = 0;
                    }
                }
            }
            patientCheckFlag[this.dataListView.FocusedItem.Index] = true;
            if (allChecked)
            {
                this.dataListView.Items[this.dataListView.FocusedItem.Index].SubItems[1].Text = "X";
                patientFinishFlag[this.dataListView.FocusedItem.Index] = true;
            }
            else
            {
                this.dataListView.Items[this.dataListView.FocusedItem.Index].SubItems[1].Text = "";
                patientFinishFlag[this.dataListView.FocusedItem.Index] = false;
            }

            //
            if (T1Flag && Annot1Flag && Annot2Flag)
            {
                if (File.Exists(Path.Combine(rootPath, "QuestionaireResult.txt")))
                {
                    File.Delete(Path.Combine(rootPath, "QuestionaireResult.txt"));
                }
                using (System.IO.StreamWriter file =
                    new System.IO.StreamWriter(@Path.Combine(rootPath, "QuestionaireResult.txt"), true))
                {
                    for(int i = 0;i< patientFinishFlag.Length;++i)
                    {
                        string tmpLine = patientList[i];
                        if (patientFinishFlag[i] == false)
                        {
                            tmpLine += " -1";
                            file.WriteLine(tmpLine);
                        }
                        else
                        {
                            for(int j = 0; j <9;++j)
                            {
                                tmpLine += " " + answer[i,j];
                            }
                            file.WriteLine(tmpLine);
                        }
                    }
                }
                this.saveInfoDisplay.ForeColor = System.Drawing.Color.Red;
                this.saveInfoDisplay.Text = "Save path:\n"+ Path.Combine(rootPath, "QuestionaireResult.txt");
            }
            else
            {
                MessageBox.Show("Please load T1, annotation1 and annotation2", "Error");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (RadioButton rb in this.Q1Box.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            foreach (CheckBox cb in this.Q1Box.Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            }
            foreach (RadioButton rb in this.Q2Box.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            foreach (CheckBox cb in this.Q2Box.Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            }
            foreach (RadioButton rb in this.Q3Box.Controls.OfType<RadioButton>())
            {
                rb.Checked = false;
            }
            foreach (CheckBox cb in this.Q3Box.Controls.OfType<CheckBox>())
            {
                cb.Checked = false;
            }

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            int range = patientList.Length;
            this.dataListView.Select();
            int curIndex = this.dataListView.FocusedItem.Index;
            if (curIndex < range - 1)
            {
                this.dataListView.Items[curIndex + 1].Focused = true;
                this.dataListView.Items[curIndex + 1].Selected = true;
            }
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            //int range = patientList.Length;
            this.dataListView.Select();
            int curIndex = this.dataListView.FocusedItem.Index;
            if (curIndex > 0)
            {
                this.dataListView.Items[curIndex - 1].Focused = true;
                this.dataListView.Items[curIndex - 1].Selected = true;
            }
        }

        private void DataListView_SelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // record answer
                if (preIndex >= 0)
                {
                    List<GroupBox> QBoxlist = new List<GroupBox>();
                    QBoxlist.Add(Q1Box);
                    QBoxlist.Add(Q2Box);
                    QBoxlist.Add(Q3Box);
                    bool allChecked = true;
                    for (int i = 0; i < questionNum; ++i)
                    {
                        var radioButtons = QBoxlist[i].Controls.OfType<RadioButton>().ToArray();
                        bool ischecked = false;
                        for (int j = 0; j < radioButtons.Length; ++j)
                        {
                            if (radioButtons[j].Checked)
                            {
                                answer[preIndex, i * 3] = j + 1;
                                ischecked = true;
                                break;
                            }
                        }
                        if(!ischecked)
                        {
                            answer[preIndex, i * 3] = 0;
                            allChecked = false;
                        }
                        var checkBoxes = QBoxlist[i].Controls.OfType<CheckBox>().ToArray();
                        for (int j = 0; j < checkBoxes.Length; ++j)
                        {
                            if (checkBoxes[j].Checked)
                            {
                                answer[preIndex, i * 3 + j + 1] = 1;
                            }
                            else
                            {
                                answer[preIndex, i * 3 + j + 1] = 0;
                            }
                        }
                    }
                    patientCheckFlag[preIndex] = true;
                    if (allChecked)
                    {
                        this.dataListView.Items[preIndex].SubItems[1].Text = "X";
                        patientFinishFlag[preIndex] = true;
                    }
                    else
                    {
                        this.dataListView.Items[preIndex].SubItems[1].Text = "";
                        patientFinishFlag[preIndex] = false;
                    }
                }

                string T2Path = Path.Combine(rootPath, "T2WI");
                string annot1Path = Path.Combine(rootPath, "annotation1");
                string annot2Path = Path.Combine(rootPath, "annotation2");
                // T1WI
                T1Display(rootPath,this.dataListView.FocusedItem.Index);
                //Display T2
                T2Display(T2Path, this.dataListView.FocusedItem.Index);
                //Display A1
                annot1Display(annot1Path, this.dataListView.FocusedItem.Index);
                //DIsplay A2
                annot2Display(annot2Path, this.dataListView.FocusedItem.Index);

                // load answers
                if(patientCheckFlag[this.dataListView.FocusedItem.Index] == true)
                {
                    List<GroupBox> QBoxlist = new List<GroupBox>();
                    QBoxlist.Add(Q1Box);
                    QBoxlist.Add(Q2Box);
                    QBoxlist.Add(Q3Box);
                    for (int i = 0; i < questionNum; ++i)
                    {
                        var radioButtons = QBoxlist[i].Controls.OfType<RadioButton>().ToArray();
                        if(answer[this.dataListView.FocusedItem.Index, i * 3] > 0)
                        {
                            radioButtons[answer[this.dataListView.FocusedItem.Index, i * 3] - 1].Checked = true;
                        }
                        else
                        {
                            radioButtons[0].Checked = false;
                            radioButtons[1].Checked = false;
                            radioButtons[2].Checked = false;
                        }

                        var checkBoxes = QBoxlist[i].Controls.OfType<CheckBox>().ToArray();
                        if (answer[this.dataListView.FocusedItem.Index, i * 3 + 1] == 1)
                        {
                            checkBoxes[0].Checked = true;
                        }
                        else
                        {
                            checkBoxes[0].Checked = false;
                        }
                        if (answer[this.dataListView.FocusedItem.Index, i * 3 + 2] == 1)
                        {
                            checkBoxes[1].Checked = true;
                        }
                        else
                        {
                            checkBoxes[1].Checked = false;
                        }
                    }
                }
                else
                {
                    foreach (RadioButton rb in this.Q1Box.Controls.OfType<RadioButton>())
                    {
                        rb.Checked = false;
                    }
                    foreach (CheckBox cb in this.Q1Box.Controls.OfType<CheckBox>())
                    {
                        cb.Checked = false;
                    }
                    foreach (RadioButton rb in this.Q2Box.Controls.OfType<RadioButton>())
                    {
                        rb.Checked = false;
                    }
                    foreach (CheckBox cb in this.Q2Box.Controls.OfType<CheckBox>())
                    {
                        cb.Checked = false;
                    }
                    foreach (RadioButton rb in this.Q3Box.Controls.OfType<RadioButton>())
                    {
                        rb.Checked = false;
                    }
                    foreach (CheckBox cb in this.Q3Box.Controls.OfType<CheckBox>())
                    {
                        cb.Checked = false;
                    }
                }
                preIndex = this.dataListView.FocusedItem.Index;
            }
            
        }
    }
}
