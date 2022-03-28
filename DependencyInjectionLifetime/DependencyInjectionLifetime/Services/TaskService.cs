using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionLifetime.Services
{
    public class TaskService : ITransientService, ISingletonService, IScopedService
    {
        Guid id;
        public TaskService()
        {
            id = Guid.NewGuid();
        }
        public Guid GetID()
        {
            return id;
        }
    }
}
