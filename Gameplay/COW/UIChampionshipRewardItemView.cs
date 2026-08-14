using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200341A")]
public class UIChampionshipRewardItemView : UIBaseView
{
	[Token(Token = "0x40141EB")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView Reward;

	[Token(Token = "0x40141EC")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RewardBtn;

	[Token(Token = "0x6016002")]
	[Address(RVA = "0x283A91C", Offset = "0x283A91C", VA = "0x283A91C")]
	public UIChampionshipRewardItemView()
	{
	}

	[Token(Token = "0x6016003")]
	[Address(RVA = "0x283A924", Offset = "0x283A924", VA = "0x283A924", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016004")]
	[Address(RVA = "0x283AB2C", Offset = "0x283AB2C", VA = "0x283AB2C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
