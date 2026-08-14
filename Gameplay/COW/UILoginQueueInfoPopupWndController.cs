using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002952")]
public class UILoginQueueInfoPopupWndController : UIPopupWindowController
{
	[Token(Token = "0x400FEB6")]
	[FieldOffset(Offset = "0x48")]
	private UILoginQueueInfoPopupWndView m_View;

	[Token(Token = "0x400FEB7")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLogin m_ModelLogin;

	[Token(Token = "0x400FEB8")]
	[FieldOffset(Offset = "0x50")]
	private uint m_Hours;

	[Token(Token = "0x400FEB9")]
	[FieldOffset(Offset = "0x54")]
	private uint m_Mins;

	[Token(Token = "0x400FEBA")]
	[FieldOffset(Offset = "0x58")]
	private uint m_Secs;

	[Token(Token = "0x400FEBB")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_RequestInterval;

	[Token(Token = "0x400FEBC")]
	[FieldOffset(Offset = "0x60")]
	private CountDownConfig m_Config;

	[Token(Token = "0x400FEBD")]
	[FieldOffset(Offset = "0x68")]
	private ulong m_StartCountDownTime;

	[Token(Token = "0x400FEBE")]
	[FieldOffset(Offset = "0x70")]
	private ulong m_TotalWaitSec;

	[Token(Token = "0x601086F")]
	[Address(RVA = "0x21F5384", Offset = "0x21F5384", VA = "0x21F5384")]
	public UILoginQueueInfoPopupWndController()
	{
	}

	[Token(Token = "0x6010870")]
	[Address(RVA = "0x21F5400", Offset = "0x21F5400", VA = "0x21F5400")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010871")]
	[Address(RVA = "0x21F54A4", Offset = "0x21F54A4", VA = "0x21F54A4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010872")]
	[Address(RVA = "0x21F5670", Offset = "0x21F5670", VA = "0x21F5670")]
	public void UpdateQueueInfo(LoginQueueInfo info, bool IsNew = false)
	{
	}

	[Token(Token = "0x6010873")]
	[Address(RVA = "0x21F5894", Offset = "0x21F5894", VA = "0x21F5894")]
	private void SetCountDown(uint sec)
	{
	}

	[Token(Token = "0x6010874")]
	[Address(RVA = "0x21F5B94", Offset = "0x21F5B94", VA = "0x21F5B94")]
	private void UpdateProgressBar()
	{
	}

	[Token(Token = "0x6010875")]
	[Address(RVA = "0x21F5D18", Offset = "0x21F5D18", VA = "0x21F5D18")]
	private void ReRequestQueueInfo()
	{
	}

	[Token(Token = "0x6010876")]
	[Address(RVA = "0x21F5D90", Offset = "0x21F5D90", VA = "0x21F5D90")]
	private void OnCancleClick()
	{
	}

	[Token(Token = "0x6010877")]
	[Address(RVA = "0x21F5E58", Offset = "0x21F5E58", VA = "0x21F5E58", Slot = "40")]
	public override bool ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x6010878")]
	[Address(RVA = "0x21F5EB0", Offset = "0x21F5EB0", VA = "0x21F5EB0", Slot = "41")]
	public override bool IgnoreEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x6010879")]
	[Address(RVA = "0x21F5E04", Offset = "0x21F5E04", VA = "0x21F5E04")]
	private void ClearData()
	{
	}

	[Token(Token = "0x601087A")]
	[Address(RVA = "0x21F5F14", Offset = "0x21F5F14", VA = "0x21F5F14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601087B")]
	[Address(RVA = "0x21F5F1C", Offset = "0x21F5F1C", VA = "0x21F5F1C")]
	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x601087C")]
	[Address(RVA = "0x21F5F24", Offset = "0x21F5F24", VA = "0x21F5F24")]
	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return default(bool);
	}
}
