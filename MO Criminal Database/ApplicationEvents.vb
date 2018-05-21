Imports System.Threading 'to create a mutex which will ensure that only one application is running


Namespace My
    Partial Friend Class MyApplication

        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            On Error Resume Next
            objMutex = New Mutex(False, "MO_Criminal_Information_System_APPMUTEX") 'creates the mutex
            Me.MinimumSplashScreenDisplayTime = 5000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function


        Private Sub MyApplication_StartupNextInstance(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs) Handles Me.StartupNextInstance
            On Error Resume Next
            e.BringToForeground = True
            frmMainInterface.WindowState = FormWindowState.Maximized
            frmMainInterface.BringToFront()
        End Sub
    End Class

End Namespace
