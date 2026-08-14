using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CB0")]
public class OverlayData : _Attribute
{
	[Token(Token = "0x4019C77")]
	[FieldOffset(Offset = "0x8")]
	public OverlayDataAsset asset;

	[Token(Token = "0x4019C78")]
	[FieldOffset(Offset = "0xC")]
	public Rect rect;

	[NonSerialized]
	[Token(Token = "0x4019C79")]
	[FieldOffset(Offset = "0x1C")]
	public OverlayColorData colorData;

	[NonSerialized]
	[Token(Token = "0x4019C7A")]
	[FieldOffset(Offset = "0x20")]
	public byte additiveOrder;

	[Token(Token = "0x170019AD")]
	public string overlayName
	{
		[Token(Token = "0x601846A")]
		[Address(RVA = "0x2D51C08", Offset = "0x2D51C08", VA = "0x2D51C08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6018468")]
	[Address(RVA = "0x2D51990", Offset = "0x2D51990", VA = "0x2D51990")]
	protected OverlayData()
	{
	}

	[Token(Token = "0x6018469")]
	[Address(RVA = "0x2D51998", Offset = "0x2D51998", VA = "0x2D51998")]
	public OverlayData(OverlayDataAsset asset)
	{
	}

	[Token(Token = "0x601846B")]
	[Address(RVA = "0x2D51C2C", Offset = "0x2D51C2C", VA = "0x2D51C2C")]
	public OverlayData Duplicate()
	{
		return null;
	}

	[Token(Token = "0x601846C")]
	[Address(RVA = "0x2D51CFC", Offset = "0x2D51CFC", VA = "0x2D51CFC")]
	public void SetColor(int channel, Color32 color)
	{
	}

	[Token(Token = "0x601846D")]
	[Address(RVA = "0x2D51DBC", Offset = "0x2D51DBC", VA = "0x2D51DBC")]
	public Color32 GetColor(int channel)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color32);
	}

	[Token(Token = "0x601846E")]
	[Address(RVA = "0x2D51E3C", Offset = "0x2D51E3C", VA = "0x2D51E3C")]
	public Color32 GetAdditive(int channel)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color32);
	}

	[Token(Token = "0x601846F")]
	[Address(RVA = "0x2D51EBC", Offset = "0x2D51EBC", VA = "0x2D51EBC")]
	public void SetAdditive(int channel, Color32 color)
	{
	}

	[Token(Token = "0x6018470")]
	[Address(RVA = "0x2D51F4C", Offset = "0x2D51F4C", VA = "0x2D51F4C")]
	public void CopyColors(OverlayData overlay)
	{
	}

	[Token(Token = "0x6018471")]
	[Address(RVA = "0x2D51D8C", Offset = "0x2D51D8C", VA = "0x2D51D8C")]
	public void EnsureChannels(int channels)
	{
	}

	[Token(Token = "0x6018472")]
	[Address(RVA = "0x2D51F90", Offset = "0x2D51F90", VA = "0x2D51F90")]
	public static bool Equivalent(OverlayData overlay1, OverlayData overlay2)
	{
		return default(bool);
	}

	[Token(Token = "0x6018473")]
	[Address(RVA = "0x2D52168", Offset = "0x2D52168", VA = "0x2D52168")]
	public static bool EquivalentAssetAndUse(OverlayData overlay1, OverlayData overlay2)
	{
		return default(bool);
	}

	[Token(Token = "0x6018474")]
	[Address(RVA = "0x2D520CC", Offset = "0x2D520CC", VA = "0x2D520CC")]
	public static implicit operator bool(OverlayData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6018475")]
	[Address(RVA = "0x2D523AC", Offset = "0x2D523AC", VA = "0x2D523AC", Slot = "4")]
	public bool Equals(OverlayData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6018476")]
	[Address(RVA = "0x2D523F4", Offset = "0x2D523F4", VA = "0x2D523F4", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6018477")]
	[Address(RVA = "0x2D523B0", Offset = "0x2D523B0", VA = "0x2D523B0")]
	public static bool operator ==(OverlayData overlay, OverlayData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6018478")]
	[Address(RVA = "0x2D52494", Offset = "0x2D52494", VA = "0x2D52494")]
	public static bool operator !=(OverlayData overlay, OverlayData obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6018479")]
	[Address(RVA = "0x2D524D8", Offset = "0x2D524D8", VA = "0x2D524D8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
