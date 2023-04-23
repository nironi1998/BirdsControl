﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BirdsControl
{
    /// <summary>
    /// Interaction logic for UpdateBirdPage.xaml
    /// </summary>
    public partial class UpdateBirdPage : Page
    {
        public UpdateBirdPage()
        {
            InitializeComponent();
        }
        private void Update_bird_Click(object sender, RoutedEventArgs e)
        {
            BirdsControlDBEntities db = new BirdsControlDBEntities();
            if (string.IsNullOrWhiteSpace(species_tb.Text) || string.IsNullOrWhiteSpace(subspecies_tb.Text) ||
                datePicker.SelectedDate == null || string.IsNullOrWhiteSpace(sex_tb.Text) || string.IsNullOrWhiteSpace(cage_tb.Text))
            {
                MessageBox.Show("Please fill in all the fields before adding a bird.");
                return;
            }
            if (sex_tb.Text != "Male" && sex_tb.Text != "male" && sex_tb.Text != "Female" && sex_tb.Text != "female")
            {
                MessageBox.Show("Enter M/male or F/female");
                return;
            }




            var r = from d in db.Bird
                    where d.Id == this.updatingTableId
                    select d;


            var result = from cage in db.Cage
                         where (cage_tb.Text == cage.SerialNumber)
                         select cage;

            if (!result.Any())
            {
                MessageBox.Show("The cage number Does not exist");
            }

            else
            {
                Bird obj = r.SingleOrDefault();
                if (obj != null)
                {
                    obj.Specie = this.species_tb.Text;
                    obj.SubSpecie = this.subspecies_tb.Text;
                    obj.HatchingDate = this.datePicker.SelectedDate.Value;

                    obj.Sex = this.sex_tb.Text;
                    obj.CageNumber = this.cage_tb.Text;
                }

                db.SaveChanges();
                this.gridBird.ItemsSource = db.Bird.ToList();
            }

        }

        private void Load_Birds_Click(object sender, RoutedEventArgs e)
        {

            BirdsControlDBEntities db = new BirdsControlDBEntities();
            this.gridBird.ItemsSource = db.Bird.ToList();

        }
        private int updatingTableId = 0;
        private void gridBird_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.gridBird.SelectedIndex >= 0 && this.gridBird.SelectedItems.Count >= 0)
            {
                if (this.gridBird.SelectedItems[0].GetType() == typeof(Bird))
                {
                    Bird t = (Bird)this.gridBird.SelectedItems[0];
                    this.species_tb.Text = t.Specie;
                    this.subspecies_tb.Text = t.SubSpecie;
                    this.datePicker.Text = t.HatchingDate.ToString();
                    this.sex_tb.Text = t.Sex;
                    this.cage_tb.Text = t.CageNumber;
                    this.updatingTableId = t.Id;
                }
            }

        }

        private void HomePage_btn_Click(object sender, RoutedEventArgs e)
        {
            MainPage newWindow = new MainPage();
            this.Visibility = Visibility.Hidden;
            newWindow.Show();
        }

        private void Delete_bird_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult msg = MessageBox.Show("Are you sure?",
              "Deletre bird",
              MessageBoxButton.YesNo,
              MessageBoxImage.Warning,
              MessageBoxResult.No
              );
            if (msg == MessageBoxResult.Yes)
            {


                BirdsControlDBEntities db = new BirdsControlDBEntities();

                var r = from d in db.Bird
                        where d.Id == this.updatingTableId
                        select d;

                Bird obj = r.SingleOrDefault();
                if (obj != null)
                {
                    db.Bird.Remove(obj);
                    db.SaveChanges();
                }
                this.gridBird.ItemsSource = db.Bird.ToList();
            }



        }
    }
}