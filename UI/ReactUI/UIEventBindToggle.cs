using Il2CppDummyDll;
using UnityEngine.UI;

namespace ReactUI;

[Token(Token = "0x2000CB2")]
public sealed class UIEventBindToggle : UIEventBind
{
	[Token(Token = "0x400676E")]
	[FieldOffset(Offset = "0x30")]
	private string eventName;

	[Token(Token = "0x400676F")]
	[FieldOffset(Offset = "0x34")]
	private Toggle m_toggle;

	[Token(Token = "0x4006770")]
	[FieldOffset(Offset = "0x38")]
	private SignalDelegateList m_eventDelegate;

	[Token(Token = "0x60060AC")]
	[Address(RVA = "0x3159B00", Offset = "0x3159B00", VA = "0x3159B00")]
	public UIEventBindToggle()
	{
	}

	[Token(Token = "0x60060AD")]
	[Address(RVA = "0x3159B04", Offset = "0x3159B04", VA = "0x3159B04")]
	private SignalDelegateList GetDelegateList()
	{
		return null;
	}

	[Token(Token = "0x60060AE")]
	[Address(RVA = "0x3159B30", Offset = "0x3159B30", VA = "0x3159B30", Slot = "10")]
	protected override void RefreshBind()
	{
	}

	[Token(Token = "0x60060AF")]
	[Address(RVA = "0x3159B4C", Offset = "0x3159B4C", VA = "0x3159B4C")]
	private new void Awake()
	{
	}

	[Token(Token = "0x60060B0")]
	[Address(RVA = "0x3159BDC", Offset = "0x3159BDC", VA = "0x3159BDC")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60060B1")]
	[Address(RVA = "0x3159CB0", Offset = "0x3159CB0", VA = "0x3159CB0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60060B2")]
	[Address(RVA = "0x3159D84", Offset = "0x3159D84", VA = "0x3159D84")]
	private void OnToggleChanged(bool isToggle)
	{
	}
}
