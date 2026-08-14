using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AmplifyColor;

[Serializable]
[Token(Token = "0x2003B06")]
public class VolumeEffectContainer
{
	[Token(Token = "0x4019246")]
	[FieldOffset(Offset = "0x8")]
	public List<VolumeEffect> volumes;

	[Token(Token = "0x4019247")]
	[FieldOffset(Offset = "0x0")]
	private static Func<VolumeEffect, PostEffectManagerBase> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60176CE")]
	[Address(RVA = "0x2EC85F8", Offset = "0x2EC85F8", VA = "0x2EC85F8")]
	public VolumeEffectContainer()
	{
	}

	[Token(Token = "0x60176CF")]
	[Address(RVA = "0x2EC8684", Offset = "0x2EC8684", VA = "0x2EC8684")]
	public void AddColorEffect(PostEffectManagerBase colorEffect)
	{
	}

	[Token(Token = "0x60176D0")]
	[Address(RVA = "0x2EC8A64", Offset = "0x2EC8A64", VA = "0x2EC8A64")]
	public VolumeEffect AddJustColorEffect(PostEffectManagerBase colorEffect)
	{
		return null;
	}

	[Token(Token = "0x60176D1")]
	[Address(RVA = "0x2EC8750", Offset = "0x2EC8750", VA = "0x2EC8750")]
	public VolumeEffect FindVolumeEffect(PostEffectManagerBase colorEffect)
	{
		return null;
	}

	[Token(Token = "0x60176D2")]
	[Address(RVA = "0x2EC8B08", Offset = "0x2EC8B08", VA = "0x2EC8B08")]
	public void RemoveVolumeEffect(VolumeEffect volume)
	{
	}

	[Token(Token = "0x60176D3")]
	[Address(RVA = "0x2EC8B88", Offset = "0x2EC8B88", VA = "0x2EC8B88")]
	public PostEffectManagerBase[] GetStoredEffects()
	{
		return null;
	}

	[Token(Token = "0x60176D4")]
	[Address(RVA = "0x2EC8C8C", Offset = "0x2EC8C8C", VA = "0x2EC8C8C")]
	private static PostEffectManagerBase _003CGetStoredEffects_003Em__0(VolumeEffect r)
	{
		return null;
	}
}
