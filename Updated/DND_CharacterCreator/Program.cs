using DND_CharacterCreator.Constants;
using DND_CharacterCreator.Enums;
using DND_CharacterCreator.Models;

Console.WriteLine("Введите данные о персонаже.");
Console.Write("Имя: ");
string name = CreateName();
Console.WriteLine($"Введите значения характеристик (в диапазоне от {CharacteristicConstant.MinLimit} до {CharacteristicConstant.MaxLimit}).");
Console.Write("Сила: ");
int strength = CreateCharacteristic();
Console.Write("Ловкость: ");
int dexterity = CreateCharacteristic();
Console.Write("Телосложение: ");
int constitution = CreateCharacteristic();
Console.Write("Интеллект: ");
int intelligence = CreateCharacteristic();
Console.Write("Мудрость: ");
int wisdom = CreateCharacteristic();
Console.Write("Харизма: ");
int charisma = CreateCharacteristic();
Console.WriteLine("Выберите расу (номер):");
Console.WriteLine(new Ancestries().Print());
Ancestry ancestry = CreateAncestry();

Person person = new(name, ancestry, strength, dexterity, constitution, intelligence, wisdom, charisma);
Console.WriteLine(person.Print());

string CreateName()
{
    string? name;
    while (true)
    {
        name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.Write("Имя должно содержать символы. \nИмя: ");
        }
        else
        {
            break;
        }
    }
    return name;
}
int CreateCharacteristic()
{
    int number;
    while (true)
    {
        var input = Console.ReadLine();
        if (int.TryParse(input, out number))
        {
            if (number >= CharacteristicConstant.MinLimit && number <= CharacteristicConstant.MaxLimit)
            {
                break;
            }
            else
            {
                Console.Write($"Значение должно быть в диапазоне от {CharacteristicConstant.MinLimit} до {CharacteristicConstant.MaxLimit}. \nЗначение: ");
            }

        }
        else
        {
            Console.Write("Значение характеристики должно быть числом. \nЗначение: ");
        }
    }
    return number;
}
Ancestry CreateAncestry()
{
    AncestryType type = AncestryType.Dwarf;
    bool invalidOption = true;
    while (invalidOption)
    {
        int ancestryOption = Convert.ToInt32(Console.ReadLine());
        type = (AncestryType)ancestryOption;
        invalidOption = ancestryOption < 1 || ancestryOption > 3;
        if (invalidOption)
        {
            Console.WriteLine("Неверное число. Введите число из списка.");
        }
    }
    return new Ancestry(type);
}
