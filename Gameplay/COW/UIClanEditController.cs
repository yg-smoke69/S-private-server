using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002540")]
public class UIClanEditController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002541")]
	public enum FuntionType
	{
		[Token(Token = "0x400E6EA")]
		Create,
		[Token(Token = "0x400E6EB")]
		Edit,
		[Token(Token = "0x400E6EC")]
		Inspect
	}

	[Token(Token = "0x2002542")]
	public enum TokenType
	{
		[Token(Token = "0x400E6EE")]
		Gold = 1,
		[Token(Token = "0x400E6EF")]
		Diamond
	}

	[Token(Token = "0x2002543")]
	private sealed class _003CGenerateAreaMenuData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E6F0")]
		[FieldOffset(Offset = "0x8")]
		internal ClanAreaData area;

		[Token(Token = "0x600D8EE")]
		[Address(RVA = "0x2F393D8", Offset = "0x2F393D8", VA = "0x2F393D8")]
		public _003CGenerateAreaMenuData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D8EF")]
		[Address(RVA = "0x2F3C4D8", Offset = "0x2F3C4D8", VA = "0x2F3C4D8")]
		internal bool _003C_003Em__0(string temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002544")]
	private sealed class _003CGenerateAreaMenuData_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E6F1")]
		[FieldOffset(Offset = "0x8")]
		internal ClanAreaData area;

		[Token(Token = "0x600D8F0")]
		[Address(RVA = "0x2F393E0", Offset = "0x2F393E0", VA = "0x2F393E0")]
		public _003CGenerateAreaMenuData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600D8F1")]
		[Address(RVA = "0x2F3C57C", Offset = "0x2F3C57C", VA = "0x2F3C57C")]
		internal bool _003C_003Em__0(PopMenuData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E6D1")]
	[FieldOffset(Offset = "0x48")]
	private UIClanEditView m_View;

	[Token(Token = "0x400E6D2")]
	[FieldOffset(Offset = "0x4C")]
	private EClan.EntryType m_CurApprovalType;

	[Token(Token = "0x400E6D3")]
	[FieldOffset(Offset = "0x50")]
	private FuntionType m_FunctionType;

	[Token(Token = "0x400E6D4")]
	[FieldOffset(Offset = "0x54")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E6D5")]
	[FieldOffset(Offset = "0x58")]
	private PopMenuData m_DefaultMenuData;

	[Token(Token = "0x400E6D6")]
	[FieldOffset(Offset = "0x5C")]
	protected List<PopMenuData> m_DataList;

	[Token(Token = "0x400E6D7")]
	[FieldOffset(Offset = "0x60")]
	private UIPopMenuSmallControler m_SelectAreaPopMenuSmallCtrl;

	[Token(Token = "0x400E6D8")]
	[FieldOffset(Offset = "0x64")]
	private UIPopMenuSmallControler m_SelectStylePopMenuSmallCtrl;

	[Token(Token = "0x400E6D9")]
	[FieldOffset(Offset = "0x68")]
	private UIPopMenuSmallControler m_SelectLevelPopMenuSmallCtrl;

	[Token(Token = "0x400E6DA")]
	[FieldOffset(Offset = "0x6C")]
	private UIPopMenuSmallControler m_SelectBRRankPopMenuSmallCtrl;

	[Token(Token = "0x400E6DB")]
	[FieldOffset(Offset = "0x70")]
	private UIPopMenuSmallControler m_SelectCSRankPopMenuSmallCtrl;

	[Token(Token = "0x400E6DC")]
	[FieldOffset(Offset = "0x74")]
	private uint m_AreaID;

	[Token(Token = "0x400E6DD")]
	[FieldOffset(Offset = "0x78")]
	private uint m_PlayStyle;

	[Token(Token = "0x400E6DE")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_LimitLevel;

	[Token(Token = "0x400E6DF")]
	[FieldOffset(Offset = "0x80")]
	private int m_LimitRank;

	[Token(Token = "0x400E6E0")]
	[FieldOffset(Offset = "0x84")]
	private int m_LimitCSRank;

	[Token(Token = "0x400E6E1")]
	[FieldOffset(Offset = "0x88")]
	private uint m_BadgeId;

	[Token(Token = "0x400E6E2")]
	[FieldOffset(Offset = "0x8C")]
	private TokenType m_CurrentTokenType;

	[Token(Token = "0x400E6E3")]
	private const int CREATE_CLAN_NAME_LOWER_LIMIT = 3;

	[Token(Token = "0x400E6E4")]
	private const int SLOGAN_MAX_LENGTH = 20;

	[Token(Token = "0x400E6E5")]
	private const int ANNOUNCEMENT_MAX_LENGTH = 80;

	[Token(Token = "0x400E6E6")]
	private const int POPMENUWIDTH = 263;

	[Token(Token = "0x400E6E7")]
	private const string m_DefaultText = "TXT_SETTING_AIDER_ALLON";

	[Token(Token = "0x400E6E8")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600D8CA")]
	[Address(RVA = "0x2F35044", Offset = "0x2F35044", VA = "0x2F35044")]
	public UIClanEditController()
	{
	}

	[Token(Token = "0x600D8CB")]
	[Address(RVA = "0x2F350D8", Offset = "0x2F350D8", VA = "0x2F350D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D8CC")]
	[Address(RVA = "0x2F3517C", Offset = "0x2F3517C", VA = "0x2F3517C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D8CD")]
	[Address(RVA = "0x2F35210", Offset = "0x2F35210", VA = "0x2F35210", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D8CE")]
	[Address(RVA = "0x2F36288", Offset = "0x2F36288", VA = "0x2F36288", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D8CF")]
	[Address(RVA = "0x2F367B4", Offset = "0x2F367B4", VA = "0x2F367B4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600D8D0")]
	[Address(RVA = "0x2F368E8", Offset = "0x2F368E8", VA = "0x2F368E8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D8D1")]
	[Address(RVA = "0x2F36E88", Offset = "0x2F36E88", VA = "0x2F36E88")]
	public void SetFunctionType(FuntionType type)
	{
	}

	[Token(Token = "0x600D8D2")]
	[Address(RVA = "0x2F37928", Offset = "0x2F37928", VA = "0x2F37928")]
	private void InitView()
	{
	}

	[Token(Token = "0x600D8D3")]
	[Address(RVA = "0x2F352C8", Offset = "0x2F352C8", VA = "0x2F352C8")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600D8D4")]
	[Address(RVA = "0x2F383E8", Offset = "0x2F383E8", VA = "0x2F383E8")]
	private void UpdateApprovalView(bool isApprove)
	{
	}

	[Token(Token = "0x600D8D5")]
	[Address(RVA = "0x2F38600", Offset = "0x2F38600", VA = "0x2F38600")]
	private void RefreshPriceBtnState(uint coinCost, uint gemCost)
	{
	}

	[Token(Token = "0x600D8D6")]
	[Address(RVA = "0x2F38888", Offset = "0x2F38888", VA = "0x2F38888")]
	private void GenerateAreaMenuData()
	{
	}

	[Token(Token = "0x600D8D7")]
	[Address(RVA = "0x2F393E8", Offset = "0x2F393E8", VA = "0x2F393E8")]
	private void OnRegionSelected(object obj)
	{
	}

	[Token(Token = "0x600D8D8")]
	[Address(RVA = "0x2F394A4", Offset = "0x2F394A4", VA = "0x2F394A4")]
	private void GeneratePlayStyleMenuData()
	{
	}

	[Token(Token = "0x600D8D9")]
	[Address(RVA = "0x2F399D0", Offset = "0x2F399D0", VA = "0x2F399D0")]
	private void OnPlayStyleSelected(object obj)
	{
	}

	[Token(Token = "0x600D8DA")]
	[Address(RVA = "0x2F39A8C", Offset = "0x2F39A8C", VA = "0x2F39A8C")]
	private void GenerateLevelMenuData()
	{
	}

	[Token(Token = "0x600D8DB")]
	[Address(RVA = "0x2F39FBC", Offset = "0x2F39FBC", VA = "0x2F39FBC")]
	private void OnLevelSelected(object obj)
	{
	}

	[Token(Token = "0x600D8DC")]
	[Address(RVA = "0x2F3A078", Offset = "0x2F3A078", VA = "0x2F3A078")]
	private void GenerateBRRankMenuData()
	{
	}

	[Token(Token = "0x600D8DD")]
	[Address(RVA = "0x2F3A5F8", Offset = "0x2F3A5F8", VA = "0x2F3A5F8")]
	private void OnBRRankSelected(object obj)
	{
	}

	[Token(Token = "0x600D8DE")]
	[Address(RVA = "0x2F3A6B4", Offset = "0x2F3A6B4", VA = "0x2F3A6B4")]
	private void GenerateCSRankMenuData()
	{
	}

	[Token(Token = "0x600D8DF")]
	[Address(RVA = "0x2F3AC34", Offset = "0x2F3AC34", VA = "0x2F3AC34")]
	private void OnCSRankSelected(object obj)
	{
	}

	[Token(Token = "0x600D8E0")]
	[Address(RVA = "0x2F3ACF0", Offset = "0x2F3ACF0", VA = "0x2F3ACF0")]
	private void OnEditNameClick()
	{
	}

	[Token(Token = "0x600D8E1")]
	[Address(RVA = "0x2F3AE3C", Offset = "0x2F3AE3C", VA = "0x2F3AE3C")]
	private void OnAutoToggleClick()
	{
	}

	[Token(Token = "0x600D8E2")]
	[Address(RVA = "0x2F3AEA0", Offset = "0x2F3AEA0", VA = "0x2F3AEA0")]
	private void OnApproveToggleClick()
	{
	}

	[Token(Token = "0x600D8E3")]
	[Address(RVA = "0x2F3AF04", Offset = "0x2F3AF04", VA = "0x2F3AF04")]
	private void OnDisbandBtnClick()
	{
	}

	[Token(Token = "0x600D8E4")]
	[Address(RVA = "0x2F3B450", Offset = "0x2F3B450", VA = "0x2F3B450")]
	private void OnCoinBtnClick()
	{
	}

	[Token(Token = "0x600D8E5")]
	[Address(RVA = "0x2F3BD54", Offset = "0x2F3BD54", VA = "0x2F3BD54")]
	private void OnGemBtnClick()
	{
	}

	[Token(Token = "0x600D8E6")]
	[Address(RVA = "0x2F3B5C8", Offset = "0x2F3B5C8", VA = "0x2F3B5C8")]
	private void OnBtnConfirmClick()
	{
	}

	[Token(Token = "0x600D8E7")]
	[Address(RVA = "0x2F36960", Offset = "0x2F36960", VA = "0x2F36960")]
	private void OnSettingSave()
	{
	}

	[Token(Token = "0x600D8E8")]
	[Address(RVA = "0x2F3BECC", Offset = "0x2F3BECC", VA = "0x2F3BECC")]
	private void OnTeamIconBtnClick()
	{
	}

	[Token(Token = "0x600D8E9")]
	[Address(RVA = "0x2F3C1EC", Offset = "0x2F3C1EC", VA = "0x2F3C1EC")]
	private void ResetBadgeId(object[] data)
	{
	}

	[Token(Token = "0x600D8EA")]
	[Address(RVA = "0x2F3C3EC", Offset = "0x2F3C3EC", VA = "0x2F3C3EC")]
	private static void _003COnDisbandBtnClick_003Em__0()
	{
	}

	[Token(Token = "0x600D8EB")]
	[Address(RVA = "0x2F3C4C0", Offset = "0x2F3C4C0", VA = "0x2F3C4C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D8EC")]
	[Address(RVA = "0x2F3C4C8", Offset = "0x2F3C4C8", VA = "0x2F3C4C8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600D8ED")]
	[Address(RVA = "0x2F3C4D0", Offset = "0x2F3C4D0", VA = "0x2F3C4D0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
