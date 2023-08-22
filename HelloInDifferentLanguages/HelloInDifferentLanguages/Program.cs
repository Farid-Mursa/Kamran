namespace HelloInDifferentLanguages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RussianPerson russianPerson = new RussianPerson();
            russianPerson.Speak();
            FrenchPerson frenchPerson = new FrenchPerson();
            frenchPerson.Speak();
            SpanishPerson spanishPerson = new SpanishPerson();
            spanishPerson.Speak();
        }
    }
}