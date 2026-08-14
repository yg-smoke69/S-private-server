using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200172B")]
public class CSSendGiftRes
{
	[Token(Token = "0x4009970")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] remove_ids;

	[Token(Token = "0x4009971")]
	[FieldOffset(Offset = "0xC")]
	public uint send_gift_times_today;

	[Token(Token = "0x6007D85")]
	[Address(RVA = "0x3099824", Offset = "0x3099824", VA = "0x3099824")]
	public CSSendGiftRes()
	{
	}
}
