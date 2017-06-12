using System;
using System.ComponentModel.DataAnnotations;

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
