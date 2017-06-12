using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyQuotesAPI.Models
{
  public class Quote
  {
    [Required]
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DatePosted { get; set; }
  }
}
