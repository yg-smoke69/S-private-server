using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200289F")]
internal class UIHudUseRescureZoneProcessController : UIBaseController
{
	[Token(Token = "0x400FA10")]
	[FieldOffset(Offset = "0x28")]
	private UIHudUseRescureZoneProcessView m_View;

	[Token(Token = "0x400FA11")]
	[FieldOffset(Offset = "0x2C")]
	private float m_FinishTime;

	[Token(Token = "0x600FF22")]
	[Address(RVA = "0x1A6A3D4", Offset = "0x1A6A3D4", VA = "0x1A6A3D4")]
	public UIHudUseRescureZoneProcessController()
	{
	}

	[Token(Token = "0x600FF23")]
	[Address(RVA = "0x1A6A458", Offset = "0x1A6A458", VA = "0x1A6A458")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FF24")]
	[Address(RVA = "0x1A6A500", Offset = "0x1A6A500", VA = "0x1A6A500", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FF25")]
	[Address(RVA = "0x1A6A6B8", Offset = "0x1A6A6B8", VA = "0x1A6A6B8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FF26")]
	[Address(RVA = "0x1A6A854", Offset = "0x1A6A854", VA = "0x1A6A854")]
	private void OnPlayerDead(object[] param)
	{
	}

	[Token(Token = "0x600FF27")]
	[Address(RVA = "0x1A6A8C8", Offset = "0x1A6A8C8", VA = "0x1A6A8C8")]
	public void OnUseRescureZoneCancel(object[] param)
	{
	}

	[Token(Token = "0x600FF28")]
	[Address(RVA = "0x1A6A944", Offset = "0x1A6A944", VA = "0x1A6A944")]
	public void RefreshActiveState(object[] param)
	{
	}

	[Token(Token = "0x600FF29")]
	[Address(RVA = "0x1A6AB78", Offset = "0x1A6AB78", VA = "0x1A6AB78")]
	private void Update()
	{
	}

	[Token(Token = "0x600FF2A")]
	[Address(RVA = "0x1A6B0C8", Offset = "0x1A6B0C8", VA = "0x1A6B0C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FF2B")]
	[Address(RVA = "0x1A6B0D0", Offset = "0x1A6B0D0", VA = "0x1A6B0D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
