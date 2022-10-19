namespace Module;

public class StringUtility
{
    public bool IsLongStringV1(string input)
    {
        if (input.Length > 5)
            return true;

        return false;
    }

    public bool IsLongStringV2(string input)
    {
        return input.Length > 5;
    }
}