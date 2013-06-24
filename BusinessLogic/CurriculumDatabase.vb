Public Class CurriculumDatabase

    Private m_cdatabase As new Collection

    Public Sub new()

    End Sub

    Property MasterDatabase As Collection
        Get
            Return m_cdatabase 
        End Get
        Set(ByVal value As Collection)          
            m_cdatabase = value
        End Set
    end property

    Public Sub addCurriculum(ByVal curriculum As Curriculum)
        m_cdatabase.Add(curriculum,curriculum.ID)
    End Sub

    Public Function getCurriculum(ByVal id As String)
        Return m_cdatabase.Item(id)
    End Function

End Class
