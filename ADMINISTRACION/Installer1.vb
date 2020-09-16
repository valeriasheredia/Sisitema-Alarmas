Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.Configuration

Public Class Installer1

    Public Sub New()
        MyBase.New()

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

        'Agregue el código de inicialización después de llamar a InitializeComponent
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        config.AppSettings.Settings.Remove("Title")
        config.AppSettings.Settings.Add("Title", TextBox1.Text)
        config.AppSettings.Settings.Remove("Number")
        config.AppSettings.Settings.Add("Number", NumericUpDown1.Value.ToString())
        config.Save(ConfigurationSaveMode.Modified)
    End Sub

End Class
