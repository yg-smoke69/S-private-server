using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UMA.Simple;

namespace UMA;

[Token(Token = "0x2003C92")]
public static class UmaSimpleUtils
{
	[Token(Token = "0x2003C93")]
	private sealed class _003CStringToBits_003Ec__AnonStorey0
	{
		[Token(Token = "0x4019C15")]
		[FieldOffset(Offset = "0x8")]
		internal Func<string, int> strToIdx;

		[Token(Token = "0x4019C16")]
		[FieldOffset(Offset = "0xC")]
		internal int ret;

		[Token(Token = "0x60183C5")]
		[Address(RVA = "0x35EBEC4", Offset = "0x35EBEC4", VA = "0x35EBEC4")]
		public _003CStringToBits_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60183C6")]
		[Address(RVA = "0x35EDF4C", Offset = "0x35EDF4C", VA = "0x35EDF4C")]
		internal void _003C_003Em__0(string s)
		{
		}
	}

	[Token(Token = "0x4019C0C")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<string, int> RaceNameToEnums;

	[Token(Token = "0x4019C0D")]
	[FieldOffset(Offset = "0x4")]
	public static Dictionary<string, int> BaseSlotNameToEnums;

	[Token(Token = "0x4019C0E")]
	[FieldOffset(Offset = "0x8")]
	public static Dictionary<string, int> WardrobeSlotNameToEnums;

	[Token(Token = "0x4019C0F")]
	[FieldOffset(Offset = "0xC")]
	private static Func<string, int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4019C10")]
	[FieldOffset(Offset = "0x10")]
	private static Func<int, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4019C11")]
	[FieldOffset(Offset = "0x14")]
	private static Func<string, int> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4019C12")]
	[FieldOffset(Offset = "0x18")]
	private static Func<int, string> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4019C13")]
	[FieldOffset(Offset = "0x1C")]
	private static Func<string, int> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4019C14")]
	[FieldOffset(Offset = "0x20")]
	private static Func<int, string> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x601839C")]
	[Address(RVA = "0x35EBD40", Offset = "0x35EBD40", VA = "0x35EBD40")]
	public static void LogErrorNonLive(string msg)
	{
	}

	[Token(Token = "0x601839D")]
	[Address(RVA = "0x35EBDC4", Offset = "0x35EBDC4", VA = "0x35EBDC4")]
	public static int StringToBits(List<string> ss, Func<string, int> strToIdx)
	{
		return default(int);
	}

	[Token(Token = "0x601839E")]
	[Address(RVA = "0x35EBECC", Offset = "0x35EBECC", VA = "0x35EBECC")]
	private static int StringToBitsMasked(List<string> ss, Func<string, int> strToIdx, int invalidBits = 1)
	{
		return default(int);
	}

	[Token(Token = "0x601839F")]
	[Address(RVA = "0x35EBEE4", Offset = "0x35EBEE4", VA = "0x35EBEE4")]
	private static List<string> BitsToStrings(int bits, Func<int, string> idxToStr, int invalidBits = 1)
	{
		return null;
	}

	[Token(Token = "0x60183A0")]
	[Address(RVA = "0x35EC014", Offset = "0x35EC014", VA = "0x35EC014")]
	private static Dictionary<string, int> InitNameToEnumMap(string[] ss)
	{
		return null;
	}

	[Token(Token = "0x60183A1")]
	[Address(RVA = "0x35EC118", Offset = "0x35EC118", VA = "0x35EC118")]
	private static int GetEnumByName(Dictionary<string, int> dic, string s, int @default = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60183A2")]
	[Address(RVA = "0x35EC1CC", Offset = "0x35EC1CC", VA = "0x35EC1CC")]
	public static string GetRaceName(ERace e)
	{
		return null;
	}

	[Token(Token = "0x60183A3")]
	[Address(RVA = "0x35EC290", Offset = "0x35EC290", VA = "0x35EC290")]
	public static bool IsFemale(ERace e)
	{
		return default(bool);
	}

	[Token(Token = "0x60183A4")]
	[Address(RVA = "0x35EC2A4", Offset = "0x35EC2A4", VA = "0x35EC2A4")]
	public static ERace GetRace(string s)
	{
		return default(ERace);
	}

	[Token(Token = "0x60183A5")]
	[Address(RVA = "0x35EC388", Offset = "0x35EC388", VA = "0x35EC388")]
	public static byte GetRaces(List<string> compatibleRaces)
	{
		return default(byte);
	}

	[Token(Token = "0x60183A6")]
	[Address(RVA = "0x35EC464", Offset = "0x35EC464", VA = "0x35EC464")]
	public static List<string> GetRaces(int i)
	{
		return null;
	}

	[Token(Token = "0x60183A7")]
	[Address(RVA = "0x35EC540", Offset = "0x35EC540", VA = "0x35EC540")]
	public static string GetBaseSlotName(EBaseSlot e)
	{
		return null;
	}

	[Token(Token = "0x60183A8")]
	[Address(RVA = "0x35EC604", Offset = "0x35EC604", VA = "0x35EC604")]
	public static EBaseSlot GetBaseSlot(string s)
	{
		return default(EBaseSlot);
	}

	[Token(Token = "0x60183A9")]
	[Address(RVA = "0x35EC6E4", Offset = "0x35EC6E4", VA = "0x35EC6E4")]
	public static int GetBaseSlots(List<string> names)
	{
		return default(int);
	}

	[Token(Token = "0x60183AA")]
	[Address(RVA = "0x35EC7C0", Offset = "0x35EC7C0", VA = "0x35EC7C0")]
	public static List<string> GetBaseSlots(int i)
	{
		return null;
	}

	[Token(Token = "0x60183AB")]
	[Address(RVA = "0x35EC89C", Offset = "0x35EC89C", VA = "0x35EC89C")]
	public static string GetWardrobeSlotName(EWardrobeSlot e)
	{
		return null;
	}

	[Token(Token = "0x60183AC")]
	[Address(RVA = "0x35EC960", Offset = "0x35EC960", VA = "0x35EC960")]
	public static EWardrobeSlot GetWardrobeSlot(string s)
	{
		return default(EWardrobeSlot);
	}

	[Token(Token = "0x60183AD")]
	[Address(RVA = "0x35ECA40", Offset = "0x35ECA40", VA = "0x35ECA40")]
	public static int GetWardrobeSlots(List<string> names)
	{
		return default(int);
	}

	[Token(Token = "0x60183AE")]
	[Address(RVA = "0x35ECB1C", Offset = "0x35ECB1C", VA = "0x35ECB1C")]
	public static List<string> GetWardrobeSlots(int i)
	{
		return null;
	}

	[Token(Token = "0x60183AF")]
	[Address(RVA = "0x35ECBF8", Offset = "0x35ECBF8", VA = "0x35ECBF8")]
	public static string GetWardrobeSlotName(EAdditiveTargetSlot e)
	{
		return null;
	}

	[Token(Token = "0x60183B0")]
	[Address(RVA = "0x35ECC04", Offset = "0x35ECC04", VA = "0x35ECC04")]
	public static EWardrobeSlot GetTargetWardrobeSlot(EAdditiveTargetSlot e)
	{
		return default(EWardrobeSlot);
	}

	[Token(Token = "0x60183B1")]
	[Address(RVA = "0x35ECC10", Offset = "0x35ECC10", VA = "0x35ECC10")]
	public static int GetTargetBaseSlots(EAdditiveTargetSlot e)
	{
		return default(int);
	}

	[Token(Token = "0x60183B2")]
	[Address(RVA = "0x35ECC28", Offset = "0x35ECC28", VA = "0x35ECC28")]
	public static bool IsPotensialAdditiveSlot(string slotName)
	{
		return default(bool);
	}

	[Token(Token = "0x60183B3")]
	[Address(RVA = "0x35ECCFC", Offset = "0x35ECCFC", VA = "0x35ECCFC")]
	public static bool IsPotensialAdditiveSrcSlot(string wardrobeSlot)
	{
		return default(bool);
	}

	[Token(Token = "0x60183B4")]
	[Address(RVA = "0x35ECD4C", Offset = "0x35ECD4C", VA = "0x35ECD4C")]
	public static bool GetRecipe(string recipe, out UMATextRecipe textRecipe, out UmaRecipeSimple simpleRecipe)
	{
		return default(bool);
	}

	[Token(Token = "0x60183B5")]
	[Address(RVA = "0x35ECFF4", Offset = "0x35ECFF4", VA = "0x35ECFF4")]
	public static bool IsConflict(string selectRecipe, string targetRecipe, bool considerHidingTarget)
	{
		return default(bool);
	}

	[Token(Token = "0x60183B6")]
	[Address(RVA = "0x35ED420", Offset = "0x35ED420", VA = "0x35ED420")]
	public static bool IsHidenByTarget(UmaRecipeSimple srcRecipe, UmaRecipeSimple targetRecipe)
	{
		return default(bool);
	}

	[Token(Token = "0x60183B7")]
	[Address(RVA = "0x35ED498", Offset = "0x35ED498", VA = "0x35ED498")]
	public static bool IsHidenByTarget(UMATextRecipe srcRecipe, UMATextRecipe targetRecipe)
	{
		return default(bool);
	}

	[Token(Token = "0x60183B8")]
	[Address(RVA = "0x35ED590", Offset = "0x35ED590", VA = "0x35ED590")]
	public static bool HasSuppress(string recipe, EWardrobeSlot slot)
	{
		return default(bool);
	}

	[Token(Token = "0x60183B9")]
	[Address(RVA = "0x35ED7E4", Offset = "0x35ED7E4", VA = "0x35ED7E4")]
	public static bool HasSuppress(UmaRecipeSimple recipe, EWardrobeSlot slot)
	{
		return default(bool);
	}

	[Token(Token = "0x60183BA")]
	[Address(RVA = "0x35ED6E8", Offset = "0x35ED6E8", VA = "0x35ED6E8")]
	public static bool HasSuppress(UMATextRecipe recipe, EWardrobeSlot slot)
	{
		return default(bool);
	}

	[Token(Token = "0x60183BB")]
	[Address(RVA = "0x35ED820", Offset = "0x35ED820", VA = "0x35ED820")]
	public static void MergeAdditiveSlot(SlotData dst, SlotData src, AdditiveInfo srcInfo)
	{
	}

	[Token(Token = "0x60183BC")]
	[Address(RVA = "0x35EDD0C", Offset = "0x35EDD0C", VA = "0x35EDD0C")]
	public static void SortReplaceSlotsInNeed(List<KeyValuePair<SlotData, AdditiveInfo>> additiveSlots)
	{
	}

	[Token(Token = "0x60183BD")]
	[Address(RVA = "0x35EDEEC", Offset = "0x35EDEEC", VA = "0x35EDEEC")]
	public static int GetHash(SlotDataAsset s)
	{
		return default(int);
	}

	[Token(Token = "0x60183BE")]
	[Address(RVA = "0x35EDF10", Offset = "0x35EDF10", VA = "0x35EDF10")]
	public static int GetHash(OverlayDataAsset o)
	{
		return default(int);
	}

	[Token(Token = "0x60183BF")]
	[Address(RVA = "0x35EDF34", Offset = "0x35EDF34", VA = "0x35EDF34")]
	private static int _003CGetRaces_003Em__0(string s)
	{
		return default(int);
	}

	[Token(Token = "0x60183C0")]
	[Address(RVA = "0x35EDF38", Offset = "0x35EDF38", VA = "0x35EDF38")]
	private static string _003CGetRaces_003Em__1(int idx)
	{
		return null;
	}

	[Token(Token = "0x60183C1")]
	[Address(RVA = "0x35EDF3C", Offset = "0x35EDF3C", VA = "0x35EDF3C")]
	private static int _003CGetBaseSlots_003Em__2(string s)
	{
		return default(int);
	}

	[Token(Token = "0x60183C2")]
	[Address(RVA = "0x35EDF40", Offset = "0x35EDF40", VA = "0x35EDF40")]
	private static string _003CGetBaseSlots_003Em__3(int idx)
	{
		return null;
	}

	[Token(Token = "0x60183C3")]
	[Address(RVA = "0x35EDF44", Offset = "0x35EDF44", VA = "0x35EDF44")]
	private static int _003CGetWardrobeSlots_003Em__4(string s)
	{
		return default(int);
	}

	[Token(Token = "0x60183C4")]
	[Address(RVA = "0x35EDF48", Offset = "0x35EDF48", VA = "0x35EDF48")]
	private static string _003CGetWardrobeSlots_003Em__5(int idx)
	{
		return null;
	}
}
