using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionPractise
{
    public interface IOperation
    {
        public Guid guid { get;  }

        
    }

    public interface IOperationTransient : IOperation
    {
       
    }

    public interface IOperationSingleton : IOperation
    {
         
    }

    public interface IOperationScoped : IOperation
    {
        
    }

}
