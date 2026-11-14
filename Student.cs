public class Student : Person
{
    public int Semester { get; private set; }
    public string StudyField { get; set; }

    public Student(string firstname, string lastname, Gender gender, int birthyear, int semester, string studyField) : base(firstname, lastname, gender, birthyear)
    {
        Semester = semester;
        StudyField = studyField;
    }
}