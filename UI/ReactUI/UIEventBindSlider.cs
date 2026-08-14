using Il2CppDummyDll;
using UnityEngine.UI;

namespace ReactUI;

[Token(Token = "0x2000CB0")]
public sealed class UIEventBindSlider : UIEventBind
{
	[Token(Token = "0x4006766")]
	[FieldOffset(Offset = "0x30")]
	private string eventName;

	[Token(Token = "0x4006767")]
	[FieldOffset(Offset = "0x34")]
	private Slider m_slider;

	[Token(Token = "0x4006768")]
	[FieldOffset(Offset = "0x38")]
	private SignalDelegateList m_event;

	[Token(Token = "0x600609C")]
	[Address(RVA = "0x315901C", Offset = "0x315901C", VA = "0x315901C")]
	public UIEventBindSlider()
	{
	}

	[Token(Token = "0x600609D")]
	[Address(RVA = "0x3159020", Offset = "0x3159020", VA = "0x3159020")]
	private SignalDelegateList GetEvent()
	{
		return null;
	}

	[Token(Token = "0x600609E")]
	[Address(RVA = "0x315904C", Offset = "0x315904C", VA = "0x315904C", Slot = "10")]
	protected override void RefreshBind()
	{
	}

	[Token(Token = "0x600609F")]
	[Address(RVA = "0x3159068", Offset = "0x3159068", VA = "0x3159068")]
	private new void Awake()
	{
	}

	[Token(Token = "0x60060A0")]
	[Address(RVA = "0x31590F8", Offset = "0x31590F8", VA = "0x31590F8")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60060A1")]
	[Address(RVA = "0x31591D8", Offset = "0x31591D8", VA = "0x31591D8")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60060A2")]
	[Address(RVA = "0x31592B8", Offset = "0x31592B8", VA = "0x31592B8")]
	private void onSliderChanged(float v)
	{
	}
}
