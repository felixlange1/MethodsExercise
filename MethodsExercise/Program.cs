namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Plus(2, 5));
            StoryMethod();
            
        }

        public static void StoryMethod()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Great, thank you. What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Now tell me a location.");
            string location = Console.ReadLine();
            Console.WriteLine("Now enter a profession.");
            string profession = Console.ReadLine();
            Console.WriteLine("Please tell me an adjective.");
            string adjective = Console.ReadLine();
            Console.WriteLine("Great. Lastly, tell me a mysterious object.");
            string mystObject = Console.ReadLine();

            Console.WriteLine(
                $"One sunny morning, {name}, a {profession}, decided to take a break from their usual work and visit {location}. While wandering around, they encountered a {adjective} {animal} holding a {mystObject}. Surprised and intrigued, {name} followed the creature, only to discover it leading them to a hidden treasure buried in the heart of the {location}. That day, {name}'s life changed forever, thanks to the curious {animal} and its mysterious {mystObject}."
                );
            
            
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }
        
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
