namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "Doğukan");
            myDictionary.Add(2, "Berivan");
            myDictionary.Add(3, "Gülüzar");
            myDictionary.Add(4, "Esra");
            myDictionary.Add(5, "Armağan");

            myDictionary.T1s();

            myDictionary.T2s();

            Console.WriteLine(myDictionary.Count);
        }
    }
}