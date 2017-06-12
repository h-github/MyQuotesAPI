using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuotesAPI.Models
{
    public class QuoteDTO
    {
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DatePosted { get; set; }
  }
}
