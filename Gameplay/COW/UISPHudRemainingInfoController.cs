using System.Runtime.InteropServices;
using System.Text;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002B43")]
public class UISPHudRemainingInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010977")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudRemainingInfoView m_View;

	[Token(Token = "0x4010978")]
	[FieldOffset(Offset = "0x2C")]
	private HHDIPHFOBFO m_CurrentGroupMode;

	[Token(Token = "0x4010979")]
	[FieldOffset(Offset = "0x30")]
	private long m_LastSeconds;

	[Token(Token = "0x401097A")]
	[FieldOffset(Offset = "0x38")]
	private StringBuilder m_TimeString;

	[Token(Token = "0x6011D06")]
	[Address(RVA = "0x1D2916C", Offset = "0x1D2916C", VA = "0x1D2916C")]
	public UISPHudRemainingInfoController()
	{
	}

	[Token(Token = "0x6011D07")]
	[Address(RVA = "0x1D29214", Offset = "0x1D29214", VA = "0x1D29214")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011D08")]
	[Address(RVA = "0x1D292BC", Offset = "0x1D292BC", VA = "0x1D292BC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011D09")]
	[Address(RVA = "0x1D29DE4", Offset = "0x1D29DE4", VA = "0x1D29DE4")]
	private void ChangeVisible(object[] data)
	{
	}

	[Token(Token = "0x6011D0A")]
	[Address(RVA = "0x1D29ED4", Offset = "0x1D29ED4", VA = "0x1D29ED4")]
	private void Update()
	{
	}

	[Token(Token = "0x6011D0B")]
	[Address(RVA = "0x1D2A134", Offset = "0x1D2A134", VA = "0x1D2A134", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011D0C")]
	[Address(RVA = "0x1D2A2F8", Offset = "0x1D2A2F8", VA = "0x1D2A2F8", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011D0D")]
	[Address(RVA = "0x1D2A660", Offset = "0x1D2A660", VA = "0x1D2A660", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011D0E")]
	[Address(RVA = "0x1D2A6F4", Offset = "0x1D2A6F4", VA = "0x1D2A6F4")]
	private void OnSafeZoneChanged(object[] data)
	{
	}

	[Token(Token = "0x6011D0F")]
	[Address(RVA = "0x1D2A898", Offset = "0x1D2A898", VA = "0x1D2A898")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011D10")]
	[Address(RVA = "0x1D2A8A0", Offset = "0x1D2A8A0", VA = "0x1D2A8A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
