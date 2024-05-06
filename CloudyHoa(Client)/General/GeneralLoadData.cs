using CloudyHoa_Client_.DataObject;
using CloudyHoa_Client_.SaveExecuteControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.General
{
    static class GeneralLoadData
    {
        //public delegate void LoadDataFunc(IDataStructure dataStructure, IDataService dataService);
        public static async Task LoadData(ISafeExecuteControl form,Func<IDataService, IDataStructure,Task> func, IDataStructure structure, IDataService service)
        {
            await form.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    await func(service, structure);

                }
                catch (Exception e)
                {
                    const string caption = "Подключение к серверу";
                    var result = MessageBox.Show(e.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
        }
        public static async Task LoadData(ISafeExecuteControl form, Func<IDataService, IDataStructure, int, Task> func, IDataStructure structure, IDataService service, 
            int objectId)
        {
            await form.SafeUIExecuteAsync(async () =>
            {
                try
                {
                    await func(service, structure, objectId);

                }
                catch (Exception e)
                {
                    const string caption = "Подключение к серверу";
                    var result = MessageBox.Show(e.Message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Error);
                }
            }, "Ошибка подключения к северу.");
        }
    }
}
