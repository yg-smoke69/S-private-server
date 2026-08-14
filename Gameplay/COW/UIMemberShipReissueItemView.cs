using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038A6")]
public class UIMemberShipReissueItemView : UIBaseView
{
	[Token(Token = "0x40176DB")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40176DC")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid Grid;

	[Token(Token = "0x40176DD")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton ReissuBtn;

	[Token(Token = "0x40176DE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ReissueBtnGray;

	[Token(Token = "0x40176DF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CliamedLabel;

	[Token(Token = "0x40176E0")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DataTimeLabel;

	[Token(Token = "0x40176E1")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TodayRewardLabel;

	[Token(Token = "0x6016D9D")]
	[Address(RVA = "0x12FEC74", Offset = "0x12FEC74", VA = "0x12FEC74")]
	public UIMemberShipReissueItemView()
	{
	}

	[Token(Token = "0x6016D9E")]
	[Address(RVA = "0x12FEC7C", Offset = "0x12FEC7C", VA = "0x12FEC7C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D9F")]
	[Address(RVA = "0x12FF04C", Offset = "0x12FF04C", VA = "0x12FF04C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
