using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;
/*
public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        string pattern = "\\W";

        string data = Regex.Replace(word.ToLower(), pattern, String.Empty);

        if (data == StringHelper.ReverseString(data))
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    static class StringHelper
    {
        /// <summary>
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

    }
    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));

    }*/

/*
public class TextInput
{
    public IList<char> list = new List<char>();

    public virtual void Add(char c)
    {
        list.Add(c);
    }

    public string GetValue()
    {
        string r = "";
        foreach (char l in list)
        {
            r = r + l;
        }
        return r;
    }
}

public class NumericInput : TextInput
{
    public override void Add(char c)
    {
        if (c < '0' || c > '9') { }
        else
            list.Add(c);
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        Console.WriteLine(input.GetValue());
    }
}
*/
/*folders

public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {
        List<string> elem = new List<string>();

        XmlDocument xmldoc = new XmlDocument();
        xmldoc.LoadXml(xml);

        foreach (XmlAttribute folderName in xmldoc.SelectNodes("//folder/@name[starts-with(., '" + startingLetter + "')]"))
        {
            elem.Add(folderName.Value);
            Console.WriteLine(folderName.Value);
        }

        return elem;
    }

    public static void Main(string[] args)
    {
        string xml =
            "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
            "<folder name=\"c\">" +
                "<folder name=\"program files\">" +
                    "<folder name=\"uninstall information\" />" +
                "</folder>" +
                "<folder name=\"users\" />" +
            "</folder>";

        foreach (string name in Folders.FolderNames(xml, 'u'))
        {
            Console.WriteLine(name);
            
        }
            
    }
}
*/
//path

public class Path
{
    public string CurrentPath { get; private set; }

    public Path(string path)
    {
        this.CurrentPath = path;
    }

    public void Cd2(string newPath)
    {
        String[] newP = newPath.Split('/');
        String[] oldP = CurrentPath.Split('/');
        int lnCount = 0;
        foreach (String str in newP)
        {
            if (str.Equals(".."))
            {
                lnCount++;
            }
        }

        int len = oldP.Length;
        String strOut = "";
        for (int i = 0; i < len - lnCount; i++)
        {
            strOut = strOut + oldP[i] + "/";
        }

        len = newP.Length;
        for (int i = 0; i < len; i++)
        {
            if (!newP[i].Equals(".."))
            {
                strOut = strOut + newP[i] + "/";
            }
        }
        CurrentPath = strOut.Substring(0, strOut.Length - 1);
        Console.WriteLine(CurrentPath);
        
    }

    
    

    public static void Main(string[] args)
    {
        Path path = new Path("/a/b/c/d");
        path.Cd2("../x");
        Console.WriteLine(path.CurrentPath);
    }
}