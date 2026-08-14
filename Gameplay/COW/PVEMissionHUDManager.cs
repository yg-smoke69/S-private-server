using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022AF")]
internal class PVEMissionHUDManager
{
	[Token(Token = "0x400D904")]
	[FieldOffset(Offset = "0x8")]
	private UIHUDPVEMissionListController m_ListController;

	[Token(Token = "0x400D905")]
	[FieldOffset(Offset = "0xC")]
	private UIHUDPVEMissionCenterTipController m_CenterTipController;

	[Token(Token = "0x400D906")]
	[FieldOffset(Offset = "0x10")]
	private UIInGameScene m_UIScene;

	[Token(Token = "0x400D907")]
	[FieldOffset(Offset = "0x14")]
	private string m_MissionContent;

	[Token(Token = "0x600BEB5")]
	[Address(RVA = "0x28CE2FC", Offset = "0x28CE2FC", VA = "0x28CE2FC")]
	public PVEMissionHUDManager()
	{
	}

	[Token(Token = "0x600BEB6")]
	[Address(RVA = "0x28CE304", Offset = "0x28CE304", VA = "0x28CE304")]
	public void InitManager(UIInGameScene uiScene)
	{
	}

	[Token(Token = "0x600BEB7")]
	[Address(RVA = "0x28CE36C", Offset = "0x28CE36C", VA = "0x28CE36C")]
	public void MissionCome(string content)
	{
	}

	[Token(Token = "0x600BEB8")]
	[Address(RVA = "0x28CE6B4", Offset = "0x28CE6B4", VA = "0x28CE6B4")]
	public void OnCenterShowFinish(string content)
	{
	}
}
