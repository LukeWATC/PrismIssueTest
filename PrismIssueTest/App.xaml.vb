Imports Prism.Unity.Windows

NotInheritable Class App
    Inherits PrismUnityApplication

    Protected Overrides Function OnLaunchApplicationAsync(args As LaunchActivatedEventArgs) As Task

        NavigationService.Navigate("Main", Nothing)

        Return Task.CompletedTask

    End Function

End Class
