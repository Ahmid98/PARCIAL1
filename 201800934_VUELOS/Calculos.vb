Module Calculos

    Const avioneta_costa = 150
    Const avioneta_izabal = 175.99
    Const avioneta_peten = 250.99

    Const jet_costa = 250.99
    Const jet_izabal = 325.99
    Const jet_peten = 450.99

    Const helicop_costa = 125.99
    Const helicop_izabal = 175.99
    Const helicop_peten = 275.99

    Dim total1 As Double

    Function CalculoSubtotal(c_costa As Double, c_izabal As Double, c_peten As Double)
        Dim sub_costa As Double = 0
        Dim sub_izabal As Double = 0
        Dim sub_peten As Double = 0
        Dim total As Double

        If Form1.rb_avioneta.Checked = True Then
            If Form1.cb_costasur.Checked = True Then
                sub_costa = c_costa * avioneta_costa
            End If
            If Form1.cb_izabal.Checked = True Then
                sub_izabal = c_izabal * avioneta_izabal
            End If
            If Form1.cb_peten.Checked = True Then
                sub_peten = c_peten * avioneta_peten
            End If

            total = sub_costa + sub_izabal + sub_peten

        ElseIf Form1.rb_jet.Checked = True Then

            If Form1.cb_costasur.Checked = True Then
                sub_costa = c_costa * jet_costa
            End If
            If Form1.cb_izabal.Checked = True Then
                sub_izabal = c_izabal * jet_izabal
            End If
            If Form1.cb_peten.Checked = True Then
                sub_peten = c_peten * jet_peten
            End If
            total = sub_costa + sub_izabal + sub_peten

        ElseIf Form1.rb_helicoptero.Checked = True Then

            If Form1.cb_costasur.Checked = True Then
                sub_costa = c_costa * helicop_costa
            End If
            If Form1.cb_izabal.Checked = True Then
                sub_izabal = c_izabal * helicop_izabal
            End If
            If Form1.cb_peten.Checked = True Then
                sub_peten = c_peten * helicop_peten
            End If

            total = sub_costa + sub_izabal + sub_peten

        End If
        total1 = total
        Return total
    End Function

    Function Descuento()
        Dim desc As Double

        If Form1.rb_jet.Checked = True Then


            If Form1.cb_izabal.Checked = True And Form1.cb_peten.Checked = True Then
                desc = total1 * 0.02
            End If
        ElseIf Form1.rb_avioneta.Checked = True Then
            If Form1.cb_izabal.Checked = True And Form1.cb_peten.Checked = True And Form1.cb_costasur.Checked = True Then
                desc = total1 * 0.1
            End If
        End If

        Return desc
    End Function

    Function Total()
        Dim t_total As Double
        t_total = total1 - Descuento()
        Return t_total
    End Function

    Sub Limpiar()

        Form1.txt_costasur.Text = "0"
        Form1.txt_izabal.Text = "0"
        Form1.txt_peten.Text = "0"

        Form1.cb_costasur.Checked = False
        Form1.cb_izabal.Checked = False
        Form1.cb_peten.Checked = False

        Form1.rb_avioneta.Checked = False
        Form1.rb_jet.Checked = False
        Form1.rb_helicoptero.Checked = False


    End Sub

End Module
