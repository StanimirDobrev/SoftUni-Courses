using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Models.Contracts;
using TheContentDepartment.Utilities.Messages;

namespace TheContentDepartment.Models
{
    public abstract class TeamMember : ITeamMember
    {
        //private string name;
        //private readonly List<string> _inProgress;
        //protected TeamMember(string name, string path)
        //{
        //    name = name;
        //    Path = path;

        //    _inProgress = new List<string>();
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
        //public string Path { get; }
        //public IReadOnlyCollection<string> InProgress => _inProgress.AsReadOnly();
        //public void WorkOnTask(string resourceName)
        //{
        //    _inProgress.Add(resourceName);
        //}

        //public void FinishTask(string resourceName)
        //{
        //    _inProgress.Remove(resourceName);
        //}
        private readonly List<string> _inProgress;

        protected TeamMember(string name, string path)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException(ExceptionMessages.NameNullOrWhiteSpace);

            this.Name = name;
            this.Path = path;

            this._inProgress = new List<string>();
            this.InProgress = this._inProgress.AsReadOnly();
        }

        public string Name { get; }
        public string Path { get; }
        public IReadOnlyCollection<string> InProgress { get; }

        public void WorkOnTask(string resourceName) => this._inProgress.Add(resourceName);

        public void FinishTask(string resourceName) => this._inProgress.Remove(resourceName);

        public override string ToString() => $"Currently working on {this.InProgress.Count} tasks.";
    }
}
