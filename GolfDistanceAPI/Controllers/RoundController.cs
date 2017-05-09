using GolfDistanceAPI.Models.RoundModels;
using GolfDistanceAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GolfDistanceAPI.Controllers
{
    public class RoundController : ApiController
    {
        public IRoundService RoundService { get; set; }

        public RoundController(IRoundService roundService)
        {
            RoundService = roundService;
        }

        [Route("rounds/{roundId:int}/")]
        public HttpResponseMessage GetRound(int roundId)
        {
            var round = RoundService.Get(roundId);

            return Request.CreateResponse(HttpStatusCode.OK, round);
        }

        [Route("rounds/")]
        public HttpResponseMessage GetRounds()
        {
            var rounds = RoundService.Get();

            return Request.CreateResponse(HttpStatusCode.OK, rounds);
        }

        [Route("rounds/{roundId:int}/")]
        public HttpResponseMessage PostSwing(Round round)
        {
            return Request.CreateResponse();
        }
    }
}
