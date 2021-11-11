namespace animation
{
    partial class pageAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pageAccueil));
            this.Panel_affichage = new System.Windows.Forms.Panel();
            this.listeAnimationEnreg = new System.Windows.Forms.GroupBox();
            this.btnSupprimerAnim = new System.Windows.Forms.Button();
            this.ajouterJeux = new System.Windows.Forms.Button();
            this.listeAnimation = new System.Windows.Forms.ListBox();
            this.nvType = new System.Windows.Forms.Button();
            this.listeType = new System.Windows.Forms.ComboBox();
            this.nomAnimation = new System.Windows.Forms.Label();
            this.dureeAnim = new System.Windows.Forms.Label();
            this.ageAnim = new System.Windows.Forms.Label();
            this.matosAnim = new System.Windows.Forms.Label();
            this.descrJeux = new System.Windows.Forms.Label();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.Panel_affichage.SuspendLayout();
            this.listeAnimationEnreg.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_affichage
            // 
            this.Panel_affichage.Controls.Add(this.TB_Search);
            this.Panel_affichage.Controls.Add(this.listeAnimationEnreg);
            this.Panel_affichage.Location = new System.Drawing.Point(13, 13);
            this.Panel_affichage.Name = "Panel_affichage";
            this.Panel_affichage.Size = new System.Drawing.Size(400, 635);
            this.Panel_affichage.TabIndex = 0;
            // 
            // listeAnimationEnreg
            // 
            this.listeAnimationEnreg.Controls.Add(this.btnSupprimerAnim);
            this.listeAnimationEnreg.Controls.Add(this.ajouterJeux);
            this.listeAnimationEnreg.Controls.Add(this.listeAnimation);
            this.listeAnimationEnreg.Controls.Add(this.nvType);
            this.listeAnimationEnreg.Controls.Add(this.listeType);
            this.listeAnimationEnreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeAnimationEnreg.Location = new System.Drawing.Point(4, 4);
            this.listeAnimationEnreg.Name = "listeAnimationEnreg";
            this.listeAnimationEnreg.Size = new System.Drawing.Size(393, 586);
            this.listeAnimationEnreg.TabIndex = 0;
            this.listeAnimationEnreg.TabStop = false;
            this.listeAnimationEnreg.Text = "Liste des animations";
            // 
            // btnSupprimerAnim
            // 
            this.btnSupprimerAnim.Location = new System.Drawing.Point(207, 554);
            this.btnSupprimerAnim.Name = "btnSupprimerAnim";
            this.btnSupprimerAnim.Size = new System.Drawing.Size(180, 26);
            this.btnSupprimerAnim.TabIndex = 5;
            this.btnSupprimerAnim.Text = "Supprimer";
            this.btnSupprimerAnim.UseVisualStyleBackColor = true;
            this.btnSupprimerAnim.Click += new System.EventHandler(this.btnSupprimerAnim_Click);
            // 
            // ajouterJeux
            // 
            this.ajouterJeux.Location = new System.Drawing.Point(7, 554);
            this.ajouterJeux.Name = "ajouterJeux";
            this.ajouterJeux.Size = new System.Drawing.Size(180, 26);
            this.ajouterJeux.TabIndex = 4;
            this.ajouterJeux.Text = "Ajouter";
            this.ajouterJeux.UseVisualStyleBackColor = true;
            this.ajouterJeux.Click += new System.EventHandler(this.ajouterJeux_Click);
            // 
            // listeAnimation
            // 
            this.listeAnimation.FormattingEnabled = true;
            this.listeAnimation.ItemHeight = 20;
            this.listeAnimation.Location = new System.Drawing.Point(7, 60);
            this.listeAnimation.Name = "listeAnimation";
            this.listeAnimation.Size = new System.Drawing.Size(380, 484);
            this.listeAnimation.TabIndex = 3;
            this.listeAnimation.SelectedIndexChanged += new System.EventHandler(this.listeAnimation_SelectedIndexChanged);
            // 
            // nvType
            // 
            this.nvType.BackColor = System.Drawing.Color.Transparent;
            this.nvType.Image = ((System.Drawing.Image)(resources.GetObject("nvType.Image")));
            this.nvType.Location = new System.Drawing.Point(365, 27);
            this.nvType.Name = "nvType";
            this.nvType.Size = new System.Drawing.Size(25, 25);
            this.nvType.TabIndex = 2;
            this.nvType.UseVisualStyleBackColor = false;
            this.nvType.Click += new System.EventHandler(this.nvType_Click);
            // 
            // listeType
            // 
            this.listeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(6, 25);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(355, 28);
            this.listeType.TabIndex = 0;
            this.listeType.SelectedIndexChanged += new System.EventHandler(this.listeType_SelectedIndexChanged);
            // 
            // nomAnimation
            // 
            this.nomAnimation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomAnimation.Location = new System.Drawing.Point(437, 13);
            this.nomAnimation.Name = "nomAnimation";
            this.nomAnimation.Size = new System.Drawing.Size(973, 50);
            this.nomAnimation.TabIndex = 3;
            this.nomAnimation.Text = "Nom de l\'animation";
            this.nomAnimation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dureeAnim
            // 
            this.dureeAnim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dureeAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dureeAnim.Location = new System.Drawing.Point(437, 63);
            this.dureeAnim.Name = "dureeAnim";
            this.dureeAnim.Size = new System.Drawing.Size(480, 33);
            this.dureeAnim.TabIndex = 4;
            this.dureeAnim.Text = "Durée de l\'animation";
            this.dureeAnim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ageAnim
            // 
            this.ageAnim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageAnim.Location = new System.Drawing.Point(930, 63);
            this.ageAnim.Name = "ageAnim";
            this.ageAnim.Size = new System.Drawing.Size(480, 33);
            this.ageAnim.TabIndex = 5;
            this.ageAnim.Text = "Tranche d\'âge";
            this.ageAnim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // matosAnim
            // 
            this.matosAnim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matosAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matosAnim.Location = new System.Drawing.Point(437, 116);
            this.matosAnim.Name = "matosAnim";
            this.matosAnim.Size = new System.Drawing.Size(973, 94);
            this.matosAnim.TabIndex = 6;
            this.matosAnim.Text = "Matériel";
            this.matosAnim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descrJeux
            // 
            this.descrJeux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descrJeux.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrJeux.Location = new System.Drawing.Point(437, 226);
            this.descrJeux.Name = "descrJeux";
            this.descrJeux.Size = new System.Drawing.Size(973, 422);
            this.descrJeux.TabIndex = 7;
            this.descrJeux.Text = "Description du jeux";
            this.descrJeux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Search
            // 
            this.TB_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Search.Location = new System.Drawing.Point(17, 596);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(380, 26);
            this.TB_Search.TabIndex = 6;
            this.TB_Search.TextChanged += new System.EventHandler(this.TB_Search_TextChanged);
            // 
            // pageAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 673);
            this.Controls.Add(this.descrJeux);
            this.Controls.Add(this.matosAnim);
            this.Controls.Add(this.ageAnim);
            this.Controls.Add(this.dureeAnim);
            this.Controls.Add(this.nomAnimation);
            this.Controls.Add(this.Panel_affichage);
            this.Name = "pageAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Animation";
            this.Panel_affichage.ResumeLayout(false);
            this.Panel_affichage.PerformLayout();
            this.listeAnimationEnreg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_affichage;
        private System.Windows.Forms.GroupBox listeAnimationEnreg;
        private System.Windows.Forms.ComboBox listeType;
        private System.Windows.Forms.Button nvType;
        private System.Windows.Forms.ListBox listeAnimation;
        private System.Windows.Forms.Label nomAnimation;
        private System.Windows.Forms.Label dureeAnim;
        private System.Windows.Forms.Label ageAnim;
        private System.Windows.Forms.Label matosAnim;
        private System.Windows.Forms.Label descrJeux;
        private System.Windows.Forms.Button ajouterJeux;
        private System.Windows.Forms.Button btnSupprimerAnim;
        private System.Windows.Forms.TextBox TB_Search;
    }
}

