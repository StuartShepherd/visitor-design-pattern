namespace VisitorDesignPattern
{
    public interface IVisitor
    {
        void VisitConcreteComponentAlpha(ConcreteComponentAlpha element);
        void VisitConcreteComponentBeta(ConcreteComponentBeta element);
    }
}
