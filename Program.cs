namespace Name
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario
            {
                ID = 1,
                Nome = "Felipe",
                SalarioBase = 5000m,
                Descontos = 900,
            };


            var CalculaSalario = new CalculaSalario(new GerarXML());
            CalculaSalario.ProcessaSalarioFuncionario(funcionario);
            CalculaSalario.GravaArquivo();

        }
    }
}