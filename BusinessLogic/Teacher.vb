''' <summary>
''' Represents a teacher in the university
''' </summary>
''' <remarks>TODO:
''' - cleanup and docs</remarks>
Public Class Teacher
    Private m_ID, m_Name As String


    Public Sub New()

    End Sub

    Public Sub New(ByVal ID As String, ByVal name As String)
        Me.ID = ID
        Me.Name = name

    End Sub

    Public Property ID As String 'Changed from Interget to a string because an ID can have letters ex: "CIS 304" - Miguel
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property
    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set(value As String)
            m_Name = value
        End Set
    End Property

    'Erased the Department property because the case only deals with ONE department - Miguel
    Public Function getTeacherDescription()
        Dim msg As String = ""

        msg += "Teacher ID: " & m_ID & vbCrLf & "Teacher Name: " & m_Name & vbCrLf

        Return msg

    End Function
End Class
