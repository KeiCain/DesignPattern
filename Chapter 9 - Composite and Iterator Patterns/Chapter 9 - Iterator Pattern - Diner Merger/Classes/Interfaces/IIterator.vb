Public Interface IIterator(Of T)
    Function HasNext() As Boolean
    Function GetNext() As T
End Interface
