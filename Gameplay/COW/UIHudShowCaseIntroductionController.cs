using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002844")]
internal class UIHudShowCaseIntroductionController : UIBaseController
{
	[Token(Token = "0x400F870")]
	[FieldOffset(Offset = "0x28")]
	private UIHudShowCaseIntroductionView m_View;

	[Token(Token = "0x600FB6E")]
	[Address(RVA = "0x16B90F8", Offset = "0x16B90F8", VA = "0x16B90F8")]
	public UIHudShowCaseIntroductionController()
	{
	}

	[Token(Token = "0x600FB6F")]
	[Address(RVA = "0x16B917C", Offset = "0x16B917C", VA = "0x16B917C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FB70")]
	[Address(RVA = "0x16B9220", Offset = "0x16B9220", VA = "0x16B9220", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FB71")]
	[Address(RVA = "0x16B937C", Offset = "0x16B937C", VA = "0x16B937C")]
	private void OnBtnClose()
	{
	}

	[Token(Token = "0x600FB72")]
	[Address(RVA = "0x16B93E8", Offset = "0x16B93E8", VA = "0x16B93E8")]
	public void UpdateContent(string title, string content)
	{
	}

	[Token(Token = "0x600FB73")]
	[Address(RVA = "0x16B94D0", Offset = "0x16B94D0", VA = "0x16B94D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
