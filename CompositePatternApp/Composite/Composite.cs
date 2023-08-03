 namespace CompositePatternApp.Composite;
 using CompositePatternApp.Component;
  public class Composite : IComponent
    {
        public string Name { get; private set; }
        readonly IList<IComponent> children = new List<IComponent>();
        // Constructor
        public Composite(string name)
        {
            Name = name;
        }
        public void Add(IComponent component)
        {
            children.Add(component);
        }
        public  void Remove(IComponent component)
        {
            children.Remove(component);
        }
        public void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + Name);
            // Recursively display child nodes
            foreach (IComponent component in children)
            {
                component.Display(depth + 2);
            }
        }

    public double Calculate()
    {
        double total = 0;
         foreach (IComponent component in children)
            {
                total+= component.Calculate();
            }

            return total;
    }
}