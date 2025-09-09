namespace Calculadora
{
    public class Operacoes
    {
        public long valorA { get; set; }
        public char operador { get; set; }
        public long valorB { get; set; }
        public decimal resultado { get; set; }    
        public override string ToString()
        {
            return $"{valorA} {operador} {valorB}";
        }
    }
}