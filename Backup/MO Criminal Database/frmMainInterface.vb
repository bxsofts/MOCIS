Public Class frmMainInterface

#Region "VARIABLES DECLARATION"
    Dim scAutoCompleteName As New AutoCompleteStringCollection
    Dim scAutoCompleteAliasName As New AutoCompleteStringCollection
    Dim scAutoCompleteDistrict As New AutoCompleteStringCollection
    Dim scAutoCompletePS As New AutoCompleteStringCollection
    Dim EditMode As Boolean

    WithEvents devmanager As WIA.DeviceManager

#End Region


#Region "FORM LOAD EVENTS"

    Private Sub frmMainInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Me.Cursor = Cursors.WaitCursor
        Me.MOCriminalDataGridView.DefaultCellStyle.Font = New Font("Segoe UI", 11, FontStyle.Regular)
        Me.MOCriminalDataGridView.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        LoadMOCriminalDataGridViewColumnWidth()
        LoadMOCriminalDataGridViewColumnOrder()
        LoadImageLocations()
        Me.MOCriminalTableAdapter.Fill(Me.MOCriminalsDatabaseDataSet.MOCriminal)
        ' Me.MOCriminalTableAdapter.RemoveNullFPClass("")
        ' Me.MOCriminalTableAdapter.RemoveNullFPSlipLocation("")
        LoadPSandDistrict()
        LoadFieldsToComboBox()
        DisplayImages()
        Application.DoEvents()
        LoadAutoTexts()
        EditMode = False
        devmanager = New WIA.DeviceManager
        Me.Cursor = Cursors.Default
    End Sub

#End Region


#Region "LOAD DISTRICT AND PS"

    Private Sub LoadPSandDistrict()
        On Error Resume Next
        Me.AutoDistrictTableAdapter.Fill(MOCriminalsDatabaseDataSet.AutoDistrict)
        Me.cmbDistrict.Text = ""
        Me.AutoPSTableAdapter.Fill(MOCriminalsDatabaseDataSet.AutoPS)
        Me.cmbPS.Text = ""
    End Sub
#End Region


#Region "AUTO COMPLETE"

   


    Private Sub ShowAutoValuesInDatagridColumns(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles MOCriminalDataGridView.EditingControlShowing
        On Error Resume Next
        If MOCriminalDataGridView.CurrentCell.ColumnIndex = 1 AndAlso TypeOf e.Control Is TextBox Then
            With DirectCast(e.Control, TextBox)
                '  .CharacterCasing = CharacterCasing.Upper
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = scAutoCompleteName
            End With
        End If

        If MOCriminalDataGridView.CurrentCell.ColumnIndex = 2 AndAlso TypeOf e.Control Is TextBox Then
            With DirectCast(e.Control, TextBox)
                ' .CharacterCasing = CharacterCasing.Upper
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = scAutoCompleteAliasName
            End With
        End If

        If MOCriminalDataGridView.CurrentCell.ColumnIndex = 4 AndAlso TypeOf e.Control Is TextBox Then
            With DirectCast(e.Control, TextBox)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = scAutoCompleteDistrict
            End With
        End If

        If MOCriminalDataGridView.CurrentCell.ColumnIndex = 5 AndAlso TypeOf e.Control Is TextBox Then
            With DirectCast(e.Control, TextBox)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.CustomSource
                .AutoCompleteCustomSource = scAutoCompletePS
            End With
        End If

        If MOCriminalDataGridView.CurrentCell.ColumnIndex = 10 AndAlso TypeOf e.Control Is TextBox Then
            With DirectCast(e.Control, TextBox)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.FileSystem
            End With
        End If

        If MOCriminalDataGridView.CurrentCell.ColumnIndex = 11 AndAlso TypeOf e.Control Is TextBox Then
            With DirectCast(e.Control, TextBox)
                .AutoCompleteMode = AutoCompleteMode.SuggestAppend
                .AutoCompleteSource = AutoCompleteSource.FileSystem
            End With
        End If

        ' If MOCriminalDataGridView.CurrentCell.ColumnIndex <> 1 And MOCriminalDataGridView.CurrentCell.ColumnIndex <> 2 Then
        ' DirectCast(e.Control, TextBox).CharacterCasing = CharacterCasing.Normal
        ' End If
    End Sub


    Private Sub LoadNameAutoTexts()
        On Error Resume Next

        Me.AutoNameFieldTableAdapter.Fill(MOCriminalsDatabaseDataSet.AutoNameField)
        Dim max = Me.MOCriminalsDatabaseDataSet.AutoNameField.Count - 1
        For i = 0 To max
            Dim a As String = Me.MOCriminalsDatabaseDataSet.AutoNameField(i).Name
            If a <> Nothing Then
                scAutoCompleteName.Add(a)
            End If
        Next
        Me.txtName.AutoCompleteCustomSource = scAutoCompleteName
    End Sub

    Private Sub LoadAliasNameAutoTexts()
        On Error Resume Next
        Me.AutoAliasNameTableAdapter.Fill(MOCriminalsDatabaseDataSet.AutoAliasName)
        Dim max = Me.MOCriminalsDatabaseDataSet.AutoAliasName.Count - 1
        For i = 0 To max
            Dim a As String = Me.MOCriminalsDatabaseDataSet.AutoAliasName(i).AliasName
            If a <> Nothing Then
                scAutoCompleteAliasName.Add(a)
            End If
        Next
        Me.txtAliasName.AutoCompleteCustomSource = scAutoCompleteAliasName
    End Sub



    Private Sub LoadAutoTexts() Handles BackgroundWorker1.DoWork
        LoadNameAutoTexts()
        LoadAliasNameAutoTexts()
    End Sub


#End Region



#Region "DATAGRID SETTINGS"


    Private Sub SaveMOCriminalDataGridColumnWidth()
        On Error Resume Next
        Dim p As String = RegistrySettingsPath & "\MOCriminalDataGrid"
        For i = 0 To Me.MOCriminalDataGridView.ColumnCount - 1
            My.Computer.Registry.SetValue(p, "Width" & Format(i, "00"), MOCriminalDataGridView.Columns(i).Width.ToString, Microsoft.Win32.RegistryValueKind.String)
        Next
        My.Computer.Registry.SetValue(p, "RHWidth", MOCriminalDataGridView.RowHeadersWidth, Microsoft.Win32.RegistryValueKind.String)
    End Sub

    Private Sub LoadMOCriminalDataGridViewColumnWidth()
        On Error Resume Next

        Dim p As String = RegistrySettingsPath & "\MOCriminalDataGrid"
        If My.Computer.Registry.GetValue(p, "Width00", Nothing) Is Nothing Then
            Exit Sub
        End If
        For i = 0 To Me.MOCriminalDataGridView.ColumnCount - 1
            MOCriminalDataGridView.Columns(i).Width = My.Computer.Registry.GetValue(p, "Width" & Format(i, "00"), MOCriminalDataGridView.Columns(i).Width)
        Next
        MOCriminalDataGridView.RowHeadersWidth = My.Computer.Registry.GetValue(p, "RHWidth", 40)
    End Sub

    Private Sub SaveMOCriminalDataGridColumnOrder()
        On Error Resume Next
        Dim p As String = RegistrySettingsPath & "\MOCriminalDataGrid"
        For i = 0 To Me.MOCriminalDataGridView.ColumnCount - 1
            My.Computer.Registry.SetValue(p, "Order" & Format(i, "00"), MOCriminalDataGridView.Columns(i).DisplayIndex.ToString, Microsoft.Win32.RegistryValueKind.String)
        Next

    End Sub


    Private Sub LoadMOCriminalDataGridViewColumnOrder()
        On Error Resume Next

        Dim p As String = RegistrySettingsPath & "\MOCriminalDataGrid"
        If My.Computer.Registry.GetValue(p, "Order00", Nothing) Is Nothing Then
            Exit Sub
        End If
        For i = 0 To Me.MOCriminalDataGridView.ColumnCount - 1
            MOCriminalDataGridView.Columns(i).DisplayIndex = My.Computer.Registry.GetValue(p, "Order" & Format(i, "00"), MOCriminalDataGridView.Columns(i).DisplayIndex)
        Next
    End Sub


#End Region


#Region "NEW DATA ENTRY"


    Private Sub ClearAllFields() Handles btnNew.Click, NewMenuItem.Click
        On Error Resume Next
        For Each Ctrl As Control In Me.PanelDataEntry.Controls
            If TypeOf (Ctrl) Is TextBox Or TypeOf (Ctrl) Is ComboBox Then
                Ctrl.Text = ""
            End If
        Next
        Me.txtName.Focus()
        EditMode = False
        DisplayImages()
    End Sub


    Private Sub SaveNewRecord()
        Try
            If Me.txtName.Text.Trim = "" Then
                MsgBox("Please enter 'Name'", MsgBoxStyle.Information, "Values Not Specified")
                Me.txtName.Focus()
                Exit Sub
            End If
            Dim newRow As MOCriminalsDatabaseDataSet.MOCriminalRow 'add a new row to insert values
            newRow = Me.MOCriminalsDatabaseDataSet.MOCriminal.NewMOCriminalRow
            With newRow
                .Name = Me.txtName.Text.Trim
                .AliasName = Me.txtAliasName.Text.Trim
                .Age = Me.txtAge.Text.Trim
                .District = Me.cmbDistrict.Text.Trim
                .PoliceStation = Me.cmbPS.Text.Trim
                .CrimeNo = Me.txtCrimeNo.Text.Trim
                .MOClassification = Me.txtMOClass.Text.Trim
                .FPClassification = Me.txtFPClass.Text.Trim
                .Adress = Me.txtAdress.Text.Trim
                .FPSlipLocation = Me.txtFPSlip.Text.Trim
                .ImageLocation = Me.txtMOCriminalsPicture.Text.Trim
            End With
            Me.MOCriminalsDatabaseDataSet.MOCriminal.Rows.Add(newRow)
            UpdateDatabase()
            Me.MOCriminalBindingSource.Position = Me.MOCriminalBindingSource.Find("ID", newRow.ID)
            ' LoadPSandDistrict()
            ClearAllFields()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error In Saving Data")
        End Try
    End Sub
#End Region


#Region "EDIT DATA"

    Private Sub EditData() Handles btnEdit.Click, EditMenuItem.Click
        On Error Resume Next
        If Me.MOCriminalDataGridView.SelectedRows.Count = 0 Then
            MsgBox("No records selected", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "No Records For Editing")
            Exit Sub
        End If
        ClearAllFields()
        EditMode = True
        With Me.MOCriminalDataGridView.SelectedRows(0)
            Me.txtName.Text = .Cells(1).Value.ToString
            Me.txtAliasName.Text = .Cells(2).Value.ToString
            Me.txtAge.Text = .Cells(3).Value.ToString
            Me.cmbDistrict.Text = .Cells(4).Value.ToString
            Me.cmbPS.Text = .Cells(5).Value.ToString
            Me.txtCrimeNo.Text = .Cells(6).Value.ToString
            Me.txtFPClass.Text = .Cells(7).Value.ToString
            Me.txtMOClass.Text = .Cells(8).Value.ToString()
            Me.txtAdress.Text = .Cells(9).Value.ToString
            Me.txtFPSlip.Text = .Cells(11).Value.ToString
            Me.txtMOCriminalsPicture.Text = .Cells(10).Value.ToString
        End With
    End Sub


    Private Sub UpdateEditedData()
        Try
            Dim ID = Me.MOCriminalDataGridView.SelectedRows(0).Cells(0).Value
            Dim oldRow As MOCriminalsDatabaseDataSet.MOCriminalRow 'add a new row to insert values
            oldRow = Me.MOCriminalsDatabaseDataSet.MOCriminal.FindByID(ID)
            If oldRow IsNot Nothing Then
                With oldRow
                    .Name = Me.txtName.Text.Trim
                    .AliasName = Me.txtAliasName.Text.Trim
                    .Age = Me.txtAge.Text.Trim
                    .District = Me.cmbDistrict.Text.Trim
                    .PoliceStation = Me.cmbPS.Text.Trim
                    .CrimeNo = Me.txtCrimeNo.Text.Trim
                    .FPClassification = Me.txtFPClass.Text.Trim
                    .MOClassification = Me.txtMOClass.Text.Trim
                    .Adress = Me.txtAdress.Text.Trim
                    .FPSlipLocation = Me.txtFPSlip.Text.Trim
                    .ImageLocation = Me.txtMOCriminalsPicture.Text.Trim
                End With
            End If
            'LoadPSandDistrict()
            UpdateDatabase()

            ClearAllFields()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error In Updation")
        End Try
    End Sub
#End Region


#Region "SAVE BUTTON ACTION"

    Private Sub SaveButtonAction() Handles btnSaveMain.Click, SaveMenuItem.Click
        On Error Resume Next
        If EditMode Then
            UpdateEditedData()
        Else
            SaveNewRecord()
        End If
    End Sub
#End Region


#Region "DELETE DATA"

    Private Sub DeleteSelectedItem() Handles btnDelete.Click, DeleteMenuItem.Click
        If Me.MOCriminalDataGridView.SelectedRows.Count = 0 Then
            MsgBox("No records selected", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "No Records For Deletion")
            Exit Sub
        End If

        Try
            If MessageBox.Show("Do you really want to delete the selected record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Me.MOCriminalBindingSource.RemoveCurrent()
                EditMode = False
                UpdateDatabase()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error In Deletion")
        End Try

    End Sub

    Private Sub MOCriminalDataGridView_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles MOCriminalDataGridView.UserDeletingRow
        Try
            If MessageBox.Show("Do you really want to delete the selected record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            Else
                UpdateDatabase()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "Error In Deletion")
        End Try
    End Sub

#End Region


#Region "UPDATE DATABASE"

    Private Sub UpdateDatabase() Handles MOCriminalDataGridView.CellEndEdit
        Try
            Me.Validate()
            Me.MOCriminalBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.MOCriminalsDatabaseDataSet)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, AppName)
        End Try

    End Sub


#End Region


#Region "RELOAD DATA"

    Private Sub ReloadData() Handles btnReload.Click, ReloadMenuItem.Click
        On Error Resume Next
        Me.Cursor = Cursors.WaitCursor
        Me.MOCriminalTableAdapter.Fill(Me.MOCriminalsDatabaseDataSet.MOCriminal)
        Me.MOCriminalBindingSource.Filter = Nothing
        DisplayImages()
        Me.Cursor = Cursors.Default
    End Sub
#End Region


#Region "PICTURE SETTINGS"

    Private Sub LoadImageLocations()
        On Error Resume Next
        FPSlipLocation = My.Computer.Registry.GetValue(RegistrySettingsPath, "FPSlipLocation", "D:\FP Slips\")
        MOCriminalPictureLocation = My.Computer.Registry.GetValue(RegistrySettingsPath, "MOCriminalPictureLocation", "D:\MO Criminals' Pictures\")

        If FPSlipLocation = Nothing Then
            FPSlipLocation = "D:\FP Slips\"
        End If

        If MOCriminalPictureLocation = Nothing Then
            MOCriminalPictureLocation = "D:\MO Criminals' Pictures\"
        End If
        If FPSlipLocation.EndsWith("\") = False Then
            FPSlipLocation = FPSlipLocation & "\"
        End If

        If MOCriminalPictureLocation.EndsWith("\") = False Then
            MOCriminalPictureLocation = MOCriminalPictureLocation & "\"
        End If
    End Sub


    Private Sub DisplayImages() Handles MOCriminalBindingSource.ListChanged, MOCriminalBindingSource.PositionChanged, MOCriminalDataGridView.Sorted
        On Error Resume Next
        Dim imglocation As String = Me.MOCriminalDataGridView.SelectedRows(0).Cells(10).Value.ToString
        If imglocation <> vbNullString Then
            Me.picMOCriminalsPicture.ImageLocation = imglocation
        Else
            Me.picMOCriminalsPicture.Image = Nothing
        End If

        imglocation = Me.MOCriminalDataGridView.SelectedRows(0).Cells(11).Value.ToString
        If imglocation <> vbNullString Then
            Me.picFPSlip.ImageLocation = imglocation
        Else
            Me.picFPSlip.Image = Nothing
        End If

        Me.lblName.Text = Me.MOCriminalDataGridView.SelectedCells(1).Value.ToString
    End Sub

   

    Private Sub ViewFPSlip() Handles picFPSlip.DoubleClick
        Try
            If FileIO.FileSystem.FileExists(Me.picFPSlip.ImageLocation) Then
                Shell("explorer.exe " & Me.picFPSlip.ImageLocation, AppWinStyle.MaximizedFocus)
            Else
                MsgBox("FP Slip not available.", MsgBoxStyle.Information, AppName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, AppName)
        End Try
    End Sub


    Private Sub ViewCriminalPicture() Handles picMOCriminalsPicture.DoubleClick
        Try
            If FileIO.FileSystem.FileExists(Me.picMOCriminalsPicture.ImageLocation) Then
                Shell("explorer.exe " & Me.picMOCriminalsPicture.ImageLocation, AppWinStyle.MaximizedFocus)
            Else
                MsgBox("Picture not available.", MsgBoxStyle.Information, AppName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, AppName)
        End Try
    End Sub


    Private Sub SelectFPSlip() Handles btnSelectFPSlip.Click
        On Error GoTo errhandler
        OpenFileDialog1.Filter = "Picture Files(JPG, JPEG, BMP, TIF, GIF, PNG)|*.jpg;*.jpeg;*.bmp;*.tif;*.gif;*.png"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Select FP Slip Image File"

        Dim SelectedFile As String
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'if ok button clicked
            Application.DoEvents() 'first close the selection window
            SelectedFile = OpenFileDialog1.FileName

            '  Dim DestinationFile As String = FPSlipLocation & OpenFileDialog1.SafeFileName
            '  My.Computer.FileSystem.CopyFile(SelectedFile, DestinationFile, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException) 'shows replace option
            '   SelectedFile = DestinationFile

            Me.txtFPSlip.Text = SelectedFile
            Me.picFPSlip.Image = New Bitmap(SelectedFile) 'display the pic
        End If
        Exit Sub
errhandler:
        ' MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, AppName)


    End Sub


    Private Sub SelectMOCriminalPicture() Handles btnSelectMOCriminalsPicture.Click
        On Error GoTo errhandler
        OpenFileDialog1.Filter = "Picture Files(JPG, JPEG, BMP, TIF, GIF, PNG)|*.jpg;*.jpeg;*.bmp;*.tif;*.gif;*.png"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Title = "Select MO Criminal's Picture File"

        Dim SelectedFile As String
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then 'if ok button clicked
            Application.DoEvents() 'first close the selection window
            SelectedFile = OpenFileDialog1.FileName

            '  Dim DestinationFile As String = FPSlipLocation & OpenFileDialog1.SafeFileName
            '  My.Computer.FileSystem.CopyFile(SelectedFile, DestinationFile, FileIO.UIOption.AllDialogs, FileIO.UICancelOption.ThrowException) 'shows replace option
            '   SelectedFile = DestinationFile

            Me.txtMOCriminalsPicture.Text = SelectedFile
            Me.picMOCriminalsPicture.Image = New Bitmap(SelectedFile) 'display the pic
        End If
        Exit Sub
errhandler:
        ' MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, AppName)


    End Sub


    Private Sub ScanFPSlip() Handles btnScanFPSLip.Click
        On Error Resume Next
        If Me.devmanager.DeviceInfos.Count = 0 Then
            MessageBox.Show("No compatible Scanner or Camera Device detected. Please connect one!", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim i As Integer = 0
        Dim FileMask As String = "FP Slip - {0:0000}.jpg"
        Dim FileName As String = ""

        FileName = FPSlipLocation & String.Format(FileMask, i)
        Do While My.Computer.FileSystem.FileExists(FileName)
            i += 1
            FileName = FPSlipLocation & String.Format(FileMask, i)
        Loop
        FileName = FileIO.FileSystem.GetName(FileName)

        Dim newfilename As String = InputBox("Please enter or modify name of the file if you wish.", "Enter File Name", FileName)
        If newfilename = "" Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        FileName = newfilename

        If ImportImageFromScannerOrCamera(FPSlipLocation, FileName) <> vbNullString Then
            Me.txtFPSlip.Text = FileName
            Me.picFPSlip.ImageLocation = FileName
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ScanCriminalsPicture() Handles btnScanCriminalPicture.Click
        On Error Resume Next
        If Me.devmanager.DeviceInfos.Count = 0 Then
            MessageBox.Show("No compatible Scanner or Camera Device detected. Please connect one!", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim i As Integer = 0
        Dim FileMask As String = "Picture - {0:0000}.jpg"
        Dim FileName As String = ""

        FileName = MOCriminalPictureLocation & String.Format(FileMask, i)
        Do While My.Computer.FileSystem.FileExists(FileName)
            i += 1
            FileName = MOCriminalPictureLocation & String.Format(FileMask, i)
        Loop

        FileName = FileIO.FileSystem.GetName(FileName)

        Dim newfilename As String = InputBox("Please enter or modify name of the file if you wish.", "Enter File Name", FileName)
        If newfilename = "" Then
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        FileName = newfilename
        If ImportImageFromScannerOrCamera(MOCriminalPictureLocation, FileName) <> vbNullString Then
            Me.txtMOCriminalsPicture.Text = FileName
            Me.picMOCriminalsPicture.ImageLocation = FileName
        End If

        Me.Cursor = Cursors.Default
    End Sub


    Private Function ImportImageFromScannerOrCamera(ByVal SaveLocation As String, Optional ByVal FileName As String = vbNullString) As String
        On Error GoTo errhandler

        Dim dev As WIA.Device
        Dim dg As New WIA.CommonDialog
        Dim SelectedItems As WIA.Items
        Dim img As WIA.ImageFile
        Dim itm As WIA.Item

        dev = dg.ShowSelectDevice(WIA.WiaDeviceType.UnspecifiedDeviceType, False, True) 'show select device message
        SelectedItems = dg.ShowSelectItems(dev, WIA.WiaImageIntent.UnspecifiedIntent, WIA.WiaImageBias.MaximizeQuality, True, True, True) 'show the pictures in the device selected

        itm = SelectedItems(1)
        If FileName = vbNullString Then FileName = itm.Properties("Item Name").Value 'use the original name
        img = dg.ShowTransfer(itm, , True) 'transfer the picture to imgfile
        Dim saved As Boolean
        saved = SaveImage(img, SaveLocation, FileName)
        If saved = False Then
            Return vbNullString
        Else
            Return SaveLocation & FileName & ".jpeg" 'return the Photo
        End If

        Exit Function
errhandler:
        If Err.Number = -2145320939 Then
            MessageBox.Show("No compatible Scanner or Camera Device detected. Please connect one!", AppName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf Err.Number = -2145320860 Then
            ' ShowAlertMessage(Err.Description)
        End If
    End Function


    Private Function SaveImage(ByVal img As WIA.ImageFile, ByVal SaveLocation As String, ByVal FileName As String) As Boolean

        On Error Resume Next
        If My.Computer.FileSystem.DirectoryExists(SaveLocation) = False Then 'if destination directory not exists
            My.Computer.FileSystem.CreateDirectory(SaveLocation) 'then create one!
        End If

        If Strings.Right(SaveLocation, 1) <> "\" Then SaveLocation = SaveLocation & "\"
        If Not img Is Nothing Then

            Dim tempfile As String = SaveLocation & "temp" & "." & img.FileExtension.ToLower
            If My.Computer.FileSystem.FileExists(tempfile) Then
                FileIO.FileSystem.DeleteFile(tempfile)
            End If
            img.SaveFile(tempfile)

            Dim x As Bitmap = New Bitmap(tempfile)
            x.SetResolution(Int(x.HorizontalResolution), Int(x.VerticalResolution))
            ' FileIO.FileSystem.DeleteFile(SaveLocation & FileName & ".jpeg")
            x.Save(SaveLocation & FileName & ".jpeg", Imaging.ImageFormat.Jpeg)
            x.Dispose()
            FileIO.FileSystem.DeleteFile(tempfile)
            Return True
        Else
            Return False
        End If

    End Function

   
#End Region


#Region "SEARCH"

    Private Sub SearchDatabase() Handles btnSearch.Click, SearchMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim name = Me.txtName.Text.Trim & "%"
            Dim aliasname = Me.txtAliasName.Text.Trim & "%"
            Dim age = Me.txtAge.Text.Trim & "%"
            Dim district = Me.cmbDistrict.Text.Trim & "%"
            Dim ps = Me.cmbPS.Text.Trim & "%"
            Dim adress = Me.txtAdress.Text.Trim & "%"
            Dim moclass = Me.txtMOClass.Text.Trim & "%"
            Dim fpclass = Me.txtFPClass.Text.Trim & "%"
            Dim crimeno = Me.txtCrimeNo.Text.Trim & "%"

            Me.MOCriminalTableAdapter.Search(Me.MOCriminalsDatabaseDataSet.MOCriminal, name, aliasname, age, crimeno, district, ps, moclass, adress, fpclass)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, AppName)
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub MOCriminalDataGridView_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) 'Handles MOCriminalDataGridView.KeyPress
        On Error Resume Next
        Static SearchText As String
        Static LastKeyPress As Date

        If DateDiff(DateInterval.Second, LastKeyPress, Now) >= 2 Then 'if more than 2 seconds has passed, clear the string

            If System.Char.IsLetterOrDigit(e.KeyChar) Then
                SearchText = CStr(e.KeyChar)
                ' Me.txtSearch.Text = SearchText
            End If
        Else
            If e.KeyChar = vbBack Then
                If SearchText.Length > 0 Then
                    SearchText = SearchText.Remove(SearchText.Length - 1)
                Else
                    SearchText = ""
                End If

            Else
                If System.Char.IsLetterOrDigit(e.KeyChar) Then
                    SearchText += CStr(e.KeyChar)

                End If

            End If


        End If

        LastKeyPress = Now
        '  If SearchText <> "" Then Me.txtSearch.Text = SearchText


        ' If Me.MOCriminalDataGridView.RowCount = 0 Then Exit Sub
        Dim i = Me.MOCriminalDataGridView.CurrentCell.ColumnIndex

        Dim field As String = Me.MOCriminalDataGridView.Columns(i).DataPropertyName
        MOCriminalBindingSource.Filter = (field & " like '" & SearchText & "%'")
        Me.MOCriminalDataGridView.CurrentRow.Cells(i).Selected = True
    End Sub


    Private Sub LoadFieldsToComboBox()
        On Error Resume Next
        For i = 1 To 11
            Me.cmbFields.Items.Add(Me.MOCriminalDataGridView.Columns(i).HeaderText)
        Next
        Me.cmbFields.SelectedIndex = 0
    End Sub

    Private Sub txtSearch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.Click
        On Error Resume Next
        If Me.txtSearch.Text <> "" Then
            SearchFromSearchTextBox()
        End If
    End Sub

    Private Sub txtSearch_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.GotFocus
        On Error Resume Next
        If Me.txtSearch.ForeColor = Color.Gray Then
            Me.txtSearch.ForeColor = Color.Black
            Me.txtSearch.Text = ""
        End If
    End Sub

    Private Sub txtSearch_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSearch.LostFocus
        On Error Resume Next
        If Me.txtSearch.Text = "" Or Me.txtSearch.Text = "[Enter Search Text]" Then
            Me.txtSearch.ForeColor = Color.Gray
            Me.txtSearch.Text = "[Enter Search Text]"
        End If
    End Sub



    Private Sub SearchFromSearchTextBox() Handles txtSearch.TextChanged
        On Error Resume Next
        If Me.txtSearch.ForeColor <> Color.Gray Then
            Dim i = Me.cmbFields.SelectedIndex + 1
            Dim field As String = Me.MOCriminalDataGridView.Columns(i).DataPropertyName
            MOCriminalBindingSource.Filter = (field & " like '" & Me.txtSearch.Text & "%'")
        End If
    End Sub

#End Region


#Region "END APPLICAION"

    Private Sub EndApplication() Handles MyBase.FormClosed
        On Error Resume Next
        SaveMOCriminalDataGridColumnOrder()
        SaveMOCriminalDataGridColumnWidth()
        UpdateDatabase()
        objMutex.Close()
        objMutex = Nothing
        Me.Dispose()
    End Sub
#End Region


   
    

  
    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        On Error Resume Next
        frmAbout.ShowDialog()
    End Sub

    
  
    
End Class
