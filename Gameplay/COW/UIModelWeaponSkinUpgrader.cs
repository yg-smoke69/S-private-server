using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20032C0")]
public class UIModelWeaponSkinUpgrader : UIBaseModel
{
	[Token(Token = "0x20032C1")]
	private class WSUFeatureComparer : _Attribute
	{
		[Token(Token = "0x4013537")]
		[FieldOffset(Offset = "0x8")]
		public bool isEmoteObtainFirst;

		[Token(Token = "0x60156BC")]
		[Address(RVA = "0x1947B64", Offset = "0x1947B64", VA = "0x1947B64")]
		public WSUFeatureComparer()
		{
		}

		[Token(Token = "0x60156BD")]
		[Address(RVA = "0x194A7A8", Offset = "0x194A7A8", VA = "0x194A7A8", Slot = "4")]
		public int Compare(int x, int y)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20032C2")]
	private sealed class _003CGetOwnAndOpenInfoById_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013538")]
		[FieldOffset(Offset = "0x8")]
		internal uint skinItemId;

		[Token(Token = "0x60156BE")]
		[Address(RVA = "0x1947B5C", Offset = "0x1947B5C", VA = "0x1947B5C")]
		public _003CGetOwnAndOpenInfoById_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60156BF")]
		[Address(RVA = "0x194A1EC", Offset = "0x194A1EC", VA = "0x194A1EC")]
		internal bool _003C_003Em__0(WeaponSkinUpgradeConfig x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20032C3")]
	private sealed class _003CGetCanUpgradeCauseMaterialEnoughSkinIds_003Ec__AnonStorey1
	{
		[Token(Token = "0x4013539")]
		[FieldOffset(Offset = "0x8")]
		internal uint item;

		[Token(Token = "0x60156C0")]
		[Address(RVA = "0x1948A64", Offset = "0x1948A64", VA = "0x1948A64")]
		public _003CGetCanUpgradeCauseMaterialEnoughSkinIds_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60156C1")]
		[Address(RVA = "0x194A17C", Offset = "0x194A17C", VA = "0x194A17C")]
		internal bool _003C_003Em__0(WeaponSkinUpgradeConfig x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20032C4")]
	private sealed class _003CGetNeedDownloadResListBySkinId_003Ec__AnonStorey2
	{
		[Token(Token = "0x401353A")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x60156C2")]
		[Address(RVA = "0x19492EC", Offset = "0x19492EC", VA = "0x19492EC")]
		public _003CGetNeedDownloadResListBySkinId_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60156C3")]
		[Address(RVA = "0x194A1B4", Offset = "0x194A1B4", VA = "0x194A1B4")]
		internal bool _003C_003Em__0(WeaponSkinUpgradeConfig x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20032C5")]
	private sealed class _003CUpgradeWeaponSkin_003Ec__AnonStorey3
	{
		[Token(Token = "0x401353B")]
		[FieldOffset(Offset = "0x8")]
		internal CSUpgradeWeaponSkinReq req;

		[Token(Token = "0x401353C")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelWeaponSkinUpgrader _0024this;

		[Token(Token = "0x60156C4")]
		[Address(RVA = "0x19499DC", Offset = "0x19499DC", VA = "0x19499DC")]
		public _003CUpgradeWeaponSkin_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60156C5")]
		[Address(RVA = "0x194A224", Offset = "0x194A224", VA = "0x194A224")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x4013529")]
	[FieldOffset(Offset = "0xC")]
	private List<uint> m_HaveHadSkinIds;

	[Token(Token = "0x401352A")]
	[FieldOffset(Offset = "0x10")]
	private List<SuitOpenInfo> m_SuitOpenInfos;

	[Token(Token = "0x401352B")]
	[FieldOffset(Offset = "0x14")]
	private List<uint> m_HaveSeenSets;

	[Token(Token = "0x401352C")]
	[FieldOffset(Offset = "0x18")]
	private List<WeaponSkinUpgradeConfig> m_UpgradeConfig;

	[Token(Token = "0x401352D")]
	[FieldOffset(Offset = "0x20")]
	private long m_SystemOpenTimeStamp;

	[Token(Token = "0x401352E")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, WeaponSkinUpgradeInfoData> m_FeatureInThisLevel;

	[Token(Token = "0x401352F")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, bool> m_DictNewTipSkinIds;

	[Token(Token = "0x4013530")]
	public const int PropID_GetOpenningSetConfig = 2;

	[Token(Token = "0x4013531")]
	public const int PropID_UpgradeSuccessd = 4;

	[Token(Token = "0x4013532")]
	public const int PropID_RefreshHaveHadSkinIds = 8;

	[Token(Token = "0x4013533")]
	public const int PropID_RefreshUpgradeConfig = 16;

	[Token(Token = "0x4013534")]
	public const int PropID_UpgradeFail = 32;

	[Token(Token = "0x4013535")]
	public const int PropID_ExchangeWeaponSkinUpgradeToken = 64;

	[Token(Token = "0x4013536")]
	[FieldOffset(Offset = "0x0")]
	private static Func<WeaponSkinUpgradeInfoData, int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6015697")]
	[Address(RVA = "0x19442B0", Offset = "0x19442B0", VA = "0x19442B0")]
	public UIModelWeaponSkinUpgrader()
	{
	}

	[Token(Token = "0x6015698")]
	[Address(RVA = "0x1944334", Offset = "0x1944334", VA = "0x1944334", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015699")]
	[Address(RVA = "0x194438C", Offset = "0x194438C", VA = "0x194438C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601569A")]
	[Address(RVA = "0x19448C4", Offset = "0x19448C4", VA = "0x19448C4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601569B")]
	[Address(RVA = "0x1944A20", Offset = "0x1944A20", VA = "0x1944A20")]
	public WeaponSkinUpgradeInfoData GetFeatureInfo(WeaponSkinFeature feature)
	{
		return null;
	}

	[Token(Token = "0x601569C")]
	[Address(RVA = "0x1944B10", Offset = "0x1944B10", VA = "0x1944B10")]
	public void SetSystemOpenTimeStamp(long systemOpenTimeStamp)
	{
	}

	[Token(Token = "0x601569D")]
	[Address(RVA = "0x1944B8C", Offset = "0x1944B8C", VA = "0x1944B8C")]
	public void RefreshDictTips()
	{
	}

	[Token(Token = "0x601569E")]
	[Address(RVA = "0x1944EB0", Offset = "0x1944EB0", VA = "0x1944EB0")]
	public bool HasUnclickedNewSkin()
	{
		return default(bool);
	}

	[Token(Token = "0x601569F")]
	[Address(RVA = "0x1945150", Offset = "0x1945150", VA = "0x1945150")]
	public bool GetNewRedPointStateBySkin(uint skinId)
	{
		return default(bool);
	}

	[Token(Token = "0x60156A0")]
	[Address(RVA = "0x19452DC", Offset = "0x19452DC", VA = "0x19452DC")]
	public bool IsSystemOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x60156A1")]
	[Address(RVA = "0x19453D0", Offset = "0x19453D0", VA = "0x19453D0")]
	public void SeeSuitAnimation(uint setId)
	{
	}

	[Token(Token = "0x60156A2")]
	[Address(RVA = "0x1945490", Offset = "0x1945490", VA = "0x1945490")]
	public bool HaveSeenSuitAnimation(uint setId)
	{
		return default(bool);
	}

	[Token(Token = "0x60156A3")]
	[Address(RVA = "0x1945564", Offset = "0x1945564", VA = "0x1945564")]
	public uint GetHaveHadSkinInSuit(uint suitId)
	{
		return default(uint);
	}

	[Token(Token = "0x60156A4")]
	[Address(RVA = "0x19457F0", Offset = "0x19457F0", VA = "0x19457F0")]
	public uint GetHaveHadSkinInSameSuit(uint skinId)
	{
		return default(uint);
	}

	[Token(Token = "0x60156A5")]
	[Address(RVA = "0x1945A7C", Offset = "0x1945A7C", VA = "0x1945A7C")]
	public uint GetNextUnhaveSkinInSameSuit(uint skinId)
	{
		return default(uint);
	}

	[Token(Token = "0x60156A6")]
	[Address(RVA = "0x1945C8C", Offset = "0x1945C8C", VA = "0x1945C8C")]
	public WeaponSkinUpgradeConfig GetUpgradeConfigBySkin(uint skinId)
	{
		return null;
	}

	[Token(Token = "0x60156A7")]
	[Address(RVA = "0x1945E70", Offset = "0x1945E70", VA = "0x1945E70")]
	public List<SkinOwnAndOpenInfo> GetOwnedOrOpenningSkins()
	{
		return null;
	}

	[Token(Token = "0x60156A8")]
	[Address(RVA = "0x19464A0", Offset = "0x19464A0", VA = "0x19464A0")]
	public SkinOwnAndOpenInfo GetOwnAndOpenInfoById(uint skinItemId)
	{
		return null;
	}

	[Token(Token = "0x60156A9")]
	[Address(RVA = "0x194597C", Offset = "0x194597C", VA = "0x194597C")]
	public List<uint> GetSuitSkinIdsBySkinId(uint skinItemId)
	{
		return null;
	}

	[Token(Token = "0x60156AA")]
	[Address(RVA = "0x19456F0", Offset = "0x19456F0", VA = "0x19456F0")]
	public List<uint> GetSuitSkinIdsBySuitId(uint suitId)
	{
		return null;
	}

	[Token(Token = "0x60156AB")]
	[Address(RVA = "0x1947B6C", Offset = "0x1947B6C", VA = "0x1947B6C")]
	public bool IsMaxLevelSkin(uint skinId)
	{
		return default(bool);
	}

	[Token(Token = "0x60156AC")]
	[Address(RVA = "0x1947C70", Offset = "0x1947C70", VA = "0x1947C70")]
	public uint GetMaxLevelSkinBySuitId(uint suitId)
	{
		return default(uint);
	}

	[Token(Token = "0x60156AD")]
	[Address(RVA = "0x1947D80", Offset = "0x1947D80", VA = "0x1947D80")]
	public uint GetMinLevelSkinBySuitId(uint suitId)
	{
		return default(uint);
	}

	[Token(Token = "0x60156AE")]
	[Address(RVA = "0x1947E78", Offset = "0x1947E78", VA = "0x1947E78")]
	public GoPos GetGoPosWhenOpen(uint skinId)
	{
		return null;
	}

	[Token(Token = "0x60156AF")]
	[Address(RVA = "0x1948160", Offset = "0x1948160", VA = "0x1948160")]
	public List<uint> GetCanUpgradeCauseMaterialEnoughSkinIds()
	{
		return null;
	}

	[Token(Token = "0x60156B0")]
	[Address(RVA = "0x1948A6C", Offset = "0x1948A6C", VA = "0x1948A6C")]
	public void RefreshHaveHadSkinIds()
	{
	}

	[Token(Token = "0x60156B1")]
	[Address(RVA = "0x1948E60", Offset = "0x1948E60", VA = "0x1948E60")]
	public List<ResourceID> GetNeedDownloadResListBySkinId(uint skinId)
	{
		return null;
	}

	[Token(Token = "0x60156B2")]
	[Address(RVA = "0x1944524", Offset = "0x1944524", VA = "0x1944524")]
	private void InitFeatureInThisLevel()
	{
	}

	[Token(Token = "0x60156B3")]
	[Address(RVA = "0x1944720", Offset = "0x1944720", VA = "0x1944720")]
	private void LoadUpgradeConfig()
	{
	}

	[Token(Token = "0x60156B4")]
	[Address(RVA = "0x19492F4", Offset = "0x19492F4", VA = "0x19492F4")]
	public void GetOpenningSetIds(bool forceRequest = false)
	{
	}

	[Token(Token = "0x60156B5")]
	[Address(RVA = "0x1949550", Offset = "0x1949550", VA = "0x1949550")]
	public void UpgradeWeaponSkin(WeaponSkinData skinData)
	{
	}

	[Token(Token = "0x60156B6")]
	[Address(RVA = "0x19499E4", Offset = "0x19499E4", VA = "0x19499E4")]
	public void ExchangeWeaponSkinUpgradeToken(uint weaponSkinID)
	{
	}

	[Token(Token = "0x60156B7")]
	[Address(RVA = "0x1949C64", Offset = "0x1949C64", VA = "0x1949C64")]
	private static int _003CInitFeatureInThisLevel_003Em__0(WeaponSkinUpgradeInfoData key)
	{
		return default(int);
	}

	[Token(Token = "0x60156B8")]
	[Address(RVA = "0x1949C88", Offset = "0x1949C88", VA = "0x1949C88")]
	private void _003CGetOpenningSetIds_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60156B9")]
	[Address(RVA = "0x1949FB0", Offset = "0x1949FB0", VA = "0x1949FB0")]
	private void _003CExchangeWeaponSkinUpgradeToken_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60156BA")]
	[Address(RVA = "0x194A16C", Offset = "0x194A16C", VA = "0x194A16C")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x60156BB")]
	[Address(RVA = "0x194A174", Offset = "0x194A174", VA = "0x194A174")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
