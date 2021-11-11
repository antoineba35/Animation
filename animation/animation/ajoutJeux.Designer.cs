namespace animation
{
    partial class ajoutJeux
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
            this.components = new System.ComponentModel.Container();
            this.nvNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nvAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nvDuree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nvMatos = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nvDescription = new System.Windows.Forms.RichTextBox();
            this.BT_Add = new System.Windows.Forms.Button();
            this.listeType = new System.Windows.Forms.ComboBox();
            this.CM_Group = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MI_DeleteGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.CM_Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // nvNom
            // 
            this.nvNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvNom.Location = new System.Drawing.Point(113, 8);
            this.nvNom.Name = "nvNom";
            this.nvNom.Size = new System.Drawing.Size(240, 26);
            this.nvNom.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom du jeux :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nvAge
            // 
            this.nvAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvAge.Location = new System.Drawing.Point(498, 8);
            this.nvAge.Name = "nvAge";
            this.nvAge.Size = new System.Drawing.Size(154, 26);
            this.nvAge.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tranche d\'âge :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nvDuree
            // 
            this.nvDuree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvDuree.Location = new System.Drawing.Point(791, 9);
            this.nvDuree.Name = "nvDuree";
            this.nvDuree.Size = new System.Drawing.Size(247, 26);
            this.nvDuree.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duree du jeux :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nvMatos
            // 
            this.nvMatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvMatos.Location = new System.Drawing.Point(12, 40);
            this.nvMatos.Name = "nvMatos";
            this.nvMatos.Size = new System.Drawing.Size(1228, 141);
            this.nvMatos.TabIndex = 8;
            this.nvMatos.Text = "";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1092, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Matérie souhaités :";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1081, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "Description du jeux :";
            // 
            // nvDescription
            // 
            this.nvDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nvDescription.Location = new System.Drawing.Point(12, 187);
            this.nvDescription.Name = "nvDescription";
            this.nvDescription.Size = new System.Drawing.Size(1228, 270);
            this.nvDescription.TabIndex = 10;
            this.nvDescription.Text = "";
            // 
            // BT_Add
            // 
            this.BT_Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BT_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Add.Location = new System.Drawing.Point(0, 465);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(1253, 32);
            this.BT_Add.TabIndex = 15;
            this.BT_Add.Text = "Ajouter un jeu";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // listeType
            // 
            this.listeType.ContextMenuStrip = this.CM_Group;
            this.listeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeType.FormattingEnabled = true;
            this.listeType.Location = new System.Drawing.Point(1044, 7);
            this.listeType.Name = "listeType";
            this.listeType.Size = new System.Drawing.Size(196, 28);
            this.listeType.TabIndex = 16;
            // 
            // CM_Group
            // 
            this.CM_Group.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_DeleteGroup});
            this.CM_Group.Name = "CM_Group";
            this.CM_Group.Size = new System.Drawing.Size(130, 26);
            // 
            // MI_DeleteGroup
            // 
            this.MI_DeleteGroup.Name = "MI_DeleteGroup";
            this.MI_DeleteGroup.Size = new System.Drawing.Size(152, 22);
            this.MI_DeleteGroup.Text = "Supprimer";
            this.MI_DeleteGroup.Click += new System.EventHandler(this.MI_DeleteGroup_Click);
            // 
            // ajoutJeux
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 497);
            this.Controls.Add(this.listeType);
            this.Controls.Add(this.BT_Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nvDescription);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nvMatos);
            this.Controls.Add(this.nvDuree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nvAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nvNom);
            this.Controls.Add(this.label1);
            this.Name = "ajoutJeux";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ajoutJeux";
            this.CM_Group.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nvNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nvAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nvDuree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox nvMatos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox nvDescription;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.ComboBox listeType;
        private System.Windows.Forms.ContextMenuStrip CM_Group;
        private System.Windows.Forms.ToolStripMenuItem MI_DeleteGroup;
    }
}