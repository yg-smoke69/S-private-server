using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002890")]
internal class UIHudTutorialMainTaskGuideController : UIBaseController
{
	[Token(Token = "0x400F9BE")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTutorialMainTaskGuideView m_View;

	[Token(Token = "0x400F9BF")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_delayCallID;

	[Token(Token = "0x600FEA0")]
	[Address(RVA = "0x1590E64", Offset = "0x1590E64", VA = "0x1590E64")]
	public UIHudTutorialMainTaskGuideController()
	{
	}

	[Token(Token = "0x600FEA1")]
	[Address(RVA = "0x1590EE8", Offset = "0x1590EE8", VA = "0x1590EE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FEA2")]
	[Address(RVA = "0x1590F90", Offset = "0x1590F90", VA = "0x1590F90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FEA3")]
	[Address(RVA = "0x159104C", Offset = "0x159104C", VA = "0x159104C")]
	public void SetContent(string content)
	{
	}

	[Token(Token = "0x600FEA4")]
	[Address(RVA = "0x15911A8", Offset = "0x15911A8", VA = "0x15911A8")]
	public void DelayHide(float f = 3f)
	{
	}

	[Token(Token = "0x600FEA5")]
	[Address(RVA = "0x1591370", Offset = "0x1591370", VA = "0x1591370")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
