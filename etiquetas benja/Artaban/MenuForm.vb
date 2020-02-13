Imports System.ComponentModel
Imports System.Text
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraEditors


Public Class FrmMain
    Sub New()
        InitSkins()
        InitializeComponent()
        TabModulos.TabPages.Clear()
        'Me.InitGrid()
    End Sub

    Private Sub visiblePanel()
        CalidadProcesosPanel.Visible = False
        ComprasRepPanel.Visible = False
        ConfiguracionPanel.Visible = False
        IngenieriaCatP.Visible = False
        ProduccionProP.Visible = False
        ProduccionRepP.Visible = False
        ContabilidadRepP.Visible = False

        PyFProP.Visible = False
        AlmRepP.Visible = False
        AlmProP.Visible = False
        IngProP.Visible = False
        RHCatP.Visible = False
        RHProP.Visible = False
        PyFRepP.Visible = False
        RHRepP.Visible = False
        TabModulos.TabPages.Clear()
    End Sub

    Sub InitSkins()
        DevExpress.Skins.SkinManager.EnableFormSkins()
        DevExpress.UserSkins.BonusSkins.Register()
        UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
    End Sub

    Private Sub CalidadP_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles CalidadP.LinkClicked
        visiblePanel()
        CalidadProcesosPanel.Dock = DockStyle.Fill
        CalidadProcesosPanel.Visible = True
        TabModulos.TabPages.Add(TabCalidad)
    End Sub

    Private Sub ComprasR_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles ComprasR.LinkClicked
        visiblePanel()
        ComprasRepPanel.Dock = DockStyle.Fill
        ComprasRepPanel.Visible = True
        TabModulos.TabPages.Add(TabCompras)
    End Sub

    Private Sub iExit_ItemClick(sender As System.Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles iExit.ItemClick
        Me.Close()
    End Sub

    Private Sub FrmMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Artaban Internacional v." & Me.ProductVersion.ToString
        DatosConexion()
        ' If Top01 < 0 And Top02 < 0 And Top03 < 0 And Top04 < 0 And Top05 < 0 And Top06 < 0 And Top07 < 0 And Top08 < 0 And Top09 Then Accesos()
        Top01 = -20
        Top02 = -20
        Top03 = -20
        Top04 = -20
        Top05 = -20
        Top06 = -20
        Top07 = -20
        Top08 = -20
        Top09 = -20
        Top10 = -20
        Top11 = -20
        Top12 = -20 'Panel de Reportes de Compras
        Top13 = -20
        Top14 = -20
        Top15 = -20
        Top16 = -20
        Top17 = -20
        Top18 = -20
        Top19 = -20
        Top20 = -20 'Contabilidad Reportes
        Top21 = -20 'RH Procesos
        Top2 = -20

        If UCase(Usuario) = "idiaz" Or UCase(Usuario) = "auditoria" Or UCase(Usuario) = "dguzman" Then
            PrimpresionMp.Visible = True
        Else : PrimpresionMp.Visible = False
        End If



        If UCase(Usuario) = "EMBOLSADO" Or UCase(Usuario) = "EMBOLSADO1" Or UCase(Usuario) = "EMBOLSADO2" Or UCase(Usuario) = "EMBOLSADO3" Or UCase(Usuario) = "EMBOLSADOB" Or UCase(Usuario) = "EMBOLSADOC" Or UCase(Usuario) = "EMBOLSADO4" Then
            Dim ProEtiquetaPT As New ProCargaFundasFrm
            ProEtiquetaPT.TipoRecibo = 1 'pt
            ProEtiquetaPT.Icon = Me.Icon
            ProEtiquetaPT.Show()
            Me.Hide()
            Exit Sub
        End If
        Accesos()
    End Sub

    Private Sub Accesos()
        If dtAcceso.Rows.Count = 0 Then Exit Sub
        For Each row As DataRow In dtAcceso.Rows
            Dim ctrl() As Control
            Select Case row.Item("idModulo")
                Case 1 'Calidad
                    ctrl = CalidadProcesosPanel.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top01 = Top01 + 25
                        CType(ctrl(0), SimpleButton).Top = Top01
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                Case 2 'Configuracion
                    ctrl = ConfiguracionPanel.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top02 = Top02 + 25
                        CType(ctrl(0), SimpleButton).Top = Top02
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                Case 3 'Ingeniería
                    ctrl = IngenieriaCatP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top03 = Top03 + 25
                        CType(ctrl(0), SimpleButton).Top = Top03
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                    ctrl = IngProP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top08 = Top08 + 25
                        CType(ctrl(0), SimpleButton).Top = Top08
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                Case 4 'Produccion
                    ctrl = ProduccionProP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top04 = Top04 + 25
                        CType(ctrl(0), SimpleButton).Top = Top04
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                    ctrl = ProduccionRepP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top09 = Top09 + 25
                        CType(ctrl(0), SimpleButton).Top = Top09
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                Case 5 'Pedidos y Facturacion
                    ctrl = PyFProP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top05 = Top05 + 25
                        CType(ctrl(0), SimpleButton).Top = Top05
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                    ctrl = PyFRepP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top11 = Top11 + 25
                        CType(ctrl(0), SimpleButton).Top = Top11
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                Case 6 'Almacen
                    ctrl = AlmProP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top06 = Top06 + 25
                        CType(ctrl(0), SimpleButton).Top = Top06
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                    ctrl = AlmRepP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top10 = Top10 + 25
                        CType(ctrl(0), SimpleButton).Top = Top10
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                    '7 = Hand Held
                Case 8 'Capital Humano
                    ctrl = RHCatP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top07 = Top07 + 25
                        CType(ctrl(0), SimpleButton).Top = Top07
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                    'Panel de Procesos
                    ctrl = RHProP.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top21 = Top21 + 25
                        CType(ctrl(0), SimpleButton).Top = Top21
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                Case 9 'Compras
                    ctrl = ComprasRepPanel.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top12 = Top12 + 25
                        CType(ctrl(0), SimpleButton).Top = Top12
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
                Case 10 ' Contabilidad
                    ctrl = ComprasRepPanel.Controls.Find("boton" & row.Item("idAcceso").ToString, True)
                    If (ctrl IsNot Nothing AndAlso ctrl.Length > 0) Then ' if there is a control found
                        Top20 = Top20 + 25
                        CType(ctrl(0), SimpleButton).Top = Top20
                        CType(ctrl(0), SimpleButton).Visible = True
                        Exit Select
                    End If
            End Select

            'Dim ctrl() As Control = TabModulos.Controls.Find("boton" & row.Item("idAcceso").ToString, True)   ' Find control in all children controls

        Next
        Top09 = Top09 + 25 'Reportes de Produccion
        bRepProd.Top = Top09
        Top10 = Top10 + 25 'Reportes de Almacen
        bRepAlm.Top = Top10
        Top12 = Top12 + 25 'Reporteador de Compras
        bRepComp.Top = Top12
        Top11 = Top11 + 25 'Reporteador de Pedidos y Facturacion
        bRepPyF.Top = Top11
    End Sub

    Private Sub sbRepCompras01_Click(sender As System.Object, e As System.EventArgs) Handles sbRepCompras01.Click
        Dim RepComp01 As New RepCompras01
        RepComp01.Icon = Me.Icon
        Me.Hide()
        RepComp01.Show()
    End Sub

    Private Sub CalidadR_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles CalidadR.LinkClicked
        GetDatos()
    End Sub

    Private Sub ConfigC_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles ConfigC.LinkClicked
        visiblePanel()
        ConfiguracionPanel.Dock = DockStyle.Fill
        ConfiguracionPanel.Visible = True
        TabModulos.TabPages.Add(TabConfig)
    End Sub

    Private Sub FrmMain_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.ExitThread()
    End Sub

    Private Sub navBarControl_Click(sender As System.Object, e As System.EventArgs) Handles MenuBar.Click
        'visiblePanel()
    End Sub

    Private Sub IngenieriaC_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles IngenieriaC.LinkClicked
        visiblePanel()
        IngenieriaCatP.Dock = DockStyle.Fill
        IngenieriaCatP.Visible = True
        TabModulos.TabPages.Add(TabIng)
    End Sub
    '////// Procesos para clic en botones
    Private Sub boton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles boton11.Click
        Dim EtiquetasCalFrm As New EtiquetasCalForm
        EtiquetasCalFrm.Icon = Me.Icon
        EtiquetasCalFrm.Show()
        Me.Hide()
    End Sub

    Private Sub boton12_Click(sender As System.Object, e As System.EventArgs) Handles boton12.Click
        Dim ConfigFrm As New DatosDBForm
        ConfigFrm.Icon = Me.Icon
        ConfigFrm.Show()
        Me.Hide()
    End Sub

    Private Sub boton13_Click(sender As System.Object, e As System.EventArgs) Handles boton13.Click
        Dim catComp As New CatTiposForm
        catComp.Icon = Me.Icon
        catComp.Show()
        Me.Hide()
    End Sub

    Private Sub boton14_Click(sender As System.Object, e As System.EventArgs) Handles boton14.Click
        Dim CatTipos As New CatTiposForm
        CatTipos.Icon = Me.Icon
        CatTipos.Show()
        Me.Hide()
    End Sub

    Private Sub Boton15_Click(sender As System.Object, e As System.EventArgs) Handles Boton15.Click
        Dim CatMarcas As New CatMarcasForm
        CatMarcas.Icon = Me.Icon
        CatMarcas.Show()
        Me.Hide()
    End Sub

    Private Sub Boton16_Click(sender As System.Object, e As System.EventArgs) Handles Boton16.Click
        Dim CatModelos As New CatModelosForm
        CatModelos.Icon = Me.Icon
        CatModelos.Show()
        Me.Hide()
    End Sub

    Private Sub Boton17_Click(sender As System.Object, e As System.EventArgs) Handles Boton17.Click
        Dim catCategorias As New CatCategoriasForm
        catCategorias.Icon = Me.Icon
        catCategorias.Show()
        Me.Hide()
    End Sub

    Private Sub Boton18_Click(sender As System.Object, e As System.EventArgs) Handles Boton18.Click
        Dim CatLineas As New CatLineasForm
        CatLineas.Icon = Me.Icon
        CatLineas.Show()
        Me.Hide()
    End Sub

    Private Sub Boton19_Click(sender As System.Object, e As System.EventArgs) Handles Boton19.Click
        Dim CatConstrucciones As New CatConstruccionesForm
        CatConstrucciones.Icon = Me.Icon
        CatConstrucciones.Show()
        Me.Hide()
    End Sub

    Private Sub Boton20_Click(sender As System.Object, e As System.EventArgs) Handles Boton20.Click
        Dim CatConfort As New CatConfortForm
        CatConfort.Icon = Me.Icon
        CatConfort.Show()
        Me.Hide()
    End Sub

    Private Sub Boton21_Click(sender As System.Object, e As System.EventArgs) Handles Boton21.Click
        Dim CatMedidas As New CatMedidasForm
        CatMedidas.Icon = Me.Icon
        CatMedidas.Show()
        Me.Hide()
    End Sub

    Private Sub Boton22_Click(sender As System.Object, e As System.EventArgs) Handles Boton22.Click
        Dim CatProcesos As New CatProcesosForm
        CatProcesos.Icon = Me.Icon
        CatProcesos.Show()
        Me.Hide()
    End Sub

    Private Sub Boton24_Click(sender As System.Object, e As System.EventArgs) Handles Boton24.Click
        Dim Articulos As New CatArticulos
        Articulos.Icon = Me.Icon
        Articulos.Show()
        Me.Hide()
    End Sub

    Private Sub Boton25_Click(sender As System.Object, e As System.EventArgs) Handles Boton25.Click
        Dim ProEtiqueta As New EtiquetasMPSForm
        ProEtiqueta.EtiquetaPT = False
        ProEtiqueta.ClaseProd = 1
        ProEtiqueta.Icon = Me.Icon
        ProEtiqueta.Show()
        Me.Hide()
    End Sub

    Private Sub Boton26_Click(sender As System.Object, e As System.EventArgs) Handles Boton26.Click
        Dim ProEtiquetaPT As New ProCargaFundasFrm
        ProEtiquetaPT.TipoRecibo = 1 'Recibo de PT
        ProEtiquetaPT.Icon = Me.Icon
        ProEtiquetaPT.Show()
        Me.Hide()
    End Sub

    Private Sub IngenieriaP_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles IngenieriaP.LinkClicked
        visiblePanel()
        IngProP.Dock = DockStyle.Fill
        IngProP.Visible = True
        TabModulos.TabPages.Add(TabIng)
    End Sub

    Private Sub Boton27_Click(sender As System.Object, e As System.EventArgs) Handles Boton27.Click
        Dim Embarques As New ProEmbarquesFrm
        Embarques.Icon = Me.Icon
        Embarques.Show()
        Me.Hide()
    End Sub

    Private Sub Boton28_Click(sender As System.Object, e As System.EventArgs) Handles Boton28.Click
        Dim Inventarios As New RepExistenciasForm
        Inventarios.Icon = Me.Icon
        Inventarios.Show()
        Me.Hide()
    End Sub

    Private Sub PyFP_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles PyFP.LinkClicked
        visiblePanel()
        PyFProP.Dock = DockStyle.Fill
        PyFProP.Visible = True
        TabModulos.TabPages.Add(TabPyF)
        'Dim Embarques As New ProEmbarquesFrm
        'Embarques.Icon = Me.Icon
        'Embarques.Show()
        'Me.Hide()
    End Sub

    Private Sub PyFR_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles PyFR.LinkClicked
        visiblePanel()
        PyFRepP.Dock = DockStyle.Fill
        PyFRepP.Visible = True
        TabModulos.TabPages.Add(TabPyF)
    End Sub

    Private Sub ProdP_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles ProdP.LinkClicked
        visiblePanel()
        ProduccionProP.Dock = DockStyle.Fill
        ProduccionProP.Visible = True
        TabModulos.TabPages.Add(TabProd)
    End Sub

    Private Sub AlmP_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles AlmP.LinkClicked
        visiblePanel()
        AlmProP.Dock = DockStyle.Fill
        AlmProP.Visible = True
        TabModulos.TabPages.Add(TabAlmacen)
    End Sub

    Private Sub Boton29_Click(sender As System.Object, e As System.EventArgs) Handles Boton29.Click
        'Dim RevInv As New CapturaInv
        Dim RevInv As New ProcesaInv
        RevInv.TipoInv = 1
        RevInv.Text = "Revision de Inventario de Producto Terminado"
        RevInv.Icon = Me.Icon
        RevInv.Show()
        Me.Hide()
    End Sub

    Private Sub boton30_Click(sender As System.Object, e As System.EventArgs) Handles boton30.Click
        Dim bInfo As New BuscaItemFrm
        bInfo.Icon = Me.Icon
        bInfo.Show()
        Me.Hide()
    End Sub

    Private Sub Boton31_Click(sender As System.Object, e As System.EventArgs) Handles Boton31.Click
        Dim Transfer As New TransferFrm
        Transfer.Icon = Me.Icon
        Transfer.Origen = "PT"
        Transfer.Show()
        Me.Hide()
    End Sub

    Private Sub Boton32_Click(sender As System.Object, e As System.EventArgs) Handles Boton32.Click
        Dim PreProd As New PreProdFrm
        PreProd.Icon = Me.Icon
        PreProd.Show()
        Me.Hide()
    End Sub

    Private Sub Boton23_Click(sender As System.Object, e As System.EventArgs) Handles Boton23.Click
        Dim ProRutaPro As New ProRutaProceso
        ProRutaPro.Icon = Me.Icon
        ProRutaPro.Show()
        Me.Hide()
    End Sub

    Private Sub Boton33_Click(sender As System.Object, e As System.EventArgs) Handles Boton33.Click
        Dim EtiquetaPT As New GenEtiquetaInv
        EtiquetaPT.Tipo = "1"
        EtiquetaPT.Dev = 0
        EtiquetaPT.Icon = Me.Icon
        EtiquetaPT.Show()
        Me.Hide()
    End Sub

    Private Sub Boton34_Click(sender As System.Object, e As System.EventArgs) Handles Boton34.Click
        Dim EtiquetaPT As New GenEtiquetaInv
        EtiquetaPT.Tipo = "3"
        EtiquetaPT.Dev = 0
        EtiquetaPT.Icon = Me.Icon
        EtiquetaPT.Show()
        Me.Hide()
    End Sub

    Private Sub Boton35_Click(sender As System.Object, e As System.EventArgs) Handles Boton35.Click
        ImportaCodPT(1) '1 = Producto Terminado
    End Sub

    Private Sub Boton36_Click(sender As System.Object, e As System.EventArgs) Handles Boton36.Click
        ImportaCodPT(2) '2 = Producto de Blancos
    End Sub

    Private Sub Boton37_Click(sender As System.Object, e As System.EventArgs) Handles Boton37.Click
        Dim CSalas As New CatSalas
        CSalas.Icon = Me.Icon
        CSalas.Show()
        Me.Hide()
    End Sub

    Private Sub RHC_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles RHC.LinkClicked
        visiblePanel()
        RHCatP.Dock = DockStyle.Fill
        RHCatP.Visible = True
        TabModulos.TabPages.Add(TabRH)
    End Sub

    Private Sub Boton38_Click(sender As System.Object, e As System.EventArgs) Handles Boton38.Click
        Dim cEmp As New CatEmpleados
        cEmp.Icon = Me.Icon
        cEmp.Show()
        Me.Hide() 
    End Sub

    Private Sub Boton39_Click(sender As System.Object, e As System.EventArgs) Handles Boton39.Click
        Dim cIngresoProd As New ProRecDestajoFormf
        cIngresoProd.Icon = Me.Icon
        cIngresoProd.Show()
        Me.Hide()
    End Sub

    Private Sub Boton40_Click(sender As System.Object, e As System.EventArgs) Handles Boton40.Click
        Dim rDestajo As New RepDestajosForm
        rDestajo.Icon = Me.Icon
        rDestajo.Show()
        Me.Hide()
    End Sub

    Private Sub ProdR_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles ProdR.LinkClicked
        visiblePanel()
        ProduccionRepP.Dock = DockStyle.Fill
        ProduccionRepP.Visible = True
        TabModulos.TabPages.Add(TabProd)
    End Sub
     
    Private Sub NavBarItem3_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles AlmR.LinkClicked
        visiblePanel()
        AlmRepP.Dock = DockStyle.Fill
        AlmRepP.Visible = True
        TabModulos.TabPages.Add(TabAlmacen)
    End Sub

    Private Sub Boton41_Click(sender As System.Object, e As System.EventArgs) Handles Boton41.Click
        Dim RepEmbarques As New RepEmbarquesForm
        RepEmbarques.Icon = Me.Icon
        RepEmbarques.Show()
        Me.Hide()
    End Sub

    Private Sub Boton42_Click(sender As System.Object, e As System.EventArgs) Handles Boton42.Click
        Dim EtiquetaPT As New GenEtiquetaInv
        EtiquetaPT.Tipo = "1"
        EtiquetaPT.Dev = 1
        EtiquetaPT.Icon = Me.Icon
        EtiquetaPT.Show()
        Me.Hide()
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Dim testeo As New TestFormvb
        TestFormvb.Show()
    End Sub

    Private Sub Boton43_Click(sender As System.Object, e As System.EventArgs)
        Dim ProEtiqueta As New EtiquetasMPSForm
        ProEtiqueta.EtiquetaPT = True
        ProEtiqueta.ClaseProd = 1
        ProEtiqueta.Icon = Me.Icon
        ProEtiqueta.Show()
        Me.Hide()
    End Sub

    Private Sub bRepProd_Click(sender As System.Object, e As System.EventArgs) Handles bRepProd.Click
        Dim Reporte As New ReportesForm
        Reporte.Icon = Me.Icon
        Reporte.Modulo = 4
        Reporte.Show()
        Me.Hide()
    End Sub

    Private Sub bRepAlm_Click(sender As System.Object, e As System.EventArgs) Handles bRepAlm.Click
        Dim Reporte As New ReportesForm
        Reporte.Icon = Me.Icon
        Reporte.Modulo = 6
        Reporte.Show()
        Me.Hide()
    End Sub

    Private Sub Boton43_Click_1(sender As System.Object, e As System.EventArgs) Handles Boton43.Click
        Dim ProEtiqueta As New EtiquetasMPSForm
        ProEtiqueta.EtiquetaPT = True
        ProEtiqueta.ClaseProd = 1
        ProEtiqueta.Icon = Me.Icon
        ProEtiqueta.Show()
        Me.Hide()
    End Sub

    Private Sub Boton44_Click(sender As System.Object, e As System.EventArgs) Handles Boton44.Click
        Dim PP As New ProdProcesoFrm
        PP.Icon = Me.Icon
        PP.Show()
        Me.Hide()
    End Sub

    Private Sub bRepComp_Click(sender As System.Object, e As System.EventArgs) Handles bRepComp.Click
        Dim Reporte As New ReportesForm
        Reporte.Icon = Me.Icon
        Reporte.Modulo = 9
        Reporte.Show()
        Me.Hide()
    End Sub

    Private Sub Boton45_Click(sender As System.Object, e As System.EventArgs) Handles Boton45.Click
        Dim ReimpEt As New ReImpETEpicor
        ReimpEt.Icon = Me.Icon
        ReimpEt.Tipo = "5" 'Costuras
        ReimpEt.Show()
        Me.Hide()
    End Sub

    Private Sub Boton46_Click(sender As System.Object, e As System.EventArgs) Handles Boton46.Click
        Dim ReimpEt As New ReImpETEpicor
        ReimpEt.cbPT.Checked = False
        ReimpEt.Icon = Me.Icon
        ReimpEt.Tipo = "8" 'Tapizado
        ReimpEt.Show()
        Me.Hide()
    End Sub

    Private Sub Boton47_Click(sender As System.Object, e As System.EventArgs) Handles Boton47.Click
        Dim ReimpEt As New ReImpETEpicor
        ReimpEt.cbPT.Checked = True
        ReimpEt.Icon = Me.Icon
        ReimpEt.Tipo = "8" 'Tapizado
        ReimpEt.Show()
        Me.Hide()
    End Sub

    Private Sub Boton49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton49.Click
        Dim CatAreas As New CatAreasForm
        CatAreas.Icon = Me.Icon
        CatAreas.Show()
        Me.Hide()
    End Sub

    Private Sub Boton50_Click(sender As System.Object, e As System.EventArgs) Handles Boton50.Click
        Dim CatPlanEmb As New PlanEmbarque
        CatPlanEmb.Icon = Me.Icon
        CatPlanEmb.Show()
        Me.Hide()
    End Sub

    Private Sub Boton48_Click(sender As System.Object, e As System.EventArgs) Handles Boton48.Click
        Dim EtEpicor As New GenEtiquetaEpicor
        EtEpicor.Icon = Me.Icon
        EtEpicor.Show()
        Me.Hide()
    End Sub

    Private Sub bRepPyF_Click(sender As System.Object, e As System.EventArgs) Handles bRepPyF.Click
        Dim Reporte As New ReportesForm
        Reporte.Icon = Me.Icon
        Reporte.Modulo = 5
        Reporte.Show()
        Me.Hide()
    End Sub

    Private Sub bMetricos_Click(sender As System.Object, e As System.EventArgs) Handles Boton51.Click
        Dim metricos As New Metricos01
        metricos.Icon = Me.Icon
        metricos.Show()
        Me.Hide()
    End Sub

    Private Sub bRepCont_Click(sender As System.Object, e As System.EventArgs) Handles bRepCont.Click 
        Dim Reporte As New ReportesForm
        Reporte.Icon = Me.Icon
        Reporte.Modulo = 10
        Reporte.Show()
        Me.Hide()
    End Sub 

    Private Sub RCont_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles RCont.LinkClicked
        visiblePanel()
        ContabilidadRepP.Dock = DockStyle.Fill
        ContabilidadRepP.Visible = True
        TabModulos.TabPages.Add(tabcont)
    End Sub

    Private Sub boton52_Click(sender As System.Object, e As System.EventArgs) Handles boton52.Click
        Dim Etiquetas As New ProImpEtForm
        Etiquetas.Icon = Me.Icon 
        Etiquetas.Show()
        Me.Hide()
    End Sub

    Private Sub Boton53_Click(sender As System.Object, e As System.EventArgs) Handles Boton53.Click
        Dim metricos As New MetricosTH01
        metricos.Icon = Me.Icon
        metricos.Show()
        Me.Hide()
    End Sub

    Private Sub RHP_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles RHP.LinkClicked
        visiblePanel()
        TabModulos.TabPages.Add(TabRH)
        RHProP.Dock = DockStyle.Fill
        RHProP.Visible = True
    End Sub

    Private Sub Boton54_Click(sender As System.Object, e As System.EventArgs) Handles Boton60.Click
        Dim PreNom As New PreNomina
        PreNom.Icon = Me.Icon
        PreNom.Show()
        Me.Hide()
    End Sub

    Private Sub RHR_LinkClicked(sender As System.Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles RHR.LinkClicked
        visiblePanel()
        RHRepP.Dock = DockStyle.Fill
        RHRepP.Visible = True
        TabModulos.TabPages.Add(TabRH)
    End Sub

    Private Sub SimpleButton3_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton3.Click
        Dim Reporte As New ReportesForm
        Reporte.Icon = Me.Icon
        Reporte.Modulo = 8
        Reporte.Show()
        Me.Hide()
    End Sub

    Private Sub tPagos_Tick(sender As System.Object, e As System.EventArgs) Handles tPagos.Tick
        tPagos.Enabled = False
        tPagos.Enabled = True
    End Sub

    Private Sub Boton55_Click(sender As System.Object, e As System.EventArgs) Handles Boton55.Click
        Dim EtiquetasAlm As New EtiquetasAlm
        EtiquetasAlm.Tipo = 1
        EtiquetasAlm.Icon = Me.Icon
        EtiquetasAlm.Show()
        Me.Hide()
    End Sub

    Private Sub Boton56_Click(sender As System.Object, e As System.EventArgs) Handles Boton56.Click
        Dim EtiquetasAlm As New EtiquetasAlm
        EtiquetasAlm.Tipo = 2
        EtiquetasAlm.Icon = Me.Icon
        EtiquetasAlm.Show()
        Me.Hide()
    End Sub

    Private Sub Boton57_Click(sender As System.Object, e As System.EventArgs) Handles Boton57.Click
        Dim RevInv As New ProcesaInv
        RevInv.TipoInv = 2
        RevInv.Text = "Revision de Inventario de Materia Prima"
        RevInv.Icon = Me.Icon
        RevInv.Show()
        Me.Hide()
    End Sub

    Private Sub b58_Click(sender As System.Object, e As System.EventArgs) Handles Boton58.Click
        Dim PreNom As New PreNominaElbeck
        PreNom.Icon = Me.Icon
        PreNom.NoEmpresa = 1
        PreNom.Show()
        Me.Hide()
    End Sub

    Private Sub Boton59_Click(sender As System.Object, e As System.EventArgs) Handles Boton59.Click
        Dim PreNom As New PrenomProm
        PreNom.Icon = Me.Icon 
        PreNom.Show()
        Me.Hide()
    End Sub

    Private Sub Boton61_Click(sender As System.Object, e As System.EventArgs) Handles Boton61.Click
        Dim SubyProm As New CatSupyProm
        SubyProm.Icon = Me.Icon
        SubyProm.Show()
        Me.Hide()
    End Sub

    Private Sub SimpleButton2_Click(sender As System.Object, e As System.EventArgs) Handles boton62.Click
        Dim CargaBases As New ProCargaFundasFrm1
        CargaBases.Icon = Me.Icon
        CargaBases.TipoRecibo = 1 '"Salida de Bases a Planta Therapedic"
        CargaBases.Show()
        Me.Hide()
    End Sub

    Private Sub SimpleButton2_Click_1(sender As System.Object, e As System.EventArgs) Handles Boton63.Click
        Dim PreRegistro As New CatPreregPromo
        PreRegistro.Icon = Me.Icon
        PreRegistro.Show()
        Me.Hide()
    End Sub

    Private Sub SimpleButton2_Click_2(sender As System.Object, e As System.EventArgs) Handles Boton64.Click
        Dim Finiquitos As New ProFiniquitos
        Finiquitos.Icon = Me.Icon
        Finiquitos.Show()
        Me.Hide()
    End Sub

    Private Sub PrimpresionMp_Click(sender As System.Object, e As System.EventArgs) Handles PrimpresionMp.Click
        Dim EtiquetasAlm As New EtiquetasAlm
        EtiquetasAlm.Tipo = 3
        EtiquetasAlm.Icon = Me.Icon
        EtiquetasAlm.Show()
        Me.Hide()
    End Sub
End Class