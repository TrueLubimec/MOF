using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MOFUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.GetPeople(lastNametText.Text);

        }
    }
}
