namespace AS2425._3F.INF.Prof.DataGridView
{
    public partial class Form1 : Form
    {
        // limiti della matrice
        const int MIN_ROWCOL_MATRICE = 1;
        const int MAX_ROWCOL_MATRICE = 20;

        // limiti intervallo di valori della matrice
        const int MIN_VALUE_MATRICE = -10;
        const int MAX_VALUE_MATRICE = +10;

        // definizione matrice con i valori generati (matrice)
        private int[,] valori;
        int n_righeColonne;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAssegnaValori_Click(object sender, EventArgs e)
        {
            // crea la matrice di valori

            n_righeColonne = Convert.ToInt32("0" + txtRigheColonne.Text);

            if (n_righeColonne < MIN_ROWCOL_MATRICE || n_righeColonne > MAX_ROWCOL_MATRICE)
            {
                MessageBox.Show("Limiti matrice fuori intervallo.");
                n_righeColonne = 0;
                return;
            }

            // istanzia la matrice
            valori = new int[n_righeColonne, n_righeColonne];

            // assegna ad ogni valore della matrice un valore casuale (random)
            assegnaValoriCasuali();
        }

        /// <summary>
        /// Assegna i valori casuali nella matrice
        /// </summary>
        private void assegnaValoriCasuali()
        {
            // dichiara e istanzia la variabile casuale
            Random r = new Random();

            int valore;

            // posiziona i premi nel campo di gioco
            for (int row = 0; row < n_righeColonne; row++)
            {
                for (int col = 0; col < n_righeColonne; col++)
                {
                    valore = r.Next(MIN_VALUE_MATRICE, MAX_VALUE_MATRICE + 1);

                    // posizionalo nel campo di gioco
                    valori[row, col] = valore;
                }
            }
        }

        private void btnVisualizzaMatrice_Click(object sender, EventArgs e)
        {

        }

    }
}
