using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000EA")]
public class VehicleSkinData : CSVBaseData
{
	[Token(Token = "0x40005CC")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0xC")]
	public string PropertyDescription;

	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x10")]
	public uint iID;

	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x14")]
	public uint VehicleID;

	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x18")]
	public uint sortId;

	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x1C")]
	public uint basedConfigID;

	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID previewRes;

	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID inGameRes;

	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID inGameWithEffectRes;

	[Token(Token = "0x40005D5")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID previewAnim;

	[Token(Token = "0x40005D6")]
	[FieldOffset(Offset = "0x30")]
	public bool IsWithEffect;

	[Token(Token = "0x40005D7")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map0;

	[Token(Token = "0x6000604")]
	[Address(RVA = "0x219CE1C", Offset = "0x219CE1C", VA = "0x219CE1C")]
	public VehicleSkinData()
	{
	}

	[Token(Token = "0x6000605")]
	[Address(RVA = "0x219CF54", Offset = "0x219CF54", VA = "0x219CF54", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000606")]
	[Address(RVA = "0x219CFB8", Offset = "0x219CFB8", VA = "0x219CFB8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
