using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002116")]
public class UIHudModeIntroInfoController : UIBaseController
{
	[Token(Token = "0x400CF57")]
	[FieldOffset(Offset = "0x28")]
	private uint m_DelayCallId;

	[Token(Token = "0x600AD20")]
	[Address(RVA = "0x1F47844", Offset = "0x1F47844", VA = "0x1F47844")]
	public UIHudModeIntroInfoController()
	{
	}

	[Token(Token = "0x600AD21")]
	[Address(RVA = "0x1F478C8", Offset = "0x1F478C8", VA = "0x1F478C8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AD22")]
	[Address(RVA = "0x1F47E20", Offset = "0x1F47E20", VA = "0x1F47E20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AD23")]
	[Address(RVA = "0x1F47FA0", Offset = "0x1F47FA0", VA = "0x1F47FA0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600AD24")]
	[Address(RVA = "0x1F480BC", Offset = "0x1F480BC", VA = "0x1F480BC")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600AD25")]
	[Address(RVA = "0x1F48194", Offset = "0x1F48194", VA = "0x1F48194")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AD26")]
	[Address(RVA = "0x1F4819C", Offset = "0x1F4819C", VA = "0x1F4819C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
