using ClientSproto;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMap : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MapReady();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void MapReady()
    {
        NetSender.Send<ClientProtocol.mapready>(null, (_) =>
        {
            mapready.response rsp = _ as mapready.response;
            Debug.Log("进入地图结果：" + rsp.ok);
        });
    }
}