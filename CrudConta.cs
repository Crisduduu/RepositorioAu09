using System.Collections.Generic;
using System.IO;

namespace SolucaoExercicio01.Classes
{
    public class CrudConta
    {
        private string path = @"contas.txt";
        private static List<Conta> contas = new List<Conta>();
        public void Adicionar(Conta conta)
        {
            contas.Add(conta);
            using(StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{conta.Agencia};{conta.Numero};{conta.Saldo}");
            }
        }

        public void Editar(Conta conta)
        {
            contas.Remove(conta);
            contas.Add(conta);
        }

        public void Excluir(Conta conta)
        {
            contas.Remove(conta);
        }

        public Conta ConsultarPorAgenciaNumero(int agencia, int numero)
        {
            foreach (var item in contas)
            {
                if (item.Agencia == agencia && item.Numero == numero) 
                {
                    return item;
                }
            }
            return null;
        }

        public List<Conta> ConsultarTodos()
        {
            return contas;
        }

    }
}