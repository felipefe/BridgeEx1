namespace Name
{
    public class CalculaSalario : Arquivo
    {
        public CalculaSalario(IGeraArquivo iGerar) : base(iGerar)
        {
        }

        public void ProcessaSalarioFuncionario(Funcionario f)
        {
            Console.WriteLine($"Salario Líquido: R$ {f.SalarioLiquido}");
        }
    }
}