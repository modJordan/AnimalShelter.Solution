using System;
using System.Data.Common;
using AnimalShelter.Controllers;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace AnimalShelter.Models;
public class Animal
{


  public string Name { get; set; }
  public string Breed { get; set; }

  public int Uid { get; set; }
  public string Date { get; set; } 

  public int Age { get; set; }

  public Animal(string name, string breed, int uId, string date, int age)
  {
    Name = name;
    Breed = breed;
    Uid = uId;
    Date = date;
    Age = age;
  }

  // public MySqlConnection GetConnection()
  // {
  //   return new MySqlConnection(_connectionString);
  // }

  // public static Animal Find(int Uid)
  // {
    
  //   conn.Open();

  //   MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
  //   cmd.CommandText = "SELECT * FROM animals WHERE Uid = @Uid;";

  //   MySqlParameter param = new MySqlParameter();
  //   param.ParameterName = "@Uid";
  //   param.Value = Uid;
  //   cmd.Parameters.Add(param);

  //   MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
  //   int animalUId = 0;
  //   string animalName = "";
  //   string animalBreed = "";
  //  string animalDate = "";
  //   int animalAge = 0;

  //   while (rdr.Read())
  //   {
  //     animalUId = rdr.GetInt32(0);
  //     animalName = rdr.GetString(1);
  //     animalBreed = rdr.GetString(2);
  //     animalDate = rdr.GetString(3);
  //     animalAge = rdr.GetInt32(4);
  //   }

  //   Animal foundAnimal = new Animal(animalName, animalBreed, animalUId, animalDate, animalAge);

  //   conn.Close();
  //   if (conn != null)
  //   {
  //     conn.Dispose();
  //   }
  //   return foundAnimal;
  // }

  // public Animal(IConfiguration configuration)
  // {
  //   _connectionString = configuration.GetConnectionString("DefaultConnection");
  // }
}