Public Class Form1
    Dim sm As MaterialSkin.MaterialSkinManager
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sm = MaterialSkin.MaterialSkinManager.Instance
        sm.AddFormToManage(Me)
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK
        sm.ColorScheme = New MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500,
                                                      MaterialSkin.Primary.Orange900,
                                                      MaterialSkin.Primary.Orange200,
                                                      MaterialSkin.Accent.Blue400,
                                                      MaterialSkin.TextShade.WHITE)
    End Sub

    Private Sub light_butt_Click(sender As Object, e As EventArgs) Handles light_butt.Click
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT
    End Sub

    Private Sub dark_butt_Click(sender As Object, e As EventArgs) Handles dark_butt.Click
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK
    End Sub
End Class
