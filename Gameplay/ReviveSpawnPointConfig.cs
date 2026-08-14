using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000715")]
public class ReviveSpawnPointConfig : MonoBehaviour
{
	[Token(Token = "0x4004C13")]
	[FieldOffset(Offset = "0xC")]
	public GameObject ColliderTemplate;

	[Token(Token = "0x4004C14")]
	[FieldOffset(Offset = "0x10")]
	public GameObject EventTriggerSpawnPointsObj;

	[Token(Token = "0x4004C15")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ZeppelinTriggerSpawnPointsObj;

	[Token(Token = "0x6002CEA")]
	[Address(RVA = "0x316C86C", Offset = "0x316C86C", VA = "0x316C86C")]
	public ReviveSpawnPointConfig()
	{
	}

	[Token(Token = "0x6002CEB")]
	[Address(RVA = "0x316C874", Offset = "0x316C874", VA = "0x316C874")]
	public List<Transform> GetEventTriggerPoints()
	{
		return null;
	}

	[Token(Token = "0x6002CEC")]
	[Address(RVA = "0x316CA04", Offset = "0x316CA04", VA = "0x316CA04")]
	public List<Transform> GetZeppelinTriggerPoint()
	{
		return null;
	}
}
