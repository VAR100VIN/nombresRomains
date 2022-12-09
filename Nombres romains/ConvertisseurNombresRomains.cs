﻿namespace NombresRomains
{
    public static class ConvertisseurNombresRomains
    {


        public static string Convertir(int nombreArabe)
            => nombreArabe switch
            {
                <= 3 => new string('I', nombreArabe),
                   4 => "IV",
                <= 8 => "V" + Convertir(nombreArabe - 5),
            };


    }
} 
