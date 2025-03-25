using System;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args) // <- Certifique-se de que o Main está correto
        {
            // Loop infinito para o menu
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Cadastrar usuário");
                Console.WriteLine("2 - Listar usuários");
                Console.WriteLine("3 - Buscar usuário por nome");
                Console.WriteLine("4 - Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.WriteLine();
                // Switch case para as opções
                switch (opcao)
                {
                    case "1":
                        UsuarioFuncion.CadastrarUsuario();
                        break;
                    case "2":
                        UsuarioFuncion.ListarUsuarios();
                        break;
                    case "3":
                        UsuarioFuncion.BuscarUsuario();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }
        }
    }
}
