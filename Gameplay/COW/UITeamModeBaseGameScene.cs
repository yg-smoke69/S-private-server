using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003334")]
internal class UITeamModeBaseGameScene : UIInGameScene
{
	[Token(Token = "0x4013835")]
	[FieldOffset(Offset = "0x2C8")]
	private UIHudGameShowInfoController m_ShowInfoCtrl;

	[Token(Token = "0x4013836")]
	[FieldOffset(Offset = "0x2CC")]
	protected UIHudTDMLikeShopController m_TDMLikeShopController;

	[Token(Token = "0x4013837")]
	[FieldOffset(Offset = "0x2D0")]
	protected UIHudCSShopEntryController m_TDMShopEntryCtrl;

	[Token(Token = "0x4013838")]
	[FieldOffset(Offset = "0x2D4")]
	protected UIHudTDMLikeShopEntryController m_TDMLikeShopEntryCtrl;

	[Token(Token = "0x6015B9D")]
	[Address(RVA = "0x2014C60", Offset = "0x2014C60", VA = "0x2014C60")]
	public UITeamModeBaseGameScene()
	{
	}

	[Token(Token = "0x6015B9E")]
	[Address(RVA = "0x20199D0", Offset = "0x20199D0", VA = "0x20199D0", Slot = "18")]
	protected override void OpenCommonHud()
	{
	}

	[Token(Token = "0x6015B9F")]
	[Address(RVA = "0x2015998", Offset = "0x2015998", VA = "0x2015998", Slot = "38")]
	protected override void OnOpenHudInPregame()
	{
	}

	[Token(Token = "0x6015BA0")]
	[Address(RVA = "0x2014EA0", Offset = "0x2014EA0", VA = "0x2014EA0", Slot = "15")]
	public override void RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015BA1")]
	[Address(RVA = "0x20152AC", Offset = "0x20152AC", VA = "0x20152AC", Slot = "12")]
	protected override void OnDestory()
	{
	}

	[Token(Token = "0x6015BA2")]
	[Address(RVA = "0x2019D2C", Offset = "0x2019D2C", VA = "0x2019D2C")]
	public void OnRefreshTDMLikeShop(object[] data)
	{
	}

	[Token(Token = "0x6015BA3")]
	[Address(RVA = "0x201A36C", Offset = "0x201A36C", VA = "0x201A36C")]
	public void OnTDMLikeShopVisibilityChange(object[] data)
	{
	}

	[Token(Token = "0x6015BA4")]
	[Address(RVA = "0x201A60C", Offset = "0x201A60C", VA = "0x201A60C")]
	public bool IsBombLikeShopIsShowing()
	{
		return default(bool);
	}

	[Token(Token = "0x6015BA5")]
	[Address(RVA = "0x201A714", Offset = "0x201A714", VA = "0x201A714")]
	private void OnShowMatchInfo(object[] param)
	{
	}

	[Token(Token = "0x6015BA6")]
	[Address(RVA = "0x201A9F0", Offset = "0x201A9F0", VA = "0x201A9F0", Slot = "47")]
	protected virtual void ShowTeamScore(object[] data)
	{
	}

	[Token(Token = "0x6015BA7")]
	[Address(RVA = "0x201AA4C", Offset = "0x201AA4C", VA = "0x201AA4C")]
	protected void OnLocalPlayerRevive(object[] data)
	{
	}

	[Token(Token = "0x6015BA8")]
	[Address(RVA = "0x201ACC4", Offset = "0x201ACC4", VA = "0x201ACC4", Slot = "48")]
	protected virtual bool CanAutoPopShop()
	{
		return default(bool);
	}

	[Token(Token = "0x6015BA9")]
	[Address(RVA = "0x201AD1C", Offset = "0x201AD1C", VA = "0x201AD1C")]
	private void _003COnOpenHudInPregame_003Em__0()
	{
	}

	[Token(Token = "0x6015BAA")]
	[Address(RVA = "0x201ADE0", Offset = "0x201ADE0", VA = "0x201ADE0")]
	public void _003C_003EiFixBaseProxy_OpenCommonHud()
	{
	}

	[Token(Token = "0x6015BAB")]
	[Address(RVA = "0x201ADE8", Offset = "0x201ADE8", VA = "0x201ADE8")]
	public void _003C_003EiFixBaseProxy_RegisterGameEventHandler()
	{
	}

	[Token(Token = "0x6015BAC")]
	[Address(RVA = "0x201ADF0", Offset = "0x201ADF0", VA = "0x201ADF0")]
	public new void _003C_003EiFixBaseProxy_OnDestory()
	{
	}

	[Token(Token = "0x6015BAD")]
	[Address(RVA = "0x201ADF8", Offset = "0x201ADF8", VA = "0x201ADF8")]
	public void _003C_003EiFixBaseProxy_OnOpenHudInPregame()
	{
	}
}
