using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DependencyInjectionPractise.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjectionPractise.Pages
{
    public class IndexModel : PageModel
    {
        public IOperationTransient TransientOperation { get; }
        public IOperationScoped ScopedOperation { get; }
        public IOperationSingleton SingletonOperation { get; }

        public OperationService OperationService { get; }


        public IndexModel(
        IOperationTransient transientOperation,
        IOperationScoped scopedOperation,
        IOperationSingleton singletonOperation,
        OperationService operationService
        )
        {
            TransientOperation = transientOperation;
            ScopedOperation = scopedOperation;
            SingletonOperation = singletonOperation;
            OperationService = operationService;
        }

        [BindProperty]
        public Sample Sample { get; set; }
        public IActionResult OnGet()
        {
            ViewData["TransientData"] = String.Format("Transient Request : {0} ", TransientOperation.guid );
            ViewData["ScopedData"] = String.Format("Scoped Request : {0} ", ScopedOperation.guid);
            ViewData["SingleData"] = String.Format("Singleton Request : {0} ", SingletonOperation.guid);

            ViewData["TransientDataOther"] = String.Format("Transient Request (Other dependency Type): {0} ", OperationService.TransientOperation.guid);
            ViewData["ScopedDataOther"] = String.Format("Scoped Request  (Other dependency Type): {0} ", OperationService.ScopedOperation.guid);
            ViewData["SingleDataOther"] = String.Format("Singleton Request  (Other dependency Type): {0} ", OperationService.SingletonOperation.guid);

            return Page();
        }
    }
}