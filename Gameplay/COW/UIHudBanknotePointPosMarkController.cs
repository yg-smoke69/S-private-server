using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026E3")]
public class UIHudBanknotePointPosMarkController : UIHudNameBaseController
{
	[Token(Token = "0x400F036")]
	[FieldOffset(Offset = "0x50")]
	private UIHudBanknotePointPosMarkView m_View;

	[Token(Token = "0x400F037")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_ControlPointPos;

	[Token(Token = "0x400F038")]
	[FieldOffset(Offset = "0x60")]
	private uint m_CurrentPointID;

	[Token(Token = "0x400F039")]
	[FieldOffset(Offset = "0x64")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x400F03A")]
	private const int NO_OCCUPY_COLOR = 2130706517;

	[Token(Token = "0x400F03B")]
	private const int LOCAL_OCCUPY_COLOR = 2131790519;

	[Token(Token = "0x400F03C")]
	private const int OPP_OCCUPY_COLOR = 2145343516;

	[Token(Token = "0x600EB9D")]
	[Address(RVA = "0x171CB88", Offset = "0x171CB88", VA = "0x171CB88")]
	public UIHudBanknotePointPosMarkController()
	{
	}

	[Token(Token = "0x600EB9E")]
	[Address(RVA = "0x171CC2C", Offset = "0x171CC2C", VA = "0x171CC2C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB9F")]
	[Address(RVA = "0x171CCD0", Offset = "0x171CCD0", VA = "0x171CCD0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EBA0")]
	[Address(RVA = "0x171D210", Offset = "0x171D210", VA = "0x171D210", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600EBA1")]
	[Address(RVA = "0x171D414", Offset = "0x171D414", VA = "0x171D414", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EBA2")]
	[Address(RVA = "0x171D538", Offset = "0x171D538", VA = "0x171D538", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600EBA3")]
	[Address(RVA = "0x171D590", Offset = "0x171D590", VA = "0x171D590", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600EBA4")]
	[Address(RVA = "0x171D73C", Offset = "0x171D73C", VA = "0x171D73C", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EBA5")]
	[Address(RVA = "0x171D794", Offset = "0x171D794", VA = "0x171D794")]
	private void OnOccupateTeamChange(object[] data)
	{
	}

	[Token(Token = "0x600EBA6")]
	[Address(RVA = "0x171DA84", Offset = "0x171DA84", VA = "0x171DA84")]
	private void OnRestAmountChange(object[] data)
	{
	}

	[Token(Token = "0x600EBA7")]
	[Address(RVA = "0x171DBC4", Offset = "0x171DBC4", VA = "0x171DBC4")]
	private void OnControlPointChange(object[] data)
	{
	}

	[Token(Token = "0x600EBA8")]
	[Address(RVA = "0x171D018", Offset = "0x171D018", VA = "0x171D018")]
	private void ClearHudShow()
	{
	}

	[Token(Token = "0x600EBA9")]
	[Address(RVA = "0x171DF50", Offset = "0x171DF50", VA = "0x171DF50")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EBAA")]
	[Address(RVA = "0x171DF58", Offset = "0x171DF58", VA = "0x171DF58")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600EBAB")]
	[Address(RVA = "0x171DF60", Offset = "0x171DF60", VA = "0x171DF60")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EBAC")]
	[Address(RVA = "0x171DF74", Offset = "0x171DF74", VA = "0x171DF74")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600EBAD")]
	[Address(RVA = "0x171DF7C", Offset = "0x171DF7C", VA = "0x171DF7C")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600EBAE")]
	[Address(RVA = "0x171DF90", Offset = "0x171DF90", VA = "0x171DF90")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}
}
