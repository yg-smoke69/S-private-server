using System;
using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CAE")]
public sealed class UIEventBindButtonClick : UIEventBind
{
	[Token(Token = "0x400675B")]
	[FieldOffset(Offset = "0x30")]
	private string eventName;

	[Token(Token = "0x400675C")]
	[FieldOffset(Offset = "0x34")]
	private UIButton button;

	[Token(Token = "0x400675D")]
	[FieldOffset(Offset = "0x38")]
	private SignalDelegateList m_delegateList;

	[NonSerialized]
	[Token(Token = "0x400675E")]
	[FieldOffset(Offset = "0x3C")]
	public bool IsInterceptClickEvent;

	[Token(Token = "0x14000003")]
	public event Action OnInterceptClickEvent
	{
		[Token(Token = "0x6006091")]
		[Address(RVA = "0x31583D0", Offset = "0x31583D0", VA = "0x31583D0")]
		add
		{
		}
		[Token(Token = "0x6006092")]
		[Address(RVA = "0x31584DC", Offset = "0x31584DC", VA = "0x31584DC")]
		remove
		{
		}
	}

	[Token(Token = "0x600608B")]
	[Address(RVA = "0x3157F0C", Offset = "0x3157F0C", VA = "0x3157F0C")]
	public UIEventBindButtonClick()
	{
	}

	[Token(Token = "0x600608C")]
	[Address(RVA = "0x3157F10", Offset = "0x3157F10", VA = "0x3157F10")]
	private SignalDelegateList GetDelegateList()
	{
		return null;
	}

	[Token(Token = "0x600608D")]
	[Address(RVA = "0x3157F3C", Offset = "0x3157F3C", VA = "0x3157F3C", Slot = "10")]
	protected override void RefreshBind()
	{
	}

	[Token(Token = "0x600608E")]
	[Address(RVA = "0x3157F58", Offset = "0x3157F58", VA = "0x3157F58")]
	private new void Awake()
	{
	}

	[Token(Token = "0x600608F")]
	[Address(RVA = "0x31580B8", Offset = "0x31580B8", VA = "0x31580B8")]
	private void OnButtonClick()
	{
	}

	[Token(Token = "0x6006090")]
	[Address(RVA = "0x3158290", Offset = "0x3158290", VA = "0x3158290", Slot = "5")]
	protected override void OnDestroy()
	{
	}
}
