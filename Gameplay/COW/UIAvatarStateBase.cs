using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FDF")]
public class UIAvatarStateBase
{
	[Token(Token = "0x400C865")]
	[FieldOffset(Offset = "0x8")]
	public uint AvatarID;

	[Token(Token = "0x400C866")]
	[FieldOffset(Offset = "0xC")]
	public uint CollectionId;

	[Token(Token = "0x400C867")]
	[FieldOffset(Offset = "0x10")]
	public float SkinColorNormed;

	[Token(Token = "0x400C868")]
	[FieldOffset(Offset = "0x14")]
	public bool IsLocalAvatar;

	[Token(Token = "0x400C869")]
	[FieldOffset(Offset = "0x15")]
	public bool UseLobbyRecipes;

	[Token(Token = "0x400C86A")]
	[FieldOffset(Offset = "0x18")]
	public List<uint> Clothes;

	[Token(Token = "0x400C86B")]
	[FieldOffset(Offset = "0x1C")]
	public int ClothesNotReadyCnt;

	[Token(Token = "0x400C86C")]
	[FieldOffset(Offset = "0x20")]
	public bool PlayTriggerEffect;

	[Token(Token = "0x400C86D")]
	[FieldOffset(Offset = "0x21")]
	public bool HideSkinRendererUntilNotDirty;

	[Token(Token = "0x400C86E")]
	[FieldOffset(Offset = "0x24")]
	public Action<bool> AvatarInitedCallbackOnce;

	[Token(Token = "0x400C86F")]
	[FieldOffset(Offset = "0x28")]
	public Action<UIStatedAvatar> AvatarUpdateCallbackOnce;

	[Token(Token = "0x400C870")]
	[FieldOffset(Offset = "0x2C")]
	public bool IsSkipSetAnimator;

	[Token(Token = "0x600A082")]
	[Address(RVA = "0x2FA1CD4", Offset = "0x2FA1CD4", VA = "0x2FA1CD4")]
	public UIAvatarStateBase()
	{
	}

	[Token(Token = "0x600A083")]
	[Address(RVA = "0x2F89F70", Offset = "0x2F89F70", VA = "0x2F89F70")]
	public void SetClothes(IEnumerable<uint> cs)
	{
	}

	[Token(Token = "0x600A084")]
	[Address(RVA = "0x2FA1E58", Offset = "0x2FA1E58", VA = "0x2FA1E58")]
	public void CloneTo(UIAvatarStateBase s)
	{
	}

	[Token(Token = "0x600A085")]
	[Address(RVA = "0x2FA1FEC", Offset = "0x2FA1FEC", VA = "0x2FA1FEC", Slot = "4")]
	public virtual void ResetOnceValues()
	{
	}
}
