/*
    The MIT License (MIT)

    Copyright (c) 2011-2015 Andy Cheung

    Permission is hereby granted, free of charge, to any person obtaining a copy
  of this software and associated documentation files (the "Software"), to deal
  in the Software without restriction, including without limitation the rights
  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
  copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
  copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
  SOFTWARE.
*/

using AC.WishesGenerator.Data.Common;
using System;
using System.Collections.Generic;

namespace AC.WishesGenerator.Data.SpringFestival
{
    public class SheepYear : AbstractSpringFestivalLanguage
    {
        public SheepYear()
        {
            data = new List<string>();
            Generator = new SheepYearGenerator();
        }
        protected override void InitData()
        {
            String mess = "三羊开泰,喜气洋洋,洋洋得意";
            String[] messArray = mess.Split(',');
            foreach (String s in messArray)
            {
                data.Add(s);
            }
        }

        public override String InvokeLunarLanguageGenerator(int num)
        {
            return Generator.GenerateLunarLanguage(num, this);
        }

        private class SheepYearGenerator : AbstractSpringFestivalLanguage.ILunarLanguageGenerator
        {
            public String GenerateLunarLanguage(int num, AbstractSpringFestivalLanguage o)
            {
                List<int> pos = o.GenerateNumbers(1);
                CommonLanguage cl = new CommonLanguage();
                String s = cl.ConstructLanguage(2);
                return o.Data[pos[0]] + "，" + s;
            }
        }

        public override string GetYearName()
        {
            return "羊";
        }
    }
}
