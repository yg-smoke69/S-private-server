using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200390E")]
public class UIPointsRankView : UIBaseView
{
	[Token(Token = "0x4017BCB")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4017BCC")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList ContentList;

	[Token(Token = "0x4017BCD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SelfInfo;

	[Token(Token = "0x4017BCE")]
	[FieldOffset(Offset = "0x20")]
	public UISprite CurClanIcon;

	[Token(Token = "0x6016ED3")]
	[Address(RVA = "0x2C54C90", Offset = "0x2C54C90", VA = "0x2C54C90")]
	public UIPointsRankView()
	{
	}

	[Token(Token = "0x6016ED4")]
	[Address(RVA = "0x2C54C98", Offset = "0x2C54C98", VA = "0x2C54C98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ED5")]
	[Address(RVA = "0x2C54F54", Offset = "0x2C54F54", VA = "0x2C54F54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
