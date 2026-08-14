using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x2002C47")]
public class UIHUDWereWolvesPredictToolCountDown : UIBaseController
{
	[Token(Token = "0x4010E39")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDWereWolvesPredictToolCountDownView m_View;

	[Token(Token = "0x4010E3A")]
	[FieldOffset(Offset = "0x2C")]
	private float m_EndTime;

	[Token(Token = "0x6012795")]
	[Address(RVA = "0x1483F9C", Offset = "0x1483F9C", VA = "0x1483F9C")]
	public UIHUDWereWolvesPredictToolCountDown()
	{
	}

	[Token(Token = "0x6012796")]
	[Address(RVA = "0x1484020", Offset = "0x1484020", VA = "0x1484020")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012797")]
	[Address(RVA = "0x1484088", Offset = "0x1484088", VA = "0x1484088", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012798")]
	[Address(RVA = "0x14840FC", Offset = "0x14840FC", VA = "0x14840FC")]
	public void RefreshEndTime(float endTime)
	{
	}

	[Token(Token = "0x6012799")]
	[Address(RVA = "0x1484104", Offset = "0x1484104", VA = "0x1484104")]
	private void LateUpdate()
	{
	}
}
