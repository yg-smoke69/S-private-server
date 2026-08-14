using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AAD")]
public class FlashStorePeriodInfo
{
	[Token(Token = "0x400A7BD")]
	[FieldOffset(Offset = "0x8")]
	public uint period_group_id;

	[Token(Token = "0x400A7BE")]
	[FieldOffset(Offset = "0x10")]
	public long period_start_timestamp;

	[Token(Token = "0x400A7BF")]
	[FieldOffset(Offset = "0x18")]
	public long period_end_timestamp;

	[Token(Token = "0x400A7C0")]
	[FieldOffset(Offset = "0x20")]
	public uint period_flash_gem_number;

	[Token(Token = "0x600810A")]
	[Address(RVA = "0x30A0E68", Offset = "0x30A0E68", VA = "0x30A0E68")]
	public FlashStorePeriodInfo()
	{
	}
}
