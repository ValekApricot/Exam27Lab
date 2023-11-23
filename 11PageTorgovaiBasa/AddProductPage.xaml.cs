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
using System.Xml.Linq;

namespace _11PageTorgovaiBasa
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

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            //Проверяем, что все поля были заполнены
            if (string.IsNullOrWhiteSpace(ProductNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(ProductDescriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(ProductPriceTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                //Проверки на пустоты
                if (String.IsNullOrEmpty(ProductNameTextBox.Text))
                {
                    MessageBox.Show("Поле Навзание продукта Пустое");
                    return; //Возвращает обратно
                }
                if (String.IsNullOrEmpty(ProductDescriptionTextBox.Text))
                {
                    MessageBox.Show("Поле Описание Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(ProductPriceTextBox.Text))
                {
                    MessageBox.Show("Поле телефон Пустое");
                    return;
                }

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }


            // Добавляем товар в базу данных или в другую структуру данных

            MessageBox.Show("Продукт успешно добавлен.", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);


            // Очищаем текстовые поля для добавления нового товара
            ProductNameTextBox.Clear();
            ProductDescriptionTextBox.Clear();
            ProductPriceTextBox.Clear();

          
        }
    }
}





       
