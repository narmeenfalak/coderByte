Imports System.IO
Imports System.Net
Imports System.Web.Optimization

Partial Class home
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Protected Sub bttnSearch_Click(sender As Object, e As EventArgs) Handles bttnSearch.Click

        ServicePointManager.Expect100Continue = True
        'ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3
        'System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
        'ServicePointManager.ServerCertificateValidationCallback = (snder, cert, chain, error) => true;
        ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072

        'Create request for URL
        Dim request As WebRequest =
          WebRequest.Create("https://api.github.com/users/lipis/gists")
        'Get the response

        Dim response As WebResponse = request.GetResponse()

        ' Display the status.
        'Console.WriteLine(CType(response, HttpWebResponse).StatusDescription)
        Label1.Text = CType(response, HttpWebResponse).StatusDescription

        ' Get the stream containing content returned by the server.
        Dim dataStream As Stream = response.GetResponseStream()

        ' Open the stream using a StreamReader for easy access.
        Dim reader As New StreamReader(dataStream)

        ' Read the content.
        Dim responseFromServer As String = reader.ReadToEnd()

        ' Display the content.
        'Console.WriteLine(responseFromServer)
        Label2.Text = responseFromServer

        ' Clean up the streams and the response.
        reader.Close()
        response.Close()

    End Sub

End Class
