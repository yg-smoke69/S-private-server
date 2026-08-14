using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200379C")]
public class UIHUDUGC_MoreTeamLeaderboardView : UIBaseView
{
	[Token(Token = "0x4016874")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView TeamScrollView;

	[Token(Token = "0x4016875")]
	[FieldOffset(Offset = "0x18")]
	public UITable TeamTable;

	[Token(Token = "0x4016876")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton SpaceBtn;

	[Token(Token = "0x6016A7F")]
	[Address(RVA = "0x2E17F6C", Offset = "0x2E17F6C", VA = "0x2E17F6C")]
	public UIHUDUGC_MoreTeamLeaderboardView()
	{
	}

	[Token(Token = "0x6016A80")]
	[Address(RVA = "0x2E17F74", Offset = "0x2E17F74", VA = "0x2E17F74", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A81")]
	[Address(RVA = "0x2E181DC", Offset = "0x2E181DC", VA = "0x2E181DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
