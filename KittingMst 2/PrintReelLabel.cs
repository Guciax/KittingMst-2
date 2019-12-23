using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KittingMst_2
{
    class PrintReelLabel
    {
        private static string qrText = "";
        public static void Print(string fullQrText)
        {
            qrText = fullQrText;
            string printerName = GetPrinter();
            if (printerName == null)
            {
                MessageBox.Show("Brak podłączonej drukarki DYMO");
                return;
            }

            PrintDocument doc = new PrintDocument();
            doc.PrinterSettings.PrinterName = printerName;
            doc.DefaultPageSettings.Landscape = false;
            doc.DefaultPageSettings.PaperSize = new PaperSize("Dymo 11356 89x41", (int)Math.Round(41 / 0.264583333, 0), (int)Math.Round(89 / 0.264583333, 0));//100pix/inch
            doc.DefaultPageSettings.Margins = new Margins(2, 2, 2, 2);
            doc.PrintPage += new PrintPageEventHandler(qrDeuplicatePrintHandler);
            doc.Print();
        }

        private static string GetPrinter()
        {
            foreach (string printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                if (printer.ToUpper().Contains("DYMO")) return printer;
            }
            return null;
        }

        private static void PrintQrDuplicate(string PrinterName)
        {
            PrintDocument doc = new PrintDocument();

            doc.PrinterSettings.PrinterName = PrinterName;
            doc.DefaultPageSettings.Landscape = false;
            doc.DefaultPageSettings.PaperSize = new PaperSize("Dymo 11356 89x41", (int)Math.Round(41 / 0.264583333, 0), (int)Math.Round(89 / 0.264583333, 0));//100pix/inch
            doc.DefaultPageSettings.Margins = new Margins(2, 2, 2, 2);
            doc.PrintPage += new PrintPageEventHandler(qrDeuplicatePrintHandler);
            doc.Print();
        }

        private static void qrDeuplicatePrintHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            string[] split = qrText.Split(null);
            if (split.Length > 4)
            {
                //ppeArgs.Graphics.PageUnit = GraphicsUnit.Pixel;

                string nc12 = split[0];
                if (nc12.Length == 12)
                {
                    nc12 = nc12.Insert(4, " ").Insert(8, " ");
                }
                string id = split[5];
                string description = $"{nc12}" + Environment.NewLine + $"ID: {id}";

                Font FontNormal = new Font("Verdana", 5);
                Graphics g = ppeArgs.Graphics;
                Image qrCode = QrCode2(qrText);
                g.DrawImage(qrCode, new PointF(0, 0));
                g.DrawString(description, FontNormal, Brushes.Black, 0, qrCode.Height + 5, new StringFormat());
                int veticalLineX = (int)Math.Round(ppeArgs.PageBounds.Width * 0.6, 0);

                g.DrawLine(new Pen(Color.Black, 2), new Point(veticalLineX, qrCode.Height + 40), new Point(veticalLineX, 320));
                g.DrawString("Nr zlecenia", FontNormal, Brushes.Black, 20, qrCode.Height + 50, new StringFormat());
                g.DrawString("Ilość" + Environment.NewLine + "na koniec" + Environment.NewLine + "zlecenia", FontNormal, Brushes.Black, 105, qrCode.Height + 43, new StringFormat());

                for (int i = qrCode.Height + 40; i < 320; i = i + 35)
                {
                    g.DrawLine(new Pen(Color.Black, 2), new Point(2, i), new Point(ppeArgs.PageBounds.Width - 4, i));
                }
            }
            else
            {
                MessageBox.Show("Nieprawidłowy format kodu wejściowego:" + Environment.NewLine + qrText);
            }
        }

        private static Bitmap QrCode2(string codeContent)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            encoder.QRCodeScale = 2;
            Bitmap result;
            using (var bmp = encoder.Encode(codeContent))
            {
                // There is a bug in QRCodeEncoder, so that it will add an
                // additional "blank" row/column
                result = bmp.Clone(new Rectangle(0, 0, bmp.Width - 1, bmp.Height - 1), bmp.PixelFormat);

                // use bmp2 
            }
            return result;
        }
    }
}
