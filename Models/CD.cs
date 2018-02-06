using System;
using System.Collections.Generic;

namespace Cds.Models
{
  public class Cd
  {
    private static List<Cd> _instances = new List<Cd> {};

    private string _title;
    private string _artist;
    private string _price;

    public Cd(string title, string artist, string price)
    {
      _title = title;
      _artist = artist;
      _price = price;
    }

    public string GetTitle()
    {
      return _title;
    }
    public string GetArtist()
    {
      return _artist;
    }
    public string GetPrice()
    {
      return _price;
    }

    public void Save()
    {
      if (_title.Length == 0 || _artist.Length == 0 || _price.Length == 0)
        return;

      foreach (var cd in _instances)
        if (_title == cd._title && _artist == cd._artist && _price == cd._price)
          return;

      _instances.Add(this);
    }

    public static List<Cd> GetAll()
    {
      return _instances;
    }

    public static void Clear()
    {
      _instances.Clear();
    }
  }
}
