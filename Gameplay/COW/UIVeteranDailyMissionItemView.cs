using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A54")]
public class UIVeteranDailyMissionItemView : UIBaseView
{
	[Token(Token = "0x4018AA2")]
	[FieldOffset(Offset = "0x14")]
	public Animation Animation;

	[Token(Token = "0x4018AA3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BG;

	[Token(Token = "0x4018AA4")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x4018AA5")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Operation;

	[Token(Token = "0x4018AA6")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ClaimedState;

	[Token(Token = "0x4018AA7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject UnfinishedState;

	[Token(Token = "0x4018AA8")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel UnfinishedTitle;

	[Token(Token = "0x4018AA9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject FinishedState;

	[Token(Token = "0x4018AAA")]
	[FieldOffset(Offset = "0x34")]
	public UILabel FinishedTitle;

	[Token(Token = "0x4018AAB")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ProgressTips;

	[Token(Token = "0x4018AAC")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Desc;

	[Token(Token = "0x60172A2")]
	[Address(RVA = "0x284F010", Offset = "0x284F010", VA = "0x284F010")]
	public UIVeteranDailyMissionItemView()
	{
	}

	[Token(Token = "0x60172A3")]
	[Address(RVA = "0x284F018", Offset = "0x284F018", VA = "0x284F018", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172A4")]
	[Address(RVA = "0x284F550", Offset = "0x284F550", VA = "0x284F550")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
