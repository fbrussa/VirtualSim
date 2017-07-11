
Imports System.IO
Imports System.Net
imports System.Net.Sockets
imports System.Text
Imports System.Threading



Public Class MainForm


    Private thdUDPServer As Thread
    Public Delegate Sub ProcessRecivedData(text As String)
    Dim udpClient As UdpClient



    Public Sub serverThread()
        If udpClient IsNot Nothing Then
            udpClient.Close()
            udpClient = Nothing
        End If
        udpClient = New UdpClient(5002)
        While True
            Dim RemoteIpEndPoint As New IPEndPoint(System.Net.IPAddress.Any, 5002)
            Dim receiveBytes As Byte()
            receiveBytes = udpClient.Receive(RemoteIpEndPoint)
            processData(Encoding.ASCII.GetString(receiveBytes))
        End While
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            If btnStart.Text = "Start" Then
                thdUDPServer = New Thread(New ThreadStart(AddressOf serverThread))
                thdUDPServer.Start()
                btnStart.Text = "Stop"
                txtPort.Enabled = False
            Else
                btnStart.Text = "Start"
                txtPort.Enabled = True
                If thdUDPServer IsNot Nothing Then
                    thdUDPServer.Abort()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub processData(ByVal text As String)
        Try
            If txtLog.InvokeRequired Then
                txtLog.Invoke(New ProcessRecivedData(AddressOf processData), text)
            Else
                parseAndUpdate(text)
            End If
        Catch ex As Exception
            thdUDPServer.Abort()
            Return
        End Try
    End Sub


    Private Sub parseAndUpdate(text As String)
        txtLog.Text = text
        If text.Contains("A") And text.Contains("B") Then
            Dim A As Integer = text.Substring(2, text.IndexOf("]") - 2)
            Dim B As Integer
            Dim C As Integer

            Dim is2dofPlus As Boolean = False
            If text.IndexOf("C") >= 0 Then
                is2dofPlus = True
            End If

            If is2dofPlus Then
                B = text.Substring(text.IndexOf("B") + 1, text.IndexOf("]", text.IndexOf("B")) - text.IndexOf("B") - 1)
                C = text.Substring(text.IndexOf("C") + 1, text.LastIndexOf("]") - text.IndexOf("C") - 1)
            Else
                '2dof
                B = text.Substring(text.IndexOf("B") + 1, text.LastIndexOf("]") - text.IndexOf("B") - 1)
            End If


            'texts
            txtA.Text = A
            txtB.Text = B
            If is2dofPlus Then
                txtC.Text = C
            Else
                txtC.Text = ""
            End If



            ' gforce indicator
            Dim difX As Integer = B - A
            Dim difY As Integer = (B + (A - B) / 2) - 127


            gIndicator.Location = New Drawing.Point(difX / 2 + 84, difY / 2 + 84)


            'axis
            pLeft.Size = New Drawing.Size(18, (255 - A) / 255 * 150)
            pLeft.Location = New Drawing.Point(84, 15 + (150 - pLeft.Size.Height))

            pRight.Size = New Drawing.Size(18, (255 - B) / 255 * 150)
            pRight.Location = New Drawing.Point(168, 15 + (150 - pRight.Size.Height))

            If txtMaxX.Text = "" OrElse A > txtMaxX.Text Then
                txtMaxX.Text = A
            End If
            If txtMinX.Text = "" OrElse A < txtMinX.Text Then
                txtMinX.Text = A
            End If
            If txtMaxY.Text = "" OrElse B > txtMaxY.Text Then
                txtMaxY.Text = B
            End If
            If txtMinY.Text = "" OrElse B < txtMinY.Text Then
                txtMinY.Text = B
            End If

            If is2dofPlus Then
                If txtMinLoss.Text = "" OrElse C < txtMinLoss.Text Then
                    txtMinLoss.Text = C
                End If
                If txtMaxLoss.Text = "" OrElse C > txtMaxLoss.Text Then
                    txtMaxLoss.Text = C
                End If
                Dim wloss As Integer = (127 - C) * 118 / 127
                pLoss.Width = Math.Abs(wloss)
                wloss *= -1
                If wloss > 0 Then
                    pLoss.Location = New Drawing.Point(15 + 118, 245)
                Else
                    pLoss.Location = New Drawing.Point(15 + 118 + wloss, 245)
                End If

            End If



            ' images 
            Dim angleY As Integer = difY / 255 * 30 * -1
            Dim oldImageSide As Image = imgSide.Image
            imgSide.Image = RotateImage(New Bitmap(imgSideSource.Image), New Point(120, 180), angleY)

            Dim angleX As Integer = difX / 255 * 30
            Dim oldImageFront As Image = imgFront.Image
            imgFront.Image = RotateImage(New Bitmap(imgFrontSource.Image), New Point(120, 200), angleX)


            If oldImageSide IsNot Nothing Then
                oldImageSide.Dispose()
            End If
            If oldImageFront IsNot Nothing Then
                oldImageFront.Dispose()
            End If


        End If
    End Sub


    Function RotateImage(image As Image, offset As Point, angle As Decimal) As Bitmap
        If image IsNot Nothing Then

            Dim rotatedBmp As New Bitmap(image.Width, image.Height)
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution)
            Dim g As Graphics = Graphics.FromImage(rotatedBmp)
            g.TranslateTransform(offset.X, offset.Y)
            g.RotateTransform(angle)
            g.TranslateTransform(-offset.X, -offset.Y)
            g.DrawImage(image, New PointF(0, 0))
            Return rotatedBmp
        End If

    End Function


    Private Sub MainForm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try
            If thdUDPServer IsNot Nothing Then
                If udpClient IsNot Nothing Then
                    udpClient.Close()
                    udpClient = Nothing
                End If
                thdUDPServer.Abort()
            End If
        Catch ex As Exception
        End Try
    End Sub

    
End Class
