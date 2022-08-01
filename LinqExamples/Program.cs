

using LinqExamples;

List<Employee> EmployeeList = new List<Employee>() {
 new Employee() { ID = 1, DepartmentID = 1, Name = "Viky" , Salary = 200},
 new Employee() { ID = 2, DepartmentID = 2, Name = "Alexandra" , Salary = 500},
 new Employee() { ID = 3, DepartmentID = 1, Name = "Ashkan" , Salary = 750},
 new Employee() { ID = 4, DepartmentID = 3, Name = "Vivian" , Salary = 150},
 new Employee() { ID = 5, DepartmentID = 1, Name = "Cristian" , Salary = 100},
 new Employee() { ID = 6, DepartmentID = 3, Name = "Dan" , Salary = 700},
 };
Console.WriteLine("Emplyees with V in their name");
var q1 = from e in EmployeeList where e.Name.Contains("V") select e;
foreach(var e in q1)
{
    Console.WriteLine(e.Name);
}
Console.WriteLine("Employees grouped by departments");
var q2 = from e in EmployeeList
         group e by e.DepartmentID into dep
                  orderby dep.Key ascending
                  select dep;

foreach (var i in q2)
{
    Console.WriteLine("Department id " + i.Key);
    foreach (var employee in i)
    {
        Console.WriteLine(employee.Name);
    }
}
Console.WriteLine("Total Salary for each department");
var q3 = EmployeeList
    .GroupBy(x => x.DepartmentID)
    .Select(g => new {
        DepartmentID = g.Key,
        Total = g.Sum(x => x.Salary)
    });
foreach (var e in q3)
{
    Console.WriteLine(e.DepartmentID + " "+ e.Total);
}