﻿using Aula02;

Person person = new Person();
Console.WriteLine(person.Name);

Person person1
    = new Person("Rhyan Mezaroba", 18);
Console.WriteLine(person1.Name);

Person person2 = new Person();
person2.Name = "Vladimir Ilich Ulyanov";
person2.Age = 70;
Console.WriteLine(person2.Name);

Person person3 = new Person()
{
    Name = "Leonel Brizola",
    Age = 80,
};
Console.WriteLine(person3.Name);

/*Todas essas três funções
São opções para definição de variáveis
Podendo utilizar em vários casos diferentes
*/