using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B34")]
internal class UISPHudInfoListController : UIBaseHudInfoListController
{
	[Token(Token = "0x4010935")]
	[FieldOffset(Offset = "0x64")]
	protected UISPHudInfoListView m_View;

	[Token(Token = "0x6011C8D")]
	[Address(RVA = "0x1D1EB28", Offset = "0x1D1EB28", VA = "0x1D1EB28")]
	public UISPHudInfoListController()
	{
	}

	[Token(Token = "0x6011C8E")]
	[Address(RVA = "0x1D1EB30", Offset = "0x1D1EB30", VA = "0x1D1EB30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C8F")]
	[Address(RVA = "0x1D1EBD8", Offset = "0x1D1EBD8", VA = "0x1D1EBD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C90")]
	[Address(RVA = "0x1D1EF94", Offset = "0x1D1EF94", VA = "0x1D1EF94")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
