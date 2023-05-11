Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sm As MaterialSkin.MaterialSkinManager
        sm = MaterialSkin.MaterialSkinManager.Instance
        sm.AddFormToManage(Me)
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK
        sm.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500,
                                                      MaterialSkin.Primary.Orange900,
                                                      MaterialSkin.Primary.Orange200,
                                                      MaterialSkin.Accent.Blue400,
                                                      MaterialSkin.TextShade.WHITE)
    End Sub
End Class
