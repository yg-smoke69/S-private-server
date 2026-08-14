using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003875")]
internal class UIMallPurchaseSuccessView : UIBaseView
{
	[Token(Token = "0x40173B6")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x40173B7")]
	[FieldOffset(Offset = "0x18")]
	public UIButton OpenBtn;

	[Token(Token = "0x40173B8")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BtnLabel;

	[Token(Token = "0x40173B9")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ItemIcon;

	[Token(Token = "0x6016D0A")]
	[Address(RVA = "0x22680DC", Offset = "0x22680DC", VA = "0x22680DC")]
	public UIMallPurchaseSuccessView()
	{
	}

	[Token(Token = "0x6016D0B")]
	[Address(RVA = "0x22680E4", Offset = "0x22680E4", VA = "0x22680E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D0C")]
	[Address(RVA = "0x22682EC", Offset = "0x22682EC", VA = "0x22682EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
