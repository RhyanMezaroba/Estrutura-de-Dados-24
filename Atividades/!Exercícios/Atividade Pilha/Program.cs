using System.Diagnostics;
using Atividade_Pilha;

Stack<CallCenter> stack = new Stack<CallCenter>();
{
    Random random = new Random();

    CallCenter center = new();
    center.Push(1234);
    center.Push(1369);
    center.Push(2468);
    center.Push(1478);

    while(center.AreWaitingCalls())
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        Thread.Sleep(1000);
        IncomingCall call = center.Answer("Marquinhos");
        Console.WriteLine(
        @$"{DateTime.Now:HH:mm:ss} 
        Chamado: #{call.Id} 
        De: {call.ClientId} 
        Atendido por: {call.Consultant}"
        );
        Thread.Sleep(random.Next(1000, 10000));
        center.End(call);
        timer.Stop();
        call.Duracao = timer.Elapsed;
        Console.WriteLine(
        @$"Chamado: {call.Id} 
        Encerramento às: {call.EndTime} 
        Duração total de {call.Duracao.TotalSeconds} segundos!");
        Console.WriteLine();
    };
    while(stack.Count > 0)
    {
        center.Pop(1234);
        center.Pop(1369);
        center.Pop(2468);
        center.Pop(1478);
    }
}
