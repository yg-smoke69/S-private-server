using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FA7")]
public class UIHUDArmsRaceTeamMatchInfoController : UIBaseController
{
	[Token(Token = "0x400C682")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDArmsRaceTeamMatchInfoView m_View;

	[Token(Token = "0x400C683")]
	[FieldOffset(Offset = "0x2C")]
	private int m_SelfArmLevel;

	[Token(Token = "0x400C684")]
	[FieldOffset(Offset = "0x30")]
	private int m_OpponentArmLevel;

	[Token(Token = "0x400C685")]
	[FieldOffset(Offset = "0x34")]
	private uint m_GameEndTimeMS;

	[Token(Token = "0x400C686")]
	[FieldOffset(Offset = "0x38")]
	private uint mSeconds;

	[Token(Token = "0x400C687")]
	[FieldOffset(Offset = "0x3C")]
	private StringBuilder m_Timer;

	[Token(Token = "0x6009DCD")]
	[Address(RVA = "0x16710FC", Offset = "0x16710FC", VA = "0x16710FC")]
	public UIHUDArmsRaceTeamMatchInfoController()
	{
	}

	[Token(Token = "0x6009DCE")]
	[Address(RVA = "0x1671180", Offset = "0x1671180", VA = "0x1671180")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009DCF")]
	[Address(RVA = "0x1671228", Offset = "0x1671228", VA = "0x1671228", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009DD0")]
	[Address(RVA = "0x16715B8", Offset = "0x16715B8", VA = "0x16715B8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009DD1")]
	[Address(RVA = "0x16718C4", Offset = "0x16718C4", VA = "0x16718C4")]
	private void OnGameArmsListCome(object[] param)
	{
	}

	[Token(Token = "0x6009DD2")]
	[Address(RVA = "0x1671F5C", Offset = "0x1671F5C", VA = "0x1671F5C")]
	private void UpdateMaxLevel()
	{
	}

	[Token(Token = "0x6009DD3")]
	[Address(RVA = "0x167222C", Offset = "0x167222C", VA = "0x167222C")]
	private void OnBattleTimeCome(object[] parma)
	{
	}

	[Token(Token = "0x6009DD4")]
	[Address(RVA = "0x167230C", Offset = "0x167230C", VA = "0x167230C")]
	private void OnSelfArmLevelCome(object[] param)
	{
	}

	[Token(Token = "0x6009DD5")]
	[Address(RVA = "0x16723EC", Offset = "0x16723EC", VA = "0x16723EC")]
	private void OnOpponentArmLevelCome(object[] param)
	{
	}

	[Token(Token = "0x6009DD6")]
	[Address(RVA = "0x167193C", Offset = "0x167193C", VA = "0x167193C")]
	private void UpdateSelfArmInfo()
	{
	}

	[Token(Token = "0x6009DD7")]
	[Address(RVA = "0x1671C4C", Offset = "0x1671C4C", VA = "0x1671C4C")]
	private void UpdateOpponentArmInfo()
	{
	}

	[Token(Token = "0x6009DD8")]
	[Address(RVA = "0x16724CC", Offset = "0x16724CC", VA = "0x16724CC")]
	private void SetWeaponIcon(uint weaponID, UISprite uiSprite)
	{
	}

	[Token(Token = "0x6009DD9")]
	[Address(RVA = "0x1672680", Offset = "0x1672680", VA = "0x1672680")]
	private void Update()
	{
	}

	[Token(Token = "0x6009DDA")]
	[Address(RVA = "0x1672958", Offset = "0x1672958", VA = "0x1672958")]
	private void OpenScoreBoard()
	{
	}

	[Token(Token = "0x6009DDB")]
	[Address(RVA = "0x1672A88", Offset = "0x1672A88", VA = "0x1672A88")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009DDC")]
	[Address(RVA = "0x1672A90", Offset = "0x1672A90", VA = "0x1672A90")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
