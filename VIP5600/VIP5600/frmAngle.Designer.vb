﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAngle
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnA = New System.Windows.Forms.Button()
        Me.btnU = New System.Windows.Forms.Button()
        Me.btnA1 = New System.Windows.Forms.Button()
        Me.btnU1 = New System.Windows.Forms.Button()
        Me.btnA2 = New System.Windows.Forms.Button()
        Me.btnU2 = New System.Windows.Forms.Button()
        Me.btnSetU1 = New System.Windows.Forms.Button()
        Me.btnSetU2 = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 32.0!)
        Me.btnBack.ForeColor = System.Drawing.Color.Black
        Me.btnBack.Image = Global.Gidrogasitel.My.Resources.Resources.circle_back_arrow_32
        Me.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.Location = New System.Drawing.Point(80, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(600, 75)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Датчик угла наклона"
        Me.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnA
        '
        Me.btnA.Enabled = False
        Me.btnA.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnA.ForeColor = System.Drawing.Color.Black
        Me.btnA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnA.Location = New System.Drawing.Point(80, 140)
        Me.btnA.Margin = New System.Windows.Forms.Padding(80, 10, 3, 0)
        Me.btnA.Name = "btnA"
        Me.btnA.Size = New System.Drawing.Size(300, 50)
        Me.btnA.TabIndex = 1
        Me.btnA.Text = "Угол="
        Me.btnA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnA.UseVisualStyleBackColor = True
        '
        'btnU
        '
        Me.btnU.Enabled = False
        Me.btnU.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnU.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnU.ForeColor = System.Drawing.Color.Black
        Me.btnU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU.Location = New System.Drawing.Point(80, 200)
        Me.btnU.Margin = New System.Windows.Forms.Padding(80, 10, 3, 0)
        Me.btnU.Name = "btnU"
        Me.btnU.Size = New System.Drawing.Size(300, 50)
        Me.btnU.TabIndex = 2
        Me.btnU.Text = "U="
        Me.btnU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnU.UseVisualStyleBackColor = True
        '
        'btnA1
        '
        Me.btnA1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnA1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnA1.Location = New System.Drawing.Point(80, 260)
        Me.btnA1.Margin = New System.Windows.Forms.Padding(80, 10, 3, 0)
        Me.btnA1.Name = "btnA1"
        Me.btnA1.Size = New System.Drawing.Size(300, 50)
        Me.btnA1.TabIndex = 3
        Me.btnA1.Text = "Угол1="
        Me.btnA1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnA1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnA1.UseVisualStyleBackColor = True
        '
        'btnU1
        '
        Me.btnU1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnU1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnU1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU1.Location = New System.Drawing.Point(80, 320)
        Me.btnU1.Margin = New System.Windows.Forms.Padding(80, 10, 3, 0)
        Me.btnU1.Name = "btnU1"
        Me.btnU1.Size = New System.Drawing.Size(300, 50)
        Me.btnU1.TabIndex = 4
        Me.btnU1.Text = "U1="
        Me.btnU1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnU1.UseVisualStyleBackColor = True
        '
        'btnA2
        '
        Me.btnA2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnA2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnA2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnA2.Location = New System.Drawing.Point(80, 380)
        Me.btnA2.Margin = New System.Windows.Forms.Padding(80, 10, 3, 0)
        Me.btnA2.Name = "btnA2"
        Me.btnA2.Size = New System.Drawing.Size(300, 50)
        Me.btnA2.TabIndex = 5
        Me.btnA2.Text = "Угол2="
        Me.btnA2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnA2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnA2.UseVisualStyleBackColor = True
        '
        'btnU2
        '
        Me.btnU2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnU2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnU2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnU2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU2.Location = New System.Drawing.Point(80, 440)
        Me.btnU2.Margin = New System.Windows.Forms.Padding(80, 10, 3, 0)
        Me.btnU2.Name = "btnU2"
        Me.btnU2.Size = New System.Drawing.Size(300, 50)
        Me.btnU2.TabIndex = 6
        Me.btnU2.Text = "U2="
        Me.btnU2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnU2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnU2.UseVisualStyleBackColor = True
        '
        'btnSetU1
        '
        Me.btnSetU1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnSetU1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetU1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSetU1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetU1.Location = New System.Drawing.Point(453, 320)
        Me.btnSetU1.Margin = New System.Windows.Forms.Padding(70, 10, 3, 0)
        Me.btnSetU1.Name = "btnSetU1"
        Me.btnSetU1.Size = New System.Drawing.Size(300, 50)
        Me.btnSetU1.TabIndex = 9
        Me.btnSetU1.Text = "Установить U1=U"
        Me.btnSetU1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetU1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetU1.UseVisualStyleBackColor = True
        '
        'btnSetU2
        '
        Me.btnSetU2.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnSetU2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSetU2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnSetU2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetU2.Location = New System.Drawing.Point(453, 440)
        Me.btnSetU2.Margin = New System.Windows.Forms.Padding(70, 10, 3, 0)
        Me.btnSetU2.Name = "btnSetU2"
        Me.btnSetU2.Size = New System.Drawing.Size(300, 50)
        Me.btnSetU2.TabIndex = 10
        Me.btnSetU2.Text = "Установить U2=U"
        Me.btnSetU2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetU2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnSetU2.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnCancel.Image = Global.Gidrogasitel.My.Resources.Resources.button_cancel
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(453, 500)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(80, 10, 3, 0)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(200, 75)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "Нет"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue
        Me.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOk.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnOk.Image = Global.Gidrogasitel.My.Resources.Resources.Ok
        Me.btnOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.Location = New System.Drawing.Point(80, 500)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(80, 10, 3, 0)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(200, 75)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Да"
        Me.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmAngle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.btnSetU2)
        Me.Controls.Add(Me.btnSetU1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.btnU2)
        Me.Controls.Add(Me.btnA2)
        Me.Controls.Add(Me.btnU1)
        Me.Controls.Add(Me.btnA1)
        Me.Controls.Add(Me.btnU)
        Me.Controls.Add(Me.btnA)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximumSize = New System.Drawing.Size(1024, 768)
        Me.Name = "frmAngle"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnA As System.Windows.Forms.Button
    Friend WithEvents btnU As System.Windows.Forms.Button
    Friend WithEvents btnA1 As System.Windows.Forms.Button
    Friend WithEvents btnU1 As System.Windows.Forms.Button
    Friend WithEvents btnA2 As System.Windows.Forms.Button
    Friend WithEvents btnU2 As System.Windows.Forms.Button
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSetU1 As System.Windows.Forms.Button
    Friend WithEvents btnSetU2 As System.Windows.Forms.Button
End Class
