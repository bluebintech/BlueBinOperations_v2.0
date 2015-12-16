
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Web
Imports System.Web.UI.WebControls
Imports System.IO
Imports System.Drawing

Partial Class ScanLines
    Inherits Page

    Dim UserLogin As String = Page.User.Identity.Name.ToString()
    Dim Location As String
    Dim Item1 As String
    Dim Qty1 As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CurrentTimeTB.Text = DateTime.Now.ToString("MM/dd/yyyy")
        ScannerTB.Text = UserLogin
        LocationDD.Focus()

    End Sub


    Public Sub ScanSubmit_Click(sender As Object, e As EventArgs) Handles ScanSubmit.Click
        Dim constr As String = ConfigurationManager.ConnectionStrings("Site_ConnectionString").ConnectionString
        Dim NewScanBatchID As String
        Using con As New SqlConnection(constr)
            Using cmd As New SqlCommand("sp_InsertScanBatch")
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Location", LocationDD.SelectedValue)
                cmd.Parameters.AddWithValue("@Scanner", ScannerTB.Text)
                cmd.Connection = con
                con.Open()
                'cmd.ExecuteNonQuery()
                NewScanBatchID = Convert.ToString(cmd.ExecuteScalar())
                con.Close()
            End Using
        End Using

        Dim Item1 As String = Item1TB.Text
        Dim Item2 As String = Item2TB.Text
        Dim Item3 As String = Item3TB.Text
        Dim Item4 As String = Item4TB.Text
        Dim Item5 As String = Item5TB.Text
        Dim Item6 As String = Item6TB.Text
        Dim Item7 As String = Item7TB.Text
        Dim Item8 As String = Item8TB.Text
        Dim Item9 As String = Item9TB.Text
        Dim Item10 As String = Item10TB.Text
        Dim Item11 As String = Item11TB.Text
        Dim Item12 As String = Item12TB.Text
        Dim Item13 As String = Item13TB.Text
        Dim Item14 As String = Item14TB.Text
        Dim Item15 As String = Item15TB.Text
        Dim Item16 As String = Item16TB.Text
        Dim Item17 As String = Item17TB.Text
        Dim Item18 As String = Item18TB.Text
        Dim Item19 As String = Item19TB.Text
        Dim Item20 As String = Item20TB.Text
        Dim Item21 As String = Item21TB.Text
        Dim Item22 As String = Item22TB.Text
        Dim Item23 As String = Item23TB.Text
        Dim Item24 As String = Item24TB.Text
        Dim Item25 As String = Item25TB.Text
        Dim Item26 As String = Item26TB.Text
        Dim Item27 As String = Item27TB.Text
        Dim Item28 As String = Item28TB.Text
        Dim Item29 As String = Item29TB.Text
        Dim Item30 As String = Item30TB.Text
        Dim Item31 As String = Item31TB.Text
        Dim Item32 As String = Item32TB.Text
        Dim Item33 As String = Item33TB.Text
        Dim Item34 As String = Item34TB.Text
        Dim Item35 As String = Item35TB.Text
        Dim Item36 As String = Item36TB.Text
        Dim Item37 As String = Item37TB.Text
        Dim Item38 As String = Item38TB.Text
        Dim Item39 As String = Item39TB.Text
        Dim Item40 As String = Item40TB.Text
        Dim Item41 As String = Item41TB.Text
        Dim Item42 As String = Item42TB.Text
        Dim Item43 As String = Item43TB.Text
        Dim Item44 As String = Item44TB.Text
        Dim Item45 As String = Item45TB.Text
        Dim Item46 As String = Item46TB.Text
        Dim Item47 As String = Item47TB.Text
        Dim Item48 As String = Item48TB.Text
        Dim Item49 As String = Item49TB.Text
        Dim Item50 As String = Item50TB.Text
        Dim Item51 As String = Item51TB.Text
        Dim Item52 As String = Item52TB.Text
        Dim Item53 As String = Item53TB.Text
        Dim Item54 As String = Item54TB.Text
        Dim Item55 As String = Item55TB.Text
        Dim Item56 As String = Item56TB.Text
        Dim Item57 As String = Item57TB.Text
        Dim Item58 As String = Item58TB.Text
        Dim Item59 As String = Item59TB.Text
        Dim Item60 As String = Item60TB.Text
        Dim Item61 As String = Item61TB.Text
        Dim Item62 As String = Item62TB.Text
        Dim Item63 As String = Item63TB.Text
        Dim Item64 As String = Item64TB.Text
        Dim Item65 As String = Item65TB.Text
        Dim Item66 As String = Item66TB.Text
        Dim Item67 As String = Item67TB.Text
        Dim Item68 As String = Item68TB.Text
        Dim Item69 As String = Item69TB.Text
        Dim Item70 As String = Item70TB.Text
        Dim Item71 As String = Item71TB.Text
        Dim Item72 As String = Item72TB.Text
        Dim Item73 As String = Item73TB.Text
        Dim Item74 As String = Item74TB.Text
        Dim Item75 As String = Item75TB.Text
        Dim Item76 As String = Item76TB.Text
        Dim Item77 As String = Item77TB.Text
        Dim Item78 As String = Item78TB.Text
        Dim Item79 As String = Item79TB.Text
        Dim Item80 As String = Item80TB.Text
        Dim Item81 As String = Item81TB.Text
        Dim Item82 As String = Item82TB.Text
        Dim Item83 As String = Item83TB.Text
        Dim Item84 As String = Item84TB.Text
        Dim Item85 As String = Item85TB.Text
        Dim Item86 As String = Item86TB.Text
        Dim Item87 As String = Item87TB.Text
        Dim Item88 As String = Item88TB.Text
        Dim Item89 As String = Item89TB.Text
        Dim Item90 As String = Item90TB.Text
        Dim Qty1 As String = Qty1TB.Text
        Dim Qty2 As String = Qty2TB.Text
        Dim Qty3 As String = Qty3TB.Text
        Dim Qty4 As String = Qty4TB.Text
        Dim Qty5 As String = Qty5TB.Text
        Dim Qty6 As String = Qty6TB.Text
        Dim Qty7 As String = Qty7TB.Text
        Dim Qty8 As String = Qty8TB.Text
        Dim Qty9 As String = Qty9TB.Text
        Dim Qty10 As String = Qty10TB.Text
        Dim Qty11 As String = Qty11TB.Text
        Dim Qty12 As String = Qty12TB.Text
        Dim Qty13 As String = Qty13TB.Text
        Dim Qty14 As String = Qty14TB.Text
        Dim Qty15 As String = Qty15TB.Text
        Dim Qty16 As String = Qty16TB.Text
        Dim Qty17 As String = Qty17TB.Text
        Dim Qty18 As String = Qty18TB.Text
        Dim Qty19 As String = Qty19TB.Text
        Dim Qty20 As String = Qty20TB.Text
        Dim Qty21 As String = Qty21TB.Text
        Dim Qty22 As String = Qty22TB.Text
        Dim Qty23 As String = Qty23TB.Text
        Dim Qty24 As String = Qty24TB.Text
        Dim Qty25 As String = Qty25TB.Text
        Dim Qty26 As String = Qty26TB.Text
        Dim Qty27 As String = Qty27TB.Text
        Dim Qty28 As String = Qty28TB.Text
        Dim Qty29 As String = Qty29TB.Text
        Dim Qty30 As String = Qty30TB.Text
        Dim Qty31 As String = Qty31TB.Text
        Dim Qty32 As String = Qty32TB.Text
        Dim Qty33 As String = Qty33TB.Text
        Dim Qty34 As String = Qty34TB.Text
        Dim Qty35 As String = Qty35TB.Text
        Dim Qty36 As String = Qty36TB.Text
        Dim Qty37 As String = Qty37TB.Text
        Dim Qty38 As String = Qty38TB.Text
        Dim Qty39 As String = Qty39TB.Text
        Dim Qty40 As String = Qty40TB.Text
        Dim Qty41 As String = Qty41TB.Text
        Dim Qty42 As String = Qty42TB.Text
        Dim Qty43 As String = Qty43TB.Text
        Dim Qty44 As String = Qty44TB.Text
        Dim Qty45 As String = Qty45TB.Text
        Dim Qty46 As String = Qty46TB.Text
        Dim Qty47 As String = Qty47TB.Text
        Dim Qty48 As String = Qty48TB.Text
        Dim Qty49 As String = Qty49TB.Text
        Dim Qty50 As String = Qty50TB.Text
        Dim Qty51 As String = Qty51TB.Text
        Dim Qty52 As String = Qty52TB.Text
        Dim Qty53 As String = Qty53TB.Text
        Dim Qty54 As String = Qty54TB.Text
        Dim Qty55 As String = Qty55TB.Text
        Dim Qty56 As String = Qty56TB.Text
        Dim Qty57 As String = Qty57TB.Text
        Dim Qty58 As String = Qty58TB.Text
        Dim Qty59 As String = Qty59TB.Text
        Dim Qty60 As String = Qty60TB.Text
        Dim Qty61 As String = Qty61TB.Text
        Dim Qty62 As String = Qty62TB.Text
        Dim Qty63 As String = Qty63TB.Text
        Dim Qty64 As String = Qty64TB.Text
        Dim Qty65 As String = Qty65TB.Text
        Dim Qty66 As String = Qty66TB.Text
        Dim Qty67 As String = Qty67TB.Text
        Dim Qty68 As String = Qty68TB.Text
        Dim Qty69 As String = Qty69TB.Text
        Dim Qty70 As String = Qty70TB.Text
        Dim Qty71 As String = Qty71TB.Text
        Dim Qty72 As String = Qty72TB.Text
        Dim Qty73 As String = Qty73TB.Text
        Dim Qty74 As String = Qty74TB.Text
        Dim Qty75 As String = Qty75TB.Text
        Dim Qty76 As String = Qty76TB.Text
        Dim Qty77 As String = Qty77TB.Text
        Dim Qty78 As String = Qty78TB.Text
        Dim Qty79 As String = Qty79TB.Text
        Dim Qty80 As String = Qty80TB.Text
        Dim Qty81 As String = Qty81TB.Text
        Dim Qty82 As String = Qty82TB.Text
        Dim Qty83 As String = Qty83TB.Text
        Dim Qty84 As String = Qty84TB.Text
        Dim Qty85 As String = Qty85TB.Text
        Dim Qty86 As String = Qty86TB.Text
        Dim Qty87 As String = Qty87TB.Text
        Dim Qty88 As String = Qty88TB.Text
        Dim Qty89 As String = Qty89TB.Text
        Dim Qty90 As String = Qty90TB.Text



        Dim con2 As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("Site_ConnectionString").ConnectionString)
        Dim cmd1 As New SqlCommand
        Dim cmd2 As New SqlCommand
        Dim cmd3 As New SqlCommand
        Dim cmd4 As New SqlCommand
        Dim cmd5 As New SqlCommand
        Dim cmd6 As New SqlCommand
        Dim cmd7 As New SqlCommand
        Dim cmd8 As New SqlCommand
        Dim cmd9 As New SqlCommand
        Dim cmd10 As New SqlCommand
        Dim cmd11 As New SqlCommand
        Dim cmd12 As New SqlCommand
        Dim cmd13 As New SqlCommand
        Dim cmd14 As New SqlCommand
        Dim cmd15 As New SqlCommand
        Dim cmd16 As New SqlCommand
        Dim cmd17 As New SqlCommand
        Dim cmd18 As New SqlCommand
        Dim cmd19 As New SqlCommand
        Dim cmd20 As New SqlCommand
        Dim cmd21 As New SqlCommand
        Dim cmd22 As New SqlCommand
        Dim cmd23 As New SqlCommand
        Dim cmd24 As New SqlCommand
        Dim cmd25 As New SqlCommand
        Dim cmd26 As New SqlCommand
        Dim cmd27 As New SqlCommand
        Dim cmd28 As New SqlCommand
        Dim cmd29 As New SqlCommand
        Dim cmd30 As New SqlCommand
        Dim cmd31 As New SqlCommand
        Dim cmd32 As New SqlCommand
        Dim cmd33 As New SqlCommand
        Dim cmd34 As New SqlCommand
        Dim cmd35 As New SqlCommand
        Dim cmd36 As New SqlCommand
        Dim cmd37 As New SqlCommand
        Dim cmd38 As New SqlCommand
        Dim cmd39 As New SqlCommand
        Dim cmd40 As New SqlCommand
        Dim cmd41 As New SqlCommand
        Dim cmd42 As New SqlCommand
        Dim cmd43 As New SqlCommand
        Dim cmd44 As New SqlCommand
        Dim cmd45 As New SqlCommand
        Dim cmd46 As New SqlCommand
        Dim cmd47 As New SqlCommand
        Dim cmd48 As New SqlCommand
        Dim cmd49 As New SqlCommand
        Dim cmd50 As New SqlCommand
        Dim cmd51 As New SqlCommand
        Dim cmd52 As New SqlCommand
        Dim cmd53 As New SqlCommand
        Dim cmd54 As New SqlCommand
        Dim cmd55 As New SqlCommand
        Dim cmd56 As New SqlCommand
        Dim cmd57 As New SqlCommand
        Dim cmd58 As New SqlCommand
        Dim cmd59 As New SqlCommand
        Dim cmd60 As New SqlCommand
        Dim cmd61 As New SqlCommand
        Dim cmd62 As New SqlCommand
        Dim cmd63 As New SqlCommand
        Dim cmd64 As New SqlCommand
        Dim cmd65 As New SqlCommand
        Dim cmd66 As New SqlCommand
        Dim cmd67 As New SqlCommand
        Dim cmd68 As New SqlCommand
        Dim cmd69 As New SqlCommand
        Dim cmd70 As New SqlCommand
        Dim cmd71 As New SqlCommand
        Dim cmd72 As New SqlCommand
        Dim cmd73 As New SqlCommand
        Dim cmd74 As New SqlCommand
        Dim cmd75 As New SqlCommand
        Dim cmd76 As New SqlCommand
        Dim cmd77 As New SqlCommand
        Dim cmd78 As New SqlCommand
        Dim cmd79 As New SqlCommand
        Dim cmd80 As New SqlCommand
        Dim cmd81 As New SqlCommand
        Dim cmd82 As New SqlCommand
        Dim cmd83 As New SqlCommand
        Dim cmd84 As New SqlCommand
        Dim cmd85 As New SqlCommand
        Dim cmd86 As New SqlCommand
        Dim cmd87 As New SqlCommand
        Dim cmd88 As New SqlCommand
        Dim cmd89 As New SqlCommand
        Dim cmd90 As New SqlCommand


        cmd1.Connection = con2
        cmd2.Connection = con2
        cmd3.Connection = con2
        cmd4.Connection = con2
        cmd5.Connection = con2
        cmd6.Connection = con2
        cmd7.Connection = con2
        cmd8.Connection = con2
        cmd9.Connection = con2
        cmd10.Connection = con2
        cmd11.Connection = con2
        cmd12.Connection = con2
        cmd13.Connection = con2
        cmd14.Connection = con2
        cmd15.Connection = con2
        cmd16.Connection = con2
        cmd17.Connection = con2
        cmd18.Connection = con2
        cmd19.Connection = con2
        cmd20.Connection = con2
        cmd21.Connection = con2
        cmd22.Connection = con2
        cmd23.Connection = con2
        cmd24.Connection = con2
        cmd25.Connection = con2
        cmd26.Connection = con2
        cmd27.Connection = con2
        cmd28.Connection = con2
        cmd29.Connection = con2
        cmd30.Connection = con2
        cmd31.Connection = con2
        cmd32.Connection = con2
        cmd33.Connection = con2
        cmd34.Connection = con2
        cmd35.Connection = con2
        cmd36.Connection = con2
        cmd37.Connection = con2
        cmd38.Connection = con2
        cmd39.Connection = con2
        cmd40.Connection = con2
        cmd41.Connection = con2
        cmd42.Connection = con2
        cmd43.Connection = con2
        cmd44.Connection = con2
        cmd45.Connection = con2
        cmd46.Connection = con2
        cmd47.Connection = con2
        cmd48.Connection = con2
        cmd49.Connection = con2
        cmd50.Connection = con2
        cmd51.Connection = con2
        cmd52.Connection = con2
        cmd53.Connection = con2
        cmd54.Connection = con2
        cmd55.Connection = con2
        cmd56.Connection = con2
        cmd57.Connection = con2
        cmd58.Connection = con2
        cmd59.Connection = con2
        cmd60.Connection = con2
        cmd61.Connection = con2
        cmd62.Connection = con2
        cmd63.Connection = con2
        cmd64.Connection = con2
        cmd65.Connection = con2
        cmd66.Connection = con2
        cmd67.Connection = con2
        cmd68.Connection = con2
        cmd69.Connection = con2
        cmd70.Connection = con2
        cmd71.Connection = con2
        cmd72.Connection = con2
        cmd73.Connection = con2
        cmd74.Connection = con2
        cmd75.Connection = con2
        cmd76.Connection = con2
        cmd77.Connection = con2
        cmd78.Connection = con2
        cmd79.Connection = con2
        cmd80.Connection = con2
        cmd81.Connection = con2
        cmd82.Connection = con2
        cmd83.Connection = con2
        cmd84.Connection = con2
        cmd85.Connection = con2
        cmd86.Connection = con2
        cmd87.Connection = con2
        cmd88.Connection = con2
        cmd89.Connection = con2
        cmd90.Connection = con2

        con2.Open()

        Dim Error1 As Integer

        If Len(Item1) > 0 Then
            cmd1.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item1 & "','" & Qty1 & "','1'"
            'cmd1.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd1.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item1TB.BackColor = Color.Red
                    Item1TB.Text = "ItemID is Not valid!"
                    Qty1TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If
        If Len(Item2) > 0 Then
            cmd2.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item2 & "','" & Qty2 & "','2'"
            'cmd2.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd2.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item2TB.BackColor = Color.Red
                    Item2TB.Text = "ItemID is Not valid!"
                    Qty2TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If
        If Len(Item3) > 0 Then
            cmd3.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item3 & "','" & Qty3 & "','3'"
            'cmd3.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd3.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item3TB.BackColor = Color.Red
                    Item3TB.Text = "ItemID is Not valid!"
                    Qty3TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If
        If Len(Item4) > 0 Then
            cmd4.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item4 & "','" & Qty4 & "','4'"
            'cmd4.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd4.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item4TB.BackColor = Color.Red
                    Item4TB.Text = "ItemID is Not valid!"
                    Qty4TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If
        If Len(Item5) > 0 Then
            cmd5.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item5 & "','" & Qty5 & "','5'"
            'cmd5.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd5.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item5TB.BackColor = Color.Red
                    Item5TB.Text = "ItemID is Not valid!"
                    Qty5TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If
        If Len(Item6) > 0 Then
            cmd6.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item6 & "','" & Qty6 & "','6'"
            'cmd6.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd6.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item6TB.BackColor = Color.Red
                    Item6TB.Text = "ItemID is Not valid!"
                    Qty6TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If
        If Len(Item7) > 0 Then
            cmd7.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item7 & "','" & Qty7 & "','7'"
            'cmd7.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd7.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item7TB.BackColor = Color.Red
                    Item7TB.Text = "ItemID is Not valid!"
                    Qty7TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If
        If Len(Item8) > 0 Then
            cmd8.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item8 & "','" & Qty8 & "','8'"
            'cmd8.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd8.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item8TB.BackColor = Color.Red
                    Item8TB.Text = "ItemID is Not valid!"
                    Qty8TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If
        If Len(Item9) > 0 Then
            cmd9.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item9 & "','" & Qty9 & "','9'"
            'cmd9.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd9.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item9TB.BackColor = Color.Red
                    Item9TB.Text = "ItemID is Not valid!"
                    Qty9TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If
        If Len(Item10) > 0 Then
            cmd10.CommandText = "exec sp_InsertScanLine '" & NewScanBatchID & "','" & Item10 & "','" & Qty10 & "','10'"
            'cmd10.ExecuteNonQuery()
            Error1 = Convert.ToInt32(cmd10.ExecuteScalar())
            Select Case Error1
                Case -1
                    Item10TB.BackColor = Color.Red
                    Item10TB.Text = "ItemID is Not valid!"
                    Qty10TB.Text = ""
                    GoTo LastLine
                    Exit Select
            End Select
        End If

        'MsgBox("New Gemba Saved For With score = " & TotalScore & "")
        Response.Redirect("~/Scans")

LastLine:
        con2.Close()

    End Sub


    Protected Sub ScanningCancel_Click(sender As Object, e As EventArgs) Handles ScanningCancel.Click
        Response.Redirect("~/Scans")
    End Sub



End Class