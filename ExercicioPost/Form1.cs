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
    public partial class Form1 : Form
    {
        
        public Post Postagem { get; set; } 
        public Form1()
        {
            InitializeComponent();
            Postagem = new Post();

            if(Postagem != null)
            {
               btn_Postar.Enabled = true;
               txt_Descricao.Enabled = true;
               txt_Titulo.Enabled = true;
            }
        }

        public void btn_Postar_Click(object sender, EventArgs e)
        {
            MostrarPost mostrarPost = new MostrarPost(txt_Titulo.Text,txt_Descricao.Text);
           
            mostrarPost.Show();

        }
    }
}
