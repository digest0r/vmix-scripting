dim xml as string = API.XML()
dim x as new system.xml.xmldocument
x.loadxml(xml)

If (x.SelectSingleNode("//input[@number='" & (x.SelectSingleNode("//preview").InnerText) & "']/@shortTitle").Value).Contains("Background --")
    API.Function("SetCCLiftRGB", 0, "0.05")
    API.Function("SetCCGammaRGB", 0, "0.15")
    API.Function("SetCCGainRGB", 0, "1.2")
End if
