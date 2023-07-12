namespace Alura.Loja.Testes.ConsoleApp.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set;}
    }
}
