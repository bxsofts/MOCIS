<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainInterface
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainInterface))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MOCriminalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.MOCriminalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MOCriminalsDatabaseDataSet = New MO_Criminal_Database.MOCriminalsDatabaseDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbFields = New System.Windows.Forms.ToolStripComboBox()
        Me.txtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.MOCriminalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.picMOCriminalsPicture = New System.Windows.Forms.PictureBox()
        Me.PanelDataEntry = New System.Windows.Forms.Panel()
        Me.btnScanCriminalPicture = New System.Windows.Forms.Button()
        Me.btnSelectMOCriminalsPicture = New System.Windows.Forms.Button()
        Me.btnScanFPSLip = New System.Windows.Forms.Button()
        Me.btnSelectFPSlip = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnReload = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSearch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAbout = New System.Windows.Forms.ToolStripButton()
        Me.btnSaveMain = New System.Windows.Forms.Button()
        Me.txtMOCriminalsPicture = New System.Windows.Forms.TextBox()
        Me.txtFPSlip = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.cmbPS = New System.Windows.Forms.ComboBox()
        Me.AutoPSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbDistrict = New System.Windows.Forms.ComboBox()
        Me.AutoDistrictBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtMOClass = New System.Windows.Forms.TextBox()
        Me.txtFPClass = New System.Windows.Forms.TextBox()
        Me.txtCrimeNo = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtAliasName = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReloadMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.picFPSlip = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MOCriminalTableAdapter = New MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.MOCriminalTableAdapter()
        Me.TableAdapterManager = New MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.AutoNameFieldTableAdapter = New MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.AutoNameFieldTableAdapter()
        Me.AutoAliasNameTableAdapter = New MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.AutoAliasNameTableAdapter()
        Me.AutoDistrictTableAdapter = New MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.AutoDistrictTableAdapter()
        Me.AutoPSTableAdapter = New MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.AutoPSTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.MOCriminalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MOCriminalBindingNavigator.SuspendLayout()
        CType(Me.MOCriminalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOCriminalsDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MOCriminalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMOCriminalsPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDataEntry.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.AutoPSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AutoDistrictBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.picFPSlip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MOCriminalBindingNavigator
        '
        Me.MOCriminalBindingNavigator.AddNewItem = Nothing
        Me.MOCriminalBindingNavigator.BindingSource = Me.MOCriminalBindingSource
        Me.MOCriminalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MOCriminalBindingNavigator.DeleteItem = Nothing
        Me.MOCriminalBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MOCriminalBindingNavigator.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MOCriminalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripLabel2, Me.cmbFields, Me.txtSearch})
        Me.MOCriminalBindingNavigator.Location = New System.Drawing.Point(0, 725)
        Me.MOCriminalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MOCriminalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MOCriminalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MOCriminalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MOCriminalBindingNavigator.Name = "MOCriminalBindingNavigator"
        Me.MOCriminalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MOCriminalBindingNavigator.Size = New System.Drawing.Size(1370, 25)
        Me.MOCriminalBindingNavigator.TabIndex = 1
        Me.MOCriminalBindingNavigator.Text = "BindingNavigator1"
        '
        'MOCriminalBindingSource
        '
        Me.MOCriminalBindingSource.DataMember = "MOCriminal"
        Me.MOCriminalBindingSource.DataSource = Me.MOCriminalsDatabaseDataSet
        '
        'MOCriminalsDatabaseDataSet
        '
        Me.MOCriminalsDatabaseDataSet.DataSetName = "MOCriminalsDatabaseDataSet"
        Me.MOCriminalsDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.AutoSize = False
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(50, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(44, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(30, 22)
        Me.ToolStripLabel2.Text = "Find"
        '
        'cmbFields
        '
        Me.cmbFields.AutoSize = False
        Me.cmbFields.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFields.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbFields.MaxDropDownItems = 10
        Me.cmbFields.Name = "cmbFields"
        Me.cmbFields.Size = New System.Drawing.Size(115, 23)
        '
        'txtSearch
        '
        Me.txtSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSearch.ForeColor = System.Drawing.Color.Gray
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(200, 25)
        Me.txtSearch.Text = "[Enter Search Text]"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(92, 75)
        Me.btnDelete.Text = "Delete"
        '
        'MOCriminalDataGridView
        '
        Me.MOCriminalDataGridView.AllowUserToAddRows = False
        Me.MOCriminalDataGridView.AllowUserToOrderColumns = True
        Me.MOCriminalDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MOCriminalDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MOCriminalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MOCriminalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn12})
        Me.MOCriminalDataGridView.DataSource = Me.MOCriminalBindingSource
        Me.MOCriminalDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MOCriminalDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.MOCriminalDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MOCriminalDataGridView.MultiSelect = False
        Me.MOCriminalDataGridView.Name = "MOCriminalDataGridView"
        Me.MOCriminalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MOCriminalDataGridView.Size = New System.Drawing.Size(1125, 468)
        Me.MOCriminalDataGridView.TabIndex = 0
        Me.MOCriminalDataGridView.TabStop = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AliasName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Alias Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Age"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "District"
        Me.DataGridViewTextBoxColumn5.HeaderText = "District"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "PoliceStation"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Police Station"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CrimeNo"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Crime No"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "FPClassification"
        Me.DataGridViewTextBoxColumn10.HeaderText = "FP Classification"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MOClassification"
        Me.DataGridViewTextBoxColumn7.HeaderText = "MO Classification"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Adress"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Adress"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 200
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "ImageLocation"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Image Location"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "FPSlipLocation"
        Me.DataGridViewTextBoxColumn12.HeaderText = "FP Slip Location"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 200
        '
        'picMOCriminalsPicture
        '
        Me.picMOCriminalsPicture.BackColor = System.Drawing.SystemColors.ControlDark
        Me.picMOCriminalsPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMOCriminalsPicture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picMOCriminalsPicture.Location = New System.Drawing.Point(3, 21)
        Me.picMOCriminalsPicture.Name = "picMOCriminalsPicture"
        Me.picMOCriminalsPicture.Size = New System.Drawing.Size(211, 231)
        Me.picMOCriminalsPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMOCriminalsPicture.TabIndex = 2
        Me.picMOCriminalsPicture.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picMOCriminalsPicture, "Double click to view in external viewer")
        '
        'PanelDataEntry
        '
        Me.PanelDataEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDataEntry.Controls.Add(Me.btnScanCriminalPicture)
        Me.PanelDataEntry.Controls.Add(Me.btnSelectMOCriminalsPicture)
        Me.PanelDataEntry.Controls.Add(Me.btnScanFPSLip)
        Me.PanelDataEntry.Controls.Add(Me.btnSelectFPSlip)
        Me.PanelDataEntry.Controls.Add(Me.Panel4)
        Me.PanelDataEntry.Controls.Add(Me.btnSaveMain)
        Me.PanelDataEntry.Controls.Add(Me.txtMOCriminalsPicture)
        Me.PanelDataEntry.Controls.Add(Me.txtFPSlip)
        Me.PanelDataEntry.Controls.Add(Me.txtAdress)
        Me.PanelDataEntry.Controls.Add(Me.cmbPS)
        Me.PanelDataEntry.Controls.Add(Me.cmbDistrict)
        Me.PanelDataEntry.Controls.Add(Me.txtMOClass)
        Me.PanelDataEntry.Controls.Add(Me.txtFPClass)
        Me.PanelDataEntry.Controls.Add(Me.txtCrimeNo)
        Me.PanelDataEntry.Controls.Add(Me.txtAge)
        Me.PanelDataEntry.Controls.Add(Me.txtAliasName)
        Me.PanelDataEntry.Controls.Add(Me.Label11)
        Me.PanelDataEntry.Controls.Add(Me.Label10)
        Me.PanelDataEntry.Controls.Add(Me.Label9)
        Me.PanelDataEntry.Controls.Add(Me.Label8)
        Me.PanelDataEntry.Controls.Add(Me.Label7)
        Me.PanelDataEntry.Controls.Add(Me.Label6)
        Me.PanelDataEntry.Controls.Add(Me.Label5)
        Me.PanelDataEntry.Controls.Add(Me.Label4)
        Me.PanelDataEntry.Controls.Add(Me.Label3)
        Me.PanelDataEntry.Controls.Add(Me.Label2)
        Me.PanelDataEntry.Controls.Add(Me.Label1)
        Me.PanelDataEntry.Controls.Add(Me.txtName)
        Me.PanelDataEntry.Controls.Add(Me.MenuStrip1)
        Me.PanelDataEntry.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDataEntry.Location = New System.Drawing.Point(0, 0)
        Me.PanelDataEntry.Name = "PanelDataEntry"
        Me.PanelDataEntry.Size = New System.Drawing.Size(1370, 255)
        Me.PanelDataEntry.TabIndex = 3
        '
        'btnScanCriminalPicture
        '
        Me.btnScanCriminalPicture.Location = New System.Drawing.Point(1217, 171)
        Me.btnScanCriminalPicture.Name = "btnScanCriminalPicture"
        Me.btnScanCriminalPicture.Size = New System.Drawing.Size(57, 25)
        Me.btnScanCriminalPicture.TabIndex = 19
        Me.btnScanCriminalPicture.TabStop = False
        Me.btnScanCriminalPicture.Text = "Scan"
        Me.btnScanCriminalPicture.UseVisualStyleBackColor = True
        '
        'btnSelectMOCriminalsPicture
        '
        Me.btnSelectMOCriminalsPicture.Location = New System.Drawing.Point(1154, 171)
        Me.btnSelectMOCriminalsPicture.Name = "btnSelectMOCriminalsPicture"
        Me.btnSelectMOCriminalsPicture.Size = New System.Drawing.Size(57, 25)
        Me.btnSelectMOCriminalsPicture.TabIndex = 18
        Me.btnSelectMOCriminalsPicture.TabStop = False
        Me.btnSelectMOCriminalsPicture.Text = "Select"
        Me.btnSelectMOCriminalsPicture.UseVisualStyleBackColor = True
        '
        'btnScanFPSLip
        '
        Me.btnScanFPSLip.Location = New System.Drawing.Point(1217, 212)
        Me.btnScanFPSLip.Name = "btnScanFPSLip"
        Me.btnScanFPSLip.Size = New System.Drawing.Size(57, 25)
        Me.btnScanFPSLip.TabIndex = 17
        Me.btnScanFPSLip.TabStop = False
        Me.btnScanFPSLip.Text = "Scan"
        Me.btnScanFPSLip.UseVisualStyleBackColor = True
        '
        'btnSelectFPSlip
        '
        Me.btnSelectFPSlip.Location = New System.Drawing.Point(1154, 212)
        Me.btnSelectFPSlip.Name = "btnSelectFPSlip"
        Me.btnSelectFPSlip.Size = New System.Drawing.Size(57, 25)
        Me.btnSelectFPSlip.TabIndex = 16
        Me.btnSelectFPSlip.TabStop = False
        Me.btnSelectFPSlip.Text = "Select"
        Me.btnSelectFPSlip.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ToolStrip1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1368, 80)
        Me.Panel4.TabIndex = 14
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnEdit, Me.btnDelete, Me.ToolStripSeparator1, Me.btnReload, Me.ToolStripSeparator2, Me.btnSearch, Me.ToolStripSeparator3, Me.btnAbout})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1366, 78)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(83, 75)
        Me.btnNew.Text = "New"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(79, 75)
        Me.btnEdit.Text = "Edit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 78)
        '
        'btnReload
        '
        Me.btnReload.Image = CType(resources.GetObject("btnReload.Image"), System.Drawing.Image)
        Me.btnReload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnReload.Name = "btnReload"
        Me.btnReload.Size = New System.Drawing.Size(95, 75)
        Me.btnReload.Text = "Reload"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 78)
        '
        'btnSearch
        '
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(94, 75)
        Me.btnSearch.Text = "Search"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 78)
        '
        'btnAbout
        '
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(92, 75)
        Me.btnAbout.Text = "About"
        '
        'btnSaveMain
        '
        Me.btnSaveMain.Image = CType(resources.GetObject("btnSaveMain.Image"), System.Drawing.Image)
        Me.btnSaveMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSaveMain.Location = New System.Drawing.Point(1164, 96)
        Me.btnSaveMain.Name = "btnSaveMain"
        Me.btnSaveMain.Size = New System.Drawing.Size(98, 56)
        Me.btnSaveMain.TabIndex = 12
        Me.btnSaveMain.Text = "Save"
        Me.btnSaveMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSaveMain.UseVisualStyleBackColor = True
        '
        'txtMOCriminalsPicture
        '
        Me.txtMOCriminalsPicture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtMOCriminalsPicture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.txtMOCriminalsPicture.Location = New System.Drawing.Point(889, 171)
        Me.txtMOCriminalsPicture.MaxLength = 255
        Me.txtMOCriminalsPicture.Name = "txtMOCriminalsPicture"
        Me.txtMOCriminalsPicture.Size = New System.Drawing.Size(259, 25)
        Me.txtMOCriminalsPicture.TabIndex = 9
        '
        'txtFPSlip
        '
        Me.txtFPSlip.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtFPSlip.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystemDirectories
        Me.txtFPSlip.Location = New System.Drawing.Point(889, 212)
        Me.txtFPSlip.MaxLength = 255
        Me.txtFPSlip.Name = "txtFPSlip"
        Me.txtFPSlip.Size = New System.Drawing.Size(259, 25)
        Me.txtFPSlip.TabIndex = 10
        '
        'txtAdress
        '
        Me.txtAdress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAdress.Location = New System.Drawing.Point(889, 89)
        Me.txtAdress.MaxLength = 255
        Me.txtAdress.Multiline = True
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(259, 66)
        Me.txtAdress.TabIndex = 8
        '
        'cmbPS
        '
        Me.cmbPS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbPS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPS.DataSource = Me.AutoPSBindingSource
        Me.cmbPS.DisplayMember = "PoliceStation"
        Me.cmbPS.FormattingEnabled = True
        Me.cmbPS.Location = New System.Drawing.Point(518, 89)
        Me.cmbPS.MaxLength = 255
        Me.cmbPS.Name = "cmbPS"
        Me.cmbPS.Size = New System.Drawing.Size(259, 25)
        Me.cmbPS.TabIndex = 4
        '
        'AutoPSBindingSource
        '
        Me.AutoPSBindingSource.DataMember = "AutoPS"
        Me.AutoPSBindingSource.DataSource = Me.MOCriminalsDatabaseDataSet
        '
        'cmbDistrict
        '
        Me.cmbDistrict.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbDistrict.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDistrict.DataSource = Me.AutoDistrictBindingSource
        Me.cmbDistrict.DisplayMember = "District"
        Me.cmbDistrict.FormattingEnabled = True
        Me.cmbDistrict.Location = New System.Drawing.Point(99, 212)
        Me.cmbDistrict.MaxLength = 255
        Me.cmbDistrict.Name = "cmbDistrict"
        Me.cmbDistrict.Size = New System.Drawing.Size(259, 25)
        Me.cmbDistrict.TabIndex = 3
        '
        'AutoDistrictBindingSource
        '
        Me.AutoDistrictBindingSource.DataMember = "AutoDistrict"
        Me.AutoDistrictBindingSource.DataSource = Me.MOCriminalsDatabaseDataSet
        '
        'txtMOClass
        '
        Me.txtMOClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtMOClass.Location = New System.Drawing.Point(518, 212)
        Me.txtMOClass.MaxLength = 255
        Me.txtMOClass.Name = "txtMOClass"
        Me.txtMOClass.Size = New System.Drawing.Size(259, 25)
        Me.txtMOClass.TabIndex = 7
        '
        'txtFPClass
        '
        Me.txtFPClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFPClass.Location = New System.Drawing.Point(518, 171)
        Me.txtFPClass.MaxLength = 255
        Me.txtFPClass.Name = "txtFPClass"
        Me.txtFPClass.Size = New System.Drawing.Size(259, 25)
        Me.txtFPClass.TabIndex = 6
        '
        'txtCrimeNo
        '
        Me.txtCrimeNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtCrimeNo.Location = New System.Drawing.Point(518, 127)
        Me.txtCrimeNo.MaxLength = 255
        Me.txtCrimeNo.Name = "txtCrimeNo"
        Me.txtCrimeNo.Size = New System.Drawing.Size(259, 25)
        Me.txtCrimeNo.TabIndex = 5
        '
        'txtAge
        '
        Me.txtAge.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAge.Location = New System.Drawing.Point(99, 171)
        Me.txtAge.MaxLength = 255
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(259, 25)
        Me.txtAge.TabIndex = 2
        '
        'txtAliasName
        '
        Me.txtAliasName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtAliasName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtAliasName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAliasName.Location = New System.Drawing.Point(99, 127)
        Me.txtAliasName.MaxLength = 255
        Me.txtAliasName.Name = "txtAliasName"
        Me.txtAliasName.Size = New System.Drawing.Size(259, 25)
        Me.txtAliasName.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(834, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 17)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Picture"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(834, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 17)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "FP Slip"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(834, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Adress"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(406, 212)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "MO Classification"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(406, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "FP Classification"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(406, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Crime No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(406, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Police Station"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alias Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Age"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "District"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(99, 89)
        Me.txtName.MaxLength = 255
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(259, 25)
        Me.txtName.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewMenuItem, Me.EditMenuItem, Me.DeleteMenuItem, Me.ReloadMenuItem, Me.SearchMenuItem, Me.SaveMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1442, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'NewMenuItem
        '
        Me.NewMenuItem.Name = "NewMenuItem"
        Me.NewMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.NewMenuItem.Text = "New"
        '
        'EditMenuItem
        '
        Me.EditMenuItem.Name = "EditMenuItem"
        Me.EditMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.EditMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditMenuItem.Text = "Edit"
        '
        'DeleteMenuItem
        '
        Me.DeleteMenuItem.Name = "DeleteMenuItem"
        Me.DeleteMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.DeleteMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.DeleteMenuItem.Text = "Delete"
        '
        'ReloadMenuItem
        '
        Me.ReloadMenuItem.Name = "ReloadMenuItem"
        Me.ReloadMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.ReloadMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ReloadMenuItem.Text = "Reload"
        '
        'SearchMenuItem
        '
        Me.SearchMenuItem.Name = "SearchMenuItem"
        Me.SearchMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SearchMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.SearchMenuItem.Text = "Search"
        '
        'SaveMenuItem
        '
        Me.SaveMenuItem.Name = "SaveMenuItem"
        Me.SaveMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.SaveMenuItem.Text = "Save"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MOCriminalDataGridView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 255)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1127, 470)
        Me.Panel1.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblName)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(1127, 255)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(243, 470)
        Me.Panel3.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(5, 270)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(299, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.picFPSlip)
        Me.GroupBox2.Location = New System.Drawing.Point(49, 298)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(217, 255)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FP Slip"
        '
        'picFPSlip
        '
        Me.picFPSlip.BackColor = System.Drawing.SystemColors.ControlDark
        Me.picFPSlip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFPSlip.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picFPSlip.Location = New System.Drawing.Point(3, 21)
        Me.picFPSlip.Name = "picFPSlip"
        Me.picFPSlip.Size = New System.Drawing.Size(211, 231)
        Me.picFPSlip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFPSlip.TabIndex = 3
        Me.picFPSlip.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picFPSlip, "Double click to view in external viewer")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picMOCriminalsPicture)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 255)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Photo"
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "MO Criminal Database"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.RestoreDirectory = True
        '
        'MOCriminalTableAdapter
        '
        Me.MOCriminalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.MOCriminalTableAdapter = Me.MOCriminalTableAdapter
        Me.TableAdapterManager.UpdateOrder = MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AutoNameFieldTableAdapter
        '
        Me.AutoNameFieldTableAdapter.ClearBeforeFill = True
        '
        'AutoAliasNameTableAdapter
        '
        Me.AutoAliasNameTableAdapter.ClearBeforeFill = True
        '
        'AutoDistrictTableAdapter
        '
        Me.AutoDistrictTableAdapter.ClearBeforeFill = True
        '
        'AutoPSTableAdapter
        '
        Me.AutoPSTableAdapter.ClearBeforeFill = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'frmMainInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelDataEntry)
        Me.Controls.Add(Me.MOCriminalBindingNavigator)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frmMainInterface"
        Me.Text = "MO Criminal Information System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.MOCriminalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MOCriminalBindingNavigator.ResumeLayout(False)
        Me.MOCriminalBindingNavigator.PerformLayout()
        CType(Me.MOCriminalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOCriminalsDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MOCriminalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMOCriminalsPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDataEntry.ResumeLayout(False)
        Me.PanelDataEntry.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.AutoPSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AutoDistrictBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.picFPSlip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MOCriminalsDatabaseDataSet As MO_Criminal_Database.MOCriminalsDatabaseDataSet
    Friend WithEvents MOCriminalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MOCriminalTableAdapter As MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.MOCriminalTableAdapter
    Friend WithEvents TableAdapterManager As MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MOCriminalBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MOCriminalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents picMOCriminalsPicture As System.Windows.Forms.PictureBox
    Friend WithEvents PanelDataEntry As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picFPSlip As System.Windows.Forms.PictureBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents AutoNameFieldTableAdapter As MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.AutoNameFieldTableAdapter
    Friend WithEvents AutoAliasNameTableAdapter As MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.AutoAliasNameTableAdapter
    Friend WithEvents AutoDistrictTableAdapter As MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.AutoDistrictTableAdapter
    Friend WithEvents AutoPSTableAdapter As MO_Criminal_Database.MOCriminalsDatabaseDataSetTableAdapters.AutoPSTableAdapter
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMOClass As System.Windows.Forms.TextBox
    Friend WithEvents txtFPClass As System.Windows.Forms.TextBox
    Friend WithEvents txtCrimeNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents txtAliasName As System.Windows.Forms.TextBox
    Friend WithEvents cmbPS As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDistrict As System.Windows.Forms.ComboBox
    Friend WithEvents txtMOCriminalsPicture As System.Windows.Forms.TextBox
    Friend WithEvents txtFPSlip As System.Windows.Forms.TextBox
    Friend WithEvents txtAdress As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveMain As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnReload As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReloadMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnScanCriminalPicture As System.Windows.Forms.Button
    Friend WithEvents btnSelectMOCriminalsPicture As System.Windows.Forms.Button
    Friend WithEvents btnScanFPSLip As System.Windows.Forms.Button
    Friend WithEvents btnSelectFPSlip As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents AutoPSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AutoDistrictBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents cmbFields As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel

End Class
