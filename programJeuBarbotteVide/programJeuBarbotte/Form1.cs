using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programJeuBarbotte
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent();
      }

      private void label5_Click(object sender, EventArgs e)
      {

      }

      private void btnReglement_Click(object sender, EventArgs e)
      {
         MessageBox.Show("allo !" );
      }

      private void btnBrasserDes_Click(object sender, EventArgs e)
      {
         
      }

      private void btnQuitter_Click(object sender, EventArgs e)
      {
         Application.Exit();
      }
   }
}
