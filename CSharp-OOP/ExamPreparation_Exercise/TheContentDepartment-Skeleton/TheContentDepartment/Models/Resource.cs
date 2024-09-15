using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Models.Contracts;
using TheContentDepartment.Utilities.Messages;

namespace TheContentDepartment.Models
{
    public abstract class Resource : IResource
    {
        //private string name;
        //private string creator;
        //private int priority;
        //protected Resource(string name, string creator, int priority)
        //{
        //    name = name;
        //    Creator = creator;
        //    Priority = priority;
        //}

        //public string Name
        //{
        //    get => name;
        //    private set
        //    {
        //        if (string.IsNullOrWhiteSpace(value))
        //        {
        //            string.Format(ExceptionMessages.NameNullOrWhiteSpace);
        //        }
        //        name = value;
        //    }
        //}
        //public string Creator { get; }
        //public int Priority { get; }
        //public bool IsTested { get; private set; }
        //public bool IsApproved { get; private set; }

        //public void Test()
        //    => IsTested = !IsTested;

        //public void Approve()
        //{
        //    IsApproved = true;
        //}

        //public override string ToString()
        //{
        //    return $"{Name} ({GetType().Name}), Created By: {Creator}";
        //}
        protected Resource(string name, string creator, int priority)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(ExceptionMessages.NameNullOrWhiteSpace);
            this.Name = name;
            this.Creator = creator;
            this.Priority = priority;
        }

        public string Name { get; }
        public string Creator { get; }
        public int Priority { get; }
        public bool IsTested { get; private set; }
        public bool IsApproved { get; private set; }

        public void Test() => this.IsTested = !this.IsTested;

        public void Approve() => this.IsApproved = true;

        public override string ToString() => $"{this.Name} ({this.GetType().Name}), Created By: {this.Creator}";
    }
}
