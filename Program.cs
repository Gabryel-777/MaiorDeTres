int N1, N2, N3;

Console.Clear();



Console.WriteLine("---- MAIOR DE TRÊS----");

Console.WriteLine("Olá usuÁrio, seja bem vindo ao programa que recebe três números de vc e escolhe somente o maior entre os três.");

Console.Write("Agora digite um n° INTEIRO: ");

N1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Agora digite outro n° INTEIRO: ");

N3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Agora digite outro n° INTEIRO: ");

N2 = Convert.ToInt32(Console.ReadLine());

if (N1 > N2 && N1 > N3)
{
    Console.WriteLine($"o maior numero entre esses é: {N1}");


}

else if (N2 > N1 && N2 > N3)
{
    Console.WriteLine($"o maior numero entre esses é: {N2}");


}
else if (N3 > N1 && N3 > N2)
{
    Console.WriteLine($"o maior numero entre esses é: {N3}");


}