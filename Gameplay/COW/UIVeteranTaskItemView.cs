using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A64")]
public class UIVeteranTaskItemView : UIBaseView
{
	[Token(Token = "0x4018BE0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BGSpriteLight;

	[Token(Token = "0x4018BE1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BGSpriteDark;

	[Token(Token = "0x4018BE2")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid Grid;

	[Token(Token = "0x4018BE3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton Operation;

	[Token(Token = "0x4018BE4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ClaimedState;

	[Token(Token = "0x4018BE5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject UnfinishedState;

	[Token(Token = "0x4018BE6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject FinishedState;

	[Token(Token = "0x4018BE7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Title;

	[Token(Token = "0x4018BE8")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ProgressTips;

	[Token(Token = "0x4018BE9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Desc;

	[Token(Token = "0x60172D2")]
	[Address(RVA = "0x2CCA3CC", Offset = "0x2CCA3CC", VA = "0x2CCA3CC")]
	public UIVeteranTaskItemView()
	{
	}

	[Token(Token = "0x60172D3")]
	[Address(RVA = "0x2CCA3D4", Offset = "0x2CCA3D4", VA = "0x2CCA3D4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172D4")]
	[Address(RVA = "0x2CCA8A0", Offset = "0x2CCA8A0", VA = "0x2CCA8A0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
