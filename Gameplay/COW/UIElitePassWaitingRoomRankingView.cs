using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003512")]
public class UIElitePassWaitingRoomRankingView : UIBaseView
{
	[Token(Token = "0x4014F08")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid Grid;

	[Token(Token = "0x4014F09")]
	[FieldOffset(Offset = "0x18")]
	public ElitePassWaittingRoomRanking Top1Player;

	[Token(Token = "0x4014F0A")]
	[FieldOffset(Offset = "0x1C")]
	public ElitePassWaittingRoomRanking Top2Player;

	[Token(Token = "0x4014F0B")]
	[FieldOffset(Offset = "0x20")]
	public ElitePassWaittingRoomRanking Top3Player;

	[Token(Token = "0x4014F0C")]
	[FieldOffset(Offset = "0x24")]
	public ElitePassWaittingRoomRanking MePlayer;

	[Token(Token = "0x4014F0D")]
	[FieldOffset(Offset = "0x28")]
	public UITexture AvatarTexture;

	[Token(Token = "0x60162E6")]
	[Address(RVA = "0x19D0A18", Offset = "0x19D0A18", VA = "0x19D0A18")]
	public UIElitePassWaitingRoomRankingView()
	{
	}

	[Token(Token = "0x60162E7")]
	[Address(RVA = "0x19D0A20", Offset = "0x19D0A20", VA = "0x19D0A20", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162E8")]
	[Address(RVA = "0x19D0DA8", Offset = "0x19D0DA8", VA = "0x19D0DA8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
