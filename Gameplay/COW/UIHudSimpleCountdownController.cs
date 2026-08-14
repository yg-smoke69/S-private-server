using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002847")]
internal class UIHudSimpleCountdownController : UIBaseController
{
	[Token(Token = "0x400F885")]
	[FieldOffset(Offset = "0x28")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400F886")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudSimpleCountdownView m_View;

	[Token(Token = "0x600FB8A")]
	[Address(RVA = "0x16BAF04", Offset = "0x16BAF04", VA = "0x16BAF04")]
	public UIHudSimpleCountdownController()
	{
	}

	[Token(Token = "0x600FB8B")]
	[Address(RVA = "0x16BAF88", Offset = "0x16BAF88", VA = "0x16BAF88")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FB8C")]
	[Address(RVA = "0x16BB02C", Offset = "0x16BB02C", VA = "0x16BB02C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FB8D")]
	[Address(RVA = "0x16BB1EC", Offset = "0x16BB1EC", VA = "0x16BB1EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FB8E")]
	[Address(RVA = "0x16BB320", Offset = "0x16BB320", VA = "0x16BB320")]
	private void OnPhaseTimeChange(object[] data)
	{
	}

	[Token(Token = "0x600FB8F")]
	[Address(RVA = "0x16BB3A4", Offset = "0x16BB3A4", VA = "0x16BB3A4")]
	private void Update()
	{
	}

	[Token(Token = "0x600FB90")]
	[Address(RVA = "0x16BB410", Offset = "0x16BB410", VA = "0x16BB410")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FB91")]
	[Address(RVA = "0x16BB418", Offset = "0x16BB418", VA = "0x16BB418")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
