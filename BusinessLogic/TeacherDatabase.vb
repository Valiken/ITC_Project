''' <summary>
''' A db of teachers
''' </summary>
''' <remarks>TODO:
''' - initialize with a number of teachers
''' - cleanup and docs
''' - better class description
''' - db connections(if needed)</remarks>
Public Class TeacherDatabase
    'This class should contain the master database of all teachers possible
    Private m_id As Integer
    Private m_Name As String
    Private m_teacherDatabase As New Collection

    Public Property ID As Integer
        Get
            Return m_id
        End Get
        Set(value As Integer)
            m_id = value
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

    Public Property MasterDatabase As Collection
        Get
            Return m_teacherDatabase
        End Get
        Set(value As Collection)
            m_teacherDatabase = value
        End Set
    End Property

    Public Sub setTeacher(ByVal teacher As Teacher)
        m_teacherDatabase.Add(teacher, teacher.ID)
    End Sub

    Public Function getTeacher(ByVal ID As String)
        Return m_teacherDatabase.Item(ID)
    End Function

    Public Function getAllTeachers() As ArrayList
        Dim list As New ArrayList
        Dim teacher As Teacher
        For Each teacher In m_teacherDatabase
            list.Add(teacher)
        Next
        Return list
    End Function

End Class
