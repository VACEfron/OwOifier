using System;
using System.Text.RegularExpressions;

namespace OwOifier
{
    public static class OwOifier
    {
        public static string OwOify(string text, OwOMode OwOMode = OwOMode.High)
        {
            text = Regex.Replace(text, @"(?:R|L)", "W");
            text = Regex.Replace(text, @"(?:r|l)", "w");

            if (OwOMode == OwOMode.Medium || OwOMode == OwOMode.High)
            {
                text = Regex.Replace(text, @"n([aeiou])", "ny$1");
                text = Regex.Replace(text, @"N([aeiou])", "Ny$1");
                text = Regex.Replace(text, @"N([AEIOU])", "NY$1");
                text = Regex.Replace(text, @"z ", "z~ ");
            }
            if (OwOMode == OwOMode.High)
            {
                text = Regex.Replace(text, @"OVE", "UV");
                text = Regex.Replace(text, @"ove", "uv");

                var r = new Random();
                string[] faces = {
                    "(o´∀`o)", "(#｀ε´)", "(๑•̀ㅁ•́๑)✧", "(*≧m≦*)", "(・`ω´・)", "UwU", "OwO", ">w<", "｡ﾟ( ﾟ^∀^ﾟ)ﾟ｡","ヾ(｀ε´)ﾉ",
                    "(´• ω •`)","o(>ω<)o","(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧", "(⁀ᗢ⁀)", "(￣ε￣＠)", "( 〃▽〃)", "(o^ ^o)", "ヾ(*'▽'*)"
                };

                text = Regex.Replace(text, "!", $" {faces[r.Next(faces.Length)]} ");

                text = text
                .Replace("nyzzwes", "nuzzles~")
                .Replace("ahh", "murr")
                .Replace("awesome", "pawsome")
                .Replace("awfuw", "pawful")
                .Replace("bite", "nuzzles~")
                .Replace("bite", "nom")
                .Replace("buwge", "bulgy-wulgy")
                .Replace("butthowe", "tailhole")
                .Replace("cewebwity", "popufur")
                .Replace("cheese", "sergal")
                .Replace("chiwd", "cub")
                .Replace("computew", "protogen")
                .Replace("wobot", "protogen")
                .Replace("cybowg", "protogen")
                .Replace("cum", "cummy wummy~")
                .Replace("disease", "pathOwOgen")
                .Replace("dog", "good boy")
                .Replace("dwagon", "derg")
                .Replace("eat", "vore")
                .Replace("fuck", "fluff")
                .Replace("fathew", "daddy")
                .Replace("foot", "footpaw")
                .Replace("fow", "fur")
                .Replace("hand", "paw")
                .Replace("heww", "hecc")
                .Replace("hyenya", "yeen")
                .Replace("kiss", "lick")
                .Replace("wmao", "hehe~")
                .Replace("mouth", "maw")
                .Replace("nyaughty", "knotty")
                .Replace("nyot", "knot")
                .Replace("pewfect", "purrfect")
                .Replace("pewsona", "fursona")
                .Replace("pewvewt", "furvert")
                .Replace("pown", "yiff")
                .Replace("shout", "awoo")
                .Replace("swut", "fox")
                .Replace("souwce", "saunce")
                .Replace("stwaight", "gay")
                .Replace("tawe", "tail")
                .Replace("the", "teh")
                .Replace("this", "dis")
                .Replace("toe", "toe been")
                .Replace("with", "wif")
                .Replace("you", "chu")
                .Replace("youw", "ur")
                .Replace(",", "~")
                .Replace(";", "~")
                .Replace(":)", ":3")
                .Replace(":O", "OwO")
                .Replace(":o", "owo")
                .Replace(":D", "UwU")
                .Replace("XD", "X3")
                .Replace("xD", "x3")
                .Replace("?", " uwu?");
            }            

            return text;
        }
    }

    public enum OwOMode
    {
        Low,
        Medium,
        High
    }
}
