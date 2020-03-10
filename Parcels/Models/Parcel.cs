using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {

    public int Width { get; set; }
    public int PLength { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }

    public Parcel(int width, int length, int height, int weight)
    {
      Width = width;
      PLength = length;
      Height = height;
      Weight = weight;
      Volume = length * width * height;

      Location.ParcelsList.Add(this);
    }

    public static int GetPrice()
    {
      if (Location.ParcelsList.Count > 0)
      {
        int volume = 0;
        int weight = 0;
        foreach (var item in Location.ParcelsList)
        {
          volume += item.Volume;
          weight += item.Weight;
        }
        return volume / weight;
        // return (volume / weight);
        // return (volume / weight) * (Location.Distance / 10);
      }
      else
      {
        return 0;
      }
    }
  }

  public class Location
  {
    public static List<Parcel> ParcelsList { get; set; } = new List<Parcel>();

    public static int Distance { get; set; }
    public static string LocationName { get; set; }

    public static int Price { get; set; }

  }
}