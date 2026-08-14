using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001825")]
public class CSHelpToAccelerateSupercarReq
{
	[Token(Token = "0x4009C29")]
	[FieldOffset(Offset = "0x8")]
	public uint car_id;

	[Token(Token = "0x4009C2A")]
	[FieldOffset(Offset = "0xC")]
	public string helper_name;

	[Token(Token = "0x4009C2B")]
	[FieldOffset(Offset = "0x10")]
	public ulong helpee_id;

	[Token(Token = "0x6007E7F")]
	[Address(RVA = "0x3097100", Offset = "0x3097100", VA = "0x3097100")]
	public CSHelpToAccelerateSupercarReq()
	{
	}
}
