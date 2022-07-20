using VisitorDesignPattern;

Console.WriteLine("Visitor Design Pattern");
Console.WriteLine("Visitor is a behavioral design pattern that allows adding new behaviors to existing class hierarchy without altering any existing code.");
Console.WriteLine();

var components = new List<IComponent>
{
    new ConcreteComponentAlpha(),
    new ConcreteComponentBeta()
};

Console.WriteLine("The client code works with all visitors via the base Visitor interface:");
Console.WriteLine();

var visitorAlpha = new ConcreteVisitorAlpha();
Client.ClientCode(
    components, 
    visitorAlpha);
Console.WriteLine();

var visitorBeta = new ConcreteVisitorBeta();
Client.ClientCode(
    components, 
    visitorBeta);
Console.WriteLine();
