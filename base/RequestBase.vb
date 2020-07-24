Imports System.IO
Imports System.Net
Imports System.Text
Imports MedatechUK.PaySafe.Vault
Imports Newtonsoft
Imports Newtonsoft.Json

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

        Sub New(Settings As PaySafe.Settings, ParamArray args() As String)
            Request(Settings, Nothing, args)

        End Sub

        Sub New(Settings As PaySafe.Settings, e As Object, ParamArray args() As String)
            Request(Settings, e, args)

        End Sub

        Private Sub Request(Settings As PaySafe.Settings, e As Object, ParamArray args() As String)

            Dim r As Object
            Dim buffer(1024) As Byte
            Dim bytesRead As Integer

            _Request = CType(HttpWebRequest.Create(String.Format("{0}{1}", Settings.baseUrl, String.Format(Me.uri, args))), Net.HttpWebRequest)
            With _Request

                .Method = Me.verb
                .Proxy = Nothing
                .UserAgent = "Medatech .net oData Client"
                .ContentType = "application/json"
                .Headers.Add("Authorization", Settings.Auth)

                Console.WriteLine("{0} {1}", Me.verb, String.Format("{0}{1}", Settings.baseUrl, String.Format(Me.uri, args)))

                Dim js = New JsonSerializerSettings()
                js.NullValueHandling = NullValueHandling.Ignore

                Dim rStr As String = JsonConvert.SerializeObject(e, js)
                Dim Request As MemoryStream = New MemoryStream(ASCIIEncoding.ASCII.GetBytes(rStr))
                Try
                    If Not e Is Nothing Then
                        Console.WriteLine(rStr)

                        Using requestStream As Stream = .GetRequestStream()
                            With requestStream
                                While True
                                    bytesRead = Request.Read(buffer, 0, buffer.Length)
                                    If bytesRead = 0 Then
                                        Exit While

                                    End If
                                    .Write(buffer, 0, bytesRead)

                                End While

                            End With

                        End Using

                    End If

                    r = .GetResponse
                    Using reader As New StreamReader(TryCast(r, WebResponse).GetResponseStream)
                        _result = Json.JsonConvert.DeserializeObject(reader.ReadToEnd(), Me.responseType)

                    End Using

                Catch ex As WebException
                    With ex
                        If TryCast(.Response, HttpWebResponse) Is Nothing Then
                            r = New Exception(ex.Status.ToString)

                        Else
                            Using reader As New StreamReader(.Response.GetResponseStream)
                                _result = Json.JsonConvert.DeserializeObject(reader.ReadToEnd(), GetType(ResponseErr))

                            End Using


                        End If

                    End With

                End Try

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
