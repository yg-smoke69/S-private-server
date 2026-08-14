using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200281A")]
internal class UIHudQuickUseRepairKitController : UIBaseController
{
	[Token(Token = "0x400F79A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudQuickUseRepairKitView m_View;

	[Token(Token = "0x400F79B")]
	[FieldOffset(Offset = "0x2C")]
	private float m_StartTime;

	[Token(Token = "0x400F79C")]
	[FieldOffset(Offset = "0x30")]
	private float m_TotalTime;

	[Token(Token = "0x400F79D")]
	[FieldOffset(Offset = "0x34")]
	private int m_RepairKitCount;

	[Token(Token = "0x600F9CD")]
	[Address(RVA = "0x1FD363C", Offset = "0x1FD363C", VA = "0x1FD363C")]
	public UIHudQuickUseRepairKitController()
	{
	}

	[Token(Token = "0x600F9CE")]
	[Address(RVA = "0x1FD36C0", Offset = "0x1FD36C0", VA = "0x1FD36C0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F9CF")]
	[Address(RVA = "0x1FD3764", Offset = "0x1FD3764", VA = "0x1FD3764", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F9D0")]
	[Address(RVA = "0x1FD3C18", Offset = "0x1FD3C18", VA = "0x1FD3C18", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F9D1")]
	[Address(RVA = "0x1FD3F54", Offset = "0x1FD3F54", VA = "0x1FD3F54")]
	private void Update()
	{
	}

	[Token(Token = "0x600F9D2")]
	[Address(RVA = "0x1FD4278", Offset = "0x1FD4278", VA = "0x1FD4278")]
	private void OnBtnQuickUse()
	{
	}

	[Token(Token = "0x600F9D3")]
	[Address(RVA = "0x1FD47A8", Offset = "0x1FD47A8", VA = "0x1FD47A8")]
	private void OnInventoryRepairKitChanged(object[] param)
	{
	}

	[Token(Token = "0x600F9D4")]
	[Address(RVA = "0x1FD4CA4", Offset = "0x1FD4CA4", VA = "0x1FD4CA4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F9D5")]
	[Address(RVA = "0x1FD5108", Offset = "0x1FD5108", VA = "0x1FD5108")]
	private bool CheckToShowUse(IHAAMHPPLMG pId)
	{
		return default(bool);
	}

	[Token(Token = "0x600F9D6")]
	[Address(RVA = "0x1FD54B4", Offset = "0x1FD54B4", VA = "0x1FD54B4")]
	private void OnPlayerTryUseVehicleItem(object[] param)
	{
	}

	[Token(Token = "0x600F9D7")]
	[Address(RVA = "0x1FD5920", Offset = "0x1FD5920", VA = "0x1FD5920")]
	private void OnPlayerCancelUseVehicleItem(object[] param)
	{
	}

	[Token(Token = "0x600F9D8")]
	[Address(RVA = "0x1FD5BE8", Offset = "0x1FD5BE8", VA = "0x1FD5BE8")]
	private void OnVehicleHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600F9D9")]
	[Address(RVA = "0x1FD5EC4", Offset = "0x1FD5EC4", VA = "0x1FD5EC4")]
	private void OnGetOnVehicle(object[] param)
	{
	}

	[Token(Token = "0x600F9DA")]
	[Address(RVA = "0x1FD60B0", Offset = "0x1FD60B0", VA = "0x1FD60B0")]
	private void OnGetOffVehicle(object[] param)
	{
	}

	[Token(Token = "0x600F9DB")]
	[Address(RVA = "0x1FD4F40", Offset = "0x1FD4F40", VA = "0x1FD4F40")]
	private void UpdateIconStatus(Player p)
	{
	}

	[Token(Token = "0x600F9DC")]
	[Address(RVA = "0x1FD48EC", Offset = "0x1FD48EC", VA = "0x1FD48EC")]
	private void UpdateUrgencyEffect()
	{
	}

	[Token(Token = "0x600F9DD")]
	[Address(RVA = "0x1FD629C", Offset = "0x1FD629C", VA = "0x1FD629C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F9DE")]
	[Address(RVA = "0x1FD62A4", Offset = "0x1FD62A4", VA = "0x1FD62A4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F9DF")]
	[Address(RVA = "0x1FD62AC", Offset = "0x1FD62AC", VA = "0x1FD62AC")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
