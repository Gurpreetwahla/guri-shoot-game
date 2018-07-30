using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guri_shoot_game
{
    public partial class spin_Chamber : Form
    {
        public spin_Chamber()
        {
            InitializeComponent();
        }
        SoundPlayer My_JukeBox = new SoundPlayer(@"C:\Users\BROTHERS\Documents\wave");
        private void spin_Chamber_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            My_JukeBox.Play();
        }
    }
}
