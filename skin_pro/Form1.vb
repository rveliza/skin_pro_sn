Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sm As MaterialSkin.MaterialSkinManager
        sm = MaterialSkin.MaterialSkinManager.Instance
        sm.AddFormToManage(Me)
        sm.Theme = MaterialSkin.MaterialSkinManager.Themes.DARK
    End Sub
End Class
