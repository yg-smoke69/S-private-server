using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000156")]
public class IceWallSkinData : CSVBaseData
{
	[Token(Token = "0x40008A0")]
	[FieldOffset(Offset = "0x8")]
	public uint skinid;

	[Token(Token = "0x40008A1")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID inGameRes;

	[Token(Token = "0x40008A2")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID previewgameRes;

	[Token(Token = "0x40008A3")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 HDLobbyPosition;

	[Token(Token = "0x40008A4")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 HDLobbyScale;

	[Token(Token = "0x40008A5")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 HDLobbyAngle;

	[Token(Token = "0x40008A6")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 HDLobbyPreviewPosition;

	[Token(Token = "0x40008A7")]
	[FieldOffset(Offset = "0x44")]
	public Vector3 HDLobbyPreviewScale;

	[Token(Token = "0x40008A8")]
	[FieldOffset(Offset = "0x50")]
	public Vector3 HDLobbyPreviewAngle;

	[Token(Token = "0x600080E")]
	[Address(RVA = "0x2C6F9A8", Offset = "0x2C6F9A8", VA = "0x2C6F9A8")]
	public IceWallSkinData()
	{
	}

	[Token(Token = "0x600080F")]
	[Address(RVA = "0x2C6FB58", Offset = "0x2C6FB58", VA = "0x2C6FB58", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0x2C6FBBC", Offset = "0x2C6FBBC", VA = "0x2C6FBBC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
