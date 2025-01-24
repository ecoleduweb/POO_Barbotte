namespace Barbotte
{
    public partial class Form1 : Form
    {
        bool isGameOver = false, isWin = false;
        int numberToMatch = 0, numberOfThrows = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBrasserDes_Click(object sender, EventArgs e)
        {
            numberOfThrows++;
            bool isFirstThrow = numberOfThrows == 1;
            int die1 = Random.Shared.Next(1, 7);
            int die2 = Random.Shared.Next(1, 7);
            int total = die1 + die2;
            if (!isFirstThrow)
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
                        break;
                }
            }
            // Si ce n'est pas le premier jet
            else if (numberToMatch == total)
            {
                isWin= true;
                isGameOver= true;
            }
            else if (total == 7)
            {
                isWin= false;
                isGameOver= true;
            }


            updateUI(die1, die2);
            if (isGameOver)
            {
                if (isWin)
                {
                    MessageBox.Show("Vous avez gagn�");
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
            isGameOver = false;
            numberOfThrows = 0;
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
                         "Apr�s le tirage des 2 d�s la somme des faces sup�rieures est calcul�e. Si cette \n" +
                         "somme vaut 7 ou 11 au premier jet le joueur gagne. Si elle vaut 2, 3 ou 12 au \n" +
                         "premier jet, le joueur perd. Sinon si la somme vaut autre chose que ce qu'on \n" +
                         "a cit� au premier jet alors elle forme les points du joueur. Dans ce cas le \n" +
                         "joueur continue � jouer le d� jusqu'� ce qu'il refasse ces points c'est � \n" +
                         "dire qu'il lance la m�me valeur que son premier jet pour gagner. Le joueur \n" +
                         "perd s'il lance une somme de 7 avant de refaire ces points. ");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}