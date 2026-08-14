using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C48")]
internal class UIHUDWereWolvesPrepareInfoController : UIBaseController
{
	[Token(Token = "0x4010E3B")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDWereWolvesPrepareInfoView m_View;

	[Token(Token = "0x4010E3C")]
	[FieldOffset(Offset = "0x2C")]
	private float m_EndTime;

	[Token(Token = "0x1700132C")]
	public float EndTime
	{
		[Token(Token = "0x601279B")]
		[Address(RVA = "0x1625FD4", Offset = "0x1625FD4", VA = "0x1625FD4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x601279A")]
	[Address(RVA = "0x1625F50", Offset = "0x1625F50", VA = "0x1625F50")]
	public UIHUDWereWolvesPrepareInfoController()
	{
	}

	[Token(Token = "0x601279C")]
	[Address(RVA = "0x162602C", Offset = "0x162602C", VA = "0x162602C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601279D")]
	[Address(RVA = "0x16260D4", Offset = "0x16260D4", VA = "0x16260D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601279E")]
	[Address(RVA = "0x16262D4", Offset = "0x16262D4", VA = "0x16262D4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601279F")]
	[Address(RVA = "0x1626408", Offset = "0x1626408", VA = "0x1626408")]
	public void OnCampInfoCome()
	{
	}

	[Token(Token = "0x60127A0")]
	[Address(RVA = "0x1626510", Offset = "0x1626510", VA = "0x1626510")]
	private void OnPhaseEndTimeCome(object[] param)
	{
	}

	[Token(Token = "0x60127A1")]
	[Address(RVA = "0x1626900", Offset = "0x1626900", VA = "0x1626900")]
	private void Update()
	{
	}

	[Token(Token = "0x60127A2")]
	[Address(RVA = "0x1626668", Offset = "0x1626668", VA = "0x1626668")]
	private void UpdateLeftTimeShow()
	{
	}

	[Token(Token = "0x60127A3")]
	[Address(RVA = "0x1626960", Offset = "0x1626960", VA = "0x1626960")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60127A4")]
	[Address(RVA = "0x1626968", Offset = "0x1626968", VA = "0x1626968")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
