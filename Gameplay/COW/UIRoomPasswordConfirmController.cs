using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AF6")]
public class UIRoomPasswordConfirmController : UIPopupWindowController
{
	[Token(Token = "0x2002AF7")]
	public enum UIStyle
	{
		[Token(Token = "0x40107C5")]
		PasswordOnly,
		[Token(Token = "0x40107C6")]
		GroupNameAndPassword
	}

	[Token(Token = "0x40107C1")]
	[FieldOffset(Offset = "0x48")]
	private UIRoomPasswordConfirmView m_View;

	[Token(Token = "0x40107C2")]
	[FieldOffset(Offset = "0x4C")]
	private Action<string, string, string> m_ConfirmCallback;

	[Token(Token = "0x40107C3")]
	[FieldOffset(Offset = "0x50")]
	private UIStyle m_Style;

	[Token(Token = "0x6011A2A")]
	[Address(RVA = "0x23D7A80", Offset = "0x23D7A80", VA = "0x23D7A80")]
	public UIRoomPasswordConfirmController()
	{
	}

	[Token(Token = "0x6011A2B")]
	[Address(RVA = "0x23D7A88", Offset = "0x23D7A88", VA = "0x23D7A88")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011A2C")]
	[Address(RVA = "0x23D7B2C", Offset = "0x23D7B2C", VA = "0x23D7B2C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011A2D")]
	[Address(RVA = "0x23CD2BC", Offset = "0x23CD2BC", VA = "0x23CD2BC")]
	public void SetUIStyle(UIStyle style)
	{
	}

	[Token(Token = "0x6011A2E")]
	[Address(RVA = "0x23D7CFC", Offset = "0x23D7CFC", VA = "0x23D7CFC")]
	private void RefreshCacheGroupName()
	{
	}

	[Token(Token = "0x6011A2F")]
	[Address(RVA = "0x23CD404", Offset = "0x23CD404", VA = "0x23CD404")]
	public void SetConfirmCallback(Action<string, string, string> callback)
	{
	}

	[Token(Token = "0x6011A30")]
	[Address(RVA = "0x23D84F8", Offset = "0x23D84F8", VA = "0x23D84F8")]
	private void OnBtnConfirm()
	{
	}

	[Token(Token = "0x6011A31")]
	[Address(RVA = "0x23D8F50", Offset = "0x23D8F50", VA = "0x23D8F50")]
	private void OnBtnClose()
	{
	}

	[Token(Token = "0x6011A32")]
	[Address(RVA = "0x23D8FB4", Offset = "0x23D8FB4", VA = "0x23D8FB4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
