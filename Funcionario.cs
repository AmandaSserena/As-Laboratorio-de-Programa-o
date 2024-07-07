public abstract class Funcionarios
{
    public string Nome;
    public int MatriculaDoFuncionario;

    List<string> projetos = new List<string>();

    public void AdicionarProjeto(string projeto)
    {
        projetos.Add(projeto);
    }
  
    public Funcionarios(string nome, int matricula)
    {
        Nome = nome;
        MatriculaDoFuncionario = matricula;
    }

    public abstract double CalcularSalario();

    public abstract void ExibirInformacoes();


    public void AdicionarProjeto(List<string> projetos)
    {
        foreach (string projeto in projetos)
        {
            AdicionarProjeto(projeto);
        }
    }

    public void ExibirProjetos()
    {
        foreach (string projeto in projetos)
        {
            Console.WriteLine(projeto);
        }
    }
}