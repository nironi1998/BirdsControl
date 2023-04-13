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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace BirdsControl
{
    /// <summary>
    /// Interaction logic for UpdateCage.xaml
    /// </summary>
    public partial class UpdateCage : Window
    {
        public UpdateCage()
        {
            InitializeComponent();
        }
        private int updatingTableId = 0;
        private void gridCage_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.gridCage.SelectedIndex >= 0 && this.gridCage.SelectedItems.Count >= 0)
            {
                if (this.gridCage.SelectedItems[0].GetType() == typeof(Cage))
                {
                    Cage t = (Cage)this.gridCage.SelectedItems[0];
                    this.SerialNumber_tb.Text = t.SerialNumber;
                    this.Length_tb.Text = t.Length.ToString();
                    this.Width_tb.Text = t.Width.ToString();
                    this.Height_tb.Text = t.Height.ToString();
                    this.updatingTableId = t.Id;
                }
            }
        }

        private void updateCage_btn_Click(object sender, RoutedEventArgs e)
        {
            BirdsControlDBEntities db = new BirdsControlDBEntities();

            var r = from d in db.Cage
                    where d.Id == this.updatingTableId
                    select d;

            var result = from cage in db.Cage
                         where (SerialNumber_tb.Text == cage.SerialNumber)
                         select cage;

            if (!result.Any())
            {

                Cage obj = r.SingleOrDefault();
                if (obj != null)
                {
                    obj.SerialNumber = this.SerialNumber_tb.Text;
                    obj.Length = int.Parse(this.Length_tb.Text);
                    obj.Width = int.Parse(this.Width_tb.Text);
                    obj.Height = int.Parse(this.Height_tb.Text);
                    obj.Material = Material_drop.SelectedItem.ToString().Split(':')[1];
                }

                db.SaveChanges();
                this.gridCage.ItemsSource = db.Cage.ToList();
            }
            else
            {
                MessageBox.Show("Cage is already exists");
            }
        }

        private void LoadCages_btn_Click(object sender, RoutedEventArgs e)
        {
            BirdsControlDBEntities db = new BirdsControlDBEntities();
            this.gridCage.ItemsSource = db.Cage.ToList();
        }

        private void HomePage_btn_Click(object sender, RoutedEventArgs e)
        {
            MainPage newWindow = new MainPage();
            this.Visibility = Visibility.Hidden;
            newWindow.Show();
        }
    }
}
