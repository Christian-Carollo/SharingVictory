using SharingVictory;

internal class Program
{
    private static void Main(string[] args)
    {

        /**
         * Se andiamo a inserire in una Lista un altro Studente con nome differente ma con stesso valore voto 
         * l'applicazione mi darà come risultato solo lo studente che viene per ultimo in lista con quel valore.
         */
        List<Studente> studenti = new List<Studente>()
        {
            new Studente("Marco", 10),
            new Studente("Lorenzo", 10),
            new Studente("Alessio", 3),
            new Studente("Alessia", 7),
            new Studente("Marta", 6),
            new Studente("Stefano", 4),
            new Studente("Francesca", 5),
            new Studente("Mirco", 9),
            new Studente("Emanuela", 8),
            new Studente("Paolo", 6),
            new Studente("Pamela", 2)
    };


        //---------------------------------------------------------------------------------------------

        double media = studenti.Average(studente => studente.voto);

        Console.WriteLine($"Media Voti: {media}\n");

        //---------------------------------------------------------------------------------------------

        List<Studente> topTwoStudents = studenti.OrderByDescending(studente => studente.voto).
            ThenBy(studente => studente.nome).Take(2).ToList();

        string risultato = string.Join(", ", topTwoStudents.Select(studente => studente.ToString()));

        
        Console.WriteLine($"Gli studenti con il voto più alto sono: {risultato}\n");
        


    }
}