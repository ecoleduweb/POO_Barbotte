namespace Barbotte
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrasserDes_Click(object sender, EventArgs e)
        {
            // Ton code ici. On brasse les d�s seulement lorsqu'on clic.
            // pense � g�rer les cas o� le joueur gagne ou perd en affichant une bo�te de dialogue.
            // Tu peux utiliser la m�thode MessageBox.Show("Ton message ici") pour afficher un message.
            // Pour afficher les valeurs des d�s, tu peux utiliser les propri�t�s Text des labels.
            // Pour les valeurs des d�s, tu peux utiliser la m�thode Random.Next pour obtenir un nombre al�atoire entre 1 et 6.
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