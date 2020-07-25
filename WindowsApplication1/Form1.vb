Public Class Form1

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim c As New controlador(GetType(visao2))
        c.chama()
    End Sub

End Class


Public Class controlador

    Private visao As ivisao

    Sub New(ClasseVisao As Type)
        Me.visao = Activator.CreateInstance(ClasseVisao, Me)
    End Sub

    Sub chama()
        visao.v1()
    End Sub

    Sub c1()
        MsgBox("c1")
    End Sub

End Class

Interface ivisao
    Sub v1()
End Interface

Public Class visao1
    Implements ivisao

    Private controlador As controlador

    Sub New(controlador As controlador)
        Me.controlador = controlador
    End Sub

    Sub v1() Implements ivisao.v1
        MsgBox("v1")
        controlador.c1()
    End Sub

End Class



Public Class visao2
    Implements ivisao

    Private controlador As controlador

    Sub New(controlador As controlador)
        Me.controlador = controlador
    End Sub

    Sub v1() Implements ivisao.v1
        MsgBox("v2")
        controlador.c1()
    End Sub

End Class