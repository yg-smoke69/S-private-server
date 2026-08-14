using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EBC")]
public class UIDigitaluniverseBCoreInfoPanelController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C171")]
	[FieldOffset(Offset = "0x48")]
	private UIDigitaluniverseBCoreInfoPanelView m_View;

	[Token(Token = "0x400C172")]
	private const float m_HeightSpace = 40f;

	[Token(Token = "0x400C173")]
	[FieldOffset(Offset = "0x4C")]
	private UIRoot m_UIRoot;

	[Token(Token = "0x400C174")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_Pos;

	[Token(Token = "0x400C175")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_IsMyFriend;

	[Token(Token = "0x400C176")]
	[FieldOffset(Offset = "0x60")]
	private CoreNode m_CoreNode;

	[Token(Token = "0x400C177")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsInLightenCD;

	[Token(Token = "0x400C178")]
	[FieldOffset(Offset = "0x65")]
	private bool m_IsOutAssitTimesLimit;

	[Token(Token = "0x400C179")]
	[FieldOffset(Offset = "0x68")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400C17A")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_VoteTimes;

	[Token(Token = "0x400C17B")]
	[FieldOffset(Offset = "0x70")]
	private UIModelDigitaluniverseB m_DigitaluniverseBModel;

	[Token(Token = "0x6009536")]
	[Address(RVA = "0x2ADC568", Offset = "0x2ADC568", VA = "0x2ADC568")]
	public UIDigitaluniverseBCoreInfoPanelController()
	{
	}

	[Token(Token = "0x6009537")]
	[Address(RVA = "0x2ADC570", Offset = "0x2ADC570", VA = "0x2ADC570")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009538")]
	[Address(RVA = "0x2ADC618", Offset = "0x2ADC618", VA = "0x2ADC618", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009539")]
	[Address(RVA = "0x2ADCB90", Offset = "0x2ADCB90", VA = "0x2ADCB90", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600953A")]
	[Address(RVA = "0x2ADCC10", Offset = "0x2ADCC10", VA = "0x2ADCC10", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x600953B")]
	[Address(RVA = "0x2ADA928", Offset = "0x2ADA928", VA = "0x2ADA928")]
	public void SetViewData(Vector3 pos, CoreNode coreNode)
	{
	}

	[Token(Token = "0x600953C")]
	[Address(RVA = "0x2ADCC68", Offset = "0x2ADCC68", VA = "0x2ADCC68")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600953D")]
	[Address(RVA = "0x2ADD5B4", Offset = "0x2ADD5B4", VA = "0x2ADD5B4")]
	public void UpdateView([Optional] object info)
	{
	}

	[Token(Token = "0x600953E")]
	[Address(RVA = "0x2ADD950", Offset = "0x2ADD950", VA = "0x2ADD950")]
	private void RefreshVoteView()
	{
	}

	[Token(Token = "0x600953F")]
	[Address(RVA = "0x2ADDCE8", Offset = "0x2ADDCE8", VA = "0x2ADDCE8")]
	private void RefreshAssistState()
	{
	}

	[Token(Token = "0x6009540")]
	[Address(RVA = "0x2ADDEB8", Offset = "0x2ADDEB8", VA = "0x2ADDEB8")]
	private void RefreshCountDown()
	{
	}

	[Token(Token = "0x6009541")]
	[Address(RVA = "0x2ADE0E8", Offset = "0x2ADE0E8", VA = "0x2ADE0E8")]
	private void CountDownFinish()
	{
	}

	[Token(Token = "0x6009542")]
	[Address(RVA = "0x2ADE148", Offset = "0x2ADE148", VA = "0x2ADE148")]
	private void OnAssistClick()
	{
	}

	[Token(Token = "0x6009543")]
	[Address(RVA = "0x2ADE530", Offset = "0x2ADE530", VA = "0x2ADE530")]
	private void OnThumbClick()
	{
	}

	[Token(Token = "0x6009544")]
	[Address(RVA = "0x2ADE8D0", Offset = "0x2ADE8D0", VA = "0x2ADE8D0")]
	private void OnAddPlayerClick()
	{
	}

	[Token(Token = "0x6009545")]
	[Address(RVA = "0x2ADEAD0", Offset = "0x2ADEAD0", VA = "0x2ADEAD0")]
	private void OnMaskBtnClick()
	{
	}

	[Token(Token = "0x6009546")]
	[Address(RVA = "0x2ADD1F8", Offset = "0x2ADD1F8", VA = "0x2ADD1F8")]
	private void SetPosition(Vector3 itemPos)
	{
	}

	[Token(Token = "0x6009547")]
	[Address(RVA = "0x2ADEC8C", Offset = "0x2ADEC8C", VA = "0x2ADEC8C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009548")]
	[Address(RVA = "0x2ADEE14", Offset = "0x2ADEE14", VA = "0x2ADEE14", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009549")]
	[Address(RVA = "0x2ADEEAC", Offset = "0x2ADEEAC", VA = "0x2ADEEAC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600954A")]
	[Address(RVA = "0x2ADEEB4", Offset = "0x2ADEEB4", VA = "0x2ADEEB4")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x600954B")]
	[Address(RVA = "0x2ADEEBC", Offset = "0x2ADEEBC", VA = "0x2ADEEBC")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
