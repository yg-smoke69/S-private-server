using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A12")]
public class UITurntableSignInItemView : UIBaseView
{
	[Token(Token = "0x4018843")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView BaseItemView;

	[Token(Token = "0x4018844")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018845")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Rare;

	[Token(Token = "0x4018846")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Light;

	[Token(Token = "0x4018847")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Count;

	[Token(Token = "0x4018848")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Sign;

	[Token(Token = "0x4018849")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Time;

	[Token(Token = "0x401884A")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BigRewardEffect;

	[Token(Token = "0x401884B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GetRewardEffect;

	[Token(Token = "0x401884C")]
	[FieldOffset(Offset = "0x38")]
	public UISprite Sprite_Debris;

	[Token(Token = "0x60171DC")]
	[Address(RVA = "0x1C30204", Offset = "0x1C30204", VA = "0x1C30204")]
	public UITurntableSignInItemView()
	{
	}

	[Token(Token = "0x60171DD")]
	[Address(RVA = "0x1C3020C", Offset = "0x1C3020C", VA = "0x1C3020C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171DE")]
	[Address(RVA = "0x1C306F0", Offset = "0x1C306F0", VA = "0x1C306F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
