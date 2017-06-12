using Microsoft.AspNetCore.Mvc;
using MyQuotesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuotesAPI.Controllers
{
  [Route("api/{userId}")]
  public class QuotesController : Controller
  {
    [HttpGet("quotes/{posted}")]
    public IActionResult GetPostedQuotes(string userId, string posted)
    {
      return Ok(QuotesDataStore.Current.Quotes.Where(q => q.UserId == userId && ((posted == "posted") == (q.DatePosted != null))));
    }

    [HttpGet("quote/{id}", Name = "GetUserQuote")]
    public IActionResult GetPostedQuote(string userId, int id)
    {
      var quote = QuotesDataStore.Current.Quotes.FirstOrDefault(q => q.UserId == userId && q.Id == id);
      if(quote == null)
      {
        return NotFound();
      }
      return Ok(quote);
    }

    [HttpPost("quote")]
    public IActionResult PostNewQuote(string userId, [FromBody]Quote quote)
    {
      if(quote == null)
      {
        return BadRequest();
      }

      if (!ModelState.IsValid)
      {
        return BadRequest();
      }

      var maxQuoteId = QuotesDataStore.Current.Quotes.Max(q => q.Id);
      var newQuote = new QuoteDTO
      {
        Id = ++maxQuoteId,
        UserId = userId,
        Content = quote.Content,
        Author = quote.Author,
        DateCreated = DateTime.Now.ToUniversalTime(),
        DatePosted = null
      };

      QuotesDataStore.Current.Quotes.Add(newQuote);

      return CreatedAtRoute("GetUserQuote", new { userId = userId, id = newQuote.Id}, newQuote);
    }

    [HttpPut("quote/{id}")]
    public IActionResult PostQuote(string userId, int id)
    {
      var quote = QuotesDataStore.Current.Quotes.FirstOrDefault(q=>q.UserId == userId && q.Id == id);
      if(quote == null)
      {
        return NotFound();
      }

      quote.DatePosted = DateTime.Now.ToUniversalTime();

      return CreatedAtRoute("GetUserQuote", new { userId = userId, id = quote.Id, datePosted = quote.DatePosted }, quote);
    }

  }
}
