using System.Collections.Generic;
using System.IO;

namespace SolucaoExercicio01.Classes
{
    public class CrudCliente
    {
        private string path = @"clientes.txt";
        private static List<Cliente> correntistas = new List<Cliente>();
        public void Adicionar(Cliente correntista)
        {
            correntistas.Add(correntista);

            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{correntista.CPF};{correntista.Nome};{correntista.RG};{correntista.Endereco}");
            }
        }

        public void Editar(Cliente conta)
        {
            correntistas.Remove(conta);
            correntistas.Add(conta);
        }

        public void Excluir(Cliente conta)
        {
            correntistas.Remove(conta);
        }

        public Cliente ConsultarPorCPF(string cpf)
        {
            foreach (var item in correntistas)
            {
                if (item.CPF == cpf) 
                {
                    return item;
                }
            }
            return null;
        }

        public List<Cliente> ConsultarTodos()
        {
            return correntistas;
        }


    }
}