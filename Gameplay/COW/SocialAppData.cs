using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000237")]
public class SocialAppData : CSVBaseData
{
	[Token(Token = "0x4000D87")]
	[FieldOffset(Offset = "0x8")]
	public string RegionName;

	[Token(Token = "0x4000D88")]
	[FieldOffset(Offset = "0xC")]
	public bool FacebookShareMatchResult;

	[Token(Token = "0x4000D89")]
	[FieldOffset(Offset = "0xD")]
	public bool FacebookInviteFriend;

	[Token(Token = "0x4000D8A")]
	[FieldOffset(Offset = "0xE")]
	public bool FacebookGroupInvite;

	[Token(Token = "0x4000D8B")]
	[FieldOffset(Offset = "0xF")]
	public bool LineShareMatchResult;

	[Token(Token = "0x4000D8C")]
	[FieldOffset(Offset = "0x10")]
	public bool LineInviteFriend;

	[Token(Token = "0x4000D8D")]
	[FieldOffset(Offset = "0x11")]
	public bool LineGroupInvite;

	[Token(Token = "0x6000B3F")]
	[Address(RVA = "0x20F3248", Offset = "0x20F3248", VA = "0x20F3248")]
	public SocialAppData()
	{
	}

	[Token(Token = "0x6000B40")]
	[Address(RVA = "0x20F32CC", Offset = "0x20F32CC", VA = "0x20F32CC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B41")]
	[Address(RVA = "0x20F3324", Offset = "0x20F3324", VA = "0x20F3324", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
