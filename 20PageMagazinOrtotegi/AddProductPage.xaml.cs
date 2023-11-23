using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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

namespace _20PageMagazinOrtotegi
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

            private void BtnAddProduct_Click(object sender, RoutedEventArgs e)
            {
            //Проверяем, что все поля были заполнены
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtBrand.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
               
            }

            try
            {
                //Проверки на пустоты
                if (String.IsNullOrEmpty(txtName.Text))
                {
                    MessageBox.Show("Поле Навзание  Пустое");
                    return; //Возвращает обратно
                }
                if (String.IsNullOrEmpty(txtBrand.Text))
                {
                    MessageBox.Show("Поле Бренд Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(txtPrice.Text))
                {
                    MessageBox.Show("Поле Цена Пустое");
                    return;
                }
                if (String.IsNullOrEmpty(txtQuantity.Text))
                {
                    MessageBox.Show("Поле Колличество Пустое");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


            //Добавляем товар в базу данных или в другую структуру данных

            MessageBox.Show("Продукт успешно добавлен.", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);

            //txtName.Clear();
            //txtBrand.Clear();
            //txtPrice.Clear();
            //txtQuantity.Clear();

            //    string name = txtName.Text;
            //    string brand = txtBrand.Text;
            //    double price;
            //    int quantity;

            //    if (!double.TryParse(txtPrice.Text, out price))
            //    {
            //        lblMessage.Content = "Недопустимая цена!";
            //        lblMessage.Visibility = Visibility.Visible;
            //        return;
            //    }

            //    if (!int.TryParse(txtQuantity.Text, out quantity))
            //    {
            //        lblMessage.Content = "Недопустимое количество!";
            //        lblMessage.Visibility = Visibility.Visible;
            //        return;
            //    }

            //    // Здесь можно добавить код для сохранения товара в базу данных или другие необходимые действия.

            //    lblMessage.Content = "Продукт успешно добавлен!";
            //    lblMessage.Visibility = Visibility.Visible;
        }
        }
    }




