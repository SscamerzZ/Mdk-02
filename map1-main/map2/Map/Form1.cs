using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
        }

        private void Checkpoint1_Click(object sender, EventArgs e)
        {
            Header2.Text = "Чекпоинт 1";
            Header.Text = "МЦК Лужники"; 

            Energy_Bars_img.Visible = true;
            labelEnergy_bars.Visible = true;
            Drinks_img.Visible = true;
            labelDrinks.Visible = true;

            Toilets_img.Visible = false;
            labelToilet.Visible = false;
            Medical_img.Visible = false;
            labelMedical.Visible = false;
            Information_img.Visible = false;
            labelInformation.Visible = false;

            Medical_img.Location = new Point(601, 412);
            labelMedical.Location = new Point(681, 439);
            Header2.Visible = true;
            panel1.Visible = true;


        }

        private void Checkpoint2_Click(object sender, EventArgs e)
        {
            Header2.Text = "Чекпоинт 2";
            Header.Text = "Новодевичей монастырь";
            Energy_Bars_img.Visible = true;
            labelEnergy_bars.Visible = true;
            Drinks_img.Visible = true;
            labelDrinks.Visible = true;
            Toilets_img.Visible = true;
            labelToilet.Visible = true;
            Medical_img.Visible = true;
            labelMedical.Visible = true;
            Information_img.Visible = true;
            labelInformation.Visible = true;
            Header2.Visible = true;
            panel1.Visible = true;


            Medical_img.Location = new Point(601, 412);
            labelMedical.Location = new Point(681, 439);

        }

        private void Checkpoint3_Click(object sender, EventArgs e)
        {
            Header2.Text = "Чекпоинт 3";
            Header.Text = "Метро Киевская";
            Toilets_img.Visible = true;
            labelToilet.Visible = true;
            Energy_Bars_img.Visible = true;
            labelEnergy_bars.Visible = true;
            Drinks_img.Visible = true;
            labelDrinks.Visible = true;

            Medical_img.Visible = false;
            labelMedical.Visible = false;
            Information_img.Visible = false;
            labelInformation.Visible = false;
            Header2.Visible = true;
            panel1.Visible = true;



            Medical_img.Location = new Point(601, 412);
            labelMedical.Location = new Point(681, 439);

        }

        private void Checkpoint4_Click(object sender, EventArgs e)
        {
            Header2.Text = "Чекпоинт 4";
            Header.Text = "МИД";
            Toilets_img.Visible = true;
            labelToilet.Visible = true;
            Energy_Bars_img.Visible = true;
            labelEnergy_bars.Visible = true;
            Drinks_img.Visible = true;
            labelDrinks.Visible = true;
            Medical_img.Visible = true;
            labelMedical.Visible = true;

            Information_img.Visible = false;
            labelInformation.Visible = false;
            Header2.Visible = true;
            panel1.Visible = true;


            Medical_img.Location = new Point(601, 330);
            labelMedical.Location = new Point(681, 358);
        }

        private void Checkpoint5_Click(object sender, EventArgs e)
        {
            Header2.Text = "Чекпоинт 5";
            Header.Text = "Парк Горького";
            Toilets_img.Visible = true;
            labelToilet.Visible = true;
            Energy_Bars_img.Visible = true;
            labelEnergy_bars.Visible = true;
            Drinks_img.Visible = true;
            labelDrinks.Visible = true;
            Information_img.Visible = true;
            labelInformation.Visible = true;
           
            Medical_img.Visible = false;
            labelMedical.Visible = false;
            Header2.Visible = true;
            panel1.Visible = true;


            Medical_img.Location = new Point(601, 412);
            labelMedical.Location = new Point(681, 439);
        }

        private void Checkpoint6_Click(object sender, EventArgs e)
        {
            Header2.Text = "Чекпоинт 6";
            Header.Text = "Здания РАН";
            Toilets_img.Visible = true;
            labelToilet.Visible = true;
            Energy_Bars_img.Visible = true;
            labelEnergy_bars.Visible = true;
            Drinks_img.Visible = true;
            labelDrinks.Visible = true;

            Medical_img.Visible = false;
            labelMedical.Visible = false;
            Information_img.Visible = false;
            labelInformation.Visible = false;
            Header2.Visible = true;
            panel1.Visible = true;


            Medical_img.Location = new Point(601, 412);
            labelMedical.Location = new Point(681, 439);
        }

        private void Checkpoint7_Click(object sender, EventArgs e)
        {
            Header2.Text = "Чекпоинт 7";
            Header.Text = "Метро Воробевы горы";
            Energy_Bars_img.Visible = true;
            labelEnergy_bars.Visible = true;
            Drinks_img.Visible = true;
            labelDrinks.Visible = true;
            Toilets_img.Visible = true;
            labelToilet.Visible = true;
            Medical_img.Visible = true;
            labelMedical.Visible = true;
            Information_img.Visible = true;
            labelInformation.Visible = true;
            Header2.Visible = true;
            panel1.Visible = true;

            Medical_img.Location = new Point(601, 412);
            labelMedical.Location = new Point(681, 439);
        }

        private void Checkpoint8_Click(object sender, EventArgs e)
        {
            Header2.Text = "Чекпоинт 8";
            Header.Text = "Стадион Лужники";
            Energy_Bars_img.Visible = true;
            labelEnergy_bars.Visible = true;
            Drinks_img.Visible = true;
            labelDrinks.Visible = true;
            Toilets_img.Visible = true;
            labelToilet.Visible = true;
            Medical_img.Visible = true;
            labelMedical.Visible = true;
            Information_img.Visible = true;
            labelInformation.Visible = true;
            Header2.Visible = true;
            panel1.Visible = true;


            Medical_img.Location = new Point(601, 412);
            labelMedical.Location = new Point(681, 439);
        }

        private void Start1_img_Click(object sender, EventArgs e)
        {
            Header.Text = "Начало забега\n";
            Energy_Bars_img.Visible = false;
            labelEnergy_bars.Visible = false;
            Drinks_img.Visible = false;
            labelDrinks.Visible = false;
            Toilets_img.Visible = false;
            labelToilet.Visible = false;
            Medical_img.Visible = false;
            labelMedical.Visible = false;
            Information_img.Visible = false;
            labelInformation.Visible = false;
            Header2.Visible = false;
            panel1.Visible = true;
        }

        private void Start2_img_Click(object sender, EventArgs e)
        {
            Header.Text = "Начало забега\n";
            Energy_Bars_img.Visible = false;
            labelEnergy_bars.Visible = false;
            Drinks_img.Visible = false;
            labelDrinks.Visible = false;
            Toilets_img.Visible = false;
            labelToilet.Visible = false;
            Medical_img.Visible = false;
            labelMedical.Visible = false;
            Information_img.Visible = false;
            labelInformation.Visible = false;
            Header2.Visible = false;
            panel1.Visible = true;
        }

        private void Start3_img_Click(object sender, EventArgs e)
        {            
            Header.Text = "Начало забега\n";
            Energy_Bars_img.Visible = false;
            labelEnergy_bars.Visible = false;
            Drinks_img.Visible = false;
            labelDrinks.Visible = false;
            Toilets_img.Visible = false;
            labelToilet.Visible = false;
            Medical_img.Visible = false;
            labelMedical.Visible = false;
            Information_img.Visible = false;
            labelInformation.Visible = false;
            Header2.Visible = false;
            panel1.Visible = true;
        }

        private void Interactive_Map_Click(object sender, EventArgs e)
        {

        }

        private void labelEnergy_bars_Click(object sender, EventArgs e)
        {

        }

        private void Header_Click(object sender, EventArgs e)
        {

        }

        private void Header2_Click_1(object sender, EventArgs e)
        {

        }

        private void Energy_Bars_img_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
