using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200301C")]
public class UIModelDressUp : UIBaseModel
{
	[Token(Token = "0x200301D")]
	private sealed class _003CEquipInfoFromList_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012532")]
		[FieldOffset(Offset = "0x8")]
		internal List<uint> temp2;

		[Token(Token = "0x4012533")]
		[FieldOffset(Offset = "0xC")]
		internal bool refresh;

		[Token(Token = "0x4012534")]
		[FieldOffset(Offset = "0xD")]
		internal bool uselog;

		[Token(Token = "0x4012535")]
		[FieldOffset(Offset = "0x10")]
		internal uint slotid;

		[Token(Token = "0x4012536")]
		[FieldOffset(Offset = "0x14")]
		internal bool donotsendbackpackmsg;

		[Token(Token = "0x4012537")]
		[FieldOffset(Offset = "0x18")]
		internal List<uint> temp;

		[Token(Token = "0x4012538")]
		[FieldOffset(Offset = "0x1C")]
		internal bool playvfx;

		[Token(Token = "0x4012539")]
		[FieldOffset(Offset = "0x0")]
		private static Action _003C_003Ef__am_0024cache0;

		[Token(Token = "0x401253A")]
		[FieldOffset(Offset = "0x4")]
		private static Action _003C_003Ef__am_0024cache1;

		[Token(Token = "0x601422A")]
		[Address(RVA = "0xFB4168", Offset = "0xFB4168", VA = "0xFB4168")]
		public _003CEquipInfoFromList_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601422B")]
		[Address(RVA = "0xFB6BE0", Offset = "0xFB6BE0", VA = "0xFB6BE0")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x601422C")]
		[Address(RVA = "0xFB6D2C", Offset = "0xFB6D2C", VA = "0xFB6D2C")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x601422D")]
		[Address(RVA = "0xFB73F4", Offset = "0xFB73F4", VA = "0xFB73F4")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x601422E")]
		[Address(RVA = "0xFB7AB8", Offset = "0xFB7AB8", VA = "0xFB7AB8")]
		private static void _003C_003Em__3()
		{
		}

		[Token(Token = "0x601422F")]
		[Address(RVA = "0xFB7BB8", Offset = "0xFB7BB8", VA = "0xFB7BB8")]
		private static void _003C_003Em__4()
		{
		}
	}

	[Token(Token = "0x200301E")]
	private sealed class _003CSendCardInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x401253B")]
		[FieldOffset(Offset = "0x8")]
		internal bool playvfx;

		[Token(Token = "0x401253C")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelDressUp _0024this;

		[Token(Token = "0x6014230")]
		[Address(RVA = "0xFB6268", Offset = "0xFB6268", VA = "0xFB6268")]
		public _003CSendCardInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014231")]
		[Address(RVA = "0xFB7CB8", Offset = "0xFB7CB8", VA = "0xFB7CB8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x4012521")]
	private const int DressUpMaxNum = 12;

	[Token(Token = "0x4012522")]
	[FieldOffset(Offset = "0xC")]
	private List<uint> m_DressUpZeroCache;

	[Token(Token = "0x4012523")]
	[FieldOffset(Offset = "0x10")]
	private List<uint> m_DressUpZero;

	[Token(Token = "0x4012524")]
	[FieldOffset(Offset = "0x14")]
	private List<uint> m_DressUpOneCache;

	[Token(Token = "0x4012525")]
	[FieldOffset(Offset = "0x18")]
	private List<uint> m_DressUpOne;

	[Token(Token = "0x4012526")]
	[FieldOffset(Offset = "0x1C")]
	private List<uint> m_DressUpTwoCache;

	[Token(Token = "0x4012527")]
	[FieldOffset(Offset = "0x20")]
	private List<uint> m_DressUpTwo;

	[Token(Token = "0x4012528")]
	[FieldOffset(Offset = "0x24")]
	private List<uint> m_DressUpTypeList;

	[Token(Token = "0x4012529")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, uint> m_DressUpTypeToIndex;

	[Token(Token = "0x401252A")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, List<uint>> m_DressupIndexToDressList;

	[Token(Token = "0x401252B")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, List<uint>> m_DressupIndexToDressCacheList;

	[Token(Token = "0x401252C")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, int> m_LegendItemLevelCache;

	[Token(Token = "0x401252D")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsCacheValid;

	[Token(Token = "0x401252E")]
	[FieldOffset(Offset = "0x3C")]
	private List<int> m_DressUpCardStateList;

	[Token(Token = "0x401252F")]
	[FieldOffset(Offset = "0x40")]
	private uint m_CurrentDressUpIndex;

	[Token(Token = "0x4012530")]
	[FieldOffset(Offset = "0x44")]
	private bool m_HasUnlockedIndex;

	[Token(Token = "0x4012531")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x60141F5")]
	[Address(RVA = "0xFAE698", Offset = "0xFAE698", VA = "0xFAE698")]
	public UIModelDressUp()
	{
	}

	[Token(Token = "0x60141F6")]
	[Address(RVA = "0xFAE7D0", Offset = "0xFAE7D0", VA = "0xFAE7D0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60141F7")]
	[Address(RVA = "0xFAE828", Offset = "0xFAE828", VA = "0xFAE828")]
	public void InitDressUpList(ref List<uint> temp)
	{
	}

	[Token(Token = "0x60141F8")]
	[Address(RVA = "0xFAE93C", Offset = "0xFAE93C", VA = "0xFAE93C")]
	public bool CheckCacheCanEquip()
	{
		return default(bool);
	}

	[Token(Token = "0x60141F9")]
	[Address(RVA = "0xFAECEC", Offset = "0xFAECEC", VA = "0xFAECEC")]
	public void EquipCacheItemid(uint id)
	{
	}

	[Token(Token = "0x60141FA")]
	[Address(RVA = "0xFAF1E0", Offset = "0xFAF1E0", VA = "0xFAF1E0")]
	public List<uint> GetCurrentEquipInfo()
	{
		return null;
	}

	[Token(Token = "0x60141FB")]
	[Address(RVA = "0xFAFA5C", Offset = "0xFAFA5C", VA = "0xFAFA5C")]
	public bool CheckCacheHasInvaildFemale()
	{
		return default(bool);
	}

	[Token(Token = "0x60141FC")]
	[Address(RVA = "0xFAFBAC", Offset = "0xFAFBAC", VA = "0xFAFBAC")]
	public bool CheckHasDiffBetweenEquip()
	{
		return default(bool);
	}

	[Token(Token = "0x60141FD")]
	[Address(RVA = "0xFB06E4", Offset = "0xFB06E4", VA = "0xFB06E4")]
	public new void ClearCache()
	{
	}

	[Token(Token = "0x60141FE")]
	[Address(RVA = "0xFB0848", Offset = "0xFB0848", VA = "0xFB0848")]
	public void EnterFirst()
	{
	}

	[Token(Token = "0x60141FF")]
	[Address(RVA = "0xFB18FC", Offset = "0xFB18FC", VA = "0xFB18FC", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014200")]
	[Address(RVA = "0xFB1BA8", Offset = "0xFB1BA8", VA = "0xFB1BA8")]
	public uint GetCurrentIndexValById(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x6014201")]
	[Address(RVA = "0xFB1CB8", Offset = "0xFB1CB8", VA = "0xFB1CB8")]
	public uint GetReallyCurrentIndexById(UIModelNewVault.eSecondTab tab)
	{
		return default(uint);
	}

	[Token(Token = "0x6014202")]
	[Address(RVA = "0xFB1DC8", Offset = "0xFB1DC8", VA = "0xFB1DC8")]
	public uint ExchangeTabToIndex(UIModelNewVault.eSecondTab tab)
	{
		return default(uint);
	}

	[Token(Token = "0x6014203")]
	[Address(RVA = "0xFAEF90", Offset = "0xFAEF90", VA = "0xFAEF90")]
	public uint ExchangeIdToIndex(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x6014204")]
	[Address(RVA = "0xFB1FA0", Offset = "0xFB1FA0", VA = "0xFB1FA0")]
	public uint GetCurrentDressupIndex()
	{
		return default(uint);
	}

	[Token(Token = "0x6014205")]
	[Address(RVA = "0xFB1FF8", Offset = "0xFB1FF8", VA = "0xFB1FF8")]
	public void ExchangeSlotIndex(uint index)
	{
	}

	[Token(Token = "0x6014206")]
	[Address(RVA = "0xFB2058", Offset = "0xFB2058", VA = "0xFB2058")]
	public bool IsFirstCard()
	{
		return default(bool);
	}

	[Token(Token = "0x6014207")]
	[Address(RVA = "0xFB20C4", Offset = "0xFB20C4", VA = "0xFB20C4")]
	public bool JudgeCardIsEmpty(uint index)
	{
		return default(bool);
	}

	[Token(Token = "0x6014208")]
	[Address(RVA = "0xFB22DC", Offset = "0xFB22DC", VA = "0xFB22DC")]
	private bool JudgeListIsEmpty(List<uint> temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6014209")]
	[Address(RVA = "0xFB2484", Offset = "0xFB2484", VA = "0xFB2484")]
	public List<ResourceID> GetDressUpNeedDownloadResList(uint slotID)
	{
		return null;
	}

	[Token(Token = "0x601420A")]
	[Address(RVA = "0xFB2828", Offset = "0xFB2828", VA = "0xFB2828")]
	public void EquipInfoFromList(List<uint> temp, bool playvfx = false, bool refresh = true, bool uselog = false, uint slotid = 0u)
	{
	}

	[Token(Token = "0x601420B")]
	[Address(RVA = "0xFB435C", Offset = "0xFB435C", VA = "0xFB435C")]
	private UIModelAvatarBase.EClothGenderType GetGenderType(uint index)
	{
		return default(UIModelAvatarBase.EClothGenderType);
	}

	[Token(Token = "0x601420C")]
	[Address(RVA = "0xFB4524", Offset = "0xFB4524", VA = "0xFB4524")]
	public DressUpCardState GetDressUpStateByIndex(uint index)
	{
		return default(DressUpCardState);
	}

	[Token(Token = "0x601420D")]
	[Address(RVA = "0xFB4170", Offset = "0xFB4170", VA = "0xFB4170")]
	private void UpdateAvatarClothData(uint itemID)
	{
	}

	[Token(Token = "0x601420E")]
	[Address(RVA = "0xFB4748", Offset = "0xFB4748", VA = "0xFB4748")]
	public void SaveCacheFromCardToAnotherCard(uint index1, uint index2)
	{
	}

	[Token(Token = "0x601420F")]
	[Address(RVA = "0xFB4934", Offset = "0xFB4934", VA = "0xFB4934")]
	public void SaveCurrentCacheToReally(uint index)
	{
	}

	[Token(Token = "0x6014210")]
	[Address(RVA = "0xFB0760", Offset = "0xFB0760", VA = "0xFB0760")]
	public void SaveReallyToCurrentCache(uint index)
	{
	}

	[Token(Token = "0x6014211")]
	[Address(RVA = "0xFB4DD4", Offset = "0xFB4DD4", VA = "0xFB4DD4")]
	public bool IsLegendLevelCachedVaild(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014212")]
	[Address(RVA = "0xFB4EB4", Offset = "0xFB4EB4", VA = "0xFB4EB4")]
	public void LegendCacheExpire()
	{
	}

	[Token(Token = "0x6014213")]
	[Address(RVA = "0xFB4F10", Offset = "0xFB4F10", VA = "0xFB4F10")]
	public void CacheLegendLevel(uint id, int level)
	{
	}

	[Token(Token = "0x6014214")]
	[Address(RVA = "0xFB5040", Offset = "0xFB5040", VA = "0xFB5040")]
	public int GetCachedLegendLevel(uint id)
	{
		return default(int);
	}

	[Token(Token = "0x6014215")]
	[Address(RVA = "0xFB510C", Offset = "0xFB510C", VA = "0xFB510C")]
	public uint FindEmptyCard()
	{
		return default(uint);
	}

	[Token(Token = "0x6014216")]
	[Address(RVA = "0xFB52BC", Offset = "0xFB52BC", VA = "0xFB52BC")]
	public bool CheckNotHasDiff()
	{
		return default(bool);
	}

	[Token(Token = "0x6014217")]
	[Address(RVA = "0xFB5498", Offset = "0xFB5498", VA = "0xFB5498")]
	private void InitDressType()
	{
	}

	[Token(Token = "0x6014218")]
	[Address(RVA = "0xFB4BF8", Offset = "0xFB4BF8", VA = "0xFB4BF8")]
	public void SaveCacheByIndex(uint index, List<uint> temp)
	{
	}

	[Token(Token = "0x6014219")]
	[Address(RVA = "0xFB4A1C", Offset = "0xFB4A1C", VA = "0xFB4A1C")]
	public void SaveByIndex(uint index, List<uint> temp)
	{
	}

	[Token(Token = "0x601421A")]
	[Address(RVA = "0xFB1F20", Offset = "0xFB1F20", VA = "0xFB1F20")]
	public uint GetCombineType(uint type1, uint subtype)
	{
		return default(uint);
	}

	[Token(Token = "0x601421B")]
	[Address(RVA = "0xFB5974", Offset = "0xFB5974", VA = "0xFB5974", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601421C")]
	[Address(RVA = "0xFB197C", Offset = "0xFB197C", VA = "0xFB197C")]
	private void InitDressUpListData()
	{
	}

	[Token(Token = "0x601421D")]
	[Address(RVA = "0xFB59E8", Offset = "0xFB59E8", VA = "0xFB59E8", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601421E")]
	[Address(RVA = "0xFB2740", Offset = "0xFB2740", VA = "0xFB2740")]
	public List<uint> GetDressUpListByIndex(uint index)
	{
		return null;
	}

	[Token(Token = "0x601421F")]
	[Address(RVA = "0xFB5A4C", Offset = "0xFB5A4C", VA = "0xFB5A4C")]
	public void ModifyItem(uint id)
	{
	}

	[Token(Token = "0x6014220")]
	[Address(RVA = "0xFAEC04", Offset = "0xFAEC04", VA = "0xFAEC04")]
	public List<uint> GetDressUpCacheListByIndex(uint index)
	{
		return null;
	}

	[Token(Token = "0x6014221")]
	[Address(RVA = "0xFB5E14", Offset = "0xFB5E14", VA = "0xFB5E14")]
	public uint GetDressUpCacheIdByIndex2(int index2)
	{
		return default(uint);
	}

	[Token(Token = "0x6014222")]
	[Address(RVA = "0xFB5F24", Offset = "0xFB5F24", VA = "0xFB5F24")]
	public void SendCardInfo(uint index, bool playvfx = false)
	{
	}

	[Token(Token = "0x6014223")]
	[Address(RVA = "0xFB6270", Offset = "0xFB6270", VA = "0xFB6270")]
	public void UnLockCardInfo()
	{
	}

	[Token(Token = "0x6014224")]
	[Address(RVA = "0xFB6620", Offset = "0xFB6620", VA = "0xFB6620")]
	public void GetCardInfo(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014225")]
	[Address(RVA = "0xFB688C", Offset = "0xFB688C", VA = "0xFB688C")]
	private static void _003CUnLockCardInfo_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014226")]
	[Address(RVA = "0xFB6890", Offset = "0xFB6890", VA = "0xFB6890")]
	private void _003CGetCardInfo_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014227")]
	[Address(RVA = "0xFB6BC8", Offset = "0xFB6BC8", VA = "0xFB6BC8")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x6014228")]
	[Address(RVA = "0xFB6BD0", Offset = "0xFB6BD0", VA = "0xFB6BD0")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014229")]
	[Address(RVA = "0xFB6BD8", Offset = "0xFB6BD8", VA = "0xFB6BD8")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
