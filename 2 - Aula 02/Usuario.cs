using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Aula_02
{
    internal class Usuario
    {
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }   
        public Usuario() { }
        public Usuario(string nome, DateTime dataNasc, string cpf, string telefone, string genero, string email, string senha)
        {
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
            Telefone = telefone;
            Genero = genero;
            Email = email;
            Senha = senha;
        }
    }
}
