namespace WebServisoClientas
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.InsertTab = new System.Windows.Forms.TabPage();
            this.SelectTab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateTab = new System.Windows.Forms.TabPage();
            this.DeleteTab = new System.Windows.Forms.TabPage();
            this.LabelPavadinimas = new System.Windows.Forms.Label();
            this.LabelKodas = new System.Windows.Forms.Label();
            this.LabelDiena = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.LabelLaikas = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.AssignTab = new System.Windows.Forms.TabPage();
            this.ButtonPrideti = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.InsertTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.InsertTab);
            this.TabControl.Controls.Add(this.SelectTab);
            this.TabControl.Controls.Add(this.UpdateTab);
            this.TabControl.Controls.Add(this.DeleteTab);
            this.TabControl.Controls.Add(this.AssignTab);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(255, 185);
            this.TabControl.TabIndex = 0;
            // 
            // InsertTab
            // 
            this.InsertTab.Controls.Add(this.ButtonPrideti);
            this.InsertTab.Controls.Add(this.textBox2);
            this.InsertTab.Controls.Add(this.textBox1);
            this.InsertTab.Controls.Add(this.LabelPavadinimas);
            this.InsertTab.Controls.Add(this.LabelKodas);
            this.InsertTab.Location = new System.Drawing.Point(4, 22);
            this.InsertTab.Name = "InsertTab";
            this.InsertTab.Padding = new System.Windows.Forms.Padding(3);
            this.InsertTab.Size = new System.Drawing.Size(247, 159);
            this.InsertTab.TabIndex = 0;
            this.InsertTab.Text = "Įdėti";
            this.InsertTab.UseVisualStyleBackColor = true;
            this.InsertTab.Click += new System.EventHandler(this.InsertTab_Click);
            // 
            // SelectTab
            // 
            this.SelectTab.Location = new System.Drawing.Point(4, 22);
            this.SelectTab.Name = "SelectTab";
            this.SelectTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTab.Size = new System.Drawing.Size(247, 159);
            this.SelectTab.TabIndex = 1;
            this.SelectTab.Text = "Gauti";
            this.SelectTab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 242);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(388, 123);
            this.dataGridView1.TabIndex = 1;
            // 
            // UpdateTab
            // 
            this.UpdateTab.Location = new System.Drawing.Point(4, 22);
            this.UpdateTab.Name = "UpdateTab";
            this.UpdateTab.Size = new System.Drawing.Size(247, 159);
            this.UpdateTab.TabIndex = 2;
            this.UpdateTab.Text = "Pakeisti";
            this.UpdateTab.UseVisualStyleBackColor = true;
            // 
            // DeleteTab
            // 
            this.DeleteTab.Location = new System.Drawing.Point(4, 22);
            this.DeleteTab.Name = "DeleteTab";
            this.DeleteTab.Size = new System.Drawing.Size(247, 159);
            this.DeleteTab.TabIndex = 3;
            this.DeleteTab.Text = "Ištrinti";
            this.DeleteTab.UseVisualStyleBackColor = true;
            // 
            // LabelPavadinimas
            // 
            this.LabelPavadinimas.AutoSize = true;
            this.LabelPavadinimas.Location = new System.Drawing.Point(17, 54);
            this.LabelPavadinimas.Name = "LabelPavadinimas";
            this.LabelPavadinimas.Size = new System.Drawing.Size(70, 13);
            this.LabelPavadinimas.TabIndex = 0;
            this.LabelPavadinimas.Text = "Pavadinimas:";
            // 
            // LabelKodas
            // 
            this.LabelKodas.AutoSize = true;
            this.LabelKodas.Location = new System.Drawing.Point(17, 21);
            this.LabelKodas.Name = "LabelKodas";
            this.LabelKodas.Size = new System.Drawing.Size(40, 13);
            this.LabelKodas.TabIndex = 1;
            this.LabelKodas.Text = "Kodas:";
            // 
            // LabelDiena
            // 
            this.LabelDiena.AutoSize = true;
            this.LabelDiena.Location = new System.Drawing.Point(373, 81);
            this.LabelDiena.Name = "LabelDiena";
            this.LabelDiena.Size = new System.Drawing.Size(38, 13);
            this.LabelDiena.TabIndex = 2;
            this.LabelDiena.Text = "Diena:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(349, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // LabelLaikas
            // 
            this.LabelLaikas.AutoSize = true;
            this.LabelLaikas.Location = new System.Drawing.Point(370, 159);
            this.LabelLaikas.Name = "LabelLaikas";
            this.LabelLaikas.Size = new System.Drawing.Size(41, 13);
            this.LabelLaikas.TabIndex = 6;
            this.LabelLaikas.Text = "Laikas:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(376, 118);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // AssignTab
            // 
            this.AssignTab.Location = new System.Drawing.Point(4, 22);
            this.AssignTab.Name = "AssignTab";
            this.AssignTab.Padding = new System.Windows.Forms.Padding(3);
            this.AssignTab.Size = new System.Drawing.Size(247, 159);
            this.AssignTab.TabIndex = 4;
            this.AssignTab.Text = "Priskirti";
            this.AssignTab.UseVisualStyleBackColor = true;
            // 
            // ButtonPrideti
            // 
            this.ButtonPrideti.Location = new System.Drawing.Point(90, 97);
            this.ButtonPrideti.Name = "ButtonPrideti";
            this.ButtonPrideti.Size = new System.Drawing.Size(75, 23);
            this.ButtonPrideti.TabIndex = 5;
            this.ButtonPrideti.Text = "Pridėti";
            this.ButtonPrideti.UseVisualStyleBackColor = true;
            // 
            // WebServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 377);
            this.Controls.Add(this.LabelLaikas);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.LabelDiena);
            this.Name = "WebServiceForm";
            this.Text = "Studijų planas";
            this.TabControl.ResumeLayout(false);
            this.InsertTab.ResumeLayout(false);
            this.InsertTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage InsertTab;
        private System.Windows.Forms.TabPage SelectTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage UpdateTab;
        private System.Windows.Forms.TabPage DeleteTab;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelPavadinimas;
        private System.Windows.Forms.Label LabelKodas;
        private System.Windows.Forms.TabPage AssignTab;
        private System.Windows.Forms.Label LabelDiena;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label LabelLaikas;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button ButtonPrideti;
    }
}

