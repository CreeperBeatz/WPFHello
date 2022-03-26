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
using System.Windows.Shapes;

namespace Expenselt
{
    /// <summary>
    /// Interaction logic for ExpenseltHome.xaml
    /// </summary>
    public partial class ExpenseltHome : Window
    {
        public string MainCaptionText {get; set;}

        public ExpenseltHome()
        {
            InitializeComponent();
            MainCaptionText = "View Expense Report :";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ExpenseReport expenseReport = new ExpenseReport();
            expenseReport.Height = this.Height;
            expenseReport.Width = this.Width;
            expenseReport.Show();
        }
    }
}
