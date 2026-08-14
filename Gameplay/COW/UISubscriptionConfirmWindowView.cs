using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F5")]
public class UISubscriptionConfirmWindowView : UIBaseView
{
	[Token(Token = "0x40186C3")]
	[FieldOffset(Offset = "0x14")]
	public UILabel DescLabel_1;

	[Token(Token = "0x40186C4")]
	[FieldOffset(Offset = "0x18")]
	public UILabel DescLabel_2;

	[Token(Token = "0x40186C5")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DescLabel_3;

	[Token(Token = "0x40186C6")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DescLabel_Whole;

	[Token(Token = "0x40186C7")]
	[FieldOffset(Offset = "0x24")]
	public UIButton ConfirmButton;

	[Token(Token = "0x40186C8")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CancelButton;

	[Token(Token = "0x40186C9")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton OKButton;

	[Token(Token = "0x6017185")]
	[Address(RVA = "0x2010FF8", Offset = "0x2010FF8", VA = "0x2010FF8")]
	public UISubscriptionConfirmWindowView()
	{
	}

	[Token(Token = "0x6017186")]
	[Address(RVA = "0x2011000", Offset = "0x2011000", VA = "0x2011000", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017187")]
	[Address(RVA = "0x20113E8", Offset = "0x20113E8", VA = "0x20113E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
