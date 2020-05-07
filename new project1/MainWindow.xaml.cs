using System;
using System.Runtime.ExceptionServices;
using System.Windows;

namespace new_project1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();       
        }
        public class Album
        {
            public string nazwa { get; set; }
            public string autor { get; set; }
            public string rok { get; set; }
            public string liczba { get; set; }

        }
 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Album first = new Album();
            first.nazwa = txtAlbum.Text;
            first.autor = txtAutor.Text;
            first.rok = txtRok.Text;
            first.liczba = txtLiczba.Text;

             gridTab.Items.Add(first);
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtAlbum.Text = "";
            txtAutor.Text = "";
            txtLiczba.Text = "";
            txtRok.Text = "";
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void gridTab_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string nazwa = txtAlbum.Text;
            string autor = txtAutor.Text;
            string rok = txtLiczba.Text;
            string liczba = txtRok.Text;
        }

       

     
    }
}
