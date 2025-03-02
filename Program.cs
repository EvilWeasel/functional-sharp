using BookStore.Models;

// Nullable array of nullable names?
var authorsBadExample = new[]
{
  Name.Create("Erich", "Gamma"),
  Name.Create("Richard", "Johnson"),
  Name.Create("Ralph", "Johnson"),
  Name.Create("John", "Vlissides"),
  Name.Create("Kernighan"),
  Name.Create("Ritchie"),
};

// We want a nullable array of non-nullable names
var authors = Name.CreateMany(
  Name.Create("Erich", "Gamma"),
  Name.Create("Richard", "Johnson"),
  Name.Create("Ralph", "Johnson"),
  Name.Create("John", "Vlissides"),
  Name.Create("Kernighan"),
  Name.Create("Ritchie")
);

var book = authors is null
  ? null
  : Book.Create("THE MISSING BOOK", authors);
