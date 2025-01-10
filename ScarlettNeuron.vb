Public Class ScarlettNeuron
    Public ReadOnly Property HasData() As Boolean
        Get
            If Current = 0 _
                    AndAlso Worst = 0 _
                    AndAlso Threshold = 0 _
                    AndAlso Data = 0 Then
                Return False
            End If
            Return True
        End Get
    End Property

    Public Property Attribute() As String
    Public Property Current() As Integer
    Public Property Worst() As Integer
    Public Property Threshold() As Integer
    Public Property Data() As Integer
    Public Property IsOK() As Boolean

    Public Sub New()

    End Sub

    Public Sub New(attributeName As String)
        Attribute = attributeName
    End Sub

End Class
