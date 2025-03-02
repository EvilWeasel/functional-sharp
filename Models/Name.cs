namespace BookStore.Models;
public abstract record NameType;

internal record FullNameType(string FirstName, string LastName) : NameType;
internal record MononymType(string Name) : NameType;

public static class Name
{
  public static NameType? Create(
    string firstName,
    string lastName
  ) =>
  string.IsNullOrWhiteSpace(firstName)
  || string.IsNullOrWhiteSpace(lastName)
  ? null
  : new FullNameType(firstName, lastName);

  public static NameType? Create(
    string mononym
  ) =>
  string.IsNullOrWhiteSpace(mononym)
  ? null
  : new MononymType(mononym);

  public static NameType[]? CreateMany(params NameType?[] names)
  => names.Any(name => name is null)
    ? null
    : (NameType[]?)names!;
}
