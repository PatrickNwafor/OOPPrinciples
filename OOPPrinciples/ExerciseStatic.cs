using OOPPrinciples.Exercise_5;
using OOPPrinciples.Exercise2;
using OOPPrinciples.Exercise6;
using OOPPrinciples.Exercise8;

internal static class ExerciseStatic
{
    public static void TextExercise()
    {
        // Exercise
        // Exercise 3
        Student[] students = new Student[10];
        students[0] = new Student("Tolu", "Agba", 55);
        students[1] = new Student("Emma", "Tukwa", 66);
        students[2] = new Student("Gambaru", "Jones", 24);
        students[3] = new Student("Philip", "Somto", 82);
        students[4] = new Student("Agu", "Chemba", 90);
        students[5] = new Student("Jindu", "Gobia", 43);
        students[6] = new Student("Eke", "Oil", 36);
        students[7] = new Student("Ike", "Baba", 20);
        students[8] = new Student("Amusu", "Squeeze", 3);
        students[9] = new Student("Jos", "Kadi", 44);

        Array.Sort(students);

        foreach (Student student in students)
        {
            Console.WriteLine(student);
        }
        Console.WriteLine();

        // Exercise 4
        Worker[] workers = new Worker[10];
        workers[0] = new Worker("Tolu", "Agba", 55, 20);
        workers[1] = new Worker("Emma", "Tukwa", 66, 70);
        workers[2] = new Worker("Gambaru", "Jones", 24, 59);
        workers[3] = new Worker("Philip", "Somto", 82, 100);
        workers[4] = new Worker("Agu", "Chemba", 90, 15);
        workers[5] = new Worker("Jindu", "Gobia", 43, 102);
        workers[6] = new Worker("Eke", "Oil", 36, 30);
        workers[7] = new Worker("Ike", "Baba", 20, 2);
        workers[8] = new Worker("Amusu", "Squeeze", 3, 5);
        workers[9] = new Worker("Jos", "Kadi", 44, 22);

        Array.Sort(workers);

        foreach (Worker worker in workers.Reverse())
        {
            Console.WriteLine(worker);
        }
        Console.WriteLine();


        // Exercise 5
        Shape[] shapes = new Shape[5];
        shapes[0] = new Triangle(4, 5);
        shapes[1] = new Rectangle(8, 3);
        shapes[2] = new Rectangle(9, 7);
        shapes[3] = new Circle(7);
        shapes[4] = new Triangle(2, 3);

        double[] shapesArea = new double[5];

        for (int i = 0; i < shapes.Length; i++)
        {
            double area = shapes[i].CalculateSurface();
            shapesArea[i] = area;
            Console.WriteLine(area);
        }

        // Exercise 6
        Animal[] animal = new Animal[10];
        animal[0] = new Frog("Jame", 2, Gender.Male);
        animal[1] = new Cat("Jame", 7, Gender.Female);
        animal[2] = new Dog("Jame", 1, Gender.Male);
        animal[3] = new Tomcat("Jame", 3, Gender.Male);
        animal[4] = new Frog("Jame", 1, Gender.Female);
        animal[5] = new Kitten("Jame", 4, Gender.Female);
        animal[6] = new Cat("Jame", 9, Gender.Male);
        animal[7] = new Kitten("Jame", 2, Gender.Female);
        animal[8] = new Dog("Jame", 12, Gender.Male);
        animal[9] = new Dog("Jame", 9, Gender.Male);

        foreach(Animal anim in animal)
        {
            Console.WriteLine("{0} Name: {1}, Age: {2}, Gender: {3}, Sound: {4}"
                , anim.GetType().Name, anim.Name, anim.Age, anim.Gender, anim.MakeSound());
        }
        Console.WriteLine();

        // Exercise 8
        Bank bank = new Bank();
        DepositAccount depositAccount = new DepositAccount(Customer.Individual, 3400m, 3.5);
        Console.WriteLine("Interest rate after {0} month is: {1}", 3, depositAccount.CalculateInterest(3));
        IAccount loanAccount = new LoanAccount(Customer.Company, 65000m, 2.2);
        Console.WriteLine("Interest rate after {0} month is: {1}", 7, loanAccount.CalculateInterest(7));
        IAccount mortgageAccount = new MortgageAccount(Customer.Individual, 3900m, 1.4);
        Console.WriteLine("Interest rate after {0} month is: {1}", 8, mortgageAccount.CalculateInterest(6));

        bank.CreateAccount(depositAccount);
        bank.CreateAccount(loanAccount);
        bank.CreateAccount(mortgageAccount);
    }
}
