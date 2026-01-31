Imports System

Module Program
    Sub Main(args As String())

        dim sayi1, sayi2, toplama, cikarma, carpma, islemSecimi as Integer
        dim bolme as Single

        Console.Write("1. sayıyı gir: ")
        sayi1 = Console.ReadLine()

        Console.Write("2. sayıyı gir: ")
        sayi2 = Console.ReadLine()

        toplama = sayi1 + sayi2
        cikarma = sayi1 - sayi2
        carpma = sayi1 * sayi2
        bolme = sayi1 / sayi2

        Console.WriteLine("Yapılacak işlemi seç:" & vbCrLf & "Toplama: 1, Çıkarma: 2, Çarpma: 3, Bölme: 4")
        islemSecimi = Console.ReadLine()

        select case islemSecimi
            case 1
                Console.Write($"Toplama = {toplama}")
            case 2
                Console.Write($"Çıkarma = {cikarma}")
            case 3
                Console.Write($"Çarpma = {carpma}")
            case 4
                Console.Write($"Bölme = {bolme}")
            case Else
                Console.Write("HATA!")
        end select
    End Sub
End Module
