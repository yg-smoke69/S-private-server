using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20029B6")]
internal class UIMatchResultZombieScreenshotSelfItemController : UIBaseController
{
	[Token(Token = "0x40100C4")]
	[FieldOffset(Offset = "0x28")]
	private UIMatchResultZombieScreenshotSelfItemView m_View;

	[Token(Token = "0x40100C5")]
	[FieldOffset(Offset = "0x2C")]
	private UIBaseProfileInfoController m_Profile;

	[Token(Token = "0x40100C6")]
	[FieldOffset(Offset = "0x30")]
	private UIBriefProfileInfoController m_BriefProfile;

	[Token(Token = "0x6010C31")]
	[Address(RVA = "0x268FA60", Offset = "0x268FA60", VA = "0x268FA60")]
	public UIMatchResultZombieScreenshotSelfItemController()
	{
	}

	[Token(Token = "0x6010C32")]
	[Address(RVA = "0x268FAE4", Offset = "0x268FAE4", VA = "0x268FAE4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010C33")]
	[Address(RVA = "0x268FB8C", Offset = "0x268FB8C", VA = "0x268FB8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010C34")]
	[Address(RVA = "0x268FDA0", Offset = "0x268FDA0", VA = "0x268FDA0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6010C35")]
	[Address(RVA = "0x268DF0C", Offset = "0x268DF0C", VA = "0x268DF0C")]
	public void SetData(UIMatchResultZombieScreenshotController.MatchResultScreenshotData data)
	{
	}

	[Token(Token = "0x6010C36")]
	[Address(RVA = "0x268FE04", Offset = "0x268FE04", VA = "0x268FE04")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010C37")]
	[Address(RVA = "0x268FE0C", Offset = "0x268FE0C", VA = "0x268FE0C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
