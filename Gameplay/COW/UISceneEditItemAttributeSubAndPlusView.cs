using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003993")]
public class UISceneEditItemAttributeSubAndPlusView : UIBaseView
{
	[Token(Token = "0x401820B")]
	[FieldOffset(Offset = "0x14")]
	public UIButton PlusBtn;

	[Token(Token = "0x401820C")]
	[FieldOffset(Offset = "0x18")]
	public UISprite PlusSpriteOne;

	[Token(Token = "0x401820D")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite PlusSpriteTwo;

	[Token(Token = "0x401820E")]
	[FieldOffset(Offset = "0x20")]
	public UIButton SubBtn;

	[Token(Token = "0x401820F")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SubSprite;

	[Token(Token = "0x4018210")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CountLabel;

	[Token(Token = "0x4018211")]
	[FieldOffset(Offset = "0x2C")]
	public UIInput Input;

	[Token(Token = "0x4018212")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ParamNameLabel;

	[Token(Token = "0x6017060")]
	[Address(RVA = "0x2DA3D20", Offset = "0x2DA3D20", VA = "0x2DA3D20")]
	public UISceneEditItemAttributeSubAndPlusView()
	{
	}

	[Token(Token = "0x6017061")]
	[Address(RVA = "0x2DA3D28", Offset = "0x2DA3D28", VA = "0x2DA3D28", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017062")]
	[Address(RVA = "0x2DA4170", Offset = "0x2DA4170", VA = "0x2DA4170")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
