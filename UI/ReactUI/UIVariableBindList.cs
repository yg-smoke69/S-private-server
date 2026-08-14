using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CD7")]
public sealed class UIVariableBindList : UIVariableBind
{
	[Token(Token = "0x400681A")]
	[FieldOffset(Offset = "0x1C")]
	private string paramBinds;

	[Token(Token = "0x400681B")]
	[FieldOffset(Offset = "0x20")]
	private GameObject parent;

	[Token(Token = "0x400681C")]
	[FieldOffset(Offset = "0x24")]
	private GameObject itemCreatorGo;

	[Token(Token = "0x400681D")]
	[FieldOffset(Offset = "0x28")]
	private IUIVariableBindListItemCreator itemCreator;

	[Token(Token = "0x400681E")]
	[FieldOffset(Offset = "0x2C")]
	private UIVariable bindVariable;

	[Token(Token = "0x6006189")]
	[Address(RVA = "0x316556C", Offset = "0x316556C", VA = "0x316556C")]
	public UIVariableBindList()
	{
	}

	[Token(Token = "0x600618A")]
	[Address(RVA = "0x31655F0", Offset = "0x31655F0", VA = "0x31655F0")]
	private new void Awake()
	{
	}

	[Token(Token = "0x600618B")]
	[Address(RVA = "0x3165600", Offset = "0x3165600", VA = "0x3165600", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x600618C")]
	[Address(RVA = "0x31657A8", Offset = "0x31657A8", VA = "0x31657A8", Slot = "7")]
	protected override void UnbindVariables()
	{
	}

	[Token(Token = "0x600618D")]
	[Address(RVA = "0x31658B8", Offset = "0x31658B8", VA = "0x31658B8")]
	private void RefreshList()
	{
	}

	[Token(Token = "0x600618E")]
	[Address(RVA = "0x31659C4", Offset = "0x31659C4", VA = "0x31659C4")]
	private void OnVariableInit()
	{
	}

	[Token(Token = "0x600618F")]
	[Address(RVA = "0x31658BC", Offset = "0x31658BC", VA = "0x31658BC")]
	private void RefreshListNormal()
	{
	}
}
