using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C3D")]
public class UIHUDTrapActionController : UIBaseController
{
	[Token(Token = "0x4010DEE")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDTrapActionView m_View;

	[Token(Token = "0x4010DEF")]
	[FieldOffset(Offset = "0x2C")]
	private int m_RescureTrapID;

	[Token(Token = "0x4010DF0")]
	[FieldOffset(Offset = "0x30")]
	private bool m_IsBeginInTrapAnim;

	[Token(Token = "0x4010DF1")]
	[FieldOffset(Offset = "0x34")]
	private float m_InTrapEndTime;

	[Token(Token = "0x4010DF2")]
	[FieldOffset(Offset = "0x38")]
	private float m_TrapDuration;

	[Token(Token = "0x4010DF3")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_DelayRescureID;

	[Token(Token = "0x4010DF4")]
	[FieldOffset(Offset = "0x40")]
	private float m_ResucreEndTime;

	[Token(Token = "0x4010DF5")]
	[FieldOffset(Offset = "0x44")]
	private float m_ResucreUseTime;

	[Token(Token = "0x601270F")]
	[Address(RVA = "0x2221F64", Offset = "0x2221F64", VA = "0x2221F64")]
	public UIHUDTrapActionController()
	{
	}

	[Token(Token = "0x6012710")]
	[Address(RVA = "0x2222038", Offset = "0x2222038", VA = "0x2222038")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012711")]
	[Address(RVA = "0x22220E0", Offset = "0x22220E0", VA = "0x22220E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012712")]
	[Address(RVA = "0x22223C8", Offset = "0x22223C8", VA = "0x22223C8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012713")]
	[Address(RVA = "0x22224FC", Offset = "0x22224FC", VA = "0x22224FC")]
	public void ShowInTrap(float endTime, float totalTime)
	{
	}

	[Token(Token = "0x6012714")]
	[Address(RVA = "0x2222640", Offset = "0x2222640", VA = "0x2222640")]
	public void EnterTrapRescureTrigger(int trapID)
	{
	}

	[Token(Token = "0x6012715")]
	[Address(RVA = "0x22226DC", Offset = "0x22226DC", VA = "0x22226DC")]
	public void ExitTrapRescureTrigger()
	{
	}

	[Token(Token = "0x6012716")]
	[Address(RVA = "0x2222960", Offset = "0x2222960", VA = "0x2222960")]
	private bool IsInRescuring()
	{
		return default(bool);
	}

	[Token(Token = "0x6012717")]
	[Address(RVA = "0x2222A48", Offset = "0x2222A48", VA = "0x2222A48")]
	private void BeginRescure()
	{
	}

	[Token(Token = "0x6012718")]
	[Address(RVA = "0x222277C", Offset = "0x222277C", VA = "0x222277C")]
	private void CanclRescure()
	{
	}

	[Token(Token = "0x6012719")]
	[Address(RVA = "0x2222CC0", Offset = "0x2222CC0", VA = "0x2222CC0")]
	private void RequestServerRescure()
	{
	}

	[Token(Token = "0x601271A")]
	[Address(RVA = "0x2222DEC", Offset = "0x2222DEC", VA = "0x2222DEC")]
	private void OnCanclAction(object[] param)
	{
	}

	[Token(Token = "0x601271B")]
	[Address(RVA = "0x2222E64", Offset = "0x2222E64", VA = "0x2222E64")]
	private void Update()
	{
	}

	[Token(Token = "0x601271C")]
	[Address(RVA = "0x2222EE4", Offset = "0x2222EE4", VA = "0x2222EE4")]
	private void UpdateInTrapAnim()
	{
	}

	[Token(Token = "0x601271D")]
	[Address(RVA = "0x222302C", Offset = "0x222302C", VA = "0x222302C")]
	private void UpdateRescureAnim()
	{
	}

	[Token(Token = "0x601271E")]
	[Address(RVA = "0x2223198", Offset = "0x2223198", VA = "0x2223198")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601271F")]
	[Address(RVA = "0x22231A0", Offset = "0x22231A0", VA = "0x22231A0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
