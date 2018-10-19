using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NasaRobots
{
    public partial class InputForm : Form
    {
        public string enteredText = "";
        public InputForm()
        {
            InitializeComponent();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            textBox1.CharacterCasing = CharacterCasing.Upper;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            enteredText = textBox1.Text;
        }
    }
}
