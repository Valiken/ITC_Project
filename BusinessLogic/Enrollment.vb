Public Class Enrollment
        Private m_grade, m_quarter, m_year As String
        Private m_section As Section

        Public Sub new()
            
        End Sub

        Public Sub new(ByVal section As Section)
            Me.SectionTaken = section
        End Sub

         Public Sub new(ByVal section As Section, ByVal grade As String)
            Me.SectionTaken = section
            Me.Grade = grade
        End Sub

        Public Sub New(ByVal section As Section, ByVal grade As String, byval year As String, byVal quarter as String)
            Me.SectionTaken = section
            Me.Grade = grade
            Me.Year = year
            Me.Quarter = quarter
        End Sub 

        public Property SectionTaken As Section
            Get
                Return m_section
            End Get
            Set(ByVal value As Section)
                m_section = value
            End Set
        end property 

        Public Property Grade As String

            Get
                Return m_grade
            End Get
            Set(ByVal value As String)
                m_grade = value
            End Set
        end property

        Public Property Year As String

            Get
                Return m_year
            End Get
            Set(ByVal value As String)
                m_year = value
            End Set
        end property

        Public Property Quarter As String

            Get
                Return m_quarter
            End Get
            Set(ByVal value As String)
                m_quarter = value
            End Set
        end property
    End Class
