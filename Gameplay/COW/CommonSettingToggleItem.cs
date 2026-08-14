using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200203A")]
public class CommonSettingToggleItem : MonoBehaviour
{
	[Token(Token = "0x400CA1D")]
	[FieldOffset(Offset = "0xC")]
	public UILabel SelectLabel;

	[Token(Token = "0x400CA1E")]
	[FieldOffset(Offset = "0x10")]
	public UILabel UnselectLabel;

	[Token(Token = "0x400CA1F")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton ToggleBtn;

	[Token(Token = "0x400CA20")]
	[FieldOffset(Offset = "0x18")]
	public Color SelectLabelDefaultColor;

	[Token(Token = "0x400CA21")]
	[FieldOffset(Offset = "0x28")]
	public Color UnSelectLabelDefaultColor;

	[Token(Token = "0x600A3A6")]
	[Address(RVA = "0x1C7EC54", Offset = "0x1C7EC54", VA = "0x1C7EC54")]
	public CommonSettingToggleItem()
	{
	}

	[Token(Token = "0x600A3A7")]
	[Address(RVA = "0x1C7EC5C", Offset = "0x1C7EC5C", VA = "0x1C7EC5C")]
	public void OnInit()
	{
	}
}
