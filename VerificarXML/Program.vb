Imports System
Imports System.Drawing
Imports System.IO
Imports System.Xml
Imports SNMPNET

Module Program
    Sub Main(args As String())
        Do
            Dim verificar As New Impressoras
            Console.Write("Digite o caminho do arquivo: ")
            Dim caminho As String = Console.ReadLine
            Dim opção As String
            Dim endereco As String
            Dim comunidade As String
            Dim xmlDoc As New XmlDocument()
            Dim VER As String
            Dim fabricante As String
            Dim modelo As String
            Dim serial As String
            Dim leitura As String
            If caminho = Nothing Then
                Console.WriteLine("Arquivo não encontrado")
            Else
                xmlDoc.Load(caminho)
                endereco = xmlDoc.SelectSingleNode("INFO").SelectSingleNode("ENDERECO").InnerText
                comunidade = xmlDoc.SelectSingleNode("INFO").SelectSingleNode("COM_SNMP").InnerText
                VER = xmlDoc.SelectSingleNode("INFO").SelectSingleNode("VER_SNMP").InnerText
                fabricante = xmlDoc.SelectSingleNode("INFO").SelectSingleNode("FABRICANTE").InnerText
                modelo = xmlDoc.SelectSingleNode("INFO").SelectSingleNode("MODELO").InnerText
                serial = xmlDoc.SelectSingleNode("INFO").SelectSingleNode("SERIAL").InnerText
                leitura = xmlDoc.SelectSingleNode("INFO").SelectSingleNode("LEITURA").InnerText
                Console.WriteLine(endereco + " " + comunidade + " " + VER + " " + fabricante + " " + modelo + " " + serial + " " + leitura + vbCrLf)

                Console.WriteLine("Deseja procurar um arquivo mais algum arquivo? (S\N): ")
                opção = Console.ReadLine
                If opção = "N" Or opção = "n" Then
                    Exit Do
                End If
            End If
        Loop




    End Sub
End Module
