using Humanizer;
using System;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.HumanizerSample
{
    public sealed partial class MainPage : Page
    {
        private DateTimeOffset selectedDate;
        private TimeSpan selectedTime;

        public MainPage()
        {
            InitializeComponent();

            SelectedDate = DateTimeOffset.Now.Date;
            SelectedTime = DateTime.Now.TimeOfDay;
        }

        public DateTimeOffset SelectedDate
        {
            get => selectedDate;
            set
            {
                SetProperty(ref selectedDate, value);
                OnPropertyChanged(nameof(SelectedDateTime));
                OnPropertyChanged(nameof(HumanizedDateTime));
            }
        }

        public TimeSpan SelectedTime
        {
            get => selectedTime;
            set
            {
                SetProperty(ref selectedTime, value);
                OnPropertyChanged(nameof(SelectedDateTime));
                OnPropertyChanged(nameof(HumanizedDateTime));
            }
        }

        public DateTime SelectedDateTime => new DateTime(SelectedDate.Year, SelectedDate.Month, SelectedDate.Day, SelectedTime.Hours, SelectedTime.Minutes, SelectedTime.Seconds);

        public string HumanizedDateTime => SelectedDateTime.ToUniversalTime().Humanize();
    }
}
