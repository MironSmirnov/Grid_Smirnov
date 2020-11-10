﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Grid_Smirnov
{
    public partial class MainPage : ContentPage
    {
        TimePicker tpicker;
        Picker picker;
        public MainPage()
        {
            Grid gr = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
                }
            };
            picker = new Picker
            {
                Title = "Plaan"
            };
            picker.Items.Add("Просыпаюсь");
            picker.Items.Add("Учеба");
            picker.Items.Add("Дома");
            picker.Items.Add("Обед");
            picker.Items.Add("Прогулка");
            picker.Items.Add("Ужин");
            picker.Items.Add("Просмотр фильма");
            picker.Items.Add("Прогулка с собакой");
            picker.Items.Add("Подготовка ко сну");
            picker.Items.Add("Чтение книги");
            picker.Items.Add("Расстелание кровати");
            picker.Items.Add("Иду спать");

            gr.Children.Add(picker, 0, 0);

            tpicker = new TimePicker()
            {
                //Time = new TimeSpan(18,0,0)
                Time
            }
        }
    }
}
