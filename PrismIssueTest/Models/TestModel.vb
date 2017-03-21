Imports System.ComponentModel.DataAnnotations
Imports Prism.Windows.Validation

Namespace Models
    Public Class TestModel
        Inherits ValidatableBindableBase

        Private _testProperty As String
        <Required>
        Public Property TestProperty() As String
            Get
                Return _testProperty
            End Get
            Set(ByVal value As String)
                SetProperty(_testProperty, value)
            End Set
        End Property

    End Class
End Namespace
