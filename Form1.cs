namespace Barbotte
{
    public partial class Form1 : Form
    {
        // ACM Pourquoi je déclare ces variables ici en haut?
        int target, rollCount = 0;
        bool firstThrow = true;
        bool lostGame =  false;
        bool wonGame = false;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrasserDes_Click(object sender, EventArgs e)
        {
            int die1 = lanceDe();
            int die2 = lanceDe();
            // ACM Est-ce que la variable total est vraiment nécessaire?
            int total = die1 + die2;
            rollCount++;

            if (firstThrow)
            {
                validateFirstThrow(total);
            }
            else
            {
                validateSubsequentThrows(total);
            }
            
            updateUI(die1, die2);

            if(wonGame)
            {
                MessageBox.Show($"Vous avez gagné!!! en {rollCount} brasses", "Victoire!");
            }
            else if (lostGame)
            {
                MessageBox.Show("Vous avez perdu!!!", ":(");
            }

            if (wonGame || lostGame) {
                rollCount = 0;
                wonGame = lostGame =  false;
                firstThrow = true;
                resetUI();
            }

        }

        /// <summary>
        /// Permet de réinitialiser l'affichage
        /// </summary>
        private void resetUI()
        {
            lblDe1.Text  = lblDe2.Text = lblTotal.Text = lblNombreARefaire.Text = "";
            lblNombreLances.Text = "0";
        }

        /// <summary>
        /// Gestion de la logique des lancés subséquents
        /// </summary>
        /// <param name="total"></param>
        private void validateSubsequentThrows(int total)
        {
            if (total == 7)
            {
                lostGame = true;
            }
            if (total == target)
            {
                wonGame = true;
            }
        }

        /// <summary>
        /// Getsion de la logique du premier lancé
        /// </summary>
        /// <param name="total"></param>
        private void validateFirstThrow(int total)
        {
            switch(total)
            {
                case 7:
                case 11:
                    wonGame = true;
                    break;
                case 2:
                case 3:
                    lostGame = true;
                    break;
                default:
                    target = total;
                    break;
            }
            firstThrow = false;
        }

        /// <summary>
        /// Met à jour l'affichage en fonction des valeurs des dés.
        /// </summary>
        /// <param name="die1">Dé 1</param>
        /// <param name="die2">Dé 2</param>
        private void updateUI(int die1, int die2)
        {
            lblDe1.Text = die1.ToString();
            lblDe2.Text = die2.ToString();
            //ACM Je ne passe ce qui est necessaire dans ma fonction, je dois donc calculer le total ici
            lblTotal.Text = (die1 + die2).ToString();
            lblNombreLances.Text = rollCount.ToString();
            lblNombreARefaire.Text = target.ToString();
        }

        private void btnReglement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C'est un jeu de dé entre 2 personnes. Le tirage est fait de façon aléatoire. \n" +
                         "Après tirage des 2 dés la somme des faces supérieures est calculée. Si cette \n" +
                         "somme vaut 7 ou 11 au premier jet le joueur gagne. Si elle vaut 2, 3 ou 12 au \n" +
                         "premier jet, le joueur perd. Sinon si la somme vaut autre chose que ce qu'on \n" +
                         "a cité au premier jet alors elle forme les points du joueur. Dans ce cas le \n" +
                         "joueur continue à jouer le dé jusqu'à ce qu'il refasse ces points c'est à \n" +
                         "dire qu'il lance la même valeur que son premier jet pour gagner. Le joueur \n" +
                         "perd s'il lace une somme de 7 avant de refaire ces points. ");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Simule l'action de brasser un dé
        /// </summary>
        /// <returns>Une valeur entre 1 et 6</returns>
        private int lanceDe()
        {
            return random.Next(1, 6);
        }
    }
}
