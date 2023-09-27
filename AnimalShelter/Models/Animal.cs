using System;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models;
public class Animal
{
  public string Name { get; set; }
  public string Breed { get; set; }

  public int Uid { get; set; }
  public string Date { get; set; } 

  public string Age { get; set; }

  public Animal(string name, string breed, int uId, string date, string age)
  {
    Name = name;
    Breed = breed;
    Uid = uId;
    Date = date;
    Age = age;
  }
}