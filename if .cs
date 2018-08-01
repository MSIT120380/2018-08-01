using System;
enum 撲克牌花樣 { 梅花, 紅心, 鑽石, 黑桃 }

class Program
{
    static void Main(string[] args)
    {

        string 顏色 = "未知顏色";
        撲克牌花樣 trumps;
        Console.WriteLine();
        trumps = 撲克牌花樣.鑽石;
        string str = "ktm";
        str = trumps.ToString();
        Console.Write("trumps:     " + trumps);
        // fix #1
        if (trumps == 撲克牌花樣.梅花)
            顏色 = "黑色";
        else
        if (trumps == 撲克牌花樣.紅心)
            顏色 = "紅色";
        else
        if (trumps == 撲克牌花樣.鑽石)
            顏色 = "紅色";
        else
        if (trumps == 撲克牌花樣.黑桃)
            顏色 = "黑色";

        //if (trumps == 撲克牌花樣.梅花)
        //    顏色 = "黑色";
        //else if (trumps == 撲克牌花樣.紅心)
        //    顏色 = "紅色";
        //else if (trumps == 撲克牌花樣.鑽石)
        //    顏色 = "紅色";
        //else if (trumps == 撲克牌花樣.黑桃)
        //    顏色 = "黑色";




        Console.WriteLine();
        Console.WriteLine("顏色:   " + 顏色);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
}
