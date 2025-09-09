using System;
using System.Collections.Generic;
namespace Calculadora
{
public class ModifiedQueue<T> : Queue<T>
    {
        // Imprime todas as operações da fila
        public void imprimirTodos(String mensagem)
        {
            if (this.Count != 0)
            {
                Console.WriteLine($"\n{mensagem}:");
                foreach (var operacoes in this)
                {
                    Console.WriteLine(operacoes);
                }
            }   
        }
    }
}