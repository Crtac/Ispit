Module Module1

	Sub Main()
		Randomize()
		Dim a(19) As Integer
		Dim b(19) As Integer

		For i = 0 To 19
			a(i) = Rnd() * 50 + 10
			b(i) = Rnd() * 50 + 10
		Next

		For i = 0 To 19
			Console.Write(a(i).ToString() + " ")
		Next
		Console.WriteLine()
		For i = 0 To 19
			Console.Write(b(i).ToString() + " ")
		Next



		Console.ReadKey()
	End Sub

End Module
