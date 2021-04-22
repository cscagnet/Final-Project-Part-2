  using System;
  
  class Book
  {
    public string Isbn { get; set; }
    public string Title { get; set; }
    public Author AuthorInfo{get; set;}
    public virtual DateTime PublishedOn { get; set; }
    public string PublishedBy {get; set;}

    public Book (string isbn, string title, Author AuthorInfo) 
      {
        Isbn = isbn;
        Title = title;
        AuthorInfo= authorinfo;
        PublishedOn = DateTime.Now;
        PublishedBy = "Unknown";
      }
    public Book (string isbn, string title, Author authorinfo, DateTime publishedon, string publishedby) 
      {
        Isbn = isbn;
        Title = title;
        Author= authorinfo;
        PublishedOn = publishedon;
        PublishedBy = publishedby;
      }

    public void Display()
    {
      Console.WriteLine("Book " + Title + "was written by" + AuthorInfo + " and published on " + PublishedOn);
    }
    
  }