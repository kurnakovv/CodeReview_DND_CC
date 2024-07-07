class Person
{
    string? _name;
    Characteristic _strength;
    Characteristic _dexterity = new Characteristic(0);
    Characteristic _constitution = new Characteristic(0);
    Characteristic _intelligence = new Characteristic(0);
    Characteristic _wisdom = new Characteristic(0);
    Characteristic _charisma = new Characteristic(0);

    Ancestry _ancestry;
    #region Methods
    public void GetInfo()
    {
        Console.WriteLine($"Имя: {_name}, Происхождение: {_ancestry._name}");
        Console.WriteLine($"Сила: {_strength.value} ({_strength.GetModifierString()}), Ловкость:{_dexterity.value} ({_dexterity.GetModifierString()}), Телосложение: {_constitution.value} ({_constitution.GetModifierString()}), Интеллект: {_intelligence.value} ({_intelligence.GetModifierString()}), Мудрость: {_wisdom.value} ({_wisdom.GetModifierString()}), Харизма: {_charisma.value} ({_charisma.GetModifierString()})");
    }

    int SetCharacteristic(int number, int ancestryBonus)
    {
        int characteristic = number + ancestryBonus;
        return characteristic;
    }
    #endregion

    private class Characteristic
    {
        public int value { get; } = 0;
        public int GetModifierInt()
        {
            decimal modifierDecimal = Math.Floor((decimal)(value - 10) / 2);
            int modifier = Convert.ToInt32(modifierDecimal);
            return modifier;
        }
        public string GetModifierString()
        {
            int modifier = GetModifierInt();
            if (modifier > 0)
            {
                return $"+{modifier}";
            }
            else
                return $"{modifier}";
        }
        public Characteristic (int value)
        {
            this.value = value;
        }
    }

    public Person(
        string name,
        Ancestry ancestry, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        _name = name;
        _ancestry = ancestry;
        _strength = new Characteristic (SetCharacteristic(strength, ancestry._strengthBonus));
        _dexterity = new Characteristic (SetCharacteristic(dexterity, ancestry._dexterityBonus));
        _constitution = new Characteristic (SetCharacteristic(constitution, ancestry._constitutionBonus));
        _intelligence = new Characteristic (SetCharacteristic(intelligence, ancestry._intelligenceBonus));
        _wisdom = new Characteristic (SetCharacteristic(wisdom, ancestry._wisdomBonus));
        _charisma = new Characteristic (SetCharacteristic(charisma, ancestry._charismaBonus));
    }
}
