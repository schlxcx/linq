public class Teacher : Person
{
    public string SchoolSubject { get; set; }
    public decimal MonthlyWage { get; private set; }

    public Teacher(string firstname, string lastname, Gender gender, int birthyear, string schoolSubject, decimal monthlyWage) : base(firstname, lastname, gender, birthyear)
    {
        SchoolSubject = schoolSubject;
        MonthlyWage = monthlyWage;
    }
}