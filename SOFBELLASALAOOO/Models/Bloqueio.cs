namespace SOFBELLASALAOOO.Models
{
    public class Bloqueio
    {
            public string Profissional { get; set; }  // Adicionado: Profissional
            public DateTime DataInicio { get; set; }  // Adicionado: Data de início
            public TimeSpan HoraInicio { get; set; }   // Adicionado: Hora de início
            public DateTime DataFinal { get; set; }    // Adicionado: Data final
            public TimeSpan HoraFinal { get; set; }    // Adicionado: Hora final
            public string Motivo { get; set; }         // Adicionado: Motivo

    }

}

