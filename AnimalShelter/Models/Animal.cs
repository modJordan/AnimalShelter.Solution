namespace AnimalShelter.Models;
public class Animal
{
  public string Name { get; set; }
  public string Breed { get; set; }
  public int AnimalId { get; set; }

  public Species Species { get; set; }

}

public enum Species
{
  Cat = 1,
  Dog = 2
}