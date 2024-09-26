using System.ComponentModel.DataAnnotations;

namespace SOFBELLASALAOOO.DTO
{
    public class BloqueioDTO
    {
      
        
        [Required]
        public string Profissional { get; set; }  // Adicionado: Profissional
        [Required]
        public DateTime DataInicio { get; set; }  // Adicionado: Data de início
        [Required]
        public TimeSpan HoraInicio { get; set; }   // Adicionado: Hora de início
        [Required]
        public DateTime DataFinal { get; set; }    // Adicionado: Data final
        [Required]
        public TimeSpan HoraFinal { get; set; }    // Adicionado: Hora final
        [Required]
        public string Motivo { get; set; }

    }

}

