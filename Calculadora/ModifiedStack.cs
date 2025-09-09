using System;
using System.Collections.Generic;
namespace Calculadora
{
public class ModifiedStack<T> : Stack<T>
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