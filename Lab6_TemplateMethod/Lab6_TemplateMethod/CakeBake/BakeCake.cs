using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_TemplateMethod.CakeBake
{
    abstract class BakeCake
    {
        public string Size { get; set; }
        public string Form { get; set; }
        public int Weight { get; set; }
        public BakeCake(string size, string form, int weight)
        {
            Size = size;
            Form = form;
            Weight = weight;
        }
        public void TemplateMethod()
        {
            PrepareWorkplace();
            Cake();
            AddCream();
            PutInFridge();
            GetCake(Size, Form, Weight);
        }
        public void PrepareWorkplace()
        {
            Console.WriteLine("Готовим место: прибираем стол, подготавливаем инструменты.");
        }
        public void Cake()
        {
            Console.WriteLine("Печем коржи для будущего торта.");
        }
        public void PutInFridge()
        {
            Console.WriteLine("Уже положили торт в холодильник. Сейчас заморозим крем и торт будет подан к столу.");
        }
        public void GetCake(string s, string f, int w)
        {
            Size = s;
            Form = f;
            Weight = w;
            Console.WriteLine("Получили {0} {1} торт на {2}г", s, f, w);
        }
        public abstract void AddCream();
    }
}
