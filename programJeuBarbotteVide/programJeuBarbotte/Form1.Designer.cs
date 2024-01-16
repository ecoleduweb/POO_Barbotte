namespace programJeuBarbotte
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
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label1 = new System.Windows.Forms.Label();
         this.lblDe1 = new System.Windows.Forms.Label();
         this.lblDe2 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.lblTotal = new System.Windows.Forms.Label();
         this.lblMessage = new System.Windows.Forms.Label();
         this.btnBrasserDes = new System.Windows.Forms.Button();
         this.btnQuitter = new System.Windows.Forms.Button();
         this.btnReglement = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.lblNombreARefaire = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.lblNombreLances = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::programJeuBarbotte.Properties.Resources.Barbotte;
         this.pictureBox1.Location = new System.Drawing.Point(12, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(146, 187);
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.label1.Location = new System.Drawing.Point(230, 12);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(292, 55);
         this.label1.TabIndex = 1;
         this.label1.Text = "Jeu barbotte";
         // 
         // lblDe1
         // 
         this.lblDe1.AutoSize = true;
         this.lblDe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDe1.ForeColor = System.Drawing.Color.Blue;
         this.lblDe1.Location = new System.Drawing.Point(246, 143);
         this.lblDe1.Name = "lblDe1";
         this.lblDe1.Size = new System.Drawing.Size(33, 37);
         this.lblDe1.TabIndex = 2;
         this.lblDe1.Text = "1";
         // 
         // lblDe2
         // 
         this.lblDe2.AutoSize = true;
         this.lblDe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblDe2.ForeColor = System.Drawing.Color.Blue;
         this.lblDe2.Location = new System.Drawing.Point(354, 143);
         this.lblDe2.Name = "lblDe2";
         this.lblDe2.Size = new System.Drawing.Size(33, 37);
         this.lblDe2.TabIndex = 3;
         this.lblDe2.Text = "1";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.label2.Location = new System.Drawing.Point(216, 105);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 37);
         this.label2.TabIndex = 4;
         this.label2.Text = "Dé 1 :";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.label3.Location = new System.Drawing.Point(322, 105);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(93, 37);
         this.label3.TabIndex = 5;
         this.label3.Text = "Dé 2:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.label4.Location = new System.Drawing.Point(455, 105);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(116, 37);
         this.label4.TabIndex = 6;
         this.label4.Text = "Total : ";
         // 
         // lblTotal
         // 
         this.lblTotal.AutoSize = true;
         this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.lblTotal.Location = new System.Drawing.Point(487, 143);
         this.lblTotal.Name = "lblTotal";
         this.lblTotal.Size = new System.Drawing.Size(35, 37);
         this.lblTotal.TabIndex = 7;
         this.lblTotal.Text = "2";
         // 
         // lblMessage
         // 
         this.lblMessage.AutoSize = true;
         this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblMessage.ForeColor = System.Drawing.Color.Red;
         this.lblMessage.Location = new System.Drawing.Point(216, 314);
         this.lblMessage.Name = "lblMessage";
         this.lblMessage.Size = new System.Drawing.Size(145, 37);
         this.lblMessage.TabIndex = 8;
         this.lblMessage.Text = "Message";
         this.lblMessage.Visible = false;
         // 
         // btnBrasserDes
         // 
         this.btnBrasserDes.Location = new System.Drawing.Point(83, 391);
         this.btnBrasserDes.Name = "btnBrasserDes";
         this.btnBrasserDes.Size = new System.Drawing.Size(75, 23);
         this.btnBrasserDes.TabIndex = 9;
         this.btnBrasserDes.Text = "Brasser";
         this.btnBrasserDes.UseVisualStyleBackColor = true;
         this.btnBrasserDes.Click += new System.EventHandler(this.btnBrasserDes_Click);
         // 
         // btnQuitter
         // 
         this.btnQuitter.Location = new System.Drawing.Point(447, 391);
         this.btnQuitter.Name = "btnQuitter";
         this.btnQuitter.Size = new System.Drawing.Size(75, 23);
         this.btnQuitter.TabIndex = 10;
         this.btnQuitter.Text = "Quitter";
         this.btnQuitter.UseVisualStyleBackColor = true;
         this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
         // 
         // btnReglement
         // 
         this.btnReglement.Location = new System.Drawing.Point(286, 391);
         this.btnReglement.Name = "btnReglement";
         this.btnReglement.Size = new System.Drawing.Size(75, 23);
         this.btnReglement.TabIndex = 11;
         this.btnReglement.Text = "Règlements";
         this.btnReglement.UseVisualStyleBackColor = true;
         this.btnReglement.Click += new System.EventHandler(this.btnReglement_Click);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.label5.Location = new System.Drawing.Point(216, 203);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(187, 26);
         this.label5.TabIndex = 12;
         this.label5.Text = "Nombre à refaire :";
         this.label5.Click += new System.EventHandler(this.label5_Click);
         // 
         // lblNombreARefaire
         // 
         this.lblNombreARefaire.AutoSize = true;
         this.lblNombreARefaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNombreARefaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.lblNombreARefaire.Location = new System.Drawing.Point(391, 203);
         this.lblNombreARefaire.Name = "lblNombreARefaire";
         this.lblNombreARefaire.Size = new System.Drawing.Size(24, 26);
         this.lblNombreARefaire.TabIndex = 13;
         this.lblNombreARefaire.Text = "0";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.label6.Location = new System.Drawing.Point(216, 231);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(201, 26);
         this.label6.TabIndex = 14;
         this.label6.Text = "Nombre de lancés :";
         // 
         // lblNombreLances
         // 
         this.lblNombreLances.AutoSize = true;
         this.lblNombreLances.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblNombreLances.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
         this.lblNombreLances.Location = new System.Drawing.Point(413, 231);
         this.lblNombreLances.Name = "lblNombreLances";
         this.lblNombreLances.Size = new System.Drawing.Size(24, 26);
         this.lblNombreLances.TabIndex = 15;
         this.lblNombreLances.Text = "0";
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(623, 544);
         this.Controls.Add(this.lblNombreLances);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.lblNombreARefaire);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.btnReglement);
         this.Controls.Add(this.btnQuitter);
         this.Controls.Add(this.btnBrasserDes);
         this.Controls.Add(this.lblMessage);
         this.Controls.Add(this.lblTotal);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.lblDe2);
         this.Controls.Add(this.lblDe1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.Name = "Form1";
         this.Text = "Jeu barbotte";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

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

