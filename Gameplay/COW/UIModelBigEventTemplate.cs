using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002EE8")]
public class UIModelBigEventTemplate : UIBaseModel
{
	[Token(Token = "0x2002EE9")]
	public class LocStrWithColor
	{
		[Token(Token = "0x4011ED4")]
		[FieldOffset(Offset = "0x8")]
		public string LocStr;

		[Token(Token = "0x4011ED5")]
		[FieldOffset(Offset = "0xC")]
		public Color LocColor;

		[Token(Token = "0x6013A62")]
		[Address(RVA = "0x26066AC", Offset = "0x26066AC", VA = "0x26066AC")]
		public LocStrWithColor()
		{
		}
	}

	[Token(Token = "0x2002EEA")]
	private sealed class _003CRequestExchangeStoreDesc_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011ED6")]
		[FieldOffset(Offset = "0x8")]
		internal bool success;

		[Token(Token = "0x4011ED7")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBigEventTemplate _0024this;

		[Token(Token = "0x6013A63")]
		[Address(RVA = "0x260ABFC", Offset = "0x260ABFC", VA = "0x260ABFC")]
		public _003CRequestExchangeStoreDesc_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013A64")]
		[Address(RVA = "0x260C040", Offset = "0x260C040", VA = "0x260C040")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002EEB")]
	private sealed class _003CRequestExchangeStorePurchase_003Ec__AnonStorey1
	{
		[Token(Token = "0x4011ED8")]
		[FieldOffset(Offset = "0x8")]
		internal CustomEventStoreCommodityDesc desc;

		[Token(Token = "0x4011ED9")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelBigEventTemplate _0024this;

		[Token(Token = "0x4011EDA")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6013A65")]
		[Address(RVA = "0x260B344", Offset = "0x260B344", VA = "0x260B344")]
		public _003CRequestExchangeStorePurchase_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013A66")]
		[Address(RVA = "0x260C540", Offset = "0x260C540", VA = "0x260C540")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013A67")]
		[Address(RVA = "0x260CC30", Offset = "0x260CC30", VA = "0x260CC30")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x4011EBD")]
	public const string CDN_LANGUAGE_DEFAULT = "default";

	[Token(Token = "0x4011EBE")]
	[FieldOffset(Offset = "0xC")]
	public CustomEventOpenInfoDesc OpenInfo;

	[Token(Token = "0x4011EBF")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<uint, CustomEventEntranceDesc> DictInPageEntrance;

	[Token(Token = "0x4011EC0")]
	[FieldOffset(Offset = "0x14")]
	public Dictionary<BigEventTemplateCdnKey, CustomEventCDNDesc> DictCdn;

	[Token(Token = "0x4011EC1")]
	[FieldOffset(Offset = "0x18")]
	public Dictionary<BigEventTemplateLocKey, CustomEventLocDesc> DictLoc;

	[Token(Token = "0x4011EC2")]
	[FieldOffset(Offset = "0x1C")]
	public Dictionary<string, CustomEventTemplateDesc> DictTempates;

	[Token(Token = "0x4011EC3")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, List<int>> DictRule;

	[Token(Token = "0x4011EC4")]
	[FieldOffset(Offset = "0x24")]
	public Dictionary<int, BigEventTemplateRuleConfig> DictRuleConfig;

	[Token(Token = "0x4011EC5")]
	public const int PropID_ProcessedOpenInfo = 2;

	[Token(Token = "0x4011EC6")]
	public const int PropID_ExchangeStoreInfoUpdate = 4;

	[Token(Token = "0x4011EC7")]
	public const int PropID_ExchangeStoreDescUpdate = 8;

	[Token(Token = "0x4011EC8")]
	public const int PropID_ExchangeStorePurchaseFinished = 16;

	[Token(Token = "0x4011EC9")]
	private const EActivity.SubType ACTIVITY_SUBTYPE = EActivity.SubType.Subtype_CUSTOM_EVENT;

	[Token(Token = "0x4011ECA")]
	[FieldOffset(Offset = "0x28")]
	private bool m_ExchangeStoreDescFetched;

	[Token(Token = "0x4011ECB")]
	[FieldOffset(Offset = "0x29")]
	private bool m_ExchangeStoreInfoFetched;

	[Token(Token = "0x4011ECC")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, CustomLimitedStoreAccountInfo> m_ExchangeStoreInfoDict;

	[Token(Token = "0x4011ECD")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, CustomEventStoreDesc> m_ExchangeStoreDescDict;

	[Token(Token = "0x4011ECE")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, uint> m_ExchangeStoreTabDict;

	[Token(Token = "0x4011ECF")]
	[FieldOffset(Offset = "0x38")]
	private List<CustomEventStoreCommodityDesc> m_ExchangeStoreCommodityDesc;

	[Token(Token = "0x4011ED0")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_TokenId;

	[Token(Token = "0x4011ED1")]
	[FieldOffset(Offset = "0x40")]
	public string PlayerPrefsKey_ExchangeStoreClassicTipsOnOff;

	[Token(Token = "0x4011ED2")]
	[FieldOffset(Offset = "0x44")]
	public string PlayerPrefsKey_ExchangeStoreSpecialTipsOnOff;

	[Token(Token = "0x4011ED3")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<string, uint> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x17001468")]
	public List<CustomEventStoreCommodityDesc> ExchangeStoreCommodityDesc
	{
		[Token(Token = "0x60139F3")]
		[Address(RVA = "0x260421C", Offset = "0x260421C", VA = "0x260421C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001469")]
	public uint CustomEventTokenId
	{
		[Token(Token = "0x60139F4")]
		[Address(RVA = "0x2604274", Offset = "0x2604274", VA = "0x2604274")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x60139F2")]
	[Address(RVA = "0x2603E80", Offset = "0x2603E80", VA = "0x2603E80")]
	public UIModelBigEventTemplate()
	{
	}

	[Token(Token = "0x60139F5")]
	[Address(RVA = "0x26042CC", Offset = "0x26042CC", VA = "0x26042CC", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60139F6")]
	[Address(RVA = "0x2604324", Offset = "0x2604324", VA = "0x2604324", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x60139F7")]
	[Address(RVA = "0x2604574", Offset = "0x2604574", VA = "0x2604574", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x60139F8")]
	[Address(RVA = "0x26045EC", Offset = "0x26045EC", VA = "0x26045EC", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60139F9")]
	[Address(RVA = "0x2604664", Offset = "0x2604664", VA = "0x2604664")]
	public CustomEventOpenInfoDesc GetOpenInfo()
	{
		return null;
	}

	[Token(Token = "0x60139FA")]
	[Address(RVA = "0x26046BC", Offset = "0x26046BC", VA = "0x26046BC")]
	public EBigEventTemplateType GetTemplateType()
	{
		return default(EBigEventTemplateType);
	}

	[Token(Token = "0x60139FB")]
	[Address(RVA = "0x2604728", Offset = "0x2604728", VA = "0x2604728")]
	public uint GetEventId()
	{
		return default(uint);
	}

	[Token(Token = "0x60139FC")]
	[Address(RVA = "0x2604794", Offset = "0x2604794", VA = "0x2604794")]
	public ECustomEvent.EventState GetEventState()
	{
		return default(ECustomEvent.EventState);
	}

	[Token(Token = "0x60139FD")]
	[Address(RVA = "0x26048BC", Offset = "0x26048BC", VA = "0x26048BC")]
	public string GetEventStateTimeStr(ECustomEvent.EventState eventState)
	{
		return null;
	}

	[Token(Token = "0x60139FE")]
	[Address(RVA = "0x2604B4C", Offset = "0x2604B4C", VA = "0x2604B4C")]
	public bool IsDuringEventStateTime(ECustomEvent.EventState eventState)
	{
		return default(bool);
	}

	[Token(Token = "0x60139FF")]
	[Address(RVA = "0x2604DBC", Offset = "0x2604DBC", VA = "0x2604DBC")]
	public string GetStoreStartTimeStr(uint storeType)
	{
		return null;
	}

	[Token(Token = "0x6013A00")]
	[Address(RVA = "0x2604CBC", Offset = "0x2604CBC", VA = "0x2604CBC")]
	public uint GetEventStateStartTime(ECustomEvent.EventState eventState)
	{
		return default(uint);
	}

	[Token(Token = "0x6013A01")]
	[Address(RVA = "0x2604D3C", Offset = "0x2604D3C", VA = "0x2604D3C")]
	public uint GetEventStateEndTime(ECustomEvent.EventState eventState)
	{
		return default(uint);
	}

	[Token(Token = "0x6013A02")]
	[Address(RVA = "0x2605084", Offset = "0x2605084", VA = "0x2605084")]
	public UIModelBigEvent.EBigEventEntranceState GetInPageEntranceState(uint entranceType)
	{
		return default(UIModelBigEvent.EBigEventEntranceState);
	}

	[Token(Token = "0x6013A03")]
	[Address(RVA = "0x2605364", Offset = "0x2605364", VA = "0x2605364")]
	public string GetInPageEntranceTimeStr(uint entranceID)
	{
		return null;
	}

	[Token(Token = "0x6013A04")]
	[Address(RVA = "0x26055E8", Offset = "0x26055E8", VA = "0x26055E8")]
	private CustomEventEntranceDesc GetInPageEntranceDesc(uint entranceId)
	{
		return null;
	}

	[Token(Token = "0x6013A05")]
	[Address(RVA = "0x2605704", Offset = "0x2605704", VA = "0x2605704")]
	private string GetCdnUrl(string strCdnId)
	{
		return null;
	}

	[Token(Token = "0x6013A06")]
	[Address(RVA = "0x2605820", Offset = "0x2605820", VA = "0x2605820")]
	public string GetCdnUrl(uint cdnId)
	{
		return null;
	}

	[Token(Token = "0x6013A07")]
	[Address(RVA = "0x2605918", Offset = "0x2605918", VA = "0x2605918")]
	private CustomEventCDNDesc GetCdnDesc(uint cdnId)
	{
		return null;
	}

	[Token(Token = "0x6013A08")]
	[Address(RVA = "0x2605B2C", Offset = "0x2605B2C", VA = "0x2605B2C")]
	public void DownloadCdnSuccessCallBack()
	{
	}

	[Token(Token = "0x6013A09")]
	[Address(RVA = "0x2605C38", Offset = "0x2605C38", VA = "0x2605C38")]
	private CustomEventLocDesc GetLocDesc(string strLocId)
	{
		return null;
	}

	[Token(Token = "0x6013A0A")]
	[Address(RVA = "0x2605CD8", Offset = "0x2605CD8", VA = "0x2605CD8")]
	private CustomEventLocDesc GetLocDesc(uint locId)
	{
		return null;
	}

	[Token(Token = "0x6013A0B")]
	[Address(RVA = "0x2605EEC", Offset = "0x2605EEC", VA = "0x2605EEC")]
	private CustomEventTemplateDesc GetTemplateValue(EBigEventTemplateConfigKey configKeyEnum)
	{
		return null;
	}

	[Token(Token = "0x6013A0C")]
	[Address(RVA = "0x26060B8", Offset = "0x26060B8", VA = "0x26060B8")]
	private string GetCdnUrlByConfigKey(EBigEventTemplateConfigKey configKey)
	{
		return null;
	}

	[Token(Token = "0x6013A0D")]
	[Address(RVA = "0x26061B0", Offset = "0x26061B0", VA = "0x26061B0")]
	private string GetCdnIdAndParseToUrlByConfigKey(EBigEventTemplateConfigKey configKey)
	{
		return null;
	}

	[Token(Token = "0x6013A0E")]
	[Address(RVA = "0x26062B4", Offset = "0x26062B4", VA = "0x26062B4")]
	private LocStrWithColor GetLocIdAndParseToStrByConfigKey(EBigEventTemplateConfigKey configKey)
	{
		return null;
	}

	[Token(Token = "0x6013A0F")]
	[Address(RVA = "0x2606478", Offset = "0x2606478", VA = "0x2606478")]
	private Color GetColorByString(string colorStr)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A10")]
	[Address(RVA = "0x26066B4", Offset = "0x26066B4", VA = "0x26066B4")]
	private Color GetColorByConfigKey(EBigEventTemplateConfigKey configKey)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A11")]
	[Address(RVA = "0x2606770", Offset = "0x2606770", VA = "0x2606770")]
	public string GetPeakDayTimeStr()
	{
		return null;
	}

	[Token(Token = "0x6013A12")]
	[Address(RVA = "0x2606944", Offset = "0x2606944", VA = "0x2606944")]
	public string GetPeakDayBubbleDateStr()
	{
		return null;
	}

	[Token(Token = "0x6013A13")]
	[Address(RVA = "0x2606BEC", Offset = "0x2606BEC", VA = "0x2606BEC")]
	public string GetPeakDayBubbleBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A14")]
	[Address(RVA = "0x2606C50", Offset = "0x2606C50", VA = "0x2606C50")]
	public string GetPeakDayWndBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A15")]
	[Address(RVA = "0x2606CB4", Offset = "0x2606CB4", VA = "0x2606CB4")]
	public LocStrWithColor GetPeakDayWndTitleStr()
	{
		return null;
	}

	[Token(Token = "0x6013A16")]
	[Address(RVA = "0x2606D18", Offset = "0x2606D18", VA = "0x2606D18")]
	public Color GetPeakDayWndCloseColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A17")]
	[Address(RVA = "0x2606D88", Offset = "0x2606D88", VA = "0x2606D88")]
	public bool IsPeakDayStateClaimable()
	{
		return default(bool);
	}

	[Token(Token = "0x6013A18")]
	[Address(RVA = "0x2606DF8", Offset = "0x2606DF8", VA = "0x2606DF8")]
	public UIModelBigEvent.EPeakDayState GetPeakDayState()
	{
		return default(UIModelBigEvent.EPeakDayState);
	}

	[Token(Token = "0x6013A19")]
	[Address(RVA = "0x2606AB8", Offset = "0x2606AB8", VA = "0x2606AB8")]
	public ClientActivityDesc GetPeakDayDesc()
	{
		return null;
	}

	[Token(Token = "0x6013A1A")]
	[Address(RVA = "0x2606F24", Offset = "0x2606F24", VA = "0x2606F24")]
	public int GetMissionFinishedCount()
	{
		return default(int);
	}

	[Token(Token = "0x6013A1B")]
	[Address(RVA = "0x26071A0", Offset = "0x26071A0", VA = "0x26071A0")]
	public List<ClientActivityDesc> GetMissionList()
	{
		return null;
	}

	[Token(Token = "0x6013A1C")]
	[Address(RVA = "0x26068EC", Offset = "0x26068EC", VA = "0x26068EC")]
	public EActivity.SubType GetActivitySubType()
	{
		return default(EActivity.SubType);
	}

	[Token(Token = "0x6013A1D")]
	[Address(RVA = "0x26072E4", Offset = "0x26072E4", VA = "0x26072E4")]
	public LocStrWithColor GetMissionWndTitleStr()
	{
		return null;
	}

	[Token(Token = "0x6013A1E")]
	[Address(RVA = "0x2607348", Offset = "0x2607348", VA = "0x2607348")]
	public string GetMissionWndBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A1F")]
	[Address(RVA = "0x26073AC", Offset = "0x26073AC", VA = "0x26073AC")]
	public Color GetMissionWndCloseColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A20")]
	[Address(RVA = "0x260741C", Offset = "0x260741C", VA = "0x260741C")]
	public string GetMissionItemBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A21")]
	[Address(RVA = "0x2607480", Offset = "0x2607480", VA = "0x2607480")]
	public Color GetMissionDescColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A22")]
	[Address(RVA = "0x26074F0", Offset = "0x26074F0", VA = "0x26074F0")]
	public Color GetMissionProcessColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A23")]
	[Address(RVA = "0x2607560", Offset = "0x2607560", VA = "0x2607560")]
	public Color GetRuleWndTitleColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A24")]
	[Address(RVA = "0x26075D0", Offset = "0x26075D0", VA = "0x26075D0")]
	public LocStrWithColor GetRuleWndDesc()
	{
		return null;
	}

	[Token(Token = "0x6013A25")]
	[Address(RVA = "0x2607634", Offset = "0x2607634", VA = "0x2607634")]
	public Color GetRuleWndCloseColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A26")]
	[Address(RVA = "0x26076A4", Offset = "0x26076A4", VA = "0x26076A4")]
	public string GetRuleWndBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A27")]
	[Address(RVA = "0x2607708", Offset = "0x2607708", VA = "0x2607708")]
	public string GetLobbyEntranceIconCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A28")]
	[Address(RVA = "0x26077F0", Offset = "0x26077F0", VA = "0x26077F0")]
	public string GetMainPageBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A29")]
	[Address(RVA = "0x2607854", Offset = "0x2607854", VA = "0x2607854")]
	public string GetMainPageTitleCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A2A")]
	[Address(RVA = "0x26078B8", Offset = "0x26078B8", VA = "0x26078B8")]
	public Color GetMainPageCloseColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A2B")]
	[Address(RVA = "0x2607928", Offset = "0x2607928", VA = "0x2607928")]
	public Color GetMainPageTimeColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A2C")]
	[Address(RVA = "0x2607998", Offset = "0x2607998", VA = "0x2607998")]
	public List<UIModelLobbyAds.AdInfo> GetMainPageCdnAds()
	{
		return null;
	}

	[Token(Token = "0x6013A2D")]
	[Address(RVA = "0x2607FD4", Offset = "0x2607FD4", VA = "0x2607FD4")]
	public string GetMainPageCdnAdsBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A2E")]
	[Address(RVA = "0x2608038", Offset = "0x2608038", VA = "0x2608038")]
	public Color GetGlobalProgressValueColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A2F")]
	[Address(RVA = "0x26080A8", Offset = "0x26080A8", VA = "0x26080A8")]
	public string GetGlobalProgressValueBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A30")]
	[Address(RVA = "0x260810C", Offset = "0x260810C", VA = "0x260810C")]
	public string GetGlobalProgressShareBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A31")]
	[Address(RVA = "0x2608170", Offset = "0x2608170", VA = "0x2608170")]
	public string GetGlobalProgressShareBtnBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A32")]
	[Address(RVA = "0x26081D4", Offset = "0x26081D4", VA = "0x26081D4")]
	public string GetGlobalProgressAwardBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A33")]
	[Address(RVA = "0x2608238", Offset = "0x2608238", VA = "0x2608238")]
	public string GetGlobalProgressAwardItemBgCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A34")]
	[Address(RVA = "0x260829C", Offset = "0x260829C", VA = "0x260829C")]
	public string GetGlobalProgressAwardCantClaimCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A35")]
	[Address(RVA = "0x2608300", Offset = "0x2608300", VA = "0x2608300")]
	public Color GetGlobalProgressBarItemActiveColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A36")]
	[Address(RVA = "0x2608370", Offset = "0x2608370", VA = "0x2608370")]
	public Color GetGlobalProgressBarItemDisactiveColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A37")]
	[Address(RVA = "0x26083E0", Offset = "0x26083E0", VA = "0x26083E0")]
	public string GetGlobalProgressExchangeStoreBGCDNUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A38")]
	[Address(RVA = "0x2608444", Offset = "0x2608444", VA = "0x2608444")]
	public string GetGlobalProgressExchangeStoreTitleCDNUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A39")]
	[Address(RVA = "0x26084A8", Offset = "0x26084A8", VA = "0x26084A8")]
	public string GetGlobalProgressExchangeStoreToggle1BGCDNUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A3A")]
	[Address(RVA = "0x260850C", Offset = "0x260850C", VA = "0x260850C")]
	public string GetGlobalProgressExchangeStoreToggle1LogoCDNUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A3B")]
	[Address(RVA = "0x2608570", Offset = "0x2608570", VA = "0x2608570")]
	public string GetGlobalProgressExchangeStoreToggle2BGCDNUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A3C")]
	[Address(RVA = "0x26085D4", Offset = "0x26085D4", VA = "0x26085D4")]
	public string GetGlobalProgressExchangeStoreToggle2LogoCDNUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A3D")]
	[Address(RVA = "0x2608638", Offset = "0x2608638", VA = "0x2608638")]
	public string GetGlobalProgressExchangeStoreItemBGCDNUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A3E")]
	[Address(RVA = "0x260869C", Offset = "0x260869C", VA = "0x260869C")]
	public Color GetExchangeStoreSelectColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A3F")]
	[Address(RVA = "0x260870C", Offset = "0x260870C", VA = "0x260870C")]
	public Color GetExchangeStoreUnSelectColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A40")]
	[Address(RVA = "0x260877C", Offset = "0x260877C", VA = "0x260877C")]
	public Color GetExchangeStoreButtonColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A41")]
	[Address(RVA = "0x26087EC", Offset = "0x26087EC", VA = "0x26087EC")]
	public Color GetExchangeStoreLimitColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A42")]
	[Address(RVA = "0x260885C", Offset = "0x260885C", VA = "0x260885C")]
	public Color GetExchangeStoreTimeColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A43")]
	[Address(RVA = "0x26088CC", Offset = "0x26088CC", VA = "0x26088CC")]
	public Color GetTokenLabelColor()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x6013A44")]
	[Address(RVA = "0x260893C", Offset = "0x260893C", VA = "0x260893C")]
	public bool GetExchangeStoreRedTips(uint storeType)
	{
		return default(bool);
	}

	[Token(Token = "0x6013A45")]
	[Address(RVA = "0x2608B5C", Offset = "0x2608B5C", VA = "0x2608B5C")]
	private bool RefreshExchangeStoreItemRedTips(EStoreTab storeType, ETipsType storeTipsType)
	{
		return default(bool);
	}

	[Token(Token = "0x6013A46")]
	[Address(RVA = "0x26093CC", Offset = "0x26093CC", VA = "0x26093CC")]
	public bool GetExchangeStoreRedTipsState()
	{
		return default(bool);
	}

	[Token(Token = "0x6013A47")]
	[Address(RVA = "0x2609450", Offset = "0x2609450", VA = "0x2609450")]
	public void RefreshExchangeStoreRedTips()
	{
	}

	[Token(Token = "0x6013A48")]
	[Address(RVA = "0x26094C8", Offset = "0x26094C8", VA = "0x26094C8")]
	public string GetExchangeStoreDateShowCdnUrl()
	{
		return null;
	}

	[Token(Token = "0x6013A49")]
	[Address(RVA = "0x260952C", Offset = "0x260952C", VA = "0x260952C")]
	public string GetEventLogPrefix()
	{
		return null;
	}

	[Token(Token = "0x6013A4A")]
	[Address(RVA = "0x2604390", Offset = "0x2604390", VA = "0x2604390")]
	private void ClearCachedData()
	{
	}

	[Token(Token = "0x6013A4B")]
	[Address(RVA = "0x2609640", Offset = "0x2609640", VA = "0x2609640")]
	private void ProcessInPageEntrance(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	[Token(Token = "0x6013A4C")]
	[Address(RVA = "0x2609864", Offset = "0x2609864", VA = "0x2609864")]
	private void ProcessTemplateComponents(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	[Token(Token = "0x6013A4D")]
	[Address(RVA = "0x2609A88", Offset = "0x2609A88", VA = "0x2609A88")]
	private void ProcessLocs(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	[Token(Token = "0x6013A4E")]
	[Address(RVA = "0x2609D18", Offset = "0x2609D18", VA = "0x2609D18")]
	private void ProcessCDN(CSGetCustomEventOpenInfoRes openInfoRes)
	{
	}

	[Token(Token = "0x6013A4F")]
	[Address(RVA = "0x2609FA8", Offset = "0x2609FA8", VA = "0x2609FA8")]
	private void ProcessRuleConfig()
	{
	}

	[Token(Token = "0x6013A50")]
	[Address(RVA = "0x260A0B8", Offset = "0x260A0B8", VA = "0x260A0B8")]
	private void ProgressRuleByRuleType(EBigEventTemplateRulePopupWndType rulePopupWndType)
	{
	}

	[Token(Token = "0x6013A51")]
	[Address(RVA = "0x25FFDA4", Offset = "0x25FFDA4", VA = "0x25FFDA4")]
	public void RequestOpenInfo()
	{
	}

	[Token(Token = "0x6013A52")]
	[Address(RVA = "0x260A62C", Offset = "0x260A62C", VA = "0x260A62C")]
	public void RequestExchangeStoreInfo(bool force = false)
	{
	}

	[Token(Token = "0x6013A53")]
	[Address(RVA = "0x260A90C", Offset = "0x260A90C", VA = "0x260A90C")]
	public void RequestExchangeStoreDesc(bool force = false)
	{
	}

	[Token(Token = "0x6013A54")]
	[Address(RVA = "0x260AC04", Offset = "0x260AC04", VA = "0x260AC04")]
	public void RequestExchangeStorePurchase(CustomEventStoreCommodityDesc desc, uint cnt = 1u)
	{
	}

	[Token(Token = "0x6013A55")]
	[Address(RVA = "0x260B34C", Offset = "0x260B34C", VA = "0x260B34C")]
	public LocStrWithColor GetExchangeStoreClassicNameStr()
	{
		return null;
	}

	[Token(Token = "0x6013A56")]
	[Address(RVA = "0x260B3B0", Offset = "0x260B3B0", VA = "0x260B3B0")]
	public LocStrWithColor GetExchangeStoreSpecialNameStr()
	{
		return null;
	}

	[Token(Token = "0x6013A57")]
	[Address(RVA = "0x26092A4", Offset = "0x26092A4", VA = "0x26092A4")]
	public CustomLimitedStoreAccountInfo GetExchangeStoreAccountInfoBySkuId(uint skuId)
	{
		return null;
	}

	[Token(Token = "0x6013A58")]
	[Address(RVA = "0x2604F4C", Offset = "0x2604F4C", VA = "0x2604F4C")]
	public CustomEventStoreDesc GetStoreDescByStoreType(uint storeType)
	{
		return null;
	}

	[Token(Token = "0x6013A59")]
	[Address(RVA = "0x260B414", Offset = "0x260B414", VA = "0x260B414")]
	public bool IsDuringOpenTimeByStoreType(uint storeType)
	{
		return default(bool);
	}

	[Token(Token = "0x6013A5A")]
	[Address(RVA = "0x260B538", Offset = "0x260B538", VA = "0x260B538")]
	public uint GetExchangeStoreIdByStoreType(uint storeType)
	{
		return default(uint);
	}

	[Token(Token = "0x6013A5B")]
	[Address(RVA = "0x260B660", Offset = "0x260B660", VA = "0x260B660")]
	public uint GetExchangeStoreTypeByStoreId(uint storeId)
	{
		return default(uint);
	}

	[Token(Token = "0x6013A5C")]
	[Address(RVA = "0x260B8C4", Offset = "0x260B8C4", VA = "0x260B8C4")]
	public bool GetExchangeStoreItemLockStateByStoreId(uint storeId)
	{
		return default(bool);
	}

	[Token(Token = "0x6013A5D")]
	[Address(RVA = "0x260BC50", Offset = "0x260BC50", VA = "0x260BC50")]
	private void _003CRequestOpenInfo_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013A5E")]
	[Address(RVA = "0x260BDC0", Offset = "0x260BDC0", VA = "0x260BDC0")]
	private void _003CRequestExchangeStoreInfo_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013A5F")]
	[Address(RVA = "0x260C028", Offset = "0x260C028", VA = "0x260C028")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6013A60")]
	[Address(RVA = "0x260C030", Offset = "0x260C030", VA = "0x260C030")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6013A61")]
	[Address(RVA = "0x260C038", Offset = "0x260C038", VA = "0x260C038")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
