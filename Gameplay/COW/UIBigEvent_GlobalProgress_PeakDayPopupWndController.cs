using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E9A")]
public class UIBigEvent_GlobalProgress_PeakDayPopupWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C05A")]
	[FieldOffset(Offset = "0x48")]
	private UIBigEvent_GlobalProgress_PeakDayPopupWndView m_View;

	[Token(Token = "0x400C05B")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	[Token(Token = "0x400C05C")]
	[FieldOffset(Offset = "0x50")]
	private UIModelActivity m_UIModelActivity;

	[Token(Token = "0x400C05D")]
	[FieldOffset(Offset = "0x54")]
	private uint m_ActivityId;

	[Token(Token = "0x400C05E")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsAutoOpen;

	[Token(Token = "0x60093A0")]
	[Address(RVA = "0x10BF5E8", Offset = "0x10BF5E8", VA = "0x10BF5E8")]
	public UIBigEvent_GlobalProgress_PeakDayPopupWndController()
	{
	}

	[Token(Token = "0x60093A1")]
	[Address(RVA = "0x10BF5F0", Offset = "0x10BF5F0", VA = "0x10BF5F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60093A2")]
	[Address(RVA = "0x10BF698", Offset = "0x10BF698", VA = "0x10BF698", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60093A3")]
	[Address(RVA = "0x10C0514", Offset = "0x10C0514", VA = "0x10C0514", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60093A4")]
	[Address(RVA = "0x10C0578", Offset = "0x10C0578", VA = "0x10C0578", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60093A5")]
	[Address(RVA = "0x10BFB64", Offset = "0x10BFB64", VA = "0x10BFB64")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x60093A6")]
	[Address(RVA = "0x10C0624", Offset = "0x10C0624", VA = "0x10C0624")]
	private void SetErrorView()
	{
	}

	[Token(Token = "0x60093A7")]
	[Address(RVA = "0x10C07E4", Offset = "0x10C07E4", VA = "0x10C07E4")]
	private void OnBtnClaimClick()
	{
	}

	[Token(Token = "0x60093A8")]
	[Address(RVA = "0x10C092C", Offset = "0x10C092C", VA = "0x10C092C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60093A9")]
	[Address(RVA = "0x10C09C0", Offset = "0x10C09C0", VA = "0x10C09C0", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60093AA")]
	[Address(RVA = "0x10C0A90", Offset = "0x10C0A90", VA = "0x10C0A90")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60093AB")]
	[Address(RVA = "0x10C0A98", Offset = "0x10C0A98", VA = "0x10C0A98")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60093AC")]
	[Address(RVA = "0x10C0AA0", Offset = "0x10C0AA0", VA = "0x10C0AA0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
