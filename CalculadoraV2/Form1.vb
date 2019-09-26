﻿Public Class Form1
    'Calculadora hecha por Frank A. Piñin Ato.
    'Variables creadas:
    Private memoriaA1 As Double = 0.0
    Private memoriaA2 As Double = 0.0
    Private signo As String


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        EvaluaRestriccionesParaConcatenar()
        txtPantalla.Text = txtPantalla.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        EvaluaRestriccionesParaConcatenar()
        txtPantalla.Text = txtPantalla.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        EvaluaRestriccionesParaConcatenar()
        txtPantalla.Text = txtPantalla.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        EvaluaRestriccionesParaConcatenar()
        txtPantalla.Text = txtPantalla.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        EvaluaRestriccionesParaConcatenar()
        txtPantalla.Text = txtPantalla.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        EvaluaRestriccionesParaConcatenar()
        txtPantalla.Text = txtPantalla.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        EvaluaRestriccionesParaConcatenar()
        txtPantalla.Text = txtPantalla.Text & "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        EvaluaRestriccionesParaConcatenar()
        txtPantalla.Text = txtPantalla.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        EvaluaRestriccionesParaConcatenar()
        txtPantalla.Text = txtPantalla.Text & "9"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtPantalla.Text = txtPantalla.Text & "0"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        If txtPantalla.Text = "" Then
            txtPantalla.Text = "0."
        ElseIf existePunto(txtPantalla.Text) = False Then
            txtPantalla.Text = txtPantalla.Text & "."
        End If
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Try
            If txtPantalla.Text <> "" Then
                memoriaA1 = Val(txtPantalla.Text)
                signo = "+"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            MsgBox("Paso un error lo siento :( ")
        End Try
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Try
            If txtPantalla.Text <> "" Then
                memoriaA1 = Val(txtPantalla.Text)
                signo = "-"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            MsgBox("Paso un error lo siento :( ")
        End Try
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Try
            If txtPantalla.Text <> "" Then
                memoriaA1 = Val(txtPantalla.Text)
                signo = "*"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            MsgBox("Paso un error lo siento :( ")
        End Try
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Try
            If txtPantalla.Text <> "" Then
                memoriaA1 = Val(txtPantalla.Text)
                signo = "/"
                txtPantalla.Clear()
            End If
        Catch ex As Exception
            MsgBox("Paso un error lo siento :( ", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarTodo.Click
        txtPantalla.Clear()
        memoriaA1 = 0.0
        memoriaA2 = 0.0
        signo = String.Empty
    End Sub

    Private Sub btnBorrarDerecha_Click(sender As Object, e As EventArgs) Handles btnBorrarDerecha.Click
        Try
            Dim largo As Integer
            If txtPantalla.Text <> "" Then
                largo = txtPantalla.Text.Length
                txtPantalla.Text = Mid(txtPantalla.Text, 1, largo - 1)
            End If
        Catch ex As Exception
            MsgBox("Paso un error lo siento :(", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnMasMenos_Click(sender As Object, e As EventArgs) Handles btnMasMenos.Click
        Try
            If txtPantalla.Text <> "" Then
                txtPantalla.Text = txtPantalla.Text * (-1)
            End If
        Catch ex As Exception
            MsgBox("Paso un error lo siento :(", MsgBoxStyle.Critical)
        End Try
    End Sub



    Private Function existePunto(ByVal cadena As String) As Boolean
        Dim largo As Integer
        Dim respuesta As Boolean = False
        largo = cadena.Length
        For i As Integer = 1 To largo Step 1
            If Mid(cadena, i, 1) = "." Then
                respuesta = True
            End If
        Next
        Return respuesta
    End Function


    Private Sub calculadora()
        Select Case signo
            Case "+"
                txtPantalla.Text = memoriaA1 + memoriaA2
            Case "-"
                txtPantalla.Text = memoriaA1 - memoriaA2
            Case "*"
                txtPantalla.Text = memoriaA1 * memoriaA2
            Case "/"
                If memoriaA2 = 0 Then
                    MsgBox("Lo siento no se puede dividir entre cero.", MsgBoxStyle.Critical)
                    txtPantalla.Clear()
                    txtPantalla.Text = "0"
                    memoriaA1 = Nothing
                    memoriaA2 = Nothing
                Else
                    txtPantalla.Text = memoriaA1 / memoriaA2
                End If

            Case Else
                MsgBox("Error", MsgBoxStyle.Critical)

        End Select
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Try
            If txtPantalla.Text <> "" Then
                memoriaA2 = txtPantalla.Text
                calculadora()
            End If
        Catch ex As Exception
            MsgBox("Error", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtPantalla.Text = "0"
        memoriaA1 = Nothing
        memoriaA2 = Nothing
    End Sub

    Public Sub EvaluaRestriccionesParaConcatenar()
        If txtPantalla.Text = "0" Then
            txtPantalla.Text = ""
        End If
    End Sub
End Class
