﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using bd.log.guardar.Inicializar;

namespace bd.swLogProyect.entidades.Helpers
{
    public class InicializarWebApp
    {
       
        #region Methods

        public static async Task Inicializar(string id)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //client.BaseAddress = new Uri("http://localhost:53317");
                    //var url = string.Format("{0}/{1}", "/api/Adscsists", id);
                    //var respuesta = await client.GetAsync(url);

                    //var resultado = await respuesta.Content.ReadAsStringAsync();
                    //var response = JsonConvert.DeserializeObject<Response>(resultado);
                    //var sistema = JsonConvert.DeserializeObject<Adscsist>(response.Resultado.ToString());
                   
                    AppGuardarLog.BaseAddress= "http://localhost:5000";



                }
               
            }
            catch (Exception ex)
            {

            }

        }

        #endregion
    }
}
