using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002D33")]
public class PopMenuItemView : MonoBehaviour
{
	[Token(Token = "0x401144B")]
	[FieldOffset(Offset = "0xC")]
	public UIButton ItemBtn;

	[Token(Token = "0x401144C")]
	[FieldOffset(Offset = "0x10")]
	public UIWidget Container;

	[Token(Token = "0x401144D")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget EnableBG;

	[Token(Token = "0x401144E")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Label;

	[Token(Token = "0x401144F")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget DisableBG;

	[Token(Token = "0x4011450")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DisableLabel;

	[Token(Token = "0x6012E8B")]
	[Address(RVA = "0x1E23E70", Offset = "0x1E23E70", VA = "0x1E23E70")]
	public PopMenuItemView()
	{
	}
}
