using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039AF")]
public class UIShootingGameRankingView : UIBaseView
{
	[Token(Token = "0x401837C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RankTitle;

	[Token(Token = "0x401837D")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LeftRank;

	[Token(Token = "0x401837E")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LeftName;

	[Token(Token = "0x401837F")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LeftScore;

	[Token(Token = "0x4018380")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LeftTime;

	[Token(Token = "0x4018381")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid LeftGrid;

	[Token(Token = "0x4018382")]
	[FieldOffset(Offset = "0x2C")]
	public UIShootingGameRankingItem Rank1;

	[Token(Token = "0x4018383")]
	[FieldOffset(Offset = "0x30")]
	public UIShootingGameRankingItem Rank2;

	[Token(Token = "0x4018384")]
	[FieldOffset(Offset = "0x34")]
	public UIShootingGameRankingItem Rank3;

	[Token(Token = "0x4018385")]
	[FieldOffset(Offset = "0x38")]
	public UIShootingGameRankingItem Rank4;

	[Token(Token = "0x4018386")]
	[FieldOffset(Offset = "0x3C")]
	public Transform Myself;

	[Token(Token = "0x4018387")]
	[FieldOffset(Offset = "0x40")]
	public UIShootingGameRankingItem Rank5;

	[Token(Token = "0x4018388")]
	[FieldOffset(Offset = "0x44")]
	public UILabel RightRank;

	[Token(Token = "0x4018389")]
	[FieldOffset(Offset = "0x48")]
	public UILabel RightName;

	[Token(Token = "0x401838A")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel RightScore;

	[Token(Token = "0x401838B")]
	[FieldOffset(Offset = "0x50")]
	public UILabel RightTime;

	[Token(Token = "0x401838C")]
	[FieldOffset(Offset = "0x54")]
	public UIGrid RightGrid;

	[Token(Token = "0x401838D")]
	[FieldOffset(Offset = "0x58")]
	public UIShootingGameRankingItem Rank6;

	[Token(Token = "0x401838E")]
	[FieldOffset(Offset = "0x5C")]
	public UIShootingGameRankingItem Rank7;

	[Token(Token = "0x401838F")]
	[FieldOffset(Offset = "0x60")]
	public UIShootingGameRankingItem Rank8;

	[Token(Token = "0x4018390")]
	[FieldOffset(Offset = "0x64")]
	public UIShootingGameRankingItem Rank9;

	[Token(Token = "0x4018391")]
	[FieldOffset(Offset = "0x68")]
	public UIShootingGameRankingItem Rank10;

	[Token(Token = "0x4018392")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject TimeTip;

	[Token(Token = "0x4018393")]
	[FieldOffset(Offset = "0x70")]
	public UILabel LeaveTime;

	[Token(Token = "0x60170B4")]
	[Address(RVA = "0x2053BB4", Offset = "0x2053BB4", VA = "0x2053BB4")]
	public UIShootingGameRankingView()
	{
	}

	[Token(Token = "0x60170B5")]
	[Address(RVA = "0x2053BBC", Offset = "0x2053BBC", VA = "0x2053BBC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170B6")]
	[Address(RVA = "0x20545D0", Offset = "0x20545D0", VA = "0x20545D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
