using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022C0")]
internal class UIHudPVETurnInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x400D93D")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPVETurnInfoView m_View;

	[Token(Token = "0x400D93E")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_delcayCall;

	[Token(Token = "0x600BF39")]
	[Address(RVA = "0x183CC00", Offset = "0x183CC00", VA = "0x183CC00")]
	public UIHudPVETurnInfoController()
	{
	}

	[Token(Token = "0x600BF3A")]
	[Address(RVA = "0x183CC84", Offset = "0x183CC84", VA = "0x183CC84")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF3B")]
	[Address(RVA = "0x183CD28", Offset = "0x183CD28", VA = "0x183CD28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF3C")]
	[Address(RVA = "0x183D110", Offset = "0x183D110", VA = "0x183D110", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BF3D")]
	[Address(RVA = "0x183D348", Offset = "0x183D348", VA = "0x183D348")]
	private void PlayerMidAnimation(byte turn)
	{
	}

	[Token(Token = "0x600BF3E")]
	[Address(RVA = "0x183D624", Offset = "0x183D624", VA = "0x183D624")]
	private void OnNewRoundStart(object[] data)
	{
	}

	[Token(Token = "0x600BF3F")]
	[Address(RVA = "0x183D710", Offset = "0x183D710", VA = "0x183D710", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BF40")]
	[Address(RVA = "0x183DA20", Offset = "0x183DA20", VA = "0x183DA20", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BF41")]
	[Address(RVA = "0x183DAB4", Offset = "0x183DAB4", VA = "0x183DAB4")]
	private void _003CPlayerMidAnimation_003Em__0()
	{
	}

	[Token(Token = "0x600BF42")]
	[Address(RVA = "0x183DAF8", Offset = "0x183DAF8", VA = "0x183DAF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BF43")]
	[Address(RVA = "0x183DB00", Offset = "0x183DB00", VA = "0x183DB00")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
