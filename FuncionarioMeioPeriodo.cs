public class FuncionarioMeioPeriodo : Funcionarios, IBonus
{
    private double salarioPorHora;
    private double horasTrabalhadas;


    public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, double horasTrabalhadas) : base(nome, matricula)
    {
        this.salarioPorHora = salarioPorHora;
        this.horasTrabalhadas = horasTrabalhadas;
    }

    public override double CalcularSalario()
    {
        return salarioPorHora * horasTrabalhadas;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("Matrícula: " + MatriculaDoFuncionario);
        Console.WriteLine("Salário por hora: " + salarioPorHora);
    }

     public double CalcularBonus()
    {
        return salarioPorHora * 0.5;
    }
}
