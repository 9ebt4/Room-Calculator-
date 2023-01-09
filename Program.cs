using System.Transactions;

Console.WriteLine("Welcome to Grand Circus' Room Calculator!");
Console.WriteLine();

Console.WriteLine("Enter room Length:");
double L = double.Parse(Console.ReadLine());
Console.WriteLine("Enter room Width:");
double W = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Room Height:");
double H = double.Parse(Console.ReadLine());
double A = L * W;
double P = 2 * W + 2 * L;
double V = L* W* H;
double SF = 2 * (W * L + H * L + H * W);

Console.WriteLine("Lenght: " + L);
Console.WriteLine("Height: " + H);
Console.WriteLine("Area: " + A);
Console.WriteLine("Perimeter: " + P);
Console.WriteLine("Volume: " + V);
Console.WriteLine("Surface Area: " + SF);

if (A <= 250) {
    Console.WriteLine("The room is small.");
}else if (A > 250 && A < 650) {
    Console.WriteLine("The room is medium.");
}else{
    Console.WriteLine("The room is large.");
};

Console.WriteLine("Thank you for using Room Calculator");