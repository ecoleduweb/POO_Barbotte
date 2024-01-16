namespace Barbotte
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblDe1 = new Label();
            lblDe2 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotal = new Label();
            lblMessage = new Label();
            btnBrasserDes = new Button();
            btnQuitter = new Button();
            btnReglement = new Button();
            label5 = new Label();
            lblNombreARefaire = new Label();
            label6 = new Label();
            lblNombreLances = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(14, 14);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 216);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(268, 14);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 55);
            label1.TabIndex = 1;
            label1.Text = "Jeu barbotte";
            // 
            // lblDe1
            // 
            lblDe1.AutoSize = true;
            lblDe1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDe1.ForeColor = Color.Blue;
            lblDe1.Location = new Point(287, 165);
            lblDe1.Margin = new Padding(4, 0, 4, 0);
            lblDe1.Name = "lblDe1";
            lblDe1.Size = new Size(33, 37);
            lblDe1.TabIndex = 2;
            lblDe1.Text = "1";
            // lblDe2
            // 
            lblDe2.AutoSize = true;
            lblDe2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDe2.ForeColor = Color.Blue;
            lblDe2.Location = new Point(413, 165);
            lblDe2.Margin = new Padding(4, 0, 4, 0);
            lblDe2.Name = "lblDe2";
            lblDe2.Size = new Size(33, 37);
            lblDe2.TabIndex = 3;
            lblDe2.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(252, 121);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 37);
            label2.TabIndex = 4;
            label2.Text = "Dé 1 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(376, 121);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(93, 37);
            label3.TabIndex = 5;
            label3.Text = "Dé 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(531, 121);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 37);
            label4.TabIndex = 6;
            label4.Text = "Total : ";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.FromArgb(0, 0, 192);
            lblTotal.Location = new Point(568, 165);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 37);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "2";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(252, 362);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(145, 37);
            lblMessage.TabIndex = 8;
            lblMessage.Text = "Message";
            lblMessage.Visible = false;
            // 
            // btnBrasserDes
            // 
            btnBrasserDes.Location = new Point(97, 451);
            btnBrasserDes.Margin = new Padding(4, 3, 4, 3);
            btnBrasserDes.Name = "btnBrasserDes";
            btnBrasserDes.Size = new Size(88, 27);
            btnBrasserDes.TabIndex = 9;
            btnBrasserDes.Text = "Brasser";
            btnBrasserDes.UseVisualStyleBackColor = true;
            btnBrasserDes.Click += btnBrasserDes_Click;
            // 
            // btnQuitter
            // 
            btnQuitter.Location = new Point(522, 451);
            btnQuitter.Margin = new Padding(4, 3, 4, 3);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(88, 27);
            btnQuitter.TabIndex = 10;
            btnQuitter.Text = "Quitter";
            btnQuitter.UseVisualStyleBackColor = true;
            btnQuitter.Click += btnQuitter_Click;
            // 
            // btnReglement
            // 
            btnReglement.Location = new Point(334, 451);
            btnReglement.Margin = new Padding(4, 3, 4, 3);
            btnReglement.Name = "btnReglement";
            btnReglement.Size = new Size(88, 27);
            btnReglement.TabIndex = 11;
            btnReglement.Text = "Règlements";
            btnReglement.UseVisualStyleBackColor = true;
            btnReglement.Click += btnReglement_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(252, 234);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(187, 26);
            label5.TabIndex = 12;
            label5.Text = "Nombre à refaire :";
            // 
            // lblNombreARefaire
            // 
            lblNombreARefaire.AutoSize = true;
            lblNombreARefaire.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreARefaire.ForeColor = Color.FromArgb(0, 0, 192);
            lblNombreARefaire.Location = new Point(456, 234);
            lblNombreARefaire.Margin = new Padding(4, 0, 4, 0);
            lblNombreARefaire.Name = "lblNombreARefaire";
            lblNombreARefaire.Size = new Size(24, 26);
            lblNombreARefaire.TabIndex = 13;
            lblNombreARefaire.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(252, 267);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(201, 26);
            label6.TabIndex = 14;
            label6.Text = "Nombre de lancés :";
            // 
            // lblNombreLances
            // 
            lblNombreLances.AutoSize = true;
            lblNombreLances.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreLances.ForeColor = Color.FromArgb(0, 0, 192);
            lblNombreLances.Location = new Point(482, 267);
            lblNombreLances.Margin = new Padding(4, 0, 4, 0);
            lblNombreLances.Name = "lblNombreLances";
            lblNombreLances.Size = new Size(24, 26);
            lblNombreLances.TabIndex = 15;
            lblNombreLances.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 628);
            Controls.Add(lblNombreLances);
            Controls.Add(label6);
            Controls.Add(lblNombreARefaire);
            Controls.Add(label5);
            Controls.Add(btnReglement);
            Controls.Add(btnQuitter);
            Controls.Add(btnBrasserDes);
            Controls.Add(lblMessage);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblDe2);
            Controls.Add(lblDe1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Jeu barbotte";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDe1;
        private System.Windows.Forms.Label lblDe2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnBrasserDes;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnReglement;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNombreARefaire;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNombreLances;
    }
}
