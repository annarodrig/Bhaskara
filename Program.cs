double a,b,c,delta,X1,X2 ;

Console.WriteLine("-- Equação do segundo grau --");

Console.Write("(a):");
a = Convert.ToDouble (Console.ReadLine());

Console.Write("(b):");
b = Convert.ToDouble (Console.ReadLine());

Console.Write("(c):");
c = Convert.ToDouble (Console.ReadLine());

if (a == 0)
{
    Console.WriteLine("\nNão é uma equação de segundo grau!");
}

else 
{
    delta = Math.Pow (b,2) - (4*a*c);
      if (delta < 0)
    {
    Console.WriteLine($"\nComo delta = {delta:N2}, a equação não possui raízes reais!");
    }
       else 
        {
            X1 = (- b + (Math.Sqrt(delta))) / (2 * a);
            X2 = (- b - (Math.Sqrt(delta))) / (2 * a);

            Console.WriteLine($"\nx1 = {X1:N2} e xa = {X2:N2}");
        }
}        

