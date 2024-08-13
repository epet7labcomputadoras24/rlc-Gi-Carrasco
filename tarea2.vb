Imports System

Module Program
    Sub Main(args As String())
        Dim F As Single
        Dim L As Single
        Dim C As Single
        Dim XL As Single
        Dim XC As Single
        Dim R As Single
        Dim X As Single
        Dim Z As Single
        Dim AZ As Single
        Dim FR As Single
        Dim PI As Single
        Console.WriteLine("Ingrese el valor de la Frecuencia")
        F = Console.ReadLine()
        Console.WriteLine("Ingrese el valor de la Inductancia")
        L = Console.ReadLine()
        Console.WriteLine("Ingrese el valor de la  Capacitancia")
        C = Console.ReadLine()
        Console.WriteLine("Ingrese el valor de la Resistencia")
        R = Console.ReadLine()
        PI = 3.1415
        XL = 2 * PI * F * L
        XC = 1 / (2 * PI * F * C)
        X = XL - XC
        Z = Math.Sqrt(R ^ 2 + X ^ 2)
        AZ = Math.Atan(X / R)
        FR = 1 / (2 * PI * Math.Sqrt(L * C))
        Console.WriteLine("El valor de XL es:" & XL)
        Console.WriteLine("El valor de XC es:" & XC)
        Console.WriteLine("El valor de R es:" & R)
        Console.WriteLine("El valor de X es:" & X)
        Console.WriteLine("El valor de |Z| es:" & Z)
        Console.WriteLine("El valor del angulo es:" & AZ)
        Console.WriteLine("El valor de la FR es:" & FR)
        Console.ReadLine()
    End Sub
End Module