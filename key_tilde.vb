dim xml as string = API.XML()
dim x as new system.xml.xmldocument
x.loadxml(xml)

If (x.SelectSingleNode("//input[@number='" & (x.SelectSingleNode("//preview").InnerText) & "']/@shortTitle").Value).Contains("🎥 Speaker ")
	API.Function("LayerOnOff", 0, 10)
End if
