Imports System.Runtime.InteropServices

Public Class Win32
    <Flags>
    Public Enum ProcessAccessFlags As UInteger
        All = &H1F0FFF
        Terminate = &H1
        CreateThread = &H2
        VirtualMemoryOperation = &H8
        VirtualMemoryRead = &H10
        VirtualMemoryWrite = &H20
        DuplicateHandle = &H40
        CreateProcess = &H80
        SetQuota = &H100
        SetInformation = &H200
        QueryInformation = &H400
        QueryLimitedInformation = &H1000
        Synchronize = &H100000
    End Enum

    <DllImport("kernel32.dll")>
    Public Shared Function OpenProcess(dwDesiredAccess As ProcessAccessFlags, bInheritHandle As Boolean, dwProcessId As Integer) As IntPtr
    End Function

    <DllImport("kernel32.dll")>
    Public Shared Function ReadProcessMemory(hProcess As IntPtr, lpBaseAddress As IntPtr,
<Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex:=3)> lpBuffer As Byte(), dwSize As Integer, <Out> ByRef lpNumberOfBytesRead As IntPtr) As Integer
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function WriteProcessMemory(hProcess As IntPtr, lpBaseAddress As IntPtr, lpBuffer As Byte(), nSize As Integer, <Out> ByRef lpNumberOfBytesWritten As IntPtr) As Boolean
    End Function

    <Flags>
    Public Enum AllocationType
        Commit = &H1000
        Reserve = &H2000
        Decommit = &H4000
        Release = &H8000
        Reset = &H80000
        Physical = &H400000
        TopDown = &H100000
        WriteWatch = &H200000
        LargePages = &H20000000
    End Enum

    <Flags>
    Public Enum MemoryProtection
        Execute = &H10
        ExecuteRead = &H20
        ExecuteReadWrite = &H40
        ExecuteWriteCopy = &H80
        NoAccess = &H1
        [ReadOnly] = &H2
        ReadWrite = &H4
        WriteCopy = &H8
        GuardModifierflag = &H100
        NoCacheModifierflag = &H200
        WriteCombineModifierflag = &H400
    End Enum

    <DllImport("kernel32.dll", SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function VirtualAllocEx(hProcess As IntPtr, lpAddress As IntPtr, dwSize As IntPtr, flAllocationType As AllocationType, flProtect As MemoryProtection) As IntPtr
    End Function

    <Flags>
    Public Enum FreeType
        Decommit = &H4000
        Release = &H8000
    End Enum
    <DllImport("kernel32.dll", SetLastError:=True, ExactSpelling:=True)>
    Public Shared Function VirtualFreeEx(hProcess As IntPtr, lpAddress As IntPtr, dwSize As Integer, dwFreeType As FreeType) As Boolean
    End Function

    <DllImport("kernel32.dll")>
    Public Shared Function CreateRemoteThread(hProcess As IntPtr, lpThreadAttributes As IntPtr, dwStackSize As UInteger, lpStartAddress As IntPtr, lpParameter As IntPtr, dwCreationFlags As UInteger, <Out> ByRef lpThreadId As IntPtr) As IntPtr
    End Function

    Public Shared Function AllocateRemoteBuffer(ProcessHandle As IntPtr, Buffer As Byte()) As IntPtr
        Dim RemoteBufferAddr = VirtualAllocEx(ProcessHandle, IntPtr.Zero, CType(Buffer.Length, IntPtr), Win32.AllocationType.Reserve Or Win32.AllocationType.Commit, Win32.MemoryProtection.ExecuteReadWrite)
        If RemoteBufferAddr = IntPtr.Zero Then
            Throw New Exception("Error: Could not allocate memory for buffer")
        End If

        Dim NumBytes As IntPtr
        If Not WriteProcessMemory(ProcessHandle, RemoteBufferAddr, Buffer, Buffer.Length, NumBytes) Then
            Throw New Exception("Error: Could not write buffer to remote process")
        End If

        Return RemoteBufferAddr
    End Function
End Class
