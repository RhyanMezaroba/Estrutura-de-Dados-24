using ListaGenérica;

List<double> numbers = new List<double>(); //quando eu coloco algum dado entre "<>", significa que via ser um dado igual a expressão List

    do
    {
        Console.Write("Informe um número:");
        string? numberStr = Console.ReadLine(); //Validando a entrada do usuário
        if (!double.TryParse(numberStr, out double number)) //TRYPARSE => Tente validar = true or false
            break;        

        numbers.Add(number);
        Console.WriteLine($"A média dos valores é {numbers.Average()}" );
    }
    while (true);
    // - Lista de Pessoas

    List <Person> people = new List<Person>();
    
    Person p1 = new Person();
    p1.Name = "Rhyan";
    p1.Age = 19;
    p1.Country = CountryEnum.PY;
    people.Add(p1);

    p1.Name = "Joaquim José da Silva Xavier";

    people.Add(new Person(){
        Name = "Sharon Stone",
        Age = 64,
        Country = CountryEnum.PY,
    });

    Person p3 = new Person(){
        Name = "Arnold E-SuasNega",
        Age= 85,
        Country = CountryEnum.JP,
    };
    people.Add(p3);

// Formas de percorrer a Lista Genérica
foreach(Person p in people)
{
    Console.WriteLine(p.Name);
}

// Modo for tradicional
for(int i = 0; i < people.Count; i++)
{
    Console.WriteLine(people[i].Name); // OUUUUUuuu
    Console.WriteLine($"Nome: {people[i].Name}");
}