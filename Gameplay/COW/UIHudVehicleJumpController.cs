using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028A9")]
internal class UIHudVehicleJumpController : UIHudVehicleItemButtonController
{
	[Token(Token = "0x400FA3A")]
	[FieldOffset(Offset = "0x44")]
	private UIHudVehicleJumpView m_View;

	[Token(Token = "0x400FA3B")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsHighlight;

	[Token(Token = "0x400FA3C")]
	[FieldOffset(Offset = "0x4C")]
	private Vehicle m_Vehicle;

	[Token(Token = "0x600FF8E")]
	[Address(RVA = "0x1A6EA40", Offset = "0x1A6EA40", VA = "0x1A6EA40")]
	public UIHudVehicleJumpController()
	{
	}

	[Token(Token = "0x600FF8F")]
	[Address(RVA = "0x1A6EA50", Offset = "0x1A6EA50", VA = "0x1A6EA50")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FF90")]
	[Address(RVA = "0x1A6EAF4", Offset = "0x1A6EAF4", VA = "0x1A6EAF4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FF91")]
	[Address(RVA = "0x1A6ECA8", Offset = "0x1A6ECA8", VA = "0x1A6ECA8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600FF92")]
	[Address(RVA = "0x1A6EDD8", Offset = "0x1A6EDD8", VA = "0x1A6EDD8", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600FF93")]
	[Address(RVA = "0x1A6EE7C", Offset = "0x1A6EE7C", VA = "0x1A6EE7C", Slot = "37")]
	protected override void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	[Token(Token = "0x600FF94")]
	[Address(RVA = "0x1A6F020", Offset = "0x1A6F020", VA = "0x1A6F020")]
	protected void OnPlayerGetOffVehicle(object[] ps)
	{
	}

	[Token(Token = "0x600FF95")]
	[Address(RVA = "0x1A6F1FC", Offset = "0x1A6F1FC", VA = "0x1A6F1FC", Slot = "39")]
	protected override void Update()
	{
	}

	[Token(Token = "0x600FF96")]
	[Address(RVA = "0x1A6F348", Offset = "0x1A6F348", VA = "0x1A6F348")]
	private void SetHightlight(bool highlight)
	{
	}

	[Token(Token = "0x600FF97")]
	[Address(RVA = "0x1A6F3BC", Offset = "0x1A6F3BC", VA = "0x1A6F3BC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FF98")]
	[Address(RVA = "0x1A6F3C0", Offset = "0x1A6F3C0", VA = "0x1A6F3C0")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600FF99")]
	[Address(RVA = "0x1A6F3C4", Offset = "0x1A6F3C4", VA = "0x1A6F3C4")]
	public void _003C_003EiFixBaseProxy_OnPlayerGetOnVehicle(object[] P0)
	{
	}

	[Token(Token = "0x600FF9A")]
	[Address(RVA = "0x1A6F3C8", Offset = "0x1A6F3C8", VA = "0x1A6F3C8")]
	public void _003C_003EiFixBaseProxy_Update()
	{
	}
}
