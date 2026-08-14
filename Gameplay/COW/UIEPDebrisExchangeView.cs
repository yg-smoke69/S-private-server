using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200351D")]
public class UIEPDebrisExchangeView : UIBaseView
{
	[Token(Token = "0x4014F6C")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BGStyle0;

	[Token(Token = "0x4014F6D")]
	[FieldOffset(Offset = "0x18")]
	public Transform BGTopPos0;

	[Token(Token = "0x4014F6E")]
	[FieldOffset(Offset = "0x1C")]
	public Transform BGBottomPos0;

	[Token(Token = "0x4014F6F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4014F70")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BadgeCntFrom;

	[Token(Token = "0x4014F71")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CntFrom;

	[Token(Token = "0x4014F72")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BadgeCntTo;

	[Token(Token = "0x4014F73")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CntTo;

	[Token(Token = "0x4014F74")]
	[FieldOffset(Offset = "0x34")]
	public UIEasyList RewardList;

	[Token(Token = "0x6016307")]
	[Address(RVA = "0x2BAA994", Offset = "0x2BAA994", VA = "0x2BAA994")]
	public UIEPDebrisExchangeView()
	{
	}

	[Token(Token = "0x6016308")]
	[Address(RVA = "0x2BAA99C", Offset = "0x2BAA99C", VA = "0x2BAA99C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016309")]
	[Address(RVA = "0x2BAADE8", Offset = "0x2BAADE8", VA = "0x2BAADE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
