Module Module1

	Sub Main()
		Dim fileReader As String
		fileReader = My.Computer.FileSystem.ReadAllText("C:\brojevi.txt")

		Dim ucitaniNiz() As String = fileReader.Split(",")
		Dim niz(14) As Integer
		For i = 0 To 14
			niz(i) = Int(ucitaniNiz(i))
			Console.Write(niz(i).ToString() + " ")
		Next
		Console.WriteLine("Broj za pretragu: ")
		Dim procitaniBroj As Integer = Int(Console.ReadLine())

		Dim Postoji As Boolean = False

		For i = 0 To 14
			Console.Write("Broj se nalazi na poziciji/ama: ")
			If niz(i) = procitaniBroj Then
				Console.Write((i + 1).ToString() + " ")
				Postoji = True
			End If
		Next

		If Postoji = False Then

		End If

		Console.ReadKey()
	End Sub

End Module
