namespace Name
{
    public class Funcionario
    {
        public int ID {get; set;}
        public string Nome {get; set;}
        public decimal Descontos {get; set;}
        public decimal SalarioBase {get; set;}
        public decimal SalarioLiquido 
        {
            get => SalarioBase - Descontos; 
        }
    }
}