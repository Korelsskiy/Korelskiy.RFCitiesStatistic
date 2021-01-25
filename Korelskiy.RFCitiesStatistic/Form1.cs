﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korelskiy.RFCitiesStatistic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            SetDataGrid();
        }

        private void SetDataGrid()
        {
            citiesDataGridView.ForeColor = Color.Black;
            citiesDataGridView.DataSource = new City().GetCitiesFromDb();
            for (int i = 0; i < citiesDataGridView.Columns.Count; i++)
            {
                if (i == 0)
                {
                    citiesDataGridView.Columns[i].Width = 30;
                }
                else if(i == 4 || i == 5)
                {
                    citiesDataGridView.Columns[i].Width = 175;
                }
                else if (i == 2)
                {
                    citiesDataGridView.Columns[i].Width = 80;
                }
                else if(i == 3)
                {
                    citiesDataGridView.Columns[i].Width = 110;
                }
                else if(i == 1)
                {
                    citiesDataGridView.Columns[i].Width = 150;
                }
            }
        }
        private bool Validation( int firstYear,  int secondYear,  int firstYearPopulation,  int secondYearPopulation)
        {
            if (string.IsNullOrWhiteSpace(cityNameTextBox.Text))
            {
                MessageBox.Show("Не верно введено название города");
                return false;
            }
            if (!int.TryParse(firstYearTextBox.Text, out firstYear) || !int.TryParse(secondYearTextBox.Text, out secondYear))
            {
                MessageBox.Show("Года введены не верно");
                return false;
            }
           
            if (!int.TryParse(firstYearPopulationTextBox.Text, out firstYearPopulation) || !int.TryParse(secondYearPopulationTextBox.Text, out secondYearPopulation))
            {
                MessageBox.Show("Население введено не верно");
                return false;
            }
            if (firstYear >= secondYear)
            {
                MessageBox.Show("Год конца измерения должен быть позже начального");
                return false;
            }
            

            return true;
        }
        private void addCityButton_Click(object sender, EventArgs e)
        {
            int firstYear = 0;
            int secondYear = 0;
            int firstYearPopulation = 0;
            int secondYearPopulation = 0;

            if (Validation(firstYear, secondYear, firstYearPopulation, secondYearPopulation))
            {
                SetLabels(firstYear, secondYear, firstYearPopulation, secondYearPopulation);

                if (!addToDbCheckBox.Checked)
                {
                    if (AddCityToDb())
                    {
                        citiesDataGridView.DataSource = new City().GetCitiesFromDb();

                        MessageBox.Show("Город добавлен в базу данных");
                    }
                }
                
                

                
            }
        }

        private void ClearLables()
        {
            cityNameTextBox.Text = "";
            firstYearTextBox.Text = "";
            secondYearTextBox.Text = "";
            firstYearPopulationTextBox.Text = "";
            secondYearPopulationTextBox.Text = "";

        }

        private bool AddCityToDb()
        {
            City city = new City();

            city.Name = cityNameTextBox.Text;
            city.FirstYear = int.Parse(firstYearTextBox.Text);
            city.SecondYear = int.Parse(secondYearTextBox.Text);
            city.FirstYearPopulation = int.Parse(firstYearPopulationTextBox.Text);
            city.SecondYearPopulation = int.Parse(secondYearPopulationTextBox.Text);

            new City().AddCityToDb(city);

            return true;
        }
        private void SetLabels(int firstYear, int secondYear, int firstYearPopulation, int secondYearPopulation)
        {
            firstYear = int.Parse(firstYearTextBox.Text);
            secondYear = int.Parse(secondYearTextBox.Text);
            firstYearPopulation = int.Parse(firstYearPopulationTextBox.Text);
            secondYearPopulation = int.Parse(secondYearPopulationTextBox.Text);


            double popchange = GetPopulationChange(firstYearPopulation, secondYearPopulation);

            SetNumOfYearsLabel(firstYear, secondYear);
            SetAllYearStatisticLabel(firstYearPopulation, secondYearPopulation, popchange);
            string sign = "";
            if (firstYearPopulation != secondYearPopulation)
            {
                sign = firstYearPopulation > secondYearPopulation ? "-" : "+";
            }
            SetOneYearStatisitLabel(firstYear, secondYear, popchange, sign);
            SetResultLabel(firstYearPopulation, secondYearPopulation, popchange);
        }
        private double GetPopulationChange(int firstYearPop, int secondYearPop)
        {   
            double popChange = Convert.ToDouble(secondYearPop) / Convert.ToDouble(firstYearPop);
            popChange = Math.Abs(popChange - 1);
            popChange *= 100;

            return popChange;
        }
        private void SetResultLabel(int firstYearPop, int secondYearPop, double popChange)
        {
            popChange = Math.Round(popChange, 3);

            resultLabel.Text = "Итог: ";

            if (firstYearPop < secondYearPop && popChange >= 30)
            {
                resultLabel.Text += "Население города стремительно растет";
            }
            else if (firstYearPop < secondYearPop && popChange >= 10 && popChange <= 30 )
            {
                resultLabel.Text += "Население города умеренно растет";
            }
            else if (firstYearPop > secondYearPop && popChange >= 10 && popChange <= 30)
            {
                resultLabel.Text += "Население города падает";
            }
            else if (firstYearPop > secondYearPop && popChange >= 30)
            {
                resultLabel.Text += "Город вымирает";
            }
            else
            {
                resultLabel.Text += "Несущественные изменения населения";
            }

            resultLabel.Visible = true;
        }
        private void SetOneYearStatisitLabel(int firstYear, int secondYear, double popChange, string sign)
        {
            popChange = Math.Round(popChange, 3);
            oneYearStatisticLabel.Text = $"Изменения за год: {sign}{Math.Round(popChange / (Math.Abs(firstYear - secondYear)), 3)}%";
            oneYearStatisticLabel.Visible = true;
        }
        private void SetNumOfYearsLabel(int firstYear, int secondYear)
        {
            yearsLabel.Visible = true;
            yearsLabel.Text = $"Изменения за {secondYear - firstYear} лет";
        }
        private void SetAllYearStatisticLabel(int firstYearPop, int secondYearPop, double popChange)
        {
            popChange = Math.Round(popChange, 3);

            if (firstYearPop < secondYearPop)
            {
                allYearsStatisticLabel.Text = $"+{popChange}%";
                SetAllYearStatisticLabelColor(firstYearPop - secondYearPop, popChange);
            }
            else if (firstYearPop > secondYearPop)
            {
                allYearsStatisticLabel.Text = $"-{popChange}%";
                SetAllYearStatisticLabelColor(firstYearPop - secondYearPop, popChange);
            }
            else
            {
                allYearsStatisticLabel.Text = "0%";
                allYearsStatisticLabel.ForeColor = Color.Yellow;
            }

            allYearsStatisticLabel.Visible = true;
        }
        private void SetAllYearStatisticLabelColor(int num, double popChange)
        {
            if (num < 0)
            {
                if (popChange >= 30)
                {
                    allYearsStatisticLabel.ForeColor = Color.MediumPurple;
                }
                else if (popChange >= 10)
                {
                    allYearsStatisticLabel.ForeColor = Color.LightGreen;
                }
                else
                {
                    allYearsStatisticLabel.ForeColor = Color.Yellow;
                }
            }
            else
            {
                if (popChange >= 30)
                {
                    allYearsStatisticLabel.ForeColor = Color.Red;
                }
                else if (popChange >= 10)
                {
                    allYearsStatisticLabel.ForeColor = Color.Orange;
                }
                else
                {
                    allYearsStatisticLabel.ForeColor = Color.Yellow;
                }
            }
        }
    }
}
