using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C3C")]
internal class UIHudTaskNameIconController : UIHudNameBaseController
{
	[Token(Token = "0x4010DE9")]
	[FieldOffset(Offset = "0x50")]
	private UIHudTaskNameIconView m_View;

	[Token(Token = "0x4010DEA")]
	[FieldOffset(Offset = "0x54")]
	private LevelTaskZone bindedLevelObject;

	[Token(Token = "0x4010DEB")]
	[FieldOffset(Offset = "0x58")]
	private bool m_onlyEmergency;

	[Token(Token = "0x4010DEC")]
	[FieldOffset(Offset = "0x59")]
	private bool m_isEmergency;

	[Token(Token = "0x4010DED")]
	[FieldOffset(Offset = "0x5C")]
	private TutorialEventEnum m_CurTutType;

	[Token(Token = "0x17001328")]
	public LevelTaskZone BindedLevelObject
	{
		[Token(Token = "0x60126FB")]
		[Address(RVA = "0x1791550", Offset = "0x1791550", VA = "0x1791550")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001329")]
	public bool IsEmergency
	{
		[Token(Token = "0x60126FC")]
		[Address(RVA = "0x17915A8", Offset = "0x17915A8", VA = "0x17915A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700132A")]
	private bool IsInTutorial
	{
		[Token(Token = "0x6012708")]
		[Address(RVA = "0x1791AC4", Offset = "0x1791AC4", VA = "0x1791AC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60126FA")]
	[Address(RVA = "0x1791548", Offset = "0x1791548", VA = "0x1791548")]
	public UIHudTaskNameIconController()
	{
	}

	[Token(Token = "0x60126FD")]
	[Address(RVA = "0x1791600", Offset = "0x1791600", VA = "0x1791600")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60126FE")]
	[Address(RVA = "0x17916A8", Offset = "0x17916A8", VA = "0x17916A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60126FF")]
	[Address(RVA = "0x1791800", Offset = "0x1791800", VA = "0x1791800", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012700")]
	[Address(RVA = "0x1791934", Offset = "0x1791934", VA = "0x1791934")]
	public void BindLevelObject(LevelTaskZone obj)
	{
	}

	[Token(Token = "0x6012701")]
	[Address(RVA = "0x1791994", Offset = "0x1791994", VA = "0x1791994")]
	public void ClearBind()
	{
	}

	[Token(Token = "0x6012702")]
	[Address(RVA = "0x1791C38", Offset = "0x1791C38", VA = "0x1791C38", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6012703")]
	[Address(RVA = "0x1791D8C", Offset = "0x1791D8C", VA = "0x1791D8C", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x6012704")]
	[Address(RVA = "0x1791DE4", Offset = "0x1791DE4", VA = "0x1791DE4")]
	public void SetEmergency(bool isEmergency)
	{
	}

	[Token(Token = "0x6012705")]
	[Address(RVA = "0x1791E50", Offset = "0x1791E50", VA = "0x1791E50")]
	private void RefreshIconVisibility()
	{
	}

	[Token(Token = "0x6012706")]
	[Address(RVA = "0x1791FB4", Offset = "0x1791FB4", VA = "0x1791FB4")]
	private void OnRefreshIcon(object[] data)
	{
	}

	[Token(Token = "0x6012707")]
	[Address(RVA = "0x17920A4", Offset = "0x17920A4", VA = "0x17920A4", Slot = "41")]
	protected override void UpdateNamePosition()
	{
	}

	[Token(Token = "0x6012709")]
	[Address(RVA = "0x1792234", Offset = "0x1792234", VA = "0x1792234")]
	public void ShowTutorial(bool isWolf)
	{
	}

	[Token(Token = "0x601270A")]
	[Address(RVA = "0x17923F0", Offset = "0x17923F0", VA = "0x17923F0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601270B")]
	[Address(RVA = "0x17923F8", Offset = "0x17923F8", VA = "0x17923F8")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x601270C")]
	[Address(RVA = "0x1792400", Offset = "0x1792400", VA = "0x1792400")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601270D")]
	[Address(RVA = "0x1792414", Offset = "0x1792414", VA = "0x1792414")]
	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x601270E")]
	[Address(RVA = "0x179241C", Offset = "0x179241C", VA = "0x179241C")]
	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}
}
