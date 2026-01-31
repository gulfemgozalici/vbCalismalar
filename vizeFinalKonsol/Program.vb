Imports System
Module Program
    'Vize final notuna göre harf notu belirleme (vize %40, final %60 etkili)
        '0-19 -> FF
        '20-29 -> FD
        '30-49 -> DD
        '50-59 -> DC
        '60-69 -> CC
        '70-75 -> CB
        '76-79 -> BB
        '80-89 -> BA
        '90-100 -> AA
    sub main(args as String())
        dim vize, final as Integer
        dim ortalama as Single

        Console.Write("Vize notu: ")
        vize = Console.ReadLine()

        Console.Write("Final notu: ")
        final = Console.ReadLine()

        ortalama = vize*0.4 + final*0.6

        Console.Write($"Ortalama = {ortalama}, Vize = {vize}, Final = {final}" & Environment.NewLine)

        select case ortalama
            case 0 to 19
                Console.Write("FF")
            case 20 to 29
                Console.Write("FD")
            case 30 to 49
                Console.Write("DD")
            case 50 to 59
                Console.Write("DC")
            case 60 to 69
                Console.Write("CC")
            case 70 to 75
                Console.Write("CB")
            case 76 to 79
                Console.Write("BB")
            case 80 to 89
                Console.Write("BA")
            case 90 to 100
                Console.Write("AA")
            case Else
                Console.Write("HATA!")
        end select
    end sub
end Module
