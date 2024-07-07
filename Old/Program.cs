Console.Write("Введите имя персонажа: ");
string? name = Console.ReadLine();
if (name == "" || name == " ")
    name = "без имени";
Console.Write("Введите значение силы: ");
int strength = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение ловкости: ");
int dexterity = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение телосложения: ");
int constitution = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение интеллекта: ");
int intelligence = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение мудрости: ");
int wisdom = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение харизмы: ");
int charisma = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите расу (введите её номер в консоль): \n1. Эльф (+2 к ловкости, +1 к мудрости) \n2. Дварф (+2 к телосложению, +1 к силе) \n3. Гном (+2 к интеллекту, +1 к ловкости)");
Ancestry ancestry = GetAncestry(); 

Person person = new Person (name, ancestry, strength, dexterity, constitution, intelligence, wisdom, charisma);
person.GetInfo();


// Методы

Ancestry GetAncestry()
{
    int ancestryOption = 0;
    for (bool InvalidOption = true; InvalidOption;  )
    {
       ancestryOption = Convert.ToInt32(Console.ReadLine());
       InvalidOption = ancestryOption < 1 || ancestryOption > 3;
       if (InvalidOption)
            Console.WriteLine("Неверное число. Введите число из списка.");
    }
    return new Ancestry(ancestryOption);
}
