using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026D6")]
public class UIHUDArmsLevelUPTipController : UIBaseController, _Attribute
{
	[Token(Token = "0x400EFF3")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDArmsLevelUPTipView m_View;

	[Token(Token = "0x400EFF4")]
	[FieldOffset(Offset = "0x2C")]
	private int m_DelayHandle;

	[Token(Token = "0x600EB00")]
	[Address(RVA = "0x166B7A0", Offset = "0x166B7A0", VA = "0x166B7A0")]
	public UIHUDArmsLevelUPTipController()
	{
	}

	[Token(Token = "0x600EB01")]
	[Address(RVA = "0x166B82C", Offset = "0x166B82C", VA = "0x166B82C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB02")]
	[Address(RVA = "0x166B8D4", Offset = "0x166B8D4", VA = "0x166B8D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB03")]
	[Address(RVA = "0x166BAB4", Offset = "0x166BAB4", VA = "0x166BAB4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EB04")]
	[Address(RVA = "0x166BC78", Offset = "0x166BC78", VA = "0x166BC78", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600EB05")]
	[Address(RVA = "0x166BF1C", Offset = "0x166BF1C", VA = "0x166BF1C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600EB06")]
	[Address(RVA = "0x166BFB0", Offset = "0x166BFB0", VA = "0x166BFB0")]
	public void ArmsRaceShowTip(object[] param)
	{
	}

	[Token(Token = "0x600EB07")]
	[Address(RVA = "0x166BD44", Offset = "0x166BD44", VA = "0x166BD44")]
	public void ShowTip()
	{
	}

	[Token(Token = "0x600EB08")]
	[Address(RVA = "0x166C28C", Offset = "0x166C28C", VA = "0x166C28C")]
	public void HideTip()
	{
	}

	[Token(Token = "0x600EB09")]
	[Address(RVA = "0x166C2F8", Offset = "0x166C2F8", VA = "0x166C2F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EB0A")]
	[Address(RVA = "0x166C300", Offset = "0x166C300", VA = "0x166C300")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
