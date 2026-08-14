using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200287E")]
internal class UIHudTimerController : UIBaseController, _Attribute
{
	[Token(Token = "0x400F987")]
	[FieldOffset(Offset = "0x28")]
	private UIHudTimerViewExt m_View;

	[Token(Token = "0x400F988")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelMatch m_MatchModel;

	[Token(Token = "0x600FDF9")]
	[Address(RVA = "0x157E070", Offset = "0x157E070", VA = "0x157E070")]
	public UIHudTimerController()
	{
	}

	[Token(Token = "0x600FDFA")]
	[Address(RVA = "0x157E0F4", Offset = "0x157E0F4", VA = "0x157E0F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FDFB")]
	[Address(RVA = "0x157E198", Offset = "0x157E198", VA = "0x157E198", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FDFC")]
	[Address(RVA = "0x157E364", Offset = "0x157E364", VA = "0x157E364", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FDFD")]
	[Address(RVA = "0x157E3EC", Offset = "0x157E3EC", VA = "0x157E3EC", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600FDFE")]
	[Address(RVA = "0x157E86C", Offset = "0x157E86C", VA = "0x157E86C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600FDFF")]
	[Address(RVA = "0x157E900", Offset = "0x157E900", VA = "0x157E900")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FE00")]
	[Address(RVA = "0x157E908", Offset = "0x157E908", VA = "0x157E908")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
