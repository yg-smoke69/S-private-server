using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022B9")]
public class UIHUDPVEHUDExitGameController : UIBaseController
{
	[Token(Token = "0x400D928")]
	[FieldOffset(Offset = "0x28")]
	private PVEHUDExitGameUIView m_View;

	[Token(Token = "0x400D929")]
	[FieldOffset(Offset = "0x2C")]
	private float closeEndTime;

	[Token(Token = "0x400D92A")]
	[FieldOffset(Offset = "0x30")]
	private Action m_CountDownEndCallback;

	[Token(Token = "0x400D92B")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsEnd;

	[Token(Token = "0x400D92C")]
	[FieldOffset(Offset = "0x38")]
	private TimeSpan m_TimeHelper;

	[Token(Token = "0x600BF03")]
	[Address(RVA = "0x1682C50", Offset = "0x1682C50", VA = "0x1682C50")]
	public UIHUDPVEHUDExitGameController()
	{
	}

	[Token(Token = "0x600BF04")]
	[Address(RVA = "0x1682CD4", Offset = "0x1682CD4", VA = "0x1682CD4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BF05")]
	[Address(RVA = "0x1682D7C", Offset = "0x1682D7C", VA = "0x1682D7C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BF06")]
	[Address(RVA = "0x1682ED8", Offset = "0x1682ED8", VA = "0x1682ED8")]
	public void InitData(float exitCountDown, Action countDownEndCallback)
	{
	}

	[Token(Token = "0x600BF07")]
	[Address(RVA = "0x1682F70", Offset = "0x1682F70", VA = "0x1682F70")]
	private void Update()
	{
	}

	[Token(Token = "0x600BF08")]
	[Address(RVA = "0x1683090", Offset = "0x1683090", VA = "0x1683090")]
	private string FormatTimeToString(float duration)
	{
		return null;
	}

	[Token(Token = "0x600BF09")]
	[Address(RVA = "0x168356C", Offset = "0x168356C", VA = "0x168356C")]
	private void OnExitClick()
	{
	}

	[Token(Token = "0x600BF0A")]
	[Address(RVA = "0x1683604", Offset = "0x1683604", VA = "0x1683604")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
