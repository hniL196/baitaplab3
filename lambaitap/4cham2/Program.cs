using System.Linq.Expressions;
using System;
using System.Runtime.CompilerServices;

public class bonchamhai
{
    public static void Main(string[] args)
    {
        Saler linh = new Saler(400,"Linh","HN",300);
        Console.WriteLine($"{linh.Calculate()}"); 
        linh.Show(linh.Calculate());
        
    }

    public abstract class Personnel
    {
        public string Name;
        public string Addree;
        public int Prince;

        public Personnel(string Name, string Addree, int Prince) 

        {
            this.Name = Name;
            this.Addree = Addree;
            this.Prince = Prince;
        }

        public abstract int Calculate();
        public abstract void Show(int Income);

    }

    public class Saler : Personnel
    {
        public int Product;
        public Saler(int Product, string Name, string Addree, int Prince) : base(Name, Addree, Prince) 
        {
            this.Product = Product;
        }

        public override int Calculate()
        {

            Console.WriteLine($"{Product}, {Prince}");

            int Income;      

            Income = Prince * Product;
            
            return Income;
        }

        public override void Show(int Income)
        {
            Console.WriteLine($"{Name},{Addree},{Income}");
        }
    }

}