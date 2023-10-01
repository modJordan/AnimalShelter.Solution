  
// using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System.Collections.Generic;
// using Microsoft.Extensions.Configuration;
// using ToDoList.Models;
// using System;

// namespace AnimalShelter.Tests
// {
//   [TestClass]
//   public class ModelTests : IDisposable
//   {
//    public ModelTests()
//     {
//       IConfigurationBuilder builder = new ConfigurationBuilder()
//           .AddJsonFile("appsettings.json");
//       Configuration = builder.Build();
//       DBConfiguration.ConnectionString = Configuration["ConnectionStrings:TestConnection"];
//     }

//       [TestMethod]
//     public void GetAll_ReturnsEmptyList_ItemList()
//     {
//       // Arrange
//       List<Item> newList = new List<Item> { };

//       // Act
//       List<Item> result = Item.GetAll();

//       // Assert
//       CollectionAssert.AreEqual(newList, result);
//     }

//   }
// }