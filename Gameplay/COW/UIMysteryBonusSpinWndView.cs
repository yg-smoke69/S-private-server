using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038B9")]
public class UIMysteryBonusSpinWndView : UIBaseView
{
	[Token(Token = "0x4017779")]
	[FieldOffset(Offset = "0x14")]
	public UIMysteryBonusSpinWndAnimationConfig UIMysteryBonusSpinWnd;

	[Token(Token = "0x401777A")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Mask;

	[Token(Token = "0x401777B")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton StopBtn;

	[Token(Token = "0x401777C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton CofirmBtn;

	[Token(Token = "0x401777D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel SpinTips;

	[Token(Token = "0x401777E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TopupTips;

	[Token(Token = "0x401777F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EffectNum;

	[Token(Token = "0x4017780")]
	[FieldOffset(Offset = "0x30")]
	public MeshRenderer number_tens;

	[Token(Token = "0x4017781")]
	[FieldOffset(Offset = "0x34")]
	public MeshRenderer number_ones;

	[Token(Token = "0x4017782")]
	[FieldOffset(Offset = "0x38")]
	public MeshRenderer number_hunderds;

	[Token(Token = "0x4017783")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Effect_End;

	[Token(Token = "0x6016DD6")]
	[Address(RVA = "0x1955EB8", Offset = "0x1955EB8", VA = "0x1955EB8")]
	public UIMysteryBonusSpinWndView()
	{
	}

	[Token(Token = "0x6016DD7")]
	[Address(RVA = "0x1955EC0", Offset = "0x1955EC0", VA = "0x1955EC0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DD8")]
	[Address(RVA = "0x1956410", Offset = "0x1956410", VA = "0x1956410")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
