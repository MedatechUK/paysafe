﻿Imports System.IO
Imports System.Net
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Web
Imports System.Web.Configuration
Imports Newtonsoft.Json

Namespace oData

    ''' <summary>
    ''' An oData client
    ''' </summary>
    Public Class oClient : Implements IDisposable

        ''' <summary>
        ''' This method load the approproiate configuration
        ''' depending if there is an http context.
        ''' If there is no context settings come from odata.config 
        ''' in the executing path.
        ''' Otherwise the settings come from the web.config file
        ''' of the website.
        ''' </summary>
        ''' <returns></returns>
        Private ReadOnly Property settings As odataConfig
            Get
                If HttpContext.Current Is Nothing Then ' Use config file
                    Dim cFile As New FileInfo(
                        Path.Combine(
                            Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly.Location),
                            "odata.config"
                        )
                    )
                    If cFile.Exists Then
                        Try
                            Dim s As New XmlSerializer(GetType(odataConfig))
                            Using sr As New StreamReader(cFile.FullName)
                                Return s.Deserialize(sr)
                            End Using

                        Catch ex As Exception
                            Throw New Exception(
                                String.Format(
                                    "Error loading odata.config {0}. {1}",
                                    cFile.FullName,
                                    ex.Message
                                )
                            )

                        End Try

                    Else
                        Throw New Exception(
                            String.Format(
                                "Missing odata.config in {0}.",
                                cFile.DirectoryName
                            )
                        )

                    End If

                Else ' Use web config
                    Dim c As New odataConfig
                    With c
                        .oDataHost = WebConfigurationManager.AppSettings("oDataHost")
                        .tabulaini = WebConfigurationManager.AppSettings("tabulaini")
                        .environment = WebConfigurationManager.AppSettings("environment")
                        .ouser = WebConfigurationManager.AppSettings("ouser")
                        .opass = WebConfigurationManager.AppSettings("opass")

                    End With

                    Return c

                End If

            End Get

        End Property

        Private _Request As Net.HttpWebRequest
        Public Property Request As Net.HttpWebRequest
            Get
                Return _Request
            End Get
            Set(value As Net.HttpWebRequest)
                _Request = value
            End Set
        End Property


        ''' <summary>
        ''' oClient constructor method.
        ''' </summary>
        ''' <param name="Path">String</param>
        ''' <param name="Method">String</param>
        Sub New(Path As String, Optional Method As String = "POST", Optional Query As String = "")

            Try
                Dim config As odataConfig = settings
                Dim uri As New UriBuilder

                With uri
                    .Scheme = Split(config.oDataHost, "://")(0)
                    .Host = Split(config.oDataHost, "://")(1)
                    .Path = String.Format(
                        "/odata/Priority/{0}/{1}{2}",
                        config.tabulaini,
                        config.environment,
                        Path
                    )
                    .Query = Query

                    'Log(Me, "{0} {1}", Method.ToUpper, uri.ToString)

                    _Request = CType(Net.HttpWebRequest.Create(.Uri), Net.HttpWebRequest)
                    With _Request
                        .Method = Method
                        .Proxy = Nothing
                        .UserAgent = "Medatech .net oData Client"
                        .ContentType = "application/json"
                        .Credentials = New NetworkCredential(
                            config.ouser,
                            config.opass
                        )

                    End With

                End With

            Catch ex As Exception
                Throw New Exception(
                    String.Format(
                        "{0}",
                        ex.Message
                    )
                )

            End Try

        End Sub

        ''' <summary>
        ''' Returns a WebResponse or an exception in 
        ''' response to the Requested MemoryStream.
        ''' </summary>
        ''' <param name="Request"></param>
        ''' <returns>Object</returns>
        Public Function GetResponse(Optional ByRef Request As MemoryStream = Nothing) As Object

            Dim e As Object
            Dim buffer(1024) As Byte
            Dim bytesRead As Integer

            System.Net.ServicePointManager.ServerCertificateValidationCallback =
          Function(se As Object,
          cert As System.Security.Cryptography.X509Certificates.X509Certificate,
          chain As System.Security.Cryptography.X509Certificates.X509Chain,
          sslerror As System.Net.Security.SslPolicyErrors) True

            With _Request
                Try
                    If Not Request Is Nothing Then
                        .ContentLength = Request.Length
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

                    e = .GetResponse()

                Catch ex As WebException
                    e = ex

                Catch ex As Exception
                    e = ex

                End Try

            End With

            Return e

        End Function

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