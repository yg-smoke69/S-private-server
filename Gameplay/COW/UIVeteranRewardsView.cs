using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A60")]
public class UIVeteranRewardsView : UIBaseView
{
	[Token(Token = "0x4018BB5")]
	[FieldOffset(Offset = "0x14")]
	public Animation main;

	[Token(Token = "0x4018BB6")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture VeteranBG;

	[Token(Token = "0x4018BB7")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RewardsTitle;

	[Token(Token = "0x4018BB8")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClose;

	[Token(Token = "0x4018BB9")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid NormalDaysGridTop;

	[Token(Token = "0x4018BBA")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid NormalDaysGridBottom;

	[Token(Token = "0x4018BBB")]
	[FieldOffset(Offset = "0x2C")]
	public Transform BigDayContainer;

	[Token(Token = "0x60172C6")]
	[Address(RVA = "0x2CC13AC", Offset = "0x2CC13AC", VA = "0x2CC13AC")]
	public UIVeteranRewardsView()
	{
	}

	[Token(Token = "0x60172C7")]
	[Address(RVA = "0x2CC13B4", Offset = "0x2CC13B4", VA = "0x2CC13B4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172C8")]
	[Address(RVA = "0x2CC1774", Offset = "0x2CC1774", VA = "0x2CC1774")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
