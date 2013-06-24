''' <summary>
''' This database contains all rooms in the university. 
''' </summary>
''' <remarks>TODO:
''' - implement new constructor
''' - code cleanup and documentation</remarks>
Public Class RoomDatabase
    'This class should contain the main database of all rooms available
    Private m_roomDatabase As New Collection

    Public Sub New()
  
    End Sub

    ''' <summary>
    ''' Initializes database with given number of rooms. Uses default value of 30 capacity and starting ID of 0.
    ''' </summary>
    ''' <param name="numberOfRooms"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal numberOfRooms As Integer)
        'implementation goes here
    End Sub

    Public Property MasterDatabase As Collection
        Get
            Return m_roomDatabase
        End Get
        Set(ByVal value As Collection)
            m_roomDatabase = value
        End Set
    End Property

    Public Sub addRoom(ByVal room As Room)
        m_roomDatabase.Add(room, room.ID)
    End Sub

    Public Function getRoom(ByVal ID As String)
        Return m_roomDatabase.Item(ID)
    End Function

    Public Function getAllRooms() As ArrayList
        Dim list As New ArrayList
        Dim room As Room
        For Each room In m_roomDatabase
            list.Add(room)
        Next
        Return list
    End Function

End Class
