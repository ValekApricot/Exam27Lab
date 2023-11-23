using System;
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

namespace _16PageMebelniSalon
{
    /// <summary>
    /// Логика взаимодействия для AddProductPage.xaml
    /// </summary>
    public partial class AddProductPage : Page
    {
        public AddProductPage()
        {
            InitializeComponent();
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productNameTextBox.Text) ||
                  string.IsNullOrWhiteSpace(categoryComboBox.Text) ||
                  string.IsNullOrWhiteSpace(priceTextBox.Text) ||
                  string.IsNullOrWhiteSpace(quantityTextBox.Text))

            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                //Проверки на пустоты
                if (String.IsNullOrEmpty(productNameTextBox.Text))
                {
                    MessageBox.Show("Поле Навзание продукта Пустое");
                    return; //Возвращает обратно
                }
                if (String.IsNullOrEmpty(categoryComboBox.Text))
                {
                    MessageBox.Show("Поле Категрия Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(priceTextBox.Text))
                {
                    MessageBox.Show("Поле Цена Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(quantityTextBox.Text))
                {
                    MessageBox.Show("Поле Колличесвто Пустое");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Добавляем товар в базу данных или в другую структуру данных
            MessageBox.Show("Продукт успешно добавлен.", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
