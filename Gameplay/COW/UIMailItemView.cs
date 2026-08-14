using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003864")]
public class UIMailItemView : UIBaseView
{
	[Token(Token = "0x401725E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIMailItem;

	[Token(Token = "0x401725F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ItemSprite;

	[Token(Token = "0x4017260")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteMailUnRead;

	[Token(Token = "0x4017261")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteMailRead;

	[Token(Token = "0x4017262")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ReportWarning;

	[Token(Token = "0x4017263")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ReadSprite;

	[Token(Token = "0x4017264")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelTitle;

	[Token(Token = "0x4017265")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelTime;

	[Token(Token = "0x4017266")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SpriteTimeIcon;

	[Token(Token = "0x4017267")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SelectedBG;

	[Token(Token = "0x6016CD7")]
	[Address(RVA = "0x18E3990", Offset = "0x18E3990", VA = "0x18E3990")]
	public UIMailItemView()
	{
	}

	[Token(Token = "0x6016CD8")]
	[Address(RVA = "0x18E3998", Offset = "0x18E3998", VA = "0x18E3998", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CD9")]
	[Address(RVA = "0x18E3E94", Offset = "0x18E3E94", VA = "0x18E3E94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
