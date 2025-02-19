namespace MauiAppEF.Data;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }

    public List<Grades> Grades { get; } = new();
}
