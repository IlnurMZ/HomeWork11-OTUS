namespace HomeWork11_OTUS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OtusDictionary otusDictionary = new OtusDictionary();
            
            otusDictionary.Add(2, "Два");
            otusDictionary.Add(4, "Четыре");            
            otusDictionary.Add(34, "Пять");            

            Console.WriteLine(otusDictionary[2]); 
        }
    }
}