namespace LanguageDictionaryApp;

internal class LanguageDictionary
{
    private string[] rus = new string[5];
    private string[] blr = new string[5];
    private string[] eng = new string[5];

    public LanguageDictionary()
    {
        rus[0] = "книга"; blr[0] = "кніга"; eng[0] = "book";
        rus[1] = "ручка"; blr[1] = "ручка"; eng[1] = "pen";
        rus[2] = "солнце"; blr[2] = "сонца"; eng[2] = "sun";
        rus[3] = "яблоко"; blr[3] = "яблык"; eng[3] = "apple";
        rus[4] = "стол"; blr[4] = "стол"; eng[4] = "table";
    }

    public string this[string index]
    {
        get
        {
            for (int i = 0; i < rus.Length; i++)
                if (rus[i] == index)
                    return $"{rus[i]} - {blr[i]} - {eng[i]}";

            for (int i = 0; i < blr.Length; i++)
                if (blr[i] == index)
                    return $"{rus[i]} - {blr[i]} - {eng[i]}";

            for (int i = 0; i < eng.Length; i++)
                if (eng[i] == index)
                    return $"{rus[i]} - {blr[i]} - {eng[i]}";

            return $"{index} - нет перевода для этого слова.";
        }
    }

    public string this[int index]
    {
        get
        {
            if (index >= 0 && index < rus.Length)
                return $"{rus[index]} - {blr[index]} - {eng[index]}";
            else
                return "Попытка обращения за пределы массива!";
        }
    }
}
