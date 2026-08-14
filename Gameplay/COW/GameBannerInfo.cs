using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002856")]
public class GameBannerInfo
{
	[Token(Token = "0x400F8D2")]
	[FieldOffset(Offset = "0x8")]
	public string BannerMainIcon;

	[Token(Token = "0x400F8D3")]
	[FieldOffset(Offset = "0xC")]
	public string Desc;

	[Token(Token = "0x400F8D4")]
	[FieldOffset(Offset = "0x10")]
	public float Duration;

	[Token(Token = "0x600FC47")]
	[Address(RVA = "0x1055B58", Offset = "0x1055B58", VA = "0x1055B58")]
	public GameBannerInfo(string MainIcon, string desc, float duration)
	{
	}
}
