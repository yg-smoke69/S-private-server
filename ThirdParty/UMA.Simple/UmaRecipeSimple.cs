using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UMA.Simple;

[Token(Token = "0x2003C88")]
public struct UmaRecipeSimple : _Attribute
{
	[Token(Token = "0x4019B98")]
	[FieldOffset(Offset = "0x0")]
	public static readonly UmaRecipeSimple INVALID;

	[Token(Token = "0x4019B99")]
	[FieldOffset(Offset = "0x0")]
	internal int m_Ptr;

	[Token(Token = "0x4019B9A")]
	[FieldOffset(Offset = "0x4")]
	private static List<KeyValuePair<int, bool>> s_SharedSlotOverlayHashList;

	[Token(Token = "0x170019A5")]
	public string Name
	{
		[Token(Token = "0x601836F")]
		[Address(RVA = "0x93D928", Offset = "0x93D928", VA = "0x93D928")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019A6")]
	public uint Id
	{
		[Token(Token = "0x601837B")]
		[Address(RVA = "0x93D99C", Offset = "0x93D99C", VA = "0x93D99C", Slot = "4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601837C")]
		[Address(RVA = "0x93D9A4", Offset = "0x93D9A4", VA = "0x93D9A4", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x601836E")]
	[Address(RVA = "0x93D920", Offset = "0x93D920", VA = "0x93D920")]
	public UmaRecipeSimple(int ptr, string name)
	{
	}

	[Token(Token = "0x6018370")]
	[Address(RVA = "0x93D930", Offset = "0x93D930", VA = "0x93D930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6018371")]
	[Address(RVA = "0x2DE3108", Offset = "0x2DE3108", VA = "0x2DE3108")]
	public static bool operator ==(UmaRecipeSimple a, UmaRecipeSimple b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018372")]
	[Address(RVA = "0x2DE311C", Offset = "0x2DE311C", VA = "0x2DE311C")]
	public static bool operator !=(UmaRecipeSimple a, UmaRecipeSimple b)
	{
		return default(bool);
	}

	[Token(Token = "0x6018373")]
	[Address(RVA = "0x93D93C", Offset = "0x93D93C", VA = "0x93D93C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6018374")]
	[Address(RVA = "0x93D944", Offset = "0x93D944", VA = "0x93D944", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6018375")]
	[Address(RVA = "0x93D94C", Offset = "0x93D94C", VA = "0x93D94C")]
	public EWardrobeSlot GetSlot()
	{
		return default(EWardrobeSlot);
	}

	[Token(Token = "0x6018376")]
	[Address(RVA = "0x93D954", Offset = "0x93D954", VA = "0x93D954")]
	public int GetSuppressBits()
	{
		return default(int);
	}

	[Token(Token = "0x6018377")]
	[Address(RVA = "0x93D95C", Offset = "0x93D95C", VA = "0x93D95C")]
	public int GetHidesBits()
	{
		return default(int);
	}

	[Token(Token = "0x6018378")]
	[Address(RVA = "0x93D964", Offset = "0x93D964", VA = "0x93D964")]
	private int GetSlotsPtr(out int[] data, out int slotCnt, out int isSkins, out int isAdditive, out int pAdditive)
	{
		return default(int);
	}

	[Token(Token = "0x6018379")]
	[Address(RVA = "0x93D98C", Offset = "0x93D98C", VA = "0x93D98C")]
	public List<KeyValuePair<int, bool>> GetSlotOverlaysInSharedListIgnoreNull()
	{
		return null;
	}

	[Token(Token = "0x601837A")]
	[Address(RVA = "0x93D994", Offset = "0x93D994", VA = "0x93D994")]
	public List<SlotOverlayHashPair> GetSlotOverlaysInSharedList()
	{
		return null;
	}

	[Token(Token = "0x601837D")]
	[Address(RVA = "0x93D9AC", Offset = "0x93D9AC", VA = "0x93D9AC")]
	private int GetHashPtr(out int[] data)
	{
		return default(int);
	}

	[Token(Token = "0x601837E")]
	[Address(RVA = "0x93D9B4", Offset = "0x93D9B4", VA = "0x93D9B4")]
	public bool MergeTo(UMAContextSimple context, RaceData racedata, UMAData.UMARecipe umaRecipe, List<SlotData> dst, List<KeyValuePair<SlotData, AdditiveInfo>> additiveSlots)
	{
		return default(bool);
	}

	[Token(Token = "0x601837F")]
	[Address(RVA = "0x2DE41F4", Offset = "0x2DE41F4", VA = "0x2DE41F4")]
	private static SlotData CreateMergeSlotData(UMAData.UMARecipe umaRecipe, UMAContextSimple context, int slotHash, int overlayHash, bool isSkin, int limitSize, bool potensialAdditive)
	{
		return null;
	}

	[Token(Token = "0x6018380")]
	[Address(RVA = "0x2DE4BB4", Offset = "0x2DE4BB4", VA = "0x2DE4BB4")]
	private static void MergeSlot(List<SlotData> dst, SlotData slotData)
	{
	}

	[Token(Token = "0x6018381")]
	[Address(RVA = "0x93D9DC", Offset = "0x93D9DC", VA = "0x93D9DC")]
	private void MergeAdditiveSlot(List<SlotData> dst, SlotData slotData, AdditiveInfo addtiveInfo, int beforeAddSlotCount, int addedSlotCount, int[] data, int pSlots)
	{
	}

	[Token(Token = "0x6018382")]
	[Address(RVA = "0x93DA18", Offset = "0x93DA18", VA = "0x93DA18")]
	public void MergeAdditiveSlot(List<SlotData> dst, SlotData slotData, AdditiveInfo addtiveInfo)
	{
	}

	[Token(Token = "0x6018383")]
	[Address(RVA = "0x93DA34", Offset = "0x93DA34", VA = "0x93DA34")]
	public bool AllSlotOverlaysCached(UMAContextSimple context)
	{
		return default(bool);
	}

	[Token(Token = "0x6018384")]
	[Address(RVA = "0x93DA3C", Offset = "0x93DA3C", VA = "0x93DA3C")]
	public void GetUnCachedSlotOverlays(UMAContextSimple context, List<int> dst)
	{
	}
}
