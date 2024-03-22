namespace AS2324._3G.Prof.RubricaWF
{
    public partial class Form1 : Form
    {
        const int nMaxContatti = 100;

        int nRecordInseriti = 0;

        // definizione array paralleli
        string[] cognome = new string[nMaxContatti];
        string[] nome = new string[nMaxContatti];
        string[] email = new string[nMaxContatti];
        string[] nickname = new string[nMaxContatti];
        int[] simpatia = new int[nMaxContatti];
        int[] annoNascita = new int[nMaxContatti];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAggiungi_Click(object sender, EventArgs e)
        {
            cognome[nRecordInseriti] = Convert.ToString(txtCognome.Text);
            nome[nRecordInseriti] = Convert.ToString(txtNome.Text);
            email[nRecordInseriti] = Convert.ToString(txtEmail.Text);
            nickname[nRecordInseriti] = Convert.ToString(txtNickName.Text);
            annoNascita[nRecordInseriti] = Convert.ToInt32(txtAnnoNascita.Text);
            simpatia[nRecordInseriti] = Convert.ToInt32(cmbSimpatia.Text);
            nRecordInseriti++;
            lblNRecord.Text = ($"N. record inseriti :{nRecordInseriti}");
        }

        private void btnRicerca_Click(object sender, EventArgs e)
        {
            
            
            if (cmbRicerca.Text == "")
                MessageBox.Show("E' necessario definire il campo di ricerca.");
        }
        
    }
}
