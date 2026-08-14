using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002711")]
internal class UIHudControlIntroInfoController : UIBaseController
{
	[Token(Token = "0x400F118")]
	[FieldOffset(Offset = "0x28")]
	private uint m_DelayCallId;

	[Token(Token = "0x600ED62")]
	[Address(RVA = "0x135FEA0", Offset = "0x135FEA0", VA = "0x135FEA0")]
	public UIHudControlIntroInfoController()
	{
	}

	[Token(Token = "0x600ED63")]
	[Address(RVA = "0x135FF24", Offset = "0x135FF24", VA = "0x135FF24")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600ED64")]
	[Address(RVA = "0x135FFC8", Offset = "0x135FFC8", VA = "0x135FFC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600ED65")]
	[Address(RVA = "0x1360110", Offset = "0x1360110", VA = "0x1360110", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600ED66")]
	[Address(RVA = "0x13602C0", Offset = "0x13602C0", VA = "0x13602C0")]
	private void OnControlPhaseChange(object[] data)
	{
	}

	[Token(Token = "0x600ED67")]
	[Address(RVA = "0x13604A8", Offset = "0x13604A8", VA = "0x13604A8")]
	private void _003COnControlPhaseChange_003Em__0()
	{
	}

	[Token(Token = "0x600ED68")]
	[Address(RVA = "0x1360588", Offset = "0x1360588", VA = "0x1360588")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ED69")]
	[Address(RVA = "0x1360590", Offset = "0x1360590", VA = "0x1360590")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
