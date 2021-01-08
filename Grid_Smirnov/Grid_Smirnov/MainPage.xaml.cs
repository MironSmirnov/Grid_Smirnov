using System;
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
        TimePicker picker;
        Entry entry;
        Image img;
        Label lbl;
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
            picker = new TimePicker()
            {
                Time = new TimeSpan(0, 0, 0)
            };
            picker.PropertyChanged += Picker_PropertyChanged1;
            gr.Children.Add(picker, 2, 1);
            lbl = new Label()
            {
                Text = "встал с кровати",
                TextColor = Color.Green,
                FontSize = 20
            };
            gr.Children.Add(lbl, 1, 0);
            img = new Image { Source = "vstal.jpg" };
            gr.Children.Add(img, 0, 1);
            Content = gr;
        }

        private void Picker_PropertyChanged1(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                var time = picker.Time.Hours;
                if (time == 8.30)
                {
                    entry.Text = "Учеба";
                    img.Source = "vosem.jpg";
                }
                else if (time == 16)
                {
                    entry.Text = "Дома";
                    img.Source = "shestnats.jps";
                }
                else if (time == 17)
                {
                    entry.Text = "Обед";
                    img.Source = "pat.jpg";
                }
                else if (time == 18)
                {
                    entry.Text = "Прогулка";
                    img.Source = "progul.jpg";
                }
                else if (time == 19)
                {
                    entry.Text = "Ужин";
                    img.Source = "semnats.jpg";
                }
                else if (time == 21)
                {
                    entry.Text = "Просмотр фильма";
                    img.Source = "prosmotr.jpg";
                }
                else if (time == 22)
                {
                    entry.Text = "Прогулка с собакой";
                    img.Source = "desat.jpg";
                }
                else if (time == 23.30)
                {
                    entry.Text = "Подготовка ко сну";
                    img.Source = "krovat.jpg";
                }
                else if (time == 23.50)
                {
                    entry.Text = "Чтение книги";
                    img.Source = "stenie.jpg";
                }
                else if (time == 00)
                {
                    entry.Text = "Расстелание кровати";
                    img.Source = "rastel.jpg";
                }
                else if (time == 00.20)
                {
                    entry.Text = "Иду спать";
                    img.Source = "nots.jpg";
                }
            }
        }
    }
}
