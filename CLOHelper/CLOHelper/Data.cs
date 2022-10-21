namespace CLOHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Data
{
    internal static Dictionary<string, string> GetMenu()
    {
        Dictionary<string, string> MenuUrls = new();
        MenuUrls.Add("1 - kolla på kalendern", "https://calendar.google.com/calendar/u/0/r?cid=c_classroom1a70e269@group.calendar.google.com");
        MenuUrls.Add("2 - Delta i Meet lektion", "https://meet.google.com/zix-upzh-ggz?authuser=0");
        MenuUrls.Add("3 - kolla på kursplanen", "https://docs.google.com/document/d/1w9B4-1452O596mJhThIpUGX9Grlp_Y91FQBhDpZk8ws/edit");
        MenuUrls.Add("4 - kolla på github repot för CLO22", "https://github.com/Campus-Molndal-CLO22");
        MenuUrls.Add("5 - kolla på github repot med live kodning", "https://github.com/Campus-Molndal-CLO22/Lektionsmaterial");
        MenuUrls.Add("6 - kolla på github repot med kodexempel", "https://github.com/Campus-Molndal-CLO22/Kodexempel");
        MenuUrls.Add("7 - kolla på Campus Mölndals hemsida", "https://www.molndal.se/campus-molndal.html");
        MenuUrls.Add("8 - kolla på Campus Mölndals facebook sida", "https://www.facebook.com/campusmolndal");
        MenuUrls.Add("9 - kolla på Campus Mölndals instagram sida", "https://www.instagram.com/yh_campusmolndal/");
        MenuUrls.Add("CTRL + C - Avsluta", "");
        return MenuUrls;
    }
}
