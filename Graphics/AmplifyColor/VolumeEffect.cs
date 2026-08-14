using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyColor;

[Serializable]
[Token(Token = "0x2003B05")]
public class VolumeEffect
{
	[Token(Token = "0x4019242")]
	[FieldOffset(Offset = "0x8")]
	public PostEffectManagerBase gameObject;

	[Token(Token = "0x4019243")]
	[FieldOffset(Offset = "0xC")]
	public List<VolumeEffectComponent> components;

	[Token(Token = "0x4019244")]
	[FieldOffset(Offset = "0x0")]
	private static Func<Component, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4019245")]
	[FieldOffset(Offset = "0x4")]
	private static Func<VolumeEffectComponent, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60176C2")]
	[Address(RVA = "0x2EC3BB4", Offset = "0x2EC3BB4", VA = "0x2EC3BB4")]
	public VolumeEffect(PostEffectManagerBase effect)
	{
	}

	[Token(Token = "0x60176C3")]
	[Address(RVA = "0x2EC3C48", Offset = "0x2EC3C48", VA = "0x2EC3C48")]
	public static VolumeEffect BlendValuesToVolumeEffect(VolumeEffectFlags flags, VolumeEffect volume1, VolumeEffect volume2, float blend)
	{
		return null;
	}

	[Token(Token = "0x60176C4")]
	[Address(RVA = "0x2EC4B5C", Offset = "0x2EC4B5C", VA = "0x2EC4B5C")]
	public VolumeEffectComponent AddComponent(Component c, VolumeEffectComponentFlags compFlags)
	{
		return null;
	}

	[Token(Token = "0x60176C5")]
	[Address(RVA = "0x2EC53FC", Offset = "0x2EC53FC", VA = "0x2EC53FC")]
	public void RemoveEffectComponent(VolumeEffectComponent comp)
	{
	}

	[Token(Token = "0x60176C6")]
	[Address(RVA = "0x2EC547C", Offset = "0x2EC547C", VA = "0x2EC547C")]
	public void UpdateVolume()
	{
	}

	[Token(Token = "0x60176C7")]
	[Address(RVA = "0x2EC56DC", Offset = "0x2EC56DC", VA = "0x2EC56DC")]
	public void SetValues(PostEffectManagerBase targetColor)
	{
	}

	[Token(Token = "0x60176C8")]
	[Address(RVA = "0x2EC6098", Offset = "0x2EC6098", VA = "0x2EC6098")]
	public void BlendValues(PostEffectManagerBase targetColor, VolumeEffect other, float blendAmount)
	{
	}

	[Token(Token = "0x60176C9")]
	[Address(RVA = "0x2EC47E8", Offset = "0x2EC47E8", VA = "0x2EC47E8")]
	public VolumeEffectComponent FindEffectComponent(string compName)
	{
		return null;
	}

	[Token(Token = "0x60176CA")]
	[Address(RVA = "0x2EC69A4", Offset = "0x2EC69A4", VA = "0x2EC69A4")]
	public static Component[] ListAcceptableComponents(PostEffectManagerBase go)
	{
		return null;
	}

	[Token(Token = "0x60176CB")]
	[Address(RVA = "0x2EC6B74", Offset = "0x2EC6B74", VA = "0x2EC6B74")]
	public string[] GetComponentNames()
	{
		return null;
	}

	[Token(Token = "0x60176CC")]
	[Address(RVA = "0x2EC6C74", Offset = "0x2EC6C74", VA = "0x2EC6C74")]
	private static bool _003CListAcceptableComponents_003Em__0(Component comp)
	{
		return default(bool);
	}

	[Token(Token = "0x60176CD")]
	[Address(RVA = "0x2EC6E2C", Offset = "0x2EC6E2C", VA = "0x2EC6E2C")]
	private static string _003CGetComponentNames_003Em__1(VolumeEffectComponent r)
	{
		return null;
	}
}
