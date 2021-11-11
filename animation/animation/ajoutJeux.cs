using System;
using System.Drawing;
using System.Windows.Forms;

namespace animation
{
    public partial class ajoutJeux : Form
    {
        public ajoutJeux()
        {
            InitializeComponent();
            LoadGroup();
        }

        public void LoadGroup()
        {
            this.listeType.Items.Clear();
            this.listeType.Items.AddRange(Global.typeAnim.ToArray());

            Console.WriteLine(Global.typeAnim[0]);

            this.listeType.SelectedIndex = 0;
        }

        private void BT_Add_Click(object sender, EventArgs e)
        {
            string nvNom = this.nvNom.Text;
            string nvAge = this.nvAge.Text;
            string nvDuree = this.nvDuree.Text;
            string nvMatos = this.nvMatos.Text;
            string nvDescription = this.nvDescription.Text;
            typeAnimation type = (typeAnimation)this.listeType.SelectedItem;

            if (CheckInputs(nvNom, nvAge, nvDuree, nvMatos, nvDescription, type))
            {
                Animation animation = new Animation(nvNom, nvAge, nvMatos, nvDuree, nvDescription);

                type.listeAnimation.Add(animation);

                // fermer la fenetre
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Veuillez entrer tous les champs !", "Animation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool CheckInputs(string nvNom, string nvAge, string nvDurée, string nvMatos, string nvDescription, typeAnimation type)
        {
            return !string.IsNullOrEmpty(nvNom)
                && !string.IsNullOrEmpty(nvAge)
                && !string.IsNullOrEmpty(nvDurée)
                && !string.IsNullOrEmpty(nvMatos)
                && !string.IsNullOrEmpty(nvDescription)
                && type != null;
        }

        private void MI_DeleteGroup_Click(object sender, EventArgs e)
        {
            if (this.listeType.SelectedIndex >= 0)
            {
                typeAnimation type = (typeAnimation)this.listeType.SelectedItem;

                if (type.listeAnimation.Count > 0)
                {
                    DialogResult dr = MessageBox.Show("Ce groupe contient des contacts qui vont être supprimés ! \n Etes vous sur de vouloir le supprimer", "MyContacts",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                }

                Global.DeleteGroup(type);

                this.listeType.Items.Remove(type);

                if (this.listeType.Items.Count >= 0)
                {
                    this.listeType.SelectedIndex = 0;
                }
            }
        }
    }
}
