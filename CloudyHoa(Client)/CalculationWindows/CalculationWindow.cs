using CloudyHoa_Client_.CalculationWindows.Controllers;
using CloudyHoa_Client_.DataObject.DataStructure;
using CloudyHoa_Client_.ObjectWindow.Service_Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.CalculationWindows
{
    public partial class CalculationWindow : Form
    {
        CalculationWindowController _controller;
        ObjectDataService _objectDataService {  get; set; }
        ObjectDataStructure _objectDataStructure { get; set; }

        public CalculationWindow()
        {
            InitializeComponent();
            _objectDataService = new ObjectDataService();
            _controller = new CalculationWindowController();
            _objectDataStructure = new ObjectDataStructure();
        }


        public async Task LoadObjects()
        {
            await General.GeneralLoadData.LoadData(this, _controller.LoadCategoryTable, _objectDataStructure, _objectDataService);
        }
        private void CalculationWindow_Load(object sender, EventArgs e)
        {
            treeListControl.BindingData(null);
        }
    }
}
