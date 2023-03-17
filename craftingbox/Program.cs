
CraftingBox craftingBox = new CraftingBox();
Random random = new Random();
for (int i = 0; i < 10; i++)
{
    craftingBox.CraftMeSomething(random.Next(4, 10));
}
Console.WriteLine(craftingBox.HowMuchCreated());
Console.ReadKey();

class CraftingBox
{
    private int tableCount = 0;
    private int chairCount = 0;
    private int plankCount = 0;

    private int remainder = 0;

    public CraftingBox()
    {

    }

    public string? CraftMeSomething(int woodAmount)
    {
        woodAmount += remainder;
        switch (woodAmount)
        {
            case >= 7:
                tableCount++;
                remainder = woodAmount - 7;
                return "table";
            case >= 5:
                chairCount++;
                remainder = woodAmount - 5;
                return "chair";
            case >= 3:
                plankCount++;
                remainder = woodAmount - 3;
                return "plank";
            default:
                return null;
        }
    }

    public int HowMuchCreated()
    {
        return tableCount + chairCount + plankCount;
    }
}