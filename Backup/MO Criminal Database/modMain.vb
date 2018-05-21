Imports System.Threading 'to create a mutex which will ensure that only one application is running


Module modMain

    Public AppName As String = "MO Criminal Information System"
    Public RegistrySettingsPath As String = "HKEY_CURRENT_USER\Software\BXSofts\MO Criminal Information System"
    Public AppPath As String = My.Application.Info.DirectoryPath
    Public MOCriminalPictureLocation As String
    Public FPSlipLocation As String
    Public objMutex As Mutex
End Module
