namespace HomeWork11_OTUS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtusDictionary otusDictionary = new OtusDictionary();
            
            otusDictionary.Add(100, "Сто");
            otusDictionary.Add(4, "Четыре");            
            otusDictionary.Add(34, "Тридцать четыре");
            otusDictionary.Add(2, "Два");
            
            Console.WriteLine(otusDictionary[2]); 
        }
    }
}