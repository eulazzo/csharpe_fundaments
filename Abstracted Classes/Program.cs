/*
namespace Acourse
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      //c1 and a1 are descendants of Vehicle
      Car c1 = new Car(3434);
      Airplane a1 = new Airplane(3434);
      TravelToCalifornia(a1);


      static void TravelToCalifornia(Vehicle vehicle)
      {
        vehicle.Move(1000);
      }
    }
  }
}
/*

DEFINITIONS

Classes Abstratas:

- Uma classe abstrata é uma classe que não pode ser instanciada. Você não pode criar um objeto a partir de uma classe abstrata.
- Uma classe abstrata pode ser herdada e geralmente serve como classe base para outras classes.
- Uma classe abstrata pode conter métodos abstratos e métodos comuns. Uma classe abstrata também podem possuir construtores, propriedades, indexadores e eventos.
- Uma classe abstrata não pode ser estática (static). Uma classe abstrata não pode ser selada (sealed).
- Uma classe abstrata pode herdar de outra classe abstrata.

Métodos Abstratos:

- Um método abstrato é um método que não possui implementação na classe abstrata. Um método abstrato possui somente a definição de sua assinatura. A sua implementação deve ser feita na classe derivada.
- Um método abstrato é um método virtual e deve ser implementado usando o modificador override.
- Um método abstrato somente pode existir em uma classe abstrata.
- Um método abstrato não pode usar os modificadores static e virtual.

*/


