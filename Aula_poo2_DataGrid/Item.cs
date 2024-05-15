using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_poo2_AgendaTelefonica
{
    internal class Item
    {
        public int id { get; set; }
        public string nome { get; set; }

        public Item(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }
    }
}
