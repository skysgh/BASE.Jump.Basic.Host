using App.Base.Presentation.Web.Constants;
using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Messages;
using App.Base.Shared.Models.Messages.API.V0100;
using App.Base.Shared.Models.Messages.API.V0100.Demo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Options;

namespace App.Host.Web.Controllers.Demo
{
    /// <summary>
    /// A demo controller to help developers
    /// get up to speed on how the framework 
    /// is wired together.
    /// </summary>
    [Route(ApiConstants.RestApiRoutePrefix + "Host/[controller]")]
    [ApiController]
    [ForDemoOnly]
    [ApiVersion("1.0")]
    public class HostLayerExampleAEntityController : ControllerBase
    {


        //IStringLocalizer _stringLocalised;

        /// <summary>
        /// Constructor
        /// </summary>
        public HostLayerExampleAEntityController()
        {
            //IStringLocalizer stringLocalised
            //    _stringLocalised = stringLocalised;
        }


        /// <summary>
        /// REST API GET Verb handler
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<ExampleAEntityDto> Get()
        {

            var values =
            new ExampleAEntityDto[]{
                new ExampleAEntityDto(){Text="A1.01",Description="* straight REST (not ODATA) Controller."},
                new ExampleAEntityDto(){Text="A1.02",Description="* to Host Layer Controller"},
                new ExampleAEntityDto(){Text="A1.03",Description="* Return System Entities DTOs"},
                new ExampleAEntityDto(){Text="A1.04",Description="* Developed in the Controller (not a lower Service)."},
                new ExampleAEntityDto(){Text="A1.05",Description="* Note:"},
                new ExampleAEntityDto(){Text="A1.06",Description="  * Route defined on Controller."},
                new ExampleAEntityDto(){Text="A1.07",Description="  * no Mapping going on."},
                new ExampleAEntityDto(){Text="A1.08",Description="  * no Repository Service involved."},
                new ExampleAEntityDto(){Text="A1.09",Description="- Synopsis: "},
                new ExampleAEntityDto(){Text="A1.10",Description="  + so simple, practically cannot fail."},
                new ExampleAEntityDto(){Text="A1.11",Description="  + Using DTOs, rather than exposing internal Sys Entites."},
                new ExampleAEntityDto(){Text="A1.12",Description="  - No Queryability."},
            };
            return values;
        }
    }

}
