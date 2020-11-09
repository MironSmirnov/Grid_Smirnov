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
        Picker picker;
        Editor editor;
        DatePicker dpicker;
        Entry entry;
        TimePicker tpicker;
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
                Title = "Keeled"
            };
            picker.Items.Add("C#");
            picker.Items.Add("Python");
            picker.Items.Add("C++");
            picker.Items.Add("VisualBasic");
            picker.Items.Add("Java");

            gr.Children.Add(picker, 0, 0);

            editor = new Editor { Placeholder = "Vali keel \nnimekirjast" };
            gr.Children.Add(editor, 1, 0);

            tpicker = new TimePicker()
            {
                //Time = new TimeSpan(18,0,0)
                Time = new TimeSpan(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second)
            };

            gr.Children.Add(tpicker, 1, 2);

            dpicker = new DatePicker
            {
                Format = "D",
                MinimumDate = DateTime.Now.AddDays(-10),
                MaximumDate = DateTime.Now.AddDays(10)
            };
            gr.Children.Add(dpicker, 1, 1);
            Content = gr;


            entry = new Entry { Text = "Vali kuupäev" };
            gr.Children.Add(entry, 0, 1);

            Content = gr;
        }
        private void Dpicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            entry.Text = "Sinu kuupäev:" + e.NewDate.ToString("G");
        }

            private void Picker_SelectedIndexChanged(object sender, EventArgs e)
            {
                editor.Text = "Oli valitud:" + picker.Items[picker.SelectedIndex];
            }
        private void Tpicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            TimeSpan selctTime = tpicker.Time;
            entry.Text = selctTime.ToString();
        }
        }
    }
