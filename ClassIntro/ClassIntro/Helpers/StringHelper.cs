namespace ClassIntro.Helpers;

public static class StringHelper
{
    public static string Left(string text, int pos)
    {
        return text[..pos];
    }

    public static string Right(string text, int pos)
    {
        return text[^pos..];
    }

    public static string Mid(string text, int pos, int length)
    {
        return text.Substring(pos, length);
    }
}