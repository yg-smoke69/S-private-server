using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018EA")]
public class CSUnlockWorkshopSlotRes
{
	[Token(Token = "0x4009E32")]
	[FieldOffset(Offset = "0x8")]
	public uint share_slot_id;

	[Token(Token = "0x4009E33")]
	[FieldOffset(Offset = "0xC")]
	public EWorkshop.SlotState share_slot_state;

	[Token(Token = "0x6007F43")]
	[Address(RVA = "0x309A610", Offset = "0x309A610", VA = "0x309A610")]
	public CSUnlockWorkshopSlotRes()
	{
	}
}
