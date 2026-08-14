using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019C0")]
public class ClothesSlotDesc
{
	[Token(Token = "0x400A15F")]
	[FieldOffset(Offset = "0x8")]
	public uint clothes_slot;

	[Token(Token = "0x400A160")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.FittingSlotCdtType cdt_type;

	[Token(Token = "0x400A161")]
	[FieldOffset(Offset = "0x10")]
	public uint cdt_value;

	[Token(Token = "0x400A162")]
	[FieldOffset(Offset = "0x14")]
	public uint max_slots;

	[Token(Token = "0x6008018")]
	[Address(RVA = "0x309CBC0", Offset = "0x309CBC0", VA = "0x309CBC0")]
	public ClothesSlotDesc()
	{
	}
}
