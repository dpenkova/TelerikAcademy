/* Write a program for extracting all email addresses from given text. All substrings that match 
 * the format <identifier>@<host>…<domain> should be recognized as emails.*/

using System;
using System.Text.RegularExpressions;

class ExtractEmailAddresses
{
    static void Main()
    {
        string input = @"vigic60@yahoo.com; vigi@yahho.com, , getmail@admin.bg admin@office-bg.bg ; vigi@yahho.com, , 
                        getmail@admin.bg admin@office-bg.bg, hayasko.com; akf, aofk, gmail.com, @gmail.com, 
                        glif.bgdf.sfsdf.@faa.vfg,;lk -dassda@fdsf.vds, assdfss@asdfsd.fsdf.fsf.fdsfs.dfsf.,     
                        dfssd,fdsf,fdsf.f_ds-fs@erfsd.vf'cvlv'zz,vb@cdf.vfghgfhcnvy, bxcvdfs, fdgdg,
                        dfghn-sdf_df@rfd.fdg.fsdgdfgdf.fsfsdf.fsdf";

        string regex = @"\b[A-Z0-9\.\-_]{1,49}\.*?([A-Z0-9\.\-_]+\.){0,49}@[^\s\._,;""']([A-Z0-9\-\.]{0,49}\.+[A-Z]{2,4})\b";
        //string regex = @"\b[A-Z0-9._%+-]+@(?:[A-Z0-9-]{0,49}\.)+[A-Z]{2,4}\b";
        //string regex = @"\b[A-Z0-9._%+-]+@(?:[A-Z0-9-]+\.)+[A-Z]{2,4}\b";

        MatchCollection matches = Regex.Matches(input, regex, RegexOptions.IgnoreCase);

        foreach (Match match in matches)
        {
            Console.WriteLine(match);
        }
    }
}