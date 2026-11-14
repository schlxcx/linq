List<Person> people = new List<Person>
{
    // 25 Studierende (Semester 1–6 sinnvoll verteilt) new Student("Lena", "Müller-Meier", Gender.Female, 2002, 1, "Informatik"),
    new Student("Noah", "Schneider",Gender.Male, 2001, 1, "Informatik"),
    new Student("Mia","Keller", Gender.Female, 2003, 2, "Medien"),
    new Student("Luca", "Weber",Gender.Male, 2002, 2, "Informatik"),
    new Student("Emma", "Huber",Gender.Female, 2001, 3, "Wirtschaft"),
    new Student("Finn", "Meier",Gender.Male, 2000, 3, "Informatik"),
    new Student("Laura","Fischer",Gender.Female, 2002, 4, "Wirtschaft"),
    new Student("Elias","Brunner",Gender.Male, 2001, 4, "Medien"),
    new Student("Sofia","Bachmann", Gender.Female, 2003, 5, "Informatik"),
    new Student("Leon", "Steiner",Gender.Male, 2000, 5, "Wirtschaft"),
    new Student("Nina", "Schmid", Gender.Female, 2002, 6, "Medien"),
    new Student("Jan","Arnold", Gender.Male, 2001, 6, "Informatik"),
    new Student("Sara", "Graf", Gender.Female, 2002, 1, "Wirtschaft"),
    new Student("Tim","Hofmann",Gender.Male, 2003, 2, "Informatik"),
    new Student("Alina","Suter",Gender.Female, 2001, 3, "Medien"),
    new Student("Jonas","Zimmermann", Gender.Male, 2000, 4, "Wirtschaft"),
    new Student("Pia","Koch", Gender.Female, 2002, 5, "Informatik"),
    new Student("David","Seiler", Gender.Male, 2001, 6, "Medien"), 

    // Doppelnamen (mindestens 3) new Student("Lea","Frei-Senn",Gender.Female, 2003, 2, "Informatik"),
    new Student("Marco","Rossi-Bianchi",Gender.Male, 2000, 4, "Wirtschaft"),
    new Student("Jasmin", "Kunz-Widmer",Gender.Female, 2002, 5, "Medien"), 

    // restliche Studierende new Student("Kevin","Lang", Gender.Male, 2001, 3, "Informatik"),
    new Student("Melina", "Egger",Gender.Female, 2002, 1, "Wirtschaft"),
    new Student("Ramon","Gisler", Gender.Male, 2003, 2, "Medien"), 

    // 5 Lehrpersonen (mindestens 2 mit sehr hohem Gehalt) new Teacher("Claudia", "Kaufmann", Gender.Female, 1980, "Mathematik",9800m),
    new Teacher("Peter", "Baumann",Gender.Male, 1975, "Informatik", 10200m),
    new Teacher("Monika","Wenger", Gender.Female, 1985, "Deutsch", 7200m),
    new Teacher("Thomas","Lehmann",Gender.Male, 1978, "Englisch", 7600m),
    new Teacher("Nadja", "Moser", Gender.Female, 1982, "Wirtschaft",6900m)
};


System.Console.WriteLine("a)");
foreach (Person person in people.Where(person => person.Gender == Gender.Female))
    System.Console.WriteLine(person.Firstname + ", " + person.Lastname);
System.Console.WriteLine();

System.Console.WriteLine("b)");
foreach (Teacher person in people.OfType<Teacher>())
    System.Console.WriteLine(person.Firstname + ", " + person.Lastname + ", " + person.Gender + ", " + person.Birthyear + ", " + person.Age);
System.Console.WriteLine();

System.Console.WriteLine("c)");
foreach (Teacher person in people.OfType<Teacher>())
    System.Console.WriteLine(person.Lastname);
System.Console.WriteLine();

System.Console.WriteLine("d)");
foreach (Student person in people.OfType<Student>().Where(student => student.Semester == 1))
    System.Console.WriteLine(person.Firstname + ", " + person.Lastname + ", " + person.Gender + ", " + person.Birthyear + ", " + person.Age);
System.Console.WriteLine();

System.Console.WriteLine("e)");
foreach (Person person in people.OrderBy(person => person.Firstname))
    System.Console.WriteLine(person.Firstname + person.Lastname);
System.Console.WriteLine();

System.Console.WriteLine("f)");
foreach (Person person in people.Where(person => person.Lastname.Contains("-")))
    System.Console.WriteLine(person.Firstname + ", " + person.Lastname);
System.Console.WriteLine();

System.Console.WriteLine("g)");
IEnumerable<string> fullNames = people.Select(person => person.Firstname + " " + person.Lastname);
foreach (string name in fullNames)
    System.Console.WriteLine(name);
System.Console.WriteLine();

System.Console.WriteLine("h)");
foreach (Person person in people.Where(person => person.Firstname.Length > 6))
    System.Console.WriteLine(person.Firstname + ", " + person.Lastname);
System.Console.WriteLine();

System.Console.WriteLine("i)");
foreach (Teacher person in people.OfType<Teacher>().Where(teacher => teacher.MonthlyWage > 7000m))
    System.Console.WriteLine(person.Firstname + ", " + person.Lastname + ", " + person.MonthlyWage);
System.Console.WriteLine();

System.Console.WriteLine("j)");
foreach (Student person in people.OfType<Student>().Where(student => student.Semester > 3))
    System.Console.WriteLine(person.Firstname + ", " + person.Lastname + ", " + person.Semester);
System.Console.WriteLine();

System.Console.WriteLine("k)");
foreach (Teacher teacher in people.OfType<Teacher>().OrderByDescending(teacher => teacher.MonthlyWage))
    System.Console.WriteLine(teacher.Firstname + ", " + teacher.Lastname + ", " + teacher.MonthlyWage);
System.Console.WriteLine();

System.Console.WriteLine("l)");
foreach (Student student in people.OfType<Student>().Where(student => student.StudyField == "Informatik"))
    System.Console.WriteLine(student.Firstname + ", " + student.Lastname + ", " + student.StudyField);
System.Console.WriteLine();

System.Console.WriteLine("m)");
System.Console.WriteLine("Anzahl der Lehrpersonen: " + people.OfType<Teacher>().Count());
System.Console.WriteLine("Anzahl der Studierenden: " + people.OfType<Student>().Count());
System.Console.WriteLine();

System.Console.WriteLine("n)");
System.Console.WriteLine("Verdient eine Lehrperson mehr als 9000 CHF? " + people.OfType<Teacher>().Any(teacher => teacher.MonthlyWage > 9000m));
System.Console.WriteLine();

System.Console.WriteLine("o)");
System.Console.WriteLine("Durchschnittssemesester der Studierenden: " + people.OfType<Student>().Average(student => student.Semester));

System.Console.WriteLine("p)");
// System.Console.WriteLine(people.Max(person => person.Birthyear)); // in einer foreach ist besser, da zwei Personen das gleiche Geburtsjahr haben könnten, dann wird nur eine Person angezeigt, die andere nicht
var maxBirthyear = people.Max(person => person.Birthyear);
var youngestPeople = people.Where(person => person.Birthyear == maxBirthyear); // keine LINQ in anderen LINQ-Methoden, da sonst ist es inperformant, da die Liste immer wieder durchlaufen wird
foreach (Person person in youngestPeople)
    System.Console.WriteLine(person.Firstname + ", " + person.Lastname + ", " + person.Birthyear);
System.Console.WriteLine();

System.Console.WriteLine("q)");
foreach (Teacher person in people.OfType<Teacher>().OrderByDescending(teacher => teacher.MonthlyWage).Take(3))
    System.Console.WriteLine(person.Firstname + ", " + person.Lastname + ", " + person.MonthlyWage);
System.Console.WriteLine();

System.Console.WriteLine("r)");
// HashSet<string> uniqueStudyFields = new HashSet<string>(people.OfType<Student>().Select(student => student.StudyField)); // Distinct ist LINQ, HashSet ist eine Datenstruktur, die nur eindeutige Werte speichert
foreach (string studyField in people.OfType<Student>().Select(student => student.StudyField).Distinct())
    System.Console.WriteLine(studyField);
System.Console.WriteLine();

System.Console.WriteLine("s)");
foreach (var item in people.OfType<Student>().Select(student => student.StudyField).Distinct().Select(studyField => new { StudyField = studyField, Count = people.OfType<Student>().Count(student => student.StudyField == studyField) }))
    System.Console.WriteLine(item.StudyField + ": " + item.Count);
System.Console.WriteLine();

System.Console.WriteLine("t)");
foreach (Teacher teacher in people.OfType<Teacher>().Where(teacher => teacher.MonthlyWage > 7000m))
    System.Console.WriteLine(teacher.Firstname + ", " + teacher.Lastname + ", " + teacher.MonthlyWage);
System.Console.WriteLine();

System.Console.WriteLine("u)");
System.Console.WriteLine(people.OfType<Teacher>().Max(teacher => teacher.MonthlyWage));
System.Console.WriteLine();

System.Console.WriteLine("v)");
foreach (var item in people.OfType<Student>().Select(student => student.StudyField).Distinct().Select(studyField => new { StudyField = studyField, Count = people.OfType<Student>().Count(student => student.StudyField == studyField) }))
    System.Console.WriteLine(item.StudyField + ": " + item.Count);
System.Console.WriteLine();