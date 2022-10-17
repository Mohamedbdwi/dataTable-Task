namespace Student_task_datatable.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date_of_birth { get; set; }
        public int Year_enrolled { get; set; }
        public string Year_class { get; set; }


        public string Address { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Section { get; set; }

        public int GPA { get; set; }
        public string Phone_No { get; set; }
        public string Hobby { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
    }
}
