string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't reassign the value of name this:
    if (name == "David") name = "Sammy";
}