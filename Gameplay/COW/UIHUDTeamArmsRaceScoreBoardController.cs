using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200236B")]
internal class UIHUDTeamArmsRaceScoreBoardController : UIHUDTeamBattleScoreBoardController<UIHUDTeamBattleScoreBoardItemController>
{
	[Token(Token = "0x400DC83")]
	[FieldOffset(Offset = "0x44")]
	private int m_SelfArmLevel;

	[Token(Token = "0x400DC84")]
	[FieldOffset(Offset = "0x48")]
	private int m_OpponentArmLevel;

	[Token(Token = "0x600C5BE")]
	[Address(RVA = "0x2218144", Offset = "0x2218144", VA = "0x2218144")]
	public UIHUDTeamArmsRaceScoreBoardController()
	{
	}

	[Token(Token = "0x600C5BF")]
	[Address(RVA = "0x22181A8", Offset = "0x22181A8", VA = "0x22181A8")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C5C0")]
	[Address(RVA = "0x2218250", Offset = "0x2218250", VA = "0x2218250", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C5C1")]
	[Address(RVA = "0x22182FC", Offset = "0x22182FC", VA = "0x22182FC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600C5C2")]
	[Address(RVA = "0x2218360", Offset = "0x2218360", VA = "0x2218360", Slot = "33")]
	public override void RegisterUIEvent()
	{
	}

	[Token(Token = "0x600C5C3")]
	[Address(RVA = "0x2218710", Offset = "0x2218710", VA = "0x2218710", Slot = "34")]
	public override void UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600C5C4")]
	[Address(RVA = "0x2218AC0", Offset = "0x2218AC0", VA = "0x2218AC0", Slot = "32")]
	protected override ResourceID GetTitileResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C5C5")]
	[Address(RVA = "0x2218B70", Offset = "0x2218B70", VA = "0x2218B70")]
	private void OnGameArmsListCome(object[] param)
	{
	}

	[Token(Token = "0x600C5C6")]
	[Address(RVA = "0x2218E64", Offset = "0x2218E64", VA = "0x2218E64")]
	private void OnSelfArmLevelCome(object[] param)
	{
	}

	[Token(Token = "0x600C5C7")]
	[Address(RVA = "0x2218F60", Offset = "0x2218F60", VA = "0x2218F60")]
	private void OnOpponentArmLevelCome(object[] param)
	{
	}

	[Token(Token = "0x600C5C8")]
	[Address(RVA = "0x2218C5C", Offset = "0x2218C5C", VA = "0x2218C5C")]
	private void UpdateLeftWeaponIcon()
	{
	}

	[Token(Token = "0x600C5C9")]
	[Address(RVA = "0x2218D60", Offset = "0x2218D60", VA = "0x2218D60")]
	private void UpdateRightWeaponIcon()
	{
	}

	[Token(Token = "0x600C5CA")]
	[Address(RVA = "0x221905C", Offset = "0x221905C", VA = "0x221905C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C5CB")]
	[Address(RVA = "0x2219060", Offset = "0x2219060", VA = "0x2219060")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600C5CC")]
	[Address(RVA = "0x2219068", Offset = "0x2219068", VA = "0x2219068")]
	public void _003C_003EiFixBaseProxy_RegisterUIEvent()
	{
	}

	[Token(Token = "0x600C5CD")]
	[Address(RVA = "0x221906C", Offset = "0x221906C", VA = "0x221906C")]
	public void _003C_003EiFixBaseProxy_UnRegisterUIEvent()
	{
	}

	[Token(Token = "0x600C5CE")]
	[Address(RVA = "0x2219070", Offset = "0x2219070", VA = "0x2219070")]
	public ResourceID _003C_003EiFixBaseProxy_GetTitileResourceID()
	{
		return default(ResourceID);
	}
}
