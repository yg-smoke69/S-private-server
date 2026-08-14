using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003810")]
public class UILadderMatchSeasonInfoMissionItemView : UIBaseView
{
	[Token(Token = "0x4016CA2")]
	[FieldOffset(Offset = "0x14")]
	public UILabel MissionDescription;

	[Token(Token = "0x4016CA3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject MissionReward;

	[Token(Token = "0x4016CA4")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ItemBG;

	[Token(Token = "0x4016CA5")]
	[FieldOffset(Offset = "0x20")]
	public UISprite ScoreSprite;

	[Token(Token = "0x4016CA6")]
	[FieldOffset(Offset = "0x24")]
	public UISprite FinishedBg;

	[Token(Token = "0x4016CA7")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ScoreCount;

	[Token(Token = "0x4016CA8")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ScoreAwardContainer;

	[Token(Token = "0x6016BDB")]
	[Address(RVA = "0x22C8D00", Offset = "0x22C8D00", VA = "0x22C8D00")]
	public UILadderMatchSeasonInfoMissionItemView()
	{
	}

	[Token(Token = "0x6016BDC")]
	[Address(RVA = "0x22C8D08", Offset = "0x22C8D08", VA = "0x22C8D08", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BDD")]
	[Address(RVA = "0x22C90CC", Offset = "0x22C90CC", VA = "0x22C90CC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
