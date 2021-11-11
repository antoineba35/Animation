using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace animation
{
    public partial class pageAccueil : Form
    {
        public pageAccueil()
        {
            InitializeComponent();

            Global.typeAnim = SaveManager.Open();

            LoadGroup();
        }

        // affiche liste type animation
        public void LoadGroup()
        {
            this.listeType.Items.Clear();
            this.listeType.Items.Add("Tout");
            this.listeType.Items.AddRange(Global.typeAnim.ToArray());

            this.listeType.SelectedIndex = 0;
        }

        // affiche les animations dispo
        private void UpdateAnimation()
        {
            int selectedIndex = this.listeType.SelectedIndex;
            if (selectedIndex == 0)
                ShowAllAnimation();
            else if (selectedIndex > 0)
            {
                // afficher les contacts du groupe selectionné
                typeAnimation group = (typeAnimation)this.listeType.SelectedItem;
                ShowContactsOf(group);
            }
            if (this.listeAnimation.Items.Count > 0)
            {
                this.listeAnimation.SelectedIndex = 0;
            }
            else
            {
                ClearInfos();
            }
            
        }

        // afficher tous les jeux
        private void ShowAllAnimation()
        {
            this.listeAnimation.Items.Clear();

            foreach (typeAnimation anim in Global.typeAnim)
            {
                this.listeAnimation.Items.AddRange(anim.listeAnimation.ToArray());
            }
        }

        // affiche les jeux du groupe selectionnés
        private void ShowContactsOf(typeAnimation type)
        {
            this.listeAnimation.Items.Clear();
            this.listeAnimation.Items.AddRange(type.listeAnimation.ToArray());
        }

        // ajouter un jeu
        private void ajouterJeux_Click(object sender, EventArgs e)
        {
            ajoutJeux nvAjoutJeux = new ajoutJeux();
            DialogResult dr = nvAjoutJeux.ShowDialog();

            if (dr == DialogResult.OK)
            {
                // Mettre à jour la liste des contacts
                UpdateAnimation();

                // Sauvegarder les données
                SaveManager.Save(Global.typeAnim);
            }
        }

        // quand on change de catégorie on update la liste
        private void listeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInfos();
            UpdateAnimation();
        }

        // quand on selectionne une animation voir ses données
        private void listeAnimation_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animation animation = (Animation)this.listeAnimation.SelectedItem;

            if (animation != null)
            {
                ShowInfoOf(animation);
            }
        }

        // voir données d'une animation
        private void ShowInfoOf(Animation animation)
        {
            ClearInfos();

            this.nomAnimation.Text = animation.ToString();
            this.dureeAnim.Text = animation.Temps;
            this.matosAnim.Text = animation.Materiel;
            this.ageAnim.Text = animation.Age;
            this.descrJeux.Text = animation.Description;
        }

        private void ClearInfos()
        {
            this.nomAnimation.Text = "Nom de l'animation";
            this.dureeAnim.Text = "Durée de l'animation";
            this.matosAnim.Text = "Matériel utilisé par l'animation";
            this.ageAnim.Text = "Age pour l'animation";
            this.descrJeux.Text = "Description de l'animation";
        }

        private void btnSupprimerAnim_Click(object sender, EventArgs e)
        {
            Animation animation = (Animation)this.listeAnimation.SelectedItem;
            typeAnimation type = GetGroupOf(animation);

            if(animation != null && type != null)
            {
                DialogResult dr = MessageBox.Show("Etes vous sur de vouloir supprimer ce jeux ?",
                "Animation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    type.listeAnimation.Remove(animation);
                    UpdateAnimation();
                    SaveManager.Save(Global.typeAnim);
                    ClearInfos();
                }
            }           
            
        }
        private typeAnimation GetGroupOf(Animation animation)
        {
            return Global.typeAnim.Find(typeAnimation => typeAnimation.listeAnimation.Contains(animation));
        }

        private void nvType_Click(object sender, EventArgs e)
        {
            ajoutGroupe ajtJeux = new ajoutGroupe();
            if (ajtJeux.ShowDialog() == DialogResult.OK)
            {
                // && Global.nomExiste(ajtJeux.TypeToAdd.name) == true
                if (ajtJeux.TypeToAdd != null )
                {
                    Global.AddGroup(ajtJeux.TypeToAdd);

                    this.listeType.Items.Add(ajtJeux.TypeToAdd);
                    this.listeType.SelectedItem = ajtJeux.TypeToAdd;
                }
            }
            LoadGroup();
        }

        private void TB_Search_TextChanged(object sender, EventArgs e)
        {
            // On récupère la saisie de l'utilisateur (la chaine à rechercher)
            string search = this.TB_Search.Text.ToLower();

            // Si cette saisie est vide alors...
            if (search.Length <= 0)
            {
                UpdateAnimation();
                // Et on quitte la méthode
                return;
            }

            this.listeAnimation.Items.Clear();

            foreach (typeAnimation type in Global.typeAnim)
            {
                foreach (Animation a in type.listeAnimation)
                {
                    // On récupère le nom et prénom du contact courant en minuscule (ToLower)
                    string cName = a.ToString().ToLower();

                    // Si le nom complet du contact contient la chaine recherché alors...
                    if (cName.Contains(search))
                    {
                        // On ajoute le contact à la liste
                        this.listeAnimation.Items.Add(a);
                    }
                }
            }
        }

    }
}
