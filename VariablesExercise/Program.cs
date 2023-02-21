namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Patient Information:");
            Console.WriteLine($"Name: {myName}  |  Age: {myAge}  |  Gender: {myGender}");
            Console.WriteLine($"Citzen Status: {isCitzen}  |  HeartBeats/Min: {beatsPerMinute}  |  HeartBeats/Sec : {beatsPerSecond}");
        }
        static string myName = "Jiger";

        static int myAge = 20;

        static char myGender = 'M';

        static bool isCitzen = true;

        static double beatsPerMinute = 52.4;

        static decimal beatsPerSecond = .8m;
    }
}
