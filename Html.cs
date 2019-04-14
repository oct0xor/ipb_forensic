using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NulledViewer
{
    static class Html
    {
        public static string GetStart()
        {
            return @"<html> <head> <title>Intro</title> <style> h1, h2, h3 { color: navy; font-weight:normal; } h1 { margin-bottom: .47em } h2 { margin-bottom: .3em }
                    h3 { margin-bottom: .4em } ul { margin-top: .5em } ul li {margin: .25em} body { font:10pt Tahoma } pre  { border:solid 1px gray; background-color:#eee; padding:1em }
                    a:link { text-decoration: none; } a:hover { text-decoration: underline; } .gray    { color:gray; } .example { background-color:#efefef; corner-radius:5px; padding:0.5em; }
                    .whitehole { background-color:#" + Properties.Settings.Default.background + @"; corner-radius:10px; padding:15px; } .caption { font-size: 1.1em } .comment { color: green; margin-bottom: 5px; margin-left: 3px; }
                    .comment2 { color: green; } </style>
                    </head> <body style=""background-color: #" + Properties.Settings.Default.gradient1 + @"; background-gradient: #" + Properties.Settings.Default.gradient2 + @"; background-gradient-angle: 60; margin: 0;"">";
        }

        public static string GetEnd()
        {
            return @"</body></html>";
        }

        public static string GetElement(string text1, string text2)
        {
            return @"<blockquote class=""whitehole"">
                        <p style=""margin-top: 0px"">
                            <table border=""0"" width=""100%"">
                                <tr style=""vertical-align: top; color:#" + Properties.Settings.Default.color + @""">
                                    <td width=""50"" style=""padding: 2px 5px 0 0"">
                                        " + text1 + @"
                                    </td>
                                    <td>
                                        " + text2 + @"
                                    </td>
                                </tr>
                            </table>
                        </p>
                    </blockquote>";
        }
    }
}
