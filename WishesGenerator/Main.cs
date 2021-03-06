﻿/*
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

using AC.WishesGenerator.Data;
using AC.WishesGenerator.Data.Common;
using AC.WishesGenerator.Data.NewYearsDay;
using AC.WishesGenerator.Data.SpringFestival;
using System;
using System.Windows.Forms;

namespace WishesGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (name.Text.Equals("") || type.Text.Equals(""))
            {
                MessageBox.Show("请填完所有的空");
                return;
            }
            switch (type.Text)
            {
                case "通用句式":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new CommonLanguage());
                    break;

                case "通用句式（不带年份）":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new NewYearsDayLanguage());
                    break;

                case "鼠年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new MouseYear());
                    break;

                case "牛年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new CowYear());
                    break;

                case "虎年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new TigerYear());
                    break;

                case "兔年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new RabbitYear());
                    break;

                case "龙年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new DragonYear());
                    break;

                case "蛇年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new SnakeYear());
                    break;

                case "马年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new HorseYear());
                    break;

                case "羊年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new SheepYear());
                    break;

                case "猴年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new MonkeyYear());
                    break;

                case "鸡年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new ChickenYear());
                    break;

                case "狗年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new DogYear());
                    break;

                case "猪年":
                    textBox1.Text = "";
                    textBox1.Text = SentenseMaker.MakeSentense(name.Text, new PigYear());
                    break;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void about_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
