namespace Barbotte
{
    public partial class Form1 : Form
    {
        bool isFirstThrow = true, isWin = false;
        bool isGameOver = false;
        int numberToMatch = 0, numberOfThrows = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrasserDes_Click(object sender, EventArgs e)
        {
            numberOfThrows++;
            int die1 = Random.Shared.Next(1, 7);
            int die2 = Random.Shared.Next(1, 7);
            int total = die1 + die2;
            // Ton code ici. On brasse les dés seulement lorsqu'on clic.
            // pense à gérer les cas où le joueur gagne ou perd en affichant une boîte de dialogue.
            // Tu peux utiliser la méthode MessageBox.Show("Ton message ici") pour afficher un message.
            // Pour afficher les valeurs des dés, tu peux utiliser les propriétés Text des labels.
            // Pour les valeurs des dés, tu peux utiliser la méthode Random.Next pour obtenir un nombre aléatoire entre 1 et 6.
            if (isFirstThrow)
            {
                switch (total)
                {
                    case 2:
                    case 3:
                    case 12:
                        isWin= false;
                        isGameOver= true;
                        break;
                    case 7:
                    case 11:
                        isWin= true;
                        isGameOver= true;
                        break;
                    default:
                        numberToMatch = total;
                        isFirstThrow = false;
                        break;
                }
            }
            else
            {
                if (numberToMatch == total)
                {
                    isWin= true;
                    isGameOver= true;
                }
                else if (total == 7)
                {
                    isWin= false;
                    isGameOver= true;
                }

            }

            updateUI(die1, die2);
            if (isGameOver)
            {
                if (isWin)
                {
                    MessageBox.Show("Vous avez gagné");
                }
                else
                {
                    MessageBox.Show("Vous avez perdu");
                }
                resetGame();
            }
        }

        private void resetGame()
        {
            isFirstThrow = true;
            isGameOver = false;
            numberOfThrows++;
            numberToMatch =  0;
            resetUI();
        }

        private void resetUI()
        {
            lblDe1.Text = "";
            lblDe2.Text = "";
            lblNombreLances.Text = "";
            lblTotal.Text = "";
            lblMessage.Text = "";
            lblNombreARefaire.Text = "";
        }

        private void updateUI(int die1, int die2)
        {
            lblDe1.Text = die1.ToString();
            lblDe2.Text = die2.ToString();
            lblNombreLances.Text = numberOfThrows.ToString();
            lblTotal.Text = (die1 + die2).ToString();
            lblMessage.Text = "";
            lblNombreARefaire.Text = numberToMatch.ToString();
        }


        private void btnReglement_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Le tirage est fait de fa?on al?atoire. \n" +
                         "Après le tirage des 2 dés la somme des faces supérieures est calculée. Si cette \n" +
                         "somme vaut 7 ou 11 au premier jet le joueur gagne. Si elle vaut 2, 3 ou 12 au \n" +
                         "premier jet, le joueur perd. Sinon si la somme vaut autre chose que ce qu'on \n" +
                         "a cité au premier jet alors elle forme les points du joueur. Dans ce cas le \n" +
                         "joueur continue à jouer le dé jusqu'à ce qu'il refasse ces points c'est à \n" +
                         "dire qu'il lance la même valeur que son premier jet pour gagner. Le joueur \n" +
                         "perd s'il lance une somme de 7 avant de refaire ces points. ");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}