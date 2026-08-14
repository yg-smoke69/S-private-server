using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;

namespace ReactUI;

[Token(Token = "0x2000CAF")]
public sealed class UIEventBindInputField : UIEventBind
{
	[Token(Token = "0x4006760")]
	[FieldOffset(Offset = "0x30")]
	private string valueChangedEventName;

	[Token(Token = "0x4006761")]
	[FieldOffset(Offset = "0x34")]
	private string endEditEventName;

	[Token(Token = "0x4006762")]
	[FieldOffset(Offset = "0x38")]
	private TMP_InputField m_inputField;

	[Token(Token = "0x4006763")]
	[FieldOffset(Offset = "0x3C")]
	private InputField systemInputField;

	[Token(Token = "0x4006764")]
	[FieldOffset(Offset = "0x40")]
	private SignalDelegateList m_delegateListForChanged;

	[Token(Token = "0x4006765")]
	[FieldOffset(Offset = "0x44")]
	private SignalDelegateList m_delegateListForEnd;

	[Token(Token = "0x6006093")]
	[Address(RVA = "0x31585E8", Offset = "0x31585E8", VA = "0x31585E8")]
	public UIEventBindInputField()
	{
	}

	[Token(Token = "0x6006094")]
	[Address(RVA = "0x31585EC", Offset = "0x31585EC", VA = "0x31585EC")]
	private SignalDelegateList GetChangedDelegateList()
	{
		return null;
	}

	[Token(Token = "0x6006095")]
	[Address(RVA = "0x3158618", Offset = "0x3158618", VA = "0x3158618")]
	private SignalDelegateList GetEndDelegateList()
	{
		return null;
	}

	[Token(Token = "0x6006096")]
	[Address(RVA = "0x3158644", Offset = "0x3158644", VA = "0x3158644", Slot = "10")]
	protected override void RefreshBind()
	{
	}

	[Token(Token = "0x6006097")]
	[Address(RVA = "0x3158670", Offset = "0x3158670", VA = "0x3158670")]
	private new void Awake()
	{
	}

	[Token(Token = "0x6006098")]
	[Address(RVA = "0x315871C", Offset = "0x315871C", VA = "0x315871C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6006099")]
	[Address(RVA = "0x3158A40", Offset = "0x3158A40", VA = "0x3158A40")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600609A")]
	[Address(RVA = "0x3158D64", Offset = "0x3158D64", VA = "0x3158D64")]
	private void OnValueChanged(string v)
	{
	}

	[Token(Token = "0x600609B")]
	[Address(RVA = "0x3158EC0", Offset = "0x3158EC0", VA = "0x3158EC0")]
	private void OnValueEditEnd(string v)
	{
	}
}
