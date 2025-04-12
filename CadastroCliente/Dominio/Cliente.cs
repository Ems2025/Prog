using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CadastroCliente.Form1;

namespace CadastroCliente.Dominio
{
    internal class Cliente
    {
        private readonly ClienteRepositorio clienteRepositorio = new();

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public EnderecoCliente Endereco { get; set; }
        public GeneroCliente Genero { get; set; }
        public string NomeSocial { get; set; }
        public EtniaCliente Etnia { get; set; }
        public bool Estrangeiro { get; set; }
        public TipoCliente Tipo { get; set; }


        public List<Cliente> ListarClientes()
        {
            return clienteRepositorio.ListarClientes();
        }


    }
}
