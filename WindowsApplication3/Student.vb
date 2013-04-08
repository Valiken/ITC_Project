''' <summary>
''' This class represents a student enrolled in the university
''' </summary>
''' <remarks>Things that need to be implemented: 
''' - retreving course data from enrolled classes
''' - finalize way to store enrollment data
''' - data and functions required for views
''' - code cleanup and documentation
''' - save to db (if needed)</remarks>
Public Class Student

    Private m_ID, m_Name, m_enrolledQuarter As String
    Private m_enrolledYear As Integer
    Private m_enrolledDate As Date
    Private m_ExpectedGraduation As Date = Now
    Private m_CurrentStudent As Boolean = False
    Private m_coursesTaken As New Collection
    Private m_curriculum As Curriculum
    Private m_courses As New ArrayList

    Public Sub New()

    End Sub

    Public Sub New(ByVal id As String, ByVal name As String,
            ByVal enrolledYear As String, ByVal enrolledQuarter As String, ByVal currentStudent As Boolean) ' Optional ByVal expectedGraudationDate As Date = Now
        'Me.ExpectedGraduationDate = expectedGraudationDate
        Me.ID = id
        Me.Name = name
        'Me.EnrolledDate = enrolledDate
        Me.EnrolledYear = enrolledYear
        Me.EnrolledQuarter = enrolledQuarter
        Me.CurrentStudent = currentStudent
    End Sub



    Public Property ID As String
        Get
            Return m_ID
        End Get
        Set(ByVal value As String)
            m_ID = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property

    Public Property EnrolledQuarter As String
        Get
            Return m_enrolledQuarter
        End Get
        Set(ByVal value As String)
            m_enrolledQuarter = value
        End Set
    End Property

    Public Property EnrolledYear As Integer
        Get
            Return m_enrolledYear
        End Get
        Set(ByVal value As Integer)
            m_enrolledYear = value
        End Set
    End Property

    Public Property EnrolledDate As Date
        Get
            Return m_enrolledDate
        End Get
        Set(ByVal value As Date)
            m_enrolledDate = value
        End Set
    End Property
    Public Property ExpectedGraduationDate As Date
        Get
            Return m_ExpectedGraduation
        End Get
        Set(ByVal value As Date)
            m_ExpectedGraduation = value
        End Set
    End Property
    Public Property CurrentStudent As Boolean
        Get
            Return m_CurrentStudent
        End Get
        Set(ByVal value As Boolean)
            m_CurrentStudent = value
        End Set
    End Property

    Public Property Courses As Collection
        Get
            Return m_coursesTaken
        End Get
        Set(ByVal value As Collection)
            m_coursesTaken = value
        End Set
    End Property


    Public Property CurrentCurriculum As Curriculum
        Get
            Return m_curriculum
        End Get
        Set(ByVal value As Curriculum)
            m_curriculum = value
        End Set
    End Property

    Public Property SectionsTaken As ArrayList

        Get
            Return m_courses
        End Get
        Set

        End Set
    end property

    

   

    Public Function getStudentDescription()
        Dim msg As String = ""
        msg += "Student ID: " & m_ID & vbCrLf & " Student Name: " & m_Name & vbCrLf & " Enrolled Quarter: " & m_enrolledQuarter & vbCrLf & " Enrolled Year: " & m_enrolledYear & vbCrLf & " Current Student: " & m_CurrentStudent & vbCrLf
        If m_CurrentStudent = True Then
            msg += "Expected Graduation: " & m_ExpectedGraduation
        End If
        If Not m_coursesTaken.Count = 0 Then
            msg += vbCrLf & " Courses Taken" & vbCrLf
            For Each courseTaken As Course In m_coursesTaken
                msg += "  " & courseTaken.ID & vbCrLf
            Next
        End If


        Return msg
    End Function

    Public Sub addCourse(ByVal section As Section)
        m_courses.Add(New Enrollment(section))
    End Sub

     Public Sub addCourseTakenWithGrade(ByVal section As Section, ByVal grade As String)
        m_courses.Add(New Enrollment(section, grade))
    End Sub

    Public Sub addCourseTakenWithGradeAndDate(ByVal section As Section, ByVal grade As String, byval year As String, byVal quarter as String)
        m_courses.Add(New Enrollment(section, grade, year, quarter))
    end sub

End Class
