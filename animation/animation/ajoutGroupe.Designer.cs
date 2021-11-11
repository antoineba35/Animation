namespace animation
{
    partial class ajoutGroupe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_ajoutGroupe = new System.Windows.Forms.Button();
            this.nvGroupe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ajoutGroupe
            // 
            this.btn_ajoutGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutGroupe.Location = new System.Drawing.Point(37, 82);
            this.btn_ajoutGroupe.Name = "btn_ajoutGroupe";
            this.btn_ajoutGroupe.Size = new System.Drawing.Size(324, 35);
            this.btn_ajoutGroupe.TabIndex = 5;
            this.btn_ajoutGroupe.Text = "Ajouter un groupe";
            this.btn_ajoutGroupe.UseVisualStyleBackColor = true;
            this.btn_ajoutGroupe.Click += new System.EventHandler(this.btn_ajoutGroupe_Click);
            // 
            // nvGroupe
            // 
            this.nvGroupe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvGroupe.Location = new System.Drawing.Point(16, 32);
            this.nvGroupe.Name = "nvGroupe";
            this.nvGroupe.Size = new System.Drawing.Size(377, 29);
            this.nvGroupe.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du groupe :";
            // 
            // ajoutGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 135);
            this.Controls.Add(this.btn_ajoutGroupe);
            this.Controls.Add(this.nvGroupe);
            this.Controls.Add(this.label1);
            this.Name = "ajoutGroupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajoutGroupe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ajoutGroupe;
        private System.Windows.Forms.TextBox nvGroupe;
        private System.Windows.Forms.Label label1;
    }
}