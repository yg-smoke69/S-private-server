using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000792")]
public class SpawnConfig : MonoBehaviour
{
	[Token(Token = "0x4004EA0")]
	[FieldOffset(Offset = "0xC")]
	public uint MeshTemplateID;

	[Token(Token = "0x4004EA1")]
	[FieldOffset(Offset = "0x10")]
	public uint TriggerTemplateID;

	[Token(Token = "0x4004EA2")]
	[FieldOffset(Offset = "0x14")]
	public List<uint> DisplayTemplateID;

	[Token(Token = "0x4004EA3")]
	[FieldOffset(Offset = "0x18")]
	public uint TriggerBuffID;

	[Token(Token = "0x600308B")]
	[Address(RVA = "0x21D75B0", Offset = "0x21D75B0", VA = "0x21D75B0")]
	public SpawnConfig()
	{
	}
}
