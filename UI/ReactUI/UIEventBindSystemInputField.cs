using Il2CppDummyDll;
using UnityEngine.UI;

namespace ReactUI;

[Token(Token = "0x2000CB1")]
public sealed class UIEventBindSystemInputField : UIEventBind
{
	[Token(Token = "0x4006769")]
	[FieldOffset(Offset = "0x30")]
	private string valueChangedEventName;

	[Token(Token = "0x400676A")]
	[FieldOffset(Offset = "0x34")]
	private string endEditEventName;

	[Token(Token = "0x400676B")]
	[FieldOffset(Offset = "0x38")]
	private InputField m_inputField;

	[Token(Token = "0x400676C")]
	[FieldOffset(Offset = "0x3C")]
	private SignalDelegateList m_delegateListForChanged;

	[Token(Token = "0x400676D")]
	[FieldOffset(Offset = "0x40")]
	private SignalDelegateList m_delegateListForEnd;

	[Token(Token = "0x60060A3")]
	[Address(RVA = "0x3159448", Offset = "0x3159448", VA = "0x3159448")]
	public UIEventBindSystemInputField()
	{
	}

	[Token(Token = "0x60060A4")]
	[Address(RVA = "0x315944C", Offset = "0x315944C", VA = "0x315944C")]
	private SignalDelegateList GetChangedDelegateList()
	{
		return null;
	}

	[Token(Token = "0x60060A5")]
	[Address(RVA = "0x3159478", Offset = "0x3159478", VA = "0x3159478")]
	private SignalDelegateList GetEndDelegateList()
	{
		return null;
	}

	[Token(Token = "0x60060A6")]
	[Address(RVA = "0x31594A4", Offset = "0x31594A4", VA = "0x31594A4", Slot = "10")]
	protected override void RefreshBind()
	{
	}

	[Token(Token = "0x60060A7")]
	[Address(RVA = "0x31594D0", Offset = "0x31594D0", VA = "0x31594D0")]
	private new void Awake()
	{
	}

	[Token(Token = "0x60060A8")]
	[Address(RVA = "0x3159560", Offset = "0x3159560", VA = "0x3159560")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60060A9")]
	[Address(RVA = "0x31596D4", Offset = "0x31596D4", VA = "0x31596D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60060AA")]
	[Address(RVA = "0x3159848", Offset = "0x3159848", VA = "0x3159848")]
	private void OnValueChanged(string v)
	{
	}

	[Token(Token = "0x60060AB")]
	[Address(RVA = "0x31599A4", Offset = "0x31599A4", VA = "0x31599A4")]
	private void OnValueEditEnd(string v)
	{
	}
}
