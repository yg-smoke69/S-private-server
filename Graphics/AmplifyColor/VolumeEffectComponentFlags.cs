using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyColor;

[Serializable]
[Token(Token = "0x2003B08")]
public class VolumeEffectComponentFlags
{
	[Token(Token = "0x2003B09")]
	private sealed class _003CUpdateComponentFlags_003Ec__AnonStorey0
	{
		[Token(Token = "0x4019250")]
		[FieldOffset(Offset = "0x8")]
		internal VolumeEffectField field;

		[Token(Token = "0x60176DF")]
		[Address(RVA = "0x2EC7FFC", Offset = "0x2EC7FFC", VA = "0x2EC7FFC")]
		public _003CUpdateComponentFlags_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60176E0")]
		[Address(RVA = "0x2EC8474", Offset = "0x2EC8474", VA = "0x2EC8474")]
		internal bool _003C_003Em__0(VolumeEffectFieldFlags s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003B0A")]
	private sealed class _003CUpdateComponentFlags_003Ec__AnonStorey1
	{
		[Token(Token = "0x4019251")]
		[FieldOffset(Offset = "0x8")]
		internal FieldInfo pi;

		[Token(Token = "0x60176E1")]
		[Address(RVA = "0x2EC8280", Offset = "0x2EC8280", VA = "0x2EC8280")]
		public _003CUpdateComponentFlags_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60176E2")]
		[Address(RVA = "0x2EC852C", Offset = "0x2EC852C", VA = "0x2EC852C")]
		internal bool _003C_003Em__0(VolumeEffectFieldFlags s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401924B")]
	[FieldOffset(Offset = "0x8")]
	public string componentName;

	[Token(Token = "0x401924C")]
	[FieldOffset(Offset = "0xC")]
	public List<VolumeEffectFieldFlags> componentFields;

	[Token(Token = "0x401924D")]
	[FieldOffset(Offset = "0x10")]
	public bool blendFlag;

	[Token(Token = "0x401924E")]
	[FieldOffset(Offset = "0x0")]
	private static Func<VolumeEffectFieldFlags, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x401924F")]
	[FieldOffset(Offset = "0x4")]
	private static Func<VolumeEffectFieldFlags, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60176D7")]
	[Address(RVA = "0x2EC7764", Offset = "0x2EC7764", VA = "0x2EC7764")]
	public VolumeEffectComponentFlags(string name)
	{
	}

	[Token(Token = "0x60176D8")]
	[Address(RVA = "0x2EC77F8", Offset = "0x2EC77F8", VA = "0x2EC77F8")]
	public VolumeEffectComponentFlags(VolumeEffectComponent comp)
	{
	}

	[Token(Token = "0x60176D9")]
	[Address(RVA = "0x2EC7A74", Offset = "0x2EC7A74", VA = "0x2EC7A74")]
	public VolumeEffectComponentFlags(Component c)
	{
	}

	[Token(Token = "0x60176DA")]
	[Address(RVA = "0x2EC7D18", Offset = "0x2EC7D18", VA = "0x2EC7D18")]
	public void UpdateComponentFlags(VolumeEffectComponent comp)
	{
	}

	[Token(Token = "0x60176DB")]
	[Address(RVA = "0x2EC8004", Offset = "0x2EC8004", VA = "0x2EC8004")]
	public void UpdateComponentFlags(Component c)
	{
	}

	[Token(Token = "0x60176DC")]
	[Address(RVA = "0x2EC8288", Offset = "0x2EC8288", VA = "0x2EC8288")]
	public string[] GetFieldNames()
	{
		return null;
	}

	[Token(Token = "0x60176DD")]
	[Address(RVA = "0x2EC842C", Offset = "0x2EC842C", VA = "0x2EC842C")]
	private static bool _003CGetFieldNames_003Em__0(VolumeEffectFieldFlags r)
	{
		return default(bool);
	}

	[Token(Token = "0x60176DE")]
	[Address(RVA = "0x2EC8450", Offset = "0x2EC8450", VA = "0x2EC8450")]
	private static string _003CGetFieldNames_003Em__1(VolumeEffectFieldFlags r)
	{
		return null;
	}
}
