using OOPPrinciples;

class Program
{
    static void Main(string[] args)
    {
        // Examples
        {
            AfricanLion africanLion = new AfricanLion(true, 80);
            bool male = africanLion.Male;
            male = true;
            // Implicit casting
            object obj = africanLion;

            try
            {
                // Explicit casting
                AfricanLion castedLion = (AfricanLion)obj;
            }
            catch (InvalidCastException ice)
            {
                Console.WriteLine("obj cannot be downcasted to AfricanLion");
            }

            // Object.ToString() 
            Console.WriteLine(new object());
            //Console.WriteLine(new Felidae(true));
            Console.WriteLine(new Lion(true, 80));
            Console.WriteLine(new AfricanLion(true, 80));

            // Override vs new
            string asAfricanLion = africanLion.ToString();
            string asObject = ((object)africanLion).ToString();
            Console.WriteLine(asAfricanLion);
            Console.WriteLine(asObject);

            // Abstraction Example
            Lion lion = new Lion(true, 150);
            Felidae bigCat1 = lion;
            AfricanLion africanLion2 = new AfricanLion(true, 80);
            Felidae bigCat2 = africanLion2;

            // Polymorphism
            Animal cat = new Cat();
            cat.PrintInformation();

            // Overriding
            Lion lion2 = new Lion(true, 80);
            lion2.CatchPrey(null);
            // Will print "Lion.CatchPrey"
            AfricanLion lion3 = new AfricanLion(true, 120);
            lion3.CatchPrey(null);
            // Will print "AfricanLion.CatchPrey"
            Lion lion4 = new AfricanLion(false, 60);
            lion4.CatchPrey(null);
            // Will print "AfricanLion.CatchPrey", because
            // the variable lion has a value of type AfricanLion
        }

        // Exercise
        ExerciseStatic.TextExercise();
    }

}