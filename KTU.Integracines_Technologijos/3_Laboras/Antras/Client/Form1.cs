using System;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Windows.Forms;
using Client.Properties;
using Client.Servisas;

namespace Client
{
    public partial class Form1 : Form
    {
        private Service2Client _proxy;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateProxy()
        {
            //sukuriamas serviso klientas priklausomai nuo radio button pasirinkimo
            if (radioButton1.Checked)
            {
                _proxy = new Service2Client("SecureService_Tcp");
            }
            else if (radioButton2.Checked)
            {
                _proxy = new Service2Client("SecureService_WsHttp");
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
                string result = _proxy.Labas();
                if (result != "Neautorizuotas") //jei klientas autorizuotas
                {
                    MessageBox.Show(result); //pasisveikinam
                }
                else
                {
                    MessageBox.Show(Resources.Button1Click_JusNeautorizuotasPamatytiZinute); //jei ne, isvedam zinute
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