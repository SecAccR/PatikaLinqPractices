using System.ComponentModel.DataAnnotations.Schema;

namespace LinqPractices.Entities;

public class Student
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int ClassId { get; set; }

    public Student(string name, string surname, int classId)
    {
        Name = name;
        Surname = surname;
        ClassId = classId;
    }
}