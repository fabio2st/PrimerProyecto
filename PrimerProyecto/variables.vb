Module variables
    Sub main()
        Dim pc As String
        pc = "Lenovo"
        Dim modelo As String = "Tactil q tul"
        Console.WriteLine(pc & " " & modelo)

        Dim car As Char
        car = "a"
        Console.WriteLine(car)
        Dim a As Byte
        'a = -3
        Console.WriteLine(a)
        Dim entero As UShort
        'entero -= 10

        Dim pi32 As Single = Math.PI
        Console.WriteLine("pi single: " & pi32)
        Dim pi64 As Double = Math.PI
        Console.WriteLine("pi double: " & pi64)
        Dim pi128 As Decimal = Math.PI
        Console.WriteLine("pi decimal: " & pi128)
        pi32 = pi32 * 4
        Console.WriteLine("pi single: " & pi32)

        Dim ahora As Date = Date.Now
        Console.WriteLine("ahora: " & ahora)

        Dim ayer As Date = #4-2-2017#
        Console.WriteLine("ahora: " & ayer)

        Console.ReadKey()
    End Sub
End Module
