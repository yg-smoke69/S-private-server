using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200182A")]
public class CSTokenToAccelerateSupercarRes
{
	[Token(Token = "0x4009C38")]
	[FieldOffset(Offset = "0x8")]
	public uint drive_sum;

	[Token(Token = "0x4009C39")]
	[FieldOffset(Offset = "0xC")]
	public uint cur_exchange_tokens;

	[Token(Token = "0x4009C3A")]
	[FieldOffset(Offset = "0x10")]
	public long speed_change_time;

	[Token(Token = "0x6007E84")]
	[Address(RVA = "0x309A474", Offset = "0x309A474", VA = "0x309A474")]
	public CSTokenToAccelerateSupercarRes()
	{
	}
}
