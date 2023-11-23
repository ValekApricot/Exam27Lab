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

namespace _22PageUchebnoiMedicUchresdenie
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
            if (string.IsNullOrWhiteSpace(PatientNameTextBox.Text) ||
                           string.IsNullOrWhiteSpace(AppointmentTextBox.Text) ||
                           string.IsNullOrWhiteSpace(DoctorTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                //Проверки на пустоты
                if (String.IsNullOrEmpty(PatientNameTextBox.Text))
                {
                    MessageBox.Show("Поле Пациент Пустое");
                    return; //Возвращает обратно
                }
                if (String.IsNullOrEmpty(AppointmentTextBox.Text))
                {
                    MessageBox.Show("Поле Дата приема Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(DoctorTextBox.Text))
                {
                    MessageBox.Show("Поле Доктор Пустое");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Добавляем товар в базу данных или в другую структуру данных

            MessageBox.Show("Продукт успешно добавлен.", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);


            // Очищаем текстовые поля для добавления нового товара
            PatientNameTextBox.Clear();
            DoctorTextBox.Items.Clear();
        }
    }
}

