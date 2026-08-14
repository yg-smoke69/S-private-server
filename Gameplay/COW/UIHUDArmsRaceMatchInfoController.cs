using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FA2")]
public class UIHUDArmsRaceMatchInfoController : UIBaseController
{
	[Token(Token = "0x400C66F")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDArmsRaceMatchInfoView m_View;

	[Token(Token = "0x400C670")]
	[FieldOffset(Offset = "0x2C")]
	private int m_SelfRank;

	[Token(Token = "0x400C671")]
	[FieldOffset(Offset = "0x30")]
	private int m_SelfArmLevel;

	[Token(Token = "0x400C672")]
	[FieldOffset(Offset = "0x34")]
	private int m_TopArmLevel;

	[Token(Token = "0x400C673")]
	[FieldOffset(Offset = "0x38")]
	private uint m_GameEndTimeMS;

	[Token(Token = "0x400C674")]
	[FieldOffset(Offset = "0x3C")]
	private uint mSeconds;

	[Token(Token = "0x400C675")]
	[FieldOffset(Offset = "0x40")]
	private StringBuilder m_Timer;

	[Token(Token = "0x6009D9B")]
	[Address(RVA = "0x166E878", Offset = "0x166E878", VA = "0x166E878")]
	public UIHUDArmsRaceMatchInfoController()
	{
	}

	[Token(Token = "0x6009D9C")]
	[Address(RVA = "0x166E904", Offset = "0x166E904", VA = "0x166E904")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009D9D")]
	[Address(RVA = "0x166E9AC", Offset = "0x166E9AC", VA = "0x166E9AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009D9E")]
	[Address(RVA = "0x166ED04", Offset = "0x166ED04", VA = "0x166ED04", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009D9F")]
	[Address(RVA = "0x166EFD8", Offset = "0x166EFD8", VA = "0x166EFD8")]
	private void OnGameArmsListCome(object[] param)
	{
	}

	[Token(Token = "0x6009DA0")]
	[Address(RVA = "0x166FB5C", Offset = "0x166FB5C", VA = "0x166FB5C")]
	private void OnBattleTimeCome(object[] parma)
	{
	}

	[Token(Token = "0x6009DA1")]
	[Address(RVA = "0x166FC3C", Offset = "0x166FC3C", VA = "0x166FC3C")]
	private void OnSelfArmLevelCome(object[] param)
	{
	}

	[Token(Token = "0x6009DA2")]
	[Address(RVA = "0x166FD1C", Offset = "0x166FD1C", VA = "0x166FD1C")]
	private void OnSelfRankCome(object[] param)
	{
	}

	[Token(Token = "0x6009DA3")]
	[Address(RVA = "0x166FDFC", Offset = "0x166FDFC", VA = "0x166FDFC")]
	private void OnTopPlayerArmLevelCome(object[] param)
	{
	}

	[Token(Token = "0x6009DA4")]
	[Address(RVA = "0x166F88C", Offset = "0x166F88C", VA = "0x166F88C")]
	private void UpdateMaxLevel()
	{
	}

	[Token(Token = "0x6009DA5")]
	[Address(RVA = "0x166F058", Offset = "0x166F058", VA = "0x166F058")]
	private void UpdateSelfArmInfo()
	{
	}

	[Token(Token = "0x6009DA6")]
	[Address(RVA = "0x166F57C", Offset = "0x166F57C", VA = "0x166F57C")]
	private void UpdateTopArmInfo()
	{
	}

	[Token(Token = "0x6009DA7")]
	[Address(RVA = "0x166F368", Offset = "0x166F368", VA = "0x166F368")]
	private void UpdateSelfRank()
	{
	}

	[Token(Token = "0x6009DA8")]
	[Address(RVA = "0x166FEDC", Offset = "0x166FEDC", VA = "0x166FEDC")]
	private void SetWeaponIcon(uint weaponID, UISprite uiSprite)
	{
	}

	[Token(Token = "0x6009DA9")]
	[Address(RVA = "0x1670090", Offset = "0x1670090", VA = "0x1670090")]
	private void Update()
	{
	}

	[Token(Token = "0x6009DAA")]
	[Address(RVA = "0x1670368", Offset = "0x1670368", VA = "0x1670368")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009DAB")]
	[Address(RVA = "0x1670370", Offset = "0x1670370", VA = "0x1670370")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
