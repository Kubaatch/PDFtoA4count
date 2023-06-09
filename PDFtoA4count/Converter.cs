using System;
using System.Windows.Forms;
using Aspose;
using Aspose.Pdf;
using Aspose.Pdf.Facades;
using Form = System.Windows.Forms.Form;

namespace PDFtoA4count
{
    public partial class Converter : Form
    {
        private double width;
        private double height;
        private readonly double roundingNumber = 0.15;
        private int a4count;

        public Converter()
        {
            InitializeComponent();
        }

        private void B_SelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ResetLabels();
                foreach (string f in openFileDialog1.FileNames)
                {
                    FileOk(f);
                }
            }
        }

        private void FileOk(string fileName)
        {
            PdfFileInfo pdfFileInfo = new PdfFileInfo(fileName);

            height = Convert.ToInt32(pdfFileInfo.GetPageHeight(1));
            width = Convert.ToInt32(pdfFileInfo.GetPageWidth(1));

            MathConversion();

            if (openFileDialog1.FileNames.Length == 1)
            {
                L_PageSizeMM.Visible = true;
                L_PageSizeMM.Text += "\nWidth = " + width;
                L_PageSizeMM.Text += "\nHeight = " + height;
            }

            L_A4Count.Text = $"Total A4 Count: {a4count}";
        }

        private void MathConversion()
        {
            // 72points = 1inch = 2,54cm
            width = width / 72 * 25.4;
            height = height / 72 * 25.4;

            width = Math.Round(width, 1, MidpointRounding.AwayFromZero);
            height = Math.Round(height, 1, MidpointRounding.AwayFromZero);

            double a4widths = width / 210;
            double a4heights = height / 297;

            int a4widthsrounded = RoundEdges(a4widths);
            int a4heightsrounded = RoundEdges(a4heights);

            a4count += a4heightsrounded * a4widthsrounded;
        }

        private int RoundEdges(double input)
        {
            int output;

            if (input - Math.Truncate(input) > roundingNumber)
            {
                output = (int)Math.Truncate(input) + 1;
            }
            else
            {
                output = (int)Math.Truncate(input);
            }

            return output;
        }

        private void ResetLabels()
        {
            L_PageSizeMM.Visible = false;
            L_PageSizeMM.Text = "Page size in mm: ";
            L_A4Count.Text = "Total A4 Count: ";
            a4count = 0;
        }

        private void B_ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}