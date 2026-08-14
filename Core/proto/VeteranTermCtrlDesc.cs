using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A16")]
public class VeteranTermCtrlDesc
{
	[Token(Token = "0x400A398")]
	[FieldOffset(Offset = "0x8")]
	public uint term_id;

	[Token(Token = "0x400A399")]
	[FieldOffset(Offset = "0x10")]
	public long start_timestamp;

	[Token(Token = "0x400A39A")]
	[FieldOffset(Offset = "0x18")]
	public long end_timestamp;

	[Token(Token = "0x600806E")]
	[Address(RVA = "0x33E4894", Offset = "0x33E4894", VA = "0x33E4894")]
	public VeteranTermCtrlDesc()
	{
	}
}
