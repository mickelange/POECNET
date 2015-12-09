using FormationEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormationWeb
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int idTemp = 1;
            if (TextBox1.Text != null)
            {
                idTemp = int.Parse(TextBox1.Text);
            }
            BookRepository bookRepo = new BookRepository();
            Book b = bookRepo.GetById(idTemp);

            TextBox2.Text = b.Title;

        }
    }
}