using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyQuotesAPI.Entities
{
  public class Quote
  {
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string UserId { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DatePosted { get; set; }
  }
}
