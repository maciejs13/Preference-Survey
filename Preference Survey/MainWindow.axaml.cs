using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Preference_Survey;

public partial class MainWindow : Window
{

    public MainWindow()
    {
        InitializeComponent();
        
    }
    public void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        var zainteresowania = "";
        
        if (Technologia.IsSelected == true)
            zainteresowania = "Technologia";

        if (Sport.IsSelected == true)
            zainteresowania = "Sport";

        if (Kultura.IsSelected == true)
            zainteresowania = "Kultura";
        
        var licznik = 0;

        if (CheckBox1.IsChecked == true)
            licznik = licznik + 1;
        
        if (CheckBox2.IsChecked == true)
            licznik = licznik + 1;
        
        if (CheckBox3.IsChecked == true)
            licznik = licznik + 1;
        
        
       
        
        
        podsumowanie.Text = $"Użytkownik:{imie.Text}\n Zainteresowania: {zainteresowania}\n Liczba Odpowiedzi Tak: {licznik}";
    }
}