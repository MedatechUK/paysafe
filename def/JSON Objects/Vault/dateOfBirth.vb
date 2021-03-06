﻿Namespace PaySafe.Vault
    Public Class dateOfBirth : Implements IDisposable

    Sub New()

    End Sub

    Sub New(dt As Date)
        _year = dt.Year
        _month = dt.Month
        _day = dt.Day

    End Sub

    Private _year As Integer
    ''' <summary> 
    '''This is the year of birth.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property year As Integer
        Get
            Return _year
        End Get
        Set(value As Integer)
            _year = value
        End Set
    End Property

    Private _month As Integer
    ''' <summary> 
    '''This is the month of birth.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property month As Integer
        Get
            Return _month
        End Get
        Set(value As Integer)
            _month = value
        End Set
    End Property

    Private _day As Integer
    ''' <summary> 
    '''This is the day of birth.
    ''' </summary> 
    ''' <returns></returns> 
    Public Property day As Integer
        Get
            Return _day
        End Get
        Set(value As Integer)
            _day = value
        End Set
    End Property

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region


End Class

End Namespace
