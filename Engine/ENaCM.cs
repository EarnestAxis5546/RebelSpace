using System.Collections.Generic;

// Assuming ENaCM is a class, here's a basic structure:
public class ENaCM
{
    private List<string> items;

    public ENaCM()
    {
        items = new List<string>();
    }

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public List<string> GetItems()
    {
        return items;
    }
}
