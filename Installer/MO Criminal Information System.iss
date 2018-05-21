
[Setup]
AppName=MO Criminal Information System
AppVerName=MO Criminal Information System V 1.0
VersionInfoVersion=1.0
VersionInfoCompany=BXSofts
VersionInfoProductName= MO Criminal Information System
VersionInfoProductVersion=1.0
VersionInfoDescription=Designed and programmed by Baiju Xavior, Fingerprint Expert.
VersionInfoTextVersion=1.0
VersionInfoCopyright=C@P BXSofts
MinVersion=0,5
AppComments=Designed and programmed by Baiju Xavior, Fingerprint Expert.
AppCopyright=Copyright © Baiju Xavior 2010-2011
AppPublisher=BXSofts, Inc.
AppMutex=MO_Criminal_Information_System_APPMUTEX
AppID={{35378e35-8e10-4097-9384-c4d2621cef8a}
;DefaultDirName={pf}\BXSofts\Fingerprint Information System
DefaultDirName=D:\MO Criminal Information System
DefaultGroupName=BXSofts\MO Criminal Information System
OutputDir=.
UsePreviousAppDir=yes
UsePreviousGroup=yes
UsePreviousSetupType=yes
OutputBaseFilename=MO Criminal Information System V 1.0 Setup
SolidCompression=true
PrivilegesRequired=admin
;ChangesAssociations=true
TerminalServicesAware=yes
AllowNoIcons=yes
AllowRootDirectory=No
AlwaysShowDirOnReadyPage=yes
AlwaysShowGroupOnReadyPage=yes
AlwaysUsePersonalGroup=yes
Uninstallable=yes
UninstallDisplayIcon={app}\MO Criminal Information System.exe
UninstallFilesDir={app}
WizardImageBackColor=clRed
WindowVisible=false
WizardImageFile=.\Icons\WizModernImage-IS.bmp
WizardSmallImageFile=.\Icons\WizModernSmallImage-IS.bmp
SetupIconFile=.\Icons\Setup Icon.ico

[Icons]
Name: {group}\MO Criminal Information System; Filename: {app}\MO Criminal Information System.exe
Name: {group}\{cm:UninstallProgram,MO Criminal Information System}; Filename: {uninstallexe}
Name: {commondesktop}\MO Criminal Information System; Filename: {app}\MO Criminal Information System.exe; Tasks: desktopicon; Comment: "Designed and programmed by Baiju Xavior, Fingerprint Expert."



[CustomMessages]
dotnetmissing=Setup has detected that Microsoft .NET Framework v3.5 is not installed in your system. The application will not work correctly until you install it. Do you want to install the application any way?



[code]
function InitializeSetup(): Boolean;
var
    NetFrameWorkInstalled : Boolean;
    Result1 : Boolean;
begin

	NetFrameWorkInstalled := RegKeyExists(HKLM,'SOFTWARE\Microsoft\NET Framework Setup\NDP\v3.5');
	if NetFrameWorkInstalled =true then
	  begin
		Result := true;
	end;

	if NetFrameWorkInstalled =false then
		begin
			Result1 := MsgBox(ExpandConstant('{cm:dotnetmissing}'),mbConfirmation, MB_YESNO) = idYes;
			if Result1 =true then
				begin
					Result:=true;
			    end
	    end;
  end;

[Files]
Source: .\Fonts\segoeui.ttf; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Segoe UI
Source: .\Fonts\segoeuib.ttf; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Segoe UI Bold
Source: .\Fonts\SEGOEUII.TTF; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Sego UI Italic
Source: .\Fonts\SEGOEUIZ.TTF; DestDir: {fonts}; Flags: onlyifdoesntexist uninsneveruninstall; FontInstall: Sego UI BoldItalic

Source: ..\MO Criminal Database\bin\Release\MO Criminal Information System.pdb; DestDir: {app}\; Flags: ignoreversion
Source: ..\MO Criminal Database\bin\Release\MO Criminal Information System.xml; DestDir: {app}\; Flags: ignoreversion
Source: ..\MO Criminal Database\bin\Release\MO Criminal Information System.exe.config; DestDir: {app}\; Flags: ignoreversion
Source: ..\MO Criminal Database\bin\Release\MO Criminal Information System.exe; DestDir: {app}\; Flags: ignoreversion
Source: ..\MO Criminal Database\bin\Release\Interop.WIA.dll; DestDir: {app}\; Flags: ignoreversion
Source: .\Database\MOCriminalsDatabase.mdb; DestDir: {userdocs}\BXSofts\MO Criminal Information System\Database\; Flags: onlyifdoesntexist uninsneveruninstall
Source: .\Database\MOCriminalsDatabase.mdb; DestDir: {app}\; Flags: onlyifdoesntexist uninsneveruninstall

[Registry]
Root: HKCU; Subkey: Software\BXSofts; Flags: noerror
Root: HKCU; Subkey: Software\BXSofts\MO Criminal Information System; Flags: uninsdeletekey noerror
Root: HKCU; Subkey: Software\BXSofts\MO Criminal Information System\MOCriminalDataGrid; Flags: uninsdeletekey noerror

Root: HKCU; Subkey: Software\BXSofts\MO Criminal Information System; ValueType: string; ValueName: FPSlipLocation; ValueData: D:\FP Slips\; Flags: noerror uninsdeletekey createvalueifdoesntexist
Root: HKCU; Subkey: Software\BXSofts\MO Criminal Information System; ValueType: string; ValueName: MOCriminalPictureLocation; ValueData: D:\MO Criminals' Pictures\; Flags: noerror uninsdeletekey createvalueifdoesntexist
Root: HKCU; Subkey: Software\BXSofts\MO Criminal Information System; ValueType: string; ValueName: FirstRun; ValueData: 1;  Flags: noerror uninsdeletekey   createvalueifdoesntexist

[Run]
Filename: {app}\MO Criminal Information System.exe; Description: {cm:LaunchProgram,MO Criminal Information System}; Flags: nowait postinstall skipifsilent runascurrentuser; WorkingDir: {app}

[UninstallDelete]
Name: {app}\MO Criminal Information System.pdb; Type: files
Name: {app}\MO Criminal Information System.xml; Type: files
Name: {app}\MO Criminal Information System.exe.config; Type: files
Name: {app}\MO Criminal Information System.exe; Type: files
Name: {app}\MO Criminal Information System.exe.manifest; Type: files
Name: {app}\MO Criminal Information System.application; Type: files
Name: {app}\Interop.WIA.dll; Type: files
Name: {app}; Type: dirifempty
Name: {userdocs}\BXSofts\MO Criminal Information System; Type: dirifempty
Name: {userdocs}\BXSofts; Type: dirifempty

[Tasks]
Name: desktopicon; Description: {cm:CreateDesktopIcon}; GroupDescription: {cm:AdditionalIcons}

[Dirs]
Name: {userdocs}\BXSofts\MO Criminal Information System\Database

