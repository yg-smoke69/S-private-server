using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003073")]
public class UIModelGacha : UIBaseModel
{
	[Token(Token = "0x2003074")]
	private class GachaCachePref
	{
		[Token(Token = "0x401273B")]
		[FieldOffset(Offset = "0x8")]
		public uint id;

		[Token(Token = "0x401273C")]
		[FieldOffset(Offset = "0xC")]
		public uint subId;

		[Token(Token = "0x60144BB")]
		[Address(RVA = "0x319E44C", Offset = "0x319E44C", VA = "0x319E44C")]
		public GachaCachePref()
		{
		}
	}

	[Token(Token = "0x2003075")]
	private class GachaCachePrefs
	{
		[Token(Token = "0x401273D")]
		[FieldOffset(Offset = "0x8")]
		public List<GachaCachePref> gachaCaches;

		[Token(Token = "0x60144BC")]
		[Address(RVA = "0x3196EBC", Offset = "0x3196EBC", VA = "0x3196EBC")]
		public GachaCachePrefs()
		{
		}
	}

	[Token(Token = "0x2003076")]
	private enum GachaAnimState
	{
		[Token(Token = "0x401273F")]
		NO_PLAYED,
		[Token(Token = "0x4012740")]
		PLAYERD
	}

	[Token(Token = "0x2003077")]
	private enum GachaFreeType
	{
		[Token(Token = "0x4012742")]
		Free = 1
	}

	[Token(Token = "0x2003078")]
	public enum GachaActivityType
	{
		[Token(Token = "0x4012744")]
		NONE,
		[Token(Token = "0x4012745")]
		ACTIVITY_TYPE1,
		[Token(Token = "0x4012746")]
		ACTIVITY_TYPE2
	}

	[Token(Token = "0x2003079")]
	public enum LotteryTheme
	{
		[Token(Token = "0x4012748")]
		THEME1 = 1,
		[Token(Token = "0x4012749")]
		THEME2
	}

	[Token(Token = "0x200307A")]
	public enum GachaDrawType
	{
		[Token(Token = "0x401274B")]
		TYPE_NONE,
		[Token(Token = "0x401274C")]
		TYPE_SINGLE,
		[Token(Token = "0x401274D")]
		TYPE_MULTI,
		[Token(Token = "0x401274E")]
		TYPE_BUFF_BUY,
		[Token(Token = "0x401274F")]
		TYPE_BUFF_REFRESH,
		[Token(Token = "0x4012750")]
		TYPE_RERANDOM
	}

	[Token(Token = "0x200307B")]
	public enum ChestHintColor
	{
		[Token(Token = "0x4012752")]
		WHITE,
		[Token(Token = "0x4012753")]
		BLACK
	}

	[Token(Token = "0x200307C")]
	public enum LimitResetType
	{
		[Token(Token = "0x4012755")]
		NONE,
		[Token(Token = "0x4012756")]
		DAILY,
		[Token(Token = "0x4012757")]
		TERM
	}

	[Token(Token = "0x200307D")]
	private sealed class _003CSortHackerStoreShowItem_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012758")]
		[FieldOffset(Offset = "0x8")]
		internal uint gachaID;

		[Token(Token = "0x4012759")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144BD")]
		[Address(RVA = "0x3190CD8", Offset = "0x3190CD8", VA = "0x3190CD8")]
		public _003CSortHackerStoreShowItem_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60144BE")]
		[Address(RVA = "0x31A6B10", Offset = "0x31A6B10", VA = "0x31A6B10")]
		internal bool _003C_003Em__0(LimitedChestGoods good)
		{
			return default(bool);
		}

		[Token(Token = "0x60144BF")]
		[Address(RVA = "0x31A6B7C", Offset = "0x31A6B7C", VA = "0x31A6B7C")]
		internal bool _003C_003Em__1(LimitedChestGoods good)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200307E")]
	private sealed class _003CGethackerStoreShowItemInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x401275A")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x60144C0")]
		[Address(RVA = "0x3191008", Offset = "0x3191008", VA = "0x3191008")]
		public _003CGethackerStoreShowItemInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60144C1")]
		[Address(RVA = "0x31A30C8", Offset = "0x31A30C8", VA = "0x31A30C8")]
		internal bool _003C_003Em__0(GachaShowItem info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200307F")]
	private sealed class _003CRequestLimitedChestProbability_003Ec__AnonStorey2
	{
		[Token(Token = "0x401275B")]
		[FieldOffset(Offset = "0x8")]
		internal uint chestID;

		[Token(Token = "0x401275C")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144C2")]
		[Address(RVA = "0x3192DF8", Offset = "0x3192DF8", VA = "0x3192DF8")]
		public _003CRequestLimitedChestProbability_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60144C3")]
		[Address(RVA = "0x31A62E0", Offset = "0x31A62E0", VA = "0x31A62E0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003080")]
	private sealed class _003CSelectHackerStoreLimitedChestPrize_003Ec__AnonStorey3
	{
		[Token(Token = "0x401275D")]
		[FieldOffset(Offset = "0x8")]
		internal uint gachaID;

		[Token(Token = "0x401275E")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144C4")]
		[Address(RVA = "0x31933B4", Offset = "0x31933B4", VA = "0x31933B4")]
		public _003CSelectHackerStoreLimitedChestPrize_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60144C5")]
		[Address(RVA = "0x31A699C", Offset = "0x31A699C", VA = "0x31A699C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003081")]
	private sealed class _003CRequestRemoveGachaLimitItems_003Ec__AnonStorey4
	{
		[Token(Token = "0x401275F")]
		[FieldOffset(Offset = "0x8")]
		internal uint gachaID;

		[Token(Token = "0x4012760")]
		[FieldOffset(Offset = "0xC")]
		internal List<uint> removeItems;

		[Token(Token = "0x4012761")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144C6")]
		[Address(RVA = "0x3194C40", Offset = "0x3194C40", VA = "0x3194C40")]
		public _003CRequestRemoveGachaLimitItems_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60144C7")]
		[Address(RVA = "0x31A678C", Offset = "0x31A678C", VA = "0x31A678C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003082")]
	private sealed class _003CRequestDoGachaSpecialExchange_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012762")]
		[FieldOffset(Offset = "0x8")]
		internal ChestSpecialExchangeDesc exchangeDes;

		[Token(Token = "0x4012763")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144C8")]
		[Address(RVA = "0x3198204", Offset = "0x3198204", VA = "0x3198204")]
		public _003CRequestDoGachaSpecialExchange_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x60144C9")]
		[Address(RVA = "0x31A4918", Offset = "0x31A4918", VA = "0x31A4918")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60144CA")]
		[Address(RVA = "0x31A4D80", Offset = "0x31A4D80", VA = "0x31A4D80")]
		internal CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2003083")]
	private sealed class _003CRequestGachaInfoRes_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012764")]
		[FieldOffset(Offset = "0x8")]
		internal bool isSpecial;

		[Token(Token = "0x4012765")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144CB")]
		[Address(RVA = "0x319882C", Offset = "0x319882C", VA = "0x319882C")]
		public _003CRequestGachaInfoRes_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60144CC")]
		[Address(RVA = "0x31A4DDC", Offset = "0x31A4DDC", VA = "0x31A4DDC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003084")]
	private sealed class _003CRequestGachaProbability_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012766")]
		[FieldOffset(Offset = "0x8")]
		internal uint gachaId;

		[Token(Token = "0x4012767")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144CD")]
		[Address(RVA = "0x3198CDC", Offset = "0x3198CDC", VA = "0x3198CDC")]
		public _003CRequestGachaProbability_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60144CE")]
		[Address(RVA = "0x31A57F4", Offset = "0x31A57F4", VA = "0x31A57F4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003085")]
	private sealed class _003CExchangeGachaExtraReward_003Ec__AnonStorey8
	{
		[Token(Token = "0x4012768")]
		[FieldOffset(Offset = "0x8")]
		internal CSLotteryExtraRewardReq req;

		[Token(Token = "0x4012769")]
		[FieldOffset(Offset = "0xC")]
		internal uint chestID;

		[Token(Token = "0x401276A")]
		[FieldOffset(Offset = "0x10")]
		internal uint condition_num;

		[Token(Token = "0x401276B")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144CF")]
		[Address(RVA = "0x31990D4", Offset = "0x31990D4", VA = "0x31990D4")]
		public _003CExchangeGachaExtraReward_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60144D0")]
		[Address(RVA = "0x31A2A10", Offset = "0x31A2A10", VA = "0x31A2A10")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003086")]
	private sealed class _003CPurchase_003Ec__AnonStorey9
	{
		[Token(Token = "0x401276C")]
		[FieldOffset(Offset = "0x8")]
		internal uint chestID;

		[Token(Token = "0x401276D")]
		[FieldOffset(Offset = "0xC")]
		internal GachaDrawType drawType;

		[Token(Token = "0x401276E")]
		[FieldOffset(Offset = "0x10")]
		internal uint jackpotID;

		[Token(Token = "0x401276F")]
		[FieldOffset(Offset = "0x14")]
		internal bool isRepurchase;

		[Token(Token = "0x4012770")]
		[FieldOffset(Offset = "0x18")]
		internal CSLotteryReq req;

		[Token(Token = "0x4012771")]
		[FieldOffset(Offset = "0x1C")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144D1")]
		[Address(RVA = "0x319992C", Offset = "0x319992C", VA = "0x319992C")]
		public _003CPurchase_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x60144D2")]
		[Address(RVA = "0x31A328C", Offset = "0x31A328C", VA = "0x31A328C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003087")]
	private sealed class _003CPurchase_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4012772")]
		[FieldOffset(Offset = "0x8")]
		internal CSPurchaseLimitedChestReq msgReq;

		[Token(Token = "0x4012773")]
		[FieldOffset(Offset = "0xC")]
		internal _003CPurchase_003Ec__AnonStorey9 _003C_003Ef__ref_00249;

		[Token(Token = "0x60144D3")]
		[Address(RVA = "0x3199934", Offset = "0x3199934", VA = "0x3199934")]
		public _003CPurchase_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x60144D4")]
		[Address(RVA = "0x31A3D90", Offset = "0x31A3D90", VA = "0x31A3D90")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003088")]
	private sealed class _003CHasNewGacha_003Ec__AnonStoreyB
	{
		[Token(Token = "0x4012774")]
		[FieldOffset(Offset = "0x8")]
		internal KeyValuePair<uint, GachaPackageInfoData> gachaDesc;

		[Token(Token = "0x60144D5")]
		[Address(RVA = "0x319DFE4", Offset = "0x319DFE4", VA = "0x319DFE4")]
		public _003CHasNewGacha_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x60144D6")]
		[Address(RVA = "0x31A30FC", Offset = "0x31A30FC", VA = "0x31A30FC")]
		internal bool _003C_003Em__0(GachaCachePref item)
		{
			return default(bool);
		}

		[Token(Token = "0x60144D7")]
		[Address(RVA = "0x31A3188", Offset = "0x31A3188", VA = "0x31A3188")]
		internal bool _003C_003Em__1(GachaCachePref item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003089")]
	private sealed class _003CGetGachaShowItemInfo_003Ec__AnonStoreyC
	{
		[Token(Token = "0x4012775")]
		[FieldOffset(Offset = "0x8")]
		internal uint itmID;

		[Token(Token = "0x4012776")]
		[FieldOffset(Offset = "0xC")]
		internal uint duration;

		[Token(Token = "0x60144D8")]
		[Address(RVA = "0x319EB68", Offset = "0x319EB68", VA = "0x319EB68")]
		public _003CGetGachaShowItemInfo_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x60144D9")]
		[Address(RVA = "0x31A2DC4", Offset = "0x31A2DC4", VA = "0x31A2DC4")]
		internal bool _003C_003Em__0(GachaShowItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200308A")]
	private sealed class _003CGetGachaShowItemInfoByID_003Ec__AnonStoreyD
	{
		[Token(Token = "0x4012777")]
		[FieldOffset(Offset = "0x8")]
		internal uint gachaShowItemID;

		[Token(Token = "0x60144DA")]
		[Address(RVA = "0x319F0B8", Offset = "0x319F0B8", VA = "0x319F0B8")]
		public _003CGetGachaShowItemInfoByID_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x60144DB")]
		[Address(RVA = "0x31A2E10", Offset = "0x31A2E10", VA = "0x31A2E10")]
		internal bool _003C_003Em__0(GachaShowItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200308B")]
	private sealed class _003CFindGachaIdListIdx_003Ec__AnonStoreyE
	{
		[Token(Token = "0x4012778")]
		[FieldOffset(Offset = "0x8")]
		internal uint chestID;

		[Token(Token = "0x60144DC")]
		[Address(RVA = "0x319F850", Offset = "0x319F850", VA = "0x319F850")]
		public _003CFindGachaIdListIdx_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x60144DD")]
		[Address(RVA = "0x31A2D9C", Offset = "0x31A2D9C", VA = "0x31A2D9C")]
		internal bool _003C_003Em__0(uint item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200308C")]
	private sealed class _003CCheckAwardInGacha_003Ec__AnonStoreyF
	{
		[Token(Token = "0x4012779")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x60144DE")]
		[Address(RVA = "0x319FCE8", Offset = "0x319FCE8", VA = "0x319FCE8")]
		public _003CCheckAwardInGacha_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x60144DF")]
		[Address(RVA = "0x31A2868", Offset = "0x31A2868", VA = "0x31A2868")]
		internal bool _003C_003Em__0(GachaShowItem item)
		{
			return default(bool);
		}

		[Token(Token = "0x60144E0")]
		[Address(RVA = "0x31A28A0", Offset = "0x31A28A0", VA = "0x31A28A0")]
		internal bool _003C_003Em__1(GachaShowItem item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200308D")]
	private sealed class _003CGetNotifyInfo_003Ec__AnonStorey10
	{
		[Token(Token = "0x401277A")]
		[FieldOffset(Offset = "0x8")]
		internal string gachaName;

		[Token(Token = "0x60144E1")]
		[Address(RVA = "0x31A0EE8", Offset = "0x31A0EE8", VA = "0x31A0EE8")]
		public _003CGetNotifyInfo_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x60144E2")]
		[Address(RVA = "0x31A2E48", Offset = "0x31A2E48", VA = "0x31A2E48")]
		internal string _003C_003Em__0()
		{
			return null;
		}

		[Token(Token = "0x60144E3")]
		[Address(RVA = "0x31A2F88", Offset = "0x31A2F88", VA = "0x31A2F88")]
		internal string _003C_003Em__1()
		{
			return null;
		}
	}

	[Token(Token = "0x200308E")]
	private sealed class _003CRequestGetEnergyGachaBuffInfo_003Ec__AnonStorey11
	{
		[Token(Token = "0x401277B")]
		[FieldOffset(Offset = "0x8")]
		internal uint gachaID;

		[Token(Token = "0x401277C")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144E4")]
		[Address(RVA = "0x31A13FC", Offset = "0x31A13FC", VA = "0x31A13FC")]
		public _003CRequestGetEnergyGachaBuffInfo_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x60144E5")]
		[Address(RVA = "0x31A59DC", Offset = "0x31A59DC", VA = "0x31A59DC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x200308F")]
	private sealed class _003CRequestRefreshEnergyGachaBuffInfo_003Ec__AnonStorey12
	{
		[Token(Token = "0x401277D")]
		[FieldOffset(Offset = "0x8")]
		internal uint gachaID;

		[Token(Token = "0x401277E")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144E6")]
		[Address(RVA = "0x31A16D4", Offset = "0x31A16D4", VA = "0x31A16D4")]
		public _003CRequestRefreshEnergyGachaBuffInfo_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x60144E7")]
		[Address(RVA = "0x31A64C8", Offset = "0x31A64C8", VA = "0x31A64C8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003090")]
	private sealed class _003CRequestLegendaryGachaGainItems_003Ec__AnonStorey13
	{
		[Token(Token = "0x401277F")]
		[FieldOffset(Offset = "0x8")]
		internal uint gachaID;

		[Token(Token = "0x4012780")]
		[FieldOffset(Offset = "0xC")]
		internal uint[] itemsIDs;

		[Token(Token = "0x4012781")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x4012782")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x60144E8")]
		[Address(RVA = "0x31A1A4C", Offset = "0x31A1A4C", VA = "0x31A1A4C")]
		public _003CRequestLegendaryGachaGainItems_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x60144E9")]
		[Address(RVA = "0x31A5CA0", Offset = "0x31A5CA0", VA = "0x31A5CA0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x60144EA")]
		[Address(RVA = "0x31A6060", Offset = "0x31A6060", VA = "0x31A6060")]
		private static CommonRewardItemInfo _003C_003Em__1(ExchangedAward item)
		{
			return null;
		}
	}

	[Token(Token = "0x2003091")]
	private sealed class _003CRequestLegendaryGachaRerandomItems_003Ec__AnonStorey14
	{
		[Token(Token = "0x4012783")]
		[FieldOffset(Offset = "0x8")]
		internal uint gachaID;

		[Token(Token = "0x4012784")]
		[FieldOffset(Offset = "0xC")]
		internal uint[] itemsIDs;

		[Token(Token = "0x4012785")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelGacha _0024this;

		[Token(Token = "0x60144EB")]
		[Address(RVA = "0x31A1DC4", Offset = "0x31A1DC4", VA = "0x31A1DC4")]
		public _003CRequestLegendaryGachaRerandomItems_003Ec__AnonStorey14()
		{
		}

		[Token(Token = "0x60144EC")]
		[Address(RVA = "0x31A6068", Offset = "0x31A6068", VA = "0x31A6068")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x4012707")]
	[FieldOffset(Offset = "0xC")]
	private UIDataModelGacha m_DataModel;

	[Token(Token = "0x4012708")]
	[FieldOffset(Offset = "0x10")]
	private bool _003CNoShowConfirmWnd_003Ek__BackingField;

	[Token(Token = "0x4012709")]
	[FieldOffset(Offset = "0x11")]
	private bool _003CNoShowLobbyGachaConfirmWnd_003Ek__BackingField;

	[Token(Token = "0x401270A")]
	[FieldOffset(Offset = "0x12")]
	private bool _003CNoShowLengendaryBagPackGainConfirmWnd_003Ek__BackingField;

	[Token(Token = "0x401270B")]
	[FieldOffset(Offset = "0x13")]
	private bool _003CNoShowLobbyGachaBagPackGainConfirmWnd_003Ek__BackingField;

	[Token(Token = "0x401270C")]
	[FieldOffset(Offset = "0x14")]
	private bool _003CNoShowLengendaryBagPackReRandomConfirmWnd_003Ek__BackingField;

	[Token(Token = "0x401270D")]
	[FieldOffset(Offset = "0x15")]
	private bool _003CNoShowLobbyGachaBagPackReRandomConfirmWnd_003Ek__BackingField;

	[Token(Token = "0x401270E")]
	[FieldOffset(Offset = "0x18")]
	private List<uint> m_GachaSortedIDs;

	[Token(Token = "0x401270F")]
	[FieldOffset(Offset = "0x1C")]
	private uint m_LobbyGachaId;

	[Token(Token = "0x4012710")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<uint, bool> m_IsResetEPDict;

	[Token(Token = "0x4012711")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, CSGetLotteryProbabilityRes> m_GachaRareProbability;

	[Token(Token = "0x4012712")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, UIGachaSceneShowType> m_CurrentShowTypeDic;

	[Token(Token = "0x4012713")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, List<uint>> m_RemoveItemsDic;

	[Token(Token = "0x4012714")]
	public const uint GACHALIMIT_REMOVE_COUNT = 2u;

	[Token(Token = "0x4012715")]
	public const uint GACHALIMIT_ALL_COUNT = 10u;

	[Token(Token = "0x4012716")]
	public const int MAXITEMNUMCANSELECT = 99;

	[Token(Token = "0x4012717")]
	public const int MAXITEMNUMINPACKAGE = 99;

	[Token(Token = "0x4012718")]
	[FieldOffset(Offset = "0x30")]
	private CSGetGachaInfoRes m_InfoRes;

	[Token(Token = "0x4012719")]
	[FieldOffset(Offset = "0x34")]
	private GachaCachePrefs m_CacheGachaPrefs;

	[Token(Token = "0x401271A")]
	private const string Prefs_CacheGachaIdSubIds = "CacheGachaIdSubIds";

	[Token(Token = "0x401271B")]
	private const string m_GachaAnimPrefix = "GACHA_FULLSCREEN_ANIM";

	[Token(Token = "0x401271C")]
	public const uint PropID_GachaAds_Update = 16u;

	[Token(Token = "0x401271D")]
	public const uint PropID_GachaInfo_Update = 32u;

	[Token(Token = "0x401271E")]
	public const uint PropID_PurchaseSuccess = 64u;

	[Token(Token = "0x401271F")]
	public const uint PropID_GachaDesc_Update = 128u;

	[Token(Token = "0x4012720")]
	public const uint PropID_NoGachaData = 256u;

	[Token(Token = "0x4012721")]
	public const uint PropID_PurchaseFailed = 512u;

	[Token(Token = "0x4012722")]
	public const uint PropID_Gacha_Probability_Getted = 1024u;

	[Token(Token = "0x4012723")]
	public const uint PropID_GachaSpDesc_Update = 2048u;

	[Token(Token = "0x4012724")]
	public const uint PropID_GachaSpExchange_Success = 4096u;

	[Token(Token = "0x4012725")]
	public const uint PropID_ShouldNotifyChange = 8192u;

	[Token(Token = "0x4012726")]
	public const uint PropID_PurchaseBuffSuccess = 16384u;

	[Token(Token = "0x4012727")]
	public const uint PropID_SpicalDrawDataUpdate = 32768u;

	[Token(Token = "0x4012728")]
	public const uint PropID_GachaLimitPoolStateUpdate = 65536u;

	[Token(Token = "0x4012729")]
	public const uint PropID_GachaRefreshEnergyBuff = 131072u;

	[Token(Token = "0x401272A")]
	public const uint PropID_GachaGainBagItems = 262144u;

	[Token(Token = "0x401272B")]
	public const uint PropID_GachaReRandomBagItems = 524288u;

	[Token(Token = "0x401272C")]
	public const uint PropID_GachaLimitedChestInfoUpdate = 1048576u;

	[Token(Token = "0x401272D")]
	public const uint PropID_GachaLimitedChestProbabilityUpdate = 2097152u;

	[Token(Token = "0x401272E")]
	public const uint PropID_GachaInfo_Update_Failed = 4194304u;

	[Token(Token = "0x401272F")]
	[FieldOffset(Offset = "0x38")]
	private CSGetLimitedChestInfoRes m_hackerStoreInfo;

	[Token(Token = "0x4012730")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, List<LimitedChestGoods>> m_hackerStoreShowItemIDs;

	[Token(Token = "0x4012731")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, uint> m_hackerStoreCacheRewardID;

	[Token(Token = "0x4012732")]
	private const string cm_strShowLimitChestSplashKey = "LimitChestSplash{0}_{1}";

	[Token(Token = "0x4012733")]
	public const int HackerStoreRareTypeSuperRareIndex = 2;

	[Token(Token = "0x4012734")]
	public const int HackerStoreRareTypeRareIndex = 3;

	[Token(Token = "0x4012735")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, CSGetLimitedChestProbabilityRes> m_limitChestRareProbabilitys;

	[Token(Token = "0x4012736")]
	[FieldOffset(Offset = "0x0")]
	private static Func<GachaShowItem, bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012737")]
	[FieldOffset(Offset = "0x4")]
	private static Func<GachaShowItem, bool> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012738")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<CSSharedItemData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4012739")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<ExtraRewardDesc, int> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x401273A")]
	[FieldOffset(Offset = "0x10")]
	private static Func<uint, bool> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x1700150C")]
	public bool NoShowConfirmWnd
	{
		[Token(Token = "0x601440D")]
		[Address(RVA = "0x31906D0", Offset = "0x31906D0", VA = "0x31906D0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601440E")]
		[Address(RVA = "0x31906D8", Offset = "0x31906D8", VA = "0x31906D8")]
		set
		{
		}
	}

	[Token(Token = "0x1700150D")]
	public bool NoShowLobbyGachaConfirmWnd
	{
		[Token(Token = "0x601440F")]
		[Address(RVA = "0x31906E0", Offset = "0x31906E0", VA = "0x31906E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014410")]
		[Address(RVA = "0x31906E8", Offset = "0x31906E8", VA = "0x31906E8")]
		set
		{
		}
	}

	[Token(Token = "0x1700150E")]
	public bool NoShowLengendaryBagPackGainConfirmWnd
	{
		[Token(Token = "0x6014411")]
		[Address(RVA = "0x31906F0", Offset = "0x31906F0", VA = "0x31906F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014412")]
		[Address(RVA = "0x31906F8", Offset = "0x31906F8", VA = "0x31906F8")]
		set
		{
		}
	}

	[Token(Token = "0x1700150F")]
	public bool NoShowLobbyGachaBagPackGainConfirmWnd
	{
		[Token(Token = "0x6014413")]
		[Address(RVA = "0x3190700", Offset = "0x3190700", VA = "0x3190700")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014414")]
		[Address(RVA = "0x3190708", Offset = "0x3190708", VA = "0x3190708")]
		set
		{
		}
	}

	[Token(Token = "0x17001510")]
	public bool NoShowLengendaryBagPackReRandomConfirmWnd
	{
		[Token(Token = "0x6014415")]
		[Address(RVA = "0x3190710", Offset = "0x3190710", VA = "0x3190710")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014416")]
		[Address(RVA = "0x3190718", Offset = "0x3190718", VA = "0x3190718")]
		set
		{
		}
	}

	[Token(Token = "0x17001511")]
	public bool NoShowLobbyGachaBagPackReRandomConfirmWnd
	{
		[Token(Token = "0x6014417")]
		[Address(RVA = "0x3190720", Offset = "0x3190720", VA = "0x3190720")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014418")]
		[Address(RVA = "0x3190728", Offset = "0x3190728", VA = "0x3190728")]
		set
		{
		}
	}

	[Token(Token = "0x601440C")]
	[Address(RVA = "0x3190514", Offset = "0x3190514", VA = "0x3190514")]
	public UIModelGacha()
	{
	}

	[Token(Token = "0x6014419")]
	[Address(RVA = "0x3190730", Offset = "0x3190730", VA = "0x3190730", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601441A")]
	[Address(RVA = "0x31907F4", Offset = "0x31907F4", VA = "0x31907F4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601441B")]
	[Address(RVA = "0x319084C", Offset = "0x319084C", VA = "0x319084C")]
	private void SortHackerStoreShowItem(uint gachaID)
	{
	}

	[Token(Token = "0x601441C")]
	[Address(RVA = "0x3190D98", Offset = "0x3190D98", VA = "0x3190D98")]
	public GachaShowItem GethackerStoreShowItemInfo(uint gachaID, uint id)
	{
		return null;
	}

	[Token(Token = "0x601441D")]
	[Address(RVA = "0x3191010", Offset = "0x3191010", VA = "0x3191010")]
	public ELottery.RareType GetLimitChestGoodsStatus(uint gachaID, uint id)
	{
		return default(ELottery.RareType);
	}

	[Token(Token = "0x601441E")]
	[Address(RVA = "0x3191224", Offset = "0x3191224", VA = "0x3191224")]
	public uint GetLimitChestGoodIDByGachaIDAndRareType(uint gachaID, ELottery.RareType rareType)
	{
		return default(uint);
	}

	[Token(Token = "0x601441F")]
	[Address(RVA = "0x3191468", Offset = "0x3191468", VA = "0x3191468")]
	public bool IsShowLimitChestSplashCDN(uint gachaID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014420")]
	[Address(RVA = "0x3191710", Offset = "0x3191710", VA = "0x3191710")]
	public void ShowedLimitChestSplashCDN(uint gachaID)
	{
	}

	[Token(Token = "0x6014421")]
	[Address(RVA = "0x3191880", Offset = "0x3191880", VA = "0x3191880")]
	public List<int> GetHackerStorePurchasedAnimatorIndexes(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x6014422")]
	[Address(RVA = "0x3191C90", Offset = "0x3191C90", VA = "0x3191C90")]
	private uint GetHackerStorePurchaseCnt(uint gachaID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014423")]
	[Address(RVA = "0x3191A90", Offset = "0x3191A90", VA = "0x3191A90")]
	public uint GetCacheHackerStoreLastGetID(uint gachaID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014424")]
	[Address(RVA = "0x3191E64", Offset = "0x3191E64", VA = "0x3191E64")]
	private void CacheHackerStoreLastGetID(uint gachaID, uint gachaRewardID)
	{
	}

	[Token(Token = "0x6014425")]
	[Address(RVA = "0x3191F8C", Offset = "0x3191F8C", VA = "0x3191F8C")]
	private void RefreshHackerStoreShowItems()
	{
	}

	[Token(Token = "0x6014426")]
	[Address(RVA = "0x3192218", Offset = "0x3192218", VA = "0x3192218")]
	private void UpdateHackerStoreShowItemState(uint gachaID, uint gachaRewardID)
	{
	}

	[Token(Token = "0x6014427")]
	[Address(RVA = "0x31923EC", Offset = "0x31923EC", VA = "0x31923EC")]
	private void RefreshHackerStoreShowItemsBySelectRes(uint chestID, uint[] goods)
	{
	}

	[Token(Token = "0x6014428")]
	[Address(RVA = "0x319263C", Offset = "0x319263C", VA = "0x319263C")]
	public bool IsPurchasedForHackerStore(uint chestID, uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014429")]
	[Address(RVA = "0x3192814", Offset = "0x3192814", VA = "0x3192814")]
	public bool IsAllPurchasedForHackerStore(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x601442A")]
	[Address(RVA = "0x31929A0", Offset = "0x31929A0", VA = "0x31929A0")]
	public void RequestLimitedChestProbability(uint chestID)
	{
	}

	[Token(Token = "0x601442B")]
	[Address(RVA = "0x3192E00", Offset = "0x3192E00", VA = "0x3192E00")]
	public void ReqeustHackerStoreInfo(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x601442C")]
	[Address(RVA = "0x319306C", Offset = "0x319306C", VA = "0x319306C")]
	public void SelectHackerStoreLimitedChestPrize(uint gachaID, uint firstItemID, uint secondItemID)
	{
	}

	[Token(Token = "0x601442D")]
	[Address(RVA = "0x31933BC", Offset = "0x31933BC", VA = "0x31933BC")]
	public bool IsHackerStoreSelected(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x601442E")]
	[Address(RVA = "0x3191B74", Offset = "0x3191B74", VA = "0x3191B74")]
	public List<LimitedChestGoods> GetHackerStoreShowItemIDs(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601442F")]
	[Address(RVA = "0x31934E0", Offset = "0x31934E0", VA = "0x31934E0")]
	public GachaShowItem[] GetHackerStoreSelectPageItem1(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6014430")]
	[Address(RVA = "0x3193774", Offset = "0x3193774", VA = "0x3193774")]
	public GachaShowItem[] GetHackerStoreSelectPageItem2(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6014431")]
	[Address(RVA = "0x3193A04", Offset = "0x3193A04", VA = "0x3193A04")]
	private int SortGachaShowItemList(GachaShowItem itemA, GachaShowItem itemB)
	{
		return default(int);
	}

	[Token(Token = "0x6014432")]
	[Address(RVA = "0x3193E98", Offset = "0x3193E98", VA = "0x3193E98")]
	public List<uint> GetAllRemoveItems(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x6014433")]
	[Address(RVA = "0x3193FB0", Offset = "0x3193FB0", VA = "0x3193FB0")]
	public bool CheckRemoveListFull(uint gachaID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014434")]
	[Address(RVA = "0x31940E0", Offset = "0x31940E0", VA = "0x31940E0")]
	public bool GachaLimitRemoveListContain(uint gachaID, uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014435")]
	[Address(RVA = "0x3194210", Offset = "0x3194210", VA = "0x3194210")]
	public void SetCurrentShowType(uint gachaID, UIGachaSceneShowType sceneShowType)
	{
	}

	[Token(Token = "0x6014436")]
	[Address(RVA = "0x319435C", Offset = "0x319435C", VA = "0x319435C")]
	public int GetCurrentRemoveCnt(uint gachaID)
	{
		return default(int);
	}

	[Token(Token = "0x6014437")]
	[Address(RVA = "0x319447C", Offset = "0x319447C", VA = "0x319447C")]
	public void SetGachaLimitRemoveItems(uint GachaID, uint itemID)
	{
	}

	[Token(Token = "0x6014438")]
	[Address(RVA = "0x31946A8", Offset = "0x31946A8", VA = "0x31946A8")]
	public void CancelGachaLimitRemoveItems(uint GachaID, uint itemID)
	{
	}

	[Token(Token = "0x6014439")]
	[Address(RVA = "0x319483C", Offset = "0x319483C", VA = "0x319483C")]
	public void RequestRemoveGachaLimitItems(uint gachaID, uint subID)
	{
	}

	[Token(Token = "0x601443A")]
	[Address(RVA = "0x3194C48", Offset = "0x3194C48", VA = "0x3194C48")]
	public void GetGachaAdRes()
	{
	}

	[Token(Token = "0x601443B")]
	[Address(RVA = "0x3194D44", Offset = "0x3194D44", VA = "0x3194D44")]
	public List<AdvertDesc> GetCurAdList(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601443C")]
	[Address(RVA = "0x3194DDC", Offset = "0x3194DDC", VA = "0x3194DDC")]
	public AdvertDesc GetTabRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601443D")]
	[Address(RVA = "0x3194E74", Offset = "0x3194E74", VA = "0x3194E74")]
	public AdvertDesc GetTurntableCDNRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601443E")]
	[Address(RVA = "0x3194F0C", Offset = "0x3194F0C", VA = "0x3194F0C")]
	public AdvertDesc GachaCDNBgCDNRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601443F")]
	[Address(RVA = "0x3194FA4", Offset = "0x3194FA4", VA = "0x3194FA4")]
	public AdvertDesc GetLuckBagCDNRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6014440")]
	[Address(RVA = "0x319503C", Offset = "0x319503C", VA = "0x319503C")]
	public AdvertDesc GetTitleCDNBgRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6014441")]
	[Address(RVA = "0x31950D4", Offset = "0x31950D4", VA = "0x31950D4")]
	public AdvertDesc GetFrontEndCDNBgRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6014442")]
	[Address(RVA = "0x3191678", Offset = "0x3191678", VA = "0x3191678")]
	public AdvertDesc GetSplashCDNRes(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6014443")]
	[Address(RVA = "0x319516C", Offset = "0x319516C", VA = "0x319516C")]
	public ELottery.Type GetLotteryTypeByID(uint gachaID)
	{
		return default(ELottery.Type);
	}

	[Token(Token = "0x6014444")]
	[Address(RVA = "0x31951F0", Offset = "0x31951F0", VA = "0x31951F0")]
	public GachaActivityType GetChestActivityByID(uint chestID)
	{
		return default(GachaActivityType);
	}

	[Token(Token = "0x6014445")]
	[Address(RVA = "0x3195284", Offset = "0x3195284", VA = "0x3195284")]
	public uint GetDefGachaID()
	{
		return default(uint);
	}

	[Token(Token = "0x6014446")]
	[Address(RVA = "0x3195860", Offset = "0x3195860", VA = "0x3195860")]
	public GachaResultInfo GetGachaResultInfo(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6014447")]
	[Address(RVA = "0x3195994", Offset = "0x3195994", VA = "0x3195994")]
	public List<BaseItemInfo> GetGachaRewardPoolList(List<GachaShowItem> list)
	{
		return null;
	}

	[Token(Token = "0x6014448")]
	[Address(RVA = "0x3195BC4", Offset = "0x3195BC4", VA = "0x3195BC4")]
	public List<BaseItemInfo> GetGachaRewardPoolList(uint gachaID, uint rewardPoolID = 0u)
	{
		return null;
	}

	[Token(Token = "0x6014449")]
	[Address(RVA = "0x3195F6C", Offset = "0x3195F6C", VA = "0x3195F6C")]
	public CSSharedItemDataManager.StoreQuality GetCurrentGachaMaxQuality(uint chestID)
	{
		return default(CSSharedItemDataManager.StoreQuality);
	}

	[Token(Token = "0x601444A")]
	[Address(RVA = "0x3196268", Offset = "0x3196268", VA = "0x3196268")]
	public int GetGaChaCnt()
	{
		return default(int);
	}

	[Token(Token = "0x601444B")]
	[Address(RVA = "0x3196324", Offset = "0x3196324", VA = "0x3196324")]
	public Dictionary<uint, GachaInfoDataBase> GetAllGachaInfo()
	{
		return null;
	}

	[Token(Token = "0x601444C")]
	[Address(RVA = "0x3196394", Offset = "0x3196394", VA = "0x3196394", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601444D")]
	[Address(RVA = "0x3196570", Offset = "0x3196570", VA = "0x3196570")]
	public bool GetCurGachaAnimIsPlayed(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x601444E")]
	[Address(RVA = "0x31967FC", Offset = "0x31967FC", VA = "0x31967FC")]
	public FullscreenCgDesc GetCurGachaAnimData(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x601444F")]
	[Address(RVA = "0x3196B20", Offset = "0x3196B20", VA = "0x3196B20")]
	public void SetCurGachaAnimPlayed(uint chestID)
	{
	}

	[Token(Token = "0x6014450")]
	[Address(RVA = "0x3196CD4", Offset = "0x3196CD4", VA = "0x3196CD4")]
	private void InitCacheGachaIdSubId()
	{
	}

	[Token(Token = "0x6014451")]
	[Address(RVA = "0x3196EC4", Offset = "0x3196EC4", VA = "0x3196EC4")]
	public void ClearData()
	{
	}

	[Token(Token = "0x6014452")]
	[Address(RVA = "0x3196FE4", Offset = "0x3196FE4", VA = "0x3196FE4")]
	public void RequestGachaDescRes(uint httpOption = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014453")]
	[Address(RVA = "0x3197358", Offset = "0x3197358", VA = "0x3197358")]
	public void ProcessGachaDes(CSGetGachaDescRes gachaRes)
	{
	}

	[Token(Token = "0x6014454")]
	[Address(RVA = "0x3197988", Offset = "0x3197988", VA = "0x3197988")]
	public List<GachaDesc> GetSpicalChestDesc(ELottery.Type speicalType)
	{
		return null;
	}

	[Token(Token = "0x6014455")]
	[Address(RVA = "0x3197C4C", Offset = "0x3197C4C", VA = "0x3197C4C")]
	public void RequestGachaSpecialExchangeDesc(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014456")]
	[Address(RVA = "0x3197F00", Offset = "0x3197F00", VA = "0x3197F00")]
	public void RequestDoGachaSpecialExchange(ChestSpecialExchangeDesc exchangeDes, uint count = 1u)
	{
	}

	[Token(Token = "0x6014457")]
	[Address(RVA = "0x319820C", Offset = "0x319820C", VA = "0x319820C")]
	private List<BaseItemInfo> AssembleAwardList(List<Item> add_list, List<Item> del_list)
	{
		return null;
	}

	[Token(Token = "0x6014458")]
	[Address(RVA = "0x3198508", Offset = "0x3198508", VA = "0x3198508")]
	public void RequestGachaInfoRes(uint httpOption = 0u, bool isSpecial = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014459")]
	[Address(RVA = "0x3198898", Offset = "0x3198898", VA = "0x3198898")]
	public void RequestGachaProbability(uint gachaId, uint httpOption = 0u)
	{
	}

	[Token(Token = "0x601445A")]
	[Address(RVA = "0x3198CE4", Offset = "0x3198CE4", VA = "0x3198CE4")]
	public void ExchangeGachaExtraReward(uint chestID, uint condition_num)
	{
	}

	[Token(Token = "0x601445B")]
	[Address(RVA = "0x31990DC", Offset = "0x31990DC", VA = "0x31990DC")]
	private CSLotteryRes CSPurchaseLimitedChestRes2CSLotteryRes(CSPurchaseLimitedChestRes msg)
	{
		return null;
	}

	[Token(Token = "0x601445C")]
	[Address(RVA = "0x31991E0", Offset = "0x31991E0", VA = "0x31991E0")]
	public void Purchase(uint chestID, GachaDrawType drawType, ELottery.ConsumeType consumeType, bool isRepurchase = false, uint jackpotID = 0u)
	{
	}

	[Token(Token = "0x601445D")]
	[Address(RVA = "0x319993C", Offset = "0x319993C", VA = "0x319993C")]
	public void UpdateEPDict(uint chestID, bool IsReset)
	{
	}

	[Token(Token = "0x601445E")]
	[Address(RVA = "0x3199AD0", Offset = "0x3199AD0", VA = "0x3199AD0")]
	public bool IsEPReset(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x601445F")]
	[Address(RVA = "0x3199BDC", Offset = "0x3199BDC", VA = "0x3199BDC")]
	private void CheckRewardLevel(uint chestID, List<ExchangedAward> awards, ref bool result)
	{
	}

	[Token(Token = "0x6014460")]
	[Address(RVA = "0x319A044", Offset = "0x319A044", VA = "0x319A044")]
	public uint GetCouponCount(uint gachaID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014461")]
	[Address(RVA = "0x319A4E4", Offset = "0x319A4E4", VA = "0x319A4E4")]
	public List<CSSharedItemData> GetCouponItemsInfo(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x6014462")]
	[Address(RVA = "0x319A8C0", Offset = "0x319A8C0", VA = "0x319A8C0")]
	public uint GetSpecialCouponCount(uint gachaID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014463")]
	[Address(RVA = "0x319AAD8", Offset = "0x319AAD8", VA = "0x319AAD8")]
	public void SetCouponCount(uint gachaID, List<ExchangeItemNum> items)
	{
	}

	[Token(Token = "0x6014464")]
	[Address(RVA = "0x319AEA4", Offset = "0x319AEA4", VA = "0x319AEA4")]
	public uint GetExtraListCurCount(uint chestID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014465")]
	[Address(RVA = "0x319AF78", Offset = "0x319AF78", VA = "0x319AF78")]
	public ExtraRewardDesc GetExtralRewardDesc(uint chestID, int index)
	{
		return null;
	}

	[Token(Token = "0x6014466")]
	[Address(RVA = "0x319B0C0", Offset = "0x319B0C0", VA = "0x319B0C0")]
	public bool IsExtralRewardExchanged(uint chestID, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6014467")]
	[Address(RVA = "0x319B40C", Offset = "0x319B40C", VA = "0x319B40C")]
	public uint GetCurrentPrice(uint chestID, GachaDrawType type)
	{
		return default(uint);
	}

	[Token(Token = "0x6014468")]
	[Address(RVA = "0x319C048", Offset = "0x319C048", VA = "0x319C048")]
	public uint GetOriginPrice(uint chestID, GachaDrawType type)
	{
		return default(uint);
	}

	[Token(Token = "0x6014469")]
	[Address(RVA = "0x319BF68", Offset = "0x319BF68", VA = "0x319BF68")]
	public uint GetDiscountPrice(uint chestID, GachaDrawType type)
	{
		return default(uint);
	}

	[Token(Token = "0x601446A")]
	[Address(RVA = "0x319C264", Offset = "0x319C264", VA = "0x319C264")]
	public List<uint> GetAvatarList(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601446B")]
	[Address(RVA = "0x319C300", Offset = "0x319C300", VA = "0x319C300")]
	public uint GetAvatarModelId(uint chestID, bool isfemale)
	{
		return default(uint);
	}

	[Token(Token = "0x601446C")]
	[Address(RVA = "0x319BB9C", Offset = "0x319BB9C", VA = "0x319BB9C")]
	public uint GetLimitPrice(uint chestID, GachaDrawType type)
	{
		return default(uint);
	}

	[Token(Token = "0x601446D")]
	[Address(RVA = "0x319B9A8", Offset = "0x319B9A8", VA = "0x319B9A8")]
	public uint GetLimitPurchaseCount(uint chestID, GachaDrawType type)
	{
		return default(uint);
	}

	[Token(Token = "0x601446E")]
	[Address(RVA = "0x319B7B4", Offset = "0x319B7B4", VA = "0x319B7B4")]
	public uint GetLimitPurchaseCurCount(uint chestID, GachaDrawType type)
	{
		return default(uint);
	}

	[Token(Token = "0x601446F")]
	[Address(RVA = "0x31956F8", Offset = "0x31956F8", VA = "0x31956F8")]
	public uint GetEnergyPoint(uint chestID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014470")]
	[Address(RVA = "0x319C48C", Offset = "0x319C48C", VA = "0x319C48C")]
	public List<uint> GetEnergyRange(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6014471")]
	[Address(RVA = "0x319C654", Offset = "0x319C654", VA = "0x319C654")]
	public uint GetFirstDrawRewardCount(uint chestID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014472")]
	[Address(RVA = "0x319C728", Offset = "0x319C728", VA = "0x319C728")]
	public ChestHintColor GetHintColor(uint chestID)
	{
		return default(ChestHintColor);
	}

	[Token(Token = "0x6014473")]
	[Address(RVA = "0x319C7BC", Offset = "0x319C7BC", VA = "0x319C7BC")]
	public LotteryTheme GetLotteryTheme(uint chestID)
	{
		return default(LotteryTheme);
	}

	[Token(Token = "0x6014474")]
	[Address(RVA = "0x319BD2C", Offset = "0x319BD2C", VA = "0x319BD2C")]
	public bool IsInDiscountPeriod(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014475")]
	[Address(RVA = "0x319B58C", Offset = "0x319B58C", VA = "0x319B58C")]
	public bool IsInLimitPeriod(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014476")]
	[Address(RVA = "0x319CA74", Offset = "0x319CA74", VA = "0x319CA74")]
	public bool IsInDropUpPeriod(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014477")]
	[Address(RVA = "0x319CB38", Offset = "0x319CB38", VA = "0x319CB38")]
	public bool IsOpenFirstReward(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014478")]
	[Address(RVA = "0x31957CC", Offset = "0x31957CC", VA = "0x31957CC")]
	public uint GetLimitNum(uint chestID)
	{
		return default(uint);
	}

	[Token(Token = "0x6014479")]
	[Address(RVA = "0x319CBD8", Offset = "0x319CBD8", VA = "0x319CBD8")]
	public LimitResetType GetLimitResetType(uint chestID)
	{
		return default(LimitResetType);
	}

	[Token(Token = "0x601447A")]
	[Address(RVA = "0x319CC6C", Offset = "0x319CC6C", VA = "0x319CC6C")]
	public uint GetExchangeNeedCouponCount(uint chestID, GachaDrawType type)
	{
		return default(uint);
	}

	[Token(Token = "0x601447B")]
	[Address(RVA = "0x319CD24", Offset = "0x319CD24", VA = "0x319CD24")]
	public EInventory.CurrencyType GetCurrencyType(uint chestID)
	{
		return default(EInventory.CurrencyType);
	}

	[Token(Token = "0x601447C")]
	[Address(RVA = "0x319CDB8", Offset = "0x319CDB8", VA = "0x319CDB8")]
	public ulong GetGachaEndTime(uint chestID)
	{
		return default(ulong);
	}

	[Token(Token = "0x601447D")]
	[Address(RVA = "0x319CE54", Offset = "0x319CE54", VA = "0x319CE54")]
	public bool CheckIsCurrencyEnough(uint chestID, GachaDrawType type)
	{
		return default(bool);
	}

	[Token(Token = "0x601447E")]
	[Address(RVA = "0x319D074", Offset = "0x319D074", VA = "0x319D074")]
	public bool CheckIsPriceFreeByID(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x601447F")]
	[Address(RVA = "0x319D3A8", Offset = "0x319D3A8", VA = "0x319D3A8")]
	public bool CheckIsLimitCDFreeById(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014480")]
	[Address(RVA = "0x319D510", Offset = "0x319D510", VA = "0x319D510")]
	public bool CheckCanReceiveExtraReward(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014481")]
	[Address(RVA = "0x319D7B0", Offset = "0x319D7B0", VA = "0x319D7B0")]
	public bool HasFreeGacha()
	{
		return default(bool);
	}

	[Token(Token = "0x6014482")]
	[Address(RVA = "0x319DB14", Offset = "0x319DB14", VA = "0x319DB14")]
	public bool HasNewGacha()
	{
		return default(bool);
	}

	[Token(Token = "0x6014483")]
	[Address(RVA = "0x319DFEC", Offset = "0x319DFEC", VA = "0x319DFEC")]
	public void UpdateCacheGachaIdSubIds()
	{
	}

	[Token(Token = "0x6014484")]
	[Address(RVA = "0x319E454", Offset = "0x319E454", VA = "0x319E454")]
	public bool IsHasFreeGacha(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014485")]
	[Address(RVA = "0x319E544", Offset = "0x319E544", VA = "0x319E544")]
	public bool IsCfgExtraReward(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014486")]
	[Address(RVA = "0x319E628", Offset = "0x319E628", VA = "0x319E628")]
	public bool IsCfgExtraRewardOver3(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014487")]
	[Address(RVA = "0x319E70C", Offset = "0x319E70C", VA = "0x319E70C")]
	public ResourceID GetPropIconRes(uint chestID)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6014488")]
	[Address(RVA = "0x319EA20", Offset = "0x319EA20", VA = "0x319EA20")]
	public uint GetPropConsumeCnt(uint chestID, GachaDrawType type)
	{
		return default(uint);
	}

	[Token(Token = "0x6014489")]
	[Address(RVA = "0x319C950", Offset = "0x319C950", VA = "0x319C950")]
	private bool IsInTimePeriod(ulong begin, ulong end)
	{
		return default(bool);
	}

	[Token(Token = "0x601448A")]
	[Address(RVA = "0x319A32C", Offset = "0x319A32C", VA = "0x319A32C")]
	private uint GetPropsCntByID(uint id)
	{
		return default(uint);
	}

	[Token(Token = "0x601448B")]
	[Address(RVA = "0x319ACE4", Offset = "0x319ACE4", VA = "0x319ACE4")]
	private void SetPropsCntByID(uint id, uint value)
	{
	}

	[Token(Token = "0x601448C")]
	[Address(RVA = "0x319B354", Offset = "0x319B354", VA = "0x319B354")]
	public GachaInfo GetGachaInfo(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601448D")]
	public T GetGachaPackageInfo<T>(uint gachaID) where T : GachaInfoDataBase
	{
		return null;
	}

	[Token(Token = "0x601448E")]
	[Address(RVA = "0x319EAD8", Offset = "0x319EAD8", VA = "0x319EAD8")]
	public int ChestID2ForgeTabID(uint chestID)
	{
		return default(int);
	}

	[Token(Token = "0x601448F")]
	[Address(RVA = "0x3199DE4", Offset = "0x3199DE4", VA = "0x3199DE4")]
	public GachaShowItem GetGachaShowItemInfo(uint chestID, uint itmID, uint rewardPoolID = 0u, uint duration = 0u)
	{
		return null;
	}

	[Token(Token = "0x6014490")]
	[Address(RVA = "0x319EB70", Offset = "0x319EB70", VA = "0x319EB70")]
	public GachaShowItem GetGachaShowItemInfoByGachaRewardIDFormServerDesc(uint chestID, uint GachaRewardID)
	{
		return null;
	}

	[Token(Token = "0x6014491")]
	[Address(RVA = "0x319EE74", Offset = "0x319EE74", VA = "0x319EE74")]
	public GachaShowItem GetGachaShowItemInfoByID(uint chestID, uint gachaShowItemID, uint rewardPoolID = 0u)
	{
		return null;
	}

	[Token(Token = "0x6014492")]
	[Address(RVA = "0x3195E14", Offset = "0x3195E14", VA = "0x3195E14")]
	public List<GachaShowItem> GetGachaShowItemInfoList(uint chestID, uint rewardPoolID = 0u)
	{
		return null;
	}

	[Token(Token = "0x6014493")]
	[Address(RVA = "0x3197274", Offset = "0x3197274", VA = "0x3197274")]
	public bool GachaDescHasData()
	{
		return default(bool);
	}

	[Token(Token = "0x6014494")]
	[Address(RVA = "0x319F0C0", Offset = "0x319F0C0", VA = "0x319F0C0")]
	public bool GachaSpEchDescHasData()
	{
		return default(bool);
	}

	[Token(Token = "0x6014495")]
	[Address(RVA = "0x3198834", Offset = "0x3198834", VA = "0x3198834")]
	public bool GachaInfoHasData()
	{
		return default(bool);
	}

	[Token(Token = "0x6014496")]
	[Address(RVA = "0x319F1A4", Offset = "0x319F1A4", VA = "0x319F1A4")]
	public List<ChestSpecialExchangeDesc> GetGachaSpDescList(uint forgeTabID)
	{
		return null;
	}

	[Token(Token = "0x6014497")]
	[Address(RVA = "0x319F338", Offset = "0x319F338", VA = "0x319F338")]
	public ChestSpecialExchangeDesc FindChestSpecialExchangeDesc(uint forgeTabID, uint itemId, uint id = uint.MaxValue)
	{
		return null;
	}

	[Token(Token = "0x6014498")]
	[Address(RVA = "0x319F57C", Offset = "0x319F57C", VA = "0x319F57C")]
	public Dictionary<uint, GachaSpDescData> GetGachaSpDescDict()
	{
		return null;
	}

	[Token(Token = "0x6014499")]
	[Address(RVA = "0x3190CE0", Offset = "0x3190CE0", VA = "0x3190CE0")]
	public GachaDesc GetGachaDesc(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x601449A")]
	[Address(RVA = "0x319F5EC", Offset = "0x319F5EC", VA = "0x319F5EC")]
	public GachaDesc GetSortedGachaDesc(int index)
	{
		return null;
	}

	[Token(Token = "0x601449B")]
	[Address(RVA = "0x319F70C", Offset = "0x319F70C", VA = "0x319F70C")]
	public int FindGachaIdListIdx(uint chestID)
	{
		return default(int);
	}

	[Token(Token = "0x601449C")]
	[Address(RVA = "0x319F858", Offset = "0x319F858", VA = "0x319F858")]
	public bool CheckAwardInGacha(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601449D")]
	[Address(RVA = "0x319FCF0", Offset = "0x319FCF0", VA = "0x319FCF0")]
	public List<uint> GetAllTokenGacheExchangeItemID()
	{
		return null;
	}

	[Token(Token = "0x601449E")]
	[Address(RVA = "0x3193B8C", Offset = "0x3193B8C", VA = "0x3193B8C")]
	public bool IsMocoItemOwn(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601449F")]
	[Address(RVA = "0x31A022C", Offset = "0x31A022C", VA = "0x31A022C")]
	public bool IsItemOwned(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60144A0")]
	[Address(RVA = "0x31A0514", Offset = "0x31A0514", VA = "0x31A0514")]
	public int CompareLotteryItem(GachaShowItem a, GachaShowItem b)
	{
		return default(int);
	}

	[Token(Token = "0x60144A1")]
	[Address(RVA = "0x31A05F4", Offset = "0x31A05F4", VA = "0x31A05F4")]
	private int CalcLotteryItemSortWeight(GachaShowItem item)
	{
		return default(int);
	}

	[Token(Token = "0x60144A2")]
	[Address(RVA = "0x31A0790", Offset = "0x31A0790", VA = "0x31A0790")]
	private int GetLotteryItemSortTypeWeight(CSSharedItemData baseitem)
	{
		return default(int);
	}

	[Token(Token = "0x60144A3")]
	[Address(RVA = "0x31A08AC", Offset = "0x31A08AC", VA = "0x31A08AC")]
	public uint WeightTypeToEnergyStar(ELottery.WeightType type)
	{
		return default(uint);
	}

	[Token(Token = "0x60144A4")]
	[Address(RVA = "0x31A0924", Offset = "0x31A0924", VA = "0x31A0924")]
	private string _NotifyUrl(object[] parameters)
	{
		return null;
	}

	[Token(Token = "0x60144A5")]
	[Address(RVA = "0x31A09F4", Offset = "0x31A09F4", VA = "0x31A09F4")]
	private int _NotifyMaxRandomDelay_MS()
	{
		return default(int);
	}

	[Token(Token = "0x60144A6")]
	[Address(RVA = "0x31A0AD4", Offset = "0x31A0AD4", VA = "0x31A0AD4")]
	private LocalNotificationManager.NotifyInfo GetNotifyInfo(LocalNotificationManager.NotifyType type, GachaDesc gachaDesc)
	{
		return null;
	}

	[Token(Token = "0x60144A7")]
	[Address(RVA = "0x31A0EF0", Offset = "0x31A0EF0", VA = "0x31A0EF0")]
	private void UpdateNotifies()
	{
	}

	[Token(Token = "0x60144A8")]
	[Address(RVA = "0x31A112C", Offset = "0x31A112C", VA = "0x31A112C")]
	public void RequestGetEnergyGachaBuffInfo(uint gachaID)
	{
	}

	[Token(Token = "0x60144A9")]
	[Address(RVA = "0x31A1404", Offset = "0x31A1404", VA = "0x31A1404")]
	public void RequestRefreshEnergyGachaBuffInfo(uint gachaID)
	{
	}

	[Token(Token = "0x60144AA")]
	[Address(RVA = "0x31A16DC", Offset = "0x31A16DC", VA = "0x31A16DC")]
	public void RequestLegendaryGachaGainItems(uint gachaID, uint[] itemsIDs)
	{
	}

	[Token(Token = "0x60144AB")]
	[Address(RVA = "0x31A1A54", Offset = "0x31A1A54", VA = "0x31A1A54")]
	public void RequestLegendaryGachaRerandomItems(uint gachaID, uint[] itemsIDs)
	{
	}

	[Token(Token = "0x60144AC")]
	[Address(RVA = "0x31A1DCC", Offset = "0x31A1DCC", VA = "0x31A1DCC")]
	public ClientChestType GetClientChestTypeByID(uint gachaID)
	{
		return null;
	}

	[Token(Token = "0x60144AD")]
	[Address(RVA = "0x31A1E50", Offset = "0x31A1E50", VA = "0x31A1E50")]
	public uint GetLobbyGachaId()
	{
		return default(uint);
	}

	[Token(Token = "0x60144AE")]
	[Address(RVA = "0x31A1EA8", Offset = "0x31A1EA8", VA = "0x31A1EA8")]
	public bool IsLobbyGacha(int sortedIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x60144AF")]
	[Address(RVA = "0x319DA14", Offset = "0x319DA14", VA = "0x319DA14")]
	public bool GetGachaTipsByID(uint chestID)
	{
		return default(bool);
	}

	[Token(Token = "0x60144B0")]
	[Address(RVA = "0x31A1F38", Offset = "0x31A1F38", VA = "0x31A1F38")]
	private void _003CReqeustHackerStoreInfo_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60144B1")]
	[Address(RVA = "0x31A2074", Offset = "0x31A2074", VA = "0x31A2074")]
	private static bool _003CGetHackerStoreSelectPageItem1_003Em__1(GachaShowItem reward)
	{
		return default(bool);
	}

	[Token(Token = "0x60144B2")]
	[Address(RVA = "0x31A20A0", Offset = "0x31A20A0", VA = "0x31A20A0")]
	private static bool _003CGetHackerStoreSelectPageItem2_003Em__2(GachaShowItem reward)
	{
		return default(bool);
	}

	[Token(Token = "0x60144B3")]
	[Address(RVA = "0x31A20D0", Offset = "0x31A20D0", VA = "0x31A20D0")]
	private void _003CRequestGachaDescRes_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60144B4")]
	[Address(RVA = "0x31A21D8", Offset = "0x31A21D8", VA = "0x31A21D8")]
	private int _003CProcessGachaDes_003Em__4(uint idA, uint idB)
	{
		return default(int);
	}

	[Token(Token = "0x60144B5")]
	[Address(RVA = "0x31A23B4", Offset = "0x31A23B4", VA = "0x31A23B4")]
	private void _003CRequestGachaSpecialExchangeDesc_003Em__5(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60144B6")]
	[Address(RVA = "0x31A2638", Offset = "0x31A2638", VA = "0x31A2638")]
	private static int _003CGetCouponItemsInfo_003Em__6(CSSharedItemData a, CSSharedItemData b)
	{
		return default(int);
	}

	[Token(Token = "0x60144B7")]
	[Address(RVA = "0x31A2820", Offset = "0x31A2820", VA = "0x31A2820")]
	private static int _003CIsExtralRewardExchanged_003Em__7(ExtraRewardDesc item)
	{
		return default(int);
	}

	[Token(Token = "0x60144B8")]
	[Address(RVA = "0x31A2844", Offset = "0x31A2844", VA = "0x31A2844")]
	private static bool _003CGetLimitPurchaseCount_003Em__8(uint priceType)
	{
		return default(bool);
	}

	[Token(Token = "0x60144B9")]
	[Address(RVA = "0x31A2858", Offset = "0x31A2858", VA = "0x31A2858")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x60144BA")]
	[Address(RVA = "0x31A2860", Offset = "0x31A2860", VA = "0x31A2860")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
