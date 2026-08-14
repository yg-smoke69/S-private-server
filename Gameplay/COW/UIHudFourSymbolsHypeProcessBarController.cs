using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002752")]
public class UIHudFourSymbolsHypeProcessBarController : UIBaseController
{
	[Token(Token = "0x400F2C3")]
	[FieldOffset(Offset = "0x28")]
	private UIHudFourSymbolsHypeProcessBarView m_View;

	[Token(Token = "0x400F2C4")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIFourSymbolsChooseItemController> m_CacheChooseItems;

	[Token(Token = "0x400F2C5")]
	[FieldOffset(Offset = "0x30")]
	private LLPPBHECILH m_Game;

	[Token(Token = "0x400F2C6")]
	[FieldOffset(Offset = "0x34")]
	private ushort m_CurrentHypeValue;

	[Token(Token = "0x400F2C7")]
	[FieldOffset(Offset = "0x36")]
	private ushort m_LastHypeValue;

	[Token(Token = "0x400F2C8")]
	[FieldOffset(Offset = "0x38")]
	private ushort m_MaxHypeValue;

	[Token(Token = "0x400F2C9")]
	[FieldOffset(Offset = "0x3A")]
	protected ushort m_CurrentHypeLevel;

	[Token(Token = "0x400F2CA")]
	[FieldOffset(Offset = "0x3C")]
	private ushort m_MaxHypeLevel;

	[Token(Token = "0x400F2CB")]
	[FieldOffset(Offset = "0x40")]
	private float m_HypeChangeProcess;

	[Token(Token = "0x400F2CC")]
	private const int m_SliderChangeSpeed = 3;

	[Token(Token = "0x400F2CD")]
	private const float m_HypeValueChangedPassedTime = 2f;

	[Token(Token = "0x400F2CE")]
	[FieldOffset(Offset = "0x44")]
	private bool m_HypeValueHadChanged;

	[Token(Token = "0x400F2CF")]
	[FieldOffset(Offset = "0x48")]
	private float m_Timer;

	[Token(Token = "0x400F2D0")]
	private const float m_hypeValPerLevel = 1000f;

	[Token(Token = "0x400F2D1")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_HasInitSelectItemCnt;

	[Token(Token = "0x400F2D2")]
	[FieldOffset(Offset = "0x4D")]
	private bool m_IsPress;

	[Token(Token = "0x400F2D3")]
	[FieldOffset(Offset = "0x4E")]
	private bool m_IsShowDetail;

	[Token(Token = "0x400F2D4")]
	[FieldOffset(Offset = "0x50")]
	private Color m_DefaultFullColor;

	[Token(Token = "0x400F2D5")]
	[FieldOffset(Offset = "0x60")]
	private ResourceID m_DefaultSliderFullEffect;

	[Token(Token = "0x400F2D6")]
	[FieldOffset(Offset = "0x64")]
	private ResourceID m_DefaultLevelupAudioEffect;

	[Token(Token = "0x400F2D7")]
	[FieldOffset(Offset = "0x68")]
	private ResourceID m_LevelMaxAudioEffect;

	[Token(Token = "0x400F2D8")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, FourSymbolSlider> m_SlidersInfo;

	[Token(Token = "0x400F2D9")]
	[FieldOffset(Offset = "0x70")]
	private UISprite m_TargetSlider;

	[Token(Token = "0x400F2DA")]
	[FieldOffset(Offset = "0x74")]
	private UICamera m_UICamera;

	[Token(Token = "0x400F2DB")]
	[FieldOffset(Offset = "0x78")]
	private Camera m_Camera;

	[Token(Token = "0x400F2DC")]
	[FieldOffset(Offset = "0x7C")]
	private float m_HitDist;

	[Token(Token = "0x400F2DD")]
	private const string CONDITION1NAME = "BtnFire";

	[Token(Token = "0x400F2DE")]
	private const string CONDITION2NAME = "InventoryEntryContent";

	[Token(Token = "0x400F2DF")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsTriggerBtnClick;

	[Token(Token = "0x400F2E0")]
	[FieldOffset(Offset = "0x84")]
	private float m_LeftScreenWidth;

	[Token(Token = "0x400F2E1")]
	[FieldOffset(Offset = "0x88")]
	private List<UILabel> m_CacheDescInfos;

	[Token(Token = "0x400F2E2")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_IgnoreFirstIfReconnect;

	[Token(Token = "0x170011C3")]
	public bool HadHypeValueChanged
	{
		[Token(Token = "0x600F030")]
		[Address(RVA = "0x188039C", Offset = "0x188039C", VA = "0x188039C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600F031")]
		[Address(RVA = "0x18803F4", Offset = "0x18803F4", VA = "0x18803F4")]
		set
		{
		}
	}

	[Token(Token = "0x600F02C")]
	[Address(RVA = "0x187F150", Offset = "0x187F150", VA = "0x187F150")]
	public UIHudFourSymbolsHypeProcessBarController()
	{
	}

	[Token(Token = "0x600F02D")]
	[Address(RVA = "0x187F2E0", Offset = "0x187F2E0", VA = "0x187F2E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F02E")]
	[Address(RVA = "0x187F384", Offset = "0x187F384", VA = "0x187F384", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F02F")]
	[Address(RVA = "0x187FFF8", Offset = "0x187FFF8", VA = "0x187FFF8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F032")]
	[Address(RVA = "0x1880510", Offset = "0x1880510", VA = "0x1880510")]
	protected void Update()
	{
	}

	[Token(Token = "0x600F033")]
	[Address(RVA = "0x1880580", Offset = "0x1880580", VA = "0x1880580")]
	private void UpdateProcess()
	{
	}

	[Token(Token = "0x600F034")]
	[Address(RVA = "0x188067C", Offset = "0x188067C", VA = "0x188067C")]
	private void UpdateTouchInfo()
	{
	}

	[Token(Token = "0x600F035")]
	[Address(RVA = "0x18806EC", Offset = "0x18806EC", VA = "0x18806EC")]
	private void UpdateLongPressInfo()
	{
	}

	[Token(Token = "0x600F036")]
	[Address(RVA = "0x1880EF8", Offset = "0x1880EF8", VA = "0x1880EF8")]
	private bool CheckPCTouch(Vector3 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600F037")]
	[Address(RVA = "0x18808EC", Offset = "0x18808EC", VA = "0x18808EC")]
	private bool CheckMobileTouch()
	{
		return default(bool);
	}

	[Token(Token = "0x600F038")]
	[Address(RVA = "0x1881008", Offset = "0x1881008", VA = "0x1881008")]
	private bool CheckPos(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600F039")]
	[Address(RVA = "0x18809E4", Offset = "0x18809E4", VA = "0x18809E4")]
	private void OnMeetTouchCondition()
	{
	}

	[Token(Token = "0x600F03A")]
	[Address(RVA = "0x1881410", Offset = "0x1881410", VA = "0x1881410")]
	private void UpdateTargetSlider()
	{
	}

	[Token(Token = "0x600F03B")]
	[Address(RVA = "0x1881750", Offset = "0x1881750", VA = "0x1881750")]
	private void InitSelectItem(int cnt)
	{
	}

	[Token(Token = "0x600F03C")]
	[Address(RVA = "0x187FD14", Offset = "0x187FD14", VA = "0x187FD14")]
	private void InitSlider()
	{
	}

	[Token(Token = "0x600F03D")]
	[Address(RVA = "0x18818E4", Offset = "0x18818E4", VA = "0x18818E4")]
	private void OnPlayerFourSymbolsSelectAttribute(object[] data)
	{
	}

	[Token(Token = "0x600F03E")]
	[Address(RVA = "0x188329C", Offset = "0x188329C", VA = "0x188329C")]
	private void OnPlayerFourSymbolsPendingAttributeUpdate(object[] data)
	{
	}

	[Token(Token = "0x600F03F")]
	[Address(RVA = "0x18834A0", Offset = "0x18834A0", VA = "0x18834A0")]
	private void OnLevelUpBtnClick()
	{
	}

	[Token(Token = "0x600F040")]
	[Address(RVA = "0x1881D64", Offset = "0x1881D64", VA = "0x1881D64")]
	private void ShowSelectAttributeView()
	{
	}

	[Token(Token = "0x600F041")]
	[Address(RVA = "0x1883560", Offset = "0x1883560", VA = "0x1883560")]
	private void OnLongPressBtn(bool isPress)
	{
	}

	[Token(Token = "0x600F042")]
	[Address(RVA = "0x1880C50", Offset = "0x1880C50", VA = "0x1880C50")]
	private void ShowDetail(bool b)
	{
	}

	[Token(Token = "0x600F043")]
	[Address(RVA = "0x1882CE8", Offset = "0x1882CE8", VA = "0x1882CE8")]
	private void UpdateDescInfo()
	{
	}

	[Token(Token = "0x600F044")]
	[Address(RVA = "0x18835E8", Offset = "0x18835E8", VA = "0x18835E8")]
	private void UpdateInfoBg()
	{
	}

	[Token(Token = "0x600F045")]
	[Address(RVA = "0x1882248", Offset = "0x1882248", VA = "0x1882248")]
	private void UpdateSliderInfo()
	{
	}

	[Token(Token = "0x600F046")]
	[Address(RVA = "0x188076C", Offset = "0x188076C", VA = "0x188076C")]
	private void ShowSliderValueChange(float progress)
	{
	}

	[Token(Token = "0x600F047")]
	[Address(RVA = "0x1883868", Offset = "0x1883868", VA = "0x1883868")]
	private void ShowHypeChangeEffect(bool isIncreasing)
	{
	}

	[Token(Token = "0x600F048")]
	[Address(RVA = "0x1883A78", Offset = "0x1883A78", VA = "0x1883A78")]
	private void RefreshHypeValueState()
	{
	}

	[Token(Token = "0x600F049")]
	[Address(RVA = "0x1883AE8", Offset = "0x1883AE8", VA = "0x1883AE8")]
	private void OnHypeValueChange(object[] data)
	{
	}

	[Token(Token = "0x600F04A")]
	[Address(RVA = "0x1883C1C", Offset = "0x1883C1C", VA = "0x1883C1C")]
	private void OnHypeLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600F04B")]
	[Address(RVA = "0x1883E34", Offset = "0x1883E34", VA = "0x1883E34")]
	private void OnMaxHypeValueChange(object[] data)
	{
	}

	[Token(Token = "0x600F04C")]
	[Address(RVA = "0x1883F04", Offset = "0x1883F04", VA = "0x1883F04")]
	private void OnMaxHypeLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600F04D")]
	[Address(RVA = "0x1883FD4", Offset = "0x1883FD4", VA = "0x1883FD4")]
	private void OnSwitchObserver(object[] data)
	{
	}

	[Token(Token = "0x600F04E")]
	[Address(RVA = "0x1884048", Offset = "0x1884048", VA = "0x1884048")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F04F")]
	[Address(RVA = "0x1884050", Offset = "0x1884050", VA = "0x1884050")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
