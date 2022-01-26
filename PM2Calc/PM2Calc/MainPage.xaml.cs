using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PM2Calc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            txtoperacion.Items.Add("SUMA");
            txtoperacion.Items.Add("RESTA");
            txtoperacion.Items.Add("MULTIPLICACION");
            txtoperacion.Items.Add("DIVISION");
        }

        async private void txtoperacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                String op = txtoperacion.SelectedItem.ToString();
                int n1 = Int32.Parse(txtN1.Text);
                int n2 = Int32.Parse(txtN2.Text);
                double res = 0;

                if (op == "SUMA")
                    res = n1 + n2;
                else if (op == "RESTA")
                    res = n1 - n2;
                else if (op == "MULTIPLICACION")
                    res = n1 * n2;
                else if (op == "DIVISION")
                    res = n1 / n2;

                lblRes.Text = res + "";
            var Contact = new Models.Operaciones
            {
                Suma = Convert.ToInt32(this.lblRes.Text),
                Resta = Convert.ToInt32(this.lblRes.Text),
                Multi = Convert.ToInt32(this.lblRes.Text),
                Division = Convert.ToInt32(this.lblRes.Text)
            };
            var pagina = new PageMain();
            pagina.BindingContext = Contact;
            await Navigation.PushModalAsync(pagina);
        }
    }
}
