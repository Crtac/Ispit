Module Module1

	Sub Main()
		Dim fileReader As String
		fileReader = My.Computer.FileSystem.ReadAllText("C:\tekst.txt")

		Dim tekst As String = fileReader
		Console.WriteLine(tekst)
		Dim karakteri() As Char = tekst.ToCharArray
		Dim brojIzmjena As Integer = 0
		Dim noviTekst As String = ""
		For i = 0 To karakteri.Length - 1
			If karakteri(i) = "a" Or karakteri(i) = "e" Or karakteri(i) = "i" Or karakteri(i) = "o" Or karakteri(i) = "u" Then
				brojIzmjena += 1
				karakteri(i) = "*"
			End If
			noviTekst += karakteri(i)
		Next

		Console.WriteLine("Broj izmjena je " + brojIzmjena.ToString())
		Console.WriteLine(noviTekst)

		My.Computer.FileSystem.WriteAllText("C:\tekst.txt", noviTekst, False)
		Console.ReadLine()
	End Sub

End Module
