Module Module1

	Sub Main()
		Dim fileReader As String
		fileReader = My.Computer.FileSystem.ReadAllText("C:\ispit.txt")

		Dim nizPom() As String = fileReader.Split(";")
		Dim niz(14) As Integer

		Console.Write("Unesite broj za pretragu:> ")
		Dim broj As Integer = Int(Console.ReadLine())

		Dim pozicija As Integer = -1

		For i = 0 To niz.Length - 1
			niz(i) = Convert.ToInt32(nizPom(i))
			Console.Write(niz(i).ToString() + " ")
			If niz(i) = broj Then
				pozicija = i
			End If
		Next

		Console.WriteLine()

		Console.ReadKey()
	End Sub

End Module
