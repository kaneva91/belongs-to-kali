using System;

class ParseTags
{
    static string ToUpperBetweenTags(string text)
    {    
        string result = String.Empty;
        int startInd = text.IndexOf("<upcase>", 0);
        int endtInd = text.IndexOf("</upcase>", 0);
        string subString = String.Empty;
        string subStringUpper = String.Empty;
        while (startInd >= 0 || endtInd >= 0)
        {
            subString = text.Substring(startInd + 8, endtInd - startInd - 8);
            subStringUpper = subString.ToUpper();
            result = text.Replace(subString, subStringUpper);
            startInd = startInd = text.IndexOf("<upcase>", startInd + 1);
            endtInd = text.IndexOf("</upcase>", endtInd + 1);
            text = result; 
        }
        return result;
    }
    static string RemoveTags(string text, string removeItem, int pos)
    {
        string result = String.Empty;
        int ind = 0;
        do
        {
            ind = text.IndexOf(removeItem, ind);
            if (ind >= 0)
            {
                result = text.Remove(ind, pos);
                text = result;
            }
            else
            {
                break;
            }
        } while (ind >= 0);
        return text;
    }
    static void Main()
    {
        string text = Console.ReadLine();
        text = ToUpperBetweenTags(text);
       
        text = RemoveTags(text, "<upcase>", 8);
       
        text = RemoveTags(text, "</upcase>", 9);
        Console.WriteLine(text);
    }
}
