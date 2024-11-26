namespace RefactoringGuru.DesignPatterns.Composite.Conceptual
{
    public class Leaf : Component
    {
        public override string Operation()
        {
            return "HOJA";
        }

        public override bool IsComposite()
        {
            return false;
        }
    }
}
