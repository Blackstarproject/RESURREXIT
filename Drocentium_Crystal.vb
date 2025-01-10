Imports System.Runtime.InteropServices

Public Class Drocentium_Crystal
    <DllImport("KERNEL32.DLL", EntryPoint:="SetProcessWorkingSetSize", SetLastError:=True, CallingConvention:=CallingConvention.StdCall)>
    Friend Shared Function SetProcessWorkingSetSize(pProcess As IntPtr, dwMinimumWorkingSetSize As Integer, dwMaximumWorkingSetSize As Integer) As Boolean
    End Function

    <DllImport("KERNEL32.DLL", EntryPoint:="GetCurrentProcess", SetLastError:=True, CallingConvention:=CallingConvention.StdCall)>
    Friend Shared Function GetCurrentProcess() As IntPtr
    End Function

    Public Sub New()
        Dim pHandle As IntPtr = GetCurrentProcess()
        SetProcessWorkingSetSize(pHandle, -1, -1)
    End Sub
End Class
