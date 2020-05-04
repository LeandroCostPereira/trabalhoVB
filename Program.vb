Imports System
Imports System.IO
Module Program
    Sub Main()
        Dim f As FileStream

        Try
            f = New FileStream("alfabeto", FileMode.Create)
        Catch ex As Exception
            Console.WriteLine("Erro ao criar o ficheiro!" & vbNewLine & ex.Message)
            Return
        End Try

        For i As Integer = Asc("A") To Asc("Z")
            Try
                f.WriteByte(CByte(i))
            Catch ex As Exception
                Console.WriteLine("Erro ao escrever o ficheiro" & vbNewLine & ex.Message)
                Return
            End Try
        Next

        Console.WriteLine()
        f.Close()

        Module2.main()
        Console.Read()
    End Sub
End Module
