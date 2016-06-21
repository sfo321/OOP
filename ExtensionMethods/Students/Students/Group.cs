namespace Students
{
    public class Group
    {
        public int Groupnumber { get; set; } 

        public string DepartmentName { get; set; }

        public Group(int groupnumber, string department)
        {
            this.Groupnumber = groupnumber;
            this.DepartmentName = department;
        }
    }
}
