using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002893")]
internal class UIHudTweenTipsController : UIBaseController
{
	[Token(Token = "0x400F9DC")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTweenTipsView m_View;

	[Token(Token = "0x400F9DD")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400F9DE")]
	[FieldOffset(Offset = "0x30")]
	private string IconName_UAV;

	[Token(Token = "0x400F9DF")]
	[FieldOffset(Offset = "0x34")]
	private string IconName_TeleportDoor;

	[Token(Token = "0x400F9E0")]
	[FieldOffset(Offset = "0x38")]
	private string IconName_Zeppelin;

	[Token(Token = "0x400F9E1")]
	[FieldOffset(Offset = "0x3C")]
	private string IconName_GuildWar_Box;

	[Token(Token = "0x400F9E2")]
	[FieldOffset(Offset = "0x40")]
	private string IconName_Training_Max_Killer;

	[Token(Token = "0x400F9E3")]
	[FieldOffset(Offset = "0x44")]
	private string IconName_Bomb;

	[Token(Token = "0x400F9E4")]
	[FieldOffset(Offset = "0x48")]
	private string IconName_Common;

	[Token(Token = "0x400F9E5")]
	[FieldOffset(Offset = "0x4C")]
	private string IconName_Ludo_BonusDice;

	[Token(Token = "0x400F9E6")]
	[FieldOffset(Offset = "0x50")]
	private string IconName_Ludo_NoMove;

	[Token(Token = "0x400F9E7")]
	[FieldOffset(Offset = "0x54")]
	private string IconName_Zombie;

	[Token(Token = "0x400F9E8")]
	[FieldOffset(Offset = "0x58")]
	private string IconName_DeathMatchKillerKing;

	[Token(Token = "0x600FEB7")]
	[Address(RVA = "0x1593438", Offset = "0x1593438", VA = "0x1593438")]
	public UIHudTweenTipsController()
	{
	}

	[Token(Token = "0x600FEB8")]
	[Address(RVA = "0x1593588", Offset = "0x1593588", VA = "0x1593588")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FEB9")]
	[Address(RVA = "0x159362C", Offset = "0x159362C", VA = "0x159362C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FEBA")]
	[Address(RVA = "0x15936E8", Offset = "0x15936E8", VA = "0x15936E8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FEBB")]
	[Address(RVA = "0x159374C", Offset = "0x159374C", VA = "0x159374C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FEBC")]
	[Address(RVA = "0x15938C8", Offset = "0x15938C8", VA = "0x15938C8")]
	public void SetMessage(string message, float duration, InGameEventTipsType tipsType, int offset)
	{
	}

	[Token(Token = "0x600FEBD")]
	[Address(RVA = "0x1594154", Offset = "0x1594154", VA = "0x1594154")]
	public void SetMessageWithIcon(string message, float duration, ResourceID iconRes)
	{
	}

	[Token(Token = "0x600FEBE")]
	[Address(RVA = "0x1593EAC", Offset = "0x1593EAC", VA = "0x1593EAC")]
	private void SetData(string message, float duration)
	{
	}

	[Token(Token = "0x600FEBF")]
	[Address(RVA = "0x1593D24", Offset = "0x1593D24", VA = "0x1593D24")]
	private string GetIconName(InGameEventTipsType tipsType)
	{
		return null;
	}

	[Token(Token = "0x600FEC0")]
	[Address(RVA = "0x159427C", Offset = "0x159427C", VA = "0x159427C")]
	private void AutoHide()
	{
	}

	[Token(Token = "0x600FEC1")]
	[Address(RVA = "0x15937B8", Offset = "0x15937B8", VA = "0x15937B8")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600FEC2")]
	[Address(RVA = "0x159438C", Offset = "0x159438C", VA = "0x159438C", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600FEC3")]
	[Address(RVA = "0x15943F8", Offset = "0x15943F8", VA = "0x15943F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FEC4")]
	[Address(RVA = "0x1594400", Offset = "0x1594400", VA = "0x1594400")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FEC5")]
	[Address(RVA = "0x1594408", Offset = "0x1594408", VA = "0x1594408")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FEC6")]
	[Address(RVA = "0x1594410", Offset = "0x1594410", VA = "0x1594410")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
