using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuProjeto
{
    class UsuarioFuncion
    {
        private static List<Usuario> usuarios = new List<Usuario>();

        public static void CadastrarUsuario() // <- Método de cadastro de usuários
        {
            Console.Write("Nome: ");
            string? nome = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nome))
            {
                Console.WriteLine("Nome inválido! Cadastro cancelado.");
                return;
            }

            Console.Write("E-mail: "); // <- Adiciona um campo de e-mail
            string? email = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("E-mail inválido! Cadastro cancelado.");
                return;
            }

            Console.Write("Idade: "); // <- Adiciona um campo de idade
            if (!int.TryParse(Console.ReadLine(), out int idade))
            {
                Console.WriteLine("Idade inválida! Cadastro cancelado.");
                return;
            }

            usuarios.Add(new Usuario(nome, email, idade)); // <- Adiciona o e-mail e a idade ao objeto
            Console.WriteLine("Usuário cadastrado com sucesso!");
        }   

        public static void ListarUsuarios() // <- Método de listagem de usuários
        {   // Verifica se a lista de usuários está vazia
            if (usuarios.Count == 0)
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
                return;
            }

            Console.WriteLine("\nLista de Usuários:");
            foreach (var usuario in usuarios) 
            {
                Console.WriteLine(usuario);
            }
        }

        public static void BuscarUsuario()
        {   
            Console.Write("Digite o nome do usuário:");
            string? nomeBusca = Console.ReadLine()?.Replace(" ", string.Empty)!; // O sistema não aceita valores nulos ou vazios para a busca
            if (string.IsNullOrWhiteSpace(nomeBusca))
            {
                Console.WriteLine("Nome inválido.");
                return;
            }
            // Busca o usuário na lista
            var usuarioEncontrado = usuarios.FirstOrDefault(u => u.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));
            // Verifica se o usuário foi encontrado
            if (usuarioEncontrado != null)
            {
                Console.WriteLine("Usuário encontrado:");
                Console.WriteLine(usuarioEncontrado);
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }
    }
}
