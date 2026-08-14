using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001F7")]
public class PetOpenTimeData : CSVBaseData
{
	[Token(Token = "0x4000BBB")]
	[FieldOffset(Offset = "0x8")]
	public DateTime OpenTime;

	[Token(Token = "0x4000BBC")]
	[FieldOffset(Offset = "0x18")]
	public string Region;

	[Token(Token = "0x4000BBD")]
	[FieldOffset(Offset = "0x1C")]
	public uint PetID;

	[Token(Token = "0x6000A2D")]
	[Address(RVA = "0x1BFDBF8", Offset = "0x1BFDBF8", VA = "0x1BFDBF8")]
	public PetOpenTimeData()
	{
	}

	[Token(Token = "0x6000A2E")]
	[Address(RVA = "0x1BFDC7C", Offset = "0x1BFDC7C", VA = "0x1BFDC7C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A2F")]
	[Address(RVA = "0x1BFA17C", Offset = "0x1BFA17C", VA = "0x1BFA17C")]
	public static string GenerateKey(uint petID, string region)
	{
		return null;
	}

	[Token(Token = "0x6000A30")]
	[Address(RVA = "0x1BFDD70", Offset = "0x1BFDD70", VA = "0x1BFDD70", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
