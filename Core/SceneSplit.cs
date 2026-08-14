using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x2003D1C")]
public class SceneSplit
{
	[Token(Token = "0x4019ED5")]
	[FieldOffset(Offset = "0x8")]
	public int posX;

	[Token(Token = "0x4019ED6")]
	[FieldOffset(Offset = "0xC")]
	public int posY;

	[Token(Token = "0x4019ED7")]
	[FieldOffset(Offset = "0x10")]
	public int posZ;

	[Token(Token = "0x4019ED8")]
	[FieldOffset(Offset = "0x14")]
	public string sceneName;

	[Token(Token = "0x4019ED9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject sceneGo;

	[Token(Token = "0x4019EDA")]
	[FieldOffset(Offset = "0x1C")]
	public bool loaded;

	[Token(Token = "0x4019EDB")]
	[FieldOffset(Offset = "0x20")]
	public float posXLimitMove;

	[Token(Token = "0x4019EDC")]
	[FieldOffset(Offset = "0x24")]
	public int xDeloadLimit;

	[Token(Token = "0x4019EDD")]
	[FieldOffset(Offset = "0x28")]
	public float posYLimitMove;

	[Token(Token = "0x4019EDE")]
	[FieldOffset(Offset = "0x2C")]
	public int yDeloadLimit;

	[Token(Token = "0x4019EDF")]
	[FieldOffset(Offset = "0x30")]
	public float posZLimitMove;

	[Token(Token = "0x4019EE0")]
	[FieldOffset(Offset = "0x34")]
	public int zDeloadLimit;

	[Token(Token = "0x4019EE1")]
	[FieldOffset(Offset = "0x38")]
	public int sceneNameID;

	[Token(Token = "0x4019EE2")]
	[FieldOffset(Offset = "0x3C")]
	public int sceneBuildID;

	[Token(Token = "0x4019EE3")]
	[FieldOffset(Offset = "0x40")]
	public StreamerSceneCollectionInfo sceneStreamerInfo;

	[Token(Token = "0x601876D")]
	[Address(RVA = "0x21C3C34", Offset = "0x21C3C34", VA = "0x21C3C34")]
	public SceneSplit()
	{
	}
}
