using App.Base.Infrastructure.AppDomain;
using App.Base.Presentation.Web.Api.Infrastructure;
using App.Base.Presentation.Web.Constants;
using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Messages.API.V0100.Demo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;

namespace App.Host.Web.Api.Rest.Controllers.Spikes
{
    /// <summary>
    /// 
    /// </summary>
    [Route(ApiConstants.RestApiRoutePrefix + "[controller]")]
    [ApiController]
    [ForDemoOnly]
    public class LoadupController : ControllerBase
    {
        private readonly ApplicationPartManager _applicationPartManager;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="applicationPartManager"></param>
        public LoadupController(ApplicationPartManager applicationPartManager)
        {
            _applicationPartManager = applicationPartManager;
        }
        /// <summary>
        /// REST API GET Verb handler
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var ass = Assembly.GetEntryAssembly();

            string baseDir =
                Path.GetDirectoryName(ass!.Location)!;

            baseDir = Path.Combine(baseDir, "../../../LATELOAD/Debug/Net6.0/");


            string assemblyPath = //@"PATH\ExternalControllers.dll";
                Path.Combine(baseDir, "App.Spike.LateLoadController.dll");


            var loadContext = new AppModuleLoadContext(assemblyPath);
            
            //var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);
            var assembly = loadContext.LoadFromAssemblyPath(assemblyPath);


            if (assembly == null)
            {
                return Content("Bummer...");
            }
            _applicationPartManager
                .ApplicationParts
                .Add(new AssemblyPart(assembly));

            // Notify change
            AppActionDescriptorChangeProvider.Instance.Reset();

            return Content("Wow...Maybe?");
        }
    }
}
