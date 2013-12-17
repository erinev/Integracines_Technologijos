using System;
using System.Windows.Forms;
using System.ServiceModel;
using Client.Properties;
using Client.Servisas;
using System.ServiceModel.Security;

namespace Client
{
    public partial class Form1 : Form
    {
        private Service1Client _proxy;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateProxy()
        {
            //sukuriamas serviso klientas atsizvelgianti i pasirinta radio button'a
            if (radioButton1.Checked)
            {
                _proxy = new Service1Client("SecureService_Tcp");
            }
            else if (radioButton2.Checked)
            {
                _proxy = new Service1Client("SecureService_WsHttp");

            }
            else if (radioButton3.Checked)
            {
                _proxy = new Service1Client("SecureService_netPipe");
            }
            else
            {
                _proxy = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.CreateProxy();

            try
            {
                //skaiciuojama dvieju skaiciu suma
                string result = _proxy.Suma(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                if (result != "Neautorizuotas") 
                {
                    LabelSuma.Text = result; //jei vartotojas autorizuotas parasom rezultata
                }
                else
                {
                    MessageBox.Show(result); //jei vartotojas neautorizuotas isvedam dialog box
                }
            }
            catch (FaultException faultEx)
            {
                MessageBox.Show(faultEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.CreateProxy();

            try
            {
                string result = _proxy.Labas();
                //Tikrinam ar klientas autorizuotas gauti žinutę
                if (result != "Neautorizuotas")
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show(Resources.Button2Click_NeautorizuotasPamatytiZinutes);
                }
            }
            catch (SecurityAccessDeniedException securityEx)
            {
                MessageBox.Show(securityEx.Message);
            }
            catch (FaultException faultEx)
            {
                MessageBox.Show(faultEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
