using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyColor;

[Serializable]
[Token(Token = "0x2003B0B")]
public class VolumeEffectFlags
{
	[Token(Token = "0x2003B0C")]
	private sealed class _003CAddComponent_003Ec__AnonStorey0
	{
		[Token(Token = "0x4019255")]
		[FieldOffset(Offset = "0x8")]
		internal Component c;

		[Token(Token = "0x60176EC")]
		[Address(RVA = "0x2EC91C4", Offset = "0x2EC91C4", VA = "0x2EC91C4")]
		public _003CAddComponent_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60176ED")]
		[Address(RVA = "0x2EC9B94", Offset = "0x2EC9B94", VA = "0x2EC9B94")]
		internal bool _003C_003Em__0(VolumeEffectComponentFlags s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003B0D")]
	private sealed class _003CUpdateFlags_003Ec__AnonStorey1
	{
		[Token(Token = "0x4019256")]
		[FieldOffset(Offset = "0x8")]
		internal VolumeEffectComponent comp;

		[Token(Token = "0x60176EE")]
		[Address(RVA = "0x2EC9494", Offset = "0x2EC9494", VA = "0x2EC9494")]
		public _003CUpdateFlags_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60176EF")]
		[Address(RVA = "0x2EC9C7C", Offset = "0x2EC9C7C", VA = "0x2EC9C7C")]
		internal bool _003C_003Em__0(VolumeEffectComponentFlags s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4019252")]
	[FieldOffset(Offset = "0x8")]
	public List<VolumeEffectComponentFlags> components;

	[Token(Token = "0x4019253")]
	[FieldOffset(Offset = "0x0")]
	private static Func<VolumeEffectComponentFlags, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4019254")]
	[FieldOffset(Offset = "0x4")]
	private static Func<VolumeEffectComponentFlags, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60176E3")]
	[Address(RVA = "0x2EC8FD8", Offset = "0x2EC8FD8", VA = "0x2EC8FD8")]
	public VolumeEffectFlags()
	{
	}

	[Token(Token = "0x60176E4")]
	[Address(RVA = "0x2EC9064", Offset = "0x2EC9064", VA = "0x2EC9064")]
	public void AddComponent(Component c)
	{
	}

	[Token(Token = "0x60176E5")]
	[Address(RVA = "0x2EC91CC", Offset = "0x2EC91CC", VA = "0x2EC91CC")]
	public void UpdateFlags(VolumeEffect effectVol)
	{
	}

	[Token(Token = "0x60176E6")]
	[Address(RVA = "0x2EC949C", Offset = "0x2EC949C", VA = "0x2EC949C")]
	public static void UpdateCamFlags(PostEffectManagerBase[] effects, AmplifyColorVolumeBase[] volumes)
	{
	}

	[Token(Token = "0x60176E7")]
	[Address(RVA = "0x2EC962C", Offset = "0x2EC962C", VA = "0x2EC962C")]
	public VolumeEffect GenerateEffectData(PostEffectManagerBase go)
	{
		return null;
	}

	[Token(Token = "0x60176E8")]
	[Address(RVA = "0x2EC984C", Offset = "0x2EC984C", VA = "0x2EC984C")]
	public VolumeEffectComponentFlags FindComponentFlags(string compName)
	{
		return null;
	}

	[Token(Token = "0x60176E9")]
	[Address(RVA = "0x2EC99A8", Offset = "0x2EC99A8", VA = "0x2EC99A8")]
	public string[] GetComponentNames()
	{
		return null;
	}

	[Token(Token = "0x60176EA")]
	[Address(RVA = "0x2EC9B4C", Offset = "0x2EC9B4C", VA = "0x2EC9B4C")]
	private static bool _003CGetComponentNames_003Em__0(VolumeEffectComponentFlags r)
	{
		return default(bool);
	}

	[Token(Token = "0x60176EB")]
	[Address(RVA = "0x2EC9B70", Offset = "0x2EC9B70", VA = "0x2EC9B70")]
	private static string _003CGetComponentNames_003Em__1(VolumeEffectComponentFlags r)
	{
		return null;
	}
}
