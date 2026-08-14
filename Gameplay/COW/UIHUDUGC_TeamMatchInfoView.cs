using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037AD")]
public class UIHUDUGC_TeamMatchInfoView : UIBaseView
{
	[Token(Token = "0x40168BA")]
	[FieldOffset(Offset = "0x14")]
	public Transform Root;

	[Token(Token = "0x40168BB")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Id;

	[Token(Token = "0x40168BC")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite TeamColor;

	[Token(Token = "0x40168BD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Frame;

	[Token(Token = "0x40168BE")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Num;

	[Token(Token = "0x40168BF")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Icon;

	[Token(Token = "0x6016AB2")]
	[Address(RVA = "0x292408C", Offset = "0x292408C", VA = "0x292408C")]
	public UIHUDUGC_TeamMatchInfoView()
	{
	}

	[Token(Token = "0x6016AB3")]
	[Address(RVA = "0x2924094", Offset = "0x2924094", VA = "0x2924094", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AB4")]
	[Address(RVA = "0x29243E8", Offset = "0x29243E8", VA = "0x29243E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
