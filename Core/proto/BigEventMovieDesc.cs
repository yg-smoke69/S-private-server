using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B38")]
public class BigEventMovieDesc
{
	[Token(Token = "0x400AB2D")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AB2E")]
	[FieldOffset(Offset = "0xC")]
	public ELimitedEvent.EventID event_id;

	[Token(Token = "0x400AB2F")]
	[FieldOffset(Offset = "0x10")]
	public string movie_url;

	[Token(Token = "0x400AB30")]
	[FieldOffset(Offset = "0x14")]
	public string frame_image_cdn;

	[Token(Token = "0x6008193")]
	[Address(RVA = "0x317C0F8", Offset = "0x317C0F8", VA = "0x317C0F8")]
	public BigEventMovieDesc()
	{
	}
}
