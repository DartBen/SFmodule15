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


        var newGroupCollection = departments.GroupJoin(
                                            employees,
                                            d => d.Id,
                                            e => e.DepartmentId,
                                            (d, emp) => new
                                            {
                                                Name = emp.Select(x => x.Name),
                                                Department = d.Name
                                            }
                                            );


        foreach (var dep in newGroupCollection)
        {
            Console.WriteLine(dep.Department + ":");

            // Выводим сотрудников
            foreach (string emp in dep.Name)
                Console.WriteLine(emp);

            Console.WriteLine();
        }

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
