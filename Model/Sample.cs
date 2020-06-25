using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionPractise.Model
{
    public class Sample
    {
        public Guid transientOperationId { get; set; }

        public Guid scopedOperationId { get; set; }

        public Guid singletonOperationId { get; set; }
    }
}
