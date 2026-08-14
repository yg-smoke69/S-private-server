using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC8")]
public class BISVideoDesc
{
	[Token(Token = "0x400AED5")]
	[FieldOffset(Offset = "0x8")]
	public string BIS_video;

	[Token(Token = "0x400AED6")]
	[FieldOffset(Offset = "0xC")]
	public uint BIS_video_start_time;

	[Token(Token = "0x400AED7")]
	[FieldOffset(Offset = "0x10")]
	public uint BIS_video_end_time;

	[Token(Token = "0x6008223")]
	[Address(RVA = "0x317B5C4", Offset = "0x317B5C4", VA = "0x317B5C4")]
	public BISVideoDesc()
	{
	}
}
