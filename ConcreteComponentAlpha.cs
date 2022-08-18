namespace VisitorDesignPattern;

public class ConcreteComponentAlpha : IComponent
{
    public void Accept(IVisitor visitor) =>
        visitor.VisitConcreteComponentAlpha(this);

    public string ExclusiveMethodOfConcreteComponentAlpha() =>
        "Concrete Component Alpha";
}
