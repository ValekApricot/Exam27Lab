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

namespace _13PageSalonCrasoti
{
    /// <summary>
    /// Логика взаимодействия для ApointmentPage.xaml
    /// </summary>
    public partial class ApointmentPage : Page
    {
        public ApointmentPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if  (string.IsNullOrWhiteSpace(clientNameTextBox.Text) ||
                 string.IsNullOrWhiteSpace(appointmentDatePicker.Text) ||
                 string.IsNullOrWhiteSpace(serviceComboBox.Text) ||
                string.IsNullOrWhiteSpace(stylistComboBox.Text))


            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            try
            {
                //Проверки на пустоты
                if (String.IsNullOrEmpty(clientNameTextBox.Text))
                {
                    MessageBox.Show("Поле Имя Пустое");
                    return; //Возвращает обратно
                }
                if (String.IsNullOrEmpty(appointmentDatePicker.Text))
                {
                    MessageBox.Show("Поле Дата Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(serviceComboBox.Text))
                {
                    MessageBox.Show("Поле Услуги Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(stylistComboBox.Text))
                {
                    MessageBox.Show("Поле Стилист Пустое");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // Добавляем товар в базу данных или в другую структуру данных
            MessageBox.Show("Запись успешно добавлена.", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
