namespace VisitorDesignPattern;

internal class ConcreteVisitorAlpha : IVisitor
{
    public void VisitConcreteComponentAlpha(ConcreteComponentAlpha element)
    {
        Console.WriteLine(element.ExclusiveMethodOfConcreteComponentAlpha() 
            + " + Concrete Visitor Alpha");
    }

    public void VisitConcreteComponentBeta(ConcreteComponentBeta element)
    {
        Console.WriteLine(element.SpecialMethodOfConcreteComponentBeta() 
            + " + Concrete Visitor Alpha");
    }
}
