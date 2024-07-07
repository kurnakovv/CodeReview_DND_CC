namespace DND_CharacterCreator.Models;

public class Characteristic
{
    public int Value { get; }
    public Characteristic(int value)
    {
        Value = value;
    }
    public int CalcModifier()
    {
        decimal preModifier = Math.Floor((decimal)(Value - 10) / 2);
        int modifier = Convert.ToInt32(preModifier);
        return modifier;
    }
    public string PrintModifier()
    {
        int modifier = CalcModifier();
        return modifier > 0 ? $"+{modifier}" : $"{modifier}";
    }
}
