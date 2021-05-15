dim xml as string = API.XML()
dim x as new system.xml.xmldocument
x.loadxml(xml)

If (x.SelectSingleNode("//input[@number='" & (x.SelectSingleNode("//preview").InnerText) & "']/@shortTitle").Value).Contains("🎥 Speaker ")
	API.Function("SetLayer", 0, "4,12")
End if

If (x.SelectSingleNode("//input[@number='" & (x.SelectSingleNode("//preview").InnerText) & "']/@shortTitle").Value).Contains("1+2 --")
	API.Function("SetLayer", 0, "3,12")
	API.Function("SetLayer", 0, "4,10")
	API.Function("SetLayer", 0, "5,11")
End if

If (x.SelectSingleNode("//input[@number='" & (x.SelectSingleNode("//preview").InnerText) & "']/@shortTitle").Value).Contains("1+3 --")
	API.Function("SetLayer", 0, "3,12")
	API.Function("SetLayer", 0, "4,10")
	API.Function("SetLayer", 0, "5,11")
	API.Function("SetLayer", 0, "6,8")
End if