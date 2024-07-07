public abstract class Funcionarios //classe abstrata Funcionarios
{
    public string Nome; //atributo Nome
    public int MatriculaDoFuncionario; //atributo MatriculaDoFuncionario

    List<string> projetos = new List<string>(); //lista de projetos

    public void AdicionarProjeto(string projeto) //método para adicionar projeto
    {
        projetos.Add(projeto);  //adiciona projeto
    }

    public Funcionarios(string nome, int matricula) //construtor da classe Funcionarios
    {
        Nome = nome;
        MatriculaDoFuncionario = matricula; //atribui valores aos atributos
    }

    public abstract double CalcularSalario(); //método abstrato CalcularSalario

    public abstract void ExibirInformacoes(); //método abstrato ExibirInformacoes


    public void AdicionarProjeto(List<string> projetos) //método para adicionar projetos
    {
        foreach (string projeto in projetos) //para cada projeto na lista de projetos
        {
            AdicionarProjeto(projeto); //adiciona projeto
        }
    }

    public void ExibirProjetos() //método para exibir projetos
    {
        foreach (string projeto in projetos) //para cada projeto na lista de projetos
        {
            Console.WriteLine("Projeto: " + projeto); //exibe o projeto
        }
    }
}