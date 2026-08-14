using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025C4")]
public class UIDailyBonusController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E9AD")]
	[FieldOffset(Offset = "0x28")]
	private UIDailyBonusView m_View;

	[Token(Token = "0x400E9AE")]
	[FieldOffset(Offset = "0x2C")]
	private List<string> m_Data;

	[Token(Token = "0x600DDD3")]
	[Address(RVA = "0x11EF9E0", Offset = "0x11EF9E0", VA = "0x11EF9E0")]
	public UIDailyBonusController()
	{
	}

	[Token(Token = "0x600DDD4")]
	[Address(RVA = "0x11EFA64", Offset = "0x11EFA64", VA = "0x11EFA64")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DDD5")]
	[Address(RVA = "0x11EFB08", Offset = "0x11EFB08", VA = "0x11EFB08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DDD6")]
	[Address(RVA = "0x11EFF0C", Offset = "0x11EFF0C", VA = "0x11EFF0C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DDD7")]
	[Address(RVA = "0x11F003C", Offset = "0x11F003C", VA = "0x11F003C")]
	private void OnTipsClicked()
	{
	}

	[Token(Token = "0x600DDD8")]
	[Address(RVA = "0x11F06B0", Offset = "0x11F06B0", VA = "0x11F06B0")]
	private void ShowTips()
	{
	}

	[Token(Token = "0x600DDD9")]
	[Address(RVA = "0x11F0820", Offset = "0x11F0820", VA = "0x11F0820", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600DDDA")]
	[Address(RVA = "0x11F0B88", Offset = "0x11F0B88", VA = "0x11F0B88", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600DDDB")]
	[Address(RVA = "0x11F08EC", Offset = "0x11F08EC", VA = "0x11F08EC")]
	private void RefreshDailyBonusState()
	{
	}

	[Token(Token = "0x600DDDC")]
	[Address(RVA = "0x11F0C1C", Offset = "0x11F0C1C", VA = "0x11F0C1C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DDDD")]
	[Address(RVA = "0x11F0C24", Offset = "0x11F0C24", VA = "0x11F0C24")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
