using System;
using Il2CppDummyDll;
using UMA;

[Token(Token = "0x2003C98")]
public abstract class UMAPackedRecipeBase : UMARecipeBase
{
	[Serializable]
	[Token(Token = "0x2003C99")]
	public class packedSlotData
	{
		[Token(Token = "0x4019C24")]
		[FieldOffset(Offset = "0x8")]
		public string slotID;

		[Token(Token = "0x4019C25")]
		[FieldOffset(Offset = "0xC")]
		public int overlayScale;

		[Token(Token = "0x4019C26")]
		[FieldOffset(Offset = "0x10")]
		public int copyOverlayIndex;

		[Token(Token = "0x4019C27")]
		[FieldOffset(Offset = "0x14")]
		public packedOverlayData[] OverlayDataList;

		[Token(Token = "0x60183F4")]
		[Address(RVA = "0x2A5F94C", Offset = "0x2A5F94C", VA = "0x2A5F94C")]
		public packedSlotData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C9A")]
	public class packedOverlayData
	{
		[Token(Token = "0x4019C28")]
		[FieldOffset(Offset = "0x8")]
		public string overlayID;

		[Token(Token = "0x4019C29")]
		[FieldOffset(Offset = "0xC")]
		public int[] colorList;

		[Token(Token = "0x4019C2A")]
		[FieldOffset(Offset = "0x10")]
		public int[][] channelMaskList;

		[Token(Token = "0x4019C2B")]
		[FieldOffset(Offset = "0x14")]
		public int[][] channelAdditiveMaskList;

		[Token(Token = "0x4019C2C")]
		[FieldOffset(Offset = "0x18")]
		public int[] rectList;

		[Token(Token = "0x60183F5")]
		[Address(RVA = "0x2A5F944", Offset = "0x2A5F944", VA = "0x2A5F944")]
		public packedOverlayData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C9B")]
	public class PackedSlotDataV2
	{
		[Token(Token = "0x4019C2D")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		[Token(Token = "0x4019C2E")]
		[FieldOffset(Offset = "0xC")]
		public int scale;

		[Token(Token = "0x4019C2F")]
		[FieldOffset(Offset = "0x10")]
		public int copyIdx;

		[Token(Token = "0x4019C30")]
		[FieldOffset(Offset = "0x14")]
		public PackedOverlayDataV2[] overlays;

		[Token(Token = "0x60183F6")]
		[Address(RVA = "0x2A5DE14", Offset = "0x2A5DE14", VA = "0x2A5DE14")]
		public PackedSlotDataV2()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C9C")]
	public class PackedOverlayDataV2
	{
		[Token(Token = "0x4019C31")]
		[FieldOffset(Offset = "0x8")]
		public string id;

		[Token(Token = "0x4019C32")]
		[FieldOffset(Offset = "0xC")]
		public int colorIdx;

		[Token(Token = "0x4019C33")]
		[FieldOffset(Offset = "0x10")]
		public int[] rect;

		[Token(Token = "0x60183F7")]
		[Address(RVA = "0x2A5DEC8", Offset = "0x2A5DEC8", VA = "0x2A5DEC8")]
		public PackedOverlayDataV2()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C9D")]
	public class PackedOverlayColorDataV2
	{
		[Token(Token = "0x4019C34")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4019C35")]
		[FieldOffset(Offset = "0xC")]
		public byte[] color;

		[Token(Token = "0x4019C36")]
		[FieldOffset(Offset = "0x10")]
		public byte[][] masks;

		[Token(Token = "0x4019C37")]
		[FieldOffset(Offset = "0x14")]
		public byte[][] addMasks;

		[Token(Token = "0x60183F8")]
		[Address(RVA = "0x2A5EF00", Offset = "0x2A5EF00", VA = "0x2A5EF00")]
		public PackedOverlayColorDataV2()
		{
		}

		[Token(Token = "0x60183F9")]
		[Address(RVA = "0x2A5EFBC", Offset = "0x2A5EFBC", VA = "0x2A5EFBC")]
		public PackedOverlayColorDataV2(OverlayColorData colorData)
		{
		}

		[Token(Token = "0x60183FA")]
		[Address(RVA = "0x2A5E4A4", Offset = "0x2A5E4A4", VA = "0x2A5E4A4")]
		public void SetOverlayColorData(OverlayColorData overlayColorData)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C9E")]
	public class PackedOverlayColorDataV3
	{
		[Token(Token = "0x4019C38")]
		[FieldOffset(Offset = "0x8")]
		public string name;

		[Token(Token = "0x4019C39")]
		[FieldOffset(Offset = "0xC")]
		public short[] colors;

		[Token(Token = "0x60183FB")]
		[Address(RVA = "0x2A5F7EC", Offset = "0x2A5F7EC", VA = "0x2A5F7EC")]
		public PackedOverlayColorDataV3()
		{
		}

		[Token(Token = "0x60183FC")]
		[Address(RVA = "0x2A5D878", Offset = "0x2A5D878", VA = "0x2A5D878")]
		public PackedOverlayColorDataV3(OverlayColorData colorData)
		{
		}

		[Token(Token = "0x60183FD")]
		[Address(RVA = "0x2A5DF54", Offset = "0x2A5DF54", VA = "0x2A5DF54")]
		public void SetOverlayColorData(OverlayColorData overlayColorData)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2003C9F")]
	public class UMAPackRecipe
	{
		[Token(Token = "0x4019C3A")]
		[FieldOffset(Offset = "0x8")]
		public int version;

		[Token(Token = "0x4019C3B")]
		[FieldOffset(Offset = "0xC")]
		public packedSlotData[] packedSlotDataList;

		[Token(Token = "0x4019C3C")]
		[FieldOffset(Offset = "0x10")]
		public PackedSlotDataV2[] slotsV2;

		[Token(Token = "0x4019C3D")]
		[FieldOffset(Offset = "0x14")]
		public PackedOverlayColorDataV2[] colors;

		[Token(Token = "0x4019C3E")]
		[FieldOffset(Offset = "0x18")]
		public PackedOverlayColorDataV3[] fColors;

		[Token(Token = "0x4019C3F")]
		[FieldOffset(Offset = "0x1C")]
		public int sharedColorCount;

		[Token(Token = "0x4019C40")]
		[FieldOffset(Offset = "0x20")]
		public string race;

		[Token(Token = "0x60183FE")]
		[Address(RVA = "0x2A5D754", Offset = "0x2A5D754", VA = "0x2A5D754")]
		public UMAPackRecipe()
		{
		}

		[Token(Token = "0x60183FF")]
		[Address(RVA = "0x2A5D84C", Offset = "0x2A5D84C", VA = "0x2A5D84C")]
		public static bool ArrayHasData(Array array)
		{
			return default(bool);
		}

		[Token(Token = "0x6018400")]
		[Address(RVA = "0x2A5DCF8", Offset = "0x2A5DCF8", VA = "0x2A5DCF8")]
		public static bool SlotIsValid(SlotData slotData)
		{
			return default(bool);
		}

		[Token(Token = "0x6018401")]
		[Address(RVA = "0x2A5F8A8", Offset = "0x2A5F8A8", VA = "0x2A5F8A8")]
		public static bool SlotIsValid(packedSlotData packedSlotData)
		{
			return default(bool);
		}

		[Token(Token = "0x6018402")]
		[Address(RVA = "0x2A5DE2C", Offset = "0x2A5DE2C", VA = "0x2A5DE2C")]
		public static bool SlotIsValid(PackedSlotDataV2 packedSlot)
		{
			return default(bool);
		}

		[Token(Token = "0x6018403")]
		[Address(RVA = "0x2A5EE0C", Offset = "0x2A5EE0C", VA = "0x2A5EE0C")]
		public static bool MaterialIsValid(UMAMaterial material)
		{
			return default(bool);
		}

		[Token(Token = "0x6018404")]
		[Address(RVA = "0x2A5D764", Offset = "0x2A5D764", VA = "0x2A5D764")]
		public static bool RaceIsValid(RaceData raceData)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60183EB")]
	[Address(RVA = "0x2A5BE50", Offset = "0x2A5BE50", VA = "0x2A5BE50")]
	protected UMAPackedRecipeBase()
	{
	}

	[Token(Token = "0x60183EC")]
	[Address(RVA = "0x2A5BE60", Offset = "0x2A5BE60", VA = "0x2A5BE60", Slot = "4")]
	public override void Load(UMAData.UMARecipe umaRecipe, UMAContext context)
	{
	}

	[Token(Token = "0x60183ED")]
	[Address(RVA = "0x2A5C8A8", Offset = "0x2A5C8A8", VA = "0x2A5C8A8", Slot = "5")]
	public override void Save(UMAData.UMARecipe umaRecipe, UMAContext context)
	{
	}

	[Token(Token = "0x60183EE")]
	public abstract UMAPackRecipe PackedLoad(UMAContext context);

	[Token(Token = "0x60183EF")]
	public abstract void PackedSave(UMAPackRecipe packedRecipe, UMAContext context);

	[Token(Token = "0x60183F0")]
	[Address(RVA = "0x2A5C900", Offset = "0x2A5C900", VA = "0x2A5C900")]
	public static UMAPackRecipe PackRecipeV2(UMAData.UMARecipe umaRecipe)
	{
		return null;
	}

	[Token(Token = "0x60183F1")]
	[Address(RVA = "0x2A5DED0", Offset = "0x2A5DED0", VA = "0x2A5DED0")]
	public static UMAData.UMARecipe UnpackRecipeVersion2(UMAPackRecipe umaPackRecipe, UMAContext context)
	{
		return null;
	}

	[Token(Token = "0x60183F2")]
	[Address(RVA = "0x2A5BE98", Offset = "0x2A5BE98", VA = "0x2A5BE98")]
	public static void UnpackRecipeVersion2(UMAData.UMARecipe umaRecipe, UMAPackRecipe umaPackRecipe, UMAContext context)
	{
	}

	[Token(Token = "0x60183F3")]
	[Address(RVA = "0x2A5ECA0", Offset = "0x2A5ECA0", VA = "0x2A5ECA0")]
	private static OverlayData InstantiateOverlay(UMAContext context, SlotData tempSlotData, string id)
	{
		return null;
	}
}
