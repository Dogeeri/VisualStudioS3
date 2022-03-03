Public Class Form1

    Private Function Formatear(Campo As String, Valor As String) As String
        Select Case Campo
            Case "ID"
                Formatear = Valor.PadRight(3)
            Case "FECHA"
                Formatear = Valor.PadRight(10)
            Case "VENDEDOR"
                Formatear = Valor.PadRight(30)
            Case "CLIENTE"
                Formatear = Valor.PadRight(30)
            Case "PRODUCTOS"
                Formatear = Valor.PadRight(30)
            Case "FAMILIA"
                Formatear = Valor.PadRight(20)
            Case "PRECIO"
                Formatear = Format(Val(Valor), "##,##0").PadLeft(7)
            Case "CANTIDAD"
                Formatear = Format(Val(Valor), "##,##0").PadLeft(3)
            Case Else
                Formatear = ""
        End Select
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ARCHIVO As New System.IO.StreamReader("EXAMEN - ABARROTES DON PEPE.CSV")
        Dim REGISTRO As String
        Dim ID, FECHA, VENDEDOR, CLIENTE, PRODUCTOS, FAMILIA, PRECIO, CANTIDAD As String
        Dim DATO As Array
        REGISTRO = ARCHIVO.ReadLine()
        CMB_VEND.Items.Add("TODOS")
        CMB_CLI.Items.Add("TODOS")
        While REGISTRO <> ""
            DATO = REGISTRO.Split(";")
            ID = Formatear("ID", DATO(0))
            FECHA = Formatear("FECHA", DATO(1))
            VENDEDOR = Formatear("VENDEDOR", DATO(2))

            Dim COPY, COPY2 As Boolean

            For NUM = 0 To CMB_VEND.Items.Count - 1
                If CMB_VEND.Items(NUM).ToString = VENDEDOR.ToString Then
                    COPY2 = True
                End If
            Next
            If COPY2 = True Then
                COPY2 = False
            Else
                CMB_VEND.Items.Add(VENDEDOR)
            End If

            CLIENTE = Formatear("CLIENTE", DATO(3))

            For NUM = 0 To CMB_CLI.Items.Count - 1
                If CMB_CLI.Items(NUM).ToString = CLIENTE.ToString Then
                    COPY = True
                End If
            Next
            If COPY = True Then
                COPY = False
            Else
                CMB_CLI.Items.Add(CLIENTE)
            End If

            PRODUCTOS = Formatear("PRODUCTOS", DATO(4))
            FAMILIA = Formatear("FAMILIA", DATO(5))
            PRECIO = Formatear("PRECIO", DATO(6))
            CANTIDAD = Formatear("CANTIDAD", DATO(7))
            LST_LISTA.Items.Add(ID & " " & FECHA & " " & VENDEDOR & " " & CLIENTE & " " & PRODUCTOS & " " & FAMILIA & " " & PRECIO & " " & CANTIDAD)
            REGISTRO = ARCHIVO.ReadLine()

        End While
        ARCHIVO.Close()
    End Sub

    Private Sub TXT_FIND_VEND_TextChanged(sender As Object, e As EventArgs) Handles TXT_FIND_VEND.TextChanged
        Dim Indice As Integer
        Dim Real As String

        TXT_FIND_VEND.BackColor = Color.White
        For Indice = 0 To LST_LISTA.Items.Count - 1
            LST_BUSCAR.Items.Add(LST_LISTA.Items.Item(Indice))
        Next
        Indice = LST_LISTA.Items.Count - 1
        While Indice >= 0
            LST_LISTA.Items.RemoveAt(Indice)
            Indice = Indice - 1
        End While
        Indice = LST_BUSCAR.Items.Count - 1
        While Indice >= 0
            Real = LST_BUSCAR.Items.Item(Indice).ToString.Substring(15, 30).Trim
            If Len(TXT_FIND_VEND.Text) <= Len(Real) Then
                If TXT_FIND_VEND.Text = Real.Substring(0, Len(TXT_FIND_VEND.Text)) Then
                    LST_LISTA.Items.Add(LST_BUSCAR.Items.Item(Indice))
                    LST_BUSCAR.Items.RemoveAt(Indice)
                End If
            End If
            Indice = Indice - 1
        End While
        If LST_LISTA.Items.Count = 0 Then
            TXT_FIND_VEND.BackColor = Color.Red
        End If
    End Sub

    Private Sub CMB_VEND_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_VEND.SelectedIndexChanged
        If CMB_VEND.SelectedItem = "TODOS" Then
            TXT_FAKEVEND.Clear()
            Exit Sub
        Else
            TXT_FAKEVEND.Text = CMB_VEND.SelectedItem.Trim
            CMB_CLI.SelectedItem = "TODOS"
        End If

    End Sub

    Private Sub TXT_FIND_CLI_TextChanged(sender As Object, e As EventArgs) Handles TXT_FIND_CLI.TextChanged
        Dim Real As String

        LST_LISTA.SelectedItems.Clear()

        If Len(TXT_FIND_CLI.Text) <= 25 Then
            For Indice = 0 To LST_LISTA.Items.Count - 1
                Real = LST_LISTA.Items.Item(Indice).ToString.Substring(30, 30).Trim
                If Real.Contains(TXT_FIND_CLI.Text.Substring(0, Len(TXT_FIND_CLI.Text))) And Len(TXT_FIND_CLI.Text) > 0 Then
                    'LST_LISTA.SetSelected(Indice, True)
                    Exit Sub
                End If
            Next
        End If
    End Sub

    Private Sub CMB_CLI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_CLI.SelectedIndexChanged
        If CMB_CLI.SelectedItem = "TODOS" Then
            TXT_FAKECLI.Clear()
            Exit Sub
        Else
            TXT_FAKECLI.Text = CMB_CLI.SelectedItem.Trim
            CMB_VEND.SelectedItem = "TODOS"
        End If
    End Sub

    Private Sub TXT_FAKEVEND_TextChanged(sender As Object, e As EventArgs) Handles TXT_FAKEVEND.TextChanged
        Dim Indice As Integer
        Dim Real As String

        For Indice = 0 To LST_LISTA.Items.Count - 1
            LST_BUSCAR.Items.Add(LST_LISTA.Items.Item(Indice))
        Next
        Indice = LST_LISTA.Items.Count - 1
        While Indice >= 0
            LST_LISTA.Items.RemoveAt(Indice)
            Indice = Indice - 1
        End While
        Indice = LST_BUSCAR.Items.Count - 1
        While Indice >= 0
            Real = LST_BUSCAR.Items.Item(Indice).ToString.Substring(15, 30).Trim
            If Len(TXT_FAKEVEND.Text) <= Len(Real) Then
                If TXT_FAKEVEND.Text = Real.Substring(0, Len(TXT_FAKEVEND.Text)) Then
                    LST_LISTA.Items.Add(LST_BUSCAR.Items.Item(Indice))
                    LST_BUSCAR.Items.RemoveAt(Indice)
                End If
            End If
            Indice = Indice - 1
        End While
    End Sub

    Private Sub TXT_FAKECLI_TextChanged(sender As Object, e As EventArgs) Handles TXT_FAKECLI.TextChanged
        Dim Indice As Integer
        Dim Real As String

        For Indice = 0 To LST_LISTA.Items.Count - 1
            LST_BUSCAR.Items.Add(LST_LISTA.Items.Item(Indice))
        Next
        Indice = LST_LISTA.Items.Count - 1
        While Indice >= 0
            LST_LISTA.Items.RemoveAt(Indice)
            Indice = Indice - 1
        End While
        Indice = LST_BUSCAR.Items.Count - 1
        While Indice >= 0
            Real = LST_BUSCAR.Items.Item(Indice).ToString.Substring(30, 30).Trim
            If Len(TXT_FAKECLI.Text) <= Len(Real) Then
                If TXT_FAKECLI.Text = Real.Substring(0, Len(TXT_FAKECLI.Text)) Then
                    LST_LISTA.Items.Add(LST_BUSCAR.Items.Item(Indice))
                    LST_BUSCAR.Items.RemoveAt(Indice)
                End If
            End If
            Indice = Indice - 1
        End While
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class