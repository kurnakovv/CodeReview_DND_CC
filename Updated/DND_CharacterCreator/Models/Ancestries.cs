using DND_CharacterCreator.Constants;

namespace DND_CharacterCreator.Models;

public class Ancestries
{
    public string Print()
    {
        string info = $"1. {AncestryConstant.ElfName} (+{AncestryConstant.ElfDexterity} к ловкости, +{AncestryConstant.ElfWisdom} к мудрости)\n";
        info += $"2. {AncestryConstant.DwarfName} (+{AncestryConstant.DwarfConstitution} к телосложению, +{AncestryConstant.DwarfStrength} к силе)\n";
        info += $"3. {AncestryConstant.GnomeName} (+{AncestryConstant.GnomeIntelligence} к интеллекту, +{AncestryConstant.GnomeDexterity} к ловкости)";
        return info;
    }
}
