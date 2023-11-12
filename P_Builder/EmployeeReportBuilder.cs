namespace P_Builder;

public class EmployeeReportBuilder : IEmployeeReportBuilder
{
    private EmployeeReport _employeeReport;
    private readonly IEnumerable<Employee> _employees;

    public EmployeeReportBuilder(IEnumerable<Employee> employees)
    {
        _employees = employees;
        _employeeReport = new EmployeeReport();
    }

    public IEmployeeReportBuilder BuildHeader()
    {
        _employeeReport.Header = $"Employee report on date: {DateTime.Now}\n";
        _employeeReport.Header += "\n---------------------------------------------------------\n";
        return this;
    }

    public IEmployeeReportBuilder BuildBody()
    {
        _employeeReport.Body = string.Join(Environment.NewLine,
            _employees.Select(x => $"Employee: {x.Name}\t\tSalary: {x.Salary}$"));
        return this;
    }

    public IEmployeeReportBuilder BuildFooter()
    {
        _employeeReport.Footer = "\n---------------------------------------------------------\n";
        _employeeReport.Footer +=
            $"\nTotal employees: {_employees.Count()};" +
            $"\nTotal salary: {_employees.Sum(x => x.Salary)}";
        return this;
    }

    public EmployeeReport GetReport()
    {
        EmployeeReport employeeReport = _employeeReport;
        _employeeReport = new EmployeeReport();
        return employeeReport;
    }
    
}