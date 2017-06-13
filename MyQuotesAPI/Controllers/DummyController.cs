using Microsoft.AspNetCore.Mvc;
using MyQuotesAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuotesAPI.Controllers
{
  public class DummyController:Controller
  {
    private QuoteInfoContext _qtx;

    public DummyController(QuoteInfoContext qtx)
    {
      _qtx = qtx;
    }

    [HttpGet]
    [Route("api/testdatabase")]
    public IActionResult TestDatabase()
    {
      return Ok();
    }
  }
}
