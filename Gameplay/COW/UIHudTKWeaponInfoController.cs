using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002882")]
internal class UIHudTKWeaponInfoController : UIBaseController
{
	[Token(Token = "0x400F989")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTKWeaponInfoView m_View;

	[Token(Token = "0x400F98A")]
	[FieldOffset(Offset = "0x2C")]
	private GPBDEDFKJNA m_LastWeaponInHand;

	[Token(Token = "0x400F98B")]
	[FieldOffset(Offset = "0x30")]
	private bool m_weaponChanged;

	[Token(Token = "0x400F98C")]
	[FieldOffset(Offset = "0x34")]
	private StringBuilder m_Sb;

	[Token(Token = "0x400F98D")]
	[FieldOffset(Offset = "0x38")]
	private int m_GenStartTime;

	[Token(Token = "0x400F98E")]
	[FieldOffset(Offset = "0x3C")]
	private int m_GenEndTime;

	[Token(Token = "0x600FE07")]
	[Address(RVA = "0x1FFA590", Offset = "0x1FFA590", VA = "0x1FFA590")]
	public UIHudTKWeaponInfoController()
	{
	}

	[Token(Token = "0x600FE08")]
	[Address(RVA = "0x1FFA614", Offset = "0x1FFA614", VA = "0x1FFA614")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FE09")]
	[Address(RVA = "0x1FFA6B8", Offset = "0x1FFA6B8", VA = "0x1FFA6B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FE0A")]
	[Address(RVA = "0x1FFAB58", Offset = "0x1FFAB58", VA = "0x1FFAB58", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FE0B")]
	[Address(RVA = "0x1FFAE2C", Offset = "0x1FFAE2C", VA = "0x1FFAE2C")]
	private void Update()
	{
	}

	[Token(Token = "0x600FE0C")]
	[Address(RVA = "0x1FFBA94", Offset = "0x1FFBA94", VA = "0x1FFBA94")]
	private void OnLastWeaponInit(object[] param)
	{
	}

	[Token(Token = "0x600FE0D")]
	[Address(RVA = "0x1FFBC14", Offset = "0x1FFBC14", VA = "0x1FFBC14")]
	private void OnInventoryItemChanged(object[] param)
	{
	}

	[Token(Token = "0x600FE0E")]
	[Address(RVA = "0x1FFBD30", Offset = "0x1FFBD30", VA = "0x1FFBD30")]
	private void OnThrowKnifePhaseChanged(object[] param)
	{
	}

	[Token(Token = "0x600FE0F")]
	[Address(RVA = "0x1FFB634", Offset = "0x1FFB634", VA = "0x1FFB634")]
	private void SetProgressBarAndCntUI(bool equipThrowKnife, int cnt)
	{
	}

	[Token(Token = "0x600FE10")]
	[Address(RVA = "0x1FFBE24", Offset = "0x1FFBE24", VA = "0x1FFBE24")]
	private void OnShowKnifeAutoGenTutorial(object[] data)
	{
	}

	[Token(Token = "0x600FE11")]
	[Address(RVA = "0x1FFC0D8", Offset = "0x1FFC0D8", VA = "0x1FFC0D8")]
	private void OnObserverInfoListVisibleChanged(object[] data)
	{
	}

	[Token(Token = "0x600FE12")]
	[Address(RVA = "0x1FFC1E4", Offset = "0x1FFC1E4", VA = "0x1FFC1E4")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600FE13")]
	[Address(RVA = "0x1FFC2A8", Offset = "0x1FFC2A8", VA = "0x1FFC2A8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FE14")]
	[Address(RVA = "0x1FFC2B0", Offset = "0x1FFC2B0", VA = "0x1FFC2B0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
