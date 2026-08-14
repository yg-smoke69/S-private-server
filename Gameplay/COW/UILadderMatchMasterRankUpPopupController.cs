using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028EA")]
internal class UILadderMatchMasterRankUpPopupController : UIPopupWindowController
{
	[Token(Token = "0x400FB9E")]
	[FieldOffset(Offset = "0x48")]
	private UILadderMatchMasterRankUpPopupView m_View;

	[Token(Token = "0x400FB9F")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_DelayCallId;

	[Token(Token = "0x601029F")]
	[Address(RVA = "0x1AF6298", Offset = "0x1AF6298", VA = "0x1AF6298")]
	public UILadderMatchMasterRankUpPopupController()
	{
	}

	[Token(Token = "0x60102A0")]
	[Address(RVA = "0x1AF62A0", Offset = "0x1AF62A0", VA = "0x1AF62A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60102A1")]
	[Address(RVA = "0x1AF6344", Offset = "0x1AF6344", VA = "0x1AF6344", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60102A2")]
	[Address(RVA = "0x1AF65E8", Offset = "0x1AF65E8", VA = "0x1AF65E8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60102A3")]
	[Address(RVA = "0x1AF6704", Offset = "0x1AF6704", VA = "0x1AF6704")]
	public void SetData(PeakRankData data, string info)
	{
	}

	[Token(Token = "0x60102A4")]
	[Address(RVA = "0x1AF698C", Offset = "0x1AF698C", VA = "0x1AF698C")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x60102A5")]
	[Address(RVA = "0x1AF69F0", Offset = "0x1AF69F0", VA = "0x1AF69F0")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x60102A6")]
	[Address(RVA = "0x1AF6A98", Offset = "0x1AF6A98", VA = "0x1AF6A98")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60102A7")]
	[Address(RVA = "0x1AF6AA0", Offset = "0x1AF6AA0", VA = "0x1AF6AA0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
