using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CC3")]
public sealed class UIVariableBindButtonStateBool : UIVariableBindBool
{
	[Token(Token = "0x40067AF")]
	[FieldOffset(Offset = "0x28")]
	public Sprite onNormal;

	[Token(Token = "0x40067B0")]
	[FieldOffset(Offset = "0x2C")]
	public Sprite onPressed;

	[Token(Token = "0x40067B1")]
	[FieldOffset(Offset = "0x30")]
	public Sprite offNormal;

	[Token(Token = "0x40067B2")]
	[FieldOffset(Offset = "0x34")]
	public Sprite offPressed;

	[Token(Token = "0x40067B3")]
	[FieldOffset(Offset = "0x38")]
	public string normalSprite;

	[Token(Token = "0x40067B4")]
	[FieldOffset(Offset = "0x3C")]
	public string pressedSprite;

	[Token(Token = "0x40067B5")]
	[FieldOffset(Offset = "0x40")]
	public string normalSpriteIfFalse;

	[Token(Token = "0x40067B6")]
	[FieldOffset(Offset = "0x44")]
	public string pressedSpriteIfFalse;

	[Token(Token = "0x40067B7")]
	[FieldOffset(Offset = "0x48")]
	private UIButton selectable;

	[Token(Token = "0x600612E")]
	[Address(RVA = "0x315EE44", Offset = "0x315EE44", VA = "0x315EE44")]
	public UIVariableBindButtonStateBool()
	{
	}

	[Token(Token = "0x600612F")]
	[Address(RVA = "0x315EE48", Offset = "0x315EE48", VA = "0x315EE48", Slot = "10")]
	protected override void OnValueChanged()
	{
	}
}
