namespace Plantary.Models
{
  public class Plant
  {
    public int Water { get; set; }
    public int Food { get; set; }
    public int SunExposure { get; set; }
    public int Size { get; set; }
    public bool Health { get; set; }

    public Plant()
    {
      Water = 3;
      Food = 3;
      SunExposure = 3;
      Size = 3;
      Health = true;
    }

    public void Grow()
    {
      Size ++;
    }

    public void WaterPlant()
    {
      Water ++;
    }

    public void Sun()
    {
      SunExposure ++;
    }

    public void Feed()
    {
      Food ++;
    }
    public void NextDay()
    {
      Food --;
      Water --;
      SunExposure --;
    }

  }
}