using FormationEF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormationWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idTemp = 1;
            if (Id_textBox.Text != null)
            {
                 idTemp = int.Parse(Id_textBox.Text);
            }
            BookRepository bookRepo = new BookRepository();
            Book b = bookRepo.GetById(idTemp);

            textBox1.Text = b.Title;
           
           

        }
    }
}
