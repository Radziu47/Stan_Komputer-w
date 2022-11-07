using System;
using System.Windows;

namespace Stan_Komputerów
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
      HowToUseProgram.Print();
    }

    private void LogIn(object sender, RoutedEventArgs e)
    {
      Stan_Komputerów.Cutting.GetLoginData();
    }
  }
}
