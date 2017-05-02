using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supervisorio
{
    public class Transelevador
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string codigo { get; set; }
        public float preco { get; set; }
        public int estocado { get; set; }
        public int minimo { get; set; }

        public override string ToString()
        {
            string resposta = ("Prateleira: " + Id.ToString() +"\nNome do produto: " + nome + 
                "\nDescrição do produto: " + descricao + "\nCódigo de estoque: " + codigo + 
                "\nPreço do fornecedor: R$ " + preco + "\nQuantidade em estoque: " + estocado +
                "\nQuantidade mínima: " + minimo);
            return resposta;
        }
    }
}
