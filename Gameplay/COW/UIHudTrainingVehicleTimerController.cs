using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023E5")]
public class UIHudTrainingVehicleTimerController : UIBaseController
{
	[Token(Token = "0x400DF0A")]
	[FieldOffset(Offset = "0x28")]
	private CBNIKECJHAN m_CurrentGame;

	[Token(Token = "0x400DF0B")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudTrainingVehicleTimerView m_View;

	[Token(Token = "0x400DF0C")]
	[FieldOffset(Offset = "0x30")]
	private float m_Timer;

	[Token(Token = "0x400DF0D")]
	[FieldOffset(Offset = "0x34")]
	private int minute;

	[Token(Token = "0x400DF0E")]
	[FieldOffset(Offset = "0x38")]
	private int sec;

	[Token(Token = "0x400DF0F")]
	[FieldOffset(Offset = "0x3C")]
	private int miSec;

	[Token(Token = "0x400DF10")]
	[FieldOffset(Offset = "0x40")]
	private int history;

	[Token(Token = "0x400DF11")]
	[FieldOffset(Offset = "0x44")]
	private bool play;

	[Token(Token = "0x600CA98")]
	[Address(RVA = "0x15866F8", Offset = "0x15866F8", VA = "0x15866F8")]
	public UIHudTrainingVehicleTimerController()
	{
	}

	[Token(Token = "0x600CA99")]
	[Address(RVA = "0x158677C", Offset = "0x158677C", VA = "0x158677C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CA9A")]
	[Address(RVA = "0x1586820", Offset = "0x1586820", VA = "0x1586820", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CA9B")]
	[Address(RVA = "0x1586AEC", Offset = "0x1586AEC", VA = "0x1586AEC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600CA9C")]
	[Address(RVA = "0x1586C88", Offset = "0x1586C88", VA = "0x1586C88")]
	private void Update()
	{
	}

	[Token(Token = "0x600CA9D")]
	[Address(RVA = "0x1586E84", Offset = "0x1586E84", VA = "0x1586E84")]
	private void ClearLastData()
	{
	}

	[Token(Token = "0x600CA9E")]
	[Address(RVA = "0x1587018", Offset = "0x1587018", VA = "0x1587018")]
	private void UpdateResult()
	{
	}

	[Token(Token = "0x600CA9F")]
	[Address(RVA = "0x15872AC", Offset = "0x15872AC", VA = "0x15872AC")]
	private void SendRankResult(uint result)
	{
	}

	[Token(Token = "0x600CAA0")]
	[Address(RVA = "0x1587574", Offset = "0x1587574", VA = "0x1587574")]
	public void StartGame(bool b)
	{
	}

	[Token(Token = "0x600CAA1")]
	[Address(RVA = "0x15875E0", Offset = "0x15875E0", VA = "0x15875E0")]
	private void OnMiniGameClose(object[] data)
	{
	}

	[Token(Token = "0x600CAA2")]
	[Address(RVA = "0x158766C", Offset = "0x158766C", VA = "0x158766C")]
	private void OnGoThroughtStartPoint(object[] data)
	{
	}

	[Token(Token = "0x600CAA3")]
	[Address(RVA = "0x15877F0", Offset = "0x15877F0", VA = "0x15877F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CAA4")]
	[Address(RVA = "0x15877F8", Offset = "0x15877F8", VA = "0x15877F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
