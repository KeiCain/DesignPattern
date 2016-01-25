Imports System.Text

Public Class GumballMachine
    Private m_count As Integer

    Private m_soldState As IState
    Private m_soldOutState As IState
    Private m_noQuarterState As IState
    Private m_hasQuarterState As IState
    Private m_WinnerState As IState
#Region "Properties"
    Private m_currentState As IState

    Public Property State() As IState
        Get
            Return m_currentState
        End Get
        Set(ByVal value As IState)
            m_currentState = value
        End Set
    End Property

    Public ReadOnly Property Count() As Integer
        Get
            Return m_count
        End Get
    End Property

    Public ReadOnly Property SoldState() As IState
        Get
            Return m_soldState
        End Get
    End Property

    Public ReadOnly Property SoldOutState() As IState
        Get
            Return m_soldOutState
        End Get
    End Property

    Public ReadOnly Property NoQuarterState() As IState
        Get
            Return m_noQuarterState
        End Get
    End Property

    Public ReadOnly Property HasQuarterState() As IState
        Get
            Return m_hasQuarterState
        End Get
    End Property

    Public ReadOnly Property WinnerState() As IState
        Get
            Return m_WinnerState
        End Get
    End Property
#End Region

    Public Sub New(ByVal numGumballs As Integer)
        m_soldOutState = New SoldOutState(Me)
        m_soldState = New SoldState(Me)
        m_noQuarterState = New NoQuarterState(Me)
        m_hasQuarterState = New HasQuarterState(Me)
        m_WinnerState = New WinnerState(Me)

        m_count = numGumballs
        If m_count > 0 Then
            m_currentState = m_noQuarterState
        End If
    End Sub

    Public Sub InsertQuarter()
        m_currentState.InsertQuarter()
    End Sub

    Public Sub EjectQuarter()
        m_currentState.EjectQuarter()
    End Sub

    Public Sub TurnCrank()
        m_currentState.TurnCrank()
        m_currentState.Dispense()
    End Sub

    Public Sub ReleaseBall()
        Console.WriteLine("A gumball comes rolling out the slot...")
        If m_count <> 0 Then
            m_count = m_count - 1
        End If
    End Sub

    Public Sub Refill(ByVal count As Integer)
        m_count = count
        m_currentState = m_noQuarterState
    End Sub

    Public Overrides Function ToString() As String
        Dim result As New stringbuilder
        result.AppendLine(Environment.NewLine + "Mighty Gumball, Inc.")
        result.AppendLine("VB-enabled Standing Gumball Model #2004")
        result.Append("Inventory: " + m_count.ToString + " gumball")
        If m_count <> 1 Then
            result.AppendLine("s")
        Else
            result.AppendLine()
        End If
        result.AppendLine("Machine is " + m_currentState.ToString)

        Return result.ToString()
    End Function
End Class
