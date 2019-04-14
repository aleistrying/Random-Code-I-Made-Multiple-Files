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
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

using System.Diagnostics;


namespace TrasnformxlAppToPDF
{
    public partial class XlToPDFForm : Form
    {
        public XlToPDFForm()
        {
            InitializeComponent();
        }
        static string filePath = "";
        //static Microsoft.Office.Interop.Excel.Application ExlApp;
        //static Microsoft.Office.Interop.Excel.Workbook Wbook;
        //static Microsoft.Office.Interop.Excel.Worksheet Wsheet;
        //static Microsoft.Office.Interop.Excel.Range Range;

        private System.Windows.Forms.OpenFileDialog ofd;
        //private System.Windows.Forms.FolderBrowserDialog fbd;


        [DllImport("user32.dll")]
        static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);
        /// <summary>
        /// Consigue el proceso de excel por ID usando Dll import etc. ?? no se como sirve.
        /// </summary>
        /// <param name="excelApp"></param>
        /// <returns></returns>
        /// 
        Process GetExcelProcess(Excel.Application excelApp)
        {
            int id;
            GetWindowThreadProcessId(excelApp.Hwnd, out id);
            return Process.GetProcessById(id);
        }

        private void SelectAFileButton_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                filePath = ofd.FileName;
                UbicationTextBox.Text = filePath;
            }
        }
        private void TransformToPDFButton_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(UbicationTextBox.Text);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
                xlApp.DisplayAlerts = false;
                xlWorkbook.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, filePath);
                xlWorkbook.Close();
                GetExcelProcess(xlApp).Kill();
                xlApp.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void XlToPDFForm_Load(object sender, EventArgs e)
        {
        }
        //working code
        /*ExlApp = new Microsoft.Office.Interop.Excel.Application();
                ExlApp.DisplayAlerts = false;
                Wbook = ExlApp.Workbooks.Add(Type.Missing);
                Wsheet = (Microsoft.Office.Interop.Excel.Worksheet)Wbook.ActiveSheet;
                //

                Wsheet.Cells[1, 1] = "SKU";
                Wsheet.Cells[1, 2] = "Product Name";
                Wsheet.Cells[1, 3] = "Product Description";
                Wsheet.Cells[1, 4] = "Precio";

                //

                Wsheet.Cells.ColumnWidth = 20;

                Microsoft.Office.Interop.Excel.Range lastcell = Wsheet.Cells.SpecialCells(Microsoft.Office.Interop.Excel.XlCellType.xlCellTypeLastCell, Type.Missing);

                //

                Microsoft.Office.Interop.Excel.Range AllRange = Wsheet.get_Range("A1", lastcell);

                //

                AllRange.Style.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;

                //////


                Wsheet.Cells[2, 1] = "TEST1";
                Wsheet.Cells[3, 2] = "test2";
                Wsheet.Cells[4, 3] = "TEst3";

                Wbook.ExportAsFixedFormat(Microsoft.Office.Interop.Excel.XlFixedFormatType.xlTypePDF, filePath);

               
                Wbook.SaveAs(filePath.Remove(filePath.Length - 4,4), Microsoft.Office.Interop.Excel.XlFileFormat.xlCSV);
                Wbook.Close();
                ExlApp.Quit();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            */
    }
}
