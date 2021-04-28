using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Gymme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Character> characterList = new List<Character>();

        public string TextBoxString;

        private void StartBt_Click(object sender, EventArgs e)
        {
            Character.Instance.CharacterName = NameTB.Text;
            MessageBox.Show("Your name is " + Character.Instance.CharacterName);

            Form1 newform = new Form1();
            newform = this;
            this.Hide();
            Form2 f2 = new Form2(ref newform);
            f2.Show();
        }
    }
}
