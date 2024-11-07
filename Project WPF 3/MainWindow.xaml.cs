using Project_WPF_3.Page;
using System.Windows;
using System.Windows.Controls;

namespace Project_WPF_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Обработчик кликов для всех кнопок
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                switch (clickedButton.Name)
                {
                    case "ClientsButton":
                        // При нажатии на кнопку "Клиенты" открывается страница ClientsPage
                        ContentFrame.Navigate(new ClientsPage());
                        break;

                    case "CarsButton":
                        // Открытие страницы для автомобилей (аналогично)
                        ContentFrame.Navigate(new CarsPage());
                        break;

                    case "OrdersButton":
                        // Открытие страницы для заказов
                        ContentFrame.Navigate(new OrdersPage());
                        break;

                    case "DiscountsButton":
                        // Открытие страницы для скидок
                        ContentFrame.Navigate(new DiscountsPage());
                        break;

                    case "PricesButton":
                        // Открытие страницы для цен/услуг
                        ContentFrame.Navigate(new PricesPage());
                        break;

                    case "AnalyticsButton":
                        // Открытие страницы для аналитики
                        ContentFrame.Navigate(new AnalyticsPage());
                        break;
                }
            }
        }
    }
}
