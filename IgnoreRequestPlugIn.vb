﻿Imports JHSoftware.SimpleDNS.Plugin

Public Class IgnoreRequestPlugIn
  Implements Plugin.IIgnoreRequest

  Public Property Host As IHost Implements IPlugInBase.Host

#Region "not implemented"

  Public Function InstanceConflict(ByVal config1 As String, ByVal config2 As String, ByRef errorMsg As String) As Boolean Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.InstanceConflict
    Return False
  End Function

  Public Function SaveState() As String Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.SaveState
    Return ""
  End Function

  Public Function StartService() As Threading.Tasks.Task Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StartService
    Return Threading.Tasks.Task.CompletedTask
  End Function

  Public Sub StopService() Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.StopService
  End Sub

  Public Sub LoadConfig(ByVal config As String, ByVal instanceID As System.Guid, ByVal dataPath As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadConfig
  End Sub

  Public Sub LoadState(ByVal state As String) Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.LoadState
  End Sub

#End Region

  Public Function GetPlugInTypeInfo() As JHSoftware.SimpleDNS.Plugin.IPlugInBase.PlugInTypeInfo Implements JHSoftware.SimpleDNS.Plugin.IPlugInBase.GetPlugInTypeInfo
    With GetPlugInTypeInfo
      .Name = "Ignore DNS Request"
      .Description = "Instructs Simple DNS Plus to ignore (not answer) DNS requests"
      .InfoURL = "https://simpledns.plus/kb/180/ignore-dns-request-plug-in"
    End With
  End Function

  Public Function IgnoreRequest(ByVal request As JHSoftware.SimpleDNS.Plugin.IDNSRequest) As Threading.Tasks.Task(Of Boolean) Implements JHSoftware.SimpleDNS.Plugin.IIgnoreRequest.IgnoreRequest
    Return Threading.Tasks.Task.FromResult(True)
  End Function

End Class
