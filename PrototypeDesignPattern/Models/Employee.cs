using PrototypeDesignPattern.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern.Models
{
    public class Employee : PrototypeEmployee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(Guid Id, string Name, string Department)
        {
            this.Id = Id;
            this.Name = Name;
            this.Department = Department;
        }

        public override PrototypeEmployee? Clone()
        {
            return this.MemberwiseClone() as PrototypeEmployee;
        }
    }
}
