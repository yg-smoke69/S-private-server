using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C1F")]
internal class UIWebViewWindowController : UIWebViewWindowBaseController
{
	[Token(Token = "0x4010D73")]
	[FieldOffset(Offset = "0x50")]
	private UIWebViewWindowView m_View;

	[Token(Token = "0x4010D74")]
	[FieldOffset(Offset = "0x54")]
	private uint m_UpdateDelayCallId;

	[Token(Token = "0x4010D75")]
	[FieldOffset(Offset = "0x58")]
	private float _LastProgress;

	[Token(Token = "0x4010D76")]
	[FieldOffset(Offset = "0x5C")]
	private float _NextProgress;

	[Token(Token = "0x4010D77")]
	[FieldOffset(Offset = "0x60")]
	private long _LastProgressTicks;

	[Token(Token = "0x4010D78")]
	[FieldOffset(Offset = "0x68")]
	private long _LastLoadTicks;

	[Token(Token = "0x4010D79")]
	[FieldOffset(Offset = "0x70")]
	private bool _Loading;

	[Token(Token = "0x17001323")]
	private float ProgressAnimationDuration
	{
		[Token(Token = "0x60125C3")]
		[Address(RVA = "0x1B7E1F8", Offset = "0x1B7E1F8", VA = "0x1B7E1F8")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001324")]
	private float PromptReloadDuration
	{
		[Token(Token = "0x60125C4")]
		[Address(RVA = "0x1B7E344", Offset = "0x1B7E344", VA = "0x1B7E344")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60125C1")]
	[Address(RVA = "0x1B7E148", Offset = "0x1B7E148", VA = "0x1B7E148")]
	public UIWebViewWindowController()
	{
	}

	[Token(Token = "0x60125C2")]
	[Address(RVA = "0x1B7E150", Offset = "0x1B7E150", VA = "0x1B7E150")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60125C5")]
	[Address(RVA = "0x1B7E490", Offset = "0x1B7E490", VA = "0x1B7E490")]
	private void _UpdateProgress(float progress)
	{
	}

	[Token(Token = "0x60125C6")]
	[Address(RVA = "0x1B7E5B0", Offset = "0x1B7E5B0", VA = "0x1B7E5B0")]
	private float _SmoothProgress()
	{
		return default(float);
	}

	[Token(Token = "0x60125C7")]
	[Address(RVA = "0x1B7E754", Offset = "0x1B7E754", VA = "0x1B7E754", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60125C8")]
	[Address(RVA = "0x1B7EA84", Offset = "0x1B7EA84", VA = "0x1B7EA84", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x60125C9")]
	[Address(RVA = "0x1B7EADC", Offset = "0x1B7EADC", VA = "0x1B7EADC")]
	public void SetData(string url)
	{
	}

	[Token(Token = "0x60125CA")]
	[Address(RVA = "0x1B7ED44", Offset = "0x1B7ED44", VA = "0x1B7ED44", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60125CB")]
	[Address(RVA = "0x1B7EE58", Offset = "0x1B7EE58", VA = "0x1B7EE58", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60125CC")]
	[Address(RVA = "0x1B7EF70", Offset = "0x1B7EF70", VA = "0x1B7EF70")]
	private void OnCloseButtonClick()
	{
	}

	[Token(Token = "0x60125CD")]
	[Address(RVA = "0x1B7F0B0", Offset = "0x1B7F0B0", VA = "0x1B7F0B0")]
	private void OnReloadButtonClick()
	{
	}

	[Token(Token = "0x60125CE")]
	[Address(RVA = "0x1B7F2B4", Offset = "0x1B7F2B4", VA = "0x1B7F2B4")]
	private void OnExternalButtonClick()
	{
	}

	[Token(Token = "0x60125CF")]
	[Address(RVA = "0x1B7F43C", Offset = "0x1B7F43C", VA = "0x1B7F43C")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x60125D0")]
	[Address(RVA = "0x1B7FA18", Offset = "0x1B7FA18", VA = "0x1B7FA18")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60125D1")]
	[Address(RVA = "0x1B7FA1C", Offset = "0x1B7FA1C", VA = "0x1B7FA1C")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x60125D2")]
	[Address(RVA = "0x1B7FA24", Offset = "0x1B7FA24", VA = "0x1B7FA24")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60125D3")]
	[Address(RVA = "0x1B7FA28", Offset = "0x1B7FA28", VA = "0x1B7FA28")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
