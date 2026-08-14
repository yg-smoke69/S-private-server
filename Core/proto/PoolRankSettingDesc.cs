using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA3")]
public class PoolRankSettingDesc
{
	[Token(Token = "0x400ADDA")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ADDB")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400ADDC")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400ADDD")]
	[FieldOffset(Offset = "0x20")]
	public uint refresh_time;

	[Token(Token = "0x60081FE")]
	[Address(RVA = "0x33E0094", Offset = "0x33E0094", VA = "0x33E0094")]
	public PoolRankSettingDesc()
	{
	}
}
