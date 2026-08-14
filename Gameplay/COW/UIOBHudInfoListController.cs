using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A09")]
internal class UIOBHudInfoListController : UIBaseHudInfoListController
{
	[Token(Token = "0x40102AD")]
	[FieldOffset(Offset = "0x64")]
	private UIOBHudInfoListView m_View;

	[Token(Token = "0x6010FDD")]
	[Address(RVA = "0x26E35D8", Offset = "0x26E35D8", VA = "0x26E35D8")]
	public UIOBHudInfoListController()
	{
	}

	[Token(Token = "0x6010FDE")]
	[Address(RVA = "0x26E35E0", Offset = "0x26E35E0", VA = "0x26E35E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010FDF")]
	[Address(RVA = "0x26E3688", Offset = "0x26E3688", VA = "0x26E3688", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010FE0")]
	[Address(RVA = "0x26E3B1C", Offset = "0x26E3B1C", VA = "0x26E3B1C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
