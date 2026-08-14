using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200399E")]
public class UISceneEditUGCRankRewardItemView : UIBaseView
{
	[Token(Token = "0x4018290")]
	[FieldOffset(Offset = "0x14")]
	public UISprite RankIcon;

	[Token(Token = "0x4018291")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RankName;

	[Token(Token = "0x4018292")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid RewardGot;

	[Token(Token = "0x4018293")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid RewardNormal;

	[Token(Token = "0x4018294")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RewardDes;

	[Token(Token = "0x4018295")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RewardDesLabel;

	[Token(Token = "0x4018296")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ProgreessBarContainer;

	[Token(Token = "0x6017081")]
	[Address(RVA = "0x1A3E788", Offset = "0x1A3E788", VA = "0x1A3E788")]
	public UISceneEditUGCRankRewardItemView()
	{
	}

	[Token(Token = "0x6017082")]
	[Address(RVA = "0x1A3E790", Offset = "0x1A3E790", VA = "0x1A3E790", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017083")]
	[Address(RVA = "0x1A3EB60", Offset = "0x1A3EB60", VA = "0x1A3EB60")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
