using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200351B")]
public class UIEPDailyTaskRewardItemView : UIBaseView
{
	[Token(Token = "0x4014F4F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OperateBtn;

	[Token(Token = "0x4014F50")]
	[FieldOffset(Offset = "0x18")]
	public Animation UnlockAnimation;

	[Token(Token = "0x4014F51")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject OnGoingObj;

	[Token(Token = "0x4014F52")]
	[FieldOffset(Offset = "0x20")]
	public UILabel AwardCnt;

	[Token(Token = "0x4014F53")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RedPoint;

	[Token(Token = "0x4014F54")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ClaimedLabel;

	[Token(Token = "0x4014F55")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject UnReachObj;

	[Token(Token = "0x4014F56")]
	[FieldOffset(Offset = "0x30")]
	public UILabel AwardCnt1;

	[Token(Token = "0x4014F57")]
	[FieldOffset(Offset = "0x34")]
	public GameObject UnlockEffect;

	[Token(Token = "0x6016301")]
	[Address(RVA = "0x2BA9090", Offset = "0x2BA9090", VA = "0x2BA9090")]
	public UIEPDailyTaskRewardItemView()
	{
	}

	[Token(Token = "0x6016302")]
	[Address(RVA = "0x2BA9098", Offset = "0x2BA9098", VA = "0x2BA9098", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016303")]
	[Address(RVA = "0x2BA9510", Offset = "0x2BA9510", VA = "0x2BA9510")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
