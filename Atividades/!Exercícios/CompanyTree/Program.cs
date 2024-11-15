using CompanyTree;

    // Cria a árvore com o CEO como raiz
    var ceo = new Person(1, "Cleitin Beiramar", "CEO");
    var company = new Tree<Person>(ceo);

    // Cria nós para os gestores e subordinados
    var vpEngineering = new TreeNode<Person>(new Person(2, "Jhonatan Felipe", "VP de Engenheiro"));
    var vpMarketing = new TreeNode<Person>(new Person(3, "Carol Zanin", "VP de Marketing"));

    var engineer1 = new TreeNode<Person>(new Person(4, "Dave Edwards", "Engenheiro Senior"));
    var engineer2 = new TreeNode<Person>(new Person(5, "Eve Da Eveslandia", "Engenheira Junior"));
    var marketingSpecialist = new TreeNode<Person>(new Person(6, "É o Frank", "Especialista de Marketing"));

    // Monta a estrutura da árvore
    company.Root.AddChild(vpEngineering);
    company.Root.AddChild(vpMarketing);

    vpEngineering.AddChild(engineer1);
    vpEngineering.AddChild(engineer2);
    vpMarketing.AddChild(marketingSpecialist);

    // Exibe o organograma
    Console.WriteLine("Organograma Empresarial:");
    company.Display(company.Root);