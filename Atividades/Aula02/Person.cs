using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula02
{
    public class Person
    {
        public string _location = string.Empty;
        public string Name {get; set;} //PascalCase pq é um atributo da classe pessoa
        public int Age {get; set;} // get; set; - são atributos que nos permitem ler e grava dados, neste atributo
        //GET permite a leitura da String (NAME/AGE) e o set é utilizado para setar valor

        //método construtor (mesmo nome da classe, não tem tipo de retorno)

        public Person(string name, int age) //parâmetro sempre CAMELCASE
        {
            Name = name;
            Age = age;
        }

        public Person()
        {
            Name = "------";
        }
        //método para realocar a pessoa
        public void Realocate(string location)
        {
            if(!string.IsNullOrEmpty (location))
            {
                _location = location;
            }
        }

        public float GetDistance(string location)
        {
            return 0;
        }
    }
}