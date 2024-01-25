using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Elsa
{
    public partial class Form1 : Form
    {
        /* Global Parameters */
        string showFileName, outputFolder;
        int totalPages, currentPageNo;
        byte[] showdata;
        bool fontDefault, marginDefault, saveDefault, useCustomHeader;

        public Form1()
        {
            InitializeComponent();
            InitializeGolbalParams();
        }

        private void InitializeGolbalParams()
        {
            showFileName = outputFolder = "";
            totalPages = currentPageNo = 0;
            showdata = new byte[0];
            fontDefault = true; marginDefault = true; saveDefault = true;
            useCustomHeader = false;
        }

        private void showPdfPage(byte[] pdfFileBytes, int pageNo)
        {
            byte[] pngImageBytes = Freeware.Pdf2Png.Convert(pdfFileBytes, pageNo, 300);
            System.Drawing.Image pdfPageImage = System.Drawing.Image.FromStream(new System.IO.MemoryStream(pngImageBytes));
            Bitmap newImage = new Bitmap(310, 410);
            using (Graphics g = Graphics.FromImage(newImage))
            {
                g.DrawImage(pdfPageImage, 5, 5, 310, 410);
            }
            pdfPageImage.Dispose();
            pdfView.Image = newImage;
            pageCountTextBox.Text = pageNo.ToString();
            if (pageNo == totalPages) nextPageBtn.Enabled = false; else nextPageBtn.Enabled = true;
            if (pageNo == 1) prevPageBtn.Enabled = false; else prevPageBtn.Enabled = true;
        }

        private int getTotalPageNumber(string filePath)
        {
            PdfDocument inputDocument = PdfReader.Open(filePath, PdfDocumentOpenMode.Import);
            return inputDocument.PageCount;
        }

        private void addHeader(string pdfSourceFilePath, string pdfOutputFilePath, string textToAdd)
        {
            PdfDocument inputDocument = PdfReader.Open(pdfSourceFilePath, PdfDocumentOpenMode.Import);
            PdfDocument outputDocument = new PdfDocument();
            int allPageNo = inputDocument.PageCount;
            
            // Font and Margin Setting
            XFont font = new XFont("Arial", 9, XFontStyle.Bold);
            XBrush brush = XBrushes.Black;
            if (!fontDefault)
            {
                string slectedFontstyle = fontStyleSelect.Text;
                XFontStyle fontstyle = slectedFontstyle == "Regular" ? XFontStyle.Regular :
                    slectedFontstyle == "Bold" ? XFontStyle.Bold :
                    slectedFontstyle == "Italic" ? XFontStyle.Italic :
                    slectedFontstyle == "BoldItalic" ? XFontStyle.BoldItalic :
                    slectedFontstyle == "Underline" ? XFontStyle.Underline : XFontStyle.Strikeout;
                font = new XFont(fontFamilySelect.Text, Convert.ToSingle(fontSize.Value), fontstyle);
                string selectedFontColor = fontColorSelect.Text;
                brush = selectedFontColor == "Black" ? XBrushes.Black :
                    selectedFontColor == "Blue" ? XBrushes.Blue :
                    selectedFontColor == "Green" ? XBrushes.Green :
                    selectedFontColor == "Red" ? XBrushes.Red : XBrushes.White;
            }
            int marginTop = marginDefault ? 20 : Convert.ToInt32(topMargin.Value);
            int marginBottom = marginDefault ? 20 : Convert.ToInt32(bottomMargin.Value);
            int marginLeft = marginDefault ? 20 : Convert.ToInt32(leftMargin.Value);
            int marginRight = marginDefault ? 20 : Convert.ToInt32(rightMargin.Value);

            for (int i = 0; i < allPageNo; i++)
            {
                PdfPage page = outputDocument.AddPage(inputDocument.Pages[i]);
                XGraphics gfx = XGraphics.FromPdfPage(page);
                
                //XPoint xpoint = new XPoint(marginLeft, marginTop);
                //gfx.DrawString(Convert.ToString(i + 1), font, brush, xpoint, XStringFormats.TopLeft);
                XPoint xpoint = new XPoint(page.Width - marginRight, marginTop);
                gfx.DrawString(textToAdd, font, brush, xpoint, XStringFormats.TopRight);
                xpoint = new XPoint(marginLeft, page.Height - marginBottom);
                gfx.DrawString("Amazon Confidential", font, brush, xpoint, XStringFormats.BottomLeft);
                xpoint = new XPoint(page.Width / 2, page.Height - marginBottom);
                gfx.DrawString("Protective Services Investigations", font, brush, xpoint, XStringFormats.BottomCenter);
                xpoint = new XPoint(page.Width - marginRight, page.Height - marginBottom);
                gfx.DrawString("Page " + (i + 1) + " of " + allPageNo, font, brush, xpoint, XStringFormats.BottomRight);
            }

            outputDocument.Save(pdfOutputFilePath);
        }

        private string getHeaderStringFromFilename(string filename)
        {
            string res = "";
            int number;
            filename = System.IO.Path.GetFileNameWithoutExtension(filename);
            string[] parts = filename.Split('-');
            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out number))
                {
                    res = parts[i++];
                    for (; i < parts.Length; i++)
                    {
                        string format = "mmddyyyy";
                        DateTime date;
                        if (DateTime.TryParseExact(parts[i], format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                            return res;
                        else
                            res += ("-" + parts[i]);
                    }
                }
            }
            if (res == "") return filename;
            return res;
        }

        private string getOutputFilename(string inputfileName)
        {
            string fileName = System.IO.Path.GetFileNameWithoutExtension(inputfileName);
            fileName += ".pdf";
            return System.IO.Path.Combine(outputFolder, fileName);
        }


        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            marginDefault = !marginDefault;
            if (!marginDefault)
            {
                topMargin.Enabled = bottomMargin.Enabled
                    = leftMargin.Enabled = rightMargin.Enabled = true;
                topMarginLabel.Enabled = bottomMarginLabel.Enabled
                    = leftMarginLabel.Enabled = rightMarginLabel.Enabled = true;
            }
            else
            {
                topMargin.Enabled = bottomMargin.Enabled
                    = leftMargin.Enabled = rightMargin.Enabled = false;
                topMarginLabel.Enabled = bottomMarginLabel.Enabled
                    = leftMarginLabel.Enabled = rightMarginLabel.Enabled = false;
            }
        }

        private void prevPageBtn_Click(object sender, EventArgs e)
        {
            currentPageNo--;
            showPdfPage(showdata, currentPageNo);
        }

        private void nextPageBtn_Click(object sender, EventArgs e)
        {
            currentPageNo++;
            showPdfPage(showdata, currentPageNo);
        }

        private void pictureBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Select Output Folder
            if (!saveDefault)
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.ShowNewFolderButton = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                    outputFolder = dlg.SelectedPath;
            } else
            {
                outputFolder = Path.GetDirectoryName(files[0]);
                outputFolder = Path.Combine(outputFolder, "Elsa");
                if(!Directory.Exists(outputFolder))
                    Directory.CreateDirectory(outputFolder);
            }

            // Handle Multiple Files
            if (files != null && files.Length > 0)
            {
                string showFile = getOutputFilename(files[files.Length - 1]);
                for (int i = 0; i < files.Length; i++)
                {
                    string outputFile = getOutputFilename(files[i]);
                    string header = useCustomHeader ? customTextInput.Text : getHeaderStringFromFilename(files[i]);
                    addHeader(files[i], outputFile, header);
                }

                // Preview One Converted File
                showdata = System.IO.File.ReadAllBytes(showFile);
                totalPages = getTotalPageNumber(showFile);
                if (totalPages > 0)
                {
                    pageCountTextBox.Enabled = true;
                    currentPageNo = 1;
                    showPdfPage(showdata, currentPageNo);
                }
            }
        }

        private void pictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF Files|*.pdf";
            openFileDialog.Multiselect = true;
            openFileDialog.Title = "Select PDF Files";
            string inputFile;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                inputFile = openFileDialog.FileName;
            else return;

            // Select Output Folder
            if (!saveDefault)
            {
                FolderBrowserDialog dlg = new FolderBrowserDialog();
                dlg.ShowNewFolderButton = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                    outputFolder = dlg.SelectedPath;
            }
            else
            {
                outputFolder = Path.GetDirectoryName(inputFile);
                outputFolder = Path.Combine(outputFolder, "Elsa");
                if (!Directory.Exists(outputFolder))
                    Directory.CreateDirectory(outputFolder);
            }

            string showFile = getOutputFilename(inputFile);
            string outputFile = getOutputFilename(inputFile);
            string header = useCustomHeader ? customTextInput.Text : getHeaderStringFromFilename(inputFile);
            addHeader(inputFile, outputFile, header);

            // Preview One Converted File
            showdata = System.IO.File.ReadAllBytes(showFile);
            totalPages = getTotalPageNumber(showFile);
            if (totalPages > 0)
            {
                pageCountTextBox.Enabled = true;
                currentPageNo = 1;
                showPdfPage(showdata, currentPageNo);
            }
        }

        private void useCustomText_CheckedChanged(object sender, EventArgs e)
        {
            useCustomHeader = !useCustomHeader;
            if(useCustomHeader) customTextInput.Enabled = true;
            else customTextInput.Enabled = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            saveDefault = !saveDefault;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            System.Drawing.FontFamily[] fontFamilies = installedFontCollection.Families;
            foreach (System.Drawing.FontFamily fontFamily in fontFamilies)
            {
                fontFamilySelect.Items.Add(fontFamily.Name);
            }
            fontFamilySelect.SelectedItem = "Arial Black";
            fontColorSelect.SelectedIndex = 0;
            fontStyleSelect.SelectedIndex = 1;
        }

        private void pageCountTextBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int customPageNum;
                if (!int.TryParse(pageCountTextBox.Text, out customPageNum))
                    customPageNum = 1;
                if (customPageNum > totalPages || customPageNum < 1)
                    customPageNum = customPageNum > totalPages ? totalPages : 1;
                pageCountTextBox.Text = customPageNum.ToString();
                currentPageNo = customPageNum;
                showPdfPage(showdata, currentPageNo);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            fontDefault = !fontDefault;
            if (!fontDefault)
            {
                fontSettingColorLabel.Enabled = fontSettingFontLabel.Enabled
                = fontSettingSizeLabel.Enabled = fontSettingStyleLabel.Enabled = true;
                fontFamilySelect.Enabled = fontColorSelect.Enabled = true;
                fontStyleSelect.Enabled = fontSize.Enabled = true;
            }
            else
            {
                fontSettingColorLabel.Enabled = fontSettingFontLabel.Enabled
                = fontSettingSizeLabel.Enabled = fontSettingStyleLabel.Enabled = false;
                fontFamilySelect.Enabled = fontColorSelect.Enabled = false;
                fontStyleSelect.Enabled = fontSize.Enabled = false;
            }
        }
    }
}
