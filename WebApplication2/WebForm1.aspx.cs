using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public int Nro1, Nro2;
        ServiceReference1.WebService1SoapClient servicio = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Nro2 = Convert.ToInt32(TextBox2.Text);
            Label1.Text = servicio.Resta(Nro1, Nro2).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Nro2 = Convert.ToInt32(TextBox2.Text);
            Label1.Text = servicio.Multiplicacion(Nro1, Nro2).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Nro2 = Convert.ToInt32(TextBox2.Text);
            Label1.Text = servicio.Division(Nro1, Nro2).ToString();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Nro2 = Convert.ToInt32(TextBox2.Text);
            Label1.Text = servicio.Potencia(Nro1, Nro2).ToString();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Label1.Text = servicio.Inverso(Nro1).ToString();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Label1.Text = servicio.Seno(Nro1).ToString();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Label1.Text = servicio.Coseno(Nro1).ToString();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Label1.Text = servicio.Tangente(Nro1).ToString();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Label1.Text = servicio.Factorial(Nro1).ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Nro1 = Convert.ToInt32(TextBox1.Text);
            Nro2 = Convert.ToInt32(TextBox2.Text);
            Label1.Text = servicio.Suma(Nro1,Nro2).ToString();
        }
    }
}