using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000200")]
public class PlayerSocialTagsData : CSVBaseData
{
	[Token(Token = "0x4000BF2")]
	[FieldOffset(Offset = "0x8")]
	public string m_ShowKey;

	[Token(Token = "0x4000BF3")]
	[FieldOffset(Offset = "0xC")]
	public uint typeid;

	[Token(Token = "0x4000BF4")]
	[FieldOffset(Offset = "0x10")]
	public uint sortid;

	[Token(Token = "0x6000A60")]
	[Address(RVA = "0x1C0B740", Offset = "0x1C0B740", VA = "0x1C0B740")]
	public PlayerSocialTagsData()
	{
	}

	[Token(Token = "0x6000A61")]
	[Address(RVA = "0x1C0B7C4", Offset = "0x1C0B7C4", VA = "0x1C0B7C4", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A62")]
	[Address(RVA = "0x1C0B81C", Offset = "0x1C0B81C", VA = "0x1C0B81C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
