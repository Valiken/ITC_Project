﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCreateCurriculum.Click

        'Testing creating a course and adding prerequisit Course
        Dim tempCourseDB As Collection = Controller.getCourseDB
        Dim tempTeacherDB As Collection = Controller.getTeacherDB
        Dim tempRoomDB As Collection = Controller.getRoomDB
        Dim tempStudentDB As Collection = Controller.getStudentDB
        Dim tempScheduleDB As Collection = Controller.getScheduleDB

        Dim course As New Course("CS101", 4, "", New ArrayList())
        tempCourseDB.Add(course, course.ID)

        Dim templist As New ArrayList()
        templist.Add("CS 101")
        course = New Course("CS102", 4, "", templist)
        tempCourseDB.Add(course, course.ID)
        course = New Course("CS103", 4, "CS102", New ArrayList())
        tempCourseDB.Add(course, course.ID)


        'Test Teacher
        Dim teacher As New Teacher(998877, "Dr. S Curl")
        tempTeacherDB.Add(teacher, teacher.ID)
        teacher = New Teacher
        teacher.ID = "667788"
        teacher.Name = "Dr. S Zhang"
        tempTeacherDB.Add(teacher, teacher.ID)

        'Test Room
        Dim room As New Room
        room.ID = "CLA-1001"

        tempRoomDB.Add(room, room.ID)


        room = New Room
        room.ID = "CLA-1002"

        'Test Data'
        tempRoomDB.Add(room, room.ID)
        Dim sect1 As New Section
        sect1.CourseID = "CS103"
        Dim sect2 As New Section
        sect2.CourseID = "CS222"
        Dim sect3 As New Section
        sect3.CourseID = "CS333"

        course = New Course("CS222", 4, "CS102", New ArrayList())
        tempCourseDB.Add(course, course.ID)
        course = New Course("CS333", 4, "CS222", New ArrayList())
        tempCourseDB.Add(course, course.ID)

        Dim curriculum1 As New Curriculum
        curriculum1.ID = "1999"
        Dim student As New Student("112233", "Miguel Venegas", "2012", "Fall", True, curriculum1)
        student.addCourseTakenWithGrade(sect1, "A")
        student.addCourseTakenWithGrade(sect2, "B+")
        student.addCourseTakenWithGrade(sect3, "C+")
        tempStudentDB.Add(student, student.ID)

        Dim curriculum2 As New Curriculum
        curriculum2.ID = "2009"
        student = New Student("442233", "MarTIN Legaspi", "2012", "Fall", True, curriculum2)
        student.addCourseTakenWithGrade(sect1, "B")
        student.addCourseTakenWithGrade(sect2, "C-")
        student.addCourseTakenWithGrade(sect3, "D")
        tempStudentDB.Add(student, student.ID)
        '/End Test Data'

        'test adding room, course, student and professor  into a master schedule
        Dim scheduler As New Section
        scheduler.SectionID = "Spring-2012"
        scheduler.CourseID = "CIS-304"
        scheduler.RoomID = "CLA-1001"
        scheduler.TeacherID = "667788"
        scheduler.addStudentID("442233")
        scheduler.addStudentID("112233")
        tempScheduleDB.Add(scheduler, scheduler.ScheduleID)

        Controller.updateCourseDB(tempCourseDB)
        Controller.updateRoomDB(tempRoomDB)
        Controller.updateScheduleDB(tempScheduleDB)
        Controller.updateStudentDB(tempStudentDB)
        Controller.updateTeacherDB(tempTeacherDB)
    End Sub


End Class
