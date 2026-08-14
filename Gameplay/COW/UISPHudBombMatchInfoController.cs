using System.Text;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B28")]
internal class UISPHudBombMatchInfoController : UIBaseController
{
	[Token(Token = "0x4010903")]
	[FieldOffset(Offset = "0x0")]
	private static string ZoneAStr;

	[Token(Token = "0x4010904")]
	[FieldOffset(Offset = "0x4")]
	private static string ZoneBStr;

	[Token(Token = "0x4010905")]
	[FieldOffset(Offset = "0x28")]
	private StringBuilder m_Timer;

	[Token(Token = "0x4010906")]
	[FieldOffset(Offset = "0x2C")]
	private uint min;

	[Token(Token = "0x4010907")]
	[FieldOffset(Offset = "0x30")]
	private uint sec;

	[Token(Token = "0x4010908")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsLeftAttack;

	[Token(Token = "0x4010909")]
	[FieldOffset(Offset = "0x35")]
	private bool m_IsInitFaction;

	[Token(Token = "0x401090A")]
	[FieldOffset(Offset = "0x36")]
	private bool m_IsSetTeamBlueName;

	[Token(Token = "0x401090B")]
	[FieldOffset(Offset = "0x37")]
	private bool m_IsSetTeamRedName;

	[Token(Token = "0x401090C")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsSetTeamBlueIcon;

	[Token(Token = "0x401090D")]
	[FieldOffset(Offset = "0x39")]
	private bool m_IsSetTeamRedIcon;

	[Token(Token = "0x401090E")]
	[FieldOffset(Offset = "0x3A")]
	private bool m_StartProgressing;

	[Token(Token = "0x401090F")]
	[FieldOffset(Offset = "0x3C")]
	private UIProgressBar m_RemoveBombProgressBar;

	[Token(Token = "0x4010910")]
	[FieldOffset(Offset = "0x40")]
	private float m_StartTime;

	[Token(Token = "0x4010911")]
	[FieldOffset(Offset = "0x44")]
	private float m_TotalTime;

	[Token(Token = "0x4010912")]
	[FieldOffset(Offset = "0x48")]
	private uint m_BombExplodeTime;

	[Token(Token = "0x4010913")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMatch m_ModelMatch;

	[Token(Token = "0x4010914")]
	[FieldOffset(Offset = "0x50")]
	private UIModelSpectator m_ModelSpectator;

	[Token(Token = "0x4010915")]
	[FieldOffset(Offset = "0x54")]
	private UISPHudBombMatchInfoView m_View;

	[Token(Token = "0x6011C02")]
	[Address(RVA = "0x143EB44", Offset = "0x143EB44", VA = "0x143EB44")]
	public UISPHudBombMatchInfoController()
	{
	}

	[Token(Token = "0x6011C03")]
	[Address(RVA = "0x143EBC8", Offset = "0x143EBC8", VA = "0x143EBC8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011C04")]
	[Address(RVA = "0x143EC70", Offset = "0x143EC70", VA = "0x143EC70", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011C05")]
	[Address(RVA = "0x143F54C", Offset = "0x143F54C", VA = "0x143F54C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6011C06")]
	[Address(RVA = "0x143F5B0", Offset = "0x143F5B0", VA = "0x143F5B0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011C07")]
	[Address(RVA = "0x143F614", Offset = "0x143F614", VA = "0x143F614", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011C08")]
	[Address(RVA = "0x143FA20", Offset = "0x143FA20", VA = "0x143FA20")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x6011C09")]
	[Address(RVA = "0x143FA74", Offset = "0x143FA74", VA = "0x143FA74", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011C0A")]
	[Address(RVA = "0x143FAF0", Offset = "0x143FAF0", VA = "0x143FAF0")]
	private void SetUIData()
	{
	}

	[Token(Token = "0x6011C0B")]
	[Address(RVA = "0x143FB44", Offset = "0x143FB44", VA = "0x143FB44")]
	private void Update()
	{
	}

	[Token(Token = "0x6011C0C")]
	[Address(RVA = "0x143FBA4", Offset = "0x143FBA4", VA = "0x143FBA4")]
	private void UpdateBombCountdown()
	{
	}

	[Token(Token = "0x6011C0D")]
	[Address(RVA = "0x14409E0", Offset = "0x14409E0", VA = "0x14409E0")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x6011C0E")]
	[Address(RVA = "0x1440C20", Offset = "0x1440C20", VA = "0x1440C20")]
	private void OnAddPlayer(object[] data)
	{
	}

	[Token(Token = "0x6011C0F")]
	[Address(RVA = "0x14415D4", Offset = "0x14415D4", VA = "0x14415D4")]
	private void OnFactionChange(object[] data)
	{
	}

	[Token(Token = "0x6011C10")]
	[Address(RVA = "0x1441390", Offset = "0x1441390", VA = "0x1441390")]
	private void OnODFactionChange(object[] data)
	{
	}

	[Token(Token = "0x6011C11")]
	[Address(RVA = "0x14417BC", Offset = "0x14417BC", VA = "0x14417BC")]
	private void SetBombFactionIcon(bool attack, UISprite sprite, bool isBig)
	{
	}

	[Token(Token = "0x6011C12")]
	[Address(RVA = "0x144186C", Offset = "0x144186C", VA = "0x144186C")]
	private string GetIconNameInAtlas(bool attack, bool isBig)
	{
		return null;
	}

	[Token(Token = "0x6011C13")]
	[Address(RVA = "0x1441964", Offset = "0x1441964", VA = "0x1441964")]
	private void OnScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x6011C14")]
	[Address(RVA = "0x1441C04", Offset = "0x1441C04", VA = "0x1441C04")]
	private void OnCoinChanged(object[] data)
	{
	}

	[Token(Token = "0x6011C15")]
	[Address(RVA = "0x1442290", Offset = "0x1442290", VA = "0x1442290")]
	private void OnNewPhaseEnter(object[] data)
	{
	}

	[Token(Token = "0x6011C16")]
	[Address(RVA = "0x1442444", Offset = "0x1442444", VA = "0x1442444")]
	private void OnBombPlantTimeSync(object[] data)
	{
	}

	[Token(Token = "0x6011C17")]
	[Address(RVA = "0x144251C", Offset = "0x144251C", VA = "0x144251C")]
	private void On3PPreparation(object[] data)
	{
	}

	[Token(Token = "0x6011C18")]
	[Address(RVA = "0x144298C", Offset = "0x144298C", VA = "0x144298C")]
	private void OnBombRemoved(object[] data)
	{
	}

	[Token(Token = "0x6011C1A")]
	[Address(RVA = "0x1442C58", Offset = "0x1442C58", VA = "0x1442C58")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011C1B")]
	[Address(RVA = "0x1442C60", Offset = "0x1442C60", VA = "0x1442C60")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6011C1C")]
	[Address(RVA = "0x1442C68", Offset = "0x1442C68", VA = "0x1442C68")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6011C1D")]
	[Address(RVA = "0x1442C70", Offset = "0x1442C70", VA = "0x1442C70")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6011C1E")]
	[Address(RVA = "0x1442C78", Offset = "0x1442C78", VA = "0x1442C78")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
