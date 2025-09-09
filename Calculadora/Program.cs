using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            ModifiedQueue<Operacoes> filaOperacoes = new ModifiedQueue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();

            ModifiedStack<decimal> pilhaResultados = new ModifiedStack<decimal>();

            while (filaOperacoes.Count != 0)
            {
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                Console.WriteLine("\nCalculo realizado: \n{0} {1} {2} = {3}", operacao.valorA, operacao.operador, operacao.valorB, operacao.resultado);
                pilhaResultados.Push(operacao.resultado);
                filaOperacoes.imprimirTodos("Proximas operacoes"); 
                
            }

            pilhaResultados.imprimirTodos("Resultados");
        }
    }
}