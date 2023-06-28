using EmpresaMineradora;
    public class Program
    {
        static void Main(string[] args)
        {
            Mineradora1 mineradora = new Mineradora1();

            while (true)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1. Iniciar exploração");
                Console.WriteLine("2. Listar explorações");
                Console.WriteLine("3. Exibir explorações");
                Console.WriteLine("4. Deletar exploração");
                Console.WriteLine("5. Sair");

                Console.WriteLine(" ");
                Console.Write("Digite a opção desejada: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        mineradora.IniciarExploracao();
                        break;
                    case 2:
                        mineradora.ListarExploracoes();
                        break;
                    case 3:
                        mineradora.ExibirExploracao();
                    break;
                    case 4:
                        mineradora.DeletarExploracao();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }


