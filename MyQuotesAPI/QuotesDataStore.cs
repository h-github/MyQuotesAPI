using MyQuotesAPI.Models;
using System;
using System.Collections.Generic;

namespace MyQuotesAPI
{
  public class QuotesDataStore
    {
    public static QuotesDataStore Current { get; } = new QuotesDataStore();

    public List<QuoteDTO> Quotes { get; set; }

    public QuotesDataStore()
    {

      Quotes = new List<QuoteDTO>()
      {
        new QuoteDTO(){
          Id = 1,
          UserId ="10155457810183556",
          Content = "Life is about making an impact, not making an income." ,
          Author = "Kevin Kruse",
          DateCreated = DateTimeOffset.Parse("2016-11-18T02:42:48Z").UtcDateTime,
          DatePosted = DateTimeOffset.Parse("2017-02-22T07:14:51Z").UtcDateTime
        },
        new QuoteDTO(){
          Id = 2, UserId ="10155457810183556",
          Content = "Whatever the mind of man can conceive and believe, it can achieve." ,
          Author = "Napoleon Hill",
          DateCreated = DateTimeOffset.Parse("2017-02-02T07:18:42Z").UtcDateTime,
          DatePosted = DateTimeOffset.Parse("2017-02-16T23:14:56Z").UtcDateTime
        },
        new QuoteDTO(){
          Id = 3, UserId ="10155457810183556",
          Content = "Strive not to be a success, but rather to be of value." ,
          Author = "Albert Einstein",
          DateCreated = DateTimeOffset.Parse("2016-10-22T07:33:35Z").UtcDateTime,
          DatePosted = null
        },
        new QuoteDTO(){
          Id = 4,
          UserId ="10155457810183556",
          Content = "Two roads diverged in a wood, and I-I took the one less traveled by, And that has made all the difference." ,
          Author = "Robert Frost",
          DateCreated = DateTimeOffset.Parse("2017-06-04T12:13:25Z").UtcDateTime,
          DatePosted = null
        },
        new QuoteDTO()
        {
          Id = 5,
          UserId = "10155457844444444",
          Content = "I attribute my success to this: I never gave or took any excuse." ,
          Author = "Florence Nightingale",
          DateCreated = DateTimeOffset.Parse("2016-09-04T11:21:04Z").UtcDateTime,
          DatePosted = null
        }
      };
    }
  }
}
