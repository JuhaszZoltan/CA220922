Random rnd = new();
/*
ConsoleColor szin = (ConsoleColor)rnd.Next(1, 16);

Console.Write("írd be a neved: ");
string nev = Console.ReadLine();

Console.Write("Szia ");
Console.ForegroundColor = szin;
Console.Write(nev);
Console.ResetColor();
Console.Write("!\nHogy vagy?");
*/

Console.SetWindowSize(90, 19);

Console.Write("írd be a neved: ");
string nev = Console.ReadLine();
Console.Clear();

Console.SetCursorPosition(
    left: Console.WindowWidth / 2 - nev.Length / 2,
    top: Console.WindowHeight / 2);

for (int i = 0; i < nev.Length; i++)
{
    Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
    Thread.Sleep(200);
    Console.Write(nev[i]);
}

Console.Write("\n");
Console.ReadKey(true);