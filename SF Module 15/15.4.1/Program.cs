internal class Program
{
    private static void Main(string[] args)
    {
        var departments = new List<Department>()
        {
           new Department() {Id = 1, Name = "Программирование"},
           new Department() {Id = 2, Name = "Продажи"}
        };

        var employees = new List<Employee>()
        {
           new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
           new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
           new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
           new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
        };

        var newCollection = from employee in employees
                            join department in departments on employee.DepartmentId equals department.Id
                            select new
                            {
                                Name = employee.Name,
                                Id = employee.Id,
                                Department = department.Name
                            };

        foreach (var employee in newCollection)
            Console.WriteLine("Имя: " + employee.Name + " ID: " + employee.Id + " Департамент: " + employee.Department);
    }

    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }

}