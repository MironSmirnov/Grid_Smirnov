using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grid_Smirnov
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ajaplaan : ContentPage
    {
        TimePicker tpicker;
        Picker picker;
        public Ajaplaan()
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
        }
    }
}