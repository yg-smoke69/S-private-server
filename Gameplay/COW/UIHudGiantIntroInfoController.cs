using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002766")]
public class UIHudGiantIntroInfoController : UIBaseController
{
	[Token(Token = "0x400F32C")]
	[FieldOffset(Offset = "0x28")]
	private UIHudGiantIntroInfoView m_View;

	[Token(Token = "0x400F32D")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallId;

	[Token(Token = "0x600F0D6")]
	[Address(RVA = "0x18940BC", Offset = "0x18940BC", VA = "0x18940BC")]
	public UIHudGiantIntroInfoController()
	{
	}

	[Token(Token = "0x600F0D7")]
	[Address(RVA = "0x1894140", Offset = "0x1894140", VA = "0x1894140")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F0D8")]
	[Address(RVA = "0x18941E8", Offset = "0x18941E8", VA = "0x18941E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F0D9")]
	[Address(RVA = "0x1894384", Offset = "0x1894384", VA = "0x1894384", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F0DA")]
	[Address(RVA = "0x18944A0", Offset = "0x18944A0", VA = "0x18944A0")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600F0DB")]
	[Address(RVA = "0x18945F4", Offset = "0x18945F4", VA = "0x18945F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F0DC")]
	[Address(RVA = "0x18945FC", Offset = "0x18945FC", VA = "0x18945FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
