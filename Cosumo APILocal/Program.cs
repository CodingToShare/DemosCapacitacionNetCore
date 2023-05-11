using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    var apiURL = "https://localhost:7142";
    var endpoint = "/weatherforecast";
    var endpointLogin = "/login";

    var requestBody = "{\"mail\"  \"test@gamil.com\", \"Password\"  \"Pa$$w0rd1\"}";

    var content = new StringContent(requestBody, Encoding.UTF8, "application/json");

    HttpResponseMessage reponse = await client.GetAsync(apiURL + endpoint);

    HttpResponseMessage reponsePost = await client.PostAsync(apiURL + endpointLogin, content);

    if (reponse.IsSuccessStatusCode)
    {
        var responseBody = await reponse.Content.ReadAsStringAsync();
        Console.WriteLine(responseBody);

        var algo = JsonSerializer.Deserialize<algo>(responseBody);
    }
    else
    {
        Console.WriteLine("Error");
    }
}


class algo
{

}