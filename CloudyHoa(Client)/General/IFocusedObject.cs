using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudyHoa_Client_.General
{
    internal interface IFocusedObject
    {
<<<<<<<< HEAD:CloudyHoa(Client)/General/IFocusedObject.cs
        FocusedObject focusedObject { get; set; }
========
        void LoadData(string name, string type);

        string GetData();
>>>>>>>> eb43c81 (Окно объектов и модальное окно для добавления и редактирования объектов.):CloudyHoa(Client)/ObjectWindows/MW/ISPControl.cs
    }
}
