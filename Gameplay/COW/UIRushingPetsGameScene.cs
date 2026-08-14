using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x200332E")]
internal class UIRushingPetsGameScene : UIInGameScene
{
	[Token(Token = "0x4013810")]
	[FieldOffset(Offset = "0x2C8")]
	protected JCBFLBIIDCJ m_CurPhaseType;

	[Token(Token = "0x4013811")]
	[FieldOffset(Offset = "0x2CC")]
	protected UIHUDRushingPetsLevelEndShowController m_CurLevelEndShowCtrl;

	[Token(Token = "0x4013812")]
	[FieldOffset(Offset = "0x2D0")]
	protected UIHudSpeedupAreaController m_RushingSpeedUI;

	[Token(Token = "0x4013813")]
	[FieldOffset(Offset = "0x2D4")]
	protected UIHUDRushingPetsJumpController m_RushingJumpUI;

	[Token(Token = "0x4013814")]
	[FieldOffset(Offset = "0x2D8")]
	protected UIHudMovingJoystickController m_RushingPetsMoveUI;

	[Token(Token = "0x6015B36")]
	[Address(RVA = "0x14323C8", Offset = "0x14323C8", VA = "0x14323C8")]
	public UIRushingPetsGameScene()
	{
	}

	[Token(Token = "0x6015B37")]
	[Address(RVA = "0x143244C", Offset = "0x143244C", VA = "0x143244C", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B38")]
	[Address(RVA = "0x1432658", Offset = "0x1432658", VA = "0x1432658", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015B39")]
	[Address(RVA = "0x1432864", Offset = "0x1432864", VA = "0x1432864", Slot = "17")]
	public override void OpenHud()
	{
	}

	[Token(Token = "0x6015B3A")]
	[Address(RVA = "0x14329E0", Offset = "0x14329E0", VA = "0x14329E0", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B3B")]
	[Address(RVA = "0x1432D4C", Offset = "0x1432D4C", VA = "0x1432D4C", Slot = "29")]
	protected override bool IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015B3C")]
	[Address(RVA = "0x1432DA4", Offset = "0x1432DA4", VA = "0x1432DA4", Slot = "44")]
	public override ResourceID GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015B3D")]
	[Address(RVA = "0x1432E54", Offset = "0x1432E54", VA = "0x1432E54", Slot = "47")]
	public virtual void OpenSpeedUpHUD()
	{
	}

	[Token(Token = "0x6015B3E")]
	[Address(RVA = "0x1432FD4", Offset = "0x1432FD4", VA = "0x1432FD4", Slot = "48")]
	public virtual void OpenJumpBtn()
	{
	}

	[Token(Token = "0x6015B3F")]
	[Address(RVA = "0x1432C3C", Offset = "0x1432C3C", VA = "0x1432C3C")]
	protected void OpenCountDownTip()
	{
	}

	[Token(Token = "0x6015B40")]
	[Address(RVA = "0x14330E0", Offset = "0x14330E0", VA = "0x14330E0", Slot = "49")]
	public virtual void OpenMatchResult()
	{
	}

	[Token(Token = "0x6015B41")]
	[Address(RVA = "0x1433278", Offset = "0x1433278", VA = "0x1433278", Slot = "50")]
	public virtual void OpenLevelEndShowUI(LLAHOLGIFFE msg)
	{
	}

	[Token(Token = "0x6015B42")]
	[Address(RVA = "0x1433670", Offset = "0x1433670", VA = "0x1433670", Slot = "51")]
	protected virtual void OpenMatchInfo()
	{
	}

	[Token(Token = "0x6015B43")]
	[Address(RVA = "0x1433780", Offset = "0x1433780", VA = "0x1433780", Slot = "52")]
	protected virtual void OpenMoveJoyStick()
	{
	}

	[Token(Token = "0x6015B44")]
	[Address(RVA = "0x1433434", Offset = "0x1433434", VA = "0x1433434")]
	protected void ShowMovementUI(bool isShow)
	{
	}

	[Token(Token = "0x6015B45")]
	[Address(RVA = "0x143388C", Offset = "0x143388C", VA = "0x143388C", Slot = "53")]
	protected virtual void OnNewPhase(object[] data)
	{
	}

	[Token(Token = "0x6015B46")]
	[Address(RVA = "0x1433C40", Offset = "0x1433C40", VA = "0x1433C40")]
	protected void OnPhaseEndTimeCome(object[] data)
	{
	}

	[Token(Token = "0x6015B47")]
	[Address(RVA = "0x1433CB0", Offset = "0x1433CB0", VA = "0x1433CB0", Slot = "54")]
	protected virtual void OpenIntroInfo()
	{
	}

	[Token(Token = "0x6015B48")]
	[Address(RVA = "0x1433DF8", Offset = "0x1433DF8", VA = "0x1433DF8")]
	public void OnIntroInfoDone(object[] data)
	{
	}

	[Token(Token = "0x6015B49")]
	[Address(RVA = "0x1433E74", Offset = "0x1433E74", VA = "0x1433E74", Slot = "22")]
	protected override void OnHudSettingChanged(object[] param)
	{
	}

	[Token(Token = "0x6015B4A")]
	[Address(RVA = "0x1433ED0", Offset = "0x1433ED0", VA = "0x1433ED0")]
	private void _003COpenIntroInfo_003Em__0()
	{
	}

	[Token(Token = "0x6015B4B")]
	[Address(RVA = "0x1434034", Offset = "0x1434034", VA = "0x1434034")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015B4C")]
	[Address(RVA = "0x143403C", Offset = "0x143403C", VA = "0x143403C")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015B4D")]
	[Address(RVA = "0x1434044", Offset = "0x1434044", VA = "0x1434044")]
	public void _003C_003EiFixBaseProxy_OpenHud()
	{
	}

	[Token(Token = "0x6015B4E")]
	[Address(RVA = "0x143404C", Offset = "0x143404C", VA = "0x143404C")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B4F")]
	[Address(RVA = "0x1434054", Offset = "0x1434054", VA = "0x1434054")]
	public bool _003C_003EiFixBaseProxy_IsNeedDirectionRuler()
	{
		return default(bool);
	}

	[Token(Token = "0x6015B50")]
	[Address(RVA = "0x143405C", Offset = "0x143405C", VA = "0x143405C")]
	public ResourceID _003C_003EiFixBaseProxy_GetIntroInfoUIResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015B51")]
	[Address(RVA = "0x1434064", Offset = "0x1434064", VA = "0x1434064")]
	public void _003C_003EiFixBaseProxy_OnHudSettingChanged(object[] P0)
	{
	}
}
