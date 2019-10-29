using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TwitchLib.Client.Models;
using TwitchLib.Unity;
using UnityEngine.UI;





public class twitch_integration_test : MonoBehaviour
{

    // panel de texto para el chat
    public Text panelTextoChat;
    public GameObject player1;
    public GameObject player2;
    //booleano para activar el debug de esta clase unicamente
    private bool twitchdebut = true;



    // clase de la libreria de Twitch
    public Client cliente;
    void Start()
    {

        // este metodo permite que el listener siga funcionando aun cuando el juego este en segundo plano
        Application.runInBackground = true;

        // cargo la configuracion del fichero de configuracion.
        if (testTexto.accessToken == null) { }
        testTexto.readConfig();

        if (debugprofile.estadodebug)
        {
            print("Test\nacountName: " + testTexto.accountName + "accessToken: " + testTexto.accessToken + "\nrefreshToken: " + testTexto.refreshToken + "\nchannelName: " + testTexto.channelName);
        }

        // creo el objeto de credenciales necesario la clase Twitchlib con los datos del bot_chat
        ConnectionCredentials credenciales = new ConnectionCredentials(testTexto.accountName, testTexto.accessToken);

        cliente = new Client();
        // inicializo el cliente con las credenciales y el nombre del canal
        cliente.Initialize(credenciales, testTexto.channelName);
        // conecto con el chat.
        cliente.Connect();
        // agrego una funcion para que se ejecute cuando reciba un mensaje, basicamente agrego un metodo a un listener.
        cliente.OnMessageReceived += MyMessageReceivedFunction;



    }


    void Update()
    {
        // codigo de prueba para probar la escritura de mensajes
        if (Input.GetKeyDown(KeyCode.P))
        {
            print("p pulsado");
            cliente.SendMessage(cliente.JoinedChannels[0], "mensaje de prueba bot Twitch");




        }
    }

    // metodo que se ejecuta cuando recibe un mensaje, proceso el mensaje
    // si es un comando, ejecuto la accion correspondiente

    // si no es un comando lo agrega al panel de chat del juego.
    private void MyMessageReceivedFunction(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
    {
        if (debugprofile.estadodebug || twitchdebut)
        {

            Debug.Log("El bot ha recibido un mensaje del chat");
        }
        print(sender.ToString() + "displayName=" + e.ChatMessage.DisplayName + "-id=" + e.ChatMessage.Id + "-username-" + e.ChatMessage.Username);
        print(sender.ToString() + " text=" + e.ChatMessage.Message + "   tipo de usuario = " + e.ChatMessage.UserType);
        print(sender.ToString() + " es Moderador?=" + e.ChatMessage.IsModerator);
        string textoaux = e.ChatMessage.Message;
        if (e.ChatMessage.IsModerator || e.ChatMessage.Username == "kazuokgi")
        {

            if (textoaux[0] == '!')
            {
                switch (textoaux)
                {
                    case "!big1":
                        {
                            player1.gameObject.transform.localScale = new Vector3(2, 2, 2); ;

                        }
                        break;
                    case "!big2":
                        {
                            player2.gameObject.transform.localScale = new Vector3(2, 2, 2); ;

                        }

                        break;
                    case "!little1":
                        {
                            player1.gameObject.transform.localScale = new Vector3(1, 1, 1); ;


                        }
                        break;
                    case "!little2":
                        {
                            player2.gameObject.transform.localScale = new Vector3(1, 1, 1); ;


                        }
                        break;



                }

            }
            else
            {
                panelTextoChat.text += "\n" + e.ChatMessage.Username + " : " + e.ChatMessage.Message;




            }

        }
    }






}

