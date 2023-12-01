Imports System
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.IO
Imports System.Xml
Imports SNMPNET

Module Program
    Sub Main(args As String())
        Do


            Dim verificar As New Impressoras
            Console.Write("Deseja puxar todos os valores de um XML ou somente um especifico? (1 para todos e 2 para valor especifico)")
            If Console.ReadLine = 1 Then

            ElseIf Console.ReadLine = 2 Then
                Console.Write("Digite o caminho do arquivo: ")
                Dim caminho As String = Console.ReadLine
                Dim op��o As String
                Dim endereco As String
                Dim xmlDoc As New XmlDocument()

                If caminho = Nothing Then
                    Console.WriteLine("Arquivo n�o encontrado")
                Else
                    Do
                        Console.WriteLine("Digite o nome elemento do xml: ")
                        Dim elemeto As String = Console.ReadLine
                        Console.WriteLine("Digite o valor do elemento: ")
                        Dim valor As String = Console.ReadLine
                        Try
                            xmlDoc.Load(caminho)
                            endereco = xmlDoc.SelectSingleNode(elemeto).SelectSingleNode(valor).InnerText
                        Catch ex As Exception
                            Console.WriteLine("Elemento ou valor n�o encontrado!")
                        End Try

                        Console.WriteLine($"Valor do elemento: {endereco}")

                        Console.WriteLine("Deseja procurar mais algum valor do XML? (S\N): ")
                        op��o = Console.ReadLine
                        If op��o = "N" Or op��o = "n" Then
                            Exit Do

                        End If

                    Loop

                End If
            Else
                Console.WriteLine("Valor invalido!")
                Exit Do
            End If
        Loop
    End Sub
End Module
