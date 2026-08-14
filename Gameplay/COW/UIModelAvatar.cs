using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UMA.Simple;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002EB4")]
public class UIModelAvatar : UIModelAvatarBase
{
	[Token(Token = "0x2002EB5")]
	private enum AbReadyState
	{
		[Token(Token = "0x4011D6A")]
		NoResId,
		[Token(Token = "0x4011D6B")]
		NoAb,
		[Token(Token = "0x4011D6C")]
		AbReady,
		[Token(Token = "0x4011D6D")]
		AbNotReady,
		[Token(Token = "0x4011D6E")]
		LoadFailed
	}

	[Token(Token = "0x2002EB6")]
	private sealed class _003CRequestChooseClothWithCallback_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011D6F")]
		[FieldOffset(Offset = "0x8")]
		internal Action callback;

		[Token(Token = "0x4011D70")]
		[FieldOffset(Offset = "0xC")]
		internal bool uselog;

		[Token(Token = "0x4011D71")]
		[FieldOffset(Offset = "0x10")]
		internal uint slotid;

		[Token(Token = "0x4011D72")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelAvatar _0024this;

		[Token(Token = "0x6013897")]
		[Address(RVA = "0x30B59B0", Offset = "0x30B59B0", VA = "0x30B59B0")]
		public _003CRequestChooseClothWithCallback_003Ec__AnonStorey1()
		{
		}
	}

	[Token(Token = "0x2002EB7")]
	private sealed class _003CRequestChooseClothWithCallback_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011D73")]
		[FieldOffset(Offset = "0x8")]
		internal CSChangeClothesReq req;

		[Token(Token = "0x4011D74")]
		[FieldOffset(Offset = "0xC")]
		internal _003CRequestChooseClothWithCallback_003Ec__AnonStorey1 _003C_003Ef__ref_00241;

		[Token(Token = "0x6013898")]
		[Address(RVA = "0x30B59B8", Offset = "0x30B59B8", VA = "0x30B59B8")]
		public _003CRequestChooseClothWithCallback_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013899")]
		[Address(RVA = "0x30BC72C", Offset = "0x30BC72C", VA = "0x30BC72C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EB8")]
	private sealed class _003CRequestNewChooseCloth_003Ec__AnonStorey2
	{
		[Token(Token = "0x4011D75")]
		[FieldOffset(Offset = "0x8")]
		internal uint avatarID;

		[Token(Token = "0x4011D76")]
		[FieldOffset(Offset = "0xC")]
		internal bool refreshState;

		[Token(Token = "0x4011D77")]
		[FieldOffset(Offset = "0xD")]
		internal bool cloneBeforeRequest;

		[Token(Token = "0x4011D78")]
		[FieldOffset(Offset = "0x10")]
		internal Action callback;

		[Token(Token = "0x4011D79")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelAvatar _0024this;

		[Token(Token = "0x601389A")]
		[Address(RVA = "0x30B6ED4", Offset = "0x30B6ED4", VA = "0x30B6ED4")]
		public _003CRequestNewChooseCloth_003Ec__AnonStorey2()
		{
		}
	}

	[Token(Token = "0x2002EB9")]
	private sealed class _003CRequestNewChooseCloth_003Ec__AnonStorey3
	{
		[Token(Token = "0x4011D7A")]
		[FieldOffset(Offset = "0x8")]
		internal CSChangeClothesReq req;

		[Token(Token = "0x4011D7B")]
		[FieldOffset(Offset = "0xC")]
		internal int highestRankUseLevel;

		[Token(Token = "0x4011D7C")]
		[FieldOffset(Offset = "0x10")]
		internal _003CRequestNewChooseCloth_003Ec__AnonStorey2 _003C_003Ef__ref_00242;

		[Token(Token = "0x601389B")]
		[Address(RVA = "0x30B6EDC", Offset = "0x30B6EDC", VA = "0x30B6EDC")]
		public _003CRequestNewChooseCloth_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601389C")]
		[Address(RVA = "0x30BD538", Offset = "0x30BD538", VA = "0x30BD538")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EBA")]
	private sealed class _003CRequestChooseCloth_003Ec__AnonStorey4
	{
		[Token(Token = "0x4011D7D")]
		[FieldOffset(Offset = "0x8")]
		internal uint avatarID;

		[Token(Token = "0x4011D7E")]
		[FieldOffset(Offset = "0xC")]
		internal bool refreshState;

		[Token(Token = "0x4011D7F")]
		[FieldOffset(Offset = "0xD")]
		internal bool cloneBeforeRequest;

		[Token(Token = "0x4011D80")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelAvatar _0024this;

		[Token(Token = "0x601389D")]
		[Address(RVA = "0x30B7768", Offset = "0x30B7768", VA = "0x30B7768")]
		public _003CRequestChooseCloth_003Ec__AnonStorey4()
		{
		}
	}

	[Token(Token = "0x2002EBB")]
	private sealed class _003CRequestChooseCloth_003Ec__AnonStorey5
	{
		[Token(Token = "0x4011D81")]
		[FieldOffset(Offset = "0x8")]
		internal CSChangeClothesReq req;

		[Token(Token = "0x4011D82")]
		[FieldOffset(Offset = "0xC")]
		internal int highestRankUseLevel;

		[Token(Token = "0x4011D83")]
		[FieldOffset(Offset = "0x10")]
		internal _003CRequestChooseCloth_003Ec__AnonStorey4 _003C_003Ef__ref_00244;

		[Token(Token = "0x601389E")]
		[Address(RVA = "0x30B7770", Offset = "0x30B7770", VA = "0x30B7770")]
		public _003CRequestChooseCloth_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x601389F")]
		[Address(RVA = "0x30BBA7C", Offset = "0x30BBA7C", VA = "0x30BBA7C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x4011D5B")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, List<string>> m_TempDict;

	[Token(Token = "0x4011D5C")]
	[FieldOffset(Offset = "0x4")]
	public static Dictionary<string, bool> CachedRecipeReadyList;

	[Token(Token = "0x4011D5D")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, List<CSSharedAvatarData>> m_DictBackpackAvatar;

	[Token(Token = "0x4011D5E")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, List<InventoryClothInfo>> m_DictBackpackCloth;

	[Token(Token = "0x4011D5F")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<uint, AvatarData> m_Avatars;

	[Token(Token = "0x4011D60")]
	[FieldOffset(Offset = "0x18")]
	private AvatarData m_CurrentAvatar;

	[Token(Token = "0x4011D61")]
	[FieldOffset(Offset = "0x1C")]
	private AvatarData m_CachedAvatar;

	[Token(Token = "0x4011D62")]
	[FieldOffset(Offset = "0x20")]
	private uint m_FemaleDefaultModifyId;

	[Token(Token = "0x4011D63")]
	[FieldOffset(Offset = "0x24")]
	private uint m_MaleDefaultModifyId;

	[Token(Token = "0x4011D64")]
	[FieldOffset(Offset = "0x28")]
	private uint m_CacheAvatarId;

	[Token(Token = "0x4011D65")]
	[FieldOffset(Offset = "0x2C")]
	private float m_CacheAvatarColor;

	[Token(Token = "0x4011D66")]
	[FieldOffset(Offset = "0x30")]
	private UIAvatarWindowController.AvatarSetting m_lobbyAvatarSetting;

	[Token(Token = "0x4011D67")]
	[FieldOffset(Offset = "0x34")]
	private UIAvatarWindowController.AvatarPetSetting m_lobbyPetSetting;

	[Token(Token = "0x4011D68")]
	private const bool ChecksOverlayInSlotBeforeResource = true;

	[Token(Token = "0x1700145F")]
	public AvatarData CurrentAvatarData
	{
		[Token(Token = "0x6013851")]
		[Address(RVA = "0x30B1E38", Offset = "0x30B1E38", VA = "0x30B1E38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6013847")]
	[Address(RVA = "0x30B13E0", Offset = "0x30B13E0", VA = "0x30B13E0")]
	public UIModelAvatar()
	{
	}

	[Token(Token = "0x6013848")]
	[Address(RVA = "0x30B1648", Offset = "0x30B1648", VA = "0x30B1648", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6013849")]
	[Address(RVA = "0x30B1728", Offset = "0x30B1728", VA = "0x30B1728")]
	public void RefreshDefaultModelId(GetOppositeSexModelRes res)
	{
	}

	[Token(Token = "0x601384A")]
	[Address(RVA = "0x30B1950", Offset = "0x30B1950", VA = "0x30B1950")]
	public uint GetDefaultModelId(bool isfamale)
	{
		return default(uint);
	}

	[Token(Token = "0x601384B")]
	[Address(RVA = "0x30B19BC", Offset = "0x30B19BC", VA = "0x30B19BC", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601384C")]
	[Address(RVA = "0x30B1AF4", Offset = "0x30B1AF4", VA = "0x30B1AF4", Slot = "12")]
	protected override void OnSceneChange(object[] data)
	{
	}

	[Token(Token = "0x601384D")]
	[Address(RVA = "0x30B1BC0", Offset = "0x30B1BC0", VA = "0x30B1BC0")]
	public static void ClearCachedRecipeReadyDict()
	{
	}

	[Token(Token = "0x601384E")]
	[Address(RVA = "0x30B1D24", Offset = "0x30B1D24", VA = "0x30B1D24")]
	public Dictionary<int, List<CSSharedAvatarData>> GetBackpackAvatarDict()
	{
		return null;
	}

	[Token(Token = "0x601384F")]
	[Address(RVA = "0x30B1D7C", Offset = "0x30B1D7C", VA = "0x30B1D7C")]
	public Dictionary<int, List<InventoryClothInfo>> GetBackpackClothDict()
	{
		return null;
	}

	[Token(Token = "0x6013850")]
	[Address(RVA = "0x30B1DD4", Offset = "0x30B1DD4", VA = "0x30B1DD4")]
	public bool HasCurrentAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x6013852")]
	[Address(RVA = "0x30B1E90", Offset = "0x30B1E90", VA = "0x30B1E90")]
	public uint GetAvatarID()
	{
		return default(uint);
	}

	[Token(Token = "0x6013853")]
	[Address(RVA = "0x30B1EFC", Offset = "0x30B1EFC", VA = "0x30B1EFC")]
	public bool IsSelfFemale()
	{
		return default(bool);
	}

	[Token(Token = "0x6013854")]
	[Address(RVA = "0x30B1F74", Offset = "0x30B1F74", VA = "0x30B1F74")]
	public EHairType SelfHairType()
	{
		return default(EHairType);
	}

	[Token(Token = "0x6013855")]
	[Address(RVA = "0x30B1FE0", Offset = "0x30B1FE0", VA = "0x30B1FE0")]
	public string GetBaseRaceName()
	{
		return null;
	}

	[Token(Token = "0x6013856")]
	[Address(RVA = "0x30B2150", Offset = "0x30B2150", VA = "0x30B2150")]
	public static string GetBaseRaceName(EGenderType t, bool useHigh = true)
	{
		return null;
	}

	[Token(Token = "0x6013857")]
	[Address(RVA = "0x30B2374", Offset = "0x30B2374", VA = "0x30B2374")]
	public float GetSkinColorNormalized()
	{
		return default(float);
	}

	[Token(Token = "0x6013858")]
	[Address(RVA = "0x30B23FC", Offset = "0x30B23FC", VA = "0x30B23FC")]
	public float GetSkinColorNormalizedByAvatarID(uint avatarID)
	{
		return default(float);
	}

	[Token(Token = "0x6013859")]
	[Address(RVA = "0x30B2510", Offset = "0x30B2510", VA = "0x30B2510")]
	public Dictionary<int, uint> GetCurrentClothDict()
	{
		return null;
	}

	[Token(Token = "0x601385A")]
	[Address(RVA = "0x30B2580", Offset = "0x30B2580", VA = "0x30B2580")]
	public Dictionary<int, uint> GetCachedClothDict()
	{
		return null;
	}

	[Token(Token = "0x601385B")]
	[Address(RVA = "0x30B25EC", Offset = "0x30B25EC", VA = "0x30B25EC")]
	public Dictionary<int, uint> GetCurrentClothDict(uint avatarId)
	{
		return null;
	}

	[Token(Token = "0x601385C")]
	[Address(RVA = "0x30B26DC", Offset = "0x30B26DC", VA = "0x30B26DC")]
	public uint GetCurrentHair()
	{
		return default(uint);
	}

	[Token(Token = "0x601385D")]
	[Address(RVA = "0x30B290C", Offset = "0x30B290C", VA = "0x30B290C")]
	public bool IsClothesIdsTheSameWithCurrent(List<uint> clothesList)
	{
		return default(bool);
	}

	[Token(Token = "0x601385E")]
	[Address(RVA = "0x30B2AF4", Offset = "0x30B2AF4", VA = "0x30B2AF4")]
	public UIAvatarWindowController.AvatarSetting GetLobbyAvatarSetting()
	{
		return null;
	}

	[Token(Token = "0x601385F")]
	[Address(RVA = "0x30B2B4C", Offset = "0x30B2B4C", VA = "0x30B2B4C")]
	public UIAvatarWindowController.AvatarPetSetting GetLobbyPetSetting()
	{
		return null;
	}

	[Token(Token = "0x6013860")]
	[Address(RVA = "0x30B2BA4", Offset = "0x30B2BA4", VA = "0x30B2BA4")]
	public void UpdateAvatarList(proto.AvatarProfile[] avatarList)
	{
	}

	[Token(Token = "0x6013861")]
	[Address(RVA = "0x30B3550", Offset = "0x30B3550", VA = "0x30B3550")]
	public void UpdateAvatar(proto.AvatarProfile avatar)
	{
	}

	[Token(Token = "0x6013862")]
	[Address(RVA = "0x30B3898", Offset = "0x30B3898", VA = "0x30B3898")]
	public void AfterGetBackPack(Dictionary<int, List<CSSharedAvatarData>> dictAvatar, Dictionary<int, List<InventoryClothInfo>> dictWardrobe)
	{
	}

	[Token(Token = "0x6013863")]
	[Address(RVA = "0x30B3988", Offset = "0x30B3988", VA = "0x30B3988")]
	public void UpdateCurAvatarId(uint id)
	{
	}

	[Token(Token = "0x6013864")]
	[Address(RVA = "0x30B3B24", Offset = "0x30B3B24", VA = "0x30B3B24")]
	public void LocalSaveAvatarColor(uint v)
	{
	}

	[Token(Token = "0x6013865")]
	[Address(RVA = "0x30B3BB0", Offset = "0x30B3BB0", VA = "0x30B3BB0")]
	public bool RemoveSetSlotInNeed(AvatarWardrobeData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6013866")]
	[Address(RVA = "0x30B3D4C", Offset = "0x30B3D4C", VA = "0x30B3D4C")]
	public bool CheckHasConFlict(AvatarWardrobeData data, uint targetItemID, bool removeSuppress = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6013867")]
	[Address(RVA = "0x30B3F4C", Offset = "0x30B3F4C", VA = "0x30B3F4C")]
	public bool RemoveConflictSlotInNeed(AvatarWardrobeData data, bool removeSuppress = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6013868")]
	[Address(RVA = "0x30B42AC", Offset = "0x30B42AC", VA = "0x30B42AC")]
	public static bool CheckHelmetHide(uint dataId, FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return default(bool);
	}

	[Token(Token = "0x6013869")]
	[Address(RVA = "0x30B4570", Offset = "0x30B4570", VA = "0x30B4570")]
	public static bool CheckVestHide(uint dataId, FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return default(bool);
	}

	[Token(Token = "0x601386A")]
	[Address(RVA = "0x30B4724", Offset = "0x30B4724", VA = "0x30B4724")]
	public static bool CheckHasFace(uint dataId, FrontEndPreviewComponent frontEndPreviewComponent)
	{
		return default(bool);
	}

	[Token(Token = "0x601386B")]
	[Address(RVA = "0x30B48D8", Offset = "0x30B48D8", VA = "0x30B48D8")]
	public void LocalSaveClothData(AvatarWardrobeData data)
	{
	}

	[Token(Token = "0x601386C")]
	[Address(RVA = "0x30B4AB8", Offset = "0x30B4AB8", VA = "0x30B4AB8")]
	public void LocalSaveClothData(uint avatarID, AvatarWardrobeData data)
	{
	}

	[Token(Token = "0x601386D")]
	[Address(RVA = "0x30B4C80", Offset = "0x30B4C80", VA = "0x30B4C80")]
	public void LocalClearClothData(uint avatarID)
	{
	}

	[Token(Token = "0x601386E")]
	[Address(RVA = "0x30B4DB4", Offset = "0x30B4DB4", VA = "0x30B4DB4")]
	public bool CheckClothIsEquipInAvatar(uint clothID)
	{
		return default(bool);
	}

	[Token(Token = "0x601386F")]
	[Address(RVA = "0x30B5208", Offset = "0x30B5208", VA = "0x30B5208")]
	public void RequestChooseAvatar()
	{
	}

	[Token(Token = "0x6013870")]
	[Address(RVA = "0x30B525C", Offset = "0x30B525C", VA = "0x30B525C")]
	public void RequestChooseClothWithCallback(Action callback, bool uselog = false, uint slotid = 0u)
	{
	}

	[Token(Token = "0x6013871")]
	[Address(RVA = "0x30B5F94", Offset = "0x30B5F94", VA = "0x30B5F94")]
	public void RefreshAvatarDataToServer()
	{
	}

	[Token(Token = "0x6013872")]
	[Address(RVA = "0x30B63D0", Offset = "0x30B63D0", VA = "0x30B63D0")]
	public uint TransfromFakeItemIdToAvatarId(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x6013873")]
	[Address(RVA = "0x30B662C", Offset = "0x30B662C", VA = "0x30B662C")]
	public void RequestNewChooseCloth(uint avatarID = 0u, bool cloneBeforeRequest = true, bool refreshState = false, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6013874")]
	[Address(RVA = "0x30B6EE4", Offset = "0x30B6EE4", VA = "0x30B6EE4")]
	public void RequestChooseCloth(uint avatarID = 0u, bool cloneBeforeRequest = true, bool refreshState = false)
	{
	}

	[Token(Token = "0x6013875")]
	[Address(RVA = "0x30B59C0", Offset = "0x30B59C0", VA = "0x30B59C0")]
	private bool CheckClothesCanChange(uint[] clothes)
	{
		return default(bool);
	}

	[Token(Token = "0x6013876")]
	[Address(RVA = "0x30B5B64", Offset = "0x30B5B64", VA = "0x30B5B64")]
	private int GetClothesHighestRankUseLevel(uint[] clothes)
	{
		return default(int);
	}

	[Token(Token = "0x6013877")]
	[Address(RVA = "0x30B7778", Offset = "0x30B7778", VA = "0x30B7778")]
	private void SetHighestRankUseLevel(uint clothID, ref int highestRankUseLevel)
	{
	}

	[Token(Token = "0x6013878")]
	[Address(RVA = "0x30B78D8", Offset = "0x30B78D8", VA = "0x30B78D8")]
	public void CacheAvatarSkinColor(uint avatarID, float color)
	{
	}

	[Token(Token = "0x6013879")]
	[Address(RVA = "0x30B795C", Offset = "0x30B795C", VA = "0x30B795C")]
	public void SendCacheAvatarSkinColor(bool refresh = false)
	{
	}

	[Token(Token = "0x601387A")]
	[Address(RVA = "0x30B7B2C", Offset = "0x30B7B2C", VA = "0x30B7B2C")]
	public void SetAvatarSkinColor(uint avatarID, float color)
	{
	}

	[Token(Token = "0x601387B")]
	[Address(RVA = "0x30B5C30", Offset = "0x30B5C30", VA = "0x30B5C30")]
	private void ShowNotReachRankItemUseLevelTips(int rankLevel)
	{
	}

	[Token(Token = "0x601387C")]
	[Address(RVA = "0x30B7C40", Offset = "0x30B7C40", VA = "0x30B7C40")]
	public Dictionary<uint, AvatarData> GetAvatars()
	{
		return null;
	}

	[Token(Token = "0x601387D")]
	[Address(RVA = "0x30B7C98", Offset = "0x30B7C98", VA = "0x30B7C98")]
	public void SetLobbyAvatarSetting(UIAvatarWindowController.AvatarSetting setting)
	{
	}

	[Token(Token = "0x601387E")]
	[Address(RVA = "0x30B7CF8", Offset = "0x30B7CF8", VA = "0x30B7CF8")]
	public void SetLobbyPetSetting(UIAvatarWindowController.AvatarPetSetting setting)
	{
	}

	[Token(Token = "0x601387F")]
	[Address(RVA = "0x30B7D58", Offset = "0x30B7D58", VA = "0x30B7D58")]
	public bool IsFemaleInvalid(uint itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6013880")]
	[Address(RVA = "0x30B7FEC", Offset = "0x30B7FEC", VA = "0x30B7FEC")]
	public bool CheckIsInvisibleSkill(uint itemid)
	{
		return default(bool);
	}

	[Token(Token = "0x6013881")]
	[Address(RVA = "0x30B836C", Offset = "0x30B836C", VA = "0x30B836C")]
	public bool CanEquipCloth(uint itemId, uint avatarid = 0u)
	{
		return default(bool);
	}

	[Token(Token = "0x6013882")]
	[Address(RVA = "0x30B8680", Offset = "0x30B8680", VA = "0x30B8680")]
	private static void LogRecipeAbReadyError(string s)
	{
	}

	[Token(Token = "0x6013883")]
	[Address(RVA = "0x30B874C", Offset = "0x30B874C", VA = "0x30B874C")]
	private static void LogRecipeAbReadyError(string s, UMATextRecipe recipe)
	{
	}

	[Token(Token = "0x6013884")]
	[Address(RVA = "0x30B8898", Offset = "0x30B8898", VA = "0x30B8898")]
	public static void GetRecipeResIDNotDownload(string recipe, ref List<ResourceID> not_download_res_list, bool skipDownloadedCheck = false)
	{
	}

	[Token(Token = "0x6013885")]
	[Address(RVA = "0x30B8A3C", Offset = "0x30B8A3C", VA = "0x30B8A3C")]
	public static void GetRecipeResIDNotDownload(UMATextRecipe recipe, ref List<ResourceID> not_download_res_list, bool skipDownloadedCheck = false)
	{
	}

	[Token(Token = "0x6013886")]
	[Address(RVA = "0x30B919C", Offset = "0x30B919C", VA = "0x30B919C")]
	public static void GetRecipeResIDNotDownload(UmaRecipeSimple recipe, ref List<ResourceID> not_download_res_list, bool skipDownloadedCheck = false)
	{
	}

	[Token(Token = "0x6013887")]
	[Address(RVA = "0x30B9674", Offset = "0x30B9674", VA = "0x30B9674")]
	public static void LoadRecipeAssets(string recipe)
	{
	}

	[Token(Token = "0x6013888")]
	[Address(RVA = "0x30B9B28", Offset = "0x30B9B28", VA = "0x30B9B28")]
	public static bool IsRecipeAbReady(uint itemID, AvatarWardrobeData wData, uint avatarId, bool isFemale, bool highquality, bool checkLoad, [Optional] UMAContextSimple context)
	{
		return default(bool);
	}

	[Token(Token = "0x6013889")]
	[Address(RVA = "0x30B9D94", Offset = "0x30B9D94", VA = "0x30B9D94")]
	public static bool IsRecipeAbReady(string recipe, bool checkLoad = false, bool forAsync = false, [Optional] UMAContextSimple context)
	{
		return default(bool);
	}

	[Token(Token = "0x601388A")]
	[Address(RVA = "0x30BA1BC", Offset = "0x30BA1BC", VA = "0x30BA1BC")]
	private static bool CheckRecipeAbReady(UMAContextSimple context, UMATextRecipe recipe, bool checkLoad = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601388B")]
	private static AbReadyState CheckSlotOrOverlayAbState<T>(UMAContextSimple context, string name, bool checkLoad) where T : Object
	{
		return default(AbReadyState);
	}

	[Token(Token = "0x601388C")]
	[Address(RVA = "0x30BA5C0", Offset = "0x30BA5C0", VA = "0x30BA5C0")]
	private static bool CheckRecipeAbReady(UMAContextSimple context, UmaRecipeSimple recipe, bool checkLoad = false, bool forAsync = false)
	{
		return default(bool);
	}

	[Token(Token = "0x601388D")]
	[Address(RVA = "0x30BAF30", Offset = "0x30BAF30", VA = "0x30BAF30")]
	private static bool IsSlotOverlayInSameAb(int slotHash, int overlayHash)
	{
		return default(bool);
	}

	[Token(Token = "0x601388E")]
	[Address(RVA = "0x30BAC08", Offset = "0x30BAC08", VA = "0x30BAC08")]
	private static AbReadyState CheckSlotOrOverlayAbState(UMAContextSimple context, int hash, bool isSlot, bool checkLoad)
	{
		return default(AbReadyState);
	}

	[Token(Token = "0x601388F")]
	[Address(RVA = "0x30BB0B0", Offset = "0x30BB0B0", VA = "0x30BB0B0")]
	public void AvatarPlayEnterTeamAnim(bool playIdleAlternate = false)
	{
	}

	[Token(Token = "0x6013890")]
	[Address(RVA = "0x30BB2EC", Offset = "0x30BB2EC", VA = "0x30BB2EC")]
	public void AvatarPlayEnterTeamAnim(UIMaleAvatar avatar, bool isFemale, uint groupAnim, bool playIdleAlternate = false)
	{
	}

	[Token(Token = "0x6013891")]
	[Address(RVA = "0x30BB508", Offset = "0x30BB508", VA = "0x30BB508")]
	private void PlayEnterTeamAnimByGroupAnim(UIMaleAvatar avatar, GroupAnimData data, bool isFemale, bool playIdleAlternate = false)
	{
	}

	[Token(Token = "0x6013892")]
	[Address(RVA = "0x30BB780", Offset = "0x30BB780", VA = "0x30BB780")]
	public List<uint> GetEquipedItemID()
	{
		return null;
	}

	[Token(Token = "0x6013894")]
	[Address(RVA = "0x30BBA64", Offset = "0x30BBA64", VA = "0x30BBA64")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6013895")]
	[Address(RVA = "0x30BBA6C", Offset = "0x30BBA6C", VA = "0x30BBA6C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x6013896")]
	[Address(RVA = "0x30BBA74", Offset = "0x30BBA74", VA = "0x30BBA74")]
	public void _003C_003EiFixBaseProxy_OnSceneChange(object[] P0)
	{
	}
}
