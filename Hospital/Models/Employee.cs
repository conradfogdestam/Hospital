namespace Hospital.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; } = 1;
        public string Name { get; set; } = "Fronx";
        public int Age { get; set; } = 17;

        public EmployeePosition positionOfEmployee { get; set; } = EmployeePosition.Doctor;

    }
}
