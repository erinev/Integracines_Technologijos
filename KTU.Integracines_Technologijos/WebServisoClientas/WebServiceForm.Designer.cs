﻿namespace WebServisoClientas
{
    partial class WebServiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.InsertTab = new System.Windows.Forms.TabPage();
            this.ButtonPrideti = new System.Windows.Forms.Button();
            this.TextBoxInsertPaskaitosKodas = new System.Windows.Forms.TextBox();
            this.TextBoxInsertPaskaitosPavadinimas = new System.Windows.Forms.TextBox();
            this.LabelPavadinimas = new System.Windows.Forms.Label();
            this.LabelKodas = new System.Windows.Forms.Label();
            this.AssignTab = new System.Windows.Forms.TabPage();
            this.ComboBoxPriskirtiLaikas = new System.Windows.Forms.ComboBox();
            this.ComboBoxPriskirtiDiena = new System.Windows.Forms.ComboBox();
            this.ButtonPriskirti = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectTab = new System.Windows.Forms.TabPage();
            this.LabelLaikas = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.LabelDiena = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.UpdateTab = new System.Windows.Forms.TabPage();
            this.DeleteTab = new System.Windows.Forms.TabPage();
            this.GridViewResult = new System.Windows.Forms.DataGridView();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ComboBoxStudentas = new System.Windows.Forms.ComboBox();
            this.LabelPriskirtiStudentai = new System.Windows.Forms.Label();
            this.LabelPriskirtiPaskaita = new System.Windows.Forms.Label();
            this.ComboBoxPaskaita = new System.Windows.Forms.ComboBox();
            this.TabControl.SuspendLayout();
            this.InsertTab.SuspendLayout();
            this.AssignTab.SuspendLayout();
            this.SelectTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.InsertTab);
            this.TabControl.Controls.Add(this.AssignTab);
            this.TabControl.Controls.Add(this.SelectTab);
            this.TabControl.Controls.Add(this.UpdateTab);
            this.TabControl.Controls.Add(this.DeleteTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(283, 188);
            this.TabControl.TabIndex = 0;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // InsertTab
            // 
            this.InsertTab.Controls.Add(this.ButtonPrideti);
            this.InsertTab.Controls.Add(this.TextBoxInsertPaskaitosKodas);
            this.InsertTab.Controls.Add(this.TextBoxInsertPaskaitosPavadinimas);
            this.InsertTab.Controls.Add(this.LabelPavadinimas);
            this.InsertTab.Controls.Add(this.LabelKodas);
            this.InsertTab.Location = new System.Drawing.Point(4, 22);
            this.InsertTab.Name = "InsertTab";
            this.InsertTab.Padding = new System.Windows.Forms.Padding(3);
            this.InsertTab.Size = new System.Drawing.Size(275, 162);
            this.InsertTab.TabIndex = 0;
            this.InsertTab.Text = "Įdėti";
            this.InsertTab.UseVisualStyleBackColor = true;
            // 
            // ButtonPrideti
            // 
            this.ButtonPrideti.Location = new System.Drawing.Point(79, 107);
            this.ButtonPrideti.Name = "ButtonPrideti";
            this.ButtonPrideti.Size = new System.Drawing.Size(75, 23);
            this.ButtonPrideti.TabIndex = 5;
            this.ButtonPrideti.Text = "Pridėti";
            this.ButtonPrideti.UseVisualStyleBackColor = true;
            this.ButtonPrideti.Click += new System.EventHandler(this.ButtonPrideti_Click);
            // 
            // TextBoxInsertPaskaitosKodas
            // 
            this.TextBoxInsertPaskaitosKodas.Location = new System.Drawing.Point(79, 27);
            this.TextBoxInsertPaskaitosKodas.MaxLength = 10;
            this.TextBoxInsertPaskaitosKodas.Name = "TextBoxInsertPaskaitosKodas";
            this.TextBoxInsertPaskaitosKodas.Size = new System.Drawing.Size(100, 20);
            this.TextBoxInsertPaskaitosKodas.TabIndex = 4;
            this.TextBoxInsertPaskaitosKodas.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxInsertPaskaitosKodas_Validating);
            // 
            // TextBoxInsertPaskaitosPavadinimas
            // 
            this.TextBoxInsertPaskaitosPavadinimas.Location = new System.Drawing.Point(79, 60);
            this.TextBoxInsertPaskaitosPavadinimas.MaxLength = 50;
            this.TextBoxInsertPaskaitosPavadinimas.Name = "TextBoxInsertPaskaitosPavadinimas";
            this.TextBoxInsertPaskaitosPavadinimas.Size = new System.Drawing.Size(183, 20);
            this.TextBoxInsertPaskaitosPavadinimas.TabIndex = 3;
            this.TextBoxInsertPaskaitosPavadinimas.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxInsertPaskaitosPavadinimas_Validating);
            // 
            // LabelPavadinimas
            // 
            this.LabelPavadinimas.AutoSize = true;
            this.LabelPavadinimas.Location = new System.Drawing.Point(6, 60);
            this.LabelPavadinimas.Name = "LabelPavadinimas";
            this.LabelPavadinimas.Size = new System.Drawing.Size(70, 13);
            this.LabelPavadinimas.TabIndex = 0;
            this.LabelPavadinimas.Text = "Pavadinimas:";
            // 
            // LabelKodas
            // 
            this.LabelKodas.AutoSize = true;
            this.LabelKodas.Location = new System.Drawing.Point(6, 27);
            this.LabelKodas.Name = "LabelKodas";
            this.LabelKodas.Size = new System.Drawing.Size(40, 13);
            this.LabelKodas.TabIndex = 1;
            this.LabelKodas.Text = "Kodas:";
            // 
            // AssignTab
            // 
            this.AssignTab.BackColor = System.Drawing.Color.Transparent;
            this.AssignTab.Controls.Add(this.ComboBoxPriskirtiLaikas);
            this.AssignTab.Controls.Add(this.ComboBoxPriskirtiDiena);
            this.AssignTab.Controls.Add(this.ButtonPriskirti);
            this.AssignTab.Controls.Add(this.label1);
            this.AssignTab.Controls.Add(this.label2);
            this.AssignTab.Location = new System.Drawing.Point(4, 22);
            this.AssignTab.Name = "AssignTab";
            this.AssignTab.Padding = new System.Windows.Forms.Padding(3);
            this.AssignTab.Size = new System.Drawing.Size(275, 162);
            this.AssignTab.TabIndex = 4;
            this.AssignTab.Text = "Priskirti";
            // 
            // ComboBoxPriskirtiLaikas
            // 
            this.ComboBoxPriskirtiLaikas.FormattingEnabled = true;
            this.ComboBoxPriskirtiLaikas.Items.AddRange(new object[] {
            "8:30-10:00",
            "10:30-12:00",
            "13:00-14:30",
            "15:00-16:30",
            "17:00-18:30"});
            this.ComboBoxPriskirtiLaikas.Location = new System.Drawing.Point(81, 74);
            this.ComboBoxPriskirtiLaikas.Name = "ComboBoxPriskirtiLaikas";
            this.ComboBoxPriskirtiLaikas.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPriskirtiLaikas.TabIndex = 14;
            this.ComboBoxPriskirtiLaikas.Text = "08:30-10:00";
            // 
            // ComboBoxPriskirtiDiena
            // 
            this.ComboBoxPriskirtiDiena.FormattingEnabled = true;
            this.ComboBoxPriskirtiDiena.Items.AddRange(new object[] {
            "Pirmadienis",
            "Antradienis",
            "Trečiadienis",
            "Ketvirtadienis",
            "Penktadienis"});
            this.ComboBoxPriskirtiDiena.Location = new System.Drawing.Point(81, 26);
            this.ComboBoxPriskirtiDiena.Name = "ComboBoxPriskirtiDiena";
            this.ComboBoxPriskirtiDiena.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxPriskirtiDiena.TabIndex = 13;
            this.ComboBoxPriskirtiDiena.Text = "Pirmadienis";
            // 
            // ButtonPriskirti
            // 
            this.ButtonPriskirti.Location = new System.Drawing.Point(86, 113);
            this.ButtonPriskirti.Name = "ButtonPriskirti";
            this.ButtonPriskirti.Size = new System.Drawing.Size(75, 23);
            this.ButtonPriskirti.TabIndex = 12;
            this.ButtonPriskirti.Text = "Priskirti";
            this.ButtonPriskirti.UseVisualStyleBackColor = true;
            this.ButtonPriskirti.Click += new System.EventHandler(this.ButtonPriskirti_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pasirinkite laiką:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pasirinkite dieną:";
            // 
            // SelectTab
            // 
            this.SelectTab.Controls.Add(this.LabelLaikas);
            this.SelectTab.Controls.Add(this.textBox4);
            this.SelectTab.Controls.Add(this.LabelDiena);
            this.SelectTab.Controls.Add(this.textBox3);
            this.SelectTab.Location = new System.Drawing.Point(4, 22);
            this.SelectTab.Name = "SelectTab";
            this.SelectTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTab.Size = new System.Drawing.Size(275, 162);
            this.SelectTab.TabIndex = 1;
            this.SelectTab.Text = "Gauti";
            this.SelectTab.UseVisualStyleBackColor = true;
            // 
            // LabelLaikas
            // 
            this.LabelLaikas.AutoSize = true;
            this.LabelLaikas.Location = new System.Drawing.Point(112, 77);
            this.LabelLaikas.Name = "LabelLaikas";
            this.LabelLaikas.Size = new System.Drawing.Size(41, 13);
            this.LabelLaikas.TabIndex = 6;
            this.LabelLaikas.Text = "Laikas:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(182, 42);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(103, 20);
            this.textBox4.TabIndex = 7;
            // 
            // LabelDiena
            // 
            this.LabelDiena.AutoSize = true;
            this.LabelDiena.Location = new System.Drawing.Point(112, 42);
            this.LabelDiena.Name = "LabelDiena";
            this.LabelDiena.Size = new System.Drawing.Size(38, 13);
            this.LabelDiena.TabIndex = 2;
            this.LabelDiena.Text = "Diena:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(182, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(103, 20);
            this.textBox3.TabIndex = 5;
            // 
            // UpdateTab
            // 
            this.UpdateTab.Location = new System.Drawing.Point(4, 22);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.Size = new System.Drawing.Size(275, 162);
            this.UpdateTab.TabIndex = 2;
            this.UpdateTab.Text = "Pakeisti";
            this.UpdateTab.UseVisualStyleBackColor = true;
            // 
            // DeleteTab
            // 
            this.DeleteTab.Location = new System.Drawing.Point(4, 22);
            this.DeleteTab.Name = "DeleteTab";
            this.DeleteTab.Size = new System.Drawing.Size(275, 162);
            this.DeleteTab.TabIndex = 3;
            this.DeleteTab.Text = "Ištrinti";
            this.DeleteTab.UseVisualStyleBackColor = true;
            // 
            // GridViewResult
            // 
            this.GridViewResult.AllowUserToAddRows = false;
            this.GridViewResult.AllowUserToDeleteRows = false;
            this.GridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.GridViewResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewResult.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridViewResult.Location = new System.Drawing.Point(16, 218);
            this.GridViewResult.Name = "GridViewResult";
            this.GridViewResult.Size = new System.Drawing.Size(573, 161);
            this.GridViewResult.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // ComboBoxStudentas
            // 
            this.ComboBoxStudentas.FormattingEnabled = true;
            this.ComboBoxStudentas.Location = new System.Drawing.Point(301, 108);
            this.ComboBoxStudentas.Name = "ComboBoxStudentas";
            this.ComboBoxStudentas.Size = new System.Drawing.Size(111, 21);
            this.ComboBoxStudentas.TabIndex = 0;
            this.ComboBoxStudentas.Visible = false;
            // 
            // LabelPriskirtiStudentai
            // 
            this.LabelPriskirtiStudentai.AutoSize = true;
            this.LabelPriskirtiStudentai.Location = new System.Drawing.Point(310, 92);
            this.LabelPriskirtiStudentai.Name = "LabelPriskirtiStudentai";
            this.LabelPriskirtiStudentai.Size = new System.Drawing.Size(102, 13);
            this.LabelPriskirtiStudentai.TabIndex = 1;
            this.LabelPriskirtiStudentai.Text = "Pasirinkite studentą:";
            this.LabelPriskirtiStudentai.Visible = false;
            // 
            // LabelPriskirtiPaskaita
            // 
            this.LabelPriskirtiPaskaita.AutoSize = true;
            this.LabelPriskirtiPaskaita.Location = new System.Drawing.Point(310, 44);
            this.LabelPriskirtiPaskaita.Name = "LabelPriskirtiPaskaita";
            this.LabelPriskirtiPaskaita.Size = new System.Drawing.Size(101, 13);
            this.LabelPriskirtiPaskaita.TabIndex = 2;
            this.LabelPriskirtiPaskaita.Text = "Pasirinkite paskaitą:";
            this.LabelPriskirtiPaskaita.Visible = false;
            // 
            // ComboBoxPaskaita
            // 
            this.ComboBoxPaskaita.FormattingEnabled = true;
            this.ComboBoxPaskaita.Location = new System.Drawing.Point(301, 60);
            this.ComboBoxPaskaita.Name = "ComboBoxPaskaita";
            this.ComboBoxPaskaita.Size = new System.Drawing.Size(165, 21);
            this.ComboBoxPaskaita.TabIndex = 3;
            this.ComboBoxPaskaita.Visible = false;
            // 
            // WebServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 391);
            this.Controls.Add(this.ComboBoxPaskaita);
            this.Controls.Add(this.GridViewResult);
            this.Controls.Add(this.LabelPriskirtiPaskaita);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.LabelPriskirtiStudentai);
            this.Controls.Add(this.ComboBoxStudentas);
            this.Name = "WebServiceForm";
            this.Text = "  ";
            this.TabControl.ResumeLayout(false);
            this.InsertTab.ResumeLayout(false);
            this.InsertTab.PerformLayout();
            this.AssignTab.ResumeLayout(false);
            this.AssignTab.PerformLayout();
            this.SelectTab.ResumeLayout(false);
            this.SelectTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage InsertTab;
        private System.Windows.Forms.TabPage SelectTab;
        private System.Windows.Forms.DataGridView GridViewResult;
        private System.Windows.Forms.TabPage UpdateTab;
        private System.Windows.Forms.TabPage DeleteTab;
        private System.Windows.Forms.TextBox TextBoxInsertPaskaitosKodas;
        private System.Windows.Forms.TextBox TextBoxInsertPaskaitosPavadinimas;
        private System.Windows.Forms.Label LabelPavadinimas;
        private System.Windows.Forms.Label LabelKodas;
        private System.Windows.Forms.TabPage AssignTab;
        private System.Windows.Forms.Label LabelDiena;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LabelLaikas;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button ButtonPrideti;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.ComboBox ComboBoxPaskaita;
        private System.Windows.Forms.Label LabelPriskirtiPaskaita;
        private System.Windows.Forms.Label LabelPriskirtiStudentai;
        private System.Windows.Forms.ComboBox ComboBoxStudentas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonPriskirti;
        private System.Windows.Forms.ComboBox ComboBoxPriskirtiDiena;
        private System.Windows.Forms.ComboBox ComboBoxPriskirtiLaikas;
    }
}

