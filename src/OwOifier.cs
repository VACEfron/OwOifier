using System;
using System.Text.RegularExpressions;

namespace OwOifier
{
    public static class OwOifier
    {
        public static string OwOify(string Text, OwOMode OwOMode = OwOMode.High)
        {
            if (OwOMode == OwOMode.Low || OwOMode == OwOMode.Medium || OwOMode == OwOMode.High)
            {
                Text = Regex.Replace(Text, @"(?:R|L)", "W");
                Text = Regex.Replace(Text, @"(?:r|l)", "w");
            }
            if (OwOMode == OwOMode.Medium || OwOMode == OwOMode.High)
            {
                Text = Regex.Replace(Text, @"n([aeiou])", "ny");
                Text = Regex.Replace(Text, @"N([aeiou])", "Ny");
                Text = Regex.Replace(Text, @"N([AEIOU])", "NY");
                Text = Regex.Replace(Text, @"z ", "z~ ");
            }
            if (OwOMode == OwOMode.High)
            {
                Text = Regex.Replace(Text, @"OVE", "UV");
                Text = Regex.Replace(Text, @"ove", "uv");

                var r = new Random();
                string[] faces = {
                    "(o´∀`o)", "(#｀ε´)", "(๑•̀ㅁ•́๑)✧", "(*≧m≦*)", "(・`ω´・)", "UwU", "OwO", ">w<", "｡ﾟ( ﾟ^∀^ﾟ)ﾟ｡","ヾ(｀ε´)ﾉ",
                    "(´• ω •`)","o(>ω<)o","(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧", "(⁀ᗢ⁀)", "(￣ε￣＠)", "( 〃▽〃)", "(o^ ^o)", "ヾ(*'▽'*)"
                };

                Text = Regex.Replace(Text, "!", $" {faces[r.Next(faces.Length)]} ");
            }

            Text = Text.Replace("nyzzwes", "nuzzles~");

            return Text;
        }
    }

    public enum OwOMode
    {
        Low,
        Medium,
        High
    }
}
