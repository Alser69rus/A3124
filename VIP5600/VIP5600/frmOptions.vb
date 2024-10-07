Public Class frmOptions

    Dim rw As clRWini
    Public Sub New(ByVal _rw As clRWini)

        ' Этот вызов необходим конструктору форм Windows.
        InitializeComponent()

        ' Добавьте все инициализирующие действия после вызова InitializeComponent().

        rw = _rw


        With rw
            com_shd.Value = CDec(.PORT2)
            com_485.Value = CDec(.PORT)
            per_red_angle.Value = CDec(.PER_RED_ANGLE)
            base_angle_u.Value = CDec(.BASE_ANGLE)
            num_R_angle.Value = CDec(.NUM_R_ENCODER)
            per_red_ampl.Value = CDec(.PER_RED_AMPL)
            base_ampl.Value = CDec(.BASE_AMPL)
            num_step_sh_motor.Value = CDec(.NUM_STEP_STEP_MOTOR)
            len_distance.Value = CDec(.LEN_DATCHIK_DISTANCE)
            R_distance.Value = CDec(.R_DATCHIK_DISTANCE)
            power_lim.Value = CDec(.LIM_POWER)
            tenzo_norma_out.Value = CDec(.U_POWER)
            t_okr_min.Value = CDec(.T_MIN_OKR_SREDY)
            t_okr_max.Value = CDec(.T_MAX_OKR_SREDY)
            U_temp_okr.Value = CDec(.U_T_OKR_SREDY)
            t_gidro_min.Value = CDec(.T_MIN_GIDRO)
            t_gidro_max.Value = CDec(.T_MAX_GIDRO)
            U_temp_gidro.Value = CDec(.U_T_GIDRO)
            per_shtok.Value = CDec(.PER_SHTOK)
            n_nom.Value = CDec(.N_NOM)
            num_tenzo.Value = CDec(.NUM_CHANEL_TENZO)
            num_distance.Value = CDec(.NUM_CHANEL_DISTANCE)
            num_t_okr.Value = CDec(.NUM_CHANEL_T_OKR_SRREDY)
            num_t_gidr.Value = CDec(.NUM_CHANEL_T_GIDRO)
            tenzo_datchik_out.Value = CDec(.U_OUT_TENZO)

        End With


    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        With rw

            .PORT2 = com_shd.Value.ToString
            .PORT = com_485.Value.ToString
            .PER_RED_ANGLE = per_red_angle.Value.ToString
            .BASE_ANGLE = base_angle_u.Value.ToString
            .NUM_R_ENCODER = num_R_angle.Value.ToString
            .PER_RED_AMPL = per_red_ampl.Value.ToString
            .BASE_AMPL = base_ampl.Value.ToString
            .NUM_STEP_STEP_MOTOR = num_step_sh_motor.Value.ToString
            .LEN_DATCHIK_DISTANCE = len_distance.Value.ToString
            .R_DATCHIK_DISTANCE = R_distance.Value.ToString
            .LIM_POWER = power_lim.Value.ToString
            .U_POWER = tenzo_norma_out.Value.ToString
            .T_MIN_OKR_SREDY = t_okr_min.Value.ToString
            .T_MAX_OKR_SREDY = t_okr_max.Value.ToString
            .U_T_OKR_SREDY = U_temp_okr.Value.ToString
            .T_MIN_GIDRO = t_gidro_min.Value.ToString
            .T_MAX_GIDRO = t_gidro_max.Value.ToString
            .U_T_GIDRO = U_temp_gidro.Value.ToString
            .PER_SHTOK = per_shtok.Value.ToString
            .N_NOM = n_nom.Value.ToString
            .NUM_CHANEL_TENZO = num_tenzo.Value.ToString
            .NUM_CHANEL_DISTANCE = num_distance.Value.ToString
            .NUM_CHANEL_T_OKR_SRREDY = num_t_okr.Value.ToString
            .NUM_CHANEL_T_GIDRO = num_t_gidr.Value.ToString
            .U_OUT_TENZO = tenzo_datchik_out.Value.ToString

        End With
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        btnApply_Click(Nothing, Nothing)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub dtnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtnDefault.Click
        com_shd.Value = 13
        com_485.Value = 7
        per_red_angle.Value = 1
        base_angle_u.Value = 2.0
        num_R_angle.Value = 250
        per_red_ampl.Value = 400
        base_ampl.Value = 30
        num_step_sh_motor.Value = 200
        len_distance.Value = 75
        R_distance.Value = 5
        power_lim.Value = 50000
        tenzo_norma_out.Value = 5
        t_okr_min.Value = -50
        t_okr_max.Value = 250
        U_temp_okr.Value = 10
        t_gidro_min.Value = -50
        t_gidro_max.Value = 250
        U_temp_gidro.Value = 10
        per_shtok.Value = 400
        n_nom.Value = 1480
        num_tenzo.Value = 3
        num_distance.Value = 2
        num_t_okr.Value = 1
        num_t_gidr.Value = 0
        tenzo_datchik_out.Value = 0
    End Sub

End Class