﻿#ExternalChecksum("E:\New folder (3)\PhoneAppIceCream\PhoneAppIceCream\Report.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","FC8B9BF15CAF41A11A14C40A7E01667A")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18063
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports Microsoft.Phone.Controls
Imports System
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Automation.Peers
Imports System.Windows.Automation.Provider
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Interop
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Imaging
Imports System.Windows.Resources
Imports System.Windows.Shapes
Imports System.Windows.Threading



<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class Report
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents btnReport As System.Windows.Controls.Button
    
    Friend WithEvents TxtBReportName As System.Windows.Controls.TextBox
    
    Friend WithEvents TextBlock1 As System.Windows.Controls.TextBlock
    
    Friend WithEvents TextBlock2 As System.Windows.Controls.TextBlock
    
    Friend WithEvents TextBlock12 As System.Windows.Controls.TextBlock
    
    Friend WithEvents TxtBTotalCustomer As System.Windows.Controls.TextBox
    
    Friend WithEvents TextBlock16 As System.Windows.Controls.TextBlock
    
    Friend WithEvents TxtBMemberTotal As System.Windows.Controls.TextBox
    
    Friend WithEvents TextBlock17 As System.Windows.Controls.TextBlock
    
    Friend WithEvents TxtBAveragePrice As System.Windows.Controls.TextBox
    
    Friend WithEvents TxtBPTotal As System.Windows.Controls.TextBox
    
    Friend WithEvents TxtBQTotal As System.Windows.Controls.TextBox
    
    Friend WithEvents TextBlock3 As System.Windows.Controls.TextBlock
    
    Friend WithEvents TextBlock4 As System.Windows.Controls.TextBlock
    
    Friend WithEvents TextBlock14 As System.Windows.Controls.TextBlock
    
    Friend WithEvents TxtLabel As System.Windows.Controls.TextBlock
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
    Public Sub InitializeComponent()
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        System.Windows.Application.LoadComponent(Me, New System.Uri("/PhoneAppIceCream;component/Report.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.btnReport = CType(Me.FindName("btnReport"),System.Windows.Controls.Button)
        Me.TxtBReportName = CType(Me.FindName("TxtBReportName"),System.Windows.Controls.TextBox)
        Me.TextBlock1 = CType(Me.FindName("TextBlock1"),System.Windows.Controls.TextBlock)
        Me.TextBlock2 = CType(Me.FindName("TextBlock2"),System.Windows.Controls.TextBlock)
        Me.TextBlock12 = CType(Me.FindName("TextBlock12"),System.Windows.Controls.TextBlock)
        Me.TxtBTotalCustomer = CType(Me.FindName("TxtBTotalCustomer"),System.Windows.Controls.TextBox)
        Me.TextBlock16 = CType(Me.FindName("TextBlock16"),System.Windows.Controls.TextBlock)
        Me.TxtBMemberTotal = CType(Me.FindName("TxtBMemberTotal"),System.Windows.Controls.TextBox)
        Me.TextBlock17 = CType(Me.FindName("TextBlock17"),System.Windows.Controls.TextBlock)
        Me.TxtBAveragePrice = CType(Me.FindName("TxtBAveragePrice"),System.Windows.Controls.TextBox)
        Me.TxtBPTotal = CType(Me.FindName("TxtBPTotal"),System.Windows.Controls.TextBox)
        Me.TxtBQTotal = CType(Me.FindName("TxtBQTotal"),System.Windows.Controls.TextBox)
        Me.TextBlock3 = CType(Me.FindName("TextBlock3"),System.Windows.Controls.TextBlock)
        Me.TextBlock4 = CType(Me.FindName("TextBlock4"),System.Windows.Controls.TextBlock)
        Me.TextBlock14 = CType(Me.FindName("TextBlock14"),System.Windows.Controls.TextBlock)
        Me.TxtLabel = CType(Me.FindName("TxtLabel"),System.Windows.Controls.TextBlock)
    End Sub
End Class

