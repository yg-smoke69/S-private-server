using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A0")]
public class UIAutoPickupItemPriorityViewData
{
	[Token(Token = "0x400E2FA")]
	[FieldOffset(Offset = "0x8")]
	public int Hierarchy;

	[Token(Token = "0x400E2FB")]
	[FieldOffset(Offset = "0xC")]
	public AutoPickupConfigData PickupItemConfigData;

	[Token(Token = "0x600D17A")]
	[Address(RVA = "0x1E75300", Offset = "0x1E75300", VA = "0x1E75300")]
	public UIAutoPickupItemPriorityViewData()
	{
	}
}
