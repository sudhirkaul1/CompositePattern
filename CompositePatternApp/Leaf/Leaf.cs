
namespace CompositePatternApp.Leaf;
using CompositePatternApp.Component;
public class Leaf : IComponent
    {
        public string Name { get; set; }
        public double Price {get; set;}
        // Constructor
        public Leaf(string name,double price)
        {
            Name = name;
            Price = price;
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name + ' ' + Price );
        }

        public double Calculate()
        {
            return Price;
        }
}