using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Asincrona
{
    public class Asincrona
    {
        public async Task<string> GetWebContentAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // Espera la respuesta de la solicitud sin bloquear el hilo principal
                HttpResponseMessage response = await client.GetAsync(url);
                // Verifica que la respuesta sea exitosa
                response.EnsureSuccessStatusCode();
                // Lee el contenido de la respuesta de manera asíncrona
                string content =  await response.Content.ReadAsStringAsync();
                return content;
            }
        }

    }
}
