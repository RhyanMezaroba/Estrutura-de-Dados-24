using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_Pilha
{
    public class CallCenter // Essa classe só especifica 1 CallCenter, mas para cada CallCenter vai ter uma fila de chamadas
    {
        private int _counter = 0;
        public Queue<IncomingCall>? Calls { get; set; }
        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();
        }

        // Método para abertura de chamados
        public void Push(int clientId) // Variáveis como "clientId", podem começar com letras minúsculas para não confundir
        {
            Calls!.Enqueue(
                new IncomingCall()
                {
                    Id = ++_counter,
                    ClientId = clientId,
                    CallTime = DateTime.Now
                }
            );
        }
    public IncomingCall Answer(string consultant)
        {
            // Validação: Verificar se tem atendimentos na fila
            if(Calls!.Count > 0)
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = consultant;
                call.StartTime = DateTime.Now;
                return call;
            }

            return null!;
        }

        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return Calls!.Count > 0;
        }
    }
}