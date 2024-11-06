namespace OOP_Generic_Collections;

public class Employee
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Gender { get; set; }
    public int Salary { get; set; }

    public Employee(string id, string name, string gender, int salary)
    {
        this.Id = id;
        this.Name = name;
        this.Gender = gender;
        this.Salary = salary;
    }
    
    
}