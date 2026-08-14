using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200289D")]
internal class UIHudUGCDebuggerController : UIBaseController
{
	[Token(Token = "0x400FA08")]
	[FieldOffset(Offset = "0x28")]
	private UIHudUGCDebuggerView m_View;

	[Token(Token = "0x400FA09")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_isPaused;

	[Token(Token = "0x400FA0A")]
	[FieldOffset(Offset = "0x30")]
	private UIUGCDebuggerConsole m_debugConsoleWindow;

	[Token(Token = "0x400FA0B")]
	[FieldOffset(Offset = "0x34")]
	private float m_lastDebugActiveTime;

	[Token(Token = "0x400FA0C")]
	[FieldOffset(Offset = "0x38")]
	private float m_maxDebugIdleTime;

	[Token(Token = "0x400FA0D")]
	[FieldOffset(Offset = "0x3C")]
	private float m_enterAutoExitDebugTime;

	[Token(Token = "0x400FA0E")]
	[FieldOffset(Offset = "0x40")]
	private bool m_isHealing;

	[Token(Token = "0x600FF00")]
	[Address(RVA = "0x1595318", Offset = "0x1595318", VA = "0x1595318")]
	public UIHudUGCDebuggerController()
	{
	}

	[Token(Token = "0x600FF01")]
	[Address(RVA = "0x15953B4", Offset = "0x15953B4", VA = "0x15953B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FF02")]
	[Address(RVA = "0x1595458", Offset = "0x1595458", VA = "0x1595458", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FF03")]
	[Address(RVA = "0x1595ED4", Offset = "0x1595ED4", VA = "0x1595ED4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FF04")]
	[Address(RVA = "0x1595AF8", Offset = "0x1595AF8", VA = "0x1595AF8")]
	private void RefreshDebugButtons()
	{
	}

	[Token(Token = "0x600FF05")]
	[Address(RVA = "0x15960D8", Offset = "0x15960D8", VA = "0x15960D8")]
	private void OnDebugAttachChanged(object[] data)
	{
	}

	[Token(Token = "0x600FF06")]
	[Address(RVA = "0x1596140", Offset = "0x1596140", VA = "0x1596140")]
	private void OnGamePauseChanged(object[] data)
	{
	}

	[Token(Token = "0x600FF07")]
	[Address(RVA = "0x1596320", Offset = "0x1596320", VA = "0x1596320")]
	private void OnBtnDrop()
	{
	}

	[Token(Token = "0x600FF08")]
	[Address(RVA = "0x1596684", Offset = "0x1596684", VA = "0x1596684")]
	private void OnPauseGameBtn()
	{
	}

	[Token(Token = "0x600FF09")]
	[Address(RVA = "0x15967A4", Offset = "0x15967A4", VA = "0x15967A4")]
	private void OnClickOpenGMCmdBtn()
	{
	}

	[Token(Token = "0x600FF0A")]
	[Address(RVA = "0x1596874", Offset = "0x1596874", VA = "0x1596874")]
	private void OnCloseGMCmdBtn()
	{
	}

	[Token(Token = "0x600FF0B")]
	[Address(RVA = "0x1596904", Offset = "0x1596904", VA = "0x1596904")]
	private void OnClickOpenConsoleBtn()
	{
	}

	[Token(Token = "0x600FF0C")]
	[Address(RVA = "0x1596A8C", Offset = "0x1596A8C", VA = "0x1596A8C")]
	private void OnGodStateChanged(object[] data)
	{
	}

	[Token(Token = "0x600FF0D")]
	[Address(RVA = "0x1596CAC", Offset = "0x1596CAC", VA = "0x1596CAC")]
	private void Update()
	{
	}

	[Token(Token = "0x600FF0E")]
	[Address(RVA = "0x1597148", Offset = "0x1597148", VA = "0x1597148")]
	private bool IsDebugIdle()
	{
		return default(bool);
	}

	[Token(Token = "0x600FF0F")]
	[Address(RVA = "0x1596DDC", Offset = "0x1596DDC", VA = "0x1596DDC")]
	private void CheckDebugIdleExit()
	{
	}

	[Token(Token = "0x600FF10")]
	[Address(RVA = "0x15971F8", Offset = "0x15971F8", VA = "0x15971F8")]
	private void OnClickGodBtn()
	{
	}

	[Token(Token = "0x600FF11")]
	[Address(RVA = "0x159731C", Offset = "0x159731C", VA = "0x159731C")]
	private void OnHealBuffBtn()
	{
	}

	[Token(Token = "0x600FF12")]
	[Address(RVA = "0x159759C", Offset = "0x159759C", VA = "0x159759C")]
	private void OnKillSelfBtn()
	{
	}

	[Token(Token = "0x600FF13")]
	[Address(RVA = "0x15976C0", Offset = "0x15976C0", VA = "0x15976C0")]
	private void OnTeleportBornBtn()
	{
	}

	[Token(Token = "0x600FF14")]
	[Address(RVA = "0x15977E4", Offset = "0x15977E4", VA = "0x15977E4")]
	private void _003CCheckDebugIdleExit_003Em__0()
	{
	}

	[Token(Token = "0x600FF15")]
	[Address(RVA = "0x159780C", Offset = "0x159780C", VA = "0x159780C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FF16")]
	[Address(RVA = "0x1597814", Offset = "0x1597814", VA = "0x1597814")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
