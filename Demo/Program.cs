using Org.OpenAPITools.Models;
using System.Net.Http.Headers;
using System.Net.Http.Json;

// Definieren Sie hier Ihre persönlichen API Zugangsdaten
string key = "Ihr API Schlüssel",// Nutzen Sie bitte Ihren persönlichen REST API Schlüssel, der mit den entsprechenden Scopes erstellt wurde
    uri = "https://post.gotomaxx.com/PORTALNAME/service/rest/outgoing";// Nutzen Sie bitte die korrekte URI zu Ihrem Portal

// Senden eines REST requests - hier: Liste der gesendeten Dokumente abrufen (mit allen Standardeinstellungen)
using HttpClient client = new();

using HttpRequestMessage request = new(HttpMethod.Get, $"{uri}/pdf");
request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", key);

using HttpResponseMessage response = await client.SendAsync(request);
response.EnsureSuccessStatusCode();

// Verarbeiten des Response
GotomaxxPdfUploadRestResponse[] files = await response.Content.ReadFromJsonAsync<GotomaxxPdfUploadRestResponse[]>()
    ?? throw new InvalidDataException("Ungültiger response");

Console.WriteLine($"Anzahl PDF Dokumente: {files.Length}");
foreach (GotomaxxPdfUploadRestResponse file in files)
    Console.WriteLine($"PDF #{file.Id}: \"{file.File}\"");
