using Microsoft.AspNetCore.Mvc.Filters;

namespace Inventarios_BE.Filtros
{
    public class filtroExcepcion: ExceptionFilterAttribute
    {
        private readonly ILogger<filtroExcepcion> logger;

        public filtroExcepcion(ILogger<filtroExcepcion> logger)
        {
            this.logger = logger;
        }
        public override void OnException(ExceptionContext context)
        {
            logger.LogError(context.Exception, context.Exception.Message);
            base.OnException(context);
        }
    }
}
