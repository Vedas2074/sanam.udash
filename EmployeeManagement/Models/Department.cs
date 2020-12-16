using System.Collections.Generic;

public class Department
{
        public string DName {get; set;}

        public int id {get; set;}

        public string DHead {get; set;}

        public int EmpId {get; set;}

        public Department(string Dname, int id, string Dhead, int EmpId)
        {
            this.DName = Dname;
            this.id = id;
            this.DHead = Dhead;
            this.EmpId = EmpId;
        }

        public static List<Department> GetDepartments()
        {
            Department dp1 = new Department("Human Resorce",1,"Sanam",2);
            Department dp2 = new Department("IT",2,"Susan",4);
            Department dp3 = new Department("Account",3,"Bijen",2);
            Department dp4 = new Department("Human Resorce",1,"Sanam",2);
            Department dp5 = new Department("Human Resorce",1,"Sanam",2);
            Department dp6 = new Department("Human Resorce",1,"Sanam",2);

            List<Department> departments = new List<Department>(){dp1,dp2,dp3,dp4,dp5,dp6};


            return departments;
        }
}