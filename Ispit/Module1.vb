Module Module1

	Sub Main()

		Console.Write("Unesite cijeli broj n dužine: ")

		Dim broj As String = Console.ReadLine()

		Console.Write("Unesite dužinu podbroja: ")

		Dim duzina As Integer = Convert.ToInt32(Console.ReadLine())

		Dim brojevi() As Char = broj.ToCharArray()

		For i = 0 To brojevi.Length - 1
			If (brojevi.Length - i + 1) > duzina Then

				For j = 0 To duzina - 1
					If brojevi.Length - 1 > (i + j) - 1 Then
						Console.Write(brojevi(i + j))
					End If
				Next
				Console.Write(",")
			End If
		Next

		Console.ReadKey()
	End Sub

End Module
