using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200380D")]
public class UILadderMatchMasterRankUpPopupView : UIBaseView
{
	[Token(Token = "0x4016C98")]
	[FieldOffset(Offset = "0x14")]
	public UISprite RankIcon;

	[Token(Token = "0x4016C99")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Describe;

	[Token(Token = "0x4016C9A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RankName;

	[Token(Token = "0x4016C9B")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ContinueBtn;

	[Token(Token = "0x4016C9C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Continue;

	[Token(Token = "0x6016BD2")]
	[Address(RVA = "0x1AF6AA8", Offset = "0x1AF6AA8", VA = "0x1AF6AA8")]
	public UILadderMatchMasterRankUpPopupView()
	{
	}

	[Token(Token = "0x6016BD3")]
	[Address(RVA = "0x1AF6AB0", Offset = "0x1AF6AB0", VA = "0x1AF6AB0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BD4")]
	[Address(RVA = "0x1AF6DCC", Offset = "0x1AF6DCC", VA = "0x1AF6DCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
