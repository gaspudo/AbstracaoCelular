using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CelularDIO.Models
{
    public class Nokia : Celular
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia {Modelo}...\nAbrindo a Play Store para baixar o aplicativo {nomeApp}...");
        }
    }
}