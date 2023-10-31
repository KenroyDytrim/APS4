using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS4
{
    public partial class Form1 : Form
    {
        Factory CarManager = new Factory();
        public Form1()
        {
            InitializeComponent();
        }

        private void PrototypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PrototypeBox.Text)
            {
                case "BMW X5":
                    {
                        richTextBox1.Text = CarManager.bMW_X5.GetInfo();

                        unsafe
                        {

                            var v = CarManager.bMW_X5;
                            int* g = (int*)&v;

                            textPrototype.Text = Convert.ToString(*g);
                        }

                        break;
                    }
                case "Toyota Camry":
                    {
                        richTextBox1.Text = CarManager.toyota_Camry.GetInfo();

                        unsafe
                        {

                            var v = CarManager.toyota_Camry;
                            int* g = (int*)&v;

                            textPrototype.Text = Convert.ToString(*g);
                        }

                        break;
                    }
                case "Kia Rio":
                    {
                        richTextBox1.Text = CarManager.kia_Rio.GetInfo();

                        unsafe
                        {

                            var v = CarManager.kia_Rio;
                            int* g = (int*)&v;

                            textPrototype.Text = Convert.ToString(*g);
                        }

                        break;
                    }
                case "Subaru Legacy":
                    {
                        richTextBox1.Text = CarManager.subaru_Legacy.GetInfo();

                        unsafe
                        {

                            var v = CarManager.subaru_Legacy;
                            int* g = (int*)&v;

                            textPrototype.Text = Convert.ToString(*g);
                        }

                        break;
                    }
            }
        }

        private void Clone_Click(object sender, EventArgs e)
        {
            listCars.Items.Clear();


            switch (PrototypeBox.Text)
            {
                case "BMW X5":
                    {
                        CarManager.RegisterBMW();

                        foreach (var s in CarManager.GetList())
                        {
                            listCars.Items.Add(s.GetName());
                        }
                        break;
                    }
                case "Toyota Camry":
                    {
                        CarManager.RegisterToyota();

                        foreach (var s in CarManager.GetList())
                        {
                            listCars.Items.Add(s.GetName());
                        }
                        break;
                    }
                case "Kia Rio":
                    {
                        CarManager.RegisterKia();

                        foreach (var s in CarManager.GetList())
                        {
                            listCars.Items.Add(s.GetName());
                        }
                        break;
                    }
                case "Subaru Legacy":
                    {
                        CarManager.RegisterSubaru();

                        foreach (var s in CarManager.GetList())
                        {
                            listCars.Items.Add(s.GetName());
                        }
                        break;
                    }
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            int i = listCars.SelectedIndex;

            CarManager.GetList()[i].EditVIN($"{textVIN.Text}");
            CarManager.GetList()[i].EditTypeC($"{textTypeC.Text}");
            CarManager.GetList()[i].EditYearCr($"{textYearCr.Text}");
            CarManager.GetList()[i].EditColor($"{textColor.Text}");
            CarManager.GetList()[i].EditEnginePower($"{textEnginePower.Text}");
            richTextBox1.Text = CarManager.GetList()[i].GetInfo();
        }

        private void listCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listCars.SelectedIndex;
            
            richTextBox1.Text = CarManager.GetList()[i].GetInfo();
            textVIN.Text = CarManager.GetList()[i].GetVIN();
            textTypeC.Text = CarManager.GetList()[i].GetTypeC();
            textYearCr.Text = CarManager.GetList()[i].GetYearCr();
            textColor.Text = CarManager.GetList()[i].GetColor();
            textEnginePower.Text = CarManager.GetList()[i].GetEnginePower();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            int i = listCars.SelectedIndex;

            CarManager.Delete(i);

            listCars.Items.Clear();
            foreach (var s in CarManager.GetList())
            {
                listCars.Items.Add(s.GetName());
            }
        }

        private void AllDelete_Click(object sender, EventArgs e)
        {
            CarManager.AllDelete();

            listCars.Items.Clear();
            foreach (var s in CarManager.GetList())
            {
                listCars.Items.Add(s.GetName());
            }
        }

        private Factory GetCarManager()
        {
            return CarManager;
        }

        private void Address_Click(object sender, EventArgs e)
        {
            int i = listCars.SelectedIndex;

            var A = CarManager.GetList()[i].getAddress();

            unsafe
            {

                var v = CarManager.GetList()[i];
                int* g = (int*)&v;

                textAddress.Text = Convert.ToString(*g);
            }

        }
    }
}
