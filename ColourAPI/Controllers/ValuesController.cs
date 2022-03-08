using System.Collections.Generic;
using ColourAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ColourAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {

        private readonly ColourContext _colourContext;

        public ValuesController(ColourContext colorCtx)
        {
            this._colourContext = colorCtx;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Colour>> GetColourItems()
        {
            return this._colourContext.ColourItems;
        }
    }
}