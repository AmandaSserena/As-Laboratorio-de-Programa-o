
    public class Empresa //classe Empresa
    {
        List<Funcionarios> funcionarios = new List<Funcionarios>(); //lista de funcionários

        public void AdicionarFuncionario(Funcionarios funcionario) //método para adicionar funcionário
        {
            funcionarios.Add(funcionario); //adiciona funcionário
        }

          public void RemoverFuncionario(int matricula) //método para remover funcionário
    {
        funcionarios.RemoveAll(f => f.MatriculaDoFuncionario == matricula); //remove funcionário
    }


        public void ExibirFuncionarios() //método para exibir funcionários
        {
            foreach (Funcionarios funcionario in funcionarios) //para cada funcionário na lista de funcionários
            {
                funcionario.ExibirInformacoes(); //exibe informações do funcionário
                funcionario.ExibirProjetos(); //exibe projetos do funcionário
                Console.WriteLine(); //pula linha
            }
        }

        public void AdicionarProjeto(int matricula, string nomeProjeto) //método para adicionar projeto
        {
            Funcionarios funcionario = funcionarios.Find(f => f.MatriculaDoFuncionario == matricula)!; //funcionário vai receber o funcionário com a matrícula informada
            if (funcionario != null)
            {
                funcionario.AdicionarProjeto(nomeProjeto); //adiciona projeto ao funcionário
                Console.WriteLine("Projeto adicionado com sucesso"); //mensagem de sucesso
            }
            else //se não encontrar o funcionário
            {
                Console.WriteLine("Funcionário não encontrado"); //mensagem de erro
            }
        }
    }
