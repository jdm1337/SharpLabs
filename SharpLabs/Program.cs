using SharpLabs.Lb2;

public class Program
{
    public static void Main(string[] args)
    {
        // LB 1
        // #1
        int p = 5;
        double x = 2 * p;
        float y = (float)x - 2;

        decimal z = (decimal)(y + x - p);

        Console.WriteLine($"p={p}, x={x}, y={y}, z={z}");

        // #2
        int[] a = new int[100];

        for (int i = 0; i < a.Length; i++)
        {
            Random r = new Random();
            a[i] = r.Next(100);

        }
        Console.WriteLine("Output of elements less than 50 and at the same time even: ");
        a.Where(x => x < 50 && x % 2 == 0).ToList().ForEach(x => Console.Write(x + " "));

        int[,] b = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Random r = new Random();
                b[i, j] = r.Next(100);
                
            }
        }

        int k = 0;
        int t = 0;
        int mainDiagonal = 0;

        while (k < 10)
        {
            while (t < 10)
            {
                if (k == t)
                {
                    mainDiagonal += b[k, t];
                }
                t++;
            }
            k++;
            
        }

        Console.WriteLine($"Main diagonal = {mainDiagonal}");

        int c = 0;
        do
        {
            if (a[c] % 2 == 0 && a[c] % 10 == DateTime.UtcNow.Day)
            {
                a[c] = 100 - a[c];
                Console.Write(a[c] + " ");
            }
            c++;
        }
        while (c < a.Length);

        // #3
        Sum(1, 2);
        OutSum(1, 2, out int sum);
        int sum1 = 0;
        RefSum(ref sum1, 1, 2);
        Console.WriteLine();
        //------------------

        // LB 2
        var client = new Client("Pokupat", "Pokupaev", 300);
        client.PrintInfo();
        client.Buy("Diploma");

        var employer = new Employer("Prodavat", "Prodavaed", "Manager", 45000, 34, 19);
        employer.PrintInfo();
        employer.EditSalary(5000);
        employer.Promote();
        employer.Fire();

        var engineer = new Engineer("Durachek", "Durachkov", 3, "software developer");
        engineer.PrintInfo();
        engineer.JustEngineerIt();

        // LB 3

        var anotherClient = (Client)client.Clone();
        Console.WriteLine("------");
        anotherClient.PrintInfo();
        Console.WriteLine("------");
        var engineer1 = new Engineer("A", "Anov", 5, "Fireman");
        var engineer2 = new Engineer("B", "Banov", 5, "Chiller");
        var engineer3 = new Engineer("C", "Cianov", 5, "Sales-manager");

        var listOfEngineers = new List<Engineer>() { engineer1, engineer3, engineer2 };
        listOfEngineers.Sort();
        listOfEngineers.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName + " " + x.Orientation));

        Console.WriteLine("------");

        var weightableEmployer = new Employer("Alexey", "Alexseev", "Soldier", 45000, 23.5f, 18);

        Console.WriteLine("Weight: " + weightableEmployer.DefineWeight());

        Console.WriteLine("Age: " + weightableEmployer.DefineAge());
        
    }
    public static int Sum(int a, int b)
    {
        return a + b;
    }
    public static void OutSum(int a, int b, out int sum)
    {
        sum = a + b;
    }
    public static void RefSum(ref int sum, int a, int b)
    {
        sum = a + b;
    }
}




