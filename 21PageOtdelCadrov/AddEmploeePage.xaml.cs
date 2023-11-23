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

namespace _21PageOtdelCadrov
{
    /// <summary>
    /// Логика взаимодействия для AddEmploeePage.xaml
    /// </summary>
    public partial class AddEmploeePage : Page
    {
        public AddEmploeePage()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmploNameTextBox.Text) ||
                  string.IsNullOrWhiteSpace(categoryComboBox.Text) ||
                  string.IsNullOrWhiteSpace(priceTextBox.Text) ||
                  string.IsNullOrWhiteSpace(NumberTextBox.Text))

            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                //Проверки на пустоты
                if (String.IsNullOrEmpty(EmploNameTextBox.Text))
                {
                    MessageBox.Show("Поле Навзание сотрудника Пустое");
                    return; //Возвращает обратно
                }
                if (String.IsNullOrEmpty(categoryComboBox.Text))
                {
                    MessageBox.Show("Поле Категория Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(priceTextBox.Text))
                {
                    MessageBox.Show("Поле Цена Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(NumberTextBox.Text))
                {
                    MessageBox.Show("Поле Номер телефона Пустое");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Добавляем товар в базу данных или в другую структуру данных
            MessageBox.Show("Сотрудник успешно добавлен.", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
