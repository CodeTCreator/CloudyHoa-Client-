using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CloudyHoa_Client_.General
{
    public partial class ListObjects : Form
    {

        List<Tuple<int,string>> _objectsId = new List<Tuple<int, string>>();

        DataTable _objectsTable = new DataTable();

        public ListObjects()
        {
            InitializeComponent();
        }
        public ListObjects(DataTable dataTable, List<Tuple<int,string>> objects)
        {
            InitializeComponent();
            _objectsTable = dataTable;
            if(objects != null ) { _objectsId = objects; }
            
        }

        public List<Tuple<int, string>> GetObjectsId() { return _objectsId; }

        public void SetObjectsTable(DataTable objectsTable)
        {
            _objectsTable = objectsTable;
        }

        private void ListObjects_Load(object sender, EventArgs e)
        {
            treeList1.DataSource = _objectsTable;
            treeList1.ParentFieldName = "parent_id";
            treeList1.KeyFieldName = "id";
            LoadData();
        }

        private void LoadData()
        {
            int objectId;
            foreach (TreeListNode node in treeList1.Nodes)
            {
                objectId = (int)treeList1.GetRowCellValue(node, "id");
                if (_objectsId.Any(tuple => tuple.Item1 == objectId))
                {
                    node.Checked = true;
                }
                SetCheckNode(node);
            }
        }
        private void SetCheckNode(TreeListNode parentNode)
        {
            int objectId;
            foreach (TreeListNode node in parentNode.Nodes)
            {
                objectId = (int)treeList1.GetRowCellValue(node, "id");
                if (_objectsId.Any(tuple => tuple.Item1 == objectId))
                {
                    node.Checked = true;
                }
                SetCheckNode(node);
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            SetObjectsChecking();
            this.Close();
        }
        private void SetObjectsChecking()
        {
            _objectsId.Clear();
            foreach(TreeListNode node  in treeList1.Nodes)
            {
                if (node.Checked)
                {
                    _objectsId.Add(new Tuple<int, string>((int)treeList1.GetRowCellValue(node, "id"), treeList1.GetRowCellValue(node, "name").ToString() +
                        treeList1.GetRowCellValue(node, "identificator").ToString()));
                }
                CheckNode(node);
            }
        }

        private void CheckNode(TreeListNode parentNode)
        {
            foreach (TreeListNode node in parentNode.Nodes)
            {
                if (node.Checked)
                {
                    _objectsId.Add(new Tuple<int, string>((int)treeList1.GetRowCellValue(node, "id"), treeList1.GetRowCellValue(node, "name").ToString() +
                        treeList1.GetRowCellValue(node, "identificator").ToString()));
                }
                CheckNode(node);
            }
        }
        public List<Tuple<int, string>> GetListObject()
        {
            return _objectsId;
        }

    }
}
