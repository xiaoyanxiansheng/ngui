using UnityEngine;
using System.Collections;

public class TestUIScprit : MonoBehaviour
{

    private UISprite sprite;

    private GameObject spriteObj;

    public GameObject atlasObj;

	// Use this for initialization
	void Start () {

        spriteObj = GameObject.Find("sctipte");
        sprite = spriteObj.AddComponent<UISprite>();
        sprite.atlas = atlasObj.GetComponent<UIAtlas>();
        sprite.spriteName = "NGUI";
        sprite.width = 256;
        sprite.height = 76;

        UIDrawCallTest drawCall = spriteObj.AddComponent<UIDrawCallTest>();
        sprite.OnFill(drawCall.verts,drawCall.uvs,drawCall.cols);

        drawCall.UpdateGeometry(0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
