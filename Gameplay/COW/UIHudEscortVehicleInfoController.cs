using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002745")]
internal class UIHudEscortVehicleInfoController : UIBaseController
{
	[Token(Token = "0x400F24E")]
	[FieldOffset(Offset = "0x28")]
	private UIHudEscortVehicleInfoView m_View;

	[Token(Token = "0x400F24F")]
	[FieldOffset(Offset = "0x2C")]
	private POECKIDCBKC mGame;

	[Token(Token = "0x400F250")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Color HP_COLOR_YELLOW;

	[Token(Token = "0x400F251")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Color HP_COLOR_GREEN;

	[Token(Token = "0x400F252")]
	[FieldOffset(Offset = "0x20")]
	private static readonly Color HP_COLOR_RED;

	[Token(Token = "0x400F253")]
	[FieldOffset(Offset = "0x30")]
	private UIGuideTipsController m_GuideTipsCtrl;

	[Token(Token = "0x400F254")]
	[FieldOffset(Offset = "0x34")]
	private UIHudCommonlTipsController m_CurrentTips;

	[Token(Token = "0x600EF89")]
	[Address(RVA = "0x1B95734", Offset = "0x1B95734", VA = "0x1B95734")]
	public UIHudEscortVehicleInfoController()
	{
	}

	[Token(Token = "0x600EF8A")]
	[Address(RVA = "0x1B957B8", Offset = "0x1B957B8", VA = "0x1B957B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF8B")]
	[Address(RVA = "0x1B95860", Offset = "0x1B95860", VA = "0x1B95860", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF8C")]
	[Address(RVA = "0x1B964A8", Offset = "0x1B964A8", VA = "0x1B964A8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EF8D")]
	[Address(RVA = "0x1B966AC", Offset = "0x1B966AC", VA = "0x1B966AC")]
	private void OnBtnBodyTipClick()
	{
	}

	[Token(Token = "0x600EF8E")]
	[Address(RVA = "0x1B968A8", Offset = "0x1B968A8", VA = "0x1B968A8")]
	private void OnBtnWheelTipClick()
	{
	}

	[Token(Token = "0x600EF8F")]
	[Address(RVA = "0x1B96AA4", Offset = "0x1B96AA4", VA = "0x1B96AA4")]
	private void OnBtnStatusTipClick()
	{
	}

	[Token(Token = "0x600EF90")]
	[Address(RVA = "0x1B96CA0", Offset = "0x1B96CA0", VA = "0x1B96CA0")]
	private void OnWheelHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600EF91")]
	[Address(RVA = "0x1B96D08", Offset = "0x1B96D08", VA = "0x1B96D08")]
	private void OnBodyHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600EF92")]
	[Address(RVA = "0x1B96D70", Offset = "0x1B96D70", VA = "0x1B96D70")]
	private void OnStatusChanged(object[] data)
	{
	}

	[Token(Token = "0x600EF93")]
	[Address(RVA = "0x1B95C84", Offset = "0x1B95C84", VA = "0x1B95C84")]
	private void UpdateWheelHPUI()
	{
	}

	[Token(Token = "0x600EF94")]
	[Address(RVA = "0x1B95E68", Offset = "0x1B95E68", VA = "0x1B95E68")]
	private void UpdateBodyHPUI()
	{
	}

	[Token(Token = "0x600EF95")]
	[Address(RVA = "0x1B9604C", Offset = "0x1B9604C", VA = "0x1B9604C")]
	private void UpdateStatusUI()
	{
	}

	[Token(Token = "0x600EF97")]
	[Address(RVA = "0x1B96EB8", Offset = "0x1B96EB8", VA = "0x1B96EB8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EF98")]
	[Address(RVA = "0x1B96EC0", Offset = "0x1B96EC0", VA = "0x1B96EC0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
