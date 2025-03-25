// Essa pagina contém a classe Usuario, que é usada para criar objetos do tipo Usuario.
namespace MeuProjeto
{
    class Usuario
    {
        public string Nome { get; set; } = "";
        public string Email { get; set; } = ""; // <- Evita alguns erros
        public int Idade { get; set; }
        // Construtor da classe
        public Usuario(string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }
        // Sobrescreve o método ToString
        public override string ToString() // <- Sobrescreve o método ToString
        {
            return $"Nome: {Nome}, E-mail: {Email}, Idade: {Idade}";
        }
    }
}
