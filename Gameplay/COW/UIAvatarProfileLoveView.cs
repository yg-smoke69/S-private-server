using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D4")]
public class UIAvatarProfileLoveView : UIBaseView
{
	[Token(Token = "0x4013DA9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton LoveBtn;

	[Token(Token = "0x4013DAA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject State1;

	[Token(Token = "0x4013DAB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject State2;

	[Token(Token = "0x4013DAC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject VFX_SetLove;

	[Token(Token = "0x6015F32")]
	[Address(RVA = "0x2F84C30", Offset = "0x2F84C30", VA = "0x2F84C30")]
	public UIAvatarProfileLoveView()
	{
	}

	[Token(Token = "0x6015F33")]
	[Address(RVA = "0x2F84C38", Offset = "0x2F84C38", VA = "0x2F84C38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F34")]
	[Address(RVA = "0x2F84EDC", Offset = "0x2F84EDC", VA = "0x2F84EDC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
