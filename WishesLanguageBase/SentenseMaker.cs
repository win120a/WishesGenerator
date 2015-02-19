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
using AC.WishesGenerator.Data.NewYearsDay;
using AC.WishesGenerator.Data.SpringFestival;
using System;

namespace AC.WishesGenerator.Data
{
    public class SentenseMaker
    {
        public static String MakeSentense(String who, AbstractLanguage al)
        {
            // Format:
            // {对方名字}，祝{您或你}{生肖}年快乐，{生肖特定祝福语}，{通用祝福语1}，{通用祝福语2}！
            // {对方名字}，祝{您或你}{年份}新年快乐，{通用祝福语1}，{通用祝福语2}，{通用祝福语3}！
            // is
            String mess = "";
            if (al is AbstractSpringFestivalLanguage)
            {
                String baseMessage = "{0}，祝{您或你}{1}年快乐，{2}！";
                String midMess = baseMessage.Replace("{0}", who)
                                              .Replace("{1}", ((AbstractSpringFestivalLanguage) al).GetYearName());
                String finalMess = midMess.Replace("{2}", al.ConstructLanguage(3));
                mess = finalMess;
                return mess;
            }
            else if (al is CommonLanguage)
            {
                String baseMess = "{0}，祝{您或你}{1}新年快乐，{2}！";
                String midMess = baseMess.Replace("{0}", who);
                int yr = DateTime.Now.Year;
                String nearFinalMess = midMess.Replace("{1}", yr + "年");
                String finalmess = nearFinalMess.Replace("{2}", al.ConstructLanguage(3));
                return finalmess;
            }
            else if (al is NewYearsDayLanguage)
            {
                mess = al.ConstructLanguage(3).Replace("XXX", who);
                return mess;
            }
            return null;
        }
    }
}
