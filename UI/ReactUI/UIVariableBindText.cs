using Il2CppDummyDll;
using TMPro;

namespace ReactUI;

[Token(Token = "0x2000CDE")]
public sealed class UIVariableBindText : UIVariableBind
{
	[Token(Token = "0x4006849")]
	[FieldOffset(Offset = "0x1C")]
	private string format;

	[Token(Token = "0x400684A")]
	[FieldOffset(Offset = "0x20")]
	private string[] paramBinds;

	[Token(Token = "0x400684B")]
	[FieldOffset(Offset = "0x24")]
	private bool setTextNotKey;

	[Token(Token = "0x400684C")]
	[FieldOffset(Offset = "0x28")]
	private TextMeshPro m_text;

	[Token(Token = "0x400684D")]
	[FieldOffset(Offset = "0x2C")]
	private UILabel unityText;

	[Token(Token = "0x400684E")]
	[FieldOffset(Offset = "0x30")]
	private UIVariable[] m_bindVariable;

	[Token(Token = "0x400684F")]
	[FieldOffset(Offset = "0x34")]
	private string sepForArrayValue;

	[Token(Token = "0x1700081F")]
	public string Format
	{
		[Token(Token = "0x60061A9")]
		[Address(RVA = "0x31680E8", Offset = "0x31680E8", VA = "0x31680E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x60061AA")]
		[Address(RVA = "0x31680F0", Offset = "0x31680F0", VA = "0x31680F0")]
		set
		{
		}
	}

	[Token(Token = "0x60061A8")]
	[Address(RVA = "0x3168050", Offset = "0x3168050", VA = "0x3168050")]
	public UIVariableBindText()
	{
	}

	[Token(Token = "0x60061AB")]
	[Address(RVA = "0x3168E78", Offset = "0x3168E78", VA = "0x3168E78", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x60061AC")]
	[Address(RVA = "0x31690F4", Offset = "0x31690F4", VA = "0x31690F4", Slot = "7")]
	protected override void UnbindVariables()
	{
	}

	[Token(Token = "0x60061AD")]
	[Address(RVA = "0x3168194", Offset = "0x3168194", VA = "0x3168194")]
	private void RefreshText()
	{
	}

	[Token(Token = "0x60061AE")]
	[Address(RVA = "0x3169220", Offset = "0x3169220", VA = "0x3169220")]
	private new void Awake()
	{
	}
}
