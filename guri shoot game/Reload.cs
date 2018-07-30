using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace guri_shoot_game

   
{
    public partial class Reload : Form
    {
      
        public  Reload()
        {

       
            InitializeComponent();
        }
        SoundPlayer My_JukeBox = new SoundPlayer(@"C:\Users\BROTHERS\Documents\wave");
        private void Reload_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            My_JukeBox.Play();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            spin_Chamber displaySpin = new spin_Chamber();
            displaySpin.Show();
        }
    }
}
