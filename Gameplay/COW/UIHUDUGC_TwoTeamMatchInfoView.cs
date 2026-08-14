using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037B4")]
public class UIHUDUGC_TwoTeamMatchInfoView : UIBaseView
{
	[Token(Token = "0x40168F7")]
	[FieldOffset(Offset = "0x14")]
	public Transform Root;

	[Token(Token = "0x40168F8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Bg_Left;

	[Token(Token = "0x40168F9")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid LeftTeammates;

	[Token(Token = "0x40168FA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x40168FB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Bg_Right;

	[Token(Token = "0x40168FC")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RightTeamScore;

	[Token(Token = "0x40168FD")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid RightTeammates;

	[Token(Token = "0x6016AC7")]
	[Address(RVA = "0x292E02C", Offset = "0x292E02C", VA = "0x292E02C")]
	public UIHUDUGC_TwoTeamMatchInfoView()
	{
	}

	[Token(Token = "0x6016AC8")]
	[Address(RVA = "0x292E034", Offset = "0x292E034", VA = "0x292E034", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AC9")]
	[Address(RVA = "0x292E3DC", Offset = "0x292E3DC", VA = "0x292E3DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
