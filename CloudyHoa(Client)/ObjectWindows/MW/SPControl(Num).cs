﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.ObjectWindows.MW
{
    public partial class SPControl_Num : UserControl, ISPControl
    {
        public SPControl_Num()
        {
            InitializeComponent();
        }

        public string GetData()
        {
            return valueControl.Text;
        }

        public void LoadData(string name, string type)
        {
            textEditName.Text = name;
            textEditDataType.Text = type;
        }
    }
}
