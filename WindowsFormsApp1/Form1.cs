using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        DataTable dt = new DataTable();

        private void btn_Open_Click(object sender, EventArgs e)
        {
            // ouvrir le fichier : OpenFiledialog
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx", Multiselect = true })
            {
                // show dialg: ouvre une fenetre et revient uniquement quand la fenetre ouverte est fermé
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    // transfer des data en excel
                    using(XLWorkbook workbook = new XLWorkbook(ofd.FileName))
                    {
                        // arajouter une feuille de calcul
                        bool isFirstRow = true ;
                        var rows = workbook.Worksheet(1).RowsUsed();
                        foreach (var rw in rows)
                        {
                            if (isFirstRow)
                            {
                                //rajouter des colonnes 
                                foreach (IXLCell cell in rw.Cells())
                                {
                                    dt.Columns.Add(cell.Value.ToString());
                                }
                                    
                                isFirstRow = false;
                            }
                            else
                            {
                                dt.Rows.Add();
                                int i = 0;
                                foreach (IXLCell cell in rw.Cells())
                                {
                                    dt.Rows[dt.Rows.Count - 1][i++] = cell.Value.ToString();
                                }
                            }
                        }
                        // convertion data table en data view 
                        dataGridView2.DataSource = dt.DefaultView;
                        lbltotal.Text = $"Total : {dataGridView2.RowCount}";
                        Cursor.Current = Cursors.Default;
                        

                    }
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                DataView dv = dataGridView2.DataSource as DataView;
                if(dv != null)
                {
                    dv.RowFilter = SearchText.Text;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                btn_Search.PerformClick();
            }
        }
    }
}
