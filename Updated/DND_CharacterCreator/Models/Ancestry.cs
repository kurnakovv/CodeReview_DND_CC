using DND_CharacterCreator.Constants;
using DND_CharacterCreator.Enums;

namespace DND_CharacterCreator.Models;

public class Ancestry
{
    public string Name { get; }
    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }
    public CreatureSize Size { get; }

    public Ancestry(AncestryType type)
    {
        if (type == AncestryType.Elf)
        {
            Name = AncestryConstant.ElfName;
            Dexterity = AncestryConstant.ElfDexterity;
            Wisdom = AncestryConstant.ElfWisdom;
            Size = CreatureSize.Medium;
        }
        else if (type == AncestryType.Dwarf)
        {
            Name = AncestryConstant.DwarfName;
            Strength = AncestryConstant.DwarfStrength;
            Constitution = AncestryConstant.DwarfConstitution;
            Size = CreatureSize.Medium;
        }
        else if (type == AncestryType.Gnome)
        {
            Name = AncestryConstant.GnomeName;
            Dexterity = AncestryConstant.GnomeDexterity;
            Intelligence = AncestryConstant.GnomeIntelligence;
            Size = CreatureSize.Small;
        }
        else
        {
            throw new NotImplementedException();
        }
    }
}
