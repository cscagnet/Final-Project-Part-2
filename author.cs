using System;
using System.Collections.Generic;
  
  class Author : Person
  {
    private List<Book> BookList = new List<Book>();

  public void DisplayInfo(string fname, string lname, string email)
    {
      FirstName = fname;
      LastName = lname;
      Email = email;
    }

  public void DisplayBooks ()
    {
      foreach 
      Display();
    }
  public void AddBook (Book b)
    {
      BookList.Add(b);
    }
  public void RemoveBook(Book b)
    {

    }

  }