using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Players_Service.Model;

namespace Players_Service.Controllers
{
    [ApiController]
    public class PlayersController : ControllerBase
    {
        [HttpGet]
        [Route("api/Players/forgotpassword/{emailId}")]
        public async Task<ActionResult<IEnumerable<string>>> GetPlayersCredentials(string emailId)
        {
            var playersModel = new PlayersModel();
             playersModel.writeEmail(emailId);

            return  Ok("Email Sent To Your MailID" + " " + emailId);
           
        }
        [HttpGet]
        [Route("api/Players/tempLogin/{emailId}")]
        public async Task<ActionResult<IEnumerable<string>>> LoginByEmailAddress(string emailId)
        {
            return Ok("https://GreenTube.com/TempLogin");
        }
        
    }
}
