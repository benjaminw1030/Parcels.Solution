using System;
using System.Collections.Generic;

namespace Parcels.Models
{
  
  public class Parcel
  {
    
    public int Height { get; set; }
    public int Width { get; set; }
    public int Length { get; set; }
    public int Weight { get; set; }

    private static Parcel _myParcel = new Parcel(0, 0, 0, 0);

    public Parcel(int height, int width, int length, int weight)
    {
      Height = height;
      Width = width;
      Length = length;
      Weight = weight;
      _myParcel = this;
    }

    public static Parcel GetParcel()
    {
      return _myParcel;
    }

    public int Volume()
    {
      int volume = this.Height * this.Width * this.Length;
      return volume;
    }

    public string CostToShip()
    {
      double price = this.Volume() * .001;
      price += this.Weight * .0625;
      string outputPrice = price.ToString("0.00");
      return outputPrice;
    }
  }
}