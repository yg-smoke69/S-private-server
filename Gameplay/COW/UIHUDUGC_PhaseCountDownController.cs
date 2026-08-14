using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200246A")]
public class UIHUDUGC_PhaseCountDownController : UIBaseController, _Attribute
{
	[Token(Token = "0x400E215")]
	[FieldOffset(Offset = "0x28")]
	private UIHUDUGC_PhaseCountDownView m_View;

	[Token(Token = "0x400E216")]
	[FieldOffset(Offset = "0x2C")]
	private PhaseCountDownHudEntity m_ViewData;

	[Token(Token = "0x400E217")]
	[FieldOffset(Offset = "0x30")]
	private UITimeLabelHelper m_TimeHelper;

	[Token(Token = "0x400E218")]
	[FieldOffset(Offset = "0x34")]
	private string m_EntityID;

	[Token(Token = "0x600CF3D")]
	[Address(RVA = "0x2E23764", Offset = "0x2E23764", VA = "0x2E23764")]
	public UIHUDUGC_PhaseCountDownController()
	{
	}

	[Token(Token = "0x600CF3E")]
	[Address(RVA = "0x2E237E8", Offset = "0x2E237E8", VA = "0x2E237E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CF3F")]
	[Address(RVA = "0x2E2388C", Offset = "0x2E2388C", VA = "0x2E2388C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CF40")]
	[Address(RVA = "0x2E23998", Offset = "0x2E23998", VA = "0x2E23998", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CF41")]
	[Address(RVA = "0x2E23A78", Offset = "0x2E23A78", VA = "0x2E23A78")]
	private void Update()
	{
	}

	[Token(Token = "0x600CF42")]
	[Address(RVA = "0x2E23AE4", Offset = "0x2E23AE4", VA = "0x2E23AE4", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CF43")]
	[Address(RVA = "0x2E23A04", Offset = "0x2E23A04", VA = "0x2E23A04", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CF44")]
	[Address(RVA = "0x2E23CBC", Offset = "0x2E23CBC", VA = "0x2E23CBC")]
	private void InitTimer()
	{
	}

	[Token(Token = "0x600CF45")]
	[Address(RVA = "0x2E23F84", Offset = "0x2E23F84", VA = "0x2E23F84")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CF46")]
	[Address(RVA = "0x2E2400C", Offset = "0x2E2400C", VA = "0x2E2400C")]
	private void OnBaseTimeChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF47")]
	[Address(RVA = "0x2E2408C", Offset = "0x2E2408C", VA = "0x2E2408C")]
	private void OnDurationTimeChanged(int old, int cur)
	{
	}

	[Token(Token = "0x600CF48")]
	[Address(RVA = "0x2E2410C", Offset = "0x2E2410C", VA = "0x2E2410C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CF49")]
	[Address(RVA = "0x2E24114", Offset = "0x2E24114", VA = "0x2E24114")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
