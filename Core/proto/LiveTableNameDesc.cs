using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AEF")]
public class LiveTableNameDesc
{
	[Token(Token = "0x400A94F")]
	[FieldOffset(Offset = "0x8")]
	public ELive.VideoType id;

	[Token(Token = "0x400A950")]
	[FieldOffset(Offset = "0xC")]
	public string content;

	[Token(Token = "0x400A951")]
	[FieldOffset(Offset = "0x10")]
	public string language;

	[Token(Token = "0x600814A")]
	[Address(RVA = "0x30A665C", Offset = "0x30A665C", VA = "0x30A665C")]
	public LiveTableNameDesc()
	{
	}
}
