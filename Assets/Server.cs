using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using System;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
public class Server : MonoBehaviour {
	
	float x ;
	float y ;
	float z ;
	string jsonString = "";
	StreamWriter streamWriter;
    StreamReader streamReader;
    NetworkStream networkStream;
	TcpListener tcpListener;
	Socket serverSocket;
	
	void Start () {
	}
	
	void Update () {
		tcpListener = new TcpListener(5555);
		tcpListener.Start();
		serverSocket = tcpListener.AcceptSocket();
		try
        {
            if (serverSocket.Connected)
            {
				Debug.Log("Connect");

                while (true)
                {
                    networkStream = new NetworkStream(serverSocket);
                    streamWriter = new StreamWriter(networkStream);
                    streamReader = new StreamReader(networkStream);
                    //MemoryStream stream1 = new MemoryStream();
					//DeSerealizaton();
					//MyNameSpace.Player Player = new MyNameSpace.Player {X = GameObject.Find("Player").transform.position.x,Y = GameObject.Find("Player").transform.position.y, Z = GameObject.Find("Player").transform.position.z};
					//MyNameSpace.SomeContainer someContainer = new MyNameSpace.SomeContainer {Player = Player};
					//MyNameSpace.SomeContainer desSomeObject = JsonConvert.DeserializeObject<MyNameSpace.SomeContainer>(jsonString);
					jsonString = streamReader.ReadLine();
					Debug.Log(jsonString);
					MyNameSpace.Player Player = new MyNameSpace.Player {X = GameObject.Find("Player").transform.position.x,Y = GameObject.Find("Player").transform.position.y, Z = GameObject.Find("Player").transform.position.z};
					MyNameSpace.SomeContainer someContainer = new MyNameSpace.SomeContainer {Player = Player};
					MyNameSpace.SomeContainer desSomeObject = JsonConvert.DeserializeObject<MyNameSpace.SomeContainer>(jsonString);
                    //stream1.Position = 0;
					x = desSomeObject.Player.X;
					y = desSomeObject.Player.Y;
					z = desSomeObject.Player.Z;
					GameObject.Find("Player").transform.position = new Vector3(x,y,z);
             	}
				
            }
			if (serverSocket.Connected)
			{
				serverSocket.Close();
			}
        }

        catch (SocketException ex)
        {

            Debug.Log(ex);
        }
	}
}
