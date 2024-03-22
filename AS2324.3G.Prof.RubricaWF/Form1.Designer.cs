namespace AS2324._3G.Prof.RubricaWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCognome = new TextBox();
            label2 = new Label();
            txtNome = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtNickName = new TextBox();
            label5 = new Label();
            cmbSimpatia = new ComboBox();
            label6 = new Label();
            txtAnnoNascita = new TextBox();
            groupBox1 = new GroupBox();
            btnAggiungi = new Button();
            lblNRecord = new Label();
            groupBox2 = new GroupBox();
            btnRicerca = new Button();
            lstElenco = new ListBox();
            cmbOpzioni = new ComboBox();
            cmbRicerca = new ComboBox();
            btnElenca = new Button();
            label7 = new Label();
            txtRicerca = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 27);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Cognome";
            // 
            // txtCognome
            // 
            txtCognome.Location = new Point(105, 25);
            txtCognome.Margin = new Padding(3, 2, 3, 2);
            txtCognome.Name = "txtCognome";
            txtCognome.Size = new Size(176, 23);
            txtCognome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 29);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(382, 27);
            txtNome.Margin = new Padding(3, 2, 3, 2);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(176, 23);
            txtNome.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 52);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 0;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(105, 50);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(176, 23);
            txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 54);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 0;
            label4.Text = "NickName";
            // 
            // txtNickName
            // 
            txtNickName.Location = new Point(382, 52);
            txtNickName.Margin = new Padding(3, 2, 3, 2);
            txtNickName.Name = "txtNickName";
            txtNickName.Size = new Size(110, 23);
            txtNickName.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 75);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 0;
            label5.Text = "Simpatia";
            // 
            // cmbSimpatia
            // 
            cmbSimpatia.FormattingEnabled = true;
            cmbSimpatia.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cmbSimpatia.Location = new Point(105, 74);
            cmbSimpatia.Margin = new Padding(3, 2, 3, 2);
            cmbSimpatia.Name = "cmbSimpatia";
            cmbSimpatia.Size = new Size(59, 23);
            cmbSimpatia.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(295, 79);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 0;
            label6.Text = "Anno nascita";
            // 
            // txtAnnoNascita
            // 
            txtAnnoNascita.Location = new Point(382, 76);
            txtAnnoNascita.Margin = new Padding(3, 2, 3, 2);
            txtAnnoNascita.Name = "txtAnnoNascita";
            txtAnnoNascita.Size = new Size(59, 23);
            txtAnnoNascita.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAggiungi);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(cmbSimpatia);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtNickName);
            groupBox1.Controls.Add(txtCognome);
            groupBox1.Controls.Add(lblNRecord);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtAnnoNascita);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(658, 175);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dati contatto :";
            // 
            // btnAggiungi
            // 
            btnAggiungi.Location = new Point(261, 110);
            btnAggiungi.Margin = new Padding(3, 2, 3, 2);
            btnAggiungi.Name = "btnAggiungi";
            btnAggiungi.Size = new Size(116, 54);
            btnAggiungi.TabIndex = 4;
            btnAggiungi.Text = "Aggiungi";
            btnAggiungi.UseVisualStyleBackColor = true;
            btnAggiungi.Click += btnAggiungi_Click;
            // 
            // lblNRecord
            // 
            lblNRecord.AutoSize = true;
            lblNRecord.Location = new Point(498, 149);
            lblNRecord.Name = "lblNRecord";
            lblNRecord.Size = new Size(100, 15);
            lblNRecord.TabIndex = 0;
            lblNRecord.Text = "N. record inseriti :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRicerca);
            groupBox2.Controls.Add(lstElenco);
            groupBox2.Controls.Add(cmbOpzioni);
            groupBox2.Controls.Add(cmbRicerca);
            groupBox2.Controls.Add(btnElenca);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtRicerca);
            groupBox2.Location = new Point(10, 198);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(659, 185);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ricerca :";
            // 
            // btnRicerca
            // 
            btnRicerca.Location = new Point(468, 22);
            btnRicerca.Margin = new Padding(3, 2, 3, 2);
            btnRicerca.Name = "btnRicerca";
            btnRicerca.Size = new Size(82, 22);
            btnRicerca.TabIndex = 4;
            btnRicerca.Text = "Ricerca";
            btnRicerca.UseVisualStyleBackColor = true;
            btnRicerca.Click += btnRicerca_Click;
            // 
            // lstElenco
            // 
            lstElenco.FormattingEnabled = true;
            lstElenco.ItemHeight = 15;
            lstElenco.Location = new Point(7, 55);
            lstElenco.Margin = new Padding(3, 2, 3, 2);
            lstElenco.Name = "lstElenco";
            lstElenco.Size = new Size(639, 124);
            lstElenco.TabIndex = 3;
            // 
            // cmbOpzioni
            // 
            cmbOpzioni.FormattingEnabled = true;
            cmbOpzioni.Items.AddRange(new object[] { "Inizia per", "Finisce per", "Contiene" });
            cmbOpzioni.Location = new Point(354, 22);
            cmbOpzioni.Margin = new Padding(3, 2, 3, 2);
            cmbOpzioni.Name = "cmbOpzioni";
            cmbOpzioni.Size = new Size(103, 23);
            cmbOpzioni.TabIndex = 2;
            // 
            // cmbRicerca
            // 
            cmbRicerca.FormattingEnabled = true;
            cmbRicerca.Items.AddRange(new object[] { "Nome", "Cognome", "NickName" });
            cmbRicerca.Location = new Point(85, 22);
            cmbRicerca.Margin = new Padding(3, 2, 3, 2);
            cmbRicerca.Name = "cmbRicerca";
            cmbRicerca.Size = new Size(103, 23);
            cmbRicerca.TabIndex = 2;
            // 
            // btnElenca
            // 
            btnElenca.Location = new Point(564, 22);
            btnElenca.Margin = new Padding(3, 2, 3, 2);
            btnElenca.Name = "btnElenca";
            btnElenca.Size = new Size(82, 22);
            btnElenca.TabIndex = 2;
            btnElenca.Text = "Elenca";
            btnElenca.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 26);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 0;
            label7.Text = "Ricerca per";
            // 
            // txtRicerca
            // 
            txtRicerca.Location = new Point(192, 22);
            txtRicerca.Margin = new Padding(3, 2, 3, 2);
            txtRicerca.Name = "txtRicerca";
            txtRicerca.Size = new Size(156, 23);
            txtRicerca.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(683, 402);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Prof;3G;21/03/24;Rubrica di nominativi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtCognome;
        private Label label2;
        private TextBox txtNome;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtNickName;
        private Label label5;
        private ComboBox cmbSimpatia;
        private Label label6;
        private TextBox txtAnnoNascita;
        private GroupBox groupBox1;
        private Button btnAggiungi;
        private GroupBox groupBox2;
        private ListBox lstElenco;
        private Button btnElenca;
        private Label label7;
        private TextBox txtRicerca;
        private Button btnRicerca;
        private ComboBox cmbRicerca;
        private ComboBox cmbOpzioni;
        private Label lblNRecord;
    }
}
