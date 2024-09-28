using System.Data.Common;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Security.Cryptography;
using Atividade___Dictionary;

Dictionary<Product, string> ShelfProduct = new Dictionary<Product, string>()
{
    {new Product()
    {
        Id = "123456789001",
        Name = "Product1",
        Price = 10.99
    }, "A6"},

    {new Product()
    {
        Id = "123456789002",
        Name = "Product2",
        Price = 24.99
    }, "A6"},

    {new Product()
    {
        Id = "123456789003",
        Name = "Product3",
        Price = 32.99
    }, "A6"},

    {new Product()
    {
        Id = "123456789004",
        Name = "Product4",
        Price = 4.75
    }, "A6"},

    {new Product()
    {
        Id = "123456789005",
        Name = "Product5",
        Price = 7.75
    }, "A6"},

    {new Product()
    {
        Id = "123456789006",
        Name = "Product6",
        Price = 11.75
    }, "B8"},

    {new Product()
    {
        Id = "123456789007",
        Name = "Product7",
        Price = 21.99
    }, "B8"},

    {new Product()
    {
        Id = "123456789008",
        Name = "Product8",
        Price = 42.43
    }, "B8"},

    {new Product()
    {
        Id = "123456789009",
        Name = "Product9",
        Price = 25.43
    }, "B8"},

    {new Product()
    {
        Id = "123456789010",
        Name = "Product10",
        Price = 84.43
    }, "B8"},

    {new Product()
    {
        Id = "123456789011",
        Name = "Product11",
        Price = 84.19
    }, "C4"},

    {new Product()
    {
        Id = "123456789012",
        Name = "Product12",
        Price = 84.19
    }, "C4"},

    {new Product()
    {
        Id = "123456789013",
        Name = "Product13",
        Price = 21.19
    }, "C4"},

    {new Product()
    {
        Id = "123456789014",
        Name = "Product14",
        Price = 21.19
    }, "C4"},

    {new Product()
    {
        Id = "123456789015",
        Name = "Product15",
        Price = 12.99
    }, "C4"},

    {new Product()
    {
        Id = "123456789016",
        Name = "Product16",
        Price = 12.99
    }, "C9"},

    {new Product()
    {
        Id = "123456789017",
        Name = "Product17",
        Price = 12.99
    }, "C9"},

    {new Product()
    {
        Id = "123456789018",
        Name = "Product18",
        Price = 12.49
    }, "C9"},

    {new Product()
    {
        Id = "123456789019",
        Name = "Product19",
        Price = 23.49
    }, "C9"},

    {new Product()
    {
        Id = "123456789020",
        Name = "Product20",
        Price = 23.99
    }, "C9"}
};

while(true)
{
    Console.Write
    (@"Digite 'sair' para sair!
    Digite ou passe o barras do produto:");
    string? codeId = Console.ReadLine();
    

    if(codeId?.ToLower()  == "sair")
        break;

    if(codeId?.Length != 12 || !long.TryParse(codeId, out _))
    {
        Console.WriteLine("\nCódigo de Barras inválido,por favor tente novamente!");
        continue;
    }

    Product SearchProduct = null!;
    foreach(var entry in ShelfProduct)
    {
        if(entry.Key.Id == codeId)
        {
            SearchProduct = entry.Key;
            break;
        }
    }
    if(SearchProduct != null)
    {
        string location = ShelfProduct[SearchProduct];
        Console.WriteLine($"Produto: {SearchProduct.Name}");
        Console.WriteLine($"Preço: R${SearchProduct.Price:F2}");
        Console.WriteLine($"Localização: {location}");
    }
    else
    {
        Console.WriteLine("Produto não encontrado, verifique o código de barras e passe novamente!");
    }

}