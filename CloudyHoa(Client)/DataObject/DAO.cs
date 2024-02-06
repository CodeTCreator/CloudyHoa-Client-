using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.DataObject
{
    internal class DAO
    {
        //List<DataStructure> _data = new List<DataStructure>();
        IDataStructure _structure;
        int _hoaId = -1;
        public DAO() { }
        public DAO(int hoa_Id,IDataStructure dataStructure) { hoaId = hoa_Id; structure = dataStructure; }

        public int hoaId
        {
            get { return _hoaId; }
            set { _hoaId = value; }
        }

        public IDataStructure structure
        {
            get { return _structure; }
            set { _structure = value; }
        }

        //public List<DataTable> Data
        //{
        //    get { return _data; }
        //}
        //public void AddData(DataTable dataTable,Data data)
        //{
        //    //_data.Add(new DataStructure(dataTable));
        //    _data.Add(dataTable);
        //}

        //public DataTable GetTable(string tableName)
        //{
        //    DataTable dataTable = null;
        //    dataTable = _data.Where(dt => dt.TableName == tableName).FirstOrDefault();
        //    return dataTable;
        //}

    }

    //public class DataStructure
    //{
    //    DataSet _dataSet = null;

    //    public DataStructure(DataSet dataSet)
    //    {
    //        DataSet = dataSet;
    //    }

    //    public DataSet DataSet
    //    {
    //        get { return _dataSet; }
    //        set { _dataSet = value; }
    //    }

    //}

}
