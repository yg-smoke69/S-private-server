using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A91")]
public class VideoAdPortalDesc
{
	[Token(Token = "0x400A65C")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400A65D")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x400A65E")]
	[FieldOffset(Offset = "0x10")]
	public string video_url;

	[Token(Token = "0x400A65F")]
	[FieldOffset(Offset = "0x14")]
	public string start_time;

	[Token(Token = "0x400A660")]
	[FieldOffset(Offset = "0x18")]
	public string end_time;

	[Token(Token = "0x400A661")]
	[FieldOffset(Offset = "0x20")]
	public long start_timestamp;

	[Token(Token = "0x400A662")]
	[FieldOffset(Offset = "0x28")]
	public long end_timestamp;

	[Token(Token = "0x60080EE")]
	[Address(RVA = "0x33E489C", Offset = "0x33E489C", VA = "0x33E489C")]
	public VideoAdPortalDesc()
	{
	}
}
