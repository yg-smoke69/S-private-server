using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003E52")]
internal class AudioAsyncLoadData
{
	[Token(Token = "0x401A5A4")]
	[FieldOffset(Offset = "0x8")]
	public uint Ticket;

	[Token(Token = "0x401A5A5")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID Sound;

	[Token(Token = "0x401A5A6")]
	[FieldOffset(Offset = "0x10")]
	public Transform Parent;

	[Token(Token = "0x401A5A7")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 WorldPos;

	[Token(Token = "0x401A5A8")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID AudioSourceID;

	[Token(Token = "0x401A5A9")]
	[FieldOffset(Offset = "0x24")]
	public float Volume;

	[Token(Token = "0x401A5AA")]
	[FieldOffset(Offset = "0x28")]
	public float StartLoadTime;

	[Token(Token = "0x601951D")]
	[Address(RVA = "0x26B7198", Offset = "0x26B7198", VA = "0x26B7198")]
	public AudioAsyncLoadData()
	{
	}
}
