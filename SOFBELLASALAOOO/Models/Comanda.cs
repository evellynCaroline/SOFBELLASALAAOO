using System;

namespace SOFBELLASALAOOO.Models
{
    
        public class Cliente
        {
            public string Nome { get; set; }  // Nome do cliente
            public int Id { get; set; }       // ID do cliente

            // Construtor para inicializar cliente
            public Cliente(int id, string nome)
            {
                Id = id;
                Nome = nome;
            }

            public override string ToString()
            {
                return $"ID: {Id}, Nome: {Nome}";
            }
        }
    

    public class Comanda
    {
        public DateTime Data { get; set; }             // Data da comanda
        public Cliente Cliente { get; set; }           // Cliente associado (assumindo que há uma classe Cliente)
        public string Email { get; set; }              // Email do cliente
        public string CPF { get; set; }                // CPF do cliente
        public string Telefone { get; set; }           // Telefone do cliente

        // Construtor para inicialização rápida
        public Comanda(DateTime data, Cliente cliente, string email, string cpf, string telefone)
        {
            Data = data;
            Cliente = cliente;
            Email = email;
            CPF = cpf;
            Telefone = telefone;
        }

        // Método para representar a Comanda como string
        public override string ToString()
        {
            return $"Data: {Data}, Cliente: {Cliente.Nome}, Email: {Email}, CPF: {CPF}, Telefone: {Telefone}";
        }
    }
}
