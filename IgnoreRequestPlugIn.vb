Public Class IgnoreRequestPlugIn
  Implements JHSoftware.SimpleDNS.Plugin.IIgnoreRequestPlugIn

#Region "events"
  Public Event AsyncError(ByVal ex As System.Exception) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.AsyncError
  Public Event LogLine(ByVal text As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LogLine
  Public Event SaveConfig(ByVal config As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.SaveConfig
#End Region

#Region "not implemented"
  Public Function GetDNSAskAbout() As JHSoftware.SimpleDNS.Plugin.DNSAskAbout Implements JHSoftware.SimpleDNS.Plugin.IIgnoreRequestPlugIn.GetDNSAskAbout
  End Function

  Public Function GetOptionsUI(ByVal instanceID As System.Guid, ByVal dataPath As String) As JHSoftware.SimpleDNS.Plugin.OptionsUI Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetOptionsUI
    Return Nothing
  End Function

  Public Function InstanceConflict(ByVal config1 As String, ByVal config2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.InstanceConflict
    Return False
  End Function

  Public Function SaveState() As String Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.SaveState
    Return ""
  End Function

  Public Sub StartService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StartService
  End Sub

  Public Sub StopService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StopService
  End Sub

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As System.Guid, ByVal dataPath As String, ByRef maxThreads As Integer) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
  End Sub

  Public Sub LoadState(ByVal state As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadState
  End Sub

#End Region

  Public Function GetPlugInTypeInfo() As JHSoftware.SimpleDNS.Plugin.IPlugInBase.PlugInTypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetPlugInTypeInfo
    With GetPlugInTypeInfo
      .Name = "Ignore DNS Request"
      .Description = "Instructs Simple DNS Plus to ignore (not answer) DNS requests"
      .InfoURL = "http://www.simpledns.com/plugin-ignorereq"
      .ConfigFile = False
      .MultiThreaded = False
    End With
  End Function

  Public Function IgnoreRequest(ByVal request As JHSoftware.SimpleDNS.Plugin.IDNSRequest) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IIgnoreRequestPlugIn.IgnoreRequest
    Return True
  End Function

End Class
