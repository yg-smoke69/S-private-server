using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyColor;

[Serializable]
[Token(Token = "0x2003B03")]
public class VolumeEffectComponent
{
	[Token(Token = "0x2003B04")]
	private sealed class _003CUpdateComponent_003Ec__AnonStorey0
	{
		[Token(Token = "0x4019241")]
		[FieldOffset(Offset = "0x8")]
		internal VolumeEffectFieldFlags fieldFlags;

		[Token(Token = "0x60176C0")]
		[Address(RVA = "0x2EC7380", Offset = "0x2EC7380", VA = "0x2EC7380")]
		public _003CUpdateComponent_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60176C1")]
		[Address(RVA = "0x2EC76AC", Offset = "0x2EC76AC", VA = "0x2EC76AC")]
		internal bool _003C_003Em__0(VolumeEffectField s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401923D")]
	[FieldOffset(Offset = "0x8")]
	public string componentName;

	[Token(Token = "0x401923E")]
	[FieldOffset(Offset = "0xC")]
	public List<VolumeEffectField> fields;

	[Token(Token = "0x401923F")]
	[FieldOffset(Offset = "0x0")]
	private static Func<FieldInfo, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4019240")]
	[FieldOffset(Offset = "0x4")]
	private static Func<VolumeEffectField, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x60176B5")]
	[Address(RVA = "0x2EC4944", Offset = "0x2EC4944", VA = "0x2EC4944")]
	public VolumeEffectComponent(string name)
	{
	}

	[Token(Token = "0x60176B6")]
	[Address(RVA = "0x2EC5128", Offset = "0x2EC5128", VA = "0x2EC5128")]
	public VolumeEffectComponent(Component c, VolumeEffectComponentFlags compFlags)
	{
	}

	[Token(Token = "0x60176B7")]
	[Address(RVA = "0x2EC715C", Offset = "0x2EC715C", VA = "0x2EC715C")]
	public VolumeEffectField AddField(FieldInfo pi, Component c)
	{
		return null;
	}

	[Token(Token = "0x60176B8")]
	[Address(RVA = "0x2EC7178", Offset = "0x2EC7178", VA = "0x2EC7178")]
	public VolumeEffectField AddField(FieldInfo pi, Component c, int position)
	{
		return null;
	}

	[Token(Token = "0x60176B9")]
	[Address(RVA = "0x2EC7300", Offset = "0x2EC7300", VA = "0x2EC7300")]
	public void RemoveEffectField(VolumeEffectField field)
	{
	}

	[Token(Token = "0x60176BA")]
	[Address(RVA = "0x2EC4D34", Offset = "0x2EC4D34", VA = "0x2EC4D34")]
	public void UpdateComponent(Component c, VolumeEffectComponentFlags compFlags)
	{
	}

	[Token(Token = "0x60176BB")]
	[Address(RVA = "0x2EC49D8", Offset = "0x2EC49D8", VA = "0x2EC49D8")]
	public VolumeEffectField FindEffectField(string fieldName)
	{
		return null;
	}

	[Token(Token = "0x60176BC")]
	[Address(RVA = "0x2EC7388", Offset = "0x2EC7388", VA = "0x2EC7388")]
	public static FieldInfo[] ListAcceptableFields(Component c)
	{
		return null;
	}

	[Token(Token = "0x60176BD")]
	[Address(RVA = "0x2EC7528", Offset = "0x2EC7528", VA = "0x2EC7528")]
	public string[] GetFieldNames()
	{
		return null;
	}

	[Token(Token = "0x60176BE")]
	[Address(RVA = "0x2EC7628", Offset = "0x2EC7628", VA = "0x2EC7628")]
	private static bool _003CListAcceptableFields_003Em__0(FieldInfo f)
	{
		return default(bool);
	}

	[Token(Token = "0x60176BF")]
	[Address(RVA = "0x2EC7688", Offset = "0x2EC7688", VA = "0x2EC7688")]
	private static string _003CGetFieldNames_003Em__1(VolumeEffectField r)
	{
		return null;
	}
}
