using COW;
using GCommon;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A62")]
public class LinkExchangeDesc
{
	[Token(Token = "0x400A52A")]
	[FieldOffset(Offset = "0x8")]
	public uint daily_frequency;

	[Token(Token = "0x400A52B")]
	[FieldOffset(Offset = "0xC")]
	public uint coin_type;

	[Token(Token = "0x400A52C")]
	[FieldOffset(Offset = "0x10")]
	public uint num;

	[Token(Token = "0x400A52D")]
	[FieldOffset(Offset = "0x14")]
	public uint award_num;

	[Token(Token = "0x170009E5")]
	public AvatarLinkExchangeCoinType CoinType
	{
		[Token(Token = "0x60080BB")]
		[Address(RVA = "0x30A4D24", Offset = "0x30A4D24", VA = "0x30A4D24")]
		get
		{
			return default(AvatarLinkExchangeCoinType);
		}
	}

	[Token(Token = "0x60080BA")]
	[Address(RVA = "0x30A4D1C", Offset = "0x30A4D1C", VA = "0x30A4D1C")]
	public LinkExchangeDesc()
	{
	}

	[Token(Token = "0x60080BC")]
	[Address(RVA = "0x30A4D2C", Offset = "0x30A4D2C", VA = "0x30A4D2C")]
	public ResourceID GetCostItemIconResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60080BD")]
	[Address(RVA = "0x30A4EE4", Offset = "0x30A4EE4", VA = "0x30A4EE4")]
	public bool IsRequirementMet()
	{
		return default(bool);
	}

	[Token(Token = "0x60080BE")]
	[Address(RVA = "0x30A5028", Offset = "0x30A5028", VA = "0x30A5028")]
	public string GetErrorTipsOnRequirement()
	{
		return null;
	}

	[Token(Token = "0x60080BF")]
	[Address(RVA = "0x30A519C", Offset = "0x30A519C", VA = "0x30A519C")]
	public ResourceID GetAwardItemIconResourceID()
	{
		return default(ResourceID);
	}
}
