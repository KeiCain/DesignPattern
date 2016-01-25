Module SingletonClient

    Sub Main()
        Dim singleton As SynchronizedMethodSingleton = SynchronizedMethodSingleton.GetInstance
        Dim singleton2 As EagerSingleton = EagerSingleton.GetInstance
        Dim singleton3 As DoubleCheckedSingleton = DoubleCheckedSingleton.GetInstance
    End Sub

End Module
