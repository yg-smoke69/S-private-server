using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003897")]
public class UIMatchResultRewardSingersBItemView : UIBaseView
{
	[Token(Token = "0x401761F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RewardCon;

	[Token(Token = "0x4017620")]
	[FieldOffset(Offset = "0x18")]
	public GameObject RewardItem;

	[Token(Token = "0x4017621")]
	[FieldOffset(Offset = "0x1C")]
	public Animator VFX_Main;

	[Token(Token = "0x6016D70")]
	[Address(RVA = "0x281E920", Offset = "0x281E920", VA = "0x281E920")]
	public UIMatchResultRewardSingersBItemView()
	{
	}

	[Token(Token = "0x6016D71")]
	[Address(RVA = "0x281E928", Offset = "0x281E928", VA = "0x281E928", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D72")]
	[Address(RVA = "0x281EB78", Offset = "0x281EB78", VA = "0x281EB78")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
