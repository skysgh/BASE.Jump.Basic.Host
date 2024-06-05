using App.Base.Presentation.Web.Constants;
using App.Base.Shared.Attributes;
using App.Base.Shared.Models.Messages.API.V0100.Demo;
using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace App.Host.Web.Api.Rest.Controllers.Spikes
{
    /// <summary>
    /// For Demo/Learning purposes only.
    /// A controller that returns the current time.
    /// </summary>
    [Route(ApiConstants.RestApiRoutePrefix + "[controller]")]
    [ApiController]
    [ForDemoOnly]
    public class TimeController : ControllerBase
    {
        static DateTime Started;
        /// <summary>
        /// Initializes the <see cref="TimeController"/> class.
        /// </summary>
        static TimeController()
        {
            Started = DateTime.UtcNow;
        }

        /// <summary>
        /// REST API GET Verb handler
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            var elapsed = DateTime.UtcNow - Started;
            return base.Content($"Since started: {elapsed.TotalSeconds} seconds");
        }
    }
}
