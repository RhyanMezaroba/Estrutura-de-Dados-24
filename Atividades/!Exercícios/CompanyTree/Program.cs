using CompanyTree;

static void Main(string[] args)
{
    // Cria a árvore com o CEO como raiz
    var ceo = new Person(1, "Alice", "CEO");
    var company = new Tree<Person>(ceo);

    // Cria nós para os gestores e subordinados
    var vpEngineering = new TreeNode<Person>(new Person(2, "Bob", "VP of Engineering"));
    var vpMarketing = new TreeNode<Person>(new Person(3, "Carol", "VP of Marketing"));

    var engineer1 = new TreeNode<Person>(new Person(4, "Dave", "Senior Engineer"));
    var engineer2 = new TreeNode<Person>(new Person(5, "Eve", "Junior Engineer"));
    var marketingSpecialist = new TreeNode<Person>(new Person(6, "Frank", "Marketing Specialist"));

    // Monta a estrutura da árvore
    company.Root.AddChild(vpEngineering);
    company.Root.AddChild(vpMarketing);

    vpEngineering.AddChild(engineer1);
    vpEngineering.AddChild(engineer2);
    vpMarketing.AddChild(marketingSpecialist);

    // Exibe o organograma
    Console.WriteLine("Organograma Empresarial:");
    company.Display(company.Root);
}