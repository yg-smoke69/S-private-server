using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200274E")]
public class UIHudFlagBattleHypeProcessBarController : UIBaseController
{
	[Token(Token = "0x200274F")]
	public class FlagBattleSlider
	{
		[Token(Token = "0x400F2BD")]
		[FieldOffset(Offset = "0x8")]
		public byte Camp;

		[Token(Token = "0x400F2BE")]
		[FieldOffset(Offset = "0xC")]
		public UISprite SliderSpr;

		[Token(Token = "0x400F2BF")]
		[FieldOffset(Offset = "0x10")]
		public GameObject EffectGo;

		[Token(Token = "0x400F2C0")]
		[FieldOffset(Offset = "0x14")]
		public ParticleSystem ParticleSys;

		[Token(Token = "0x600F021")]
		[Address(RVA = "0x1BAB318", Offset = "0x1BAB318", VA = "0x1BAB318")]
		public FlagBattleSlider(byte camp, UISprite sliderSpr)
		{
		}
	}

	[Token(Token = "0x400F29D")]
	[FieldOffset(Offset = "0x28")]
	protected UIHudFlagBattleHypeProcessBarView m_View;

	[Token(Token = "0x400F29E")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIFlagBattleChooseItemController> m_CacheChooseItems;

	[Token(Token = "0x400F29F")]
	[FieldOffset(Offset = "0x30")]
	private AAJOPLKMDGH m_Game;

	[Token(Token = "0x400F2A0")]
	[FieldOffset(Offset = "0x34")]
	private ushort m_CurrentHypeValue;

	[Token(Token = "0x400F2A1")]
	[FieldOffset(Offset = "0x36")]
	private ushort m_LastHypeValue;

	[Token(Token = "0x400F2A2")]
	[FieldOffset(Offset = "0x38")]
	private ushort m_MaxHypeValue;

	[Token(Token = "0x400F2A3")]
	[FieldOffset(Offset = "0x3A")]
	protected ushort m_CurrentHypeLevel;

	[Token(Token = "0x400F2A4")]
	[FieldOffset(Offset = "0x3C")]
	private ushort m_MaxHypeLevel;

	[Token(Token = "0x400F2A5")]
	[FieldOffset(Offset = "0x40")]
	private float m_HypeChangeProcess;

	[Token(Token = "0x400F2A6")]
	private const int m_SliderChangeSpeed = 3;

	[Token(Token = "0x400F2A7")]
	private const float m_HypeValueChangedPassedTime = 2f;

	[Token(Token = "0x400F2A8")]
	[FieldOffset(Offset = "0x44")]
	private bool m_HypeValueHadChanged;

	[Token(Token = "0x400F2A9")]
	[FieldOffset(Offset = "0x48")]
	private float m_Timer;

	[Token(Token = "0x400F2AA")]
	private const float m_hypeValPerLevel = 1000f;

	[Token(Token = "0x400F2AB")]
	[FieldOffset(Offset = "0x4C")]
	private bool m_HasInitSelectItemCnt;

	[Token(Token = "0x400F2AC")]
	[FieldOffset(Offset = "0x4D")]
	private bool m_IsPress;

	[Token(Token = "0x400F2AD")]
	[FieldOffset(Offset = "0x4E")]
	private bool m_IsShowDetail;

	[Token(Token = "0x400F2AE")]
	[FieldOffset(Offset = "0x50")]
	private Color m_DefaultFullColor;

	[Token(Token = "0x400F2AF")]
	[FieldOffset(Offset = "0x60")]
	private ResourceID m_DefaultSliderFullEffect;

	[Token(Token = "0x400F2B0")]
	[FieldOffset(Offset = "0x64")]
	private ResourceID m_DefaultLevelupAudioEffect;

	[Token(Token = "0x400F2B1")]
	[FieldOffset(Offset = "0x68")]
	private ResourceID m_LevelMaxAudioEffect;

	[Token(Token = "0x400F2B2")]
	[FieldOffset(Offset = "0x6C")]
	private Dictionary<uint, FlagBattleSlider> m_SlidersInfo;

	[Token(Token = "0x400F2B3")]
	[FieldOffset(Offset = "0x70")]
	private UISprite m_TargetSlider;

	[Token(Token = "0x400F2B4")]
	[FieldOffset(Offset = "0x74")]
	private UICamera m_UICamera;

	[Token(Token = "0x400F2B5")]
	[FieldOffset(Offset = "0x78")]
	private Camera m_Camera;

	[Token(Token = "0x400F2B6")]
	[FieldOffset(Offset = "0x7C")]
	private float m_HitDist;

	[Token(Token = "0x400F2B7")]
	private const string CONDITION1NAME = "BtnFire";

	[Token(Token = "0x400F2B8")]
	private const string CONDITION2NAME = "InventoryEntryContent";

	[Token(Token = "0x400F2B9")]
	[FieldOffset(Offset = "0x80")]
	private bool m_IsTriggerBtnClick;

	[Token(Token = "0x400F2BA")]
	[FieldOffset(Offset = "0x84")]
	private float m_LeftScreenWidth;

	[Token(Token = "0x400F2BB")]
	[FieldOffset(Offset = "0x88")]
	private List<UILabel> m_CacheDescInfos;

	[Token(Token = "0x400F2BC")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_IgnoreFirstIfReconnect;

	[Token(Token = "0x170011C0")]
	protected bool IsShowDetail
	{
		[Token(Token = "0x600EFF4")]
		[Address(RVA = "0x1BA8D88", Offset = "0x1BA8D88", VA = "0x1BA8D88")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600EFF5")]
		[Address(RVA = "0x1BA8DE0", Offset = "0x1BA8DE0", VA = "0x1BA8DE0")]
		set
		{
		}
	}

	[Token(Token = "0x170011C1")]
	protected Dictionary<uint, FlagBattleSlider> SlidersInfo
	{
		[Token(Token = "0x600EFF6")]
		[Address(RVA = "0x1BA8E40", Offset = "0x1BA8E40", VA = "0x1BA8E40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170011C2")]
	public bool HadHypeValueChanged
	{
		[Token(Token = "0x600EFFA")]
		[Address(RVA = "0x1BAA020", Offset = "0x1BAA020", VA = "0x1BAA020")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600EFFB")]
		[Address(RVA = "0x1BAA078", Offset = "0x1BAA078", VA = "0x1BAA078")]
		set
		{
		}
	}

	[Token(Token = "0x600EFF3")]
	[Address(RVA = "0x1BA8BF8", Offset = "0x1BA8BF8", VA = "0x1BA8BF8")]
	public UIHudFlagBattleHypeProcessBarController()
	{
	}

	[Token(Token = "0x600EFF7")]
	[Address(RVA = "0x1BA8E98", Offset = "0x1BA8E98", VA = "0x1BA8E98")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EFF8")]
	[Address(RVA = "0x1BA8F40", Offset = "0x1BA8F40", VA = "0x1BA8F40", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EFF9")]
	[Address(RVA = "0x1BA9C14", Offset = "0x1BA9C14", VA = "0x1BA9C14", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EFFC")]
	[Address(RVA = "0x1BAA194", Offset = "0x1BAA194", VA = "0x1BAA194")]
	protected void Update()
	{
	}

	[Token(Token = "0x600EFFD")]
	[Address(RVA = "0x1BAA204", Offset = "0x1BAA204", VA = "0x1BAA204")]
	private void UpdateProcess()
	{
	}

	[Token(Token = "0x600EFFE")]
	[Address(RVA = "0x1BAA300", Offset = "0x1BAA300", VA = "0x1BAA300")]
	private void UpdateTouchInfo()
	{
	}

	[Token(Token = "0x600EFFF")]
	[Address(RVA = "0x1BAA370", Offset = "0x1BAA370", VA = "0x1BAA370")]
	private void UpdateLongPressInfo()
	{
	}

	[Token(Token = "0x600F000")]
	[Address(RVA = "0x1BAA928", Offset = "0x1BAA928", VA = "0x1BAA928")]
	private bool CheckPCTouch(Vector3 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600F001")]
	[Address(RVA = "0x1BAA5C4", Offset = "0x1BAA5C4", VA = "0x1BAA5C4")]
	private bool CheckMobileTouch()
	{
		return default(bool);
	}

	[Token(Token = "0x600F002")]
	[Address(RVA = "0x1BAAA38", Offset = "0x1BAAA38", VA = "0x1BAAA38")]
	private bool CheckPos(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600F003")]
	[Address(RVA = "0x1BAA6BC", Offset = "0x1BAA6BC", VA = "0x1BAA6BC")]
	private void OnMeetTouchCondition()
	{
	}

	[Token(Token = "0x600F004")]
	[Address(RVA = "0x1BAAE40", Offset = "0x1BAAE40", VA = "0x1BAAE40")]
	private void UpdateTargetSlider()
	{
	}

	[Token(Token = "0x600F005")]
	[Address(RVA = "0x1BAB184", Offset = "0x1BAB184", VA = "0x1BAB184")]
	private void InitSelectItem(int cnt)
	{
	}

	[Token(Token = "0x600F006")]
	[Address(RVA = "0x1BA9920", Offset = "0x1BA9920", VA = "0x1BA9920")]
	private void InitSlider()
	{
	}

	[Token(Token = "0x600F007")]
	[Address(RVA = "0x1BAB340", Offset = "0x1BAB340", VA = "0x1BAB340")]
	private void OnPlayerFourSymbolsSelectAttribute(object[] data)
	{
	}

	[Token(Token = "0x600F008")]
	[Address(RVA = "0x1BABDF4", Offset = "0x1BABDF4", VA = "0x1BABDF4")]
	private void OnPlayerReviveShowBuffUI(object[] data)
	{
	}

	[Token(Token = "0x600F009")]
	[Address(RVA = "0x1BABFD0", Offset = "0x1BABFD0", VA = "0x1BABFD0")]
	private void OnPlayerFourSymbolsPendingAttributeUpdate(object[] data)
	{
	}

	[Token(Token = "0x600F00A")]
	[Address(RVA = "0x1BAC1E0", Offset = "0x1BAC1E0", VA = "0x1BAC1E0", Slot = "31")]
	protected virtual void OnLevelUpBtnClick()
	{
	}

	[Token(Token = "0x600F00B")]
	[Address(RVA = "0x1BAB7CC", Offset = "0x1BAB7CC", VA = "0x1BAB7CC")]
	private void ShowSelectAttributeView()
	{
	}

	[Token(Token = "0x600F00C")]
	[Address(RVA = "0x1BAC2A0", Offset = "0x1BAC2A0", VA = "0x1BAC2A0")]
	private void OnLongPressBtn(bool isPress)
	{
	}

	[Token(Token = "0x600F00D")]
	[Address(RVA = "0x1BAC334", Offset = "0x1BAC334", VA = "0x1BAC334", Slot = "32")]
	protected virtual void ShowDetail(bool b)
	{
	}

	[Token(Token = "0x600F00E")]
	[Address(RVA = "0x1BABCB0", Offset = "0x1BABCB0", VA = "0x1BABCB0")]
	private void UpdateDescInfo()
	{
	}

	[Token(Token = "0x600F00F")]
	[Address(RVA = "0x1BAC5DC", Offset = "0x1BAC5DC", VA = "0x1BAC5DC", Slot = "33")]
	protected virtual void ShowHypeDesc(Dictionary<byte, uint> data)
	{
	}

	[Token(Token = "0x600F010")]
	[Address(RVA = "0x1BACAFC", Offset = "0x1BACAFC", VA = "0x1BACAFC")]
	private void UpdateInfoBg()
	{
	}

	[Token(Token = "0x600F011")]
	[Address(RVA = "0x1BACD7C", Offset = "0x1BACD7C", VA = "0x1BACD7C", Slot = "34")]
	protected virtual void UpdateSliderInfo()
	{
	}

	[Token(Token = "0x600F012")]
	[Address(RVA = "0x1BAD088", Offset = "0x1BAD088", VA = "0x1BAD088")]
	protected void ShowSliderSprEffect(FlagBattleSlider sliderInfo)
	{
	}

	[Token(Token = "0x600F013")]
	[Address(RVA = "0x1BAD524", Offset = "0x1BAD524", VA = "0x1BAD524")]
	protected void ResetSliderSprEffect(FlagBattleSlider sliderInfo)
	{
	}

	[Token(Token = "0x600F014")]
	[Address(RVA = "0x1BAD6A4", Offset = "0x1BAD6A4", VA = "0x1BAD6A4", Slot = "35")]
	protected virtual void ShowSliderLvInfo(Dictionary<byte, uint> selectedAtt)
	{
	}

	[Token(Token = "0x600F015")]
	[Address(RVA = "0x1BADA3C", Offset = "0x1BADA3C", VA = "0x1BADA3C")]
	protected void RefreshForPlayer(ushort curHypeValue, ushort maxHypeValue, ushort curHypeLv, ushort maxHypeLv)
	{
	}

	[Token(Token = "0x600F016")]
	[Address(RVA = "0x1BAA3FC", Offset = "0x1BAA3FC", VA = "0x1BAA3FC")]
	private void ShowSliderValueChange(float progress)
	{
	}

	[Token(Token = "0x600F017")]
	[Address(RVA = "0x1BADCB4", Offset = "0x1BADCB4", VA = "0x1BADCB4")]
	private void ShowHypeChangeEffect(bool isIncreasing)
	{
	}

	[Token(Token = "0x600F018")]
	[Address(RVA = "0x1BADEC4", Offset = "0x1BADEC4", VA = "0x1BADEC4")]
	private void RefreshHypeValueState()
	{
	}

	[Token(Token = "0x600F019")]
	[Address(RVA = "0x1BADF34", Offset = "0x1BADF34", VA = "0x1BADF34")]
	private void OnHypeValueChange(object[] data)
	{
	}

	[Token(Token = "0x600F01A")]
	[Address(RVA = "0x1BAE068", Offset = "0x1BAE068", VA = "0x1BAE068", Slot = "36")]
	protected virtual void OnHypeLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600F01B")]
	[Address(RVA = "0x1BAE280", Offset = "0x1BAE280", VA = "0x1BAE280")]
	private void OnMaxHypeValueChange(object[] data)
	{
	}

	[Token(Token = "0x600F01C")]
	[Address(RVA = "0x1BAE350", Offset = "0x1BAE350", VA = "0x1BAE350")]
	private void OnMaxHypeLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600F01D")]
	[Address(RVA = "0x1BAE420", Offset = "0x1BAE420", VA = "0x1BAE420", Slot = "37")]
	protected virtual void OnSwitchObserver(object[] data)
	{
	}

	[Token(Token = "0x600F01E")]
	[Address(RVA = "0x1BAE494", Offset = "0x1BAE494", VA = "0x1BAE494")]
	public void UpdateFSModePos(float y)
	{
	}

	[Token(Token = "0x600F01F")]
	[Address(RVA = "0x1BAE5A0", Offset = "0x1BAE5A0", VA = "0x1BAE5A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F020")]
	[Address(RVA = "0x1BAE5A8", Offset = "0x1BAE5A8", VA = "0x1BAE5A8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
