using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F8")]
public class UIHUDBountyRepairRankView : UIBaseView
{
	[Token(Token = "0x40159BB")]
	[FieldOffset(Offset = "0x14")]
	public BountyRepairingItem Rank1;

	[Token(Token = "0x40159BC")]
	[FieldOffset(Offset = "0x18")]
	public BountyRepairingItem Rank2;

	[Token(Token = "0x40159BD")]
	[FieldOffset(Offset = "0x1C")]
	public BountyRepairingItem Rank3;

	[Token(Token = "0x40159BE")]
	[FieldOffset(Offset = "0x20")]
	public BountyRepairingItem SelfRank;

	[Token(Token = "0x40159BF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject VFX_Bounty_Waiting_RankLock;

	[Token(Token = "0x6016596")]
	[Address(RVA = "0x1675818", Offset = "0x1675818", VA = "0x1675818")]
	public UIHUDBountyRepairRankView()
	{
	}

	[Token(Token = "0x6016597")]
	[Address(RVA = "0x1675820", Offset = "0x1675820", VA = "0x1675820", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016598")]
	[Address(RVA = "0x1675A64", Offset = "0x1675A64", VA = "0x1675A64")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
