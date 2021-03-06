﻿Imports Prism.Commands
Imports Prism.Windows.Mvvm
Imports PrismIssueTest.Models
Imports Windows.UI.Popups

Namespace ViewModels
    Public Class MainPageViewModel
        Inherits ViewModelBase

        Public ReadOnly Property TestCommand As New DelegateCommand(AddressOf OnTest)

        Private Async Sub OnTest()

            Try

                Dim model As New TestModel()

                model.TestProperty = "Test Value"

                Dim dlg As New MessageDialog("Error didn't occur")
                Await dlg.ShowAsync()

            Catch ex As Exception

                ShowMessage(ex.ToString())

            End Try

        End Sub

        Private Async Sub ShowMessage(ByVal msg As String)

            Dim dlg As New MessageDialog(msg)
            Await dlg.ShowAsync()

        End Sub

    End Class
End Namespace
