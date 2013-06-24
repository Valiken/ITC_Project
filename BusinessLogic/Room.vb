''' <summary>
''' This class represents a classroom on campus.
''' </summary>
''' <remarks>TODO:
''' - better tostring method
''' - code cleanup and documentation</remarks>
Public Class Room
    'This class should make up what a room is (ID, location)
    Private m_id As String
    Private m_capacity As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal capacity As Integer)
        m_id = id
        m_capacity = capacity
    End Sub

    Public Property ID As String
        Get
            Return m_id
        End Get
        Set(ByVal value As String)
            m_id = value
        End Set
    End Property

    Public Property Capacity As Integer
        Get 
            Return m_capacity
        End Get
        Set(ByVal value As Integer)
            m_capacity = value
        End Set
    End Property

    'needs fixin
    Public Function getDescription()
        Return "Room ID: " & m_id & vbCrLf & "Current Capacity: " & m_capacity
    End Function
End Class
