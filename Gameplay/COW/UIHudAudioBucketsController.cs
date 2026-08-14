using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026DB")]
public class UIHudAudioBucketsController : UIBaseController
{
	[Token(Token = "0x400F000")]
	[FieldOffset(Offset = "0x28")]
	private UIHudAudioBucketsView m_View;

	[Token(Token = "0x600EB2D")]
	[Address(RVA = "0x170B698", Offset = "0x170B698", VA = "0x170B698")]
	public UIHudAudioBucketsController()
	{
	}

	[Token(Token = "0x600EB2E")]
	[Address(RVA = "0x170B71C", Offset = "0x170B71C", VA = "0x170B71C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB2F")]
	[Address(RVA = "0x170B7C4", Offset = "0x170B7C4", VA = "0x170B7C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB30")]
	[Address(RVA = "0x170BB30", Offset = "0x170BB30", VA = "0x170BB30", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EB31")]
	[Address(RVA = "0x170BC64", Offset = "0x170BC64", VA = "0x170BC64")]
	private void OnAudioDeubgToggle()
	{
	}

	[Token(Token = "0x600EB32")]
	[Address(RVA = "0x170BA10", Offset = "0x170BA10", VA = "0x170BA10")]
	private void OnShowDebugUI(object[] param)
	{
	}

	[Token(Token = "0x600EB33")]
	[Address(RVA = "0x170BD34", Offset = "0x170BD34", VA = "0x170BD34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EB34")]
	[Address(RVA = "0x170BD3C", Offset = "0x170BD3C", VA = "0x170BD3C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
