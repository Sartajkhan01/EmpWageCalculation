using EmpWageProblem;
Console.WriteLine("Welcome To The Employee Wage Calculation Program");
EmployeeWageComputation employeeComputation = new EmployeeWageComputation(2);
employeeComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
employeeComputation.CalculateEmpWage("TATA");

employeeComputation.AddCompany("MAHINDRA", 30, 8, 4, 100, 20);
employeeComputation.CalculateEmpWage("MAHINDRA");

employeeComputation.displayArray();