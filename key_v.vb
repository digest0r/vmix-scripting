dim xml as string = API.XML()
dim x as new system.xml.xmldocument
x.loadxml(xml)

If (x.SelectSingleNode("//input[@number='" & (x.SelectSingleNode("//preview").InnerText) & "']/@shortTitle").Value).Contains("Background --")
    API.Function("SetCCLiftRGB", 0, "0")
    API.Function("SetCCGammaRGB", 0, "0")
    API.Function("SetCCGainRGB", 0, "1")
End if
