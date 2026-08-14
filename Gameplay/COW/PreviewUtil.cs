using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C83")]
public static class PreviewUtil
{
	[Token(Token = "0x4010FDD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color32 GREEN;

	[Token(Token = "0x4010FDE")]
	[FieldOffset(Offset = "0x4")]
	private static readonly Color32 YELLOW;

	[Token(Token = "0x4010FDF")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Color32 RED;

	[Token(Token = "0x6012907")]
	[Address(RVA = "0x1963338", Offset = "0x1963338", VA = "0x1963338")]
	public static BoostState CheckBoostStateDelegate(uint itemID, FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return default(BoostState);
	}

	[Token(Token = "0x6012908")]
	[Address(RVA = "0x19635E0", Offset = "0x19635E0", VA = "0x19635E0")]
	public static EInventory.AwardType GetBaseItemInfoAwardType(BaseItemInfo info)
	{
		return default(EInventory.AwardType);
	}

	[Token(Token = "0x6012909")]
	[Address(RVA = "0x19636BC", Offset = "0x19636BC", VA = "0x19636BC")]
	public static bool IsAvatarCantWearHeadAdditive(uint avatarId, AvatarWardrobeData clothes, bool canEquipDefault = true)
	{
		return default(bool);
	}

	[Token(Token = "0x601290A")]
	[Address(RVA = "0x1963828", Offset = "0x1963828", VA = "0x1963828")]
	public static Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601290B")]
	[Address(RVA = "0x1963A30", Offset = "0x1963A30", VA = "0x1963A30")]
	public static bool IsItemABReady(uint item_id)
	{
		return default(bool);
	}

	[Token(Token = "0x601290C")]
	[Address(RVA = "0x1963B60", Offset = "0x1963B60", VA = "0x1963B60")]
	public static bool IsItemABReady(CSSharedItemData item_data)
	{
		return default(bool);
	}

	[Token(Token = "0x601290D")]
	[Address(RVA = "0x1963F6C", Offset = "0x1963F6C", VA = "0x1963F6C")]
	public static List<CSSharedItemData> TransformBundle2ItemList(CSSharedItemData item_data)
	{
		return null;
	}

	[Token(Token = "0x601290E")]
	[Address(RVA = "0x19645F4", Offset = "0x19645F4", VA = "0x19645F4")]
	public static void FindItemNeedDownloadRes(uint itemId, ref List<ResourceID> need_download_res_list)
	{
	}

	[Token(Token = "0x601290F")]
	[Address(RVA = "0x1964738", Offset = "0x1964738", VA = "0x1964738")]
	public static void FindItemNeedDownloadRes(CSSharedItemData item_data, ref List<ResourceID> need_download_res_list)
	{
	}

	[Token(Token = "0x6012910")]
	[Address(RVA = "0x19648DC", Offset = "0x19648DC", VA = "0x19648DC")]
	public static List<uint> GetAvatarClothList()
	{
		return null;
	}

	[Token(Token = "0x6012911")]
	[Address(RVA = "0x1964EC8", Offset = "0x1964EC8", VA = "0x1964EC8")]
	public static Vector3 TransStringToVector3(string str)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6012912")]
	[Address(RVA = "0x1965104", Offset = "0x1965104", VA = "0x1965104")]
	public static Color32 GetSkillBgColor(char type)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color32);
	}

	[Token(Token = "0x6012913")]
	[Address(RVA = "0x19652B0", Offset = "0x19652B0", VA = "0x19652B0")]
	public static uint GetBundleNoAvatarShowId(uint bundleID)
	{
		return default(uint);
	}

	[Token(Token = "0x6012914")]
	[Address(RVA = "0x1965520", Offset = "0x1965520", VA = "0x1965520")]
	public static bool IsSpecialPreviewBundle(uint itemID, bool checkOwned = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6012915")]
	[Address(RVA = "0x196574C", Offset = "0x196574C", VA = "0x196574C")]
	public static bool IsSpecialPreviewBundle(List<BundleShowData> bundleList, bool checkOwned = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6012916")]
	[Address(RVA = "0x1966264", Offset = "0x1966264", VA = "0x1966264")]
	public static bool IsSpecialTreasureBox(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6012917")]
	[Address(RVA = "0x1966484", Offset = "0x1966484", VA = "0x1966484")]
	private static bool IsSpecialTreasureBox(List<TreasureBoxShowData> boxList)
	{
		return default(bool);
	}

	[Token(Token = "0x6012918")]
	[Address(RVA = "0x196693C", Offset = "0x196693C", VA = "0x196693C")]
	public static uint GetPreviewAvatarId(uint clothesID)
	{
		return default(uint);
	}

	[Token(Token = "0x6012919")]
	[Address(RVA = "0x1965CEC", Offset = "0x1965CEC", VA = "0x1965CEC")]
	private static uint GetPreviewAvatarId(AvatarWardrobeData wData, uint bundleShowFemale, uint bundleShowMale)
	{
		return default(uint);
	}

	[Token(Token = "0x601291A")]
	[Address(RVA = "0x19660FC", Offset = "0x19660FC", VA = "0x19660FC")]
	private static uint GetPreviewAvatarId(uint bundleShowFemale, uint bundleShowMale)
	{
		return default(uint);
	}

	[Token(Token = "0x601291B")]
	[Address(RVA = "0x1966A84", Offset = "0x1966A84", VA = "0x1966A84")]
	public static List<uint> TransformBundleID2PreviewList(uint bundleid)
	{
		return null;
	}

	[Token(Token = "0x601291C")]
	[Address(RVA = "0x1966FB8", Offset = "0x1966FB8", VA = "0x1966FB8")]
	public static List<uint> TransformBundleList2PreviewList(List<BaseBundleItemInfo> bundle)
	{
		return null;
	}

	[Token(Token = "0x601291D")]
	[Address(RVA = "0x1967578", Offset = "0x1967578", VA = "0x1967578")]
	public static void ShowLocalAvatar(uint avatarID, List<uint> clothList, bool playanim = true, uint skinWeapon = 0u, bool showPose = false)
	{
	}

	[Token(Token = "0x601291E")]
	[Address(RVA = "0x196796C", Offset = "0x196796C", VA = "0x196796C")]
	public static UIModelAvatarBase.EClothGenderType GetGenderTypeById(uint id)
	{
		return default(UIModelAvatarBase.EClothGenderType);
	}
}
