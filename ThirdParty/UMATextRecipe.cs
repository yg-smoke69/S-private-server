using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UMA;
using UMACharacterSystem;

[Token(Token = "0x2003C5F")]
public class UMATextRecipe : UMAPackedRecipeBase, _Attribute
{
	[Token(Token = "0x2003C60")]
	private class DCSRecipeChecker
	{
		[Token(Token = "0x4019AD1")]
		[FieldOffset(Offset = "0x8")]
		public string packedRecipeType;

		[Token(Token = "0x4019AD2")]
		[FieldOffset(Offset = "0xC")]
		public List<WardrobeSettings> wardrobeRecipesJson;

		[Token(Token = "0x4019AD3")]
		[FieldOffset(Offset = "0x10")]
		public List<WardrobeSettings> wardrobeSet;

		[Token(Token = "0x1700198F")]
		public List<WardrobeSettings> checkedWardrobeSet
		{
			[Token(Token = "0x60181BE")]
			[Address(RVA = "0x2A60C54", Offset = "0x2A60C54", VA = "0x2A60C54")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60181BD")]
		[Address(RVA = "0x2A62EAC", Offset = "0x2A62EAC", VA = "0x2A62EAC")]
		public DCSRecipeChecker()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C61")]
	public class DCSPackRecipe
	{
		[Token(Token = "0x4019AD4")]
		[FieldOffset(Offset = "0x8")]
		public string packedRecipeType;

		[Token(Token = "0x4019AD5")]
		[FieldOffset(Offset = "0xC")]
		public string name;

		[Token(Token = "0x4019AD6")]
		[FieldOffset(Offset = "0x10")]
		public string race;

		[Token(Token = "0x4019AD7")]
		[FieldOffset(Offset = "0x14")]
		public List<PackedOverlayColorDataV3> characterColors;

		[Token(Token = "0x4019AD8")]
		[FieldOffset(Offset = "0x18")]
		public List<WardrobeSettings> wardrobeSet;

		[Token(Token = "0x4019AD9")]
		[FieldOffset(Offset = "0x1C")]
		public string raceAnimatorController;

		[Token(Token = "0x4019ADA")]
		[FieldOffset(Offset = "0x20")]
		private OverlayColorData[] _sharedColors;

		[Token(Token = "0x17001990")]
		public OverlayColorData[] sharedColors
		{
			[Token(Token = "0x60181C2")]
			[Address(RVA = "0x2A62CA0", Offset = "0x2A62CA0", VA = "0x2A62CA0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60181BF")]
		[Address(RVA = "0x2A62614", Offset = "0x2A62614", VA = "0x2A62614")]
		public DCSPackRecipe()
		{
		}

		[Token(Token = "0x60181C0")]
		[Address(RVA = "0x2A62680", Offset = "0x2A62680", VA = "0x2A62680")]
		public DCSPackRecipe(DynamicCharacterAvatar dcaToSave, string recipeName, string pRecipeType, DynamicCharacterAvatar.SaveOptions saveOptions, string[] slotsToSave)
		{
		}

		[Token(Token = "0x60181C1")]
		[Address(RVA = "0x2A62AF0", Offset = "0x2A62AF0", VA = "0x2A62AF0")]
		public DCSPackRecipe(UMAPackRecipe umaPackRecipe, string recipeName = "", string pRecipeType = "Standard", [Optional] List<WardrobeSettings> wardrobeSetToSave)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C62")]
	public class DCSUniversalPackRecipe : UMAPackRecipe
	{
		[Token(Token = "0x4019ADB")]
		[FieldOffset(Offset = "0x24")]
		public List<WardrobeSettings> wardrobeSet;

		[Token(Token = "0x4019ADC")]
		[FieldOffset(Offset = "0x28")]
		public string packedRecipeType;

		[Token(Token = "0x4019ADD")]
		[FieldOffset(Offset = "0x2C")]
		private OverlayColorData[] _sharedColors;

		[Token(Token = "0x17001991")]
		public OverlayColorData[] sharedColors
		{
			[Token(Token = "0x60181C7")]
			[Address(RVA = "0x2A63110", Offset = "0x2A63110", VA = "0x2A63110")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60181C3")]
		[Address(RVA = "0x2A60394", Offset = "0x2A60394", VA = "0x2A60394")]
		public DCSUniversalPackRecipe()
		{
		}

		[Token(Token = "0x60181C4")]
		[Address(RVA = "0x2A6064C", Offset = "0x2A6064C", VA = "0x2A6064C")]
		public DCSUniversalPackRecipe(UMAPackRecipe umaPackRecipe, string pRecipeType = "Standard")
		{
		}

		[Token(Token = "0x60181C5")]
		[Address(RVA = "0x2A604D8", Offset = "0x2A604D8", VA = "0x2A604D8")]
		public DCSUniversalPackRecipe(DCSPackRecipe dcsPackRecipe)
		{
		}

		[Token(Token = "0x60181C6")]
		[Address(RVA = "0x2A62F64", Offset = "0x2A62F64", VA = "0x2A62F64")]
		public DCSUniversalPackRecipe(UMAData.UMARecipe recipeToSave, [Optional] Dictionary<string, UMATextRecipe> wardrobeRecipes, string pRecipeType = "DynamicCharacterAvatar")
		{
		}
	}

	[Token(Token = "0x2003C63")]
	public enum ERecipeType : byte
	{
		[Token(Token = "0x4019ADF")]
		Standard,
		[Token(Token = "0x4019AE0")]
		Wardrobe,
		[Token(Token = "0x4019AE1")]
		WardrobeCollection,
		[Token(Token = "0x4019AE2")]
		DynamicCharacterAvatar
	}

	[Serializable]
	[Token(Token = "0x2003C64")]
	public class ByteFlags
	{
		[Token(Token = "0x4019AE3")]
		[FieldOffset(Offset = "0x8")]
		public byte flags;

		[Token(Token = "0x60181C8")]
		[Address(RVA = "0x2A625DC", Offset = "0x2A625DC", VA = "0x2A625DC")]
		public ByteFlags()
		{
		}

		[Token(Token = "0x60181C9")]
		[Address(RVA = "0x2A625E4", Offset = "0x2A625E4", VA = "0x2A625E4")]
		public bool HasFlag(byte b)
		{
			return default(bool);
		}

		[Token(Token = "0x60181CA")]
		[Address(RVA = "0x2A625F4", Offset = "0x2A625F4", VA = "0x2A625F4")]
		public void SetFlag(byte b)
		{
		}

		[Token(Token = "0x60181CB")]
		[Address(RVA = "0x2A62604", Offset = "0x2A62604", VA = "0x2A62604")]
		public void UnsetFlag(byte b)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C65")]
	public class MiniPackRecipe
	{
		[Token(Token = "0x4019AE4")]
		[FieldOffset(Offset = "0x8")]
		public string race;

		[Token(Token = "0x4019AE5")]
		[FieldOffset(Offset = "0xC")]
		public MiniPackedSlotData[] slots;

		[Token(Token = "0x60181CC")]
		[Address(RVA = "0x2A62268", Offset = "0x2A62268", VA = "0x2A62268")]
		public MiniPackRecipe()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C66")]
	public class MiniPackedSlotData
	{
		[Token(Token = "0x4019AE6")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		[Token(Token = "0x4019AE7")]
		[FieldOffset(Offset = "0xC")]
		public int scale;

		[Token(Token = "0x4019AE8")]
		[FieldOffset(Offset = "0x10")]
		public int copyIdx;

		[Token(Token = "0x4019AE9")]
		[FieldOffset(Offset = "0x14")]
		public MiniPackedOverlayData overlay;

		[Token(Token = "0x60181CD")]
		[Address(RVA = "0x2A623DC", Offset = "0x2A623DC", VA = "0x2A623DC")]
		public MiniPackedSlotData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C67")]
	public class MiniPackedOverlayData : ByteFlags
	{
		[Token(Token = "0x4019AEA")]
		public const byte FLAG_SKIN_COLOR = 1;

		[Token(Token = "0x4019AEB")]
		[FieldOffset(Offset = "0xC")]
		public string id;

		[Token(Token = "0x60181CE")]
		[Address(RVA = "0x2A6253C", Offset = "0x2A6253C", VA = "0x2A6253C")]
		public MiniPackedOverlayData()
		{
		}

		[Token(Token = "0x60181CF")]
		[Address(RVA = "0x2A62544", Offset = "0x2A62544", VA = "0x2A62544")]
		public void SetSkinColor()
		{
		}

		[Token(Token = "0x60181D0")]
		[Address(RVA = "0x2A617A4", Offset = "0x2A617A4", VA = "0x2A617A4")]
		public bool HasSkinColor()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003C68")]
	private class IntVec2
	{
		[Token(Token = "0x4019AEC")]
		[FieldOffset(Offset = "0x8")]
		public int a;

		[Token(Token = "0x4019AED")]
		[FieldOffset(Offset = "0xC")]
		public int b;

		[Token(Token = "0x60181D1")]
		[Address(RVA = "0x2A62260", Offset = "0x2A62260", VA = "0x2A62260")]
		public IntVec2()
		{
		}
	}

	[NonSerialized]
	[Token(Token = "0x4019AC4")]
	[FieldOffset(Offset = "0x11")]
	public byte recipeTypeByte;

	[Token(Token = "0x4019AC5")]
	[FieldOffset(Offset = "0x14")]
	public string DisplayValue;

	[Token(Token = "0x4019AC6")]
	[FieldOffset(Offset = "0x18")]
	public List<string> compatibleRaces;

	[Token(Token = "0x4019AC7")]
	[FieldOffset(Offset = "0x1C")]
	public string wardrobeSlot;

	[Token(Token = "0x4019AC8")]
	[FieldOffset(Offset = "0x20")]
	public List<string> Hides;

	[Token(Token = "0x4019AC9")]
	[FieldOffset(Offset = "0x24")]
	public List<string> suppressWardrobeSlots;

	[Token(Token = "0x4019ACA")]
	[FieldOffset(Offset = "0x28")]
	public List<string> beSuppressWardrobeSlots;

	[Token(Token = "0x4019ACB")]
	[FieldOffset(Offset = "0x2C")]
	private uint _003CId_003Ek__BackingField;

	[Token(Token = "0x4019ACC")]
	public const byte RecipeTypeStandard = 0;

	[Token(Token = "0x4019ACD")]
	public const byte RecipeTypeWardrobe = 1;

	[Token(Token = "0x4019ACE")]
	public const byte RecipeTypeWardrobeCollection = 2;

	[Token(Token = "0x4019ACF")]
	[FieldOffset(Offset = "0x30")]
	public MiniPackRecipe recipeData;

	[Token(Token = "0x4019AD0")]
	[FieldOffset(Offset = "0x0")]
	private static int[] m_DefaultRect;

	[Token(Token = "0x1700198E")]
	public uint Id
	{
		[Token(Token = "0x60181A4")]
		[Address(RVA = "0x2A5FAF8", Offset = "0x2A5FAF8", VA = "0x2A5FAF8", Slot = "8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60181A5")]
		[Address(RVA = "0x2A5FB00", Offset = "0x2A5FB00", VA = "0x2A5FB00", Slot = "9")]
		set
		{
		}
	}

	[Token(Token = "0x60181A3")]
	[Address(RVA = "0x2A5FA10", Offset = "0x2A5FA10", VA = "0x2A5FA10")]
	public UMATextRecipe()
	{
	}

	[Token(Token = "0x60181A6")]
	[Address(RVA = "0x2A5FB08", Offset = "0x2A5FB08", VA = "0x2A5FB08")]
	public string GetWardrobeSlot()
	{
		return null;
	}

	[Token(Token = "0x60181A7")]
	[Address(RVA = "0x2A5FB10", Offset = "0x2A5FB10", VA = "0x2A5FB10")]
	public static List<WardrobeSettings> GenerateWardrobeSet(Dictionary<string, UMATextRecipe> wardrobeRecipes, string[] slotsToSave)
	{
		return null;
	}

	[Token(Token = "0x60181A8")]
	[Address(RVA = "0x2A5FFD8", Offset = "0x2A5FFD8", VA = "0x2A5FFD8", Slot = "4")]
	public override void Load(UMAData.UMARecipe umaRecipe, [Optional] UMAContext context)
	{
	}

	[Token(Token = "0x60181A9")]
	[Address(RVA = "0x2A60018", Offset = "0x2A60018", VA = "0x2A60018")]
	protected DCSUniversalPackRecipe PackedLoadDCSInternal(UMAContext context)
	{
		return null;
	}

	[Token(Token = "0x60181AA")]
	[Address(RVA = "0x2A600A0", Offset = "0x2A600A0", VA = "0x2A600A0")]
	public static DCSUniversalPackRecipe PackedLoadDCS(UMAContext context, string recipeToUnpack, [Optional] UMATextRecipe targetUTR)
	{
		return null;
	}

	[Token(Token = "0x60181AB")]
	[Address(RVA = "0x2A60954", Offset = "0x2A60954", VA = "0x2A60954")]
	public static DCSUniversalPackRecipe PackedLoadDCS(UMAContext context, UMATextRecipe recipe, [Optional] UMATextRecipe targetUTR)
	{
		return null;
	}

	[Token(Token = "0x60181AC")]
	[Address(RVA = "0x2A60A08", Offset = "0x2A60A08", VA = "0x2A60A08")]
	public void Save(UMAData.UMARecipe umaRecipe, UMAContext context, Dictionary<string, UMATextRecipe> wardrobeRecipes, bool backwardsCompatible = true)
	{
	}

	[Token(Token = "0x60181AD")]
	[Address(RVA = "0x2A60ACC", Offset = "0x2A60ACC", VA = "0x2A60ACC", Slot = "5")]
	public override void Save(UMAData.UMARecipe umaRecipe, UMAContext context)
	{
	}

	[Token(Token = "0x60181AE")]
	[Address(RVA = "0x2A60BCC", Offset = "0x2A60BCC", VA = "0x2A60BCC")]
	public void SaveDCS(DynamicCharacterAvatar dcaToSave, string recipeName, DynamicCharacterAvatar.SaveOptions saveOptions)
	{
	}

	[Token(Token = "0x60181AF")]
	[Address(RVA = "0x2A60408", Offset = "0x2A60408", VA = "0x2A60408")]
	public static string GetRecipesType(string recipeString)
	{
		return null;
	}

	[Token(Token = "0x60181B0")]
	[Address(RVA = "0x2A60790", Offset = "0x2A60790", VA = "0x2A60790")]
	public static bool RecipeHasWardrobeSet(string recipeString)
	{
		return default(bool);
	}

	[Token(Token = "0x60181B1")]
	[Address(RVA = "0x2A60890", Offset = "0x2A60890", VA = "0x2A60890")]
	public static List<WardrobeSettings> GetRecipesWardrobeSet(string recipeString)
	{
		return null;
	}

	[Token(Token = "0x60181B2")]
	[Address(RVA = "0x2A60AC8", Offset = "0x2A60AC8", VA = "0x2A60AC8")]
	public static byte RecipeTypeToByte(ERecipeType t)
	{
		return default(byte);
	}

	[Token(Token = "0x60181B3")]
	[Address(RVA = "0x2A60CDC", Offset = "0x2A60CDC", VA = "0x2A60CDC", Slot = "6")]
	public override UMAPackRecipe PackedLoad(UMAContext context)
	{
		return null;
	}

	[Token(Token = "0x60181B4")]
	[Address(RVA = "0x2A61290", Offset = "0x2A61290", VA = "0x2A61290")]
	private PackedSlotDataV2 ConvertToSlotDataV2(MiniPackedSlotData s, ref bool hasSkinColor)
	{
		return null;
	}

	[Token(Token = "0x60181B5")]
	[Address(RVA = "0x2A61610", Offset = "0x2A61610", VA = "0x2A61610")]
	private PackedOverlayDataV2 ConvertToOverlayDataV2(MiniPackedOverlayData v, ref bool hasSkinColor)
	{
		return null;
	}

	[Token(Token = "0x60181B6")]
	[Address(RVA = "0x2A61544", Offset = "0x2A61544", VA = "0x2A61544")]
	public static PackedOverlayColorDataV3 CreateColorDataV3(string name)
	{
		return null;
	}

	[Token(Token = "0x60181B7")]
	[Address(RVA = "0x2A617B0", Offset = "0x2A617B0", VA = "0x2A617B0", Slot = "7")]
	public override void PackedSave(UMAPackRecipe packedRecipe, UMAContext context)
	{
	}

	[Token(Token = "0x60181B8")]
	[Address(RVA = "0x2A62270", Offset = "0x2A62270", VA = "0x2A62270")]
	private int GetSkipCount(int i, LinkedList<IntVec2> skips)
	{
		return default(int);
	}

	[Token(Token = "0x60181B9")]
	[Address(RVA = "0x2A61D8C", Offset = "0x2A61D8C", VA = "0x2A61D8C")]
	private MiniPackedSlotData ConvertToSlotDataMini(PackedSlotDataV2 s2, int skinColorIndex, LinkedList<IntVec2> skips)
	{
		return null;
	}

	[Token(Token = "0x60181BA")]
	[Address(RVA = "0x2A623F4", Offset = "0x2A623F4", VA = "0x2A623F4")]
	private MiniPackedOverlayData ConvertToOverlayDataMini(PackedOverlayDataV2 o2, int skinColorIndex)
	{
		return null;
	}

	[Token(Token = "0x60181BB")]
	[Address(RVA = "0x2A62554", Offset = "0x2A62554", VA = "0x2A62554")]
	public void ClearResourceRef()
	{
	}
}
