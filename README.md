# crs-pltz-linq-csharp
curso de linq with csharp

## Que es Linq?? - 2007

LINQ es un conjunto de tecnologías en .NET que viene del término (Language Integrated Query) que sirve para consultar datos desde diferentes fuentes de datos, estas fuentes pueden ser:

- Colecciones de objetos
- Base de datos relacionales
- Dataset, DataTable
- Documentos XML

## programacion Declarativa e imperativa

Programación declarativa
• Paradigma de la programación.
• Instrucciones donde especifico lo que quiero y no como lo quiero.
• Contraposición a la programación imperativa.
• Fiable y simple.
Programación imperativa
• Paradigma de la programación.
• Secuencia paso a paso de instrucciones.
• Contraposición a la programación declarativa.
• Código más extenso pero fácil de interpretar

```c#
// Declarativo
var listofNumbers = new int[] {1, 2,3 ,4, 5};
var item1 = listofNumbers.FirstOrDefault (p => p=1);
Console.Writeln(item1);

//Imperativo
var listofNumbers = new int[] {1, 2,3 ,4, 5};
for (int i=0; i < listofNumbers.length; i++ ) {
    if (listOfNumbers[i] == 1)
    Console.Writeln(listOfNumbers[i]);
}
```

https://replit.com/languages/csharp

- declarative code

```c#
using System;
using System.Linq;
					
public class Program
{
	public static void Main()
	{
		var Frutas = new String[] { "Mango", "Fresa", "Sandia", "Mango de Azucar", "Mango Tomy"};
		var mangoList = Frutas.Where(x => x.Contains("Mango")).ToList();
		mangoList.ForEach(p => Console.WriteLine(p));
	}
}
```