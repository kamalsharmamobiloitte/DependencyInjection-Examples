using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionPractise
{
    public class Operation : IOperationScoped , IOperationSingleton, IOperationTransient
    {
        public Guid guid
        {
            get; private set;
        }

        public Operation() : this(Guid.NewGuid())
        {
        }

        public Operation(Guid id)
        {
            guid = id;
        }


    }
}
