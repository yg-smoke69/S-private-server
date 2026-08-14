using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037B3")]
public class UIHUDUGC_TwoTeamMatchInfoSimpleView : UIBaseView
{
	[Token(Token = "0x40168EB")]
	[FieldOffset(Offset = "0x14")]
	public Transform Root;

	[Token(Token = "0x40168EC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Bg_Left;

	[Token(Token = "0x40168ED")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid LeftTeammates;

	[Token(Token = "0x40168EE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x40168EF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Bg_Right;

	[Token(Token = "0x40168F0")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RightTeamScore;

	[Token(Token = "0x40168F1")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid RightTeammates;

	[Token(Token = "0x40168F2")]
	[FieldOffset(Offset = "0x30")]
	public UISprite LeftTeamIcon;

	[Token(Token = "0x40168F3")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LeftTeamAlive;

	[Token(Token = "0x40168F4")]
	[FieldOffset(Offset = "0x38")]
	public UISprite RighttTeamIcon;

	[Token(Token = "0x40168F5")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel RightTeamAlive;

	[Token(Token = "0x40168F6")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget tutorialWidget;

	[Token(Token = "0x6016AC4")]
	[Address(RVA = "0x292DA94", Offset = "0x292DA94", VA = "0x292DA94")]
	public UIHUDUGC_TwoTeamMatchInfoSimpleView()
	{
	}

	[Token(Token = "0x6016AC5")]
	[Address(RVA = "0x292DA9C", Offset = "0x292DA9C", VA = "0x292DA9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AC6")]
	[Address(RVA = "0x292E024", Offset = "0x292E024", VA = "0x292E024")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
