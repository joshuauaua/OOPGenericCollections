namespace OOP_Generic_Collections;

class Program
{
    static void Main(string[] args)
    {
        //Create 5 instances of employee class
        Employee employee1 = new Employee("1001", "James", "Male", 35000);
        Employee employee2 = new Employee("1002", "Cajsa", "Female", 42000);
        Employee employee3 = new Employee("1003", "Filip", "Male", 68000);
        Employee employee4 = new Employee("1004", "Cornelia", "Female", 33000);
        Employee employee5 = new Employee("1005", "Martha", "Female", 22000);

        //Create stack of employees, use Push to add all employees to stack
        Stack<Employee> stack = new Stack<Employee>();

        stack.Push(employee1);
        stack.Push(employee2);
        stack.Push(employee3);
        stack.Push(employee4);
        stack.Push(employee5);
        
        //Display each object in stack
        foreach (Employee employee in stack)
        {
            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Gender);
            Console.WriteLine(employee.Salary);
            Console.WriteLine(stack.Count());
        }
        
        //Use Pop to pop out all objects from stack, displaying how many left afterwards
        while (stack.Count() > 0)
        {
            stack.Pop();
            Console.WriteLine(stack.Count());
        }
        
        //Push all elements back into stack using Push
        stack.Push(employee1);
        stack.Push(employee2);
        stack.Push(employee3);
        stack.Push(employee4);
        stack.Push(employee5);
        
        //Use peek to peek twice, counting stack size after
        stack.Peek();
        Console.WriteLine(stack.Count());
        stack.Peek();
        Console.WriteLine(stack.Count());

        //Check if stack contains element 3
        Console.WriteLine(stack.Contains(employee3));
        
        //Create a list for the five employees
        List<Employee> employeeList = new List<Employee>(5);

        //Add 5 employee objects to list
        employeeList.Add(employee1);
        employeeList.Add(employee2);
        employeeList.Add(employee3);
        employeeList.Add(employee4);
        employeeList.Add(employee5);

        //Use .Contains to find if employee2 exists in list
        if (employeeList.Contains(employee2))
        {
            Console.WriteLine("Employee2 object exists in the list");
        }
        else
        {
            Console.WriteLine("Employee2 object does not exist in the list");
        }

        //Use find to find first match of Gender = "Male"
        Employee firstMale = employeeList.Find(employee => employee.Gender == "Male");

        if (firstMale != null)
        {
            Console.WriteLine($"Found: {firstMale.Name}, Gender: {firstMale.Gender}");
        }
        else
        {
            Console.WriteLine("No match found.");
        }
        
        
        //Use FindAll() to find all matches of Gender = Male

        List<Employee> allMales = employeeList.FindAll(employee => employee.Gender == "Male");

        foreach (var male in allMales)
        {
            if (allMales != null)
            {
                Console.WriteLine(male.Name);
            }
            else
            {
                Console.WriteLine("No males in this list");
            }
        }
        
        








    }
}