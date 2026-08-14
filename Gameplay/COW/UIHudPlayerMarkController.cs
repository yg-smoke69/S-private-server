using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002802")]
internal class UIHudPlayerMarkController : UIBaseController
{
	[Token(Token = "0x400F6E9")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPlayerMarkView m_View;

	[Token(Token = "0x600F8B8")]
	[Address(RVA = "0x18667CC", Offset = "0x18667CC", VA = "0x18667CC")]
	public UIHudPlayerMarkController()
	{
	}

	[Token(Token = "0x600F8B9")]
	[Address(RVA = "0x1866850", Offset = "0x1866850", VA = "0x1866850")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F8BA")]
	[Address(RVA = "0x18668F4", Offset = "0x18668F4", VA = "0x18668F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F8BB")]
	[Address(RVA = "0x1866A08", Offset = "0x1866A08", VA = "0x1866A08", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F8BC")]
	[Address(RVA = "0x1866A6C", Offset = "0x1866A6C", VA = "0x1866A6C")]
	public void SetInfo(int playerTeamIndex, uint posType)
	{
	}

	[Token(Token = "0x600F8BD")]
	[Address(RVA = "0x1866CA0", Offset = "0x1866CA0", VA = "0x1866CA0")]
	public void SetScale(float scale)
	{
	}

	[Token(Token = "0x600F8BE")]
	[Address(RVA = "0x1866CFC", Offset = "0x1866CFC", VA = "0x1866CFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F8BF")]
	[Address(RVA = "0x1866D04", Offset = "0x1866D04", VA = "0x1866D04")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
