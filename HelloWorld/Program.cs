var name=personName.parse("ALi");
name.name("Hassan");
class personName
{
    private String FirstName;

    public void name(String LastName)
    {
        Console.WriteLine("Name: {0} {1}",FirstName,LastName);
    }
    public static personName parse(String name)
    {
        var personName=new personName();
        personName.FirstName=name;
        return personName;
    }
}