using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using WebServisoClientas.ErikasWebService;
using WebServisoClientas.Properties;

namespace WebServisoClientas
{
    public partial class WebServiceForm : Form
    {
        private readonly ManoWebServisasSoapClient _soapClient;

        public WebServiceForm()
        {
            InitializeComponent();

            _soapClient = new ManoWebServisasSoapClient();
            FillGridView();
            FillStudentaiComboBox();
            FillPaskaitosComboBox();
        }

        private void FillGridView()
        {
            DataTable duomenis = _soapClient.GautiDuomenisApieStudijuPlana();

            GridViewResult.DataSource = duomenis;
        }

        private void FillStudentaiComboBox()
        {
            DataTable studentai = _soapClient.GautiStudentus();

            ComboBoxStudentas.DataSource = studentai.DefaultView;
            ComboBoxStudentas.DisplayMember = studentai.Columns["Vardas"].ColumnName;
            ComboBoxStudentas.ValueMember = studentai.Columns["ID_Studentas"].ColumnName;
        }

        private void FillPaskaitosComboBox()
        {
            DataTable paskaitos = _soapClient.GautiPaskaitas();

            ComboBoxPaskaita.DataSource = paskaitos.DefaultView;
            ComboBoxPaskaita.DisplayMember = paskaitos.Columns["Pavadinimas"].ColumnName;
            ComboBoxPaskaita.ValueMember = paskaitos.Columns["Kodas"].ColumnName;
        }

        private void ButtonPrideti_Click(object sender, EventArgs e)
        {
            string kodas = TextBoxInsertPaskaitosKodas.Text;
            string pavadinimas = TextBoxInsertPaskaitosPavadinimas.Text;

            if (kodas.Trim() == string.Empty)
            {
                ErrorProvider.SetError(TextBoxInsertPaskaitosKodas, "Paskaitos kodas privalomas!");
            }
            else if (pavadinimas.Trim() == string.Empty)
            {
                ErrorProvider.SetError(TextBoxInsertPaskaitosPavadinimas, "Paskaitos pavadinimas privalomas!");
            }
            else
            {
                int insertedRow = _soapClient.IrasytiNaujaPaskaita(kodas, pavadinimas);
                if (insertedRow > 0)
                {
                    MessageBox.Show(Resources.ButtonPridetiClick_PaskaitaPridėtaSekmingai);
                    FillPaskaitosComboBox();
                }
                else
                {
                    MessageBox.Show(Resources.ButtonPridetiClick_PaskaitosPridetiNepavyko);
                }
            }
        }

        private void ButtonPriskirti_Click(object sender, EventArgs e)
        {
            string diena = ComboBoxPriskirtiDiena.Text;
            string laikas = ComboBoxPriskirtiLaikas.Text;
            var studentoId = (string) ComboBoxStudentas.SelectedValue;
            var paskaitosKodas = (string) ComboBoxPaskaita.SelectedValue;

            int insertedRow = _soapClient.PriskirtiPaskaitaStudentui(studentoId.Trim(), paskaitosKodas.Trim(), diena,
                laikas);
            if (insertedRow > 0)
            {
                MessageBox.Show(Resources.ButtonPridetiClick_PaskaitaPridėtaSekmingai);
                FillGridView();
            }
            else
            {
                MessageBox.Show(Resources.ButtonPridetiClick_PaskaitosPridetiNepavyko);
            }
        }

        private void ButtonGautiPaskaita_Click(object sender, EventArgs e)
        {
            string diena = ComboBoxGautiDiena.Text.Trim();
            string laikas = ComboBoxGautiLaikas.Text.Trim();
            var studentoId = (string) ComboBoxStudentas.SelectedValue;

            string paskaitosPavadinimas = _soapClient.GautiPaskaitaPagalLaikaIrStudentoId(diena, laikas, studentoId);

            if (!string.IsNullOrEmpty(paskaitosPavadinimas))
            {
                var list = new List<Wrapper>
                {
                    new Wrapper
                    {
                        Pavadinimas = paskaitosPavadinimas
                    }
                };
                GridViewResult.DataSource = list;
            }
            else
            {
                MessageBox.Show(Resources.ButtonPridetiClick_PaskaitosPridetiNepavyko);
            }
        }

        private void TextBoxInsertPaskaitosKodas_Validating(object sender, CancelEventArgs e)
        {
            if (TextBoxInsertPaskaitosKodas.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                ErrorProvider.SetError(TextBoxInsertPaskaitosKodas, "Paskaitos kodas privalomas!");
            }
            else
            {
                ErrorProvider.SetError(TextBoxInsertPaskaitosKodas, null);
            }
        }

        private void TextBoxInsertPaskaitosPavadinimas_Validating(object sender, CancelEventArgs e)
        {
            if (TextBoxInsertPaskaitosPavadinimas.Text.Trim() == String.Empty)
            {
                e.Cancel = true;
                ErrorProvider.SetError(TextBoxInsertPaskaitosPavadinimas, "Paskaitos pavadinimas privalomas!");
            }
            else
            {
                ErrorProvider.SetError(TextBoxInsertPaskaitosPavadinimas, null);
            }
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == InsertTab)
            {
                LabelPriskirtiPaskaita.Visible = false;
                ComboBoxPaskaita.Visible = false;
                LabelPriskirtiStudentai.Visible = false;
                ComboBoxStudentas.Visible = false;
                FillGridView();
            }
            else if (e.TabPage == AssignTab)
            {
                LabelPriskirtiPaskaita.Visible = true;
                ComboBoxPaskaita.Visible = true;
                LabelPriskirtiStudentai.Visible = true;
                ComboBoxStudentas.Visible = true;
                FillGridView();
            }
            else if (e.TabPage == SelectTab)
            {
                LabelPriskirtiPaskaita.Visible = false;
                ComboBoxPaskaita.Visible = false;
                LabelPriskirtiStudentai.Visible = true;
                ComboBoxStudentas.Visible = true;
            }
            else if (e.TabPage == UpdateTab)
            {
                LabelPriskirtiPaskaita.Visible = true;
                ComboBoxPaskaita.Visible = true;
                LabelPriskirtiStudentai.Visible = false;
                ComboBoxStudentas.Visible = false;
                FillGridView();
            }
            else if (e.TabPage == DeleteTab)
            {
                LabelPriskirtiPaskaita.Visible = true;
                ComboBoxPaskaita.Visible = true;
                LabelPriskirtiStudentai.Visible = true;
                ComboBoxStudentas.Visible = true;
                FillGridView();
            }
            else
            {
                LabelPriskirtiPaskaita.Visible = false;
                ComboBoxPaskaita.Visible = false;
                LabelPriskirtiStudentai.Visible = false;
                ComboBoxStudentas.Visible = false;
                FillGridView();
            }
        }
    }

    internal class Wrapper
    {
        public string Pavadinimas { get; set; }
    }
}