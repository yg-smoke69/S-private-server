using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2003262")]
internal class PlayerBestStatsData
{
	[Token(Token = "0x40132C0")]
	[FieldOffset(Offset = "0x8")]
	public HFMEHNDOKCA statsType;

	[Token(Token = "0x40132C1")]
	[FieldOffset(Offset = "0xC")]
	public float statsValue;

	[Token(Token = "0x40132C2")]
	[FieldOffset(Offset = "0x10")]
	public bool IsHighlight;

	[Token(Token = "0x60153D6")]
	[Address(RVA = "0x1C086A4", Offset = "0x1C086A4", VA = "0x1C086A4")]
	public PlayerBestStatsData()
	{
	}
}
