// See https://aka.ms/new-console-template for more information

using CompositePatternApp.Composite;
using CompositePatternApp.Leaf;

Console.WriteLine("Hello, World!");

Composite root = new Composite("root");
root.Add(new Leaf("Leaf A",100));
root.Add(new Leaf("Leaf B",100));
Composite bigBox = new Composite("BigBox X");
bigBox.Add(new Leaf("Leaf XA",100));
bigBox.Add(new Leaf("Leaf XB",100));

Composite smallBox = new Composite("SmallBox X1");
smallBox.Add(new Leaf("Leaf X1A",100));
smallBox.Add(new Leaf("Leaf X1B",100));
//adding small box to the big box
bigBox.Add(smallBox);
// adding the box to the main root 
root.Add(bigBox);

root.Add(new Leaf("Leaf C",100));
// Add and remove a leaf
Leaf leaf = new Leaf("Leaf D",100);
root.Add(leaf);
//root.Remove(leaf);
// Recursively display tree
root.Display(1);
double total = root.Calculate();
System.Console.WriteLine($"The total of the all the components is: {total:C}");
System.Console.WriteLine("Removing the leaf D");
root.Remove(leaf);
total = root.Calculate();
System.Console.WriteLine($"The total of the all the components is: {total:C}");
Console.ReadKey();