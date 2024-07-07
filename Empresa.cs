    public class Empresa
    {
        List<Funcionarios> funcionarios = new List<Funcionarios>();

        public void AdicionarFuncionario(Funcionarios funcionario)
        {
            funcionarios.Add(funcionario);
        }

          public void RemoverFuncionario(int matricula)
    {
        funcionarios.RemoveAll(f => f.MatriculaDoFuncionario == matricula);
    }


        public void ExibirFuncionarios()
        {
            foreach (Funcionarios funcionario in funcionarios)
            {
                funcionario.ExibirInformacoes();
                funcionario.ExibirProjetos();
                Console.WriteLine();
            }
        }

        public void AdicionarProjeto(int matricula, string nomeProjeto)
        {
            Funcionarios funcionario = funcionarios.Find(f => f.MatriculaDoFuncionario == matricula)!;
            if (funcionario != null)
            {
                funcionario.AdicionarProjeto(nomeProjeto);
                Console.WriteLine("Projeto adicionado com sucesso");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado");
            }
        }
    }
