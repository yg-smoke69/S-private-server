using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x200224E")]
public class UIHudMatchResultMVPShowController : UIBaseController
{
	[Token(Token = "0x400D6CF")]
	[FieldOffset(Offset = "0x28")]
	private UIHudMatchResultMVPShowView m_View;

	[Token(Token = "0x400D6D0")]
	[FieldOffset(Offset = "0x2C")]
	private JOKABEAPNPP m_GameMode;

	[Token(Token = "0x400D6D1")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HasWaitContinue;

	[Token(Token = "0x400D6D2")]
	[FieldOffset(Offset = "0x34")]
	private uint m_UIEnterDelayCallID;

	[Token(Token = "0x400D6D3")]
	[FieldOffset(Offset = "0x38")]
	private float MVPUIEnterDelayTime;

	[Token(Token = "0x400D6D4")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_NeedLogContinueBtn;

	[Token(Token = "0x17001082")]
	private JOKABEAPNPP GameMode
	{
		[Token(Token = "0x600BAC5")]
		[Address(RVA = "0x19BB4E4", Offset = "0x19BB4E4", VA = "0x19BB4E4")]
		get
		{
			return default(JOKABEAPNPP);
		}
	}

	[Token(Token = "0x600BAC3")]
	[Address(RVA = "0x19BB3A4", Offset = "0x19BB3A4", VA = "0x19BB3A4")]
	public UIHudMatchResultMVPShowController()
	{
	}

	[Token(Token = "0x600BAC4")]
	[Address(RVA = "0x19BB43C", Offset = "0x19BB43C", VA = "0x19BB43C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BAC6")]
	[Address(RVA = "0x19BB53C", Offset = "0x19BB53C", VA = "0x19BB53C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BAC7")]
	[Address(RVA = "0x19BBB20", Offset = "0x19BBB20", VA = "0x19BBB20", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600BAC8")]
	[Address(RVA = "0x19BBB84", Offset = "0x19BBB84", VA = "0x19BBB84", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600BAC9")]
	[Address(RVA = "0x19BBDA8", Offset = "0x19BBDA8", VA = "0x19BBDA8", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600BACA")]
	[Address(RVA = "0x19BBEF4", Offset = "0x19BBEF4", VA = "0x19BBEF4", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600BACB")]
	[Address(RVA = "0x19BC040", Offset = "0x19BC040", VA = "0x19BC040")]
	public void SetData(JOKABEAPNPP gameMode, TeammateStats mvpData, bool isWin)
	{
	}

	[Token(Token = "0x600BACC")]
	[Address(RVA = "0x19BC8DC", Offset = "0x19BC8DC", VA = "0x19BC8DC")]
	public void SetDelayData(float delay)
	{
	}

	[Token(Token = "0x600BACD")]
	[Address(RVA = "0x19BCA50", Offset = "0x19BCA50", VA = "0x19BCA50")]
	public void SetDownloadState(bool flag)
	{
	}

	[Token(Token = "0x600BACE")]
	[Address(RVA = "0x19BCAE8", Offset = "0x19BCAE8", VA = "0x19BCAE8")]
	private void OnClickShareBtn()
	{
	}

	[Token(Token = "0x600BACF")]
	[Address(RVA = "0x19BCCF8", Offset = "0x19BCCF8", VA = "0x19BCCF8")]
	private void OnClickContinueBtn()
	{
	}

	[Token(Token = "0x600BAD0")]
	[Address(RVA = "0x19BCDBC", Offset = "0x19BCDBC", VA = "0x19BCDBC")]
	private void MVPUIEnter()
	{
	}

	[Token(Token = "0x600BAD1")]
	[Address(RVA = "0x19BCF5C", Offset = "0x19BCF5C", VA = "0x19BCF5C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BAD2")]
	[Address(RVA = "0x19BCF64", Offset = "0x19BCF64", VA = "0x19BCF64")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600BAD3")]
	[Address(RVA = "0x19BCF6C", Offset = "0x19BCF6C", VA = "0x19BCF6C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600BAD4")]
	[Address(RVA = "0x19BCF74", Offset = "0x19BCF74", VA = "0x19BCF74")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600BAD5")]
	[Address(RVA = "0x19BCF7C", Offset = "0x19BCF7C", VA = "0x19BCF7C")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
