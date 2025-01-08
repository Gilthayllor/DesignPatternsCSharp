using AbstractFactory;
using AbstractFactory.Implementations;

/*
 * O cliente não precisa conhecer as classes concretas das fábricas, apenas a interface IStationeryFactory.
 * Essa abordagem permite que o cliente use qualquer fábrica que implemente a interface IStationeryFactory
 * sem precisar alterar o código do cliente.
 */

var firstClient = new Client(new BlackStationaryFactory());
var secondClient = new Client(new YellowStationaryFactory());

firstClient.UseStationery();
secondClient.UseStationery();