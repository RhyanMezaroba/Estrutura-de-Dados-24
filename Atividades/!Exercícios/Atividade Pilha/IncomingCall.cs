using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Pilha
{
    public class IncomingCall
    {
        public int Id { get; set; } // Utilize o comando "pop" e use o preenchimento SNIPPET
        public int ClientId { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public TimeSpan Duracao {get; set; }
        public string? Consultant { get; set; }
    }
}