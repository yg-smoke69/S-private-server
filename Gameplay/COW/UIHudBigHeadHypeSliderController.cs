using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026EA")]
public class UIHudBigHeadHypeSliderController : UIBaseController
{
	[Token(Token = "0x400F050")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBigHeadHypeProcessBarView m_View;

	[Token(Token = "0x400F051")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_TutShowed;

	[Token(Token = "0x400F052")]
	private const float m_HypeResetValue = 0f;

	[Token(Token = "0x400F053")]
	[FieldOffset(Offset = "0x2E")]
	private ushort m_CurrentHypeValue;

	[Token(Token = "0x400F054")]
	[FieldOffset(Offset = "0x30")]
	private ushort m_LastHypeValue;

	[Token(Token = "0x400F055")]
	[FieldOffset(Offset = "0x32")]
	private ushort m_MaxHypeValue;

	[Token(Token = "0x400F056")]
	[FieldOffset(Offset = "0x34")]
	protected ushort m_CurrentHypeLevel;

	[Token(Token = "0x400F057")]
	[FieldOffset(Offset = "0x36")]
	private ushort m_MaxHypeLevel;

	[Token(Token = "0x400F058")]
	[FieldOffset(Offset = "0x38")]
	private float m_HypeChangeProcess;

	[Token(Token = "0x400F059")]
	private const int m_SliderChangeSpeed = 3;

	[Token(Token = "0x400F05A")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<ushort, Transform> m_LevelUpBlockDic;

	[Token(Token = "0x400F05B")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<ushort, Transform> m_LevelBgDic;

	[Token(Token = "0x400F05C")]
	[FieldOffset(Offset = "0x44")]
	private int TOTAL_BAR_WIDTH;

	[Token(Token = "0x400F05D")]
	private const float m_HypeValueChangedPassedTime = 2f;

	[Token(Token = "0x400F05E")]
	[FieldOffset(Offset = "0x48")]
	private bool m_HypeValueHadChanged;

	[Token(Token = "0x400F05F")]
	[FieldOffset(Offset = "0x4C")]
	private float m_Timer;

	[Token(Token = "0x400F060")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsFootball;

	[Token(Token = "0x170011AC")]
	public bool HadHypeValueChanged
	{
		[Token(Token = "0x600EBE2")]
		[Address(RVA = "0x1DFC81C", Offset = "0x1DFC81C", VA = "0x1DFC81C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600EBE3")]
		[Address(RVA = "0x1DFC874", Offset = "0x1DFC874", VA = "0x1DFC874")]
		set
		{
		}
	}

	[Token(Token = "0x600EBDD")]
	[Address(RVA = "0x1DFB204", Offset = "0x1DFB204", VA = "0x1DFB204")]
	public UIHudBigHeadHypeSliderController()
	{
	}

	[Token(Token = "0x600EBDE")]
	[Address(RVA = "0x1DFB290", Offset = "0x1DFB290", VA = "0x1DFB290")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EBDF")]
	[Address(RVA = "0x1DFB334", Offset = "0x1DFB334", VA = "0x1DFB334", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EBE0")]
	[Address(RVA = "0x1DFBC9C", Offset = "0x1DFBC9C", VA = "0x1DFBC9C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EBE1")]
	[Address(RVA = "0x1DFC040", Offset = "0x1DFC040", VA = "0x1DFC040")]
	protected void OnHypeLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600EBE4")]
	[Address(RVA = "0x1DFC990", Offset = "0x1DFC990", VA = "0x1DFC990")]
	protected void Update()
	{
	}

	[Token(Token = "0x600EBE5")]
	[Address(RVA = "0x1DFCDE0", Offset = "0x1DFCDE0", VA = "0x1DFCDE0")]
	private void ShowNumJump(float progress)
	{
	}

	[Token(Token = "0x600EBE6")]
	[Address(RVA = "0x1DFCBC0", Offset = "0x1DFCBC0", VA = "0x1DFCBC0")]
	private void ShowSliderValueChange(float progress)
	{
	}

	[Token(Token = "0x600EBE7")]
	[Address(RVA = "0x1DFCD14", Offset = "0x1DFCD14", VA = "0x1DFCD14")]
	private void OnFootBallRadiusChange(float radius)
	{
	}

	[Token(Token = "0x600EBE8")]
	[Address(RVA = "0x1DFCF38", Offset = "0x1DFCF38", VA = "0x1DFCF38")]
	private void OnFootBallStatusChange(object[] data)
	{
	}

	[Token(Token = "0x600EBE9")]
	[Address(RVA = "0x1DFD070", Offset = "0x1DFD070", VA = "0x1DFD070")]
	private void OnHypeValueChange(object[] data)
	{
	}

	[Token(Token = "0x600EBEA")]
	[Address(RVA = "0x1DFD39C", Offset = "0x1DFD39C", VA = "0x1DFD39C")]
	private void OnMaxHypeValueChange(object[] data)
	{
	}

	[Token(Token = "0x600EBEB")]
	[Address(RVA = "0x1DFD46C", Offset = "0x1DFD46C", VA = "0x1DFD46C")]
	private void OnMaxHypeLevelChange(object[] data)
	{
	}

	[Token(Token = "0x600EBEC")]
	[Address(RVA = "0x1DFD548", Offset = "0x1DFD548", VA = "0x1DFD548")]
	private void UpdateBarItem()
	{
	}

	[Token(Token = "0x600EBED")]
	[Address(RVA = "0x1DFD1A4", Offset = "0x1DFD1A4", VA = "0x1DFD1A4")]
	private void RefreshHypeValueState()
	{
	}

	[Token(Token = "0x600EBEE")]
	[Address(RVA = "0x1DFC500", Offset = "0x1DFC500", VA = "0x1DFC500")]
	private void ResetLevelBlockStateAndSliderBgPos(ushort newLevel)
	{
	}

	[Token(Token = "0x600EBEF")]
	[Address(RVA = "0x1DFC200", Offset = "0x1DFC200", VA = "0x1DFC200")]
	protected void ShowMaxHypeLevelEffect(bool _needshow)
	{
	}

	[Token(Token = "0x600EBF0")]
	[Address(RVA = "0x1DFC328", Offset = "0x1DFC328", VA = "0x1DFC328")]
	private void ShowHypeLevelUpAnim()
	{
	}

	[Token(Token = "0x600EBF1")]
	[Address(RVA = "0x1DFD214", Offset = "0x1DFD214", VA = "0x1DFD214")]
	private void ShowHypeChangeEffect(bool isIncreasing)
	{
	}

	[Token(Token = "0x600EBF2")]
	[Address(RVA = "0x1DFDCA0", Offset = "0x1DFDCA0", VA = "0x1DFDCA0")]
	private void OnSwitchObserver(object[] data)
	{
	}

	[Token(Token = "0x600EBF3")]
	[Address(RVA = "0x1DFDD14", Offset = "0x1DFDD14", VA = "0x1DFDD14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EBF4")]
	[Address(RVA = "0x1DFDD1C", Offset = "0x1DFDD1C", VA = "0x1DFDD1C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
