using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003921")]
public class UIProfileCreditView : UIBaseView
{
	[Token(Token = "0x4017C70")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnHelp;

	[Token(Token = "0x4017C71")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelCreditScore;

	[Token(Token = "0x4017C72")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelCreditRank;

	[Token(Token = "0x4017C73")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelCreditEvaluation;

	[Token(Token = "0x4017C74")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnCreditHistory;

	[Token(Token = "0x4017C75")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid RewardGrid;

	[Token(Token = "0x4017C76")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnRewardTip;

	[Token(Token = "0x4017C77")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Star;

	[Token(Token = "0x6016F0A")]
	[Address(RVA = "0x16D36F0", Offset = "0x16D36F0", VA = "0x16D36F0")]
	public UIProfileCreditView()
	{
	}

	[Token(Token = "0x6016F0B")]
	[Address(RVA = "0x16D36F8", Offset = "0x16D36F8", VA = "0x16D36F8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F0C")]
	[Address(RVA = "0x16D3B34", Offset = "0x16D3B34", VA = "0x16D3B34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
