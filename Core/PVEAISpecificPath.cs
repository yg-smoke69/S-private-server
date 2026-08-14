using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200070D")]
public class PVEAISpecificPath : MonoBehaviour
{
	[Token(Token = "0x4004BF9")]
	[FieldOffset(Offset = "0xC")]
	public int PathGroupId;

	[Token(Token = "0x4004BFA")]
	[FieldOffset(Offset = "0x10")]
	public List<Transform> PathNaviSpots;

	[Token(Token = "0x6002CD2")]
	[Address(RVA = "0x1C77480", Offset = "0x1C77480", VA = "0x1C77480")]
	public PVEAISpecificPath()
	{
	}

	[Token(Token = "0x6002CD3")]
	[Address(RVA = "0x1C7750C", Offset = "0x1C7750C", VA = "0x1C7750C")]
	private void Awake()
	{
	}
}
