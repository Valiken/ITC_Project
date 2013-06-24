''' <summary>
''' Represents a section of an offered course. 
''' </summary>
''' <remarks>TODO:
''' - constructor to initialize all values
''' - code cleanup and documentation
''' - better class description</remarks>
Public Class Section
    'This class will receive a Student, Course, Room and teacher making up a schedule of classes that were held and who was there
    'All id's should be saved here
    'should receive the grade or status of each student
    Private m_courseID, m_roomID, m_teacherID, m_sectionID, m_scheduleID, m_days As String
    Private m_studentsID As New ArrayList
    Private m_startTime As TimeSpan

    Public Sub New()

    End Sub

    Public Property SectionID As String
        Get
            Return m_sectionID
        End Get
        Set(value As String)
            m_sectionID = value
        End Set
    End Property

    Public Property CourseID As String
        Get
            Return m_courseID
        End Get
        Set(value As String)
            m_courseID = value
        End Set
    End Property

    Public Property RoomID As String
        Get
            Return m_roomID
        End Get
        Set(value As String)
            m_roomID = value
        End Set
    End Property

    Public Property TeacherID As String
        Get
            Return m_teacherID
        End Get
        Set(value As String)
            m_teacherID = value
        End Set
    End Property

    Public Property Days As String
        Get
            Return m_days
        End Get
        Set(value As String)
            m_days = value
        End Set
    End Property

    Public Property ScheduleID As String
        Get
            Return m_scheduleID
        End Get
        Set(value As String)
            m_scheduleID = value
        End Set
    End Property

    Public Property StartTime As TimeSpan
        Get
            Return m_startTime
        End Get
        Set(value As TimeSpan)
            m_StartTime = value
        End Set
    End Property

    Public Property StudentsID As ArrayList
        Get
            Return m_studentsID
        End Get
        Set(value As ArrayList)
            m_studentsID = value
        End Set
    End Property

    Public Sub addStudentID(ByVal ID As String)
        m_studentsID.Add(ID)
    End Sub

    Public Function getAllStudentsIDs() As String
        Dim count As String = m_studentsID.Count - 1
        Dim msg As String = "Students ID: "
        Dim index As Integer

        For index = 0 To count Step 1
            msg += m_studentsID.Item(index) & ", "
        Next
        msg += vbCrLf
        Return msg
    End Function
    
    'Returns ID's contained in section (needs updating)
    Public Function getSectionDescription() As String
        Dim msg As String = ""

        msg += "Schedule ID: " & m_sectionID & vbCrLf
        msg += "Course ID: " & m_courseID & vbCrLf
        msg += "Room ID: " & m_roomID & vbCrLf
        msg += "Teacher ID: " & m_teacherID & vbCrLf
        msg += getAllStudentsIDs()

        Return msg
    End Function
End Class
