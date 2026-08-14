using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000203")]
public class PlayerSocialTagsInfoData : CSVBaseData
{
	[Token(Token = "0x4000BF7")]
	[FieldOffset(Offset = "0x8")]
	public uint SocialTagID;

	[Token(Token = "0x4000BF8")]
	[FieldOffset(Offset = "0xC")]
	public uint TagPriority;

	[Token(Token = "0x4000BF9")]
	[FieldOffset(Offset = "0x10")]
	public string TagNameKey;

	[Token(Token = "0x4000BFA")]
	[FieldOffset(Offset = "0x14")]
	public string TagDescriptionKey;

	[Token(Token = "0x6000A6A")]
	[Address(RVA = "0x1C0C110", Offset = "0x1C0C110", VA = "0x1C0C110")]
	public PlayerSocialTagsInfoData()
	{
	}

	[Token(Token = "0x6000A6B")]
	[Address(RVA = "0x1C0C194", Offset = "0x1C0C194", VA = "0x1C0C194", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A6C")]
	[Address(RVA = "0x1C0C1F8", Offset = "0x1C0C1F8", VA = "0x1C0C1F8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
