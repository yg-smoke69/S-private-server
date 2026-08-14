using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036D6")]
public class UIHudPDMTimeScoreInfoView : UIBaseView
{
	[Token(Token = "0x4016233")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x4016234")]
	[FieldOffset(Offset = "0x18")]
	public UILabel leftScore;

	[Token(Token = "0x4016235")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel time;

	[Token(Token = "0x4016236")]
	[FieldOffset(Offset = "0x20")]
	public UILabel rightScore;

	[Token(Token = "0x4016237")]
	[FieldOffset(Offset = "0x24")]
	public UILabel leftRank;

	[Token(Token = "0x4016238")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget GuideLeftScore;

	[Token(Token = "0x4016239")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget GuideRightScore;

	[Token(Token = "0x401623A")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget GuideScoreInfo;

	[Token(Token = "0x401623B")]
	[FieldOffset(Offset = "0x34")]
	public UILabel TargetScore;

	[Token(Token = "0x601682F")]
	[Address(RVA = "0x1838FA4", Offset = "0x1838FA4", VA = "0x1838FA4")]
	public UIHudPDMTimeScoreInfoView()
	{
	}

	[Token(Token = "0x6016830")]
	[Address(RVA = "0x1838FAC", Offset = "0x1838FAC", VA = "0x1838FAC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016831")]
	[Address(RVA = "0x1839454", Offset = "0x1839454", VA = "0x1839454")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
