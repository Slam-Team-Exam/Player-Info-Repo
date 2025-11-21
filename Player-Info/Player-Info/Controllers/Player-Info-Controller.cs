using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Player_Info.Controllers
{
    public class Player_Info_Controller
    {

        [ApiController]
        [Route("api/[controller]")]
        [Authorize] 
        public class PlayerController : ControllerBase
        {
            // POST: api/player
            [HttpPost]
            public IActionResult MakePlayer()
            {
                // TODO: Lav player baseret på User/claims
                // var playerId = GetPlayerIdFromJwt();

                return Ok(); // evt. Created(...)
            }

            // GET: api/player
            [HttpGet]
            public ActionResult<string> GetPlayerInfo()
            {
                
                // var playerId = GetPlayerIdFromJwt();
                // var name = ...

                return Ok(/* name */);
            }

            // PUT: api/player
            [HttpPut]
            public IActionResult UpdatePlayerInfo([FromBody] UpdatePlayerInfoRequest request)
            {
                // var playerId = GetPlayerIdFromJwt();
                // request.Name ...

                return Ok();
            }

            // DELETE: api/player/{id}
            [HttpDelete("{id}")]
            public IActionResult DeletePlayer(string id)
            {
                // TODO: Slet player (evt. tjek at id matcher JWT player)
                return Ok();
            }

            // GET: api/player/deck/{deckId}
            [HttpGet("deck/{deckId}")]
            public ActionResult<DeckDto> GetDeck(string deckId)
            {
                // var playerId = GetPlayerIdFromJwt();
                // var deck = ...

                return Ok(/* deck */);
            }

            // GET: api/player/cards
            [HttpGet("cards")]
            public ActionResult<List<string>> GetCards()
            {
                // var playerId = GetPlayerIdFromJwt();
                // var cards = ...

                return Ok(/* cards */);
            }

            // Helper til at hente PlayerId/UserId fra JWT claims
            private string? GetPlayerIdFromJwt()
            {
                return User.FindFirstValue(ClaimTypes.NameIdentifier);
                // eller hvis du bruger en custom claim:
                // return User.FindFirstValue("playerId");
            }
        }

        // --- Request/Response DTOs ---
        public class UpdatePlayerInfoRequest
        {
            public string Name { get; set; } = string.Empty;
        }

        public class DeckDto
        {
            public string DeckName { get; set; } = string.Empty;
            // evt. flere felter senere
        }

    }
}
