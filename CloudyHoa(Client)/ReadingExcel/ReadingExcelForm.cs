using DevExpress.XtraGauges.Core.Base;
using DevExpress.XtraGrid.Views.Grid;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ReadingExcel
{
    public partial class ReadingExcelForm : Form
    {
        public DataTable DataTable { get; set; } = new DataTable();

        /// <summary>
        /// 0 - не требуется чтение / 1 - требуется чтение / -1 - внутренняя ошибка
        /// </summary>
        public int ExitFlag { get; set; } = 0;
        public string FilePath { get; set; }
        public ReadingExcelForm()
        {
            InitializeComponent();
        }

        private void reviewButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Desktop";
                openFileDialog.Filter = "Excel Files (*.xlsx;*.xls;*.csv)|*.xlsx;*.xls;*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Получение пути выбранного файла
                    FilePath = openFileDialog.FileName;
                    var fi = new FileInfo(FilePath);

                    using (var package = new ExcelPackage(fi))
                    {
                        ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                        // Получаем первый лист
                        if(package.Workbook.Worksheets.Count == 0)
                        {
                            MessageBox.Show(
                                "Листы не найдены!",
                                "Сообщение",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
                        }
                        else
                        {
                            labelControlFileName.Text = "Файл: " + Path.GetFileName(FilePath);

                            int worksheetsCount = package.Workbook.Worksheets.Count;
                            LoadSheetsComboBox(PrepareSourceForComboBox(worksheetsCount));
                            // добавляем колонки
                            DataTable = ConvertExcelTodataTable(FilePath, comboBoxSheets.SelectedIndex);
                            SetSourceGrid(DataTable);
                            CreateColumnNameTextBoxes(DataTable);
                        }
                    }
                }
            }
        }
        private List<string> PrepareSourceForComboBox(int count)
        {
            List<string> result = new List<string>();
            for(int i = 0; i < count; i++)
            {
                result.Add("Лист " + (i + 1));
            }

            return result;
        }
        private void LoadSheetsComboBox(List<string> resource)
        {
            comboBoxSheets.DataSource = resource;
            comboBoxSheets.SelectedIndex = 0;
        }
        private void comboBoxSheets_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable = ConvertExcelTodataTable(FilePath, comboBoxSheets.SelectedIndex);
            ClearDataSourceGrid();
            stackPanel1.Controls.Clear();
            SetSourceGrid(DataTable);
            CreateColumnNameTextBoxes(DataTable);

            
            //SetSourceGrid(ConvertExcelTodataTable(FilePath, comboBox1.SelectedIndex));
        }

        private void SetSourceGrid(DataTable dataTable)
        {
            gridControl1.DataSource = dataTable;
        }
        private DataTable ConvertExcelTodataTable(string path, int pageNumber)
        {
            DataTable dataTable = new DataTable();
            using (ExcelPackage package = new ExcelPackage(new FileInfo(path)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[pageNumber];

                foreach (var firstRowCell in worksheet.Cells[1, 1, 1, worksheet.Dimension.End.Column])
                {
                    dataTable.Columns.Add(firstRowCell.Text);
                }

                for (int rowNum = 2; rowNum <= worksheet.Dimension.End.Row; rowNum++)
                {
                    var wsRow = worksheet.Cells[rowNum, 1, rowNum, worksheet.Dimension.End.Column];
                    DataRow row = dataTable.NewRow();

                    foreach (var cell in wsRow)
                    {
                        row[cell.Start.Column - 1] = cell.Text;
                    }

                    dataTable.Rows.Add(row);
                }
            }
            return dataTable;
        }

        private void CreateColumnNameTextBoxes(DataTable dataTable)
        {
            foreach (DataColumn column in dataTable.Columns)
            {
                TextBox textBox = new TextBox
                {
                    Text = column.ColumnName,
                    Font = new Font("Segoe UI", 10)
                };

                // Optional: Tag property can be used to store original column name
                textBox.Tag = column.ColumnName;

                stackPanel1.Controls.Add(textBox);
            }
        }

        private void saveNameColunmButton_Click(object sender, EventArgs e)
        {
            string columnName;
            for(int i = 0; i < stackPanel1.Controls.Count; i++)
            {
                columnName = stackPanel1.Controls[i].Text;
                DataTable.Columns[i].ColumnName = columnName;
            }
            ClearDataSourceGrid();
            SetSourceGrid(DataTable);
           
        }

        private void ClearDataSourceGrid()
        {
            SetSourceGrid(null);
            GridView view = new GridView(gridControl1);
            gridControl1.MainView = view;
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            ExitFlag = 1;
            this.Close();
        }
    }
}
