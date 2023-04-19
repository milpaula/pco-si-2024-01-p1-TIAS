using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_CRUD_XML
{
  public class Cliente
    {
        private string _nome;
        private string _email;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
 
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

    }
}
