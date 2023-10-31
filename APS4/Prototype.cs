using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace APS4
{
    public abstract class CarPrototype
    {
        private string Name { get; set; }
        private string VIN { get; set; }
        private string TypeC { get; set; }
        private string YearCr { get; set; }
        private string Color { get; set; }
        private string EnginePower { get; set; }
        public CarPrototype(string Name, string VIN, string TypeC, string YearCr, string Color, string EnginePower)
        {
            this.Name = Name;
            this.VIN = VIN;
            this.TypeC = TypeC;
            this.YearCr = YearCr;
            this.Color = Color;
            this.EnginePower = EnginePower;

        }
        public void EditName(string Name)
        {
            this.Name = Name;
        }
        public void EditVIN(string VIN)
        {
            this.VIN = VIN;
        }
        public void EditTypeC(string TypeC)
        {
            this.TypeC = TypeC;
        }
        public void EditYearCr(string YearCr)
        {
            this.YearCr = YearCr;
        }
        public void EditColor(string Color) 
        {  
            this.Color = Color; 
        }
        public void EditEnginePower(string EnginePower)
        {
            this.EnginePower= EnginePower;
        }
        public string GetName() 
        { 
            return this.Name; 
        }
        public string GetVIN()
        {
            return this.VIN;
        }
        public string GetTypeC()
        {
            return this.TypeC;
        }
        public string GetYearCr()
        {
            return this.YearCr;
        }
        public string GetColor()
        {
            return this.Color;
        }
        public string GetEnginePower()
        {
            return this.EnginePower;
        }
        public string GetInfo()
        {
            string result = null;
            if (this.Name != null)
            {
                result += this.Name + ":\n";
            }
            if (VIN != null)
            {
                result += "VIN: " + this.VIN + "\n";
            }
            if (this.TypeC != null)
            {
                result += "Тип ТС: " + this.TypeC + "\n";
            }
            if (this.YearCr != null)
            {
                result += "Год выпуска: " + this.YearCr + " год" + "\n";
            }
            if (Color != null)
            {
                result += "Цвет: " + this.Color + "\n";
            }
            if (EnginePower != null)
            {
                result += "Мощность двигателя: " + this.EnginePower + " л.с." + "\n";
            }

            return result;
        }
        public virtual CarPrototype Clone()
        {
            return (CarPrototype)this.MemberwiseClone();
        }
    }
    public class BMW_X5: CarPrototype
    {
        public BMW_X5(string Name, string VIN, string TypeC, string YearCr, string Color, string EnginePower) :
            base(Name, VIN, TypeC, YearCr, Color, EnginePower) { } 
        public override CarPrototype Clone()
        {
            return (CarPrototype)this.MemberwiseClone();
        }
    }
    public class Toyota_Camry : CarPrototype
    {
        public Toyota_Camry(string Name, string VIN, string TypeC, string YearCr, string Color, string EnginePower) :
           base(Name, VIN, TypeC, YearCr, Color, EnginePower)
        { }
        public override CarPrototype Clone()
        {
            return (CarPrototype)this.MemberwiseClone();
        }
    }
    public class Kia_Rio : CarPrototype
    {
        public Kia_Rio(string Name, string VIN, string TypeC, string YearCr, string Color, string EnginePower) :
           base(Name, VIN, TypeC, YearCr, Color, EnginePower)
        { }
        public override CarPrototype Clone()
        {
            return (CarPrototype)this.MemberwiseClone();
        }
    }
    public class Subaru_Legacy : CarPrototype
    {
        public Subaru_Legacy(string Name, string VIN, string TypeC, string YearCr, string Color, string EnginePower) :
           base(Name, VIN, TypeC, YearCr, Color, EnginePower)
        { }
        public override CarPrototype Clone()
        {
            return (CarPrototype)this.MemberwiseClone();
        }
    }
    public class Factory
    {
        public BMW_X5 bMW_X5;
        public Toyota_Camry toyota_Camry;
        public Kia_Rio kia_Rio;
        public Subaru_Legacy subaru_Legacy;

        private int[] col = new int[4] { 0, 0, 0, 0 };

        private List<CarPrototype> cars = new List<CarPrototype>();

        public Factory()
        {

            bMW_X5 = new BMW_X5("Прототип БМВ X5", "WBAFB335X1LH13517","Универсал","2000", "Чёрный", "210");

            toyota_Camry = new Toyota_Camry("Прототип Тойота Camry", "1FTEX1CP3JFA13968", "Седан", "2005", "Белый", "123");

            kia_Rio = new Kia_Rio("Прототип Киа Рио", "KNEDE244286326229", "Седан", "2010", "Синий", "109");

            subaru_Legacy = new Subaru_Legacy("Прототип Субару Легаси", "JF1SHJLW1BG123456", "Универсал", "2002", "Жёлтый", "100");

        }

        public BMW_X5 RegisterBMW()
        {
            BMW_X5 bmW = (BMW_X5)bMW_X5.Clone();
            bmW.EditName($"{col[0] +1} копия БМВ X5");
            cars.Add(bmW);
            col[0] += 1;
            return bmW;
        }

        public Toyota_Camry RegisterToyota()
        {
            Toyota_Camry toyota_cam= (Toyota_Camry)toyota_Camry.Clone();
            toyota_cam.EditName($"{col[1] + 1} копия Тойота Camry");
            cars.Add(toyota_cam);
            col[1] += 1;
            return toyota_Camry;
        }

        public Kia_Rio RegisterKia()
        {
            Kia_Rio kia_R = (Kia_Rio)kia_Rio.Clone();
            kia_R.EditName($"{col[2] + 1} копия Киа Рио");
            cars.Add(kia_R);
            col[2] += 1;
            return kia_Rio;
        }

        public Subaru_Legacy RegisterSubaru()
        {
            Subaru_Legacy subaru_Leg = (Subaru_Legacy)subaru_Legacy.Clone();
            subaru_Leg.EditName($"{col[3] + 1} копия Субару Legacy");
            cars.Add(subaru_Leg);
            col[3] += 1;
            return subaru_Legacy;
        }

        public List<CarPrototype> GetList()
        {
            return cars;
        }

        public void Delete(int i)
        {
            cars.RemoveAt(i);
        }

        public void AllDelete()
        {
            cars= new List<CarPrototype>();
            col = new int[4] { 0, 0, 0, 0 };
        }
    }
}
