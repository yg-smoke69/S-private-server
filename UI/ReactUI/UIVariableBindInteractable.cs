using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CD3")]
public sealed class UIVariableBindInteractable : UIVariableBindBool
{
	[Token(Token = "0x400680A")]
	[FieldOffset(Offset = "0x25")]
	private bool IsSwapSprites;

	[Token(Token = "0x400680B")]
	[FieldOffset(Offset = "0x26")]
	private bool IsPopupNotifyOnNotInteractable;

	[Token(Token = "0x400680C")]
	[FieldOffset(Offset = "0x28")]
	private UIButton m_selectable;

	[Token(Token = "0x400680D")]
	[FieldOffset(Offset = "0x2C")]
	private UIEventBindButtonClick uiEventBindButtonClick;

	[Token(Token = "0x6006172")]
	[Address(RVA = "0x3164738", Offset = "0x3164738", VA = "0x3164738")]
	public UIVariableBindInteractable()
	{
	}

	[Token(Token = "0x6006173")]
	[Address(RVA = "0x316473C", Offset = "0x316473C", VA = "0x316473C", Slot = "10")]
	protected override void OnValueChanged()
	{
	}

	[Token(Token = "0x6006174")]
	[Address(RVA = "0x3164850", Offset = "0x3164850", VA = "0x3164850")]
	private void refreshButtonClick(bool interactable)
	{
	}

	[Token(Token = "0x6006175")]
	[Address(RVA = "0x3164A2C", Offset = "0x3164A2C", VA = "0x3164A2C")]
	private void onInterceptClickEvent()
	{
	}
}
