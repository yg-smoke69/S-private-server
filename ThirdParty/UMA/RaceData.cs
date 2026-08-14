using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CA6")]
public class RaceData : ScriptableObject, _Attribute
{
	[Serializable]
	[Token(Token = "0x2003CA7")]
	public class RaceThumbnails
	{
		[Serializable]
		[Token(Token = "0x2003CA8")]
		public class WardrobeSlotThumb
		{
			[Token(Token = "0x4019C5E")]
			[FieldOffset(Offset = "0x8")]
			public string thumbIsFor;

			[Token(Token = "0x4019C5F")]
			[FieldOffset(Offset = "0xC")]
			public Sprite thumb;

			[Token(Token = "0x601842E")]
			[Address(RVA = "0x2D53F8C", Offset = "0x2D53F8C", VA = "0x2D53F8C")]
			public WardrobeSlotThumb()
			{
			}
		}

		[Token(Token = "0x4019C5B")]
		[FieldOffset(Offset = "0x8")]
		public Sprite fullThumb;

		[Token(Token = "0x4019C5C")]
		[FieldOffset(Offset = "0xC")]
		public Sprite faceThumb;

		[Token(Token = "0x4019C5D")]
		[FieldOffset(Offset = "0x10")]
		private List<WardrobeSlotThumb> wardrobeSlotThumbs;

		[Token(Token = "0x601842C")]
		[Address(RVA = "0x2D53A24", Offset = "0x2D53A24", VA = "0x2D53A24")]
		public RaceThumbnails()
		{
		}

		[Token(Token = "0x601842D")]
		[Address(RVA = "0x2D53AB0", Offset = "0x2D53AB0", VA = "0x2D53AB0")]
		public Sprite GetThumbFor(string thumbToGet = "")
		{
			return null;
		}
	}

	[Token(Token = "0x2003CA9")]
	public enum UMATarget
	{
		[Token(Token = "0x4019C61")]
		Humanoid,
		[Token(Token = "0x4019C62")]
		Generic
	}

	[Token(Token = "0x4019C4E")]
	[FieldOffset(Offset = "0xC")]
	public UMARecipeBase baseRaceRecipe;

	[Token(Token = "0x4019C4F")]
	[FieldOffset(Offset = "0x10")]
	public int baseOverlayLimitSizes;

	[Token(Token = "0x4019C50")]
	[FieldOffset(Offset = "0x14")]
	public List<string> wardrobeSlots;

	[Token(Token = "0x4019C51")]
	[FieldOffset(Offset = "0x18")]
	public List<int> overlayLimitSizes;

	[Token(Token = "0x4019C52")]
	[FieldOffset(Offset = "0x1C")]
	public List<string> backwardsCompatibleWith;

	[Token(Token = "0x4019C53")]
	[FieldOffset(Offset = "0x20")]
	public RaceThumbnails raceThumbnails;

	[Token(Token = "0x4019C54")]
	[FieldOffset(Offset = "0x24")]
	public string raceName;

	[Token(Token = "0x4019C55")]
	[FieldOffset(Offset = "0x28")]
	public UmaTPose TPose;

	[Token(Token = "0x4019C56")]
	[FieldOffset(Offset = "0x2C")]
	public UMATarget umaTarget;

	[Token(Token = "0x4019C57")]
	[FieldOffset(Offset = "0x30")]
	public string genericRootMotionTransformName;

	[Token(Token = "0x4019C58")]
	[FieldOffset(Offset = "0x34")]
	public float raceHeight;

	[Token(Token = "0x4019C59")]
	[FieldOffset(Offset = "0x38")]
	public float raceRadius;

	[Token(Token = "0x4019C5A")]
	[FieldOffset(Offset = "0x3C")]
	public float raceMass;

	[Token(Token = "0x6018424")]
	[Address(RVA = "0x2D52F60", Offset = "0x2D52F60", VA = "0x2D52F60")]
	public RaceData()
	{
	}

	[Token(Token = "0x6018425")]
	[Address(RVA = "0x2D53260", Offset = "0x2D53260", VA = "0x2D53260")]
	public void AddDefaultWardrobeSlots(bool forceOverride = false)
	{
	}

	[Token(Token = "0x6018426")]
	[Address(RVA = "0x2D53544", Offset = "0x2D53544", VA = "0x2D53544")]
	public bool ValidateWardrobeSlots(bool setToDefault = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6018427")]
	[Address(RVA = "0x2D53624", Offset = "0x2D53624", VA = "0x2D53624")]
	public bool findBackwardsCompatibleWith(List<string> compatibleStrings)
	{
		return default(bool);
	}

	[Token(Token = "0x6018428")]
	[Address(RVA = "0x2D537AC", Offset = "0x2D537AC", VA = "0x2D537AC")]
	public int GetSlotLimitSize(string s)
	{
		return default(int);
	}

	[Token(Token = "0x6018429")]
	[Address(RVA = "0x2D53924", Offset = "0x2D53924", VA = "0x2D53924", Slot = "4")]
	public string GetAssetName()
	{
		return null;
	}

	[Token(Token = "0x601842A")]
	[Address(RVA = "0x2D5392C", Offset = "0x2D5392C", VA = "0x2D5392C", Slot = "5")]
	public int GetNameHash()
	{
		return default(int);
	}

	[Token(Token = "0x601842B")]
	[Address(RVA = "0x2D53934", Offset = "0x2D53934", VA = "0x2D53934")]
	public bool Validate()
	{
		return default(bool);
	}
}
