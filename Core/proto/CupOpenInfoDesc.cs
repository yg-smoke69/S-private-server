using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA8")]
public class CupOpenInfoDesc
{
	[Token(Token = "0x400ADF5")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400ADF6")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x400ADF7")]
	[FieldOffset(Offset = "0x10")]
	public long entrance_open_time;

	[Token(Token = "0x400ADF8")]
	[FieldOffset(Offset = "0x18")]
	public long entrance_end_time;

	[Token(Token = "0x400ADF9")]
	[FieldOffset(Offset = "0x20")]
	public long season_start_time;

	[Token(Token = "0x400ADFA")]
	[FieldOffset(Offset = "0x28")]
	public long season_end_time;

	[Token(Token = "0x400ADFB")]
	[FieldOffset(Offset = "0x30")]
	public long match_start_time;

	[Token(Token = "0x400ADFC")]
	[FieldOffset(Offset = "0x38")]
	public long match_end_time;

	[Token(Token = "0x6008203")]
	[Address(RVA = "0x309DDD4", Offset = "0x309DDD4", VA = "0x309DDD4")]
	public CupOpenInfoDesc()
	{
	}
}
