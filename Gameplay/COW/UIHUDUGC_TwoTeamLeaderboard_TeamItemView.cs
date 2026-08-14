using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037B0")]
public class UIHUDUGC_TwoTeamLeaderboard_TeamItemView : UIBaseView
{
	[Token(Token = "0x40168D7")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid TitleGrid;

	[Token(Token = "0x40168D8")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TitleLabelTemp;

	[Token(Token = "0x40168D9")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView TeammateScrollView;

	[Token(Token = "0x40168DA")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid TeammateGrid;

	[Token(Token = "0x40168DB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject DragScrollView;

	[Token(Token = "0x6016ABB")]
	[Address(RVA = "0x2929FC8", Offset = "0x2929FC8", VA = "0x2929FC8")]
	public UIHUDUGC_TwoTeamLeaderboard_TeamItemView()
	{
	}

	[Token(Token = "0x6016ABC")]
	[Address(RVA = "0x2929FD0", Offset = "0x2929FD0", VA = "0x2929FD0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ABD")]
	[Address(RVA = "0x292A2E0", Offset = "0x292A2E0", VA = "0x292A2E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
