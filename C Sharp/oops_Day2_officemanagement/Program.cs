using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Employee john = new Employee { Name = "John", Id = 1 };
        Employee jane = new Employee { Name = "Jane", Id = 2 };
        Manager bob = new Manager { Name = "Bob", Id = 3 };
        Department sales = new Department { Name = "Sales", Id = 4, Manager = bob };
        Task saleTask = new Task { Name = "Sale", Id = 5, Description = "Sell product", Status = "To Do" };

        bob.AssignTask(saleTask, john);
        sales.AddEmployee(john);
        sales.AddEmployee(jane);
        saleTask.ChangeStatus("In Progress");
        jane.AssignTask(saleTask);
    }
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Department Department { get; set; }
        public List<Task> Tasks { get; set; }

        public void AssignTask(Task task)
        {
            Tasks.Add(task);
        }
    }

    class Manager : Employee
    {
        public List<Employee> Subordinates { get; set; }

        public void AssignTask(Task task, Employee employee)
        {
            employee.AssignTask(task);
        }

        public void AssignDepartment(Department department, Employee employee)
        {
            employee.Department = department;
        }
    }

    class Department
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public Manager Manager { get; set; }
        public List<Employee> Employees { get; set; }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }
    }

    class Task
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public Employee AssignedTo { get; set; }

        public void ChangeStatus(string status)
        {
            Status = status;
        }
    }



}


