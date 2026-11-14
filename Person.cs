public class Person
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public Gender Gender { get; set; }
    public int Birthyear { get; set; }
    public int Age => DateTime.Today.Year - Birthyear;

    public Person(string firstname, string lastname, Gender gender, int birthyear)
    {
        Firstname = firstname;
        Lastname = lastname;
        Gender = gender;
        Birthyear = birthyear;
    }
}