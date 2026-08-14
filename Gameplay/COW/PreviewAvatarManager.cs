using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A26")]
public class PreviewAvatarManager
{
	[Token(Token = "0x2000A27")]
	private sealed class _003CPreviewClothes_003Ec__AnonStorey0
	{
		[Token(Token = "0x4005B0F")]
		[FieldOffset(Offset = "0x8")]
		internal FrontEndPreviewComponent frontEndPreviewComponent;

		[Token(Token = "0x4005B10")]
		[FieldOffset(Offset = "0xC")]
		internal uint avatarIndex;

		[Token(Token = "0x6004F4A")]
		[Address(RVA = "0x1C18250", Offset = "0x1C18250", VA = "0x1C18250")]
		public _003CPreviewClothes_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6004F4B")]
		[Address(RVA = "0x1C182E8", Offset = "0x1C182E8", VA = "0x1C182E8")]
		internal void _003C_003Em__0(UIStatedAvatar s)
		{
		}

		[Token(Token = "0x6004F4C")]
		[Address(RVA = "0x1C182FC", Offset = "0x1C182FC", VA = "0x1C182FC")]
		internal void _003C_003Em__1(UIStatedAvatar s)
		{
		}
	}

	[Token(Token = "0x4005B0C")]
	[FieldOffset(Offset = "0x0")]
	public static List<UIMaleAvatar> UImaleAvatarPool;

	[Token(Token = "0x4005B0D")]
	public const string FORTUNEIdleAnimId = "INGAME_ANIMATION_COS_FORTUNE_IDLE_MALE";

	[Token(Token = "0x4005B0E")]
	public const string PHOENIXAnimId = "INGAME_ANIMATION_COS_PHOENIX_IDLE_FEMALE";

	[Token(Token = "0x6004F36")]
	[Address(RVA = "0x1C131B8", Offset = "0x1C131B8", VA = "0x1C131B8")]
	public PreviewAvatarManager()
	{
	}

	[Token(Token = "0x6004F37")]
	[Address(RVA = "0x1C131C0", Offset = "0x1C131C0", VA = "0x1C131C0")]
	public static void GetOptionalClothRes(uint itemID, ref List<ResourceID> cloth_res_list)
	{
	}

	[Token(Token = "0x6004F38")]
	[Address(RVA = "0x1C13DA0", Offset = "0x1C13DA0", VA = "0x1C13DA0")]
	public static void GetOptionalClothRes(uint[] item_id_list, ref List<ResourceID> cloth_res_list)
	{
	}

	[Token(Token = "0x6004F39")]
	[Address(RVA = "0x1C13EFC", Offset = "0x1C13EFC", VA = "0x1C13EFC")]
	public static bool CheckAvatarABReady(uint avatarid)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F3A")]
	[Address(RVA = "0x1C141E8", Offset = "0x1C141E8", VA = "0x1C141E8")]
	public static bool CheckClothABReady(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F3B")]
	[Address(RVA = "0x1C14BE8", Offset = "0x1C14BE8", VA = "0x1C14BE8")]
	public static bool IsClothBundleABReady(uint[] bundles)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F3C")]
	[Address(RVA = "0x1C14D30", Offset = "0x1C14D30", VA = "0x1C14D30")]
	public static void ClearAvatarPool()
	{
	}

	[Token(Token = "0x6004F3D")]
	[Address(RVA = "0x1C1505C", Offset = "0x1C1505C", VA = "0x1C1505C")]
	public static void PushAvatar()
	{
	}

	[Token(Token = "0x6004F3E")]
	[Address(RVA = "0x1C152B0", Offset = "0x1C152B0", VA = "0x1C152B0")]
	public static void RecycleAvatar(UIMaleAvatar avatar)
	{
	}

	[Token(Token = "0x6004F3F")]
	[Address(RVA = "0x1C1581C", Offset = "0x1C1581C", VA = "0x1C1581C")]
	private static int GetUsefulAvatarIndex(bool isfemale)
	{
		return default(int);
	}

	[Token(Token = "0x6004F40")]
	[Address(RVA = "0x1C155AC", Offset = "0x1C155AC", VA = "0x1C155AC")]
	public static void SetAvatarLightLayer(UIMaleAvatar avatar, string layername, string shadowname)
	{
	}

	[Token(Token = "0x6004F41")]
	[Address(RVA = "0x1C15C30", Offset = "0x1C15C30", VA = "0x1C15C30")]
	public static UIMaleAvatar CreateAvatar(List<uint> idlist, Vector3 scale, Vector3 pos, bool playSpecial, int avatarlighttype = 1, bool changeanim = true, int doubleanimid = 0, string resspecial = "", string residle = "", bool createwithlight = true, uint avatarIndex = 1u, bool playIdleAlternative = false, [Optional] FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return null;
	}

	[Token(Token = "0x6004F42")]
	[Address(RVA = "0x1C17670", Offset = "0x1C17670", VA = "0x1C17670")]
	private static void InjectFrontEndPreviewComponent(UIMaleAvatar avatar, FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6004F43")]
	[Address(RVA = "0x1C1779C", Offset = "0x1C1779C", VA = "0x1C1779C")]
	public static UIPetAvatar CreatePetAvatar(uint pet_id, Vector3 scale, Vector3 pos, int avatarlighttype = 1, [Optional] Quaternion rotation, [Optional] FrontEndPreviewComponent frontEndPreviewComponent, bool playPetLoopIdleSound = false)
	{
		return null;
	}

	[Token(Token = "0x6004F44")]
	[Address(RVA = "0x1C17CE4", Offset = "0x1C17CE4", VA = "0x1C17CE4")]
	public static void ResetAvatarDir(UIMaleAvatar avatar)
	{
	}

	[Token(Token = "0x6004F45")]
	[Address(RVA = "0x1C17E6C", Offset = "0x1C17E6C", VA = "0x1C17E6C")]
	public static void SetGameobjectLayer(GameObject avatarobj, int layer)
	{
	}

	[Token(Token = "0x6004F46")]
	[Address(RVA = "0x1C17FBC", Offset = "0x1C17FBC", VA = "0x1C17FBC")]
	public static uint ModifyChangeAvatarId(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x6004F47")]
	[Address(RVA = "0x1C18014", Offset = "0x1C18014", VA = "0x1C18014")]
	public static void GetAvatarOptionalRes(CSSharedItemData itemData, ref List<ResourceID> collection_res_list)
	{
	}

	[Token(Token = "0x6004F48")]
	[Address(RVA = "0x1C16AF4", Offset = "0x1C16AF4", VA = "0x1C16AF4")]
	public static void PreviewClothes(UIMaleAvatar avatar, uint avatarId, uint selectClothes, uint[] clothes, bool addLobbyClothes, bool playClothesAnim, bool keepHairWhenSameAvatarId, bool changeanim = true, int doubleanimid = 0, bool playTriggerEffect = true, uint avatarIndex = 1u, bool playIdleAlternative = false, [Optional] FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}
}
