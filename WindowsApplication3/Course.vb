''' <summary>
''' This class represents a course offered by the university. This class contains 
''' </summary>
''' <remarks>TODO:
''' - perhaps better tostring method
''' - code cleanup</remarks>
Public Class Course

    Private m_ID, m_title As String
    Private m_units As Integer
    Private m_companionCourse, m_PreRequisit As String
    Private m_prerequisite As ArrayList
    Private m_AmtNeeded As Integer

    Public Sub New()

    End Sub

    ''' <summary>
    ''' Construct new course with given parameters
    ''' </summary>
    ''' <param name="id"></param>
    ''' <param name="units"></param>
    ''' <param name="companionCourse"></param>
    ''' <param name="prerequisiteCourse"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal id As String, ByVal units As Integer, ByVal companionCourse As String, ByVal prerequisiteCourse As ArrayList)
        Me.ID = id
        Me.Units = units
        Me.CompanionCourse = companionCourse
        Me.PreRequisitCourse = prerequisiteCourse

    End Sub

    Public Property AmountNeeded As Integer
        Get
            Return m_AmtNeeded
        End Get
        Set(value As Integer)
            m_AmtNeeded = value
        End Set
    End Property
    ''' <summary>
    ''' A String of the ID of the companion course of this course if any exists
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Property CompanionCourse As String
        Get
            Return m_companionCourse
        End Get
        Set(value As String)
            m_companionCourse = value
        End Set
    End Property

    ''' <summary>
    ''' A List of ID's for prerequisites if any exists
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property PreRequisitCourse As ArrayList
        Get
            Return m_prerequisite
        End Get
        Set(value As ArrayList)
            m_prerequisite = value
        End Set
    End Property

    ''' <summary>
    ''' THe unit value of this course
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Units As Integer
        Get
            Return m_units
        End Get
        Set(value As Integer)
            m_units = value
        End Set
    End Property

    ''' <summary>
    ''' The class ID of this course
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ID As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = value
        End Set
    End Property

    Public Property Title As String
        Get
            Return m_title
        End Get
        Set(value As String)
            m_title = value
        End Set
    End Property

    ''' <summary>
    ''' Returns a brief description of the course. Needs work.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getCourseDescription()
        Dim result As String
        result = "Course ID: " & m_ID & vbCrLf & "Units: " & m_units & vbCrLf
        If m_companionCourse <> "" Then
            result += "Companion Course: " & m_companionCourse & vbCrLf
        End If
        If m_PreRequisit <> "" Then
            result += "PreRequisit Course: " & m_PreRequisit & vbCrLf
        End If


        Return result


    End Function


End Class
