using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200027B")]
internal class WorkshopMusicKeyConfigData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000F19")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000F1A")]
	[FieldOffset(Offset = "0xC")]
	public string ResIDStr;

	[Token(Token = "0x6000C22")]
	[Address(RVA = "0x2303D38", Offset = "0x2303D38", VA = "0x2303D38")]
	public WorkshopMusicKeyConfigData()
	{
	}

	[Token(Token = "0x6000C23")]
	[Address(RVA = "0x2303DBC", Offset = "0x2303DBC", VA = "0x2303DBC", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000C24")]
	[Address(RVA = "0x2303E14", Offset = "0x2303E14", VA = "0x2303E14", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000C25")]
	[Address(RVA = "0x2303E78", Offset = "0x2303E78", VA = "0x2303E78", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
