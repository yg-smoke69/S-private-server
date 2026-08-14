using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014FC")]
public class RandomSlotInfo
{
	[Token(Token = "0x4009074")]
	[FieldOffset(Offset = "0x8")]
	public uint slot;

	[Token(Token = "0x4009075")]
	[FieldOffset(Offset = "0xC")]
	public uint[] skin_ids;

	[Token(Token = "0x4009076")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.SlotChooseType choose_type;

	[Token(Token = "0x6007B46")]
	[Address(RVA = "0x33E0720", Offset = "0x33E0720", VA = "0x33E0720")]
	public RandomSlotInfo()
	{
	}
}
