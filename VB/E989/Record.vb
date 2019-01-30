Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Text

Namespace E989
    Public Class Record
        Public Sub New()
        End Sub

        Private id_Renamed As Integer
        Public Property ID() As Integer
            Get
                Return id_Renamed
            End Get
            Set(ByVal value As Integer)
                If id_Renamed <> value Then
                    id_Renamed = value
                End If
            End Set
        End Property

        Private parentID_Renamed As Integer
        Public Property ParentID() As Integer
            Get
                Return parentID_Renamed
            End Get
            Set(ByVal value As Integer)
                If parentID_Renamed <> value Then
                    parentID_Renamed = value
                End If
            End Set
        End Property

        Private text_Renamed As String
        Public Property Text() As String
            Get
                Return text_Renamed
            End Get
            Set(ByVal value As String)
                If text_Renamed <> value Then
                    text_Renamed = value
                End If
            End Set
        End Property

        Private info_Renamed As String
        Public Property Info() As String
            Get
                Return info_Renamed
            End Get
            Set(ByVal value As String)
                If info_Renamed <> value Then
                    info_Renamed = value
                End If
            End Set
        End Property
        Private val As Decimal
        Public Property Value() As Decimal
            Get
                Return val
            End Get
            Set(ByVal value As Decimal)
                If val <> value Then
                    val = value
                End If
            End Set
        End Property

        Private dt_Renamed As TimeSpan
        Public Property Dt() As TimeSpan
            Get
                Return dt_Renamed
            End Get
            Set(ByVal value As TimeSpan)
                If dt_Renamed <> value Then
                    dt_Renamed = value
                End If
            End Set
        End Property

        Private state_Renamed As Boolean
        Public Property State() As Boolean
            Get
                Return state_Renamed
            End Get
            Set(ByVal value As Boolean)
                If state_Renamed <> value Then
                    state_Renamed = value
                End If
            End Set
        End Property

        Private image_Renamed As Image
        Public Property Image() As Image
            Get
                Return image_Renamed
            End Get
            Set(ByVal value As Image)
                If image_Renamed IsNot value Then
                    image_Renamed = value
                End If
            End Set
        End Property
    End Class
    Public Class DataHelper
        Public Shared Function GetData(ByVal count As Integer) As BindingList(Of Record)
            Dim records As New BindingList(Of Record)()
            For i As Integer = 0 To count - 1
                records.Add(New Record() With { _
                    .ID = i, _
                    .ParentID = If(i > 10, i Mod 5, i Mod 2), _
                    .Text = String.Format("Text{0}", i), _
                    .Dt = TimeSpan.FromHours(i), _
                    .Value = If(i Mod 2 = 0, (i * 1.1222213D), (i * 1.02312D)), _
                    .State = i Mod 2 = 0, _
                    .Image = SystemIcons.Information.ToBitmap(), _
                    .Info = String.Format("Info{0}",If(i Mod 2 = 0, i, i + 2)) _
                })
            Next i
            Return records
        End Function
    End Class
End Namespace
