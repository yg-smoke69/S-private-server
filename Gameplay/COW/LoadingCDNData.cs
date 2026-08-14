using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002DF5")]
public class LoadingCDNData : CSVBaseData
{
	[Token(Token = "0x40119ED")]
	[FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x40119EE")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x40119EF")]
	[FieldOffset(Offset = "0x10")]
	public int playerType;

	[Token(Token = "0x40119F0")]
	[FieldOffset(Offset = "0x14")]
	public string[] urls;

	[Token(Token = "0x40119F1")]
	[FieldOffset(Offset = "0x18")]
	public int levelMin;

	[Token(Token = "0x40119F2")]
	[FieldOffset(Offset = "0x1C")]
	public int levelMax;

	[Token(Token = "0x601342E")]
	[Address(RVA = "0xEC924C", Offset = "0xEC924C", VA = "0xEC924C")]
	public LoadingCDNData()
	{
	}

	[Token(Token = "0x601342F")]
	[Address(RVA = "0xEC92D0", Offset = "0xEC92D0", VA = "0xEC92D0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6013430")]
	[Address(RVA = "0xEC9334", Offset = "0xEC9334", VA = "0xEC9334", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
