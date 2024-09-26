//Diferente da Tabela Hash o Dictionary nos permite, especificar o tipo de dado que será utilizado nos pares
// Key => Value
// Isso nos fornece uma estrutura fortemente tipada 

using System.Data.Common;
using System.Diagnostics;
using Dicionario;

Dictionary<string, string> dictionary = new Dictionary<string, string>()
{
    { "Chave 1", "Valor 1" },
    { "Cave 2", "Valor 2" },
};

// Obter valor do dictionary
string val = dictionary["Chave 3"];

try
{
    val = dictionary["Chave 3"];
}catch(Exception ex)
{
    Console.WriteLine("Erro ao obter valor da Chave 3!");
    Console.WriteLine(ex.Message);
}

// Verificando se a chave existe antes de acessar para evitar erros e prejuízos de execução
if(dictionary.ContainsKey("Chave 2"))
{
    Console.WriteLine($"Chave 2: {dictionary["Chave 2"]}");
}

// Outra forma de obter o valor e vitar erro 
dictionary.TryGetValue("Chave 4", out string? valor);
if(valor is not null)
    Console.WriteLine($"Chave 4: {valor}");

// Podemos adicionar da mesma forma pela chave inexistente
dictionary["Chave 0"] = "Valor 0";

// Percorrer o dictionary
foreach(KeyValuePair<string,string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key} : {kvp.Value}");
}

// Utilizando Tipos Abstratos de Dados com Dictinary
Dictionary<int, Person> dicPerson = new Dictionary<int, Person>();

dicPerson.Add(
    1,
    new Person()
    {
        Id = 0,
        BirthDate = new DateTime(2000, 3, 10),
        Name = "Rhyan Mezaroba"
    }
);

foreach(KeyValuePair<int, Person> kvp in dicPerson)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.BirthDate);
}