Console.WriteLine("Введите число А: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = int.Parse(Console.ReadLine());

double AB(int aLoc, int bLoc){

    double rez = Math.Pow((aLoc), bLoc);
    return rez;

}

Console.WriteLine(AB(A,B));