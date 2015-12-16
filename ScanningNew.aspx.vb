
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Net.Mail

Partial Class ScanningNew
    Inherits Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CurrentTimeTB.Text = DateTime.Now.ToString("MM/dd/yyyy")

        Dim con As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Site_ConnectionString").ConnectionString)
        con.Open()
        Dim da As New SqlDataAdapter("exec sp_SelectHardwareCustomer", con)
        Dim dt As New DataTable

        da.Fill(dt)

        Dim HardwareCustomer As String = dt.Rows(0)("ConfigValue").ToString()
        con.Close()

        CustomerTB.Text = HardwareCustomer



    End Sub

    Protected Sub ScanningCancel_Click(sender As Object, e As EventArgs) Handles HardwareOrderCancel.Click
        Response.Redirect("~/Scanning")
    End Sub



End Class