using Odpisy.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odpisy.Controls
{
    public partial class ClassControl : UserControl
    {
        public ClassControl()
        {
            InitializeComponent();
            _listClass.SelectedIndex = 0;
        }

        public ClassPriceModel GetData()
        {
            return new ClassPriceModel()
            {
                Price = (int)_numPrice.Value,
                Class = int.Parse(_listClass.SelectedItem.ToString())
            };
        }
    }
}
