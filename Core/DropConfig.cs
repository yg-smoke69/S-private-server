using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000786")]
public class DropConfig : MonoBehaviour
{
	[Token(Token = "0x4004E61")]
	[FieldOffset(Offset = "0xC")]
	public uint MeshTemplateID;

	[Token(Token = "0x4004E62")]
	[FieldOffset(Offset = "0x10")]
	public uint TriggerTemplateID;

	[Token(Token = "0x4004E63")]
	[FieldOffset(Offset = "0x14")]
	public uint DisplayTemplateID;

	[Token(Token = "0x4004E64")]
	[FieldOffset(Offset = "0x18")]
	public uint BatchID;

	[Token(Token = "0x600305C")]
	[Address(RVA = "0x2324854", Offset = "0x2324854", VA = "0x2324854")]
	public DropConfig()
	{
	}
}
