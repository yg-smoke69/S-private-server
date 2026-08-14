using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036AF")]
public class UIHudMatchResultItemRewardView : UIBaseView
{
	[Token(Token = "0x4016071")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SkipMask;

	[Token(Token = "0x4016072")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid DebrisRewardGrid;

	[Token(Token = "0x4016073")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid CommonRewardGrid;

	[Token(Token = "0x60167BA")]
	[Address(RVA = "0x19BA408", Offset = "0x19BA408", VA = "0x19BA408")]
	public UIHudMatchResultItemRewardView()
	{
	}

	[Token(Token = "0x60167BB")]
	[Address(RVA = "0x19BA410", Offset = "0x19BA410", VA = "0x19BA410", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167BC")]
	[Address(RVA = "0x19BA678", Offset = "0x19BA678", VA = "0x19BA678")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
