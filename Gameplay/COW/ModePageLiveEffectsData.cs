using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20001A4")]
public class ModePageLiveEffectsData : CSVBaseData
{
	[Token(Token = "0x4000A37")]
	[FieldOffset(Offset = "0x8")]
	public uint LiveEffectsID;

	[Token(Token = "0x4000A38")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID VFXResourceID;

	[Token(Token = "0x4000A39")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 LocalPosition;

	[Token(Token = "0x4000A3A")]
	[FieldOffset(Offset = "0x0")]
	private static Func<string, float> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x6000919")]
	[Address(RVA = "0x22811E0", Offset = "0x22811E0", VA = "0x22811E0")]
	public ModePageLiveEffectsData()
	{
	}

	[Token(Token = "0x600091A")]
	[Address(RVA = "0x22812AC", Offset = "0x22812AC", VA = "0x22812AC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600091B")]
	[Address(RVA = "0x2281310", Offset = "0x2281310", VA = "0x2281310", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
