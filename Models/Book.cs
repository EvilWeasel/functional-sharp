namespace BookStore.Models;
public record BookType(string Title, NameType[] Authors);

public static class Book
{
  public static BookType? Create(
    string title, params NameType[] authors)
  => string.IsNullOrWhiteSpace(title)
    ? null
    : new(title, authors);
}
