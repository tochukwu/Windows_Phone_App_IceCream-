﻿#ExternalChecksum("H:\My Documents\Visual Studio 2010\Projects\PhoneAppIceCream\PhoneAppIceCream\Lager.xaml","{406ea660-64cf-4c82-b6f0-42d48172a799}","FFD0851187F42CA9BD073733E5BD40CB")
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
Partial Public Class Lager
    Inherits Microsoft.Phone.Controls.PhoneApplicationPage
    
    Friend WithEvents LayoutRoot As System.Windows.Controls.Grid
    
    Friend WithEvents TextBlock1 As System.Windows.Controls.TextBlock
    
    Friend WithEvents TextBox1 As System.Windows.Controls.TextBox
    
    Friend WithEvents btnMinus As System.Windows.Controls.Button
    
    Friend WithEvents btnPlus As System.Windows.Controls.Button
    
    Friend WithEvents txtBoxScoops As System.Windows.Controls.TextBox
    
    Friend WithEvents TextBlock2 As System.Windows.Controls.TextBlock
    
    Friend WithEvents btnMoreIC As System.Windows.Controls.Button
    
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
        System.Windows.Application.LoadComponent(Me, New System.Uri("/PhoneAppIceCream;component/Lager.xaml", System.UriKind.Relative))
        Me.LayoutRoot = CType(Me.FindName("LayoutRoot"),System.Windows.Controls.Grid)
        Me.TextBlock1 = CType(Me.FindName("TextBlock1"),System.Windows.Controls.TextBlock)
        Me.TextBox1 = CType(Me.FindName("TextBox1"),System.Windows.Controls.TextBox)
        Me.btnMinus = CType(Me.FindName("btnMinus"),System.Windows.Controls.Button)
        Me.btnPlus = CType(Me.FindName("btnPlus"),System.Windows.Controls.Button)
        Me.txtBoxScoops = CType(Me.FindName("txtBoxScoops"),System.Windows.Controls.TextBox)
        Me.TextBlock2 = CType(Me.FindName("TextBlock2"),System.Windows.Controls.TextBlock)
        Me.btnMoreIC = CType(Me.FindName("btnMoreIC"),System.Windows.Controls.Button)
        Me.btnBasket = CType(Me.FindName("btnBasket"),System.Windows.Controls.Button)
    End Sub
End Class

