dim xml as string = API.XML()
dim x as new system.xml.xmldocument
x.loadxml(xml)

If (x.SelectSingleNode("//input[@number='" & (x.SelectSingleNode("//preview").InnerText) & "']/@shortTitle").Value).Contains("1+3 --")
	API.Function("SetLayer", 0, "3,8")
	API.Function("SetLayer", 0, "4,10")
	API.Function("SetLayer", 0, "5,11")
	API.Function("SetLayer", 0, "5,12")
End if