using szalloda;

if (File.Exists("szobak.txt")) 
{
    foreach (string aktsor in File.ReadAllLines("szobak.txt")) 
    {
        
    }
}
else 
{
    Console.WriteLine("A szobak.txt fájl nem található.");
}
