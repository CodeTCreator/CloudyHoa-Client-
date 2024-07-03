using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ExpenseWindows.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ExpenseWindows.CategoryMW
{
    public partial class CategoryMW : Form
    {
        /// <summary>
        /// 1 - создание / 0 - редактирование
        /// </summary>
        int _windowMode = -1;
        FocusedCategory FocusedCategory { get; set; } = new FocusedCategory();
        ExpenseDataService ExpenseDataService { get; set; }

        public CategoryMW(ExpenseDataService expenseDataService)
        {
            InitializeComponent();
            _windowMode = 1;
            ExpenseDataService = expenseDataService;
        }

        public CategoryMW(FocusedCategory focusedCategory, ExpenseDataService expenseDataService) 
        {
            InitializeComponent();

            _windowMode = 0;
            FocusedCategory = focusedCategory;
            ExpenseDataService = expenseDataService;
        }

        private void CategoryMW_Load(object sender, EventArgs e)
        {
            if(_windowMode == 0)
            {
                labelControlName.Text = "Редактирование категории";
                universalButton.Click += EditCategory;
                textEdit.Text = FocusedCategory.Name;
            }
            else
            {
                universalButton.Click += AddCategory;
            }
        }

        private void AddCategory(object sender, EventArgs e)
        {
            ExpenseDataService.AddCategory(FocusedCategory);
            this.Close();
        }
        private void EditCategory(object sender, EventArgs e)
        {
            ExpenseDataService.EditCategory(FocusedCategory);
            this.Close();
        }

        private void textEdit_EditValueChanged(object sender, EventArgs e)
        {
            FocusedCategory.Name = textEdit.Text;   
        }
    }
}
