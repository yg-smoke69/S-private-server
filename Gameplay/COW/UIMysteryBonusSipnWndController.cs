using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029D7")]
public class UIMysteryBonusSipnWndController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010140")]
	[FieldOffset(Offset = "0x48")]
	private UIMysteryBonusSpinWndView m_View;

	[Token(Token = "0x4010141")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelPayment m_ModelPayment;

	[Token(Token = "0x4010142")]
	[FieldOffset(Offset = "0x50")]
	private UIPopupWindowTopBtnController m_CloseBtn;

	[Token(Token = "0x4010143")]
	[FieldOffset(Offset = "0x54")]
	private UIMysteryBonusSpinWndAnimationConfig m_Config;

	[Token(Token = "0x4010144")]
	[FieldOffset(Offset = "0x58")]
	private Material m_Number_Tens;

	[Token(Token = "0x4010145")]
	[FieldOffset(Offset = "0x5C")]
	private Material m_Number_Ones;

	[Token(Token = "0x4010146")]
	[FieldOffset(Offset = "0x60")]
	private Material m_Number_Hunderds;

	[Token(Token = "0x4010147")]
	[FieldOffset(Offset = "0x64")]
	private bool m_Spined;

	[Token(Token = "0x4010148")]
	[FieldOffset(Offset = "0x68")]
	private float m_OnesScrollY;

	[Token(Token = "0x4010149")]
	[FieldOffset(Offset = "0x6C")]
	private float m_TensScrollY;

	[Token(Token = "0x401014A")]
	[FieldOffset(Offset = "0x70")]
	private float m_HunderdsScroll;

	[Token(Token = "0x401014B")]
	[FieldOffset(Offset = "0x74")]
	private float m_OnesScrollYDes;

	[Token(Token = "0x401014C")]
	[FieldOffset(Offset = "0x78")]
	private float m_TensScrollYDes;

	[Token(Token = "0x401014D")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_Percent;

	[Token(Token = "0x401014E")]
	[FieldOffset(Offset = "0x80")]
	private uint m_PercentTens;

	[Token(Token = "0x401014F")]
	[FieldOffset(Offset = "0x84")]
	private uint m_PercentOnes;

	[Token(Token = "0x4010150")]
	[FieldOffset(Offset = "0x88")]
	private uint m_PercentHunderds;

	[Token(Token = "0x4010151")]
	[FieldOffset(Offset = "0x8C")]
	private bool m_CalculatedOnesScrollY;

	[Token(Token = "0x4010152")]
	[FieldOffset(Offset = "0x8D")]
	private bool m_CalculatedTensScrollY;

	[Token(Token = "0x4010153")]
	[FieldOffset(Offset = "0x8E")]
	private bool m_ScrollEnd;

	[Token(Token = "0x4010154")]
	[FieldOffset(Offset = "0x90")]
	private AudioResource m_LoopAudioSource;

	[Token(Token = "0x6010D46")]
	[Address(RVA = "0x1954138", Offset = "0x1954138", VA = "0x1954138")]
	public UIMysteryBonusSipnWndController()
	{
	}

	[Token(Token = "0x6010D47")]
	[Address(RVA = "0x1954148", Offset = "0x1954148", VA = "0x1954148")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010D48")]
	[Address(RVA = "0x19541F0", Offset = "0x19541F0", VA = "0x19541F0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010D49")]
	[Address(RVA = "0x195486C", Offset = "0x195486C", VA = "0x195486C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010D4A")]
	[Address(RVA = "0x19549D4", Offset = "0x19549D4", VA = "0x19549D4")]
	private void OnStopBtnClick()
	{
	}

	[Token(Token = "0x6010D4B")]
	[Address(RVA = "0x1954A4C", Offset = "0x1954A4C", VA = "0x1954A4C")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x6010D4C")]
	[Address(RVA = "0x1954B90", Offset = "0x1954B90", VA = "0x1954B90")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6010D4D")]
	[Address(RVA = "0x1954EC4", Offset = "0x1954EC4", VA = "0x1954EC4")]
	private void Update()
	{
	}

	[Token(Token = "0x6010D4E")]
	[Address(RVA = "0x1954F24", Offset = "0x1954F24", VA = "0x1954F24")]
	private void AutoScrollNum()
	{
	}

	[Token(Token = "0x6010D4F")]
	[Address(RVA = "0x1955224", Offset = "0x1955224", VA = "0x1955224")]
	private void NormalScroll()
	{
	}

	[Token(Token = "0x6010D50")]
	[Address(RVA = "0x19553E8", Offset = "0x19553E8", VA = "0x19553E8")]
	private void ScrollOnes()
	{
	}

	[Token(Token = "0x6010D51")]
	[Address(RVA = "0x19555DC", Offset = "0x19555DC", VA = "0x19555DC")]
	private void ScrollTens()
	{
	}

	[Token(Token = "0x6010D52")]
	[Address(RVA = "0x195579C", Offset = "0x195579C", VA = "0x195579C")]
	private void ScrollHunderds()
	{
	}

	[Token(Token = "0x6010D53")]
	[Address(RVA = "0x19559F0", Offset = "0x19559F0", VA = "0x19559F0")]
	private void OnScrollEnd()
	{
	}

	[Token(Token = "0x6010D54")]
	[Address(RVA = "0x1955A50", Offset = "0x1955A50", VA = "0x1955A50")]
	private void StartScrollNumToDistination()
	{
	}

	[Token(Token = "0x6010D55")]
	[Address(RVA = "0x1955C7C", Offset = "0x1955C7C", VA = "0x1955C7C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010D56")]
	[Address(RVA = "0x1955DEC", Offset = "0x1955DEC", VA = "0x1955DEC", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010D57")]
	[Address(RVA = "0x1955E80", Offset = "0x1955E80", VA = "0x1955E80")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010D58")]
	[Address(RVA = "0x1955E88", Offset = "0x1955E88", VA = "0x1955E88")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
