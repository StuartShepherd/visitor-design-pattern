namespace VisitorDesignPattern
{
    internal class ConcreteVisitorBeta : IVisitor
    {
        public void VisitConcreteComponentAlpha(ConcreteComponentAlpha element)
        {
            Console.WriteLine(element.ExclusiveMethodOfConcreteComponentAlpha() 
                + " + Concrete Visitor Beta");
        }

        public void VisitConcreteComponentBeta(ConcreteComponentBeta element)
        {
            Console.WriteLine(element.SpecialMethodOfConcreteComponentBeta() 
                + " + Concrete Visitor Beta");
        }
    }
}
