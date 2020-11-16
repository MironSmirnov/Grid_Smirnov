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
        TimePicker tpicker;
        Picker picker;
        Entry entry;
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
            picker.PropertyChanged += Picker_PropertyChanged; ;
        }

        private void Picker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                var time = tpicker.Time.Hours;
                if (time == 7)
                {
                    entry.Text = "Просыпаюсь";
                }
                else time = tpicker.Time.Hours;
                if (time == 8.30)
                {
                    entry.Text = "Учеба";
                }
                else time = tpicker.Time.Hours;
                if (time == 16)
                {
                    entry.Text = "Дома";
                }
                else time = tpicker.Time.Hours;
                if (time == 17)
                {
                    entry.Text = "Обед";
                }
                else time = tpicker.Time.Hours;
                if (time == 18)
                {
                    entry.Text = "Прогулка";
                }
                else time = tpicker.Time.Hours;
                if (time == 19)
                {
                    entry.Text = "Ужин";
                }
                else time = tpicker.Time.Hours;
                if (time == 21)
                {
                    entry.Text = "Просмотр фильма";
                }
                else time = tpicker.Time.Hours;
                if (time == 22)
                {
                    entry.Text = "Прогулка с собакой";
                }
                else time = tpicker.Time.Hours;
                if (time == 23.30)
                {
                    entry.Text = "Подготовка ко сну";
                }
                else time = tpicker.Time.Hours;
                if (time == 23.50)
                {
                    entry.Text = "Чтение книги";
                }
                else time = tpicker.Time.Hours;
                if (time == 00)
                {
                    entry.Text = "Расстелание кровати";
                }
                else time = tpicker.Time.Hours;
                if (time == 00.20)
                {
                    entry.Text = "Иду спать";
                }
            }
        }
    }
}
