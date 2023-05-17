using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice15
{
    class Class1
    {
        private string ykazatel;
        private string word;
        private int num_of_page;

        public string Ykazatel { get { return ykazatel; } set { ykazatel = value; } }
        public string Word { get { return word; } set { word = value; } }
        public int Num_of_page { get { return num_of_page; } set { num_of_page = value; } }


        public void Zad6(string ykazatel, int num_of_page, string word)
        {
            this.ykazatel = ykazatel;
            this.num_of_page = num_of_page;
            this.word = word;
        }

        public string Info()
        {
            return "Указатель:" + ykazatel + "Заданное слово: " + word + "Номер страниц/ы: " + num_of_page;
        }

        public void Delete()
        {

        }
    }
}
