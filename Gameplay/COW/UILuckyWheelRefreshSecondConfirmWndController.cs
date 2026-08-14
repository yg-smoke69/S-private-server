using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002965")]
public class UILuckyWheelRefreshSecondConfirmWndController : UIPopupWindowController
{
	[Token(Token = "0x400FF24")]
	[FieldOffset(Offset = "0x48")]
	private UILuckyWheelRefreshSecondConfirmWndView m_View;

	[Token(Token = "0x400FF25")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLuckyWheel m_Model;

	[Token(Token = "0x400FF26")]
	[FieldOffset(Offset = "0x50")]
	private uint m_ID;

	[Token(Token = "0x400FF27")]
	[FieldOffset(Offset = "0x54")]
	private Action m_CloseAction;

	[Token(Token = "0x601096A")]
	[Address(RVA = "0x18CDC14", Offset = "0x18CDC14", VA = "0x18CDC14")]
	public UILuckyWheelRefreshSecondConfirmWndController()
	{
	}

	[Token(Token = "0x601096B")]
	[Address(RVA = "0x18CDC1C", Offset = "0x18CDC1C", VA = "0x18CDC1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601096C")]
	[Address(RVA = "0x18CDCC4", Offset = "0x18CDCC4", VA = "0x18CDCC4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601096D")]
	[Address(RVA = "0x18CE030", Offset = "0x18CE030", VA = "0x18CE030")]
	public void SetViewData(uint price, Action action)
	{
	}

	[Token(Token = "0x601096E")]
	[Address(RVA = "0x18CE234", Offset = "0x18CE234", VA = "0x18CE234")]
	private void OnToggleClick()
	{
	}

	[Token(Token = "0x601096F")]
	[Address(RVA = "0x18CE2DC", Offset = "0x18CE2DC", VA = "0x18CE2DC")]
	private void OnCancelClick()
	{
	}

	[Token(Token = "0x6010970")]
	[Address(RVA = "0x18CE340", Offset = "0x18CE340", VA = "0x18CE340")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x6010971")]
	[Address(RVA = "0x18CE3B8", Offset = "0x18CE3B8", VA = "0x18CE3B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
