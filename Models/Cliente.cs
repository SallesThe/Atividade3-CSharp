namespace LHPet.Models
{
    public class Cliente(int id, string nome, string cpf, string email, string paciente)
    {
        public int Id { get; set; } = id;
        public string? Nome { get; set; } = nome;
        public string? Cpf { get; set; } = cpf;
        public string? Email { get; set; } = email;
        public string? Paciente { get; set; } = paciente;
    }
}