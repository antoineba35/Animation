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
    public partial class ajoutGroupe : Form
    {
        // prpriétés
        public typeAnimation TypeToAdd { get; private set; }

        public ajoutGroupe()
        {
            InitializeComponent();
        }

        private void btn_ajoutGroupe_Click(object sender, EventArgs e)
        {
            string nvType = this.nvGroupe.Text;
            if (nvType.Length > 0)
            {
                this.TypeToAdd = new typeAnimation(nvType);
                this.DialogResult = DialogResult.OK;
            }
        }

    }
}
