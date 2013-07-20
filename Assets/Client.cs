using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;
using System;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.IO;
public class Client : MonoBehaviour{
	/*MyGameObject myGameObjcet = new MyGameObject {X = "512", Y = "315", Z = "561"};
	MySomeContainer mySomeContainer = new MySomeContainer {myGameObject = myGameObjcet};
	string jsonString = JsonConvert.SerializeObject(mySomeContainer);
	MySomeContainer desSomeObject = JsonConvert.DeserializeObject<MySomeContainer>(jsonString);
	*/
	string jsonString = "";
	
	TcpClient tcpClient;
	NetworkStream networkStream;
	StreamReader streamReader;
	StreamWriter streamWriter;
	string Serealization ()
	{
		MyNameSpace.Player Player = new MyNameSpace.Player {X = GameObject.Find("Player").transform.position.x,Y = GameObject.Find("Player").transform.position.y, Z = GameObject.Find("Player").transform.position.z};
		MyNameSpace.SomeContainer someContainer = new MyNameSpace.SomeContainer {Player = Player};
		jsonString = JsonConvert.SerializeObject(someContainer);
		return jsonString;
	}
	void Start () {
	}
	void Update () {
		Debug.Log(jsonString);
		try
		{
			tcpClient = new TcpClient("localhost", 5555);
			networkStream = tcpClient.GetStream();
            streamReader = new StreamReader(networkStream);
            streamWriter = new StreamWriter(networkStream);
			jsonString = Serealization();
            streamWriter.WriteLine(jsonString);
            streamWriter.Flush();
		}
		catch (SocketException ex)
		{
			Debug.Log(ex);
		}
	}
	
}
