using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public static class testTexto
{
    // Start is called before the first frame update
    // ubicacion del archivo con las claves.
    static string path = "Assets/Resources/configuracion.txt";

    // datos necesarios para la integracion con twitch, las consigo de un fichero por seguridad y modularidad.
    public static string accountName { set; get; } = null;
    public static string accessToken { set; get; } = null;

    public static string refreshToken { set; get; } = null;

    public static string ooauthTwitch { set; get; } = null;
    public static string channelName { set; get; } = null;






    // Update is called once per frame

    public static void readConfig()
    {


        StreamReader reader = new StreamReader(path);
        accountName = reader.ReadLine();
        accessToken = reader.ReadLine();
        refreshToken = reader.ReadLine();
        ooauthTwitch = reader.ReadLine();
        channelName = reader.ReadLine();



        reader.Close();
    }
}
