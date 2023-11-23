using System;
using Exam27Lab.Classes;
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
using static Exam27Lab.Classes.ClassH;


namespace Exam27Lab
{
    /// <summary>
    /// Логика взаимодействия для EquipmentListPage.xaml
    /// </summary>
    public partial class EquipmentListPage : Page
    {
        public EquipmentListPage()
        {
            InitializeComponent();
            LvOrdertList.ItemsSource = ClassH.OrderItems;       
        }
    }
}
