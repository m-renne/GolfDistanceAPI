using GolfDistanceAPI.Application.Interfaces.Services;
using GolfDistanceAPI.Infrastructure.Interfaces.Factories;
using GolfDistanceAPI.ServiceModels.Swings;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GolfDistanceAPI.Controllers
{
    public class RoundController : ApiController
    {
        private IBaseFactory ServiceFactory { get; set; }

        public RoundController(IBaseFactory serviceFactory)
        {
            this.ServiceFactory = serviceFactory;
        }

        [Route("rounds/{roundId:int}/")]
        public HttpResponseMessage GetRound(int roundId)
        {
            IRoundService service = ServiceFactory.Create<IRoundService>();

            var round = service.Get(roundId);

            return Request.CreateResponse(HttpStatusCode.OK, round);
        }

        [Route("rounds/")]
        public HttpResponseMessage GetRounds()
        {
            IRoundService service = ServiceFactory.Create<IRoundService>();


            var rounds = service.Get();

            return Request.CreateResponse(HttpStatusCode.OK, rounds);
        }

        [Route("rounds/{roundId:int}/")]
        public HttpResponseMessage PostSwing(int roundId, Swing swing)
        {
            return Request.CreateResponse();
        }
    }
}
