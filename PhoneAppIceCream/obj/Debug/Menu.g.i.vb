﻿#ExternalChecksum("H:\My Documents\Visual Studio 2010\Projects\PhoneAppIceCream\PhoneAppIceCream\Menu.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","D43A4306DF3B14A897FA47CF6FE96DC4")
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
Partial Public Class Menu
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents TitlePanel As System.Windows.Controls.StackPanel
    
    Friend WithEvents ContentPanel As System.Windows.Controls.Grid
    
    Friend WithEvents btnVanilla As System.Windows.Controls.Button
    
    Friend WithEvents btnChocolate As System.Windows.Controls.Button
    
    Friend WithEvents btnStrawberry As System.Windows.Controls.Button
    
    Friend WithEvents btnBanana As System.Windows.Controls.Button
    
    Friend WithEvents btnCurry As System.Windows.Controls.Button
    
    Friend WithEvents btnEgg As System.Windows.Controls.Button
    
    Friend WithEvents btnLemon As System.Windows.Controls.Button
    
    Friend WithEvents btnMint As System.Windows.Controls.Button
    
    Friend WithEvents btnLager As System.Windows.Controls.Button
    
    Friend WithEvents btnBasket As System.Windows.Controls.Button
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/PhoneAppIceCream;component/Menu.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.TitlePanel = CType(Me.FindName("TitlePanel"),System.Windows.Controls.StackPanel)
        Me.ContentPanel = CType(Me.FindName("ContentPanel"),System.Windows.Controls.Grid)
        Me.btnVanilla = CType(Me.FindName("btnVanilla"),System.Windows.Controls.Button)
        Me.btnChocolate = CType(Me.FindName("btnChocolate"),System.Windows.Controls.Button)
        Me.btnStrawberry = CType(Me.FindName("btnStrawberry"),System.Windows.Controls.Button)
        Me.btnBanana = CType(Me.FindName("btnBanana"),System.Windows.Controls.Button)
        Me.btnCurry = CType(Me.FindName("btnCurry"),System.Windows.Controls.Button)
        Me.btnEgg = CType(Me.FindName("btnEgg"),System.Windows.Controls.Button)
        Me.btnLemon = CType(Me.FindName("btnLemon"),System.Windows.Controls.Button)
        Me.btnMint = CType(Me.FindName("btnMint"),System.Windows.Controls.Button)
        Me.btnLager = CType(Me.FindName("btnLager"),System.Windows.Controls.Button)
        Me.btnBasket = CType(Me.FindName("btnBasket"),System.Windows.Controls.Button)
    End Sub
End Class

