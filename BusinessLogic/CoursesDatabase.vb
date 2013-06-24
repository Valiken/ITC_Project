''' <summary>
''' This class contains all courses in the university. Data can be intialized from a TSV file.
''' </summary>
''' <remarks>TODO:
''' - constructor to initialize data from file
''' - code cleanup and documentation</remarks>
Public Class CoursesDatabase
    Private m_courseDatabase As New Collection


    Public Property MasterDatabase As Collection
        Get
            Return m_courseDatabase
        End Get
        Set(value As Collection)
            m_courseDatabase = value
        End Set
    End Property

    Public Sub New()
   
    End Sub

    Public Sub addCourse(ByVal course As Course)

        m_courseDatabase.Add(course, course.ID)
    End Sub

    Public Function getCourse(ByVal ID As String)
        Return m_courseDatabase.Item(ID)
    End Function
End Class
