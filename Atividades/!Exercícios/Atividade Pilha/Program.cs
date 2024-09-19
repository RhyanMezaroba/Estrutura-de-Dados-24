using Atividade_Pilha;

Stack<int> stack = new Stack<int>();
{

    Random random = new Random();

    CallCenter center = new();
    center.Push(1234);
    center.Push(1369);
    center.Push(2468);
    center.Push(1478);

    while(center.AreWaitingCalls())
    {
        Thread.Sleep(3000);
        IncomingCall call = center.Answer("Marquinhos");
        Console.WriteLine(
        @$"{DateTime.Now:HH:mm:ss} 
        Chamado: #{call.Id} 
        De: {call.ClientId} 
        Atendido por: {call.Consultant}"
        );
        Thread.Sleep(random.Next(1000, 10000));
        center.End(call);
        Console.WriteLine(
        @$"Chamado: {call.Id} 
        Encerramento às: {call.EndTime}"
        );
    }
    foreach(Object  obj in stack)
    {
        Console.WriteLine(stack);
    }
    int inverted;
    while(stack.Count > 0)
    {
        inverted += stack.Pop ();
    }
Console.WriteLine (inverted);
}
