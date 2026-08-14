using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002426")]
public class UIUGCChangeHudNamePopupWindowController : UIPopupWindowController
{
	[Token(Token = "0x400E0F9")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCChangeHudNamePopupWindowView m_View;

	[Token(Token = "0x400E0FA")]
	private const int DEFAULT_LIMIT_CHAR = 12;

	[Token(Token = "0x400E0FB")]
	private const uint DEFUALT_COLOR = uint.MaxValue;

	[Token(Token = "0x400E0FC")]
	private const uint GREY_COLOR = 2593823487u;

	[Token(Token = "0x400E0FD")]
	[FieldOffset(Offset = "0x4C")]
	private Action<string> m_ChangeCallback;

	[Token(Token = "0x400E0FE")]
	[FieldOffset(Offset = "0x50")]
	private string m_CurrentValue;

	[Token(Token = "0x600CCA7")]
	[Address(RVA = "0x2B80CBC", Offset = "0x2B80CBC", VA = "0x2B80CBC")]
	public UIUGCChangeHudNamePopupWindowController()
	{
	}

	[Token(Token = "0x600CCA8")]
	[Address(RVA = "0x2B80CC4", Offset = "0x2B80CC4", VA = "0x2B80CC4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CCA9")]
	[Address(RVA = "0x2B80D68", Offset = "0x2B80D68", VA = "0x2B80D68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CCAA")]
	[Address(RVA = "0x2B80FAC", Offset = "0x2B80FAC", VA = "0x2B80FAC")]
	public void SetData(string curValue, Action<string> changeCallback, int charLimit = 12)
	{
	}

	[Token(Token = "0x600CCAB")]
	[Address(RVA = "0x2B81150", Offset = "0x2B81150", VA = "0x2B81150")]
	private void OnCancelBtnClick()
	{
	}

	[Token(Token = "0x600CCAC")]
	[Address(RVA = "0x2B811B4", Offset = "0x2B811B4", VA = "0x2B811B4")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x600CCAD")]
	[Address(RVA = "0x2B8135C", Offset = "0x2B8135C", VA = "0x2B8135C")]
	private void OnInputNameChanged()
	{
	}

	[Token(Token = "0x600CCAE")]
	[Address(RVA = "0x2B81674", Offset = "0x2B81674", VA = "0x2B81674")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
