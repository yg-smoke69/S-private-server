using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039AB")]
public class UISetFriendAliasPopUpView : UIBaseView
{
	[Token(Token = "0x4018351")]
	[FieldOffset(Offset = "0x14")]
	public UILabel EmptyLabel;

	[Token(Token = "0x4018352")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CountDownState;

	[Token(Token = "0x4018353")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x4018354")]
	[FieldOffset(Offset = "0x20")]
	public UIButton CountDownBtn;

	[Token(Token = "0x4018355")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NotChangeState;

	[Token(Token = "0x4018356")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CanelBtn;

	[Token(Token = "0x4018357")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton OKtBtn;

	[Token(Token = "0x4018358")]
	[FieldOffset(Offset = "0x30")]
	public UIInput Input;

	[Token(Token = "0x60170A8")]
	[Address(RVA = "0x1A54CC0", Offset = "0x1A54CC0", VA = "0x1A54CC0")]
	public UISetFriendAliasPopUpView()
	{
	}

	[Token(Token = "0x60170A9")]
	[Address(RVA = "0x1A54CC8", Offset = "0x1A54CC8", VA = "0x1A54CC8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170AA")]
	[Address(RVA = "0x1A550F8", Offset = "0x1A550F8", VA = "0x1A550F8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
