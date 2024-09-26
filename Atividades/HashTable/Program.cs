// Exemplo de uma agenda telefônica

using System.Collections;
using System.Linq.Expressions;

Hashtable phoneBook = new Hashtable() 
{
    //{ "Chave", "Valor" },
    { "Thomazi", "49-9961-0150" },
    { "Mauricio Gonzatto", "49-99975-8575" },
    { "Gabriel Bianchi", "49-99105-8904" }
};

// É posível adicionar elementos de diversas formas, pelo próprio índice chave inesistente
phoneBook["Thiago Padilha"] = "49-99176-8255";

// OU pelo método "Add()"
phoneBook.Add("Marcos Henrique", "49-99202-6169");

// Entretanto, a tabela hask verifica se há duplicidade de chave e pode lançar uma Exception
try
{
    phoneBook.Add("Mauricio Gonzatto", "49-99975-8575");
} catch(Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir valor repetido");
    Console.WriteLine(ex.Message);
}

// Percorrendo itens da Hastable
Console.WriteLine("\nAgenda Telefônica:");
if(phoneBook.Count == 0)
    Console.WriteLine("A agenda está vazia.");
else
    foreach(DictionaryEntry entry in phoneBook)
        Console.WriteLine($"{entry.Key}:{entry.Value}");