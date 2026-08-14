using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018E9")]
public class CSUnlockWorkshopSlotReq
{
	[Token(Token = "0x4009E30")]
	[FieldOffset(Offset = "0x8")]
	public EWorkshop.UnlockSlotCostType cost_type;

	[Token(Token = "0x4009E31")]
	[FieldOffset(Offset = "0xC")]
	public uint slot_id;

	[Token(Token = "0x6007F42")]
	[Address(RVA = "0x309A608", Offset = "0x309A608", VA = "0x309A608")]
	public CSUnlockWorkshopSlotReq()
	{
	}
}
