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
    public class PendingLanguage : AbstractSpringFestivalLanguage
    {
        public PendingLanguage()
        {
            data = new List<string>();
            Generator = new PendingLanguageGenerator();
        }

        public override string GetYearName()
        {
            return null;
        }

        protected override void InitData()
        {
            // Do nothing.
        }

        public override String InvokeLunarLanguageGenerator(int num)
        {
            return Generator.GenerateLunarLanguage(num, this);
        }

        private class PendingLanguageGenerator : AbstractSpringFestivalLanguage.ILunarLanguageGenerator
        {
            public String GenerateLunarLanguage(int num, AbstractSpringFestivalLanguage o)
            {
                CommonLanguage cl = new CommonLanguage();
                String s = cl.ConstructLanguage(3);
                return s;
            }
        }
    }

    public class MouseYear : PendingLanguage
    {
        public override string GetYearName()
        {
            return "鼠";
        }
    }

    public class MonkeyYear : PendingLanguage
    {
        public override string GetYearName()
        {
            return "猴";
        }
    }

    public class DogYear : PendingLanguage
    {
        public override string GetYearName()
        {
            return "狗";
        }
    }

    public class PigYear : PendingLanguage
    {
        public override string GetYearName()
        {
            return "猪";
        }
    }

    public class ChikenYear : PendingLanguage
    {
        public override string GetYearName()
        {
            return "鸡";
        }
    }

    public class RabbitYear : PendingLanguage
    {
        public override string GetYearName()
        {
            return "兔";
        }
    }

    public class SnakeYear : PendingLanguage
    {
        public override string GetYearName()
        {
            return "蛇";
        }
    }
}
