using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

       Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            Button[] b = new Button[2];
            b[0] = button1;
            b[1] = button2;

            for (int i = 0; i <b.Length; i++)
            {
          
                b[i].BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            }



        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Dialogo = new OpenFileDialog();
            if (Dialogo.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(Dialogo.FileName);

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialogo = new SaveFileDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)

            {
                MessageBox.Show(dialogo.FileName);

            }



        }
    }
}
