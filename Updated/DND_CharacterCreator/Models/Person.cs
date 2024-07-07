namespace DND_CharacterCreator.Models;

public class Person
{
    private readonly string? _name;
    private readonly Characteristic _strength;
    private readonly Characteristic _dexterity;
    private readonly Characteristic _constitution;
    private readonly Characteristic _intelligence;
    private readonly Characteristic _wisdom;
    private readonly Characteristic _charisma;

    private readonly Ancestry _ancestry;

    public Person(
        string name,
        Ancestry ancestry,
        int strength,
        int dexterity,
        int constitution,
        int intelligence,
        int wisdom,
        int charisma
    )
    {
        _name = name;
        _ancestry = ancestry;
        _strength = new Characteristic(strength + ancestry.Strength);
        _dexterity = new Characteristic(dexterity + ancestry.Dexterity);
        _constitution = new Characteristic(constitution + ancestry.Constitution);
        _intelligence = new Characteristic(intelligence + ancestry.Intelligence);
        _wisdom = new Characteristic(wisdom + ancestry.Wisdom);
        _charisma = new Characteristic(charisma + ancestry.Charisma);
    }
    public string Print()
    {
        string info = $"Имя: {_name}, Раса: {_ancestry.Name} \n";
        info += $"Сила: {_strength.Value} ({_strength.PrintModifier()}), ";
        info += $"Ловкость: {_dexterity.Value} ({_dexterity.PrintModifier()}), ";
        info += $"Телосложение: {_constitution.Value} ({_constitution.PrintModifier()}), ";
        info += $"Интеллект: {_intelligence.Value} ({_intelligence.PrintModifier()}), ";
        info += $"Мудрость: {_wisdom.Value} ({_wisdom.PrintModifier()}), ";
        info += $"Харизма: {_charisma.Value} ({_charisma.PrintModifier()})";
        return info;
    }
}
