using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03.Models
{
    public class EmployeeDepartment
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string DeptName { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, EmpName: {EmpName}, DeptName: {DeptName}";
        }

    }
}
