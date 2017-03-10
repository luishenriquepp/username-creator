using System;

public static class SplitFullname
{
    public static string[] Get(string fullName)
    {
        var spliced = fullName.Split(' ');
        if(spliced.Length < 2)
            throw new Exception("The name must have a second name");
        return spliced;
    }
}