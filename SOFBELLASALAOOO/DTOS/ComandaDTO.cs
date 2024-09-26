using System;
using System.ComponentModel.DataAnnotations;

namespace SOFBELLASALAOOO.DTO
{
    public class ComandaDTO
    {
        [Required]
        public DateTime Data { get; set; }  // Data da comanda

        [Required]
        public int ClienteId { get; set; }  // ID do cliente (assumindo que estamos referenciando o cliente por ID)

        [Required]
        [EmailAddress(ErrorMessage = "O e-mail inserido não é válido.")]
        public string Email { get; set; }  // Email do cliente

        [Required]
        [RegularExpression(@"\d{11}", ErrorMessage = "O CPF deve conter 11 dígitos.")]
        public string CPF { get; set; }  // CPF do cliente

        [Required]
        [Phone(ErrorMessage = "O número de telefone inserido não é válido.")]
        public string Telefone { get; set; }  // Telefone do cliente
    }
}
