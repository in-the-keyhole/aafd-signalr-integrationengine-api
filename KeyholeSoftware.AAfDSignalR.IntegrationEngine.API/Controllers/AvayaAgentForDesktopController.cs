using Microsoft.AspNetCore.Mvc;

namespace KeyholeSoftware.AAfDSignalR.IntegrationEngine.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AvayaAgentForDesktopController : ControllerBase
    {
        /// <summary>
        /// API to invoke for AAfD's screen pop
        /// </summary>
        /// <param name="nameOfCaller"></param>
        /// <param name="numberOfCaller"></param>
        /// <param name="digitsEntered"></param>
        /// <param name="vdnCampaignName"></param>
        /// <param name="communicationManagerCollectedInfo"></param>
        /// <param name="timeWhenAgentAcceptedCall"></param>
        /// <param name="timeWhenAgentEndedCall"></param>
        /// <param name="timeWhenAgentReceivedCall"></param>
        /// <param name="agentId"></param>
        /// <param name="stationId"></param>
        /// <repsonse code="202">AAfD screen pop successfully processed</repsonse>
        /// <returns>True if the screen pop was successfully processed</returns>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET /CallReceived
        ///             ?n=5555008709
        ///             &m=5555008709
        ///             &p=4
        ///             &v=HH%20Other
        ///             &u=
        ///             &s=1611866452
        ///             &e=1611866452
        ///             &d=1611866454
        ///             &a=182965
        ///             &i=3115
        /// </remarks>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        public bool CallReceived([FromQuery(Name = "n")] string nameOfCaller = "",
                                 [FromQuery(Name = "m")] string numberOfCaller = "",
                                 [FromQuery(Name = "p")] string digitsEntered = "",
                                 [FromQuery(Name = "v")] string vdnCampaignName = "",
                                 [FromQuery(Name = "u")] string communicationManagerCollectedInfo = "",
                                 [FromQuery(Name = "s")] string timeWhenAgentAcceptedCall = "",
                                 [FromQuery(Name = "e")] string timeWhenAgentEndedCall = "",
                                 [FromQuery(Name = "d")] string timeWhenAgentReceivedCall = "",
                                 [FromQuery(Name = "a")] string agentId = "",
                                 [FromQuery(Name = "i")] string stationId = "")
        {
            return true;
        }
    }
}
