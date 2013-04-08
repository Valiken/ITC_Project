Public Class Controller
    Shared ctrlCourseDB As New CoursesDatabase
    Shared ctrlStudentDB As New StudentDatabase
    Shared ctrlTeacherDB As New TeacherDatabase
    Shared ctrlRoomDB As New RoomDatabase
    Shared ctrlScheduleDB As New ScheduleDatabase
    Shared ctrlCurriculumDB As New CurriculumDatabase 

    Public Shared Function getCourseDB()
        Return ctrlCourseDB.MasterDatabase
    End Function

    Public Shared Sub updateCourseDB(ByVal db As Collection)
        ctrlCourseDB.MasterDatabase = db
    End Sub

    Public Shared Function getStudentDB()
        Return ctrlStudentDB.MasterDatabase
    End Function

    Public Shared Sub updateStudentDB(ByVal db As Collection)
        ctrlStudentDB.MasterDatabase = db
    End Sub

    Public Shared Function getTeacherDB()
        Return ctrlTeacherDB.MasterDatabase
    End Function

    Public Shared Sub updateTeacherDB(ByVal db As Collection)
        ctrlTeacherDB.MasterDatabase = db
    End Sub

    Public Shared Function getRoomDB()
        Return ctrlRoomDB.MasterDatabase
    End Function

    Public Shared Sub updateRoomDB(ByVal db As Collection)
        ctrlRoomDB.MasterDatabase = db
    End Sub

    Public Shared Function getScheduleDB()
        Return ctrlScheduleDB.MasterDatabase
    End Function

    Public Shared Sub updateScheduleDB(ByVal db As Collection)
        ctrlScheduleDB.MasterDatabase = db

    End Sub

    Public Shared Function getCurriculumDB()
        Return ctrlCurriculumDB.MasterDatabase
    End Function

    Public Shared Sub updateCurriculumDB(ByVal db As Collection)
        ctrlCurriculumDB.MasterDatabase = db

    End Sub

End Class
