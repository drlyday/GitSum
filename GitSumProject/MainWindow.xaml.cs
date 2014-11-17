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
using System.Data.Entity.Infrastructure;


namespace GitSumProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            try
            {
                //Changes
                //Feature 1 changes
                var workout = new DataModel.Workout();
                workout.Exercises.Add(new DataModel.Exercise() { Title = "Warmup", Description = "" });

                var db = new Context();
                db.Workouts.Add(workout);
                var ss = db.SaveChanges();

                MessageBox.Show(String.Format("{0} workouts in db", db.Workouts.Count()));
                var connectionString = ((IObjectContextAdapter)db).ObjectContext.Connection.ConnectionString;
                MessageBox.Show(String.Format("{0} : Connection String", connectionString));
            }
            catch (Exception ex)
            {
                var error = ex; 
                //log

            }

        }
    }
}
