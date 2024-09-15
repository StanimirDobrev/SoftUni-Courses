using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheContentDepartment.Models.Contracts;
using TheContentDepartment.Repositories.Contracts;

namespace TheContentDepartment.Repositories
{
    public class ResourceRepository : IRepository<IResource>
    {
        //private readonly List<IResource> _models;

        //public ResourceRepository()
        //{
        //    _models = new List<IResource>();
        //}

        //public IReadOnlyCollection<IResource> Models => _models.AsReadOnly();
        //public void Add(IResource model)
        //{
        //    _models.Add(model);
        //}

        //public IResource TakeOne(string modelName) 
        //    => _models.FirstOrDefault(m => m.Name == modelName);
        private readonly List<IResource> _models;

        public ResourceRepository()
        {
            this._models = new List<IResource>();
            this.Models = this._models.AsReadOnly();
        }

        public IReadOnlyCollection<IResource> Models { get; }

        public void Add(IResource model) => this._models.Add(model);

        public IResource TakeOne(string modelName) => this.Models.FirstOrDefault(m => m.Name == modelName);
    }
}

