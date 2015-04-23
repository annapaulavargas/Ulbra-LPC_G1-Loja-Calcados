using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trabalho_G1
{
    public struct Clientes
    {
        public long codigoCliente;
        public string nome;
        public string telefone;
        public string email;
        public string dataNascimento;
    }


    class Estrutura_Cliente
    {
        public Clientes[] cliente = { };
        public int totalClientes;
       
        
        public int Pesquisa_ClienteCodigo(string nome_cliente)
        {
            int i;
            for (i = 0; i < totalClientes; i++)
            {
                if (nome_cliente == cliente[i].nome)
                {
                    return (i);
                }
            }
            return 0;
        }//FimPesquisaClienteCodigo

        public int Pesquisa_ClienteNome(long Codigo)
        {
            int i;
            for (i = 0; i < totalClientes; i++)
            {
                if (Codigo == cliente[i].codigoCliente)
                {
                    return (i);
                }
            }
            return 0;
        }//FimPesquisaClienteNome



    }//FimClasse EstruturaClientes

}
