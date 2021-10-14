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
		Console.WriteLine()
		Dim imaZajednickih As Boolean = False
		Console.Write("Zajednički su :> ")
		For i = 0 To 19
			For j = 0 To 19
				If a(i) = b(j) Then
					Console.Write(a(i).ToString + " ")
					imaZajednickih = True
				End If
			Next
		Next

		If imaZajednickih = False Then
			Console.WriteLine("Nema zajedničkih")
		End If

		Console.ReadKey()
	End Sub

End Module
