''' <summary>
''' Contains all schedules loaded and created by application.
''' </summary>
''' <remarks>TODO:
''' - generate data from TSV file
''' - create file that contains schedules made by program
''' - functions needed by views if any
''' - code cleanup and documentation</remarks>
Public Class ScheduleDatabase
    'This class holds a collection of schedule objects and pushes updates to relevant tables in sql db
    Private m_scheduleDatabase As New Collection

    Public Sub New()
        'pull data from sql db to this database placeholder
  

    End Sub

    Public Property MasterDatabase As Collection
        Get
            Return m_scheduleDatabase
        End Get
        Set(value As Collection)
            m_scheduleDatabase = value
        End Set
    End Property

    Public Sub addSchedule(ByVal schedule As Schedule)
        If Not m_scheduleDatabase.Contains(schedule.ScheduleID) Then
            m_scheduleDatabase.Add(schedule, schedule.ScheduleID)
        Else
            m_scheduleDatabase.Remove(schedule.ScheduleID)
            m_scheduleDatabase.Add(schedule, schedule.ScheduleID)
        End If

    End Sub

    Public Function getSchedule(ByVal id As String) As Schedule
        Return m_scheduleDatabase.Item(id)
    End Function

    Public Function getAllSchedule() As ArrayList
        Dim list As New ArrayList
        For Each sched As Schedule In m_scheduleDatabase
            list.Add(sched)
        Next
        Return list
    End Function

End Class
