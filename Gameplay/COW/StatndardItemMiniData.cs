using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023BD")]
public class StatndardItemMiniData
{
	[Token(Token = "0x400DE66")]
	[FieldOffset(Offset = "0x8")]
	public bool showLimitedTitle;

	[Token(Token = "0x400DE67")]
	[FieldOffset(Offset = "0x9")]
	public bool showClaim;

	[Token(Token = "0x400DE68")]
	[FieldOffset(Offset = "0xA")]
	public bool showGreyBG;

	[Token(Token = "0x400DE69")]
	[FieldOffset(Offset = "0xB")]
	public bool showHighLight;

	[Token(Token = "0x400DE6A")]
	[FieldOffset(Offset = "0xC")]
	public bool showGotReward;

	[Token(Token = "0x400DE6B")]
	[FieldOffset(Offset = "0xD")]
	public bool showOwned;

	[Token(Token = "0x400DE6C")]
	[FieldOffset(Offset = "0xE")]
	public bool showDownloadInfo;

	[Token(Token = "0x400DE6D")]
	[FieldOffset(Offset = "0x10")]
	public BaseItemInfo baseItemInfo;

	[Token(Token = "0x600C941")]
	[Address(RVA = "0x288E7EC", Offset = "0x288E7EC", VA = "0x288E7EC")]
	public StatndardItemMiniData()
	{
	}
}
