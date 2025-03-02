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

var bookWithCasualNullChecking = authors is null
  ? null
  : Book.Create("THE MISSING BOOK", authors);

var bookTitleNullable = bookWithCasualNullChecking?.Title;

(bookWithCasualNullChecking?.Authors ?? Array.Empty<NameType>())
  .Select(Printable)
  .ToList()
  .ForEach(Console.WriteLine);

string Printable(NameType name) => name.Match(
  (first, last) => $"{last}, {first[..1]}",
  mononym => $"{mononym}"
);
