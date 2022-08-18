namespace VisitorDesignPattern;

public class ConcreteComponentBeta : IComponent
{
    public void Accept(IVisitor visitor) =>
        visitor.VisitConcreteComponentBeta(this);

    public string SpecialMethodOfConcreteComponentBeta() =>
        "Concrete Component Beta";
}
