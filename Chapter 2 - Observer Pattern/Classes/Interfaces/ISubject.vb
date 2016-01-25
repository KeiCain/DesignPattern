Public Interface ISubject
    Sub RegisterObserver(ByVal o As IObserver)
    Sub RemoveObserver(ByVal o As IObserver)
    Sub NotifyObservers()
End Interface
