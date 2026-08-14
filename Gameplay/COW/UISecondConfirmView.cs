using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A6")]
public class UISecondConfirmView : UIBaseView
{
	[Token(Token = "0x4018324")]
	[FieldOffset(Offset = "0x14")]
	public GameObject line;

	[Token(Token = "0x4018325")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CancelBtn;

	[Token(Token = "0x4018326")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4018327")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ConfirmBtnLabel;

	[Token(Token = "0x4018328")]
	[FieldOffset(Offset = "0x24")]
	public GameObject IconGoodsStyle;

	[Token(Token = "0x4018329")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid Item;

	[Token(Token = "0x401832A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ConfirmLabel;

	[Token(Token = "0x401832B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject TextGoodsStyle;

	[Token(Token = "0x401832C")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TextAwards;

	[Token(Token = "0x401832D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject OneTextStyle;

	[Token(Token = "0x401832E")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel OneTextContent;

	[Token(Token = "0x401832F")]
	[FieldOffset(Offset = "0x40")]
	public GameObject CheckBoxStyle;

	[Token(Token = "0x4018330")]
	[FieldOffset(Offset = "0x44")]
	public UIToggle Toggle;

	[Token(Token = "0x4018331")]
	[FieldOffset(Offset = "0x48")]
	public UILabel CheckBoxLabel;

	[Token(Token = "0x4018332")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel CheckBoxContent;

	[Token(Token = "0x6017099")]
	[Address(RVA = "0x1A50324", Offset = "0x1A50324", VA = "0x1A50324")]
	public UISecondConfirmView()
	{
	}

	[Token(Token = "0x601709A")]
	[Address(RVA = "0x1A5032C", Offset = "0x1A5032C", VA = "0x1A5032C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601709B")]
	[Address(RVA = "0x1A509D8", Offset = "0x1A509D8", VA = "0x1A509D8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
