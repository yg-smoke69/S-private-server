using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CAF")]
public class OverlayColorData : _Attribute
{
	[Token(Token = "0x4019C73")]
	public const string UNSHARED = "-";

	[Token(Token = "0x4019C74")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4019C75")]
	[FieldOffset(Offset = "0xC")]
	public Color[] channelMask;

	[Token(Token = "0x4019C76")]
	[FieldOffset(Offset = "0x10")]
	public Color[] channelAdditiveMask;

	[Token(Token = "0x170019AB")]
	public Color color
	{
		[Token(Token = "0x6018458")]
		[Address(RVA = "0x2D5054C", Offset = "0x2D5054C", VA = "0x2D5054C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Color);
		}
		[Token(Token = "0x6018459")]
		[Address(RVA = "0x2D505E4", Offset = "0x2D505E4", VA = "0x2D505E4")]
		set
		{
		}
	}

	[Token(Token = "0x170019AC")]
	public bool IsASharedColor
	{
		[Token(Token = "0x601845B")]
		[Address(RVA = "0x2D50888", Offset = "0x2D50888", VA = "0x2D50888")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6018456")]
	[Address(RVA = "0x2D5032C", Offset = "0x2D5032C", VA = "0x2D5032C")]
	public OverlayColorData()
	{
	}

	[Token(Token = "0x6018457")]
	[Address(RVA = "0x2D503B0", Offset = "0x2D503B0", VA = "0x2D503B0")]
	public OverlayColorData(int channels)
	{
	}

	[Token(Token = "0x601845A")]
	[Address(RVA = "0x2D50640", Offset = "0x2D50640", VA = "0x2D50640")]
	public OverlayColorData Duplicate()
	{
		return null;
	}

	[Token(Token = "0x601845C")]
	[Address(RVA = "0x2D50954", Offset = "0x2D50954", VA = "0x2D50954")]
	public bool HasName()
	{
		return default(bool);
	}

	[Token(Token = "0x601845D")]
	[Address(RVA = "0x2D50984", Offset = "0x2D50984", VA = "0x2D50984")]
	public static bool SameColor(Color color1, Color color2)
	{
		return default(bool);
	}

	[Token(Token = "0x601845E")]
	[Address(RVA = "0x2D50B00", Offset = "0x2D50B00", VA = "0x2D50B00")]
	public static bool DifferentColor(Color color1, Color color2)
	{
		return default(bool);
	}

	[Token(Token = "0x601845F")]
	[Address(RVA = "0x2D50C7C", Offset = "0x2D50C7C", VA = "0x2D50C7C")]
	public static implicit operator bool(OverlayColorData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6018460")]
	[Address(RVA = "0x2D50C88", Offset = "0x2D50C88", VA = "0x2D50C88", Slot = "4")]
	public bool Equals(OverlayColorData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6018461")]
	[Address(RVA = "0x2D50EBC", Offset = "0x2D50EBC", VA = "0x2D50EBC", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6018462")]
	[Address(RVA = "0x2D50C8C", Offset = "0x2D50C8C", VA = "0x2D50C8C")]
	public static bool operator ==(OverlayColorData cd1, OverlayColorData cd2)
	{
		return default(bool);
	}

	[Token(Token = "0x6018463")]
	[Address(RVA = "0x2D50F5C", Offset = "0x2D50F5C", VA = "0x2D50F5C")]
	public static bool operator !=(OverlayColorData cd1, OverlayColorData cd2)
	{
		return default(bool);
	}

	[Token(Token = "0x6018464")]
	[Address(RVA = "0x2D51184", Offset = "0x2D51184", VA = "0x2D51184", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6018465")]
	[Address(RVA = "0x2D5118C", Offset = "0x2D5118C", VA = "0x2D5118C")]
	public void EnsureChannels(int channels)
	{
	}

	[Token(Token = "0x6018466")]
	[Address(RVA = "0x2D514E0", Offset = "0x2D514E0", VA = "0x2D514E0")]
	public void AssignTo(OverlayColorData dest)
	{
	}

	[Token(Token = "0x6018467")]
	[Address(RVA = "0x2D51764", Offset = "0x2D51764", VA = "0x2D51764")]
	public void AssignFrom(OverlayColorData src)
	{
	}
}
