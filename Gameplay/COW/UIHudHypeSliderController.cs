using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002779")]
public class UIHudHypeSliderController : UIBaseController
{
	[Token(Token = "0x400F3AE")]
	[FieldOffset(Offset = "0x28")]
	private UIHudHypeProcessBarView m_View;

	[Token(Token = "0x400F3AF")]
	private const float m_HypeResetValue = 0f;

	[Token(Token = "0x400F3B0")]
	[FieldOffset(Offset = "0x2C")]
	private ushort m_CurrentHypeValue;

	[Token(Token = "0x400F3B1")]
	[FieldOffset(Offset = "0x2E")]
	private ushort m_LastHypeValue;

	[Token(Token = "0x400F3B2")]
	[FieldOffset(Offset = "0x30")]
	private ushort m_MaxHypeValue;

	[Token(Token = "0x400F3B3")]
	[FieldOffset(Offset = "0x32")]
	protected ushort m_CurrentHypeLevel;

	[Token(Token = "0x400F3B4")]
	[FieldOffset(Offset = "0x34")]
	private ushort m_MaxHypeLevel;

	[Token(Token = "0x400F3B5")]
	[FieldOffset(Offset = "0x38")]
	private float m_HypeChangeProcess;

	[Token(Token = "0x400F3B6")]
	private const int m_SliderChangeSpeed = 3;

	[Token(Token = "0x400F3B7")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<ushort, Transform> m_LevelUpBlockDic;

	[Token(Token = "0x400F3B8")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<ushort, Transform> m_LevelBgDic;

	[Token(Token = "0x400F3B9")]
	[FieldOffset(Offset = "0x44")]
	private int TOTAL_BAR_WIDTH;

	[Token(Token = "0x400F3BA")]
	private const float m_HypeValueChangedPassedTime = 2f;

	[Token(Token = "0x400F3BB")]
	[FieldOffset(Offset = "0x48")]
	private bool m_HypeValueHadChanged;

	[Token(Token = "0x400F3BC")]
	[FieldOffset(Offset = "0x4C")]
	private float m_Timer;

	[Token(Token = "0x400F3BD")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsFootball;

	[Token(Token = "0x170011C8")]
	public bool HadHypeValueChanged
	{
		[Token(Token = "0x600F1D1")]
		[Address(RVA = "0x134D04C", Offset = "0x134D04C", VA = "0x134D04C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600F1D2")]
		[Address(RVA = "0x134D0A4", Offset = "0x134D0A4", VA = "0x134D0A4")]
		set
		{
		}
	}

	[Token(Token = "0x600F1CF")]
	[Address(RVA = "0x134CF1C", Offset = "0x134CF1C", VA = "0x134CF1C")]
	public UIHudHypeSliderController()
	{
	}

	[Token(Token = "0x600F1D0")]
	[Address(RVA = "0x134CFA8", Offset = "0x134CFA8", VA = "0x134CFA8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F1D3")]
	[Address(RVA = "0x134D1C0", Offset = "0x134D1C0", VA = "0x134D1C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F1D4")]
	[Address(RVA = "0x134DBEC", Offset = "0x134DBEC", VA = "0x134DBEC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F1D5")]
	[Address(RVA = "0x134DF30", Offset = "0x134DF30", VA = "0x134DF30")]
	protected void Update()
	{
	}

	[Token(Token = "0x600F1D6")]
	[Address(RVA = "0x134E554", Offset = "0x134E554", VA = "0x134E554")]
	private void ShowNumJump(float progress)
	{
	}

	[Token(Token = "0x600F1D7")]
	[Address(RVA = "0x134E160", Offset = "0x134E160", VA = "0x134E160")]
	private void ShowSliderValueChange(float progress)
	{
	}

	[Token(Token = "0x600F1D8")]
	[Address(RVA = "0x134E2B4", Offset = "0x134E2B4", VA = "0x134E2B4")]
	private void OnFootBallRadiusChange(float radius)
	{
	}

	[Token(Token = "0x600F1D9")]
	[Address(RVA = "0x134E6AC", Offset = "0x134E6AC", VA = "0x134E6AC")]
	private void OnFootBallStatusChange(object[] data)
	{
	}

	[Token(Token = "0x600F1DA")]
	[Address(RVA = "0x134E828", Offset = "0x134E828", VA = "0x134E828")]
	private void OnHypeValueChange(object[] data)
	{
	}

	[Token(Token = "0x600F1DB")]
	[Address(RVA = "0x134EB54", Offset = "0x134EB54", VA = "0x134EB54", Slot = "31")]
	protected virtual void OnHypeLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600F1DC")]
	[Address(RVA = "0x134F158", Offset = "0x134F158", VA = "0x134F158")]
	private void OnMaxHypeValueChange(object[] data)
	{
	}

	[Token(Token = "0x600F1DD")]
	[Address(RVA = "0x134F228", Offset = "0x134F228", VA = "0x134F228")]
	private void OnMaxHypeLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600F1DE")]
	[Address(RVA = "0x134F304", Offset = "0x134F304", VA = "0x134F304")]
	private void UpdateBarItem()
	{
	}

	[Token(Token = "0x600F1DF")]
	[Address(RVA = "0x134E95C", Offset = "0x134E95C", VA = "0x134E95C")]
	private void RefreshHypeValueState()
	{
	}

	[Token(Token = "0x600F1E0")]
	[Address(RVA = "0x134EE3C", Offset = "0x134EE3C", VA = "0x134EE3C")]
	private void ResetLevelBlockStateAndSliderBgPos(ushort newLevel)
	{
	}

	[Token(Token = "0x600F1E1")]
	[Address(RVA = "0x134FA5C", Offset = "0x134FA5C", VA = "0x134FA5C", Slot = "32")]
	protected virtual void ShowMaxHypeLevelEffect(bool _needshow)
	{
	}

	[Token(Token = "0x600F1E2")]
	[Address(RVA = "0x134EC64", Offset = "0x134EC64", VA = "0x134EC64")]
	private void ShowHypeLevelUpAnim()
	{
	}

	[Token(Token = "0x600F1E3")]
	[Address(RVA = "0x134E9CC", Offset = "0x134E9CC", VA = "0x134E9CC")]
	private void ShowHypeChangeEffect(bool isIncreasing)
	{
	}

	[Token(Token = "0x600F1E4")]
	[Address(RVA = "0x134FB84", Offset = "0x134FB84", VA = "0x134FB84")]
	private void OnSwitchObserver(object[] data)
	{
	}

	[Token(Token = "0x600F1E5")]
	[Address(RVA = "0x134FBF8", Offset = "0x134FBF8", VA = "0x134FBF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F1E6")]
	[Address(RVA = "0x134FC00", Offset = "0x134FC00", VA = "0x134FC00")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
