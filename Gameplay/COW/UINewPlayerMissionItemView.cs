using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038C3")]
public class UINewPlayerMissionItemView : UIBaseView
{
	[Token(Token = "0x401784A")]
	[FieldOffset(Offset = "0x14")]
	public Transform MissionRewardIcon;

	[Token(Token = "0x401784B")]
	[FieldOffset(Offset = "0x18")]
	public UILabel MissonProgress;

	[Token(Token = "0x401784C")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel MissionDescription;

	[Token(Token = "0x401784D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel MissionRewardLabel;

	[Token(Token = "0x401784E")]
	[FieldOffset(Offset = "0x24")]
	public UIButton MissionRewardButton;

	[Token(Token = "0x401784F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MissionPendingButton;

	[Token(Token = "0x4017850")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject MissionGotoButton;

	[Token(Token = "0x4017851")]
	[FieldOffset(Offset = "0x30")]
	public GameObject MissionClaimedIcon;

	[Token(Token = "0x4017852")]
	[FieldOffset(Offset = "0x34")]
	public GameObject MissionLockedButton;

	[Token(Token = "0x4017853")]
	[FieldOffset(Offset = "0x38")]
	public Animation main;

	[Token(Token = "0x6016DF4")]
	[Address(RVA = "0x27ACAB0", Offset = "0x27ACAB0", VA = "0x27ACAB0")]
	public UINewPlayerMissionItemView()
	{
	}

	[Token(Token = "0x6016DF5")]
	[Address(RVA = "0x27ACAB8", Offset = "0x27ACAB8", VA = "0x27ACAB8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DF6")]
	[Address(RVA = "0x27ACF68", Offset = "0x27ACF68", VA = "0x27ACF68")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
