using UnityEngine;
using System.Collections;

public class ServerController : MonoBehaviour {
	
	public string ipToConnect;
	public int portToConnect;
	public int numberPlayers;
	

	// Use this for initialization
	void Start () {
		ipToConnect = Network.player.ipAddress;
	
	}
	
	// Update is called once per frame
	void Update () {
	
		
		
	}
	
	void StartServer(){
		if(Network.peerType == NetworkPeerType.Disconnected){
		Debug.Log(Network.InitializeServer(numberPlayers, portToConnect, false));
				
		}
	}
	void ConnectToServer(){
		if(Network.peerType == NetworkPeerType.Disconnected){
			Debug.Log(Network.Connect(ipToConnect, portToConnect));	
		}	
	}
	
	void OnGUI(){
		if(Network.peerType == NetworkPeerType.Disconnected){
			if(GUI.Button(new Rect(Screen.width/2-100,10,200,30), "Iniciar Servidor")){
				StartServer();	
			}
			ipToConnect = GUI.TextField(new Rect(Screen.width/2-100, 40, 200, 30), ipToConnect);
			if(GUI.Button(new Rect(Screen.width/2-100,70, 200, 30), "Conectar ao Servidor")){
				ConnectToServer();	
			}
		}
	}
}
