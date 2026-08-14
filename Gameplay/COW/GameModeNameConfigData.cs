using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001A2")]
public class GameModeNameConfigData : CSVBaseData
{
	[Token(Token = "0x4000A32")]
	[FieldOffset(Offset = "0x8")]
	public uint ModeID;

	[Token(Token = "0x4000A33")]
	[FieldOffset(Offset = "0xC")]
	public string ModeName;

	[Token(Token = "0x4000A34")]
	[FieldOffset(Offset = "0x10")]
	public string ModeSelectIcon;

	[Token(Token = "0x6000913")]
	[Address(RVA = "0x1DD6124", Offset = "0x1DD6124", VA = "0x1DD6124")]
	public GameModeNameConfigData()
	{
	}

	[Token(Token = "0x6000914")]
	[Address(RVA = "0x1DD61A8", Offset = "0x1DD61A8", VA = "0x1DD61A8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000915")]
	[Address(RVA = "0x1DD620C", Offset = "0x1DD620C", VA = "0x1DD620C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
