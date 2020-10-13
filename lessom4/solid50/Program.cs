using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solid50
{

    //The syntax for declaring a delegate
    //define a delegate by codeing the public and delegate
    //keyword ...
    //public delegate returnType DelegateName(parameterlist);
    //example
    //דלגט חדש
    public delegate void ChangeHandler(ProductList products);

    //המחלקה מוצר
    public class Product
    {
        public string _code;
        public string _desc;
        public decimal _price;
        public Product(string code, string desc, decimal price)
        {
            _code = code;
            _desc = desc;
            _price = price;
        }
        public override string ToString()
        {
            return _code + " " + _desc + " " + _price + " ";
        }
    }

    //ProductList class
    public class ProductList
    {
        public List<Product> products;
        public ProductList()
        {
            products = new List<Product>();

        }
        public int Count
        {
            get { return products.Count; }
        }
        public void Add(Product prod)
        {
            products.Add(prod);

        }
        public void Add(string c, string d, decimal p)
        {
            Product p1 = new Product(c, d, p);
            products.Add(p1);
        }
        //הגדרת אינדקסר - אין ברירה
        public Product this[int index]

        {
            get
            {
                return products[index];
            }
            set
            {
                products[index] = value;
            }
        }


        // מתודה עם אותו חותמת כמו הדלגט
        // A method with the same signature as the delegate.
        public static void PrintToConsole(ProductList products)
        {
            Console.WriteLine("The product list has changed!");

            for (int i = 0; i < products.Count; i++)
            {
                Product p = products[i];
                Console.WriteLine(p.ToString());
            }

        }
        // מתודה נוספת עם אותה חותמת
        public static void printCount(ProductList products)
        {
            Console.WriteLine("The amount of products in list is: {0}", products.Count);
        }





        static void Main(string[] args)
        {
            ProductList prods = new ProductList();
            prods.Add("jse6", "A new Book", 100m);
            prods.Add("Chachamim", "Another Book", 200m);

            //   מצהירה על אוביקט מטיפוס הדלגט
            //create the delegate and identify its method:
            ChangeHandler myDelegate;
            // מאתחלת אותו עם פונקציה המתאימה לטיפוס הדלגט
            myDelegate = new ChangeHandler(ProductList.PrintToConsole);

            //הפעלה של כל המתודות הרשומות לדלגט
            myDelegate(prods);
            Console.WriteLine("after first calling");
            myDelegate += printCount;
            myDelegate.Invoke(prods);
        }

    }
}
