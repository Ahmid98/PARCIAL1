Public Class Form1



    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("¿Desea salir del sistema?", vbQuestion + vbYesNo, "") = vbYes Then
            End
        End If
    End Sub

    Private Sub btn_calcular_Click(sender As Object, e As EventArgs) Handles btn_calcular.Click
        If rb_avioneta.Checked = True Or rb_jet.Checked = True Or rb_helicoptero.Checked = True Then

            If cb_izabal.Checked = True Then
                If txt_izabal.Text = "0" Then
                    MsgBox("Debes ingresar cantida de pasajero a Izabal..")
                Else
                    If cb_peten.Checked = True Then
                        If txt_peten.Text = "0" Then
                            MsgBox("Debes ingresar cantida de pasajero a Peten..")
                        Else
                            If cb_costasur.Checked = True Then
                                If txt_costasur.Text = "0" Then
                                    MsgBox("Debes ingresar cantida de pasajeros a Costa Sur..")
                                Else
                                    Form2.lb_subtotal.Text = System.Math.Round(Calculos.CalculoSubtotal(txt_costasur.Text, txt_izabal.Text, txt_peten.Text), 2)
                                    Form2.lb_descuento.Text = System.Math.Round(Calculos.Descuento, 2)
                                    Form2.lb_total.Text = System.Math.Round(Calculos.Total, 2)
                                    Form2.Show()
                                    Me.Hide()
                                End If
                            End If
                        End If
                    Else
                        If cb_costasur.Checked = True Then
                            If txt_costasur.Text = "0" Then
                                MsgBox("Debes ingresar cantida de pasajeros a Costa Sur..")
                            Else
                                Form2.lb_subtotal.Text = System.Math.Round(Calculos.CalculoSubtotal(txt_costasur.Text, txt_izabal.Text, txt_peten.Text), 2)
                                Form2.lb_descuento.Text = System.Math.Round(Calculos.Descuento, 2)
                                Form2.lb_total.Text = System.Math.Round(Calculos.Total, 2)
                                Form2.Show()
                                Me.Hide()
                            End If
                        End If
                    End If
                End If
            Else
                If cb_peten.Checked = True Then
                    If txt_peten.Text = "0" Then
                        MsgBox("Debes ingresar cantida de pasajero a Peten..")
                    Else
                        If cb_costasur.Checked = True Then
                            If txt_costasur.Text = "0" Then
                                MsgBox("Debes ingresar cantida de pasajeros a Costa Sur..")
                            Else
                                Form2.lb_subtotal.Text = System.Math.Round(Calculos.CalculoSubtotal(txt_costasur.Text, txt_izabal.Text, txt_peten.Text), 2)
                                Form2.lb_descuento.Text = System.Math.Round(Calculos.Descuento, 2)
                                Form2.lb_total.Text = System.Math.Round(Calculos.Total, 2)
                                Form2.Show()
                                Me.Hide()
                            End If
                        End If
                    End If
                Else
                    If cb_costasur.Checked = True Then
                        If txt_costasur.Text = "0" Then
                            MsgBox("Debes ingresar cantida de pasajeros a Costa Sur..")
                        Else
                            Form2.lb_subtotal.Text = System.Math.Round(Calculos.CalculoSubtotal(txt_costasur.Text, txt_izabal.Text, txt_peten.Text), 2)
                            Form2.lb_descuento.Text = System.Math.Round(Calculos.Descuento, 2)
                            Form2.lb_total.Text = System.Math.Round(Calculos.Total, 2)
                            Form2.Show()
                            Me.Hide()
                        End If
                    Else
                        Form2.lb_subtotal.Text = System.Math.Round(Calculos.CalculoSubtotal(txt_costasur.Text, txt_izabal.Text, txt_peten.Text), 2)
                        Form2.lb_descuento.Text = System.Math.Round(Calculos.Descuento, 2)
                        Form2.lb_total.Text = System.Math.Round(Calculos.Total, 2)
                        Form2.Show()
                        Me.Hide()
                    End If
                End If
            End If


        Else
            MsgBox("Debe seleccionar un tranporte..")

        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Calculos.Limpiar()
    End Sub

    Private Sub txt_costasur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_costasur.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_izabal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_izabal.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txt_peten_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_peten.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class
