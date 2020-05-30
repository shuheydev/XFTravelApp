using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using XFTravelApp.Models;

namespace XFTravelApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Button lastButton;

        public ObservableCollection<int> Obsanio { get; set; }

        private ObservableCollection<TravelSchedule> _travelSchedule;
        public ObservableCollection<TravelSchedule> TravelSchedule
        {
            get => _travelSchedule;
            set
            {
                _travelSchedule = value;
                OnPropertyChanged(nameof(TravelSchedule));
            }

        }

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = this;

            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                Button btn = new Button()
                {
                    Text = $"{i}",
                    TextColor = Color.Black,
                    Padding = new Thickness(30, 10),
                    BackgroundColor = Color.Transparent,
                };
                btn.Clicked += (sender, eventArgs) =>
                {
                    if (lastButton != null)
                    {
                        VisualStateManager.GoToState(lastButton, "DayUnSelected");
                    }
                    VisualStateManager.GoToState((Button)sender, "DaySelected");
                    lastButton = (Button)sender;
                };
                DaysBlock.Children.Add(btn);
            }

            Obsanio = new ObservableCollection<int>();
            for (int i = 1; i <= 29; i++)
            {
                Obsanio.Add(i);
            }

            TravelSchedule = new ObservableCollection<TravelSchedule>
            {
                new TravelSchedule
                {
                    Time = "08:00 AM",
                    Picture = "XFTravelApp.Resources.Images.Place1.png",
                    Name = "Walking Tour",
                    Address1 = "191 Sutter St.",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Car.png",
                    TransportColor = ColorConverters.FromHex("#31bea6")
                },
                new TravelSchedule
                {
                    Time = "10:00 AM",
                    Picture = "XFTravelApp.Resources.Images.Place2.png",
                    Name = "LightHouse",
                    Address1 = "192 Sutter St.",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Walking.png",
                    TransportColor = ColorConverters.FromHex("#e0995e")

                },
                new TravelSchedule
                {
                    Time = "01:30 PM",
                    Picture = "XFTravelApp.Resources.Images.Place3.png",
                    Name = "Beach Tour",
                    Address1 = "194 Sutter St.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Motor.png",
                    TransportColor = ColorConverters.FromHex("#76c2af"),
                },
                                new TravelSchedule
                {
                    Time = "08:00 AM",
                    Picture = "XFTravelApp.Resources.Images.Place1.png",
                    Name = "Walking Tour",
                    Address1 = "191 Sutter St.",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Car.png",
                    TransportColor = ColorConverters.FromHex("#31bea6")
                },
                new TravelSchedule
                {
                    Time = "10:00 AM",
                    Picture = "XFTravelApp.Resources.Images.Place2.png",
                    Name = "LightHouse",
                    Address1 = "192 Sutter St.",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Walking.png",
                    TransportColor = ColorConverters.FromHex("#e0995e")

                },
                new TravelSchedule
                {
                    Time = "01:30 PM",
                    Picture = "XFTravelApp.Resources.Images.Place3.png",
                    Name = "Beach Tour",
                    Address1 = "194 Sutter St.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Motor.png",
                    TransportColor = ColorConverters.FromHex("#76c2af"),
                },
                                new TravelSchedule
                {
                    Time = "08:00 AM",
                    Picture = "XFTravelApp.Resources.Images.Place1.png",
                    Name = "Walking Tour",
                    Address1 = "191 Sutter St.",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Car.png",
                    TransportColor = ColorConverters.FromHex("#31bea6")
                },
                new TravelSchedule
                {
                    Time = "10:00 AM",
                    Picture = "XFTravelApp.Resources.Images.Place2.png",
                    Name = "LightHouse",
                    Address1 = "192 Sutter St.",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Walking.png",
                    TransportColor = ColorConverters.FromHex("#e0995e")

                },
                new TravelSchedule
                {
                    Time = "01:30 PM",
                    Picture = "XFTravelApp.Resources.Images.Place3.png",
                    Name = "Beach Tour",
                    Address1 = "194 Sutter St.aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Motor.png",
                    TransportColor = ColorConverters.FromHex("#76c2af"),
                },
                new TravelSchedule
                {
                    Time = "04:30 PM",
                    Picture = "XFTravelApp.Resources.Images.Place4.png",
                    Name = "Island",
                    Address1 = "200 Sutter St.",
                    Address2 = "CA 91929",
                    TransportType = "XFTravelApp.Resources.Images.Walking.png",
                    TransportColor = ColorConverters.FromHex("#e0995e"),
                    IsLast=true,
                }
            };
        }
    }
}
