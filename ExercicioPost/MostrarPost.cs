using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioPost
{
    public partial class MostrarPost : Form
    {
        

        public Post Postagem { get; set; }

        public MostrarPost(string titulo, string descricao)
        {
            InitializeComponent();
            Postagem = new Post();
            lbl_MostrarTitulo.Text = titulo;
            lbl_MostrarDescricao.Text = descricao;
            lbl_Data.Text = DateTime.Now.ToString();
        }
                       
    
        private void btn_NaoGosto_Click(object sender, EventArgs e)
        {
            Postagem.Naogosto++;
            lbl_NumNaoGosto.Text = Postagem.Naogosto.ToString();
        }

        private void btn_Gosto_Click(object sender, EventArgs e)
        {
            Postagem.Gosto++;
            lbl_NumGosto.Text = Postagem.Gosto.ToString();
        }

        
    }
}
