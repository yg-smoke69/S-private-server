using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002298")]
public class UISPHudVehicleStatsController : UIBaseController
{
	[Token(Token = "0x400D8B1")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudVehicleStatsView m_View;

	[Token(Token = "0x400D8B2")]
	[FieldOffset(Offset = "0x2C")]
	private Vehicle m_Vehicle;

	[Token(Token = "0x400D8B3")]
	private const int SPEED_SAMPLE_COUNT = 10;

	[Token(Token = "0x400D8B4")]
	[FieldOffset(Offset = "0x30")]
	private float m_SpeedSum;

	[Token(Token = "0x400D8B5")]
	[FieldOffset(Offset = "0x34")]
	private Queue<float> m_Speeds;

	[Token(Token = "0x400D8B6")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder mLabelBuilder;

	[Token(Token = "0x400D8B7")]
	[FieldOffset(Offset = "0x3C")]
	private int mLastSpeed;

	[Token(Token = "0x600BDF8")]
	[Address(RVA = "0x14A6B20", Offset = "0x14A6B20", VA = "0x14A6B20")]
	public UISPHudVehicleStatsController()
	{
	}

	[Token(Token = "0x600BDF9")]
	[Address(RVA = "0x14A6BE0", Offset = "0x14A6BE0", VA = "0x14A6BE0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BDFA")]
	[Address(RVA = "0x14A6C88", Offset = "0x14A6C88", VA = "0x14A6C88", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BDFB")]
	[Address(RVA = "0x14A6DA0", Offset = "0x14A6DA0", VA = "0x14A6DA0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600BDFC")]
	[Address(RVA = "0x14A70A8", Offset = "0x14A70A8", VA = "0x14A70A8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BDFD")]
	[Address(RVA = "0x14A7368", Offset = "0x14A7368", VA = "0x14A7368")]
	private void OnHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600BDFE")]
	[Address(RVA = "0x14A77E0", Offset = "0x14A77E0", VA = "0x14A77E0")]
	private void OnOBGetOn(object[] data)
	{
	}

	[Token(Token = "0x600BDFF")]
	[Address(RVA = "0x14A7BAC", Offset = "0x14A7BAC", VA = "0x14A7BAC")]
	private void OnOBGetOff(object[] data)
	{
	}

	[Token(Token = "0x600BE00")]
	[Address(RVA = "0x14A7F58", Offset = "0x14A7F58", VA = "0x14A7F58")]
	private void OnObserverSwitch(object[] data)
	{
	}

	[Token(Token = "0x600BE01")]
	[Address(RVA = "0x14A7E54", Offset = "0x14A7E54", VA = "0x14A7E54")]
	private void Clear()
	{
	}

	[Token(Token = "0x600BE02")]
	[Address(RVA = "0x14A8328", Offset = "0x14A8328", VA = "0x14A8328")]
	private void Update()
	{
	}

	[Token(Token = "0x600BE03")]
	[Address(RVA = "0x14A8408", Offset = "0x14A8408", VA = "0x14A8408")]
	private void UpdateSpeed()
	{
	}

	[Token(Token = "0x600BE04")]
	[Address(RVA = "0x14A75B0", Offset = "0x14A75B0", VA = "0x14A75B0")]
	private void RefreshHP()
	{
	}

	[Token(Token = "0x600BE05")]
	[Address(RVA = "0x14A86E8", Offset = "0x14A86E8", VA = "0x14A86E8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BE06")]
	[Address(RVA = "0x14A86F0", Offset = "0x14A86F0", VA = "0x14A86F0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600BE07")]
	[Address(RVA = "0x14A86F8", Offset = "0x14A86F8", VA = "0x14A86F8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
