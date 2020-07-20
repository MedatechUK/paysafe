Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft

Namespace PaySafe.Base

    Public MustInherit Class Request : Implements IDisposable

        Private _uri As String
        Private _Request As HttpWebRequest

        Public MustOverride ReadOnly Property uri As String
        Public MustOverride ReadOnly Property verb As String
        Public MustOverride ReadOnly Property responseType As Type

        Private _result As Object
        Public Property Result As Object
            Get
                Return _result
            End Get
            Set(value As Object)
                _result = value
            End Set
        End Property

        Sub New(e As Object, ParamArray args() As String)
            _Request = CType(HttpWebRequest.Create(String.Format("{0}{1}", Settings.baseUrl, String.Format(Me.uri, args))), Net.HttpWebRequest)

            With _Request
                .Method = Me.verb
                .Proxy = Nothing
                .UserAgent = "Medatech .net oData Client"
                .ContentType = "application/json"
                .Headers.Add("authorization", System.Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(Settings.APIkey)).ToString)

                Try
                    Using writer = New StreamWriter(_Request.GetRequestStream())
                        writer.Write(ASCIIEncoding.ASCII.GetBytes(Json.JsonConvert.SerializeObject(e)))
                        .ContentLength = writer.BaseStream.Length

                    End Using

                Catch : End Try

                Using r = TryCast(_Request.GetResponse(), HttpWebResponse)
                    With r
                        If .StatusCode = 200 Then
                            Using reader = New IO.StreamReader(r.GetResponseStream())
                                Result = Json.JsonConvert.DeserializeObject(reader.ReadToEnd(), responseType)

                            End Using

                        Else
                            Try
                                Using reader = New IO.StreamReader(r.GetResponseStream())
                                    Result = Json.JsonConvert.DeserializeObject(reader.ReadToEnd(), GetType(PaySafe.error))

                                End Using

                            Catch ex As Exception

                            End Try

                        End If
                    End With


                End Using

            End With

        End Sub

        Sub New(ParamArray args() As String)

            _Request = CType(HttpWebRequest.Create(String.Format("{0}{1}", Settings.baseUrl, String.Format(Me.uri, args))), Net.HttpWebRequest)
            With _Request
                .Method = Me.verb
                .Proxy = Nothing
                .UserAgent = "Medatech .net oData Client"
                .ContentType = "application/json"
                .Headers.Add("authorization", System.Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(Settings.APIkey)).ToString)

                Using r = TryCast(_Request.GetResponse(), HttpWebResponse)
                    With r
                        If .StatusCode = 200 Then
                            Using reader = New IO.StreamReader(r.GetResponseStream())
                                Result = Json.JsonConvert.DeserializeObject(reader.ReadToEnd(), responseType)

                            End Using

                        Else
                            Try
                                Using reader = New IO.StreamReader(r.GetResponseStream())
                                    _result = Json.JsonConvert.DeserializeObject(reader.ReadToEnd(), GetType(PaySafe.error))

                                End Using

                            Catch ex As Exception

                            End Try

                        End If

                    End With

                End Using

            End With

        End Sub

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
