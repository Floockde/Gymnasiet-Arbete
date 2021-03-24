using System;
using System.Windows.Forms;
namespace Gymme
{
    public partial class Form2 : Form
    {
        public Form2(ref Form1 form1handel)
        {
            Form1 f1 = form1handel;
            InitializeComponent();
            Textmanager tm = Textmanager.Instance;
        }

        private void BtDialNext_Click(object sender, EventArgs e)
        {
            TbDialogueBox.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = Character.Instance.CharacterName;
        }

        private void TbDialogueBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}