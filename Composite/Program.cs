using System;

namespace RefactoringGuru.DesignPatterns.Composite.Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();

            Leaf leaf = new Leaf();
            Console.WriteLine("Cliente: Obtengo un componente simple:");
            client.ClientCode(leaf);

            Composite tree = new Composite();
            Composite branch1 = new Composite();
            branch1.Add(new Leaf());
            branch1.Add(new Leaf());
            Composite branch2 = new Composite();
            branch2.Add(new Leaf());
            tree.Add(branch1);
            tree.Add(branch2);
            Console.WriteLine("Cliente: Ahora tengo un árbol compuesto:");
            client.ClientCode(tree);

            Console.Write("Cliente: No necesito verificar las clases de componentes incluso cuando administro el árbol:\n");
            client.ClientCode2(tree, leaf);
        }
    }
}
