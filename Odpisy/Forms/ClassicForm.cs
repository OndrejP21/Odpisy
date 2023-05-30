using Odpisy.Models;
using Odpisy.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odpisy.Forms
{
    public partial class ClassicForm : Form
    {
        private readonly Service _service;

        public ClassicForm()
        {
            InitializeComponent();
            _service = new Service();
        }

        private void _btnCount_Click(object sender, EventArgs e)
        {
            ClassPriceModel model = _classControl.GetData();

            if (model.Price <= 80000)
            {
                MessageBox.Show("Částku do 80 000 Kč lze odepsat rovnou!");
            } else
            {
                List<string> list = _service.ClassicCount(model);

                _listResult.DataSource = list;
            }
        }
    }
}
