using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPost
{
    public class Post
    {
        #region Atributos 

       public string _titulo;

       public string _descrição;

       public DateTime _data;

       public int _gosto;

       public int _naogosto;

       public int _numgosto;

       public int _numnaogosto;

        #endregion

        public string Titulo
        {
            get { return _titulo; }
            set { _titulo = value; }
        }

        public string Descricao
        {
            get { return _descrição;}
            set { _descrição = value;}
        }
        
        public DateTime Data
        {
            get { return _data; }
        }

        #region Propriedades

        public int Gosto
        {
            get
            {
                return _gosto;
            }
            set
            {
                if(value >= 0)
                {
                    _gosto = value;
                }
            }
        }
        public int Naogosto
        {
            get
            { 
                return _naogosto;
            }
            set
            {
                if(value >= 0)
                {
                    _naogosto = value;
                }
            }
        }
        #endregion
    }





}
