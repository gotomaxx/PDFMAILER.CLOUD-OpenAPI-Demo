# PDFMAILER.CLOUD REST API OpenAPI Code Generierung

PDFMAILER.CLOUD erzeugt aus den angebotenen REST APIs eine OpenAPI Spezifikation im YAML oder JSON Format, welches online heruntergeladen werden kann: [YAML](https://post.gotomaxx.com/service/rest/outgoing/swagger-config.yaml) [JSON](https://post.gotomaxx.com/service/rest/outgoing/swagger-config.json)

Diese API Spezifikation kann verwendet werden, um automatisiert SDKs für diverse Programmiersprachen zu verwenden. In diesem Beispiel für .NET (C#) wurde der [OpenAPI Generator](https://github.com/OpenAPITools/openapi-generator) mit diesem Kommando verwendet:

```bash
java -jar openapi-generator-cli.jar generate -i https://post.gotomaxx.com/PORTALNAME/service/rest/outgoing/swagger-config.yaml -g csharp-functions -o ./SDK/
```

Ersetzen Sie in der URI bitte `PORTALNAME` durch den Namen Ihres Portals. Eventuell muss der gesamte Teil vor `/service/rest/outgoing/swagger-config.yaml` für Ihr Portal individuell angepasst werden.

**ACHTUNG**: Unter Umständen produziert der Generator leider nicht ganz fehlerfreien Code. Bei unserem Test mussten wir zum Beispiel eine `using` Direktive ergänzen, damit das generierte Projekt kompiliert werden konnte.

Das generierte C# Projekt wurde dann in der Visual Studio Solution `Demo` (siehe `./Demo/Demo.sln`) referenziert. In der Datei `./Demo/Program.cs` sehen Sie, mit welchem C# Code ein API Aufruf zum Beispiel stattfinden könnte. Im Beispielcode können Sie Ihre persönlichen Zugangsdaten einsetzen - dann können Sie eine Liste gesendeter PDF Dokumente aus Ihrem Portal abrufen, indem Sie in Visual Studio die Taste F5 zum Starten der Anwendung drücken. Beispiel Ausgabe:

```txt
Anzahl PDF Dokumente: 1
PDF #1: "Dateiname.pdf"
```

**TIPP**: Verwenden Sie nur die generierten Modelle zum Erstellen eines Requests und zum Parsen des Response.
