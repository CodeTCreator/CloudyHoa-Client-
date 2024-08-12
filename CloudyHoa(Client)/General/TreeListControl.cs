using System;
using System.Data;
using System.Windows.Forms;

namespace CloudyHoa_Client_.General
{
    public partial class TreeListControl : UserControl
    {
        public delegate void treeClickHandler();
        public event treeClickHandler TreeClick;
        public TreeListControl()
        {
            InitializeComponent();
        }
        public void BindingData(DataTable dataTableObjects)
        {
            treeListObjects.DataSource = dataTableObjects;
        }

        public FocusedObject GetFocusedObject()
        {
            if (treeListObjects.GetFocusedRowCellValue("id") != null)
            {
                FocusedObject focusedObject = new FocusedObject();
                focusedObject.objectId = (int)treeListObjects.GetFocusedRowCellValue("id");
                focusedObject.typeObject = (int)treeListObjects.GetFocusedRowCellValue("id1");
                focusedObject.nameType = treeListObjects.GetFocusedRowCellValue("name").ToString();
                focusedObject.parentId = treeListObjects.GetFocusedRowCellValue("parent_id") != DBNull.Value ?
                    (int)treeListObjects.GetFocusedRowCellValue("parent_id") : (int?)null;
                focusedObject.identificator = (string)treeListObjects.GetFocusedRowCellValue("identificator");
                return focusedObject;
            }
            return null;
        }

        private void treeListObjects_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (treeListObjects.GetFocusedRowCellValue("id") != null)
            {
                TreeClick.Invoke();
            }
        }
    }
}
