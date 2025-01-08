using Factory;

/*
 * Neste exemplo, temos a classe Creator que é uma classe abstrata que define um método abstrato Create.
 * As classes ConcreteCreatorA e ConcreteCreatorB são classes concretas que implementam o método Create
 * e retornam instâncias de ProductA e ProductB, respectivamente.
 *
 * O código cliente usa as classes ConcreteCreatorA e ConcreteCreatorB para criar instâncias de IProduct sem conhecer
 * as implementações concretas de IProduct (ProductA e ProductB).
 */

var concreteCreatorA = new ConcreteCreatorA();
var concreteCreatorB = new ConcreteCreatorB();

var productA = concreteCreatorA.Create();
var productB = concreteCreatorB.Create();

Console.WriteLine(productA.GetName());
Console.WriteLine(productB.GetName());

