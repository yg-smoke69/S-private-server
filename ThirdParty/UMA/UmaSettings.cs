using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x2003C91")]
public static class UmaSettings
{
	[Token(Token = "0x4019BF1")]
	[FieldOffset(Offset = "0x0")]
	public static bool LogError;

	[Token(Token = "0x4019BF2")]
	[FieldOffset(Offset = "0x1")]
	public static bool LogDetail;

	[Token(Token = "0x4019BF3")]
	[FieldOffset(Offset = "0x2")]
	public static bool LogTimes;

	[Token(Token = "0x4019BF4")]
	[FieldOffset(Offset = "0x3")]
	public static bool UsingAvatarSimple;

	[Token(Token = "0x4019BF5")]
	[FieldOffset(Offset = "0x4")]
	public static bool SkipBuildIfNotVisible;

	[Token(Token = "0x4019BF6")]
	[FieldOffset(Offset = "0x5")]
	public static bool SkipBuildIfNoVisibleChange;

	[Token(Token = "0x4019BF7")]
	[FieldOffset(Offset = "0x6")]
	public static bool ReAddBaseSlotsWhenWardrobeLoadFailed;

	[Token(Token = "0x4019BF8")]
	public const string StrAvatarAssetsDir = "umas/";

	[Token(Token = "0x4019BF9")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int StrAvatarAssetsDirLength;

	[Token(Token = "0x4019BFA")]
	public const bool SkipSlotOverlayesItemNames = true;

	[Token(Token = "0x4019BFB")]
	public const bool RenameInApkSlotOverlayFileToHashes = true;

	[Token(Token = "0x4019BFC")]
	public const bool UseSharedSbStrForSlotOverlayHashNames = false;

	[Token(Token = "0x4019BFD")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int SlotOverlayHashNameSbCap;

	[Token(Token = "0x4019BFE")]
	[FieldOffset(Offset = "0x10")]
	public static bool UsingPreAsyncLoading;

	[Token(Token = "0x4019BFF")]
	[FieldOffset(Offset = "0x11")]
	public static bool UsingPostAsyncLoading;

	[Token(Token = "0x4019C00")]
	public const int MaxAssetCountPerType = 65535;

	[Token(Token = "0x4019C01")]
	public const int MaxSlotsPerRecipe = 15;

	[Token(Token = "0x4019C02")]
	public const int MaxOverlaysPerSlot = 1;

	[Token(Token = "0x4019C03")]
	public const int MaxAdditiveSlotsPerRecipe = 7;

	[Token(Token = "0x4019C04")]
	public const bool SaveAdditiveInfoInRecipeBytes = false;

	[Token(Token = "0x4019C05")]
	public const bool SortReplaceSlotToFront = true;

	[Token(Token = "0x4019C06")]
	public const bool SortReplaceSlotToTail = true;

	[Token(Token = "0x4019C07")]
	public const int EnumInvalidBits = 1;

	[Token(Token = "0x4019C08")]
	[FieldOffset(Offset = "0x14")]
	public static string[] RaceNames;

	[Token(Token = "0x4019C09")]
	[FieldOffset(Offset = "0x18")]
	public static string[] RaceRecipes;

	[Token(Token = "0x4019C0A")]
	[FieldOffset(Offset = "0x1C")]
	public static string[] BaseSlotNames;

	[Token(Token = "0x4019C0B")]
	[FieldOffset(Offset = "0x20")]
	public static string[] WardrobeSlotNames;

	[Token(Token = "0x170019A9")]
	public static bool UsingAsyncLoading
	{
		[Token(Token = "0x601839A")]
		[Address(RVA = "0x35EA6D4", Offset = "0x35EA6D4", VA = "0x35EA6D4")]
		get
		{
			return default(bool);
		}
	}
}
