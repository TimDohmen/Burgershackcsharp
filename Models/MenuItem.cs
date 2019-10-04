namespace burgersack.Models
{
  public class MenuItem
  {
    public string Title { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }

    public MenuItem(string title, double price, string desc)
    {
      Title = title;
      Price = price;
      Description = desc;
    }
  }
}