using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023AA")]
public class UIHUDSingersBTipsController : UIBaseController
{
	[Token(Token = "0x400DE14")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDSingersBTipsView m_View;

	[Token(Token = "0x400DE15")]
	[FieldOffset(Offset = "0x2C")]
	private GameObject m_SpeedUpEffect;

	[Token(Token = "0x400DE16")]
	[FieldOffset(Offset = "0x30")]
	private SingersBTipsType tipsType;

	[Token(Token = "0x400DE17")]
	[FieldOffset(Offset = "0x34")]
	private float m_TotalTime;

	[Token(Token = "0x400DE18")]
	[FieldOffset(Offset = "0x38")]
	private float m_EndTime;

	[Token(Token = "0x400DE19")]
	[FieldOffset(Offset = "0x3C")]
	private int m_LastLeftTimeCeil;

	[Token(Token = "0x400DE1A")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsNeedUpdateOneSecond;

	[Token(Token = "0x600C894")]
	[Address(RVA = "0x22139DC", Offset = "0x22139DC", VA = "0x22139DC")]
	public UIHUDSingersBTipsController()
	{
	}

	[Token(Token = "0x600C895")]
	[Address(RVA = "0x2213A60", Offset = "0x2213A60", VA = "0x2213A60")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C896")]
	[Address(RVA = "0x2213B08", Offset = "0x2213B08", VA = "0x2213B08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C897")]
	[Address(RVA = "0x2213C58", Offset = "0x2213C58", VA = "0x2213C58")]
	public void ShowTips(bool show, SingersBTipsType tipType, float startTime = 0f)
	{
	}

	[Token(Token = "0x600C898")]
	[Address(RVA = "0x2214164", Offset = "0x2214164", VA = "0x2214164")]
	private void Update()
	{
	}

	[Token(Token = "0x600C899")]
	[Address(RVA = "0x22145F4", Offset = "0x22145F4", VA = "0x22145F4")]
	public void ChangeSpeed(object[] data)
	{
	}

	[Token(Token = "0x600C89A")]
	[Address(RVA = "0x2214988", Offset = "0x2214988", VA = "0x2214988")]
	private void _003CChangeSpeed_003Em__0()
	{
	}

	[Token(Token = "0x600C89B")]
	[Address(RVA = "0x2214A40", Offset = "0x2214A40", VA = "0x2214A40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
