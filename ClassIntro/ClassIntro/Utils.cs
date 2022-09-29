namespace ClassIntro;

using System;

public class FileHandler
{
    public string ReadFile(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
        {
            return "";
        }
        else if (File.Exists(fileName))
        {
            return File.ReadAllText(fileName);
        }
        else
        {
            return "";
        }
    }
    public void SaveFile(string fileName, string data)
    {
        if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(data))
            fileName = "Text" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt";

        File.WriteAllText(fileName, data);
    }


}
