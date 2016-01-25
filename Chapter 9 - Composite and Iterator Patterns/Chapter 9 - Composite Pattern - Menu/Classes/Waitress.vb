Public Class Waitress
    Private m_allMenus As MenuComponent

    Public Sub New(ByVal allMenus As MenuComponent)
        m_allMenus = allMenus
    End Sub

    Public Sub PrintMenu()
        m_allMenus.Print()
    End Sub
End Class
