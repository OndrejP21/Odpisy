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
    public partial class FastForm : Form
    {
        private readonly Service _service;

        public FastForm()
        {
            InitializeComponent();
            _service = new Service();
        }

        private void _btnCount_Click(object sender, EventArgs e)
        {
            ClassPriceModel model = _classControl.GetData();

            if (model.Price <= 80000)
            {
                MessageBox.Show("80000 jde odepsat hned");
            }
            else
            {
                List<string> list = _service.FastCount(model);

                int bigIndex = 0;
                int index = 0;
                int offsetX = 10;
                int offsetY = 30;
                foreach (var item in list)
                {
                    if (index == 20)
                    {
                        index = 0;
                        bigIndex++;
                        offsetX += 150;
                    }
                    Label lbl = new Label();
                    lbl.Location = new Point(offsetX, offsetY + offsetY * index);
                    lbl.Text = $"{bigIndex * 20 + index + 1}. – {item}";

                    _odpisy.Controls.Add(lbl);
                    index++;
                }
            }
        }
    }
}
