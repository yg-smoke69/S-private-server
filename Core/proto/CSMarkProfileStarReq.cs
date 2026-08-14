using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001696")]
public class CSMarkProfileStarReq
{
	[Token(Token = "0x4009680")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x4009681")]
	[FieldOffset(Offset = "0xC")]
	public bool mark;

	[Token(Token = "0x6007CF1")]
	[Address(RVA = "0x3097A58", Offset = "0x3097A58", VA = "0x3097A58")]
	public CSMarkProfileStarReq()
	{
	}
}
