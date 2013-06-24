''' <summary>
''' Contains all students enrolled in the university.
''' </summary>
''' <remarks>TODO:
''' - generate db from list of students(works in tandem with yet to be created class that generates students)
''' - functions needed by views
''' - code cleanup and documentation</remarks>
Public Class StudentDatabase
    'This class should have all the students in the database
    'This class can also generate students based on parameters (not yet implemented)
    Private m_studentDatabase As New Collection

    

    Public Property MasterDatabase As Collection
        Get
            Return m_studentDatabase
        End Get
        Set(value As Collection)
            m_studentDatabase = value
        End Set
    End Property

    Public Sub New()
      
    End Sub

    Public Sub addStudent(ByVal student As Student)
        m_studentDatabase.Add(student, student.ID)
    End Sub

    Public Function getStudent(ByVal ID As String)
        Return m_studentDatabase.Item(ID)
    End Function

    Public Function getAllStudents() As ArrayList
        Dim list As New ArrayList
        Dim student As Student
        For Each student In m_studentDatabase
            list.Add(student)
        Next
        Return list
    End Function
End Class
