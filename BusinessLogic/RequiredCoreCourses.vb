Public Class RequiredCoreCourses
    'This class should take a "PrerequisitClasses" & "CoreRequirements" that will make up one of the 3 main sections -Miguel
   Private m_courses As New ArrayList
    Public Property Courses As ArrayList
        Get
            Return m_courses
        End Get
        Set(ByVal value As ArrayList)
            m_courses = value
        End Set
    End Property

    Public Sub addCourse(ByVal course As String)
        m_courses.Add(course)
    End Sub

End Class
