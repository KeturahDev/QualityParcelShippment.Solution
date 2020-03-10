using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    public int Width { get; set; }
    public int Length { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public int Volume { get; set; }

    public Parcel(int width, int length, int height, int weight)
    {
      Width = width;
      Length = length;
      Height = height;
      Width = width;
      Volume = length * width * height;

      Location.ParcelsList.Add(this);
    }
  }

  public class Location
  {
    public static List<Parcel> ParcelsList { get; set; } = new List<Parcel>();

    public int Distance { get; set; }
    public string LocationName { get; set; }

    public int price { get; set; }

    public Location(int distance, string name)
    {
      Distance = distance;
      LocationName = name;
      //get price here. 
    }

  }
}