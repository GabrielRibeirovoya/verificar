Imports System
Imports System.ComponentModel.Design
Imports System.Drawing
Imports System.Globalization
Imports System.IO
Imports System.Xml
Imports SNMPNET

Module Program
    Sub Main(args As String())
        Do

            Console.WriteLine("Deseja puxar todos os valores de um XML ou somente um especifico (1 para todos e 2 para valor especifico)? ")
            If Console.ReadLine = 1 Then
                Dim xmlDoc As New XmlDocument()
                Console.Write("Digite o caminho do arquivo: ")
                Dim caminho As String = Console.ReadLine
                Dim opção As String
                Dim endereco As String
                If caminho = Nothing Then
                    Console.WriteLine("Arquivo não encontrado")
                Else
                    Do
                        Try
                            xmlDoc.Load(caminho)
                            Console.WriteLine("Digite o nome do elemento: ")
                            endereco = xmlDoc.SelectSingleNode(Console.ReadLine).InnerText
                            Console.WriteLine(endereco + " ")

                            Console.WriteLine("Deseja procurar mais algum arquivo XML? (S\N): ")
                            opção = Console.ReadLine
                            If opção = "N" Or opção = "n" Then
                                Exit Do
                            End If
                        Catch ex As Exception
                            Console.WriteLine("Elemento não encontrado!")
                            Exit Do
                        End Try
                    Loop

                End If
            ElseIf Console.ReadLine = 2 Then
                Console.Write("Digite o caminho do arquivo: ")
                Dim caminho As String = Console.ReadLine
                Dim opção As String
                Dim endereco As String
                Dim xmlDoc As New XmlDocument()

                If caminho = Nothing Then
                    Console.WriteLine("Arquivo não encontrado")
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
                            Console.WriteLine("Elemento ou valor não encontrado!")
                        End Try

                        Console.WriteLine($"Valor do elemento: {endereco}")

                        Console.WriteLine("Deseja procurar mais algum valor do XML? (S\N): ")
                        opção = Console.ReadLine
                        If opção = "N" Or opção = "n" Then
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
