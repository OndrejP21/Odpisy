using Odpisy.Forms;

namespace Odpisy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ClassicForm form = new ClassicForm();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FastForm fast = new FastForm();
            fast.ShowDialog();
        }
    }
}