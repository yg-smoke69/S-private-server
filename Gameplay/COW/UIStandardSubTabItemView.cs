using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F0")]
public class UIStandardSubTabItemView : UIBaseView
{
	[Token(Token = "0x4018691")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnTab;

	[Token(Token = "0x4018692")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Select;

	[Token(Token = "0x4018693")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SelectLabel;

	[Token(Token = "0x4018694")]
	[FieldOffset(Offset = "0x20")]
	public GameObject UnSelect;

	[Token(Token = "0x4018695")]
	[FieldOffset(Offset = "0x24")]
	public UILabel UnSelectLabel;

	[Token(Token = "0x4018696")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Tag;

	[Token(Token = "0x4018697")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TagLabel;

	[Token(Token = "0x4018698")]
	[FieldOffset(Offset = "0x30")]
	public UISprite TagIconBg;

	[Token(Token = "0x4018699")]
	[FieldOffset(Offset = "0x34")]
	public UISprite TagIcon;

	[Token(Token = "0x401869A")]
	[FieldOffset(Offset = "0x38")]
	public UITipsButton RedPoint;

	[Token(Token = "0x401869B")]
	[FieldOffset(Offset = "0x3C")]
	public Transform Lock;

	[Token(Token = "0x6017176")]
	[Address(RVA = "0x20705B8", Offset = "0x20705B8", VA = "0x20705B8")]
	public UIStandardSubTabItemView()
	{
	}

	[Token(Token = "0x6017177")]
	[Address(RVA = "0x20705C0", Offset = "0x20705C0", VA = "0x20705C0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017178")]
	[Address(RVA = "0x2070ADC", Offset = "0x2070ADC", VA = "0x2070ADC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
