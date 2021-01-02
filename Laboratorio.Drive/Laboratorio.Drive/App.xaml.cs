using Laboratorio.Drive.Data;
using Laboratorio.Drive.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Laboratorio.Drive
{
    public partial class App : Application
    {
        private static DriveDatabase db;
        public static DriveDatabase Db
        {
            get
            {
                if (db == null)
                {
                    db = new DriveDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Drive.db3"));
                }

                return db;
            }
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new ListagemView();
            MainPage = new NavigationPage(new ListagemView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
