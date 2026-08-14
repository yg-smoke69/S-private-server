using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DB1")]
public class UIModelBigEvent_GlobalProgress : UIBaseModel
{
	[Token(Token = "0x2002DB2")]
	private sealed class _003CRequestClaimProcessRewards_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011899")]
		[FieldOffset(Offset = "0x8")]
		internal uint processId;

		[Token(Token = "0x401189A")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBigEvent_GlobalProgress _0024this;

		[Token(Token = "0x401189B")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x601321B")]
		[Address(RVA = "0x260E640", Offset = "0x260E640", VA = "0x260E640")]
		public _003CRequestClaimProcessRewards_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601321C")]
		[Address(RVA = "0x260EF70", Offset = "0x260EF70", VA = "0x260EF70")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601321D")]
		[Address(RVA = "0x260F41C", Offset = "0x260F41C", VA = "0x260F41C")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x4011892")]
	[FieldOffset(Offset = "0x10")]
	private ulong m_CurrentGloabalProgressValue;

	[Token(Token = "0x4011893")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<uint, CustomEventProcessSettingDesc> DictProcessSettings;

	[Token(Token = "0x4011894")]
	[FieldOffset(Offset = "0x1C")]
	public List<uint> ListProcessIdHaveClaimedReward;

	[Token(Token = "0x4011895")]
	public const int PropID_GetProcessSettingDesc = 2;

	[Token(Token = "0x4011896")]
	public const int PropID_GetRewardStateInfo = 4;

	[Token(Token = "0x4011897")]
	public const int PropID_GetGlobalProgressValue = 8;

	[Token(Token = "0x4011898")]
	public const int PropID_ClaimProcessRewards = 16;

	[Token(Token = "0x6013201")]
	[Address(RVA = "0x260CC38", Offset = "0x260CC38", VA = "0x260CC38")]
	public UIModelBigEvent_GlobalProgress()
	{
	}

	[Token(Token = "0x6013202")]
	[Address(RVA = "0x260CD24", Offset = "0x260CD24", VA = "0x260CD24", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013203")]
	[Address(RVA = "0x260CD7C", Offset = "0x260CD7C", VA = "0x260CD7C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6013204")]
	[Address(RVA = "0x260CEC8", Offset = "0x260CEC8", VA = "0x260CEC8", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6013205")]
	[Address(RVA = "0x260CF40", Offset = "0x260CF40", VA = "0x260CF40", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013206")]
	[Address(RVA = "0x260CDE8", Offset = "0x260CDE8", VA = "0x260CDE8")]
	private void ClearCachedData()
	{
	}

	[Token(Token = "0x6013207")]
	[Address(RVA = "0x260CFB8", Offset = "0x260CFB8", VA = "0x260CFB8")]
	public bool HasGetProcessSetting()
	{
		return default(bool);
	}

	[Token(Token = "0x6013208")]
	[Address(RVA = "0x260D07C", Offset = "0x260D07C", VA = "0x260D07C")]
	private CustomEventProcessSettingDesc GetProcessSettingByProcessId(uint processId)
	{
		return null;
	}

	[Token(Token = "0x6013209")]
	[Address(RVA = "0x260D188", Offset = "0x260D188", VA = "0x260D188")]
	public List<AwardDesc> GetRewardsByProcessId(uint processId)
	{
		return null;
	}

	[Token(Token = "0x601320A")]
	[Address(RVA = "0x260D204", Offset = "0x260D204", VA = "0x260D204")]
	public float GetCurrentGlobalProgressPercentage()
	{
		return default(float);
	}

	[Token(Token = "0x601320B")]
	[Address(RVA = "0x260D628", Offset = "0x260D628", VA = "0x260D628")]
	public ulong GetCurrentGlobalProgressValue()
	{
		return default(ulong);
	}

	[Token(Token = "0x601320C")]
	[Address(RVA = "0x260D2B0", Offset = "0x260D2B0", VA = "0x260D2B0")]
	private ulong GetMaxGloabalProgressValue()
	{
		return default(ulong);
	}

	[Token(Token = "0x601320D")]
	[Address(RVA = "0x260D680", Offset = "0x260D680", VA = "0x260D680")]
	public ulong GetGlobalProgressEndValueByProcessId(uint process)
	{
		return default(ulong);
	}

	[Token(Token = "0x601320E")]
	[Address(RVA = "0x260D704", Offset = "0x260D704", VA = "0x260D704")]
	public float GetGlobalProgressPercentageByProcessId(uint process)
	{
		return default(float);
	}

	[Token(Token = "0x601320F")]
	[Address(RVA = "0x260D7CC", Offset = "0x260D7CC", VA = "0x260D7CC")]
	public int GetCanClaimRewardCount()
	{
		return default(int);
	}

	[Token(Token = "0x6013210")]
	[Address(RVA = "0x260DAD0", Offset = "0x260DAD0", VA = "0x260DAD0")]
	public bool GetRewardStateByIndex(uint processId, out EActivity.State state)
	{
		return default(bool);
	}

	[Token(Token = "0x6013211")]
	[Address(RVA = "0x260DC18", Offset = "0x260DC18", VA = "0x260DC18")]
	public void RequestGlobalProgressSetting(bool forceReq = false)
	{
	}

	[Token(Token = "0x6013212")]
	[Address(RVA = "0x260DF8C", Offset = "0x260DF8C", VA = "0x260DF8C")]
	public void RequestGetCurrentGlobalProgressValue()
	{
	}

	[Token(Token = "0x6013213")]
	[Address(RVA = "0x260E290", Offset = "0x260E290", VA = "0x260E290")]
	public void RequestClaimProcessRewards(uint processId)
	{
	}

	[Token(Token = "0x6013214")]
	[Address(RVA = "0x260E648", Offset = "0x260E648", VA = "0x260E648")]
	public void RequestGetRewardState()
	{
	}

	[Token(Token = "0x6013215")]
	[Address(RVA = "0x260E94C", Offset = "0x260E94C", VA = "0x260E94C")]
	private void _003CRequestGlobalProgressSetting_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013216")]
	[Address(RVA = "0x260EBF0", Offset = "0x260EBF0", VA = "0x260EBF0")]
	private void _003CRequestGetCurrentGlobalProgressValue_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013217")]
	[Address(RVA = "0x260EDA8", Offset = "0x260EDA8", VA = "0x260EDA8")]
	private void _003CRequestGetRewardState_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013218")]
	[Address(RVA = "0x260EF58", Offset = "0x260EF58", VA = "0x260EF58")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6013219")]
	[Address(RVA = "0x260EF60", Offset = "0x260EF60", VA = "0x260EF60")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x601321A")]
	[Address(RVA = "0x260EF68", Offset = "0x260EF68", VA = "0x260EF68")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
